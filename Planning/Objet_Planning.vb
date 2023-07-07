Imports Planning.Enums

Public Class Objet_Planning

    Public Proprietaire As Enum_Cible
    Public Nom As String = ""
    Public Nombre_Heures As Double = 0.0
    Public Couleur As Color = Nothing

    Sub New(_proprietaire As Enum_Cible, _nom As String)
        Proprietaire = _proprietaire
        Nom = _nom
    End Sub

End Class