Imports Newtonsoft.Json
Imports Planning.Enums
Imports Planning.CL_Outils
Imports Planning.CL_Plannings.CL_DONNEES
Imports System.IO

Public Class CL_Plannings
    Public Shared Nb As Integer = 0

    Class CL_DONNEES
        Class CL_Matiere
            Public Nombre_Heures As Double = 0.0
        End Class
        Public Liste_Matieres As New Dictionary(Of String, CL_Matiere)
        Public Liste_Plannings As New Dictionary(Of String, Objet_Planning)

        Public Mode_Affichage As ENUM_Mode_Planning = ENUM_Mode_Planning.Classes
        Public Mode_Ecran As Enum_Ecran = Enum_Ecran.Normal

        Public Planning_Selection As String = ""
        Public Liste1_Selection As String = ""
        Public Liste2_Selection As String = ""
        Public Matiere_Selection As String = ""

        Public COULEUR_ENTETES As Color = Color.LightGray

    End Class

    Class CL_Actions
        Public effacer As Boolean = False
        Public planning As String = ""
        Public x As Integer = 0
        Public y As Integer = 0
        Public liste1 As String = ""
        Public liste2 As String = ""
        Public duree As Double = 0.0
    End Class
    Public SOS As New List(Of CL_Actions)

    Public ACTIONS As New List(Of String)
    Public DONNEES As New CL_DONNEES

    Public GRILLE As New Objet_Grille(Me)

    Public Modification As Boolean = False
    Public MOTEUR As CL_Moteur

    Public Sub New(ByRef _m As CL_Moteur)
        MOTEUR = _m
        DONNEES = New CL_DONNEES
        GRILLE.Initialiser()
        SOS = New List(Of CL_Actions)
    End Sub

    Public Sub Sauvegarder(cheminFichier As String)
        Dim json As String = JsonConvert.SerializeObject(DONNEES)
        IO.File.WriteAllText(cheminFichier, json)

        json = JsonConvert.SerializeObject(SOS)
        IO.File.WriteAllText(Replace(cheminFichier, ".json", "_sos.json"), json)


        Dim monStreamWriter As StreamWriter = New StreamWriter(Replace(cheminFichier, ".json", ".txt"))

        For Each p In DONNEES.Liste_Plannings
            monStreamWriter.WriteLine(p.Value.Proprietaire.ToString & "," & p.Value.Nom)
        Next

        For Each p In DONNEES.Liste_Matieres
            monStreamWriter.WriteLine("Matiere" & "," & p.Key)
        Next

        'Fermeture du StreamWriter (Très important)
        monStreamWriter.Close()
        Modification = False
    End Sub
    Public Sub Charger(cheminFichier As String)
        If Not IO.File.Exists(cheminFichier) Then Exit Sub


        Try
            Dim json As String = IO.File.ReadAllText(cheminFichier)
            DONNEES = JsonConvert.DeserializeObject(Of CL_DONNEES)(json)



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        MOTEUR.fichier = cheminFichier

        MOTEUR.Reinitialiser_Listes_Config()

        MOTEUR.PLANNINGS.DONNEES.Mode_Affichage = ENUM_Mode_Planning.Classes
        MOTEUR.Met_a_jour_Les_Listes_Avec_Heures_ParRapport_ModeAffichage()
        MOTEUR.FORM_PARENT.Initialisation_Selection()

        MOTEUR.PLANNINGS.Preparer_Grille()


        Modification = False
    End Sub

    Public Sub Charger_SOS(cheminFichier As String)
        If Not IO.File.Exists(Replace(cheminFichier, ".json", "_sos.json")) Then Exit Sub

        Try
            Dim json As String = IO.File.ReadAllText(Replace(cheminFichier, ".json", "_sos.json"))
            Dim TMP_SOS As List(Of CL_Actions) = JsonConvert.DeserializeObject(Of List(Of CL_Actions))(json)

            For Each action In TMP_SOS
                DONNEES.Liste1_Selection = action.liste1
                DONNEES.Liste2_Selection = action.liste2
                DONNEES.Planning_Selection = action.planning
                Form1.Obj_Liste_Duree.SelectedIndex = action.duree
                GRILLE.Selection.X = action.x
                GRILLE.Selection.Y = action.y

                Ajouter_Creneau_Au_Planning(action.effacer)
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        MOTEUR.fichier = cheminFichier
        MOTEUR.Reinitialiser_Listes_Config()

        MOTEUR.PLANNINGS.DONNEES.Mode_Affichage = ENUM_Mode_Planning.Classes
        MOTEUR.Met_a_jour_Les_Listes_Avec_Heures_ParRapport_ModeAffichage()
        MOTEUR.FORM_PARENT.Initialisation_Selection()

        MOTEUR.PLANNINGS.Preparer_Grille()


        Modification = False
    End Sub

    Public Sub ReCalcul_Heures()
        For Each p In DONNEES.Liste_Plannings
            p.Value.Nombre_Heures = 0.0
        Next
        For Each m In DONNEES.Liste_Matieres
            m.Value.Nombre_Heures = 0.0
        Next

        For Each p In DONNEES.Liste_Plannings
            For Each c In p.Value.Liste_Creneaux
                For g = 0 To 1
                    If c.Value.Active(g) Then
                        Debug.Print(c.Value.Planning_Origine)
                        If Not c.Value.Valeur(g) = "" Then
                            Dim demiHeure As Double = c.Value.Duree30min(g) * 0.5
                            p.Value.Nombre_Heures += demiHeure

                            If p.Value.Proprietaire = Enum_Cible.Classe Then
                                If MOTEUR.PLANNINGS.DONNEES.Liste_Matieres.ContainsKey(c.Value.Matiere(g)) Then
                                    MOTEUR.PLANNINGS.DONNEES.Liste_Matieres(c.Value.Matiere(g)).Nombre_Heures += demiHeure
                                End If
                            End If

                        End If
                    End If
                Next
            Next
        Next

        MOTEUR.Met_a_jour_Les_Listes_Avec_Heures_ParRapport_ModeAffichage()

    End Sub

    Public Sub Afficher_Verrou()
        Dim ligne As String = ""
        For y = 1 To GRILLE.DimensionY - 1
            ligne = ""
            For x = 1 To GRILLE.DimensionX - 1
                ligne &= CStr(IIf(GRILLE.VERROUS(x, y), "███ ", "[ ] "))
            Next

            Debug.Print(ligne)
        Next
        Debug.Print("")
    End Sub
    Public Sub Preparer_Grille(Optional nom_planning As String = "", Optional _export As Boolean = False)
        Debug.Print("----------------------------------------------------------------------------")
        Afficher_Verrou()

        If DONNEES.Planning_Selection = "" Then Exit Sub
        If nom_planning = "" Then nom_planning = DONNEES.Planning_Selection
        If Not DONNEES.Liste_Plannings.ContainsKey(nom_planning) Then MsgBox("Le planning du nom : " & nom_planning & " n'existe pas.") : Exit Sub

        GRILLE.Initialiser()

        Afficher_Verrou()
        Dim planning_select As Objet_Planning = DONNEES.Liste_Plannings(nom_planning)
        For y = 0 To GRILLE.DimensionY - 1
            Dim heure As String = ""
            If (y > 0) Then heure = LISTE_HEURES(y - 1)

            For x = 0 To GRILLE.DimensionX - 1
                Dim jour As String = ""
                If (x > 0) Then jour = LISTE_JOURS(Int((x - 1) / 2))
                Dim key As String = jour & " " & heure

                If x > 0 And y > 0 Then
                    Dim c As Color = Color.White
                    Dim i As Integer = CInt(QuelGroupe(x))

                    Dim liste_construction As New List(Of Objet_Planning)
                    liste_construction.Add(planning_select)
                    If Not _export Then
                        If Not DONNEES.Liste1_Selection = "" Then liste_construction.Add(DONNEES.Liste_Plannings(DONNEES.Liste1_Selection))
                        If Not DONNEES.Liste2_Selection = "" Then liste_construction.Add(DONNEES.Liste_Plannings(DONNEES.Liste2_Selection))
                    End If

                    Dim CelluleDejaAffichée As Boolean = False
                    For Each ps In liste_construction

                        If Not CelluleDejaAffichée Then
                            If ps.Liste_Creneaux.ContainsKey(key) Then
                                Dim creneau As Objet_Creneau = ps.Liste_Creneaux(key)


                                If GRILLE.CELLULES(x, y).Init And creneau.Active(i) Then

                                        If Not Trim(creneau.Valeur(i)) = "" Then

                                            c = Recupere_Couleur_Enseignant(creneau, i, key)
                                            Prepare_Fusion_Cellules(planning_select, ps, creneau, x, y)


                                            ' // --- Active la cellule maitre
                                            With GRILLE.CELLULES(x, y)
                                                .Init = True

                                                If ps.Nom = nom_planning Then
                                                    .Texte = Split(creneau.Valeur(i), vbCrLf)
                                                    .Fond = c

                                                Else ' // --- créneaux des autres plannings
                                                    .Texte = {creneau.Classe(i), creneau.Salle(i), creneau.Enseignant(i), creneau.Matiere(i)}
                                                    .Fond = Color.LightGray
                                                End If
                                            End With
                                            CelluleDejaAffichée = True

                                        End If
                                    End If

                            Else
                                    ' // --- correction bug de merde / 9h30
                                    ps.Liste_Creneaux.Add(key, New Objet_Creneau(ps.Nom))
                            End If

                        End If

                    Next

                End If

            Next
        Next

        Afficher_Verrou()
        Debug.Print("")
    End Sub

    Public Function Recupere_Couleur_Enseignant(_creneau As Objet_Creneau, _i As Integer, _key As String) As Color
        If DONNEES.Liste_Plannings.ContainsKey(_creneau.Enseignant(_i)) Then
            If DONNEES.Liste_Plannings(_creneau.Enseignant(_i)).Liste_Occupes.ContainsKey(_key) Then
                Return DONNEES.Liste_Plannings(_creneau.Enseignant(_i)).Couleur
            End If
        End If

        Return Color.White
    End Function
    Public Sub Prepare_Fusion_Cellules(ByRef _psSelect As Objet_Planning, ByRef _ps As Objet_Planning, ByRef _creneau As Objet_Creneau, x As Integer, y As Integer)
        With GRILLE.CELLULES(x, y)
            Dim classeEntiere As Boolean = (_creneau.Valeur(0) = _creneau.Valeur(1)) And _creneau.DeuxGroupes = False
            .FusionX = CInt(IIf(classeEntiere And (QuelGroupe(x) = ENUM_Mode_Groupe.Groupe1), 2, 1))
            .FusionY = _creneau.Duree30min(CInt(QuelGroupe(x)))

            ' // si colorie gris, alors prend toute la salle
            If Not _ps Is _psSelect Then .FusionX = 2

            For ny = 0 To .FusionY - 1
                For nx = 0 To .FusionX - 1

                    GRILLE.VERROUS(x + nx, y + ny) = True
                    If GRILLE.CELLULES(x + nx, y + ny) IsNot Nothing Then
                        With GRILLE.CELLULES(x + nx, y + ny)
                            .Init = False
                        End With
                    End If
                Next
            Next
        End With
    End Sub

    Public Function Verification_Creneaux_Disponibles(_x As Integer, _y As Integer, _deuxGroupes As Boolean, _duree As Integer, _creneau As Objet_Creneau) As Boolean
        For yy = _y To _y + _duree - 1
            For xx = _x To _x + CInt(IIf(_deuxGroupes, 1, 0))
                If xx > GRILLE.DimensionX - 1 Or yy > GRILLE.DimensionY - 1 Then Return False
                If GRILLE.VERROUS(xx, yy) Then Return False
            Next
        Next
        Return True
    End Function

    Public Sub Ajouter_Creneau_Au_Planning(Optional _effacer As Boolean = False)

        ' // --- Recupere les coordonnées de la cellule selectionnée
        Dim y As Integer = GRILLE.Selection.Y
        Dim x As Integer = GRILLE.Selection.X

        ' // --- Si aucune cellule selectionnée => EXIT SUB
        ' // --- Si aucune données d'affection selectionnées => EXIT SUB
        If x = -1 Or y = -1 Then Exit Sub
        If DONNEES.Liste2_Selection = "" Or DONNEES.Liste1_Selection = "" Or DONNEES.Matiere_Selection = "" Then Exit Sub

        ' // --- Extrait le jour et l'heure
        Dim jour As String = LISTE_JOURS(Int((x - 1) / 2))
        Dim heure As String = LISTE_HEURES(y - 1)
        Dim key As String = jour & " " & heure

        '  // --- Selectionne le planning en cours
        Dim creneau As Objet_Creneau = DONNEES.Liste_Plannings(DONNEES.Planning_Selection).Liste_Creneaux(key)
        With creneau
            Dim deuxGroupes As Boolean = ((Not .Valeur(0) = "") And (Not .Valeur(1) = "")) And Not (.Valeur(0) = .Valeur(1))
            Dim duree As Integer = Form1.Obj_Liste_Duree.SelectedIndex + 1
            Dim i As Integer = CInt(QuelGroupe(x))

            If Not _effacer Then
                If Not Verification_Creneaux_Disponibles(x, y, deuxGroupes, duree, creneau) Then
                    Debug.Print("Pas disponible") : Beep()
                    Exit Sub
                End If
            End If

            ' // --- Selectionne la valeur a utilisée 0 => groupe 1 & classe entiere, 1 => groupe 2
            If _effacer Then

                SOS.Add(New CL_Actions With {.effacer = True, .x = x, .y = y})

                .DeuxGroupes = True
                .Duree30min(i) = 1
                .Valeur(i) = ""
                .Active(i) = False

            Else

                SOS.Add(New CL_Actions With {.planning = DONNEES.Planning_Selection, .liste1 = DONNEES.Liste1_Selection, .liste2 = DONNEES.Liste2_Selection, .duree = duree, .x = x, .y = y})

                .DeuxGroupes = deuxGroupes
                .Duree30min(i) = duree
                .Valeur(i) = DONNEES.Liste1_Selection & vbCrLf & DONNEES.Liste2_Selection
                .Active(i) = True

                If Not Trim(.Matiere(i)) = "" Then
                    If Not MOTEUR.PLANNINGS.DONNEES.Liste_Matieres.ContainsKey(.Matiere(i)) Then
                        MOTEUR.PLANNINGS.DONNEES.Liste_Matieres.Add(.Matiere(i), New CL_Matiere With {.Nombre_Heures = duree * 0.5})
                    Else
                        MOTEUR.PLANNINGS.DONNEES.Liste_Matieres(.Matiere(i)).Nombre_Heures += (duree * 0.5)
                    End If
                End If

            End If

            ' // --- Reajuste les données a utilisée pour l'affection dans les differents plannings
            Select Case DONNEES.Mode_Affichage
                Case ENUM_Mode_Planning.Classes
                    .Classe(i) = DONNEES.Planning_Selection
                    .Salle(i) = DONNEES.Liste1_Selection
                    .Enseignant(i) = DONNEES.Liste2_Selection

                    Impacter_Autre_Planning(i, creneau, .Enseignant(i), key, .Classe(i), .Salle(i), .Enseignant(i), .Matiere(i), _effacer)
                    Impacter_Autre_Planning(i, creneau, .Salle(i), key, .Classe(i), .Salle(i), .Enseignant(i), .Matiere(i), _effacer)

                Case ENUM_Mode_Planning.Salles
                    .Classe(i) = DONNEES.Liste1_Selection
                    .Salle(i) = DONNEES.Planning_Selection
                    .Enseignant(i) = DONNEES.Liste2_Selection

                    Impacter_Autre_Planning(i, creneau, .Enseignant(i), key, .Classe(i), .Salle(i), .Enseignant(i), .Matiere(i), _effacer)
                    Impacter_Autre_Planning(i, creneau, .Classe(i), key, .Classe(i), .Salle(i), .Enseignant(i), .Matiere(i), _effacer)

                Case ENUM_Mode_Planning.Enseignants
                    .Classe(i) = DONNEES.Liste1_Selection
                    .Salle(i) = DONNEES.Liste2_Selection
                    .Enseignant(i) = DONNEES.Planning_Selection

                    Impacter_Autre_Planning(i, creneau, .Classe(i), key, .Classe(i), .Salle(i), .Enseignant(i), .Matiere(i), _effacer)
                    Impacter_Autre_Planning(i, creneau, .Salle(i), key, .Classe(i), .Salle(i), .Enseignant(i), .Matiere(i), _effacer)

            End Select



        End With
        Modification = True
        Preparer_Grille(DONNEES.Planning_Selection)
        ' ReCalcul_Heures()
    End Sub

    Public Function Impacter_Autre_Planning(_id_groupe As Integer, _creneau As Objet_Creneau, _planning As String, _jourheure As String, _classe As String, _salle As String, _enseignant As String, _matiere As String, _effacer As Boolean) As Boolean
        If Not DONNEES.Liste_Plannings.ContainsKey(_planning) Then Return False
        If Not DONNEES.Liste_Plannings(_planning).Liste_Creneaux.ContainsKey(_jourheure) Then Return False

        With DONNEES.Liste_Plannings(_planning).Liste_Creneaux(_jourheure)
            If _effacer Then
                .Active(_id_groupe) = False
                .Valeur(_id_groupe) = ""
                .Herite(_id_groupe) = True

                _classe = ""
                _salle = ""
                _enseignant = ""
                _matiere = ""

                .Duree30min(_id_groupe) = 1
                .DeuxGroupes = True
            Else
                Dim v As String = ""
                Select Case DONNEES.Liste_Plannings(_planning).Proprietaire
                    Case Enum_Cible.Classe : v = _salle & vbCrLf & _enseignant
                    Case Enum_Cible.Salle : v = _classe & vbCrLf & _enseignant
                    Case Enum_Cible.Enseignant : v = _classe & vbCrLf & _salle
                End Select
                .Active(_id_groupe) = True
                .Herite(_id_groupe) = False
                .Valeur(_id_groupe) = v

                .Duree30min(_id_groupe) = _creneau.Duree30min(_id_groupe)
                .DeuxGroupes = _creneau.DeuxGroupes
            End If


            .Classe(_id_groupe) = _classe
            .Salle(_id_groupe) = _salle
            .Enseignant(_id_groupe) = _enseignant
            .Matiere(_id_groupe) = _matiere
        End With

        With DONNEES.Liste_Plannings(_planning)
            If Not .Liste_Occupes.ContainsKey(_jourheure) Then
                .Liste_Occupes.Add(_jourheure, _planning)
                .Nombre_Heures += CDbl(_creneau.Duree30min(_id_groupe) / 2)

            ElseIf _effacer Then
                .Nombre_Heures -= CDbl(_creneau.Duree30min(_id_groupe) / 2)
                .Liste_Occupes.Remove(_jourheure)
            End If
        End With

        Return True
    End Function


End Class
