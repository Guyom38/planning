Imports Newtonsoft.Json
Imports Planning.Objet_LienTri
Imports Planning.Enums

Public Class CL_Plannings



    Public Shared LISTE_JOURS As String() = {"Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi"}
    Public Shared LISTE_HEURES As String() = {"08:00", "08:30", "09:00", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30",
                                        "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00"}


    Class Planning
        Public Liste_Creneaux As Dictionary(Of String, LienTri)
        Public Liste_Occupes As List(Of String)

        Public Proprietaire As Enum_Cible
        Public Nom As String = ""
        Public Nombre_Heures As Double = 0.0
        Public Couleur As Color = Nothing

        Sub New(_proprietaire As Enum_Cible, _nom As String)
            Proprietaire = _proprietaire
            Nom = _nom

            Liste_Creneaux = New Dictionary(Of String, LienTri)
            Liste_Occupes = New List(Of String)

            For Each Heure In CL_Plannings.LISTE_HEURES
                For Each Jour In CL_Plannings.LISTE_JOURS
                    Liste_Creneaux.Add(Jour & " " & Heure, New LienTri)
                Next
            Next

            If Proprietaire = Enum_Cible.Enseignant Then
                Couleur = Color.FromArgb(Rnd() * 255, Rnd() * 255, Rnd() * 255)

            End If


        End Sub
    End Class

    Public Liste_Plannings As New Dictionary(Of String, Planning)
    Public Sub New()
        Liste_Plannings.Add("Amandine", New Planning(Enum_Cible.Enseignant, "Amandine"))
        Liste_Plannings.Add("Clémence", New Planning(Enum_Cible.Enseignant, "Clémence"))
        Liste_Plannings.Add("Elodie", New Planning(Enum_Cible.Enseignant, "Elodie"))
        Liste_Plannings.Add("Daniel", New Planning(Enum_Cible.Enseignant, "Daniel"))

        Liste_Plannings.Add("Salle 204", New Planning(Enum_Cible.Salle, "Salle 204"))
        Liste_Plannings.Add("Salle 206", New Planning(Enum_Cible.Salle, "Salle 206"))

        Liste_Plannings.Add("BTS IG", New Planning(Enum_Cible.Classe, "BTS IG"))
        Liste_Plannings.Add("BACPRO 2", New Planning(Enum_Cible.Classe, "BACPRO 2"))

        Initialiser_Grille()
    End Sub


    Public Sub Sauvegarder(plannings As CL_Plannings, cheminFichier As String)
        Dim json As String = JsonConvert.SerializeObject(plannings)
        IO.File.WriteAllText(cheminFichier, json)
    End Sub

    Public Function Charger(cheminFichier As String) As CL_Plannings
        Dim json As String = IO.File.ReadAllText(cheminFichier)
        Dim plannings As CL_Plannings = JsonConvert.DeserializeObject(Of CL_Plannings)(json)
        Return plannings
    End Function


    Public Function Affecter(_planning As String, _jourheure As String, _classe As String, _salle As String, _enseignant As String, _matiere As String) As Boolean
        If Not Liste_Plannings.ContainsKey(_planning) Then Return False
        If Not Liste_Plannings(_planning).Liste_Creneaux.ContainsKey(_jourheure) Then Return False

        With Liste_Plannings(_planning).Liste_Creneaux(_jourheure)
            .Classe = _classe
            .Salle = _salle
            .Enseignant = _enseignant
            .Matiere = _matiere
            .Herite = False

            Select Case Liste_Plannings(_planning).Proprietaire
                Case Enum_Cible.Classe : .Valeur = .Salle & vbCrLf & .Enseignant
                Case Enum_Cible.Salle : .Valeur = .Classe & vbCrLf & .Enseignant
                Case Enum_Cible.Enseignant : .Valeur = .Classe & vbCrLf & .Salle
            End Select
        End With

        With Liste_Plannings(_planning)
            If Not .Liste_Occupes.Contains(_jourheure) Then .Liste_Occupes.Add(_jourheure) : .Nombre_Heures += 1
        End With

        Return True
    End Function
    Public Sub Affecter_Valeurs(Optional effacer As Boolean = False)


        Dim y As Integer = Selection.Y
        Dim x As Integer = Selection.X

        If x = -1 Or y = -1 Then Exit Sub
        Dim jour As String = CL_Plannings.LISTE_JOURS(Int((x - 1) / 2))
        Dim heure As String = CL_Plannings.LISTE_HEURES(y - 1)


        If Liste2_Selection = "" Or Liste1_Selection = "" Then
            MsgBox("Veuillez selectionner le créneau, ainsi que les élements a associer.")
            Exit Sub
        End If


        Dim horaire As String = jour & " " & heure
        With Liste_Plannings(Planning_Selection).Liste_Creneaux(horaire)
            Select Case Mode_Affichage
                Case ENUM_Mode_Planning.Classes
                    .Classe = Planning_Selection
                    .Salle = Liste1_Selection
                    .Enseignant = Liste2_Selection

                    Affecter(.Enseignant, horaire, .Classe, .Salle, .Enseignant, .Matiere)
                    Affecter(.Salle, horaire, .Classe, .Salle, .Enseignant, .Matiere)

                Case ENUM_Mode_Planning.Salles
                    .Classe = Liste1_Selection
                    .Salle = Planning_Selection
                    .Enseignant = Liste2_Selection

                    Affecter(.Enseignant, horaire, .Classe, .Salle, .Enseignant, .Matiere)
                    Affecter(.Classe, horaire, .Classe, .Salle, .Enseignant, .Matiere)

                Case ENUM_Mode_Planning.Enseignants
                    .Classe = Liste1_Selection
                    .Salle = Liste2_Selection
                    .Enseignant = Planning_Selection

                    Affecter(.Classe, horaire, .Classe, .Salle, .Enseignant, .Matiere)
                    Affecter(.Salle, horaire, .Classe, .Salle, .Enseignant, .Matiere)
            End Select
            .Groupe = Mode_Groupe
            .Duree30min = Form1.Obj_Nb_Heures.SelectedIndex + 1
            .Valeur = Liste1_Selection & vbCrLf & Liste2_Selection
        End With


        Preparer_Grille(Planning_Selection)

    End Sub



    Public Mode_Affichage As ENUM_Mode_Planning = ENUM_Mode_Planning.Classes
    Public Mode_Groupe As ENUM_Mode_Groupe = ENUM_Mode_Groupe.Classe_Entiere

    Public Planning_Selection As String = ""
    Public Liste1_Selection As String = ""
    Public Liste2_Selection As String = ""

    Public Sub Preparer_Grille(Optional nom_planning As String = "")

        If Liste1_Selection = "" Or Liste2_Selection = "" Or Planning_Selection = "" Then Exit Sub
        If nom_planning = "" Then nom_planning = Planning_Selection
        If Not Liste_Plannings.ContainsKey(nom_planning) Then MsgBox("Le planning du nom : " & nom_planning & " n'existe pas.") : Exit Sub

        Initialiser_Grille()

        Dim planning_select As CL_Plannings.Planning = Liste_Plannings(nom_planning)
        Dim planning_enseignant_filtre As CL_Plannings.Planning = Nothing

        If planning_select.Proprietaire = Enum_Cible.Classe Then
            If Not Liste2_Selection = "" Then planning_enseignant_filtre = Liste_Plannings(Liste2_Selection)
        End If


        For y = 0 To DimensionY - 1
            Dim heure As String = ""
            If (y > 0) Then heure = CL_Plannings.LISTE_HEURES(y - 1)

            For x = 0 To DimensionX - 1
                Dim jour As String = ""
                If (x > 0) Then jour = CL_Plannings.LISTE_JOURS(Int((x - 1) / 2))

                Dim key As String = jour & " " & heure
                If planning_select.Liste_Creneaux.ContainsKey(key) Then
                    Dim cellule As LienTri = planning_select.Liste_Creneaux(key)
                    Dim c As Color = Color.White

                    If GRILLE(x, y) IsNot Nothing And GRILLE(x, y).Init Then
                        With GRILLE(x, y)
                            .Texte = {cellule.Valeur}

                            If Not Trim(cellule.Valeur) = "" Then
                                c = Color.LightGreen

                                If Liste_Plannings.ContainsKey(cellule.Enseignant) Then
                                    If Liste_Plannings(cellule.Enseignant).Liste_Occupes.Contains(key) Then
                                        c = Liste_Plannings(cellule.Enseignant).Couleur
                                    End If
                                End If

                            Else
                                        If planning_enseignant_filtre IsNot Nothing Then
                                    If Liste_Plannings(Liste2_Selection).Liste_Occupes.Contains(key) Then
                                        .Texte = {"occupé(e)"}
                                        c = Color.LightGray
                                    End If
                                End If
                            End If

                            If cellule.Groupe = ENUM_Mode_Groupe.Classe_Entiere Or cellule.Duree30min > 1 Then
                                .FusionX = CInt(IIf(cellule.Groupe = ENUM_Mode_Groupe.Classe_Entiere, 2, 1))
                                .FusionY = cellule.Duree30min
                                For ny = 0 To .FusionY - 1
                                    For nx = 0 To .FusionX - 1
                                        GRILLE(x + nx, y + ny).Init = False
                                    Next
                                Next
                            End If


                            .Init = True
                            .Fond = New SolidBrush(c)
                        End With
                    End If

                End If

            Next
        Next


    End Sub

End Class
