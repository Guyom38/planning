﻿Public Class CL_Cellule
    Sub New(_x As Integer, _y As Integer, _t As String())
        X = _x
        Y = _y
        Texte = _t
    End Sub
    Public X As Integer = 0
    Public Y As Integer = 0
    Public Fond As Brush = Brushes.White
    Public Couleur As Color = Color.Black
    Public Texte As String() = {""}
    Public Selection As Boolean = False
    Public FusionY As Integer = 1
    Public FusionX As Integer = 1
    Public EnTete As Boolean = False
    Public Init As Boolean = True

End Class