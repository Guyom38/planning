Imports System.Drawing.Drawing2D

Partial Public Class CL_Plannings

    Public DimensionX As Integer = (LISTE_JOURS.Count * 2) + 1
    Public DimensionY As Integer = (LISTE_HEURES.Count + 1)
    Public GRILLE(DimensionX, DimensionY) As CL_Cellule

    Const espaceEntreCellules As Integer = 1
    Const decalageBord As Integer = 8
    Public MOUSE As MouseEventArgs
    Public ecriture As Font = New Font("Arial", 10, FontStyle.Regular)

    Public Selection As New Point(-1, -1)

    Public Sub Initialiser_Grille()
        For y = 0 To (LISTE_HEURES.Count - 1)
            GRILLE(0, y + 1) = New CL_Cellule(0, y + 1, {LISTE_HEURES(y)}) With {.EnTete = True}
        Next
        For x = 0 To LISTE_JOURS.Count - 1
            GRILLE(1 + (x * 2) + 0, 0) = New CL_Cellule(x, 0, {LISTE_JOURS(x)}) With {.EnTete = True, .FusionX = 2}
            GRILLE(1 + (x * 2) + 1, 0) = Nothing
        Next

        For y = 1 To DimensionY - 1
            For x = 1 To DimensionX - 1
                GRILLE(x, y) = New CL_Cellule(x, y, {""}) With {.EnTete = False, .FusionX = 1}
            Next
        Next
    End Sub


    Public Sub Dessiner_Grille()

        Dim bmp As New Bitmap(Form1.Obj_Cadre.ClientSize.Width - 20, Form1.Obj_Cadre.ClientSize.Width)
        Dim gr As Graphics = Graphics.FromImage(bmp)

        gr.Clear(Color.White)

        Dim largeurCellule As Integer = CInt((bmp.Width - (decalageBord * 2)) / DimensionX)
        Dim hauteurCellule As Integer = CInt((bmp.Height - (decalageBord * 2)) / DimensionY)

        For x = 0 To DimensionX - 1
            For y = 0 To DimensionY - 1
                If GRILLE(x, y) IsNot Nothing Then
                    If GRILLE(x, y).Init Then

                        Dim largeurSimple As Integer = largeurCellule
                        Dim hauteurSimple As Integer = hauteurCellule
                        If GRILLE(x, y).FusionX > 1 Then largeurSimple = largeurCellule * GRILLE(x, y).FusionX
                        If GRILLE(x, y).FusionY > 1 Then hauteurSimple = hauteurCellule * GRILLE(x, y).FusionY

                        Dim xPos As Integer = decalageBord + (x * largeurCellule)
                        Dim yPos As Integer = decalageBord + (y * hauteurCellule)
                        Dim wLargeur As Integer = largeurSimple - espaceEntreCellules
                        Dim hHauteur As Integer = hauteurSimple - espaceEntreCellules

                        Cellule(gr, xPos, yPos, wLargeur, hHauteur, GRILLE(x, y))

                    End If
                End If
            Next
        Next

        Form1.Obj_Image.Image = bmp
    End Sub


    Public Function Cellule(ByRef _gr As Graphics, _x As Integer, _y As Integer, _w As Integer, _h As Integer, _cellule As CL_Cellule) As Boolean
        Dim bmp2 As New Bitmap(_w, _h)
        Dim gr2 As Graphics = Graphics.FromImage(bmp2)
        gr2.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias

        Dim c2 As Brush = _cellule.Fond
        Dim c As Color = Color.FromArgb(0, 0, 0)
        Dim pt As Point = New Point(_cellule.X, _cellule.Y)
        Dim texte As String() = _cellule.Texte

        If Not (pt.X = 0 Or pt.Y = 0) Then
            If Pression(_x, _y, _w, _h, pt) Then
                c = Color.FromArgb(128, 255, 0, 0)
                MOUSE = Nothing
            ElseIf pt = Selection Then
                c2 = New SolidBrush(Color.CadetBlue)
            End If
        End If

        If _cellule.EnTete Then c2 = New SolidBrush(Color.Gray)

        gr2.FillRectangle(c2, 0, 0, _w, _h)
        gr2.DrawRectangle(New Pen(New SolidBrush(c), 2), 0, 0, _w, _h)
        'DessinerRectangleArrondi(gr2, c, New Rectangle(0, 0, _w - 2, _h - 2), 6)

        Dim y As Integer = 0
        For Each t In texte
            Dim tailleTexte As SizeF = gr2.MeasureString(t, ecriture)
            Dim milieuV As Integer = (_w - tailleTexte.Width) / 2
            Dim milieuH As Integer = (_h - (texte.Count * tailleTexte.Height)) / 2
            gr2.DrawString(t, ecriture, New SolidBrush(c), New Point(milieuV, y + milieuH))
            y += tailleTexte.Height
        Next

        _gr.DrawImage(bmp2, New RectangleF(_x, _y, _w, _h), New RectangleF(0, 0, _w, _h), GraphicsUnit.Pixel)
    End Function

    Private Function Pression(_x As Integer, _y As Integer, _w As Integer, _h As Integer, _pt As Point) As Boolean
        If MOUSE IsNot Nothing Then
            If MOUSE.Clicks Then
                If MOUSE.X >= _x And MOUSE.Y >= _y And MOUSE.X <= _x + _w And MOUSE.Y <= _y + _h Then
                    Form1.Text = _pt.X & ", " & _pt.Y & ", " & CL_Plannings.LISTE_JOURS(Int((_pt.X - 1) / 2)) & ", " & CL_Plannings.LISTE_HEURES(_pt.Y - 1)
                    Selection = _pt
                    Return True
                End If
            End If
        End If
        Return False
    End Function


    Private Sub DessinerRectangleArrondi(graphics As Graphics, couleur As Color, rectangle As Rectangle, rayon As Integer)
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
End Class
