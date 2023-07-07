Imports Planning.Enums


Public Class Form1
    Public MOTEUR As New CL_Moteur(Me)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        MOTEUR.Initialisation(True)
    End Sub


    Public Sub Initialisation_Selection()
        ' Obj_Onglets.SelectedIndex = 1
        If Obj_Liste_Duree.Items.Count > 0 Then Obj_Liste_Duree.SelectedIndex = 1
        If Obj_Liste_Matieres.Items.Count > 0 Then Obj_Liste_Matieres.Items(0).Checked = True
        If Obj_Liste_Plannings.Items.Count > 0 Then Obj_Liste_Plannings.SelectedIndex = 0
        MOTEUR.PLANNINGS.DONNEES.Planning_Selection = Obj_Liste_Plannings.Text

    End Sub
    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If MOTEUR.PLANNINGS Is Nothing OrElse MOTEUR.PLANNINGS.GRILLE Is Nothing Then Exit Sub

        MOTEUR.PLANNINGS.GRILLE.Redimensionne_Image(Obj_Cadre.ClientSize.Width - 20, Obj_Cadre.ClientSize.Height)
    End Sub



    Private Sub Obj_Mode_Classes_Click(sender As Object, e As EventArgs) Handles Obj_Mode_Classes.Click
        MOTEUR.PLANNINGS.DONNEES.Mode_Affichage = ENUM_Mode_Planning.Classes
        MOTEUR.Met_a_jour_Les_Listes_Avec_Heures_ParRapport_ModeAffichage()

        If Obj_Liste_Plannings.Items.Count > 0 Then Obj_Liste_Plannings.SelectedIndex = 0
        MOTEUR.PLANNINGS.DONNEES.Planning_Selection = Obj_Liste_Plannings.Text
        MOTEUR.PLANNINGS.Preparer_Grille()
    End Sub

    Private Sub Obj_Mode_Salles_Click(sender As Object, e As EventArgs) Handles Obj_Mode_Salles.Click
        MOTEUR.PLANNINGS.DONNEES.Mode_Affichage = ENUM_Mode_Planning.Salles
        MOTEUR.Met_a_jour_Les_Listes_Avec_Heures_ParRapport_ModeAffichage()

        If Obj_Liste_Plannings.Items.Count > 0 Then Obj_Liste_Plannings.SelectedIndex = 0
        MOTEUR.PLANNINGS.DONNEES.Planning_Selection = Obj_Liste_Plannings.Text
        MOTEUR.PLANNINGS.Preparer_Grille()
    End Sub

    Private Sub Obj_Mode_Enseignants_Click(sender As Object, e As EventArgs) Handles Obj_Mode_Enseignants.Click
        MOTEUR.PLANNINGS.DONNEES.Mode_Affichage = ENUM_Mode_Planning.Enseignants
        MOTEUR.Met_a_jour_Les_Listes_Avec_Heures_ParRapport_ModeAffichage()

        If Obj_Liste_Plannings.Items.Count > 0 Then Obj_Liste_Plannings.SelectedIndex = 0
        MOTEUR.PLANNINGS.DONNEES.Planning_Selection = Obj_Liste_Plannings.Text
        MOTEUR.PLANNINGS.Preparer_Grille()
    End Sub

    Private Sub Obj_Liste_Plannings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Obj_Liste_Plannings.SelectedIndexChanged
        MOTEUR.PLANNINGS.DONNEES.Planning_Selection = Obj_Liste_Plannings.Text
        MOTEUR.PLANNINGS.Preparer_Grille()
    End Sub

    Private Sub Obj_Image_Click(sender As Object, e As EventArgs) Handles Obj_Image.Click
        MOTEUR.PLANNINGS.GRILLE.MOUSE = e
    End Sub
    Private Sub Obj_Image_MouseMove(sender As Object, e As MouseEventArgs) Handles Obj_Image.MouseMove
        MOTEUR.PLANNINGS.GRILLE.MOUSE2 = e
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MOTEUR.PLANNINGS.GRILLE.Dessiner()

        EnregistrerToolStripMenuItem.Enabled = (MOTEUR.PLANNINGS.Modification And Not MOTEUR.fichier = "")
        Me.Text = "Plannings Amandine" & CStr(IIf(MOTEUR.fichier = "", "", " ( " & MOTEUR.fichier & ")")) & CStr(IIf(MOTEUR.PLANNINGS.Modification, "*", ""))
    End Sub

    Private Sub Obj_Liste1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles Obj_Liste1.ItemCheck
        ' Désélectionne toutes les autres cases à cocher
        For Each item As ListViewItem In Obj_Liste1.Items
            If item IsNot Nothing Then
                If item.Index <> e.Index Then
                    item.Checked = False
                End If
            End If
        Next

    End Sub

    Private Sub Obj_Liste2_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles Obj_Liste2.ItemCheck
        ' Désélectionne toutes les autres cases à cocher
        For Each item As ListViewItem In Obj_Liste2.Items
            If item IsNot Nothing Then
                If item.Index <> e.Index Then
                    item.Checked = False
                End If
            End If
        Next
    End Sub



    Private Sub Obj_Liste2_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles Obj_Liste2.ItemChecked
        Coche_Liste2()
    End Sub
    Private Sub Coche_Liste2()
        If MOTEUR.PLANNINGS Is Nothing Then Exit Sub

        If Obj_Liste2.CheckedIndices.Count = 1 Then
            MOTEUR.PLANNINGS.DONNEES.Liste2_Selection = Obj_Liste2.CheckedItems(0).SubItems(1).Text
        Else
            MOTEUR.PLANNINGS.DONNEES.Liste2_Selection = ""
        End If
        MOTEUR.PLANNINGS.Preparer_Grille()
    End Sub
    Private Sub Obj_Liste1_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles Obj_Liste1.ItemChecked
        Coche_Liste1()

    End Sub
    Private Sub Coche_Liste1()
        If MOTEUR.PLANNINGS Is Nothing Then Exit Sub

        If Obj_Liste1.CheckedIndices.Count = 1 Then
            MOTEUR.PLANNINGS.DONNEES.Liste1_Selection = Obj_Liste1.CheckedItems(0).SubItems(1).Text
        Else
            MOTEUR.PLANNINGS.DONNEES.Liste1_Selection = ""
        End If
        MOTEUR.PLANNINGS.Preparer_Grille()
    End Sub
    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Quitter()
    End Sub

    Private Sub Quitter()
        '  PLANNINGS.Sauvegarder("test.json")

        Try
            My.Settings.fichier_en_cours = MOTEUR.fichier
            My.Settings.Save()

            Timer1.Enabled = False
            MOTEUR = Nothing
            GC.Collect()

            Threading.Thread.Sleep(1)


            End

        Catch ex As Exception
        End Try
    End Sub

    Private Sub NouveauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouveauToolStripMenuItem.Click

        Dim choix As MsgBoxResult = MsgBox("Voulez-vous conserver les classes, salles, enseignants ... ?", MsgBoxStyle.YesNoCancel)
        If choix = MsgBoxResult.Cancel Then Exit Sub
        MOTEUR.Initialisation()

        If choix = MsgBoxResult.No Then
            MOTEUR.Reinitialiser_Listes_Config()
        Else
            Mise_A_Jour_Plannings()
        End If

    End Sub

    Private Sub Obj_Bt_Normal_Click(sender As Object, e As EventArgs) Handles Obj_Bt_Normal.Click
        MOTEUR.PLANNINGS.DONNEES.Mode_Ecran = Enum_Ecran.Normal
        MOTEUR.PLANNINGS.GRILLE.Redimensionne_Image(Obj_Cadre.ClientSize.Width - 20, Obj_Cadre.ClientSize.Height)
    End Sub

    Private Sub Obj_Bt_PleinEcran_Click(sender As Object, e As EventArgs) Handles Obj_Bt_PleinEcran.Click
        MOTEUR.PLANNINGS.DONNEES.Mode_Ecran = Enum_Ecran.Etire
        MOTEUR.PLANNINGS.GRILLE.Redimensionne_Image(Obj_Cadre.ClientSize.Width - 20, Obj_Cadre.ClientSize.Height)
    End Sub

    Private Sub Boj_Bt_Zoom_Click(sender As Object, e As EventArgs) Handles Boj_Bt_Zoom.Click
        MOTEUR.PLANNINGS.DONNEES.Mode_Ecran = Enum_Ecran.Normal2x
        MOTEUR.PLANNINGS.GRILLE.Redimensionne_Image(Obj_Cadre.ClientSize.Width - 20, Obj_Cadre.ClientSize.Height)

    End Sub

    Public Function LISTE_CONTIENT(ByRef _liste As ListView, _texte As String) As Boolean
        For Each element As ListViewItem In _liste.Items
            If element.Text = _texte Then Return True
        Next
        Return False
    End Function
    Private Sub Ajouter_Liste(ByRef _liste As ListView, ByRef _zt As TextBox, _p As Enum_Cible)
        Dim element As String = Trim(_zt.Text)
        If element = "" Then MsgBox("Vous devez entrer une valeur. (20 caractères max.)", MsgBoxStyle.Exclamation) : Exit Sub

        Dim existe As Boolean = False
        For Each liste In {Obj_Liste_Config_Classes, Obj_Liste_Config_Enseignants, Obj_Liste_Config_Salles}
            If LISTE_CONTIENT(liste, element) Then existe = True : Exit For
        Next

        If Not existe Then

            _liste.Items.Add(element)
            MOTEUR.PLANNINGS.Modification = True
            If Not _p = Enum_Cible.Matiere Then
                MOTEUR.PLANNINGS.DONNEES.Liste_Plannings.Add(element, New Objet_Planning(_p, element))
            Else
                MOTEUR.PLANNINGS.DONNEES.Liste_Matieres.Add(element, New CL_Plannings.CL_DONNEES.CL_Matiere With {.Nombre_Heures = 0})
            End If
            MOTEUR.Met_a_jour_Les_Listes_Avec_Heures_ParRapport_ModeAffichage()


            Initialisation_Selection()
            ' Obj_Onglets.SelectedIndex = 1

            '  MsgBox("Planning ajouté. (" & _zt.Text & ")", MsgBoxStyle.Information)
            _zt.Text = ""

        Else
            MsgBox("L'élement existe deja dans une des listes. (" & element & ")", MsgBoxStyle.Exclamation)
        End If


    End Sub
    Private Sub Retirer_Liste(ByRef _liste As ListView)
        If _liste.SelectedIndices.Count = 1 Then
            Dim index As ListViewItem = _liste.SelectedItems(0)
            _liste.Items.Remove(index)
            MOTEUR.PLANNINGS.Modification = True
        Else
            MsgBox("Selectionnez un element pour le supprimer.", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub Obj_Bt_Ajouter_Enseignant_Click(sender As Object, e As EventArgs) Handles Obj_Bt_Ajouter_Enseignant.Click
        Ajouter_Liste(Obj_Liste_Config_Enseignants, Obj_Zt_Enseignant, Enum_Cible.Enseignant)
    End Sub

    Private Sub Obj_Bt_Retirer_Enseignant_Click(sender As Object, e As EventArgs) Handles Obj_Bt_Retirer_Enseignant.Click
        Retirer_Liste(Obj_Liste_Config_Enseignants)
    End Sub

    Private Sub Obj_Bt_Ajouter_Classe_Click(sender As Object, e As EventArgs) Handles Obj_Bt_Ajouter_Classe.Click
        Ajouter_Liste(Obj_Liste_Config_Classes, Obj_Zt_Classe, Enum_Cible.Classe)
    End Sub

    Private Sub Obj_Bt_Retirer_Classe_Click(sender As Object, e As EventArgs) Handles Obj_Bt_Retirer_Classe.Click
        Retirer_Liste(Obj_Liste_Config_Classes)

    End Sub

    Private Sub Obj_Bt_Ajouter_Salle_Click(sender As Object, e As EventArgs) Handles Obj_Bt_Ajouter_Salle.Click
        Ajouter_Liste(Obj_Liste_Config_Salles, Obj_Zt_Salle, Enum_Cible.Salle)
    End Sub

    Private Sub Obj_Bt_Retirer_Salle_Click(sender As Object, e As EventArgs) Handles Obj_Bt_Retirer_Salle.Click
        Retirer_Liste(Obj_Liste_Config_Salles)

    End Sub

    Private Sub Obj_Bt_Ajouter_Matiere_Click(sender As Object, e As EventArgs) Handles Obj_Bt_Ajouter_Matiere.Click
        Ajouter_Liste(Obj_Liste_Config_Matieres, Obj_Zt_Matiere, Enum_Cible.Matiere)
    End Sub

    Private Sub Obj_Bt_Retirer_Matiere_Click(sender As Object, e As EventArgs) Handles Obj_Bt_Retirer_Matiere.Click
        Retirer_Liste(Obj_Liste_Config_Matieres)

    End Sub

    Private Sub ChargerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChargerToolStripMenuItem.Click
        Try
            Dim d As New OpenFileDialog With {.Title = "Charger des plannings ...", .Filter = "*.json|*.json"}
            If d.ShowDialog = DialogResult.OK Then

                MOTEUR.PLANNINGS.Charger(d.FileName)

            End If
        Catch ex As Exception
            MsgBox("Une erreur serieuse s'est produite." & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub EnregistrersousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrersousToolStripMenuItem.Click
        Try
            Dim d As New SaveFileDialog With {.Title = "Enregistrer des plannings ...", .Filter = "*.json|*.json"}
            If d.ShowDialog = DialogResult.OK Then
                MOTEUR.PLANNINGS.Sauvegarder(d.FileName)
                MOTEUR.fichier = d.FileName

            End If
        Catch ex As Exception
            MsgBox("Une erreur serieuse s'est produite." & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub EnregistrerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerToolStripMenuItem.Click
        If Not MOTEUR.fichier = "" Then
            MOTEUR.PLANNINGS.Sauvegarder(MOTEUR.fichier)
        End If
    End Sub

    Private Sub Obj_Valider_Matieres_Click(sender As Object, e As EventArgs) Handles Obj_Valider_Matieres.Click
        MOTEUR.PLANNINGS.DONNEES.Liste_Matieres.Clear()
        For Each element As ListViewItem In Obj_Liste_Config_Matieres.Items
            MOTEUR.PLANNINGS.DONNEES.Liste_Matieres.Add(element.Text, New CL_Plannings.CL_DONNEES.CL_Matiere)
        Next
        MOTEUR.Met_A_Jour_La_Liste_des_Matieres_Avec_Heures()

    End Sub

    Private Sub Obj_Bt_Reinitialiser_Click(sender As Object, e As EventArgs) Handles Obj_Bt_Reinitialiser.Click
        Mise_A_Jour_Plannings()
        Obj_Onglets.SelectedIndex = 1
    End Sub

    Public Sub Mise_A_Jour_Plannings()

        MOTEUR.PLANNINGS.DONNEES.Liste_Plannings.Clear()
        Debug.Print("Réinitialisation des plannings")
        For Each p As Enum_Cible In {Enum_Cible.Classe, Enum_Cible.Enseignant, Enum_Cible.Salle}
            Debug.Print("   + " & p.ToString)
            Dim liste As ListView = Nothing
            Select Case p
                Case Enum_Cible.Classe : liste = Obj_Liste_Config_Classes
                Case Enum_Cible.Enseignant : liste = Obj_Liste_Config_Enseignants
                Case Enum_Cible.Salle : liste = Obj_Liste_Config_Salles
            End Select

            For Each element As ListViewItem In liste.Items
                Debug.Print("       + Planning (" & element.Text & ")")
                MOTEUR.PLANNINGS.DONNEES.Liste_Plannings.Add(element.Text, New Objet_Planning(p, element.Text))
            Next
        Next

        MOTEUR.PLANNINGS.DONNEES.Liste_Matieres.Clear()
        For Each element As ListViewItem In Obj_Liste_Config_Matieres.Items
            MOTEUR.PLANNINGS.DONNEES.Liste_Matieres.Add(element.Text, New CL_Plannings.CL_DONNEES.CL_Matiere)
        Next

        MOTEUR.Met_a_jour_Les_Listes_Avec_Heures_ParRapport_ModeAffichage()
        Initialisation_Selection()

        MOTEUR.PLANNINGS.Modification = True
    End Sub


    Private Sub Obj_Zt_Enseignant_KeyDown(sender As Object, e As KeyEventArgs) Handles Obj_Zt_Enseignant.KeyDown
        If e.KeyCode = Keys.Enter Then
            Ajouter_Liste(Obj_Liste_Config_Enseignants, CType(sender, TextBox), Enum_Cible.Enseignant)
        End If
    End Sub

    Private Sub Obj_Zt_Classe_KeyDown(sender As Object, e As KeyEventArgs) Handles Obj_Zt_Classe.KeyDown
        If e.KeyCode = Keys.Enter Then
            Ajouter_Liste(Obj_Liste_Config_Classes, CType(sender, TextBox), Enum_Cible.Classe)
        End If
    End Sub

    Private Sub Obj_Zt_Salle_KeyDown(sender As Object, e As KeyEventArgs) Handles Obj_Zt_Salle.KeyDown
        If e.KeyCode = Keys.Enter Then
            Ajouter_Liste(Obj_Liste_Config_Salles, CType(sender, TextBox), Enum_Cible.Salle)
        End If
    End Sub

    Private Sub Obj_Zt_Matiere_KeyDown(sender As Object, e As KeyEventArgs) Handles Obj_Zt_Matiere.KeyDown
        If e.KeyCode = Keys.Enter Then
            Ajouter_Liste(Obj_Liste_Config_Matieres, CType(sender, TextBox), Enum_Cible.Matiere)
        End If
    End Sub

    Private Sub ExporterJPGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExporterJPGToolStripMenuItem.Click
        MOTEUR.EXPORT.ExporterJPGS()
    End Sub

    Private Sub ExporterHTMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExporterHTMLToolStripMenuItem.Click
        With MOTEUR.PLANNINGS.GRILLE
            Dim largeurCellule As Integer = CInt((.img_grille.Width - (.decalageBord * 2)) / (.CELLULES.GetLength(0)))
            Dim hauteurCellule As Integer = CInt((.img_grille.Height - (.decalageBord * 2)) / (.CELLULES.GetLength(1)))


            For y = 0 To .CELLULES.GetLength(1) - 1
                For x = 0 To .CELLULES.GetLength(0) - 1
                    If .CELLULES(x, y) IsNot Nothing Then
                        If .CELLULES(x, y).Init Then

                            Dim largeurSimple As Integer = largeurCellule
                            Dim hauteurSimple As Integer = hauteurCellule

                            If Not .CELLULES(x, y).FusionX = 1 Then largeurSimple = largeurCellule * .CELLULES(x, y).FusionX
                            If Not .CELLULES(x, y).FusionY = 1 Then hauteurSimple = hauteurCellule * .CELLULES(x, y).FusionY

                            Dim xPos As Integer = .decalageBord + (x * largeurCellule)
                            Dim yPos As Integer = .decalageBord + (y * hauteurCellule)
                            Dim wLargeur As Integer = largeurSimple - .espaceEntreCellules
                            Dim hHauteur As Integer = hauteurSimple - .espaceEntreCellules

                            ' .Cellule(img_gr, xPos, yPos, wLargeur, hHauteur, .CELLULES(x, y))
                        End If
                    End If
                Next
            Next
        End With
    End Sub



    Private Sub ExporterCSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExporterCSVToolStripMenuItem.Click


        ' Exporter les tableaux en XLSX
        MOTEUR.EXPORT.ExporterTableauxEnXLSX("chemin_vers_fichier.xlsx", Nothing)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Quitter()
    End Sub

    Private Sub Obj_Bt_Calcul_Temps_Click(sender As Object, e As EventArgs) Handles Obj_Bt_Calcul_Temps.Click
        MOTEUR.PLANNINGS.ReCalcul_Heures()

    End Sub

    Private Sub Obj_Liste_Mattieres_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Obj_Liste_Matieres.SelectedIndexChanged

    End Sub

    Private Sub Obj_Liste_Mattieres_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles Obj_Liste_Matieres.ItemCheck
        ' Désélectionne toutes les autres cases à cocher
        For Each item As ListViewItem In Obj_Liste_Matieres.Items
            If item IsNot Nothing Then
                If item.Index <> e.Index Then
                    item.Checked = False
                End If
            End If
        Next
    End Sub

    Private Sub Obj_Liste_Mattieres_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles Obj_Liste_Matieres.ItemChecked
        If MOTEUR.PLANNINGS Is Nothing Then Exit Sub

        If Obj_Liste_Matieres.CheckedIndices.Count = 1 Then
            MOTEUR.PLANNINGS.DONNEES.Matiere_Selection = Obj_Liste_Matieres.CheckedItems(0).SubItems(1).Text
        Else
            MOTEUR.PLANNINGS.DONNEES.Matiere_Selection = ""
        End If
    End Sub

    Private Sub SOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SOSToolStripMenuItem.Click
        Try
            Dim d As New OpenFileDialog With {.Title = "Charger des plannings ...", .Filter = "*.json|*.json"}
            If d.ShowDialog = DialogResult.OK Then
                MOTEUR.Initialisation()
                MOTEUR.PLANNINGS.Charger_SOS(d.FileName)

            End If
        Catch ex As Exception
            MsgBox("Une erreur serieuse s'est produite." & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ChargerListesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChargerListesToolStripMenuItem.Click
        Dim d As New OpenFileDialog With {.Title = "Charger des plannings ...", .Filter = "*.txt|*.txt"}
        If d.ShowDialog = DialogResult.OK Then
            MOTEUR.Initialisation()

            Obj_Liste_Config_Enseignants.Items.Clear()
            Obj_Liste_Config_Classes.Items.Clear()
            Obj_Liste_Config_Matieres.Items.Clear()
            Obj_Liste_Config_Salles.Items.Clear()

            Dim monStreamReader As New IO.StreamReader(Replace(d.FileName, ".json", ".txt"))
            Dim ligne As String = ""
            Do
                ligne = monStreamReader.ReadLine()
                If ligne IsNot Nothing Then
                    Dim bloc As String() = Split(ligne, ",")
                    Select Case bloc(0)
                        Case "Classe" : Obj_Liste_Config_Classes.Items.Add(bloc(1))
                        Case "Salle" : Obj_Liste_Config_Salles.Items.Add(bloc(1))
                        Case "Enseignant" : Obj_Liste_Config_Enseignants.Items.Add(bloc(1))
                        Case "Matiere" : Obj_Liste_Config_Matieres.Items.Add(bloc(1)) 'MOTEUR.PLANNINGS.DONNEES.Liste_Matieres.Add(bloc(1), New CL_Plannings.CL_DONNEES.CL_Matiere)
                    End Select
                End If
            Loop Until ligne Is Nothing


            Mise_A_Jour_Plannings()
        End If


    End Sub

    Private Sub Obj_Liste_Config_Enseignants_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Obj_Liste_Config_Enseignants.SelectedIndexChanged

    End Sub

    Private Sub Obj_Liste_Config_Enseignants_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles Obj_Liste_Config_Enseignants.ItemCheck

    End Sub

    Private Sub Obj_Liste1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Obj_Liste1.SelectedIndexChanged
        If Obj_Liste1.CheckedIndices.Count = 0 Then
            MOTEUR.PLANNINGS.DONNEES.Liste1_Selection = ""
            MOTEUR.PLANNINGS.Preparer_Grille()
        End If

    End Sub
    Private Sub Obj_Liste2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Obj_Liste2.SelectedIndexChanged
        If Obj_Liste2.CheckedIndices.Count = 0 Then
            MOTEUR.PLANNINGS.DONNEES.Liste2_Selection = ""
            MOTEUR.PLANNINGS.Preparer_Grille()
        End If

    End Sub
End Class
