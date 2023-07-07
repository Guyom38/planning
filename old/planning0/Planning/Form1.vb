Imports Planning.CL_Plannings
Imports Planning.Enums

Public Class Form1
    Public PLANNINGS As CL_Plannings


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PLANNINGS.Affecter_Valeurs()
    End Sub


    Private Sub Obj_Mode_Classes_Click(sender As Object, e As EventArgs) Handles Obj_Mode_Classes.Click
        PLANNINGS.Mode_Affichage = ENUM_Mode_Planning.Classes
        Configuration_Planning()

        Obj_Liste_Plannings.SelectedIndex = 0
        PLANNINGS.Planning_Selection = Obj_Liste_Plannings.Text
        PLANNINGS.Preparer_Grille()

    End Sub

    Private Sub Obj_Mode_Salles_Click(sender As Object, e As EventArgs) Handles Obj_Mode_Salles.Click
        PLANNINGS.Mode_Affichage = ENUM_Mode_Planning.Salles
        Configuration_Planning()

        Obj_Liste_Plannings.SelectedIndex = 0
        PLANNINGS.Planning_Selection = Obj_Liste_Plannings.Text
        PLANNINGS.Preparer_Grille()
    End Sub

    Private Sub Obj_Mode_Enseignants_Click(sender As Object, e As EventArgs) Handles Obj_Mode_Enseignants.Click
        PLANNINGS.Mode_Affichage = ENUM_Mode_Planning.Enseignants
        Configuration_Planning()

        Obj_Liste_Plannings.SelectedIndex = 0
        PLANNINGS.Planning_Selection = Obj_Liste_Plannings.Text
        PLANNINGS.Preparer_Grille()
    End Sub


    Public Sub Configuration_Planning()
        Select Case PLANNINGS.Mode_Affichage
            Case ENUM_Mode_Planning.Classes : Repartition_Elements_Planning(Enum_Cible.Classe, Enum_Cible.Salle, Enum_Cible.Enseignant)
            Case ENUM_Mode_Planning.Salles : Repartition_Elements_Planning(Enum_Cible.Salle, Enum_Cible.Classe, Enum_Cible.Enseignant)
            Case ENUM_Mode_Planning.Enseignants : Repartition_Elements_Planning(Enum_Cible.Enseignant, Enum_Cible.Classe, Enum_Cible.Salle)
        End Select

    End Sub

    Public Sub Repartition_Elements_Planning(_choix As Enum_Cible, _liste1 As Enum_Cible, _liste2 As Enum_Cible)
        Obj_Liste2.Items.Clear()
        Obj_Liste1.Items.Clear()
        Obj_Liste_Plannings.Items.Clear()

        For Each element In PLANNINGS.Liste_Plannings

            Select Case element.Value.Proprietaire
                Case _liste2
                    With Obj_Liste2

                        Select Case _liste2
                            Case Enum_Cible.Classe : .Columns(1).Text = "Classe"
                            Case Enum_Cible.Salle : .Columns(1).Text = "Salle"
                            Case Enum_Cible.Enseignant : .Columns(1).Text = "Enseignant"
                        End Select
                        With .Items.Add("")
                            .UseItemStyleForSubItems = False
                            .SubItems.Add(element.Value.Nom)
                            .SubItems.Add(element.Value.Nombre_Heures.ToString)
                            If Not element.Value.Couleur = Nothing Then .BackColor = element.Value.Couleur
                        End With
                    End With

                Case _liste1
                    With Obj_Liste1
                        Select Case _liste1
                            Case Enum_Cible.Classe : .Columns(1).Text = "Classe"
                            Case Enum_Cible.Salle : .Columns(1).Text = "Salle"
                            Case Enum_Cible.Enseignant : .Columns(1).Text = "Enseignant"
                        End Select
                        With .Items.Add("")
                            .UseItemStyleForSubItems = False
                            .SubItems.Add(element.Value.Nom)
                            .SubItems.Add(element.Value.Nombre_Heures.ToString)
                            If Not element.Value.Couleur = Nothing Then .BackColor = element.Value.Couleur
                        End With
                    End With

                Case _choix
                    Obj_Liste_Plannings.Items.Add(element.Value.Nom)
            End Select
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PLANNINGS.Affecter_Valeurs(True)
        Configuration_Planning()

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Obj_Onglets.SelectedIndex = 1
        Obj_Nb_Heures.SelectedIndex = 1
        Obj_Liste_Matiere.SelectedIndex = 1

        PLANNINGS.Mode_Affichage = ENUM_Mode_Planning.Classes
        Configuration_Planning()

        Obj_Liste_Plannings.SelectedIndex = 0
        PLANNINGS.Planning_Selection = Obj_Liste_Plannings.Text
        PLANNINGS.Preparer_Grille()

    End Sub

    Private Sub Obj_Liste_Plannings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Obj_Liste_Plannings.SelectedIndexChanged
        PLANNINGS.Planning_Selection = Obj_Liste_Plannings.Text
        PLANNINGS.Preparer_Grille()
    End Sub

    Private Sub Obj_Liste1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Obj_Liste1.SelectedIndexChanged


    End Sub

    Private Sub Obj_Liste2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Obj_Liste2.SelectedIndexChanged

    End Sub



    Private Sub Obj_Image_Click(sender As Object, e As EventArgs) Handles Obj_Image.Click
        PLANNINGS.MOUSE = e
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PLANNINGS.Dessiner_Grille()

    End Sub

    Private Sub Obj_Liste1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles Obj_Liste1.ItemCheck
        ' Désélectionne toutes les autres cases à cocher
        For Each item As ListViewItem In Obj_Liste1.Items
            If item.Index <> e.Index Then
                item.Checked = False
            End If
        Next

    End Sub

    Private Sub Obj_Liste2_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles Obj_Liste2.ItemCheck
        ' Désélectionne toutes les autres cases à cocher
        For Each item As ListViewItem In Obj_Liste2.Items
            If item.Index <> e.Index Then
                item.Checked = False
            End If
        Next


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PLANNINGS = New CL_Plannings

    End Sub

    Private Sub Obj_Liste2_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles Obj_Liste2.ItemChecked
        If PLANNINGS Is Nothing Then Exit Sub
        If Obj_Liste2.CheckedIndices.Count = 1 Then
            PLANNINGS.Liste2_Selection = Obj_Liste2.CheckedItems(0).SubItems(1).Text
            PLANNINGS.Preparer_Grille()
        Else
            PLANNINGS.Liste2_Selection = ""
        End If
    End Sub

    Private Sub Obj_Liste1_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles Obj_Liste1.ItemChecked
        If PLANNINGS Is Nothing Then Exit Sub

        If Obj_Liste1.CheckedItems.Count = 1 Then
            PLANNINGS.Liste1_Selection = Obj_Liste1.CheckedItems(0).SubItems(1).Text
        Else
            PLANNINGS.Liste1_Selection = ""
        End If
    End Sub

    Private Sub Obj_Opt_Gr1_CheckedChanged(sender As Object, e As EventArgs) Handles Obj_Opt_Gr1.CheckedChanged
        If PLANNINGS Is Nothing Then Exit Sub
        If Obj_Opt_Gr1.Checked Then PLANNINGS.Mode_Groupe = ENUM_Mode_Groupe.Groupe1
    End Sub

    Private Sub Obj_Opt_Gr2_CheckedChanged(sender As Object, e As EventArgs) Handles Obj_Opt_Gr2.CheckedChanged
        If PLANNINGS Is Nothing Then Exit Sub
        If Obj_Opt_Gr2.Checked Then PLANNINGS.Mode_Groupe = ENUM_Mode_Groupe.Groupe2
    End Sub

    Private Sub Obj_Opt_Classe_CheckedChanged(sender As Object, e As EventArgs) Handles Obj_Opt_Classe.CheckedChanged
        If PLANNINGS Is Nothing Then Exit Sub

        If Obj_Opt_Classe.Checked Then PLANNINGS.Mode_Groupe = ENUM_Mode_Groupe.Classe_Entiere
    End Sub
End Class
