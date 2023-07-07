Public Class Objet_Creneau
    Sub New(_planning)
        Planning_Origine = _planning
    End Sub
    Public Planning_Origine As String = ""

    Public Classe() As String = {"", ""}
    Public Enseignant() As String = {"", ""}
    Public Salle() As String = {"", ""}
    Public Matiere() As String = {"", ""}
    Public Active() As Boolean = {False, False}
    Public Herite() As Boolean = {True, True}
    Public Duree30min() As Integer = {1, 1}

    Public DeuxGroupes As Boolean = True

    Public _Valeur() As String = {"", ""}
    Public Property Valeur(_id As Integer) As String
        Get
            If _Valeur(_id) = "" Then Return ""
            Return _Valeur(_id) & vbCrLf & Matiere(_id)
        End Get
        Set(value As String)
            _Valeur(_id) = value

            If Herite(_id) Then
                If Form1.Obj_Liste_Matieres.CheckedItems.Count = 1 Then
                    Matiere(_id) = Form1.Obj_Liste_Matieres.CheckedItems(0).SubItems(1).Text
                End If
            End If
        End Set
    End Property

End Class

