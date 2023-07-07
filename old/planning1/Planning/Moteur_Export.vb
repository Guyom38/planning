Imports System.IO
Imports OfficeOpenXml
Imports OfficeOpenXml.Style
Imports Planning.Enums

Public Class Moteur_Export
    Private PLANNINGS As CL_Plannings
    Private MOTEUR As CL_Moteur

    Sub New(ByRef _m As CL_Moteur, ByRef _p As CL_Plannings)
        MOTEUR = _m
        PLANNINGS = _p
    End Sub

    Public Sub ExporterJPGS()
        Dim ancienMode As ENUM_Mode_Planning = PLANNINGS.DONNEES.Mode_Affichage
        Dim ancienPlanningSelect = PLANNINGS.DONNEES.Planning_Selection

        Dim d As New FolderBrowserDialog With {.ShowNewFolderButton = True}
        If d.ShowDialog = DialogResult.OK Then
            For Each p In PLANNINGS.DONNEES.Liste_Plannings
                Dim prefix As String = ""
                Select Case p.Value.Proprietaire
                    Case Enum_Cible.Classe : PLANNINGS.DONNEES.Mode_Affichage = ENUM_Mode_Planning.Classes : prefix = "classe"
                    Case Enum_Cible.Salle : PLANNINGS.DONNEES.Mode_Affichage = ENUM_Mode_Planning.Salles : prefix = "salle"
                    Case Enum_Cible.Enseignant : PLANNINGS.DONNEES.Mode_Affichage = ENUM_Mode_Planning.Enseignants : prefix = "prof"
                End Select
                MOTEUR.Met_a_jour_Les_Listes_Avec_Heures_ParRapport_ModeAffichage()

                PLANNINGS.DONNEES.Planning_Selection = p.Value.Nom
                PLANNINGS.Preparer_Grille("", True)
                PLANNINGS.GRILLE.Dessiner(d.SelectedPath & "\" & prefix & "_" & p.Value.Nom & ".jpg")
            Next
        End If

        ' // --- reviens a la config d'avant
        PLANNINGS.DONNEES.Mode_Affichage = ancienMode
        PLANNINGS.DONNEES.Planning_Selection = ancienPlanningSelect
        MOTEUR.Met_a_jour_Les_Listes_Avec_Heures_ParRapport_ModeAffichage()
        PLANNINGS.Preparer_Grille()
    End Sub

    Public Sub ExporterTableauxEnXLSX(ByVal cheminfichier As String, ByVal tableaux As List(Of Integer(,)))

        Dim ancienMode As ENUM_Mode_Planning = PLANNINGS.DONNEES.Mode_Affichage
        Dim ancienPlanningSelect = PLANNINGS.DONNEES.Planning_Selection


        Dim d As New SaveFileDialog With {.Title = "Exporter les plannings au format excel", .Filter = "*.xlsx|*.xlsx"}
        If d.ShowDialog = DialogResult.OK Then

            Try
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial ' Ou LicenseContext.Commercial selon votre cas
                Dim worksheet As ExcelWorksheet
                Using excelPackage As New ExcelPackage()

                    For Each p In PLANNINGS.DONNEES.Liste_Plannings
                        Dim prefix As String = "", prefix_excel As String = ""
                        Select Case p.Value.Proprietaire
                            Case Enum_Cible.Classe : PLANNINGS.DONNEES.Mode_Affichage = ENUM_Mode_Planning.Classes : prefix = "classe" : prefix_excel = "(C) "
                            Case Enum_Cible.Salle : PLANNINGS.DONNEES.Mode_Affichage = ENUM_Mode_Planning.Salles : prefix = "salle" : prefix_excel = "(S) "
                            Case Enum_Cible.Enseignant : PLANNINGS.DONNEES.Mode_Affichage = ENUM_Mode_Planning.Enseignants : prefix = "prof" : prefix_excel = "(P) "
                        End Select
                        MOTEUR.Met_a_jour_Les_Listes_Avec_Heures_ParRapport_ModeAffichage()

                        PLANNINGS.DONNEES.Planning_Selection = p.Value.Nom
                        PLANNINGS.Preparer_Grille("", True)

                        worksheet = excelPackage.Workbook.Worksheets.Add(prefix_excel & PLANNINGS.DONNEES.Planning_Selection)
                        worksheet.View.ShowGridLines = False
                        worksheet.View.ShowHeaders = False

                        With PLANNINGS.GRILLE
                            Dim largeurCellule As Integer = CInt((.img_grille.Width - (.decalageBord * 2)) / .DimensionX)
                            Dim hauteurCellule As Integer = CInt((.img_grille.Height - (.decalageBord * 2)) / .DimensionY)


                            For y = 0 To .DimensionY - 1
                                Dim lig As Integer = y + 1
                                worksheet.Row(lig).Height = 55

                                For x = 0 To .DimensionX - 1
                                    Dim col As Integer = x + 1
                                    worksheet.Column(col).Width = 20

                                    If .CELLULES(x, y) IsNot Nothing Then
                                        If .CELLULES(x, y).Init Then

                                            Dim largeurSimple As Integer = largeurCellule
                                            Dim hauteurSimple As Integer = hauteurCellule


                                            With .CELLULES(x, y)

                                                Dim texte As String = String.Join(Chr(10), .Texte)
                                                Dim couleur As Color = .Fond
                                                If x = 0 Or y = 0 Then couleur = PLANNINGS.DONNEES.COULEUR_ENTETES

                                                '  Dim couleur_actif As Boolean = .Fond
                                                worksheet.Cells(lig, col).Value = texte



                                                ' Fusionner des cellules horizontalement
                                                If Not (.FusionX = 1 And .FusionY = 1) Then
                                                    worksheet.Cells(lig, col, lig + .FusionY - 1, col + .FusionX - 1).Merge = True ' Fusionner les cellules de A1 à C1
                                                End If

                                                With worksheet.Cells(lig, col)
                                                    .Style.WrapText = True
                                                    .Style.VerticalAlignment = ExcelVerticalAlignment.Center
                                                    .Style.HorizontalAlignment = ExcelHorizontalAlignment.Center

                                                    .Style.Fill.PatternType = ExcelFillStyle.Solid
                                                    .Style.Fill.BackgroundColor.SetColor(couleur)

                                                    .Style.Border.Top.Style = ExcelBorderStyle.Medium
                                                    .Style.Border.Bottom.Style = ExcelBorderStyle.Medium
                                                    .Style.Border.Left.Style = ExcelBorderStyle.Medium
                                                    .Style.Border.Right.Style = ExcelBorderStyle.Medium
                                                End With

                                            End With
                                        End If
                                    End If
                                Next
                            Next
                        End With
                    Next

                    excelPackage.SaveAs(d.FileName)
                End Using


            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try


        End If

        PLANNINGS.DONNEES.Mode_Affichage = ancienMode
        PLANNINGS.DONNEES.Planning_Selection = ancienPlanningSelect
        MOTEUR.Met_a_jour_Les_Listes_Avec_Heures_ParRapport_ModeAffichage()
        PLANNINGS.Preparer_Grille()

    End Sub
End Class
