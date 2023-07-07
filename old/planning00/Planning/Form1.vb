Public Class Form1
    Public PLANNINGS As CL_Plannings
    Private Sub Initialisation_Grille()

        Obj_Grille.Rows.Clear()
        For Each jour In CL_Plannings.LISTE_JOURS
            Obj_Grille.Columns.Add(jour.ToString, jour.ToString)
        Next

        For Each Heure In CL_Plannings.LISTE_HEURES
            Dim row As DataGridViewRow = New DataGridViewRow()
            row.Height = 30
            Obj_Grille.Rows.Add(row)
            Obj_Grille.Rows(Obj_Grille.Rows.Count - 1).HeaderCell.Value = Heure
        Next

        ' Ajuster l'apparence du DataGridView
        Obj_Grille.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Obj_Grille.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Obj_Grille.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None

        Obj_Grille.AllowUserToAddRows = False
        '    Obj_Grille.SelectionMode = DataGridViewSelectionMode.CellSelect

    End Sub

    Public Sub Afficher_Grille(Optional nom_planning As String = "")
        Me.Text = Obj_Liste_Plannings.Text

        If nom_planning = "" Then
            nom_planning = Obj_Liste_Plannings.Text
        End If

        If Not PLANNINGS.Liste_Plannings.ContainsKey(nom_planning) Then
            MsgBox("Le planning du nom : " & nom_planning & " n'existe pas.")
            Exit Sub
        End If

        Dim planning_select As CL_Plannings.Planning = PLANNINGS.Liste_Plannings(nom_planning)

        For h = 0 To CL_Plannings.LISTE_HEURES.Count - 1
            Dim heure As String = CL_Plannings.LISTE_HEURES(h)

            For j = 0 To CL_Plannings.LISTE_JOURS.Count - 1
                Dim jour As String = CL_Plannings.LISTE_JOURS(j)
                Dim c As Color = Color.White
                If planning_select.Liste_Creneaux.ContainsKey(jour & " " & heure) Then
                    Dim valeur As CL_Plannings.LienTri = planning_select.Liste_Creneaux(jour & " " & heure)

                    Obj_Grille.Rows(h).Cells(j).Value = valeur.Valeur
                    Obj_Grille.Rows(h).Cells(j).Style.WrapMode = DataGridViewTriState.True
                    Obj_Grille.Rows(h).Cells(j).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    If Not Trim(valeur.Valeur) = "" Then c = Color.LightGreen
                End If

                Obj_Grille.Rows(h).Cells(j).Style.BackColor = c
            Next
        Next

        '  Obj_Grille.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        '  Obj_Grille.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '  Obj_Grille.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None

        '  Obj_Grille.AllowUserToAddRows = False
        'Obj_Grille.SelectionMode = DataGridViewSelectionMode.CellSelect

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Affecter_Valeurs()
    End Sub



    Public Enum ENUM_Mode_Planning
        Classes
        Salles
        Enseignants
    End Enum
    Public Mode_Affichage As ENUM_Mode_Planning = ENUM_Mode_Planning.Classes

    Private Sub Obj_Mode_Classes_Click(sender As Object, e As EventArgs) Handles Obj_Mode_Classes.Click
        Mode_Affichage = ENUM_Mode_Planning.Classes
        Configuration_Planning()

        Obj_Liste_Plannings.SelectedIndex = 0
        Afficher_Grille()

    End Sub

    Private Sub Obj_Mode_Salles_Click(sender As Object, e As EventArgs) Handles Obj_Mode_Salles.Click
        Mode_Affichage = ENUM_Mode_Planning.Salles
        Configuration_Planning()

        Obj_Liste_Plannings.SelectedIndex = 0
        Afficher_Grille()
    End Sub

    Private Sub Obj_Mode_Enseignants_Click(sender As Object, e As EventArgs) Handles Obj_Mode_Enseignants.Click
        Mode_Affichage = ENUM_Mode_Planning.Enseignants
        Configuration_Planning()

        Obj_Liste_Plannings.SelectedIndex = 0
        Afficher_Grille()
    End Sub


    Public Sub Configuration_Planning()
        Select Case Mode_Affichage
            Case ENUM_Mode_Planning.Classes : Repartition_Elements_Planning(CL_Plannings.Enum_Cible.Classe, CL_Plannings.Enum_Cible.Salle, CL_Plannings.Enum_Cible.Enseignant)
            Case ENUM_Mode_Planning.Salles : Repartition_Elements_Planning(CL_Plannings.Enum_Cible.Salle, CL_Plannings.Enum_Cible.Classe, CL_Plannings.Enum_Cible.Enseignant)
            Case ENUM_Mode_Planning.Enseignants : Repartition_Elements_Planning(CL_Plannings.Enum_Cible.Enseignant, CL_Plannings.Enum_Cible.Classe, CL_Plannings.Enum_Cible.Salle)
        End Select

    End Sub

    Public Sub Repartition_Elements_Planning(_choix As CL_Plannings.Enum_Cible, _liste1 As CL_Plannings.Enum_Cible, _liste2 As CL_Plannings.Enum_Cible)
        Obj_Liste2.Items.Clear()
        Obj_Liste1.Items.Clear()
        Obj_Liste_Plannings.Items.Clear()

        For Each element In PLANNINGS.Liste_Plannings
            Select Case element.Value.Proprietaire
                Case _liste2
                    With Obj_Liste2
                        Select Case _liste2
                            Case CL_Plannings.Enum_Cible.Classe : .Columns(1).Text = "Classe"
                            Case CL_Plannings.Enum_Cible.Salle : .Columns(1).Text = "Salle"
                            Case CL_Plannings.Enum_Cible.Enseignant : .Columns(1).Text = "Enseignant"
                        End Select
                        With .Items.Add("")
                            .SubItems.Add(element.Value.Nom)
                            .SubItems.Add("0")
                        End With
                    End With

                Case _liste1
                    With Obj_Liste1
                        Select Case _liste1
                            Case CL_Plannings.Enum_Cible.Classe : .Columns(1).Text = "Classe"
                            Case CL_Plannings.Enum_Cible.Salle : .Columns(1).Text = "Salle"
                            Case CL_Plannings.Enum_Cible.Enseignant : .Columns(1).Text = "Enseignant"
                        End Select
                        With .Items.Add("")
                            .SubItems.Add(element.Value.Nom)
                            .SubItems.Add("0")
                        End With
                    End With

                Case _choix
                    Obj_Liste_Plannings.Items.Add(element.Value.Nom)
            End Select
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Affecter_Valeurs(True)
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        PLANNINGS = New CL_Plannings
        Initialisation_Grille()
    End Sub

    Private Sub Obj_Liste_Plannings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Obj_Liste_Plannings.SelectedIndexChanged
        Afficher_Grille()
    End Sub

    Public Function Affecter(_planning As String, _jourheure As String, _classe As String, _salle As String, _enseignant As String) As Boolean
        If Not PLANNINGS.Liste_Plannings.ContainsKey(_planning) Then Return False
        If Not PLANNINGS.Liste_Plannings(_planning).Liste_Creneaux.ContainsKey(_jourheure) Then Return False

        With PLANNINGS.Liste_Plannings(_planning).Liste_Creneaux(_jourheure)
            .Classe = _classe
            .Salle = _salle
            .Enseignant = _enseignant

            Select Case PLANNINGS.Liste_Plannings(_planning).Proprietaire
                Case CL_Plannings.Enum_Cible.Classe : .Valeur = .Salle & vbCrLf & .Enseignant
                Case CL_Plannings.Enum_Cible.Salle : .Valeur = .Classe & vbCrLf & .Enseignant
                Case CL_Plannings.Enum_Cible.Enseignant : .Valeur = .Classe & vbCrLf & .Salle
            End Select


        End With

        Return True
    End Function
    Public Sub Affecter_Valeurs(Optional effacer As Boolean = False)

        Dim nom_choix As String = Obj_Liste_Plannings.Text

        Dim celluleSelect As DataGridViewCell = Obj_Grille.SelectedCells(0)
        Dim ligne As Integer = celluleSelect.RowIndex
        Dim colonne As Integer = celluleSelect.ColumnIndex

        Dim jour As String = CL_Plannings.LISTE_JOURS(colonne)
        Dim heure As String = CL_Plannings.LISTE_HEURES(ligne)


        If Obj_Liste2.SelectedIndices.Count < 0 Or Obj_Liste1.SelectedIndices.Count < 0 Then
                MsgBox("Veuillez selectionner le créneau, ainsi que les élements a associer.")
                Exit Sub
            End If

                Dim nom_liste2 As String = Obj_Liste2.SelectedItems(0).SubItems(1).Text
                Dim nom_liste1 As String = Obj_Liste1.SelectedItems(0).SubItems(1).Text

        Dim horaire As String = jour & " " & heure
        With PLANNINGS.Liste_Plannings(nom_choix).Liste_Creneaux(horaire)
            Select Case Mode_Affichage
                Case ENUM_Mode_Planning.Classes
                    .Classe = nom_choix
                    .Salle = nom_liste1
                    .Enseignant = nom_liste2

                    Affecter(.Enseignant, horaire, .Classe, .Salle, .Enseignant)
                    Affecter(.Salle, horaire, .Classe, .Salle, .Enseignant)

                Case ENUM_Mode_Planning.Salles
                    .Classe = nom_liste1
                    .Salle = nom_choix
                    .Enseignant = nom_liste2

                    Affecter(.Enseignant, horaire, .Classe, .Salle, .Enseignant)
                    Affecter(.Classe, horaire, .Classe, .Salle, .Enseignant)

                Case ENUM_Mode_Planning.Enseignants
                    .Classe = nom_liste1
                    .Salle = nom_liste2
                    .Enseignant = nom_choix

                    Affecter(.Classe, horaire, .Classe, .Salle, .Enseignant)
                    Affecter(.Salle, horaire, .Classe, .Salle, .Enseignant)
            End Select
            .Valeur = nom_liste1 & vbCrLf & nom_liste2
        End With


        Afficher_Grille(nom_choix)

        '  Obj_Grille.Rows(ligne).Cells(colonne).Value = nom_salle & vbCrLf & nom_enseignant
        '  Obj_Grille.Rows(ligne).Cells(colonne).Style.WrapMode = DataGridViewTriState.True
        '  Obj_Grille.Rows(ligne).Height = Obj_Grille.Rows(ligne).GetPreferredHeight(ligne, DataGridViewAutoSizeRowMode.AllCells, True)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
