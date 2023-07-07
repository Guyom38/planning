Imports System.Drawing.Drawing2D
Imports Planning.Enums

Public Class CL_Outils

    Public Shared Sub DessinerRectangleArrondi(graphics As Graphics, couleur As Color, rectangle As Rectangle, rayon As Integer)
        Dim path As New GraphicsPath()

        ' Coins supérieurs gauche et droit
        path.AddArc(rectangle.X, rectangle.Y, rayon * 2, rayon * 2, 180, 90)

        ' Bord supérieur
        path.AddLine(rectangle.X + rayon, rectangle.Y, rectangle.Right - rayon, rectangle.Y)

        ' Coin supérieur droit
        path.AddArc(rectangle.Right - rayon * 2, rectangle.Y, rayon * 2, rayon * 2, 270, 90)

        ' Bord droit
        path.AddLine(rectangle.Right, rectangle.Y + rayon, rectangle.Right, rectangle.Bottom - rayon)

        ' Coin inférieur droit
        path.AddArc(rectangle.Right - rayon * 2, rectangle.Bottom - rayon * 2, rayon * 2, rayon * 2, 0, 90)

        ' Bord inférieur
        path.AddLine(rectangle.Right - rayon, rectangle.Bottom, rectangle.X + rayon, rectangle.Bottom)

        ' Coin inférieur gauche
        path.AddArc(rectangle.X, rectangle.Bottom - rayon * 2, rayon * 2, rayon * 2, 90, 90)

        ' Bord gauche
        path.AddLine(rectangle.X, rectangle.Bottom - rayon, rectangle.X, rectangle.Y + rayon)

        ' Fermer le chemin
        path.CloseFigure()

        ' Dessiner le rectangle arrondi
        graphics.DrawPath(New Pen(New SolidBrush(couleur), 1), path)
    End Sub

    Public Shared Function QuelGroupe(_x As Integer) As ENUM_Mode_Groupe
        If (_x - 1) Mod 2 = 0 Then
            Return ENUM_Mode_Groupe.Groupe1
        Else
            Return ENUM_Mode_Groupe.Groupe2
        End If
    End Function
End Class
