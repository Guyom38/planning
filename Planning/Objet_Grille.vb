Imports System.Drawing.Drawing2D
Imports Planning.Enums

Public Class Objet_Grille
    Public PLANNINGS As CL_Plannings

    Public DimensionX_Image As Integer = 800
    Public DimensionY_Image As Integer = 600

    Private DimensionX As Integer = (LISTE_JOURS.Count * 2) ' contient 11 colonnes
    Private DimensionY As Integer = (LISTE_HEURES.Count)    ' contient 22 lignes


    Public CELLULES(DimensionX, DimensionY) As Objet_Cellule
    Public VERROUS(DimensionX, DimensionY) As String

    Public espaceEntreCellules As Integer = 1
    Public decalageBord As Integer = 8

    Public MOUSE As MouseEventArgs
    Public MOUSE2 As MouseEventArgs
    Public Selection As New Point(-1, -1)

    Public ecriture As Font = New Font("Arial", 10, FontStyle.Regular)

    Public img_grille As New Bitmap(DimensionX_Image, DimensionY_Image)
    Private img_gr As Graphics

    Private delais As Double = Microsoft.VisualBasic.Timer
    Private xPosition As Integer = 0
    Private yPosition As Integer = 0
    Private gradientStartColor As Color = Color.FromArgb(200, 255, 255, 255) ' Couleur de départ du dégradé
    Private gradientEndColor As Color = Color.FromArgb(0, 255, 255, 255) ' Couleur de fin du dégradé

    Public img_fond_animation As Bitmap
    Public animation As Boolean = True

    Private Sub Animate(ByRef _gr As Graphics)
        If Not animation Then
            _gr.Clear(Color.Black)
            Exit Sub
        End If
        ' Définir les paramètres de l'animation

        ' Dessiner le fond d'écran avec des lignes et des dégradés de couleurs pastels

        If Microsoft.VisualBasic.Timer - delais > 0.01 Or img_fond_animation Is Nothing Then
            img_fond_animation = New Bitmap(DimensionX_Image, DimensionY_Image)
            Dim gr As Graphics = Graphics.FromImage(img_fond_animation)

            DrawBackground(gr, xPosition, yPosition, gradientStartColor, gradientEndColor)

            delais = Microsoft.VisualBasic.Timer
            ' Mettre à jour les positions pour l'animation
            xPosition += 1
            yPosition += 1

            If xPosition = 20 Then
                xPosition = 0
                yPosition = 0
            End If
            ' Réinitialiser les positions lorsque nécessaire
            If xPosition > DimensionX_Image Then ' Remplacez "panel1" par le nom de votre contrôle Panel
                xPosition = 0
            End If

            If yPosition > DimensionY_Image Then ' Remplacez "panel1" par le nom de votre contrôle Panel
                yPosition = 0
            End If

            ' Ajouter un délai pour contrôler la vitesse de l'animation
        End If

        _gr.DrawImage(img_fond_animation, 0, 0)

    End Sub
    Private Sub DrawBackground(ByRef _gr As Graphics, ByVal xPosition As Integer, ByVal yPosition As Integer, ByVal startColor As Color, ByVal endColor As Color)
        ' Effacer le panneau avec une couleur de fond
        _gr.Clear(Color.Black)

        ' Dessiner des lignes diagonales avec des dégradés de couleurs pastels
        Dim brush As LinearGradientBrush = New LinearGradientBrush(New Point(0, 0), New Point(DimensionX_Image, DimensionY_Image), startColor, endColor)

        For i As Integer = 0 To DimensionX_Image * 2 Step 20 ' Remplacez "panel1" par le nom de votre contrôle Panel
            _gr.DrawLine(New Pen(brush), i - xPosition, 0, i - xPosition - DimensionY_Image, DimensionY_Image) ' Remplacez "panel1" par le nom de votre contrôle Panel
        Next

        For i As Integer = 0 To DimensionY_Image * 2 Step 20 ' Remplacez "panel1" par le nom de votre contrôle Panel
            _gr.DrawLine(New Pen(brush), 0, i - yPosition, DimensionX_Image, i - yPosition - DimensionX_Image) ' Remplacez "panel1" par le nom de votre contrôle Panel
        Next
    End Sub

    Sub New(_p As CL_Plannings)

        PLANNINGS = _p
    End Sub

    Public Sub Reset_VERROUS()
        For y = 0 To CELLULES.GetLength(1) - 1
            For x = 0 To CELLULES.GetLength(0) - 1
                VERROUS(x, y) = ""
            Next
        Next
    End Sub
    Public Sub Redimensionne_Image(_w As Integer, _h As Integer)
        If _w < 300 Then _w = 300
        If _h < 200 Then _h = 200

        Select Case PLANNINGS.DONNEES.Mode_Ecran
            Case Enum_Ecran.Normal
                DimensionX_Image = _w
                DimensionY_Image = _w
            Case Enum_Ecran.Normal2x
                DimensionX_Image = _w * 1.5
                DimensionY_Image = _w * 1.5
            Case Enum_Ecran.Etire
                DimensionX_Image = _w
                DimensionY_Image = _h
        End Select

        Try
            img_grille = New Bitmap(DimensionX_Image, DimensionY_Image)
            img_gr = Graphics.FromImage(img_grille)
        Catch ex As Exception

        End Try


    End Sub
    Public Sub Initialiser()
        ' // --- Initialise les cellules de la grilles
        For y = 0 To CELLULES.GetLength(1) - 1
            For x = 0 To CELLULES.GetLength(0) - 1
                If x = 0 And y > 0 Then
                    CELLULES(x, y) = New Objet_Cellule(x, y, {LISTE_HEURES(y - 1)})

                ElseIf y = 0 And x > 0 Then
                    Dim gr As Boolean = CL_Outils.QuelGroupe(x) = ENUM_Mode_Groupe.Groupe1
                    If gr Then
                        Dim id As Integer = Int((x - 1) / 2)
                        Dim jours As String = LISTE_JOURS(id)
                        CELLULES(x, 0) = New Objet_Cellule(x, 0, {jours}) With {.FusionX = 2}
                    Else
                        CELLULES(x, 0) = New Objet_Cellule(x, 0, {""}) With {.Init = False}
                    End If


                Else
                    CELLULES(x, y) = New Objet_Cellule(x, y, {""}) With {.FusionX = 1, .Init = (x > 0 And y > 0)}

                End If


            Next
        Next

        Reset_VERROUS()
    End Sub

    Public Sub Dessiner(Optional fichier As String = "")
        If CELLULES Is Nothing Then Exit Sub

        Animate(img_gr)

        Dim largeurCellule As Integer = CInt((img_grille.Width - (decalageBord * 2)) / CELLULES.GetLength(0))
        Dim hauteurCellule As Integer = CInt((img_grille.Height - (decalageBord * 2)) / CELLULES.GetLength(1))

        For x = 0 To CELLULES.GetLength(0) - 1
            For y = 0 To CELLULES.GetLength(1) - 1

                If CELLULES(x, y).Init Then
                    Dim decalageX As Integer = 0
                    Dim largeurSimple As Integer = largeurCellule
                    Dim hauteurSimple As Integer = hauteurCellule

                    If CELLULES(x, y).FusionX > 1 Then
                        largeurSimple = largeurCellule * CELLULES(x, y).FusionX
                        If CL_Outils.QuelGroupe(x) = ENUM_Mode_Groupe.Groupe2 Then
                            decalageX = 1
                        End If
                    End If

                    If Not CELLULES(x, y).FusionY = 1 Then hauteurSimple = hauteurCellule * CELLULES(x, y).FusionY

                    Dim xPos As Integer = decalageBord + ((x - decalageX) * largeurCellule)
                    Dim yPos As Integer = decalageBord + (y * hauteurCellule)
                    Dim wLargeur As Integer = largeurSimple - espaceEntreCellules
                    Dim hHauteur As Integer = hauteurSimple - espaceEntreCellules

                    Cellule(img_gr, xPos, yPos, wLargeur, hHauteur, CELLULES(x, y))
                End If

            Next
        Next

        If fichier = "" Then
            Form1.Obj_Image.Image = img_grille
        Else
            Try
                img_grille.Save(fichier, Imaging.ImageFormat.Jpeg)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try

        End If

        GC.Collect()

    End Sub

    Public Sub Cellule(ByRef _gr As Graphics, _x As Integer, _y As Integer, _w As Integer, _h As Integer, _cellule As Objet_Cellule)
        Dim bmp_cellule As New Bitmap(_w, _h)
        Dim gr_cellule As Graphics = Graphics.FromImage(bmp_cellule)
        gr_cellule.TextRenderingHint = Text.TextRenderingHint.AntiAlias
        Dim c2 As Brush = New SolidBrush(_cellule.Fond)


        Dim c As Color = Color.FromArgb(0, 0, 0)
        Dim tp As Integer = 2
        Dim pt As Point = New Point(_cellule.X, _cellule.Y)
        Dim texte As String() = _cellule.Texte

        If Not (pt.X = 0 Or pt.Y = 0) Then
            If Clics(MOUSE, _x, _y, _w, _h, pt) Then
                c = Color.FromArgb(128, 255, 0, 0)

                If MOUSE.Button = MouseButtons.Left Then
                    PLANNINGS.Ajouter_Creneau_Au_Planning()

                ElseIf MOUSE.Button = MouseButtons.Right Then
                    PLANNINGS.Ajouter_Creneau_Au_Planning(True)

                ElseIf MOUSE.Button = MouseButtons.Middle Then ' // recupere les valeurs de la cellule et selectionne les elements dans les listes
                    Recuperer_Donnees_Cellule_Pour_Listes(_cellule)
                End If

                MOUSE = Nothing
            End If

        Else ' // --- colorie les entetes
            c2 = New SolidBrush(PLANNINGS.DONNEES.COULEUR_ENTETES)
        End If


        gr_cellule.FillRectangle(c2, 0, 0, _w, _h)
        gr_cellule.DrawRectangle(New Pen(New SolidBrush(c), tp), 0, 0, _w, _h)
        'DessinerRectangleArrondi(gr2, c, New Rectangle(0, 0, _w - 2, _h - 2), 6)

        ' // --- Positionne le texte au centre
        Dim y As Integer = 0
        For Each t In texte
            Dim tailleTexte As SizeF = gr_cellule.MeasureString(t, ecriture)
            Dim milieuV As Integer = (_w - tailleTexte.Width) / 2
            Dim milieuH As Integer = (_h - (texte.Count * tailleTexte.Height)) / 2
            gr_cellule.DrawString(t, ecriture, New SolidBrush(Color.Black), New Point(milieuV, y + milieuH))
            y += tailleTexte.Height
        Next

        _gr.DrawImage(bmp_cellule, New RectangleF(_x, _y, _w, _h), New RectangleF(0, 0, _w, _h), GraphicsUnit.Pixel)
    End Sub

    Private Sub Recuperer_Donnees_Cellule_Pour_Listes(_cellule As Objet_Cellule)

        Dim jour As String = LISTE_JOURS(Int((_cellule.X - 1) / 2))
        Dim heure As String = LISTE_HEURES(_cellule.Y - 1)
        Dim groupe As ENUM_Mode_Groupe = CL_Outils.QuelGroupe(_cellule.X)
        Dim i As Integer = CInt(IIf(groupe = ENUM_Mode_Groupe.Groupe1, 0, 1))
        Dim key As String = jour & " " & heure

        Dim selection_planning As String = PLANNINGS.DONNEES.Planning_Selection
        If PLANNINGS.DONNEES.Liste_Plannings.ContainsKey(selection_planning) Then
            Dim creneau As Objet_Creneau = PLANNINGS.DONNEES.Liste_Plannings(selection_planning).Liste_Creneaux(key)

            Dim enseignant As String = creneau.Enseignant(i)
            Dim classe As String = creneau.Classe(i)
            Dim salle As String = creneau.Salle(i)
            Dim matiere As String = creneau.Matiere(i)
            Dim duree As Integer = creneau.Duree30min(i)

            ' // --- Listes avec des coches
            For Each liste As ListView In {Form1.Obj_Liste1, Form1.Obj_Liste2}
                Dim liste_config As Enum_Cible = CType(liste.Tag, Enum_Cible)

                For Each element As ListViewItem In liste.Items
                    Dim valeurAComparer As String = ""
                    Select Case liste_config
                        Case Enum_Cible.Classe : valeurAComparer = classe
                        Case Enum_Cible.Salle : valeurAComparer = salle
                        Case Enum_Cible.Enseignant : valeurAComparer = enseignant
                    End Select

                    element.Checked = (element.SubItems(1).Text = valeurAComparer)
                Next
            Next

            ' // --- Liste Matiere
            For Each element As ListViewItem In Form1.Obj_Liste_Matieres.Items
                If (element.SubItems(1).Text = matiere) Then element.Checked = True
            Next

            ' // --- Liste Duree
            Form1.Obj_Liste_Duree.SelectedIndex = (duree - 1)
        End If

    End Sub
    Private Function Clics(_mouse As MouseEventArgs, _x As Integer, _y As Integer, _w As Integer, _h As Integer, _pt As Point, Optional _survol As Boolean = False) As Boolean
        If _mouse IsNot Nothing Then
            If _mouse.Clicks Or _survol Then
                If _mouse.X >= _x And _mouse.Y >= _y And _mouse.X <= _x + _w And _mouse.Y <= _y + _h Then
                    Selection = _pt
                    Return True
                End If
            End If
        End If
        Return False
    End Function


End Class
