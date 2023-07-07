Imports Planning.Enums

Public Class CL_Moteur
    Public FORM_PARENT As Form1
    Public PLANNINGS As CL_Plannings
    Public EXPORT As Moteur_Export


    Public fichier As String = ""

    Sub New(ByRef _f As Form1)
        FORM_PARENT = _f
        PLANNINGS = New CL_Plannings(Me)
        EXPORT = New Moteur_Export(Me, PLANNINGS)
    End Sub

    Public Sub Initialisation(Optional _boot As Boolean = False)
        PLANNINGS = New CL_Plannings(Me)
        EXPORT = New Moteur_Export(Me, PLANNINGS)

        With FORM_PARENT
            ' PLANNINGS.Preparer_Grille()
            PLANNINGS.GRILLE.Redimensionne_Image(.Obj_Cadre.ClientSize.Width - 20, .Obj_Cadre.ClientSize.Height)

            fichier = My.Settings.fichier_en_cours
            If Not Trim(fichier) = "" And _boot Then
                PLANNINGS.Charger(fichier)
                FORM_PARENT.Obj_Onglets.SelectedIndex = 1
            Else
                fichier = ""
                PLANNINGS.DONNEES.Mode_Affichage = ENUM_Mode_Planning.Classes
                Met_a_jour_Les_Listes_Avec_Heures_ParRapport_ModeAffichage()
                FORM_PARENT.Initialisation_Selection()
                PLANNINGS.Preparer_Grille()

            End If

            PLANNINGS.Modification = False
        End With

    End Sub



    Public Sub Met_a_jour_Les_Listes_Avec_Heures_ParRapport_ModeAffichage()
        Dim choix As Enum_Cible, liste1 As Enum_Cible, liste2 As Enum_Cible

        Select Case PLANNINGS.DONNEES.Mode_Affichage
            Case ENUM_Mode_Planning.Salles
                choix = Enum_Cible.Salle
                liste1 = Enum_Cible.Classe
                liste2 = Enum_Cible.Enseignant
            Case ENUM_Mode_Planning.Enseignants
                choix = Enum_Cible.Enseignant
                liste1 = Enum_Cible.Classe
                liste2 = Enum_Cible.Salle
            Case Else
                choix = Enum_Cible.Classe
                liste1 = Enum_Cible.Salle
                liste2 = Enum_Cible.Enseignant
                PLANNINGS.DONNEES.Mode_Affichage = ENUM_Mode_Planning.Classes
        End Select

        With FORM_PARENT

            .Obj_Liste2.Items.Clear()
            .Obj_Liste1.Items.Clear()
            .Obj_Liste_Plannings.Items.Clear()
            CL_Plannings.Nb = 0

            For Each element In PLANNINGS.DONNEES.Liste_Plannings
                ' // --- Ajoute dans le listing
                Select Case element.Value.Proprietaire
                    Case liste2
                        With .Obj_Liste2

                            Select Case liste2
                                Case Enum_Cible.Classe : .Columns(1).Text = "Classe"
                                Case Enum_Cible.Salle : .Columns(1).Text = "Salle"
                                Case Enum_Cible.Enseignant : .Columns(1).Text = "Enseignant" : CL_Plannings.Nb += 1
                            End Select
                            With .Items.Add("")
                                .UseItemStyleForSubItems = False
                                .SubItems.Add(element.Value.Nom)
                                .SubItems.Add(element.Value.Nombre_Heures.ToString)
                                If Not element.Value.Couleur = Nothing Then .BackColor = element.Value.Couleur
                            End With
                        End With

                    Case liste1
                        With .Obj_Liste1
                            Select Case liste1
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

                    Case choix
                        .Obj_Liste_Plannings.Items.Add(element.Value.Nom)
                End Select

            Next


            .Obj_Liste1.Tag = liste1
            .Obj_Liste2.Tag = liste2

            Met_A_Jour_La_Liste_des_Matieres_Avec_Heures()

            If .Obj_Liste1.Items.Count > 0 Then .Obj_Liste1.Items(0).Checked = True
            If .Obj_Liste2.Items.Count > 0 Then .Obj_Liste2.Items(0).Checked = True
            If .Obj_Liste_Matieres.Items.Count > 0 Then .Obj_Liste_Matieres.Items(0).Checked = True



        End With

    End Sub

    ''' <summary>
    ''' Reinitialise les listes de configuration
    ''' </summary>
    Public Sub Reinitialiser_Listes_Config()
        With FORM_PARENT


            .Obj_Liste_Config_Classes.Items.Clear()
            .Obj_Liste_Config_Enseignants.Items.Clear()
            .Obj_Liste_Config_Salles.Items.Clear()

            For Each element In PLANNINGS.DONNEES.Liste_Plannings
                ' // --- Ajoute dans la zone config
                Select Case element.Value.Proprietaire
                    Case Enum_Cible.Classe : .Obj_Liste_Config_Classes.Items.Add(element.Value.Nom)
                    Case Enum_Cible.Enseignant : .Obj_Liste_Config_Enseignants.Items.Add(element.Value.Nom)
                    Case Enum_Cible.Salle : .Obj_Liste_Config_Salles.Items.Add(element.Value.Nom)
                End Select
            Next

            .Obj_Liste_Config_Matieres.Items.Clear()
            For Each matiere In PLANNINGS.DONNEES.Liste_Matieres
                .Obj_Liste_Config_Matieres.Items.Add(matiere.Key)
            Next

        End With
    End Sub

    ''' <summary>
    ''' Met a jour la liste des matieres avec les heures
    ''' </summary>
    Public Sub Met_A_Jour_La_Liste_des_Matieres_Avec_Heures()

        With FORM_PARENT
            Dim selection_matiere As String = ""
            If .Obj_Liste_Matieres.CheckedItems.Count = 1 Then
                selection_matiere = .Obj_Liste_Matieres.CheckedItems(0).SubItems(1).Text
            End If

            .Obj_Liste_Matieres.Items.Clear()
            For Each matiere In PLANNINGS.DONNEES.Liste_Matieres
                With .Obj_Liste_Matieres
                    With .Items.Add("")
                        .UseItemStyleForSubItems = False
                        .SubItems.Add(matiere.Key)
                        .SubItems.Add(matiere.Value.Nombre_Heures.ToString)
                    End With
                End With
            Next

            For Each matiere As ListViewItem In .Obj_Liste_Matieres.Items
                If matiere.SubItems(1).Text = selection_matiere Then
                    matiere.Checked = True
                End If
            Next
        End With
    End Sub

End Class
