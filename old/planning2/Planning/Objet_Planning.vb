Imports Planning.Enums

Public Class Objet_Planning

    Public Liste_Creneaux As Dictionary(Of String, Objet_Creneau)
    Public Liste_Occupes As Dictionary(Of String, String)

    Public Proprietaire As Enum_Cible
    Public Nom As String = ""
    Public Nombre_Heures As Double = 0.0
    Public Couleur As Color = Nothing

    Sub New(_proprietaire As Enum_Cible, _nom As String)

        Proprietaire = _proprietaire
        Nom = _nom
        Liste_Creneaux = New Dictionary(Of String, Objet_Creneau)
        Liste_Occupes = New Dictionary(Of String, String)

        For Each Heure In LISTE_HEURES
            For Each Jour In LISTE_JOURS
                Liste_Creneaux.Add(Jour & " " & Heure, New Objet_Creneau(_nom))
            Next
        Next

        If Proprietaire = Enum_Cible.Enseignant Then
            Couleur = liste_couleurs(CL_Plannings.Nb)
            CL_Plannings.Nb += 1
        End If
    End Sub

End Class