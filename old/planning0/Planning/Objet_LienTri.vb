Imports Planning.Enums

Public Class Objet_LienTri
    Class LienTri
        Public Classe As String = ""
        Public Enseignant As String = ""
        Public Salle As String = ""
        Public Groupe As ENUM_Mode_Groupe = ENUM_Mode_Groupe.Aucun

        Public Herite As Boolean = True
        Public Duree30min As Integer = 1

        Public _Valeur As String = ""
        Public Property Valeur As String
            Get
                If _Valeur = "" Then Return ""
                Return _Valeur & vbCrLf & Matiere
            End Get
            Set(value As String)
                _Valeur = value

                If Herite Then Matiere = Form1.Obj_Liste_Matiere.Text
            End Set
        End Property
        Public Matiere As String = ""

    End Class
End Class
