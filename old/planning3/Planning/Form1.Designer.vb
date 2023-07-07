<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Obj_Liste_Plannings = New System.Windows.Forms.ComboBox()
        Me.Obj_Liste2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Obj_Liste1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Obj_Mode_Classes = New System.Windows.Forms.Button()
        Me.Obj_Mode_Salles = New System.Windows.Forms.Button()
        Me.Obj_Mode_Enseignants = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Obj_Onglets = New System.Windows.Forms.TabControl()
        Me.Obj_Onglet_Donnees = New System.Windows.Forms.TabPage()
        Me.Obj_Valider_Matieres = New System.Windows.Forms.Button()
        Me.Obj_Bt_Reinitialiser = New System.Windows.Forms.Button()
        Me.Obj_Bt_Retirer_Matiere = New System.Windows.Forms.Button()
        Me.Obj_Bt_Ajouter_Matiere = New System.Windows.Forms.Button()
        Me.Obj_Img_Matiere = New System.Windows.Forms.PictureBox()
        Me.Obj_Zt_Matiere = New System.Windows.Forms.TextBox()
        Me.Obj_Liste_Config_Matieres = New System.Windows.Forms.ListView()
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Obj_Bt_Retirer_Salle = New System.Windows.Forms.Button()
        Me.Obj_Bt_Ajouter_Salle = New System.Windows.Forms.Button()
        Me.Obj_Bt_Retirer_Classe = New System.Windows.Forms.Button()
        Me.Obj_Bt_Ajouter_Classe = New System.Windows.Forms.Button()
        Me.Obj_Bt_Retirer_Enseignant = New System.Windows.Forms.Button()
        Me.Obj_Bt_Ajouter_Enseignant = New System.Windows.Forms.Button()
        Me.Obj_Img_Enseignant = New System.Windows.Forms.PictureBox()
        Me.Obj_Img_Classe = New System.Windows.Forms.PictureBox()
        Me.Obj_Img_Salle = New System.Windows.Forms.PictureBox()
        Me.Obj_Zt_Salle = New System.Windows.Forms.TextBox()
        Me.Obj_Zt_Classe = New System.Windows.Forms.TextBox()
        Me.Obj_Zt_Enseignant = New System.Windows.Forms.TextBox()
        Me.Obj_Liste_Config_Salles = New System.Windows.Forms.ListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Obj_Liste_Config_Classes = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Obj_Liste_Config_Enseignants = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Obj_Split_Principal = New System.Windows.Forms.SplitContainer()
        Me.Obj_Split_Haut = New System.Windows.Forms.SplitContainer()
        Me.Obj_Split_Bas = New System.Windows.Forms.SplitContainer()
        Me.Obj_Liste_Matieres = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Obj_Liste_Duree = New System.Windows.Forms.ComboBox()
        Me.Obj_Bt_Calcul_Temps = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Obj_Img_Duree2 = New System.Windows.Forms.PictureBox()
        Me.Obj_Cadre = New System.Windows.Forms.Panel()
        Me.Obj_Image = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ChargerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChargerListesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrersousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExporterJPGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExporterHTMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExporterCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Obj_Bt_PleinEcran = New System.Windows.Forms.Button()
        Me.Obj_Bt_Normal = New System.Windows.Forms.Button()
        Me.Boj_Bt_Zoom = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Obj_Onglets.SuspendLayout()
        Me.Obj_Onglet_Donnees.SuspendLayout()
        CType(Me.Obj_Img_Matiere, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Obj_Img_Enseignant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Obj_Img_Classe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Obj_Img_Salle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.Obj_Split_Principal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Obj_Split_Principal.Panel1.SuspendLayout()
        Me.Obj_Split_Principal.Panel2.SuspendLayout()
        Me.Obj_Split_Principal.SuspendLayout()
        CType(Me.Obj_Split_Haut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Obj_Split_Haut.Panel1.SuspendLayout()
        Me.Obj_Split_Haut.Panel2.SuspendLayout()
        Me.Obj_Split_Haut.SuspendLayout()
        CType(Me.Obj_Split_Bas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Obj_Split_Bas.Panel1.SuspendLayout()
        Me.Obj_Split_Bas.Panel2.SuspendLayout()
        Me.Obj_Split_Bas.SuspendLayout()
        CType(Me.Obj_Img_Duree2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Obj_Cadre.SuspendLayout()
        CType(Me.Obj_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Obj_Liste_Plannings
        '
        Me.Obj_Liste_Plannings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Obj_Liste_Plannings.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Obj_Liste_Plannings.FormattingEnabled = True
        Me.Obj_Liste_Plannings.Location = New System.Drawing.Point(441, 36)
        Me.Obj_Liste_Plannings.Name = "Obj_Liste_Plannings"
        Me.Obj_Liste_Plannings.Size = New System.Drawing.Size(225, 32)
        Me.Obj_Liste_Plannings.TabIndex = 1
        '
        'Obj_Liste2
        '
        Me.Obj_Liste2.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.Obj_Liste2.CheckBoxes = True
        Me.Obj_Liste2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.Obj_Liste2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Obj_Liste2.HideSelection = False
        Me.Obj_Liste2.Location = New System.Drawing.Point(0, 0)
        Me.Obj_Liste2.MultiSelect = False
        Me.Obj_Liste2.Name = "Obj_Liste2"
        Me.Obj_Liste2.Size = New System.Drawing.Size(361, 166)
        Me.Obj_Liste2.TabIndex = 3
        Me.Obj_Liste2.UseCompatibleStateImageBehavior = False
        Me.Obj_Liste2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        Me.ColumnHeader1.Width = 40
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Enseignant"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nb heures"
        Me.ColumnHeader3.Width = 70
        '
        'Obj_Liste1
        '
        Me.Obj_Liste1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.Obj_Liste1.CheckBoxes = True
        Me.Obj_Liste1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.Obj_Liste1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Obj_Liste1.HideSelection = False
        Me.Obj_Liste1.Location = New System.Drawing.Point(0, 0)
        Me.Obj_Liste1.MultiSelect = False
        Me.Obj_Liste1.Name = "Obj_Liste1"
        Me.Obj_Liste1.Size = New System.Drawing.Size(361, 180)
        Me.Obj_Liste1.TabIndex = 4
        Me.Obj_Liste1.UseCompatibleStateImageBehavior = False
        Me.Obj_Liste1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = ""
        Me.ColumnHeader5.Width = 40
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Salle"
        Me.ColumnHeader6.Width = 200
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Nb heures"
        Me.ColumnHeader7.Width = 70
        '
        'Obj_Mode_Classes
        '
        Me.Obj_Mode_Classes.Image = Global.Planning.My.Resources.Resources.travail_en_equipe
        Me.Obj_Mode_Classes.Location = New System.Drawing.Point(11, 39)
        Me.Obj_Mode_Classes.Name = "Obj_Mode_Classes"
        Me.Obj_Mode_Classes.Size = New System.Drawing.Size(75, 57)
        Me.Obj_Mode_Classes.TabIndex = 7
        Me.Obj_Mode_Classes.UseVisualStyleBackColor = True
        '
        'Obj_Mode_Salles
        '
        Me.Obj_Mode_Salles.Image = Global.Planning.My.Resources.Resources.salle_de_classe
        Me.Obj_Mode_Salles.Location = New System.Drawing.Point(92, 39)
        Me.Obj_Mode_Salles.Name = "Obj_Mode_Salles"
        Me.Obj_Mode_Salles.Size = New System.Drawing.Size(75, 57)
        Me.Obj_Mode_Salles.TabIndex = 8
        Me.Obj_Mode_Salles.Text = "Salles"
        Me.Obj_Mode_Salles.UseVisualStyleBackColor = True
        '
        'Obj_Mode_Enseignants
        '
        Me.Obj_Mode_Enseignants.Image = Global.Planning.My.Resources.Resources.enseignement
        Me.Obj_Mode_Enseignants.Location = New System.Drawing.Point(173, 39)
        Me.Obj_Mode_Enseignants.Name = "Obj_Mode_Enseignants"
        Me.Obj_Mode_Enseignants.Size = New System.Drawing.Size(75, 57)
        Me.Obj_Mode_Enseignants.TabIndex = 9
        Me.Obj_Mode_Enseignants.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Planning.My.Resources.Resources.calendrier
        Me.PictureBox1.Location = New System.Drawing.Point(391, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Obj_Onglets
        '
        Me.Obj_Onglets.Controls.Add(Me.Obj_Onglet_Donnees)
        Me.Obj_Onglets.Controls.Add(Me.TabPage1)
        Me.Obj_Onglets.Location = New System.Drawing.Point(12, 133)
        Me.Obj_Onglets.Name = "Obj_Onglets"
        Me.Obj_Onglets.SelectedIndex = 0
        Me.Obj_Onglets.Size = New System.Drawing.Size(375, 597)
        Me.Obj_Onglets.TabIndex = 12
        '
        'Obj_Onglet_Donnees
        '
        Me.Obj_Onglet_Donnees.Controls.Add(Me.Obj_Valider_Matieres)
        Me.Obj_Onglet_Donnees.Controls.Add(Me.Obj_Bt_Reinitialiser)
        Me.Obj_Onglet_Donnees.Controls.Add(Me.Obj_Bt_Retirer_Matiere)
        Me.Obj_Onglet_Donnees.Controls.Add(Me.Obj_Bt_Ajouter_Matiere)
        Me.Obj_Onglet_Donnees.Controls.Add(Me.Obj_Img_Matiere)
        Me.Obj_Onglet_Donnees.Controls.Add(Me.Obj_Zt_Matiere)
        Me.Obj_Onglet_Donnees.Controls.Add(Me.Obj_Liste_Config_Matieres)
        Me.Obj_Onglet_Donnees.Controls.Add(Me.Obj_Bt_Retirer_Salle)
        Me.Obj_Onglet_Donnees.Controls.Add(Me.Obj_Bt_Ajouter_Salle)
        Me.Obj_Onglet_Donnees.Controls.Add(Me.Obj_Bt_Retirer_Classe)
        Me.Obj_Onglet_Donnees.Controls.Add(Me.Obj_Bt_Ajouter_Classe)
        Me.Obj_Onglet_Donnees.Controls.Add(Me.Obj_Bt_Retirer_Enseignant)
        Me.Obj_Onglet_Donnees.Controls.Add(Me.Obj_Bt_Ajouter_Enseignant)
        Me.Obj_Onglet_Donnees.Controls.Add(Me.Obj_Img_Enseignant)
        Me.Obj_Onglet_Donnees.Controls.Add(Me.Obj_Img_Classe)
        Me.Obj_Onglet_Donnees.Controls.Add(Me.Obj_Img_Salle)
        Me.Obj_Onglet_Donnees.Controls.Add(Me.Obj_Zt_Salle)
        Me.Obj_Onglet_Donnees.Controls.Add(Me.Obj_Zt_Classe)
        Me.Obj_Onglet_Donnees.Controls.Add(Me.Obj_Zt_Enseignant)
        Me.Obj_Onglet_Donnees.Controls.Add(Me.Obj_Liste_Config_Salles)
        Me.Obj_Onglet_Donnees.Controls.Add(Me.Obj_Liste_Config_Classes)
        Me.Obj_Onglet_Donnees.Controls.Add(Me.Obj_Liste_Config_Enseignants)
        Me.Obj_Onglet_Donnees.Location = New System.Drawing.Point(4, 22)
        Me.Obj_Onglet_Donnees.Name = "Obj_Onglet_Donnees"
        Me.Obj_Onglet_Donnees.Padding = New System.Windows.Forms.Padding(3)
        Me.Obj_Onglet_Donnees.Size = New System.Drawing.Size(367, 571)
        Me.Obj_Onglet_Donnees.TabIndex = 1
        Me.Obj_Onglet_Donnees.Text = "Réglages"
        Me.Obj_Onglet_Donnees.UseVisualStyleBackColor = True
        '
        'Obj_Valider_Matieres
        '
        Me.Obj_Valider_Matieres.Image = Global.Planning.My.Resources.Resources.plus
        Me.Obj_Valider_Matieres.Location = New System.Drawing.Point(248, 442)
        Me.Obj_Valider_Matieres.Name = "Obj_Valider_Matieres"
        Me.Obj_Valider_Matieres.Size = New System.Drawing.Size(113, 118)
        Me.Obj_Valider_Matieres.TabIndex = 26
        Me.Obj_Valider_Matieres.UseVisualStyleBackColor = True
        '
        'Obj_Bt_Reinitialiser
        '
        Me.Obj_Bt_Reinitialiser.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Obj_Bt_Reinitialiser.Image = Global.Planning.My.Resources.Resources.explosion_nucleaire
        Me.Obj_Bt_Reinitialiser.Location = New System.Drawing.Point(248, 8)
        Me.Obj_Bt_Reinitialiser.Name = "Obj_Bt_Reinitialiser"
        Me.Obj_Bt_Reinitialiser.Size = New System.Drawing.Size(113, 412)
        Me.Obj_Bt_Reinitialiser.TabIndex = 25
        Me.Obj_Bt_Reinitialiser.UseVisualStyleBackColor = False
        '
        'Obj_Bt_Retirer_Matiere
        '
        Me.Obj_Bt_Retirer_Matiere.Location = New System.Drawing.Point(208, 442)
        Me.Obj_Bt_Retirer_Matiere.Name = "Obj_Bt_Retirer_Matiere"
        Me.Obj_Bt_Retirer_Matiere.Size = New System.Drawing.Size(25, 23)
        Me.Obj_Bt_Retirer_Matiere.TabIndex = 24
        Me.Obj_Bt_Retirer_Matiere.Text = "-"
        Me.Obj_Bt_Retirer_Matiere.UseVisualStyleBackColor = True
        '
        'Obj_Bt_Ajouter_Matiere
        '
        Me.Obj_Bt_Ajouter_Matiere.Location = New System.Drawing.Point(184, 442)
        Me.Obj_Bt_Ajouter_Matiere.Name = "Obj_Bt_Ajouter_Matiere"
        Me.Obj_Bt_Ajouter_Matiere.Size = New System.Drawing.Size(25, 23)
        Me.Obj_Bt_Ajouter_Matiere.TabIndex = 23
        Me.Obj_Bt_Ajouter_Matiere.Text = "+"
        Me.Obj_Bt_Ajouter_Matiere.UseVisualStyleBackColor = True
        '
        'Obj_Img_Matiere
        '
        Me.Obj_Img_Matiere.Image = Global.Planning.My.Resources.Resources.livres
        Me.Obj_Img_Matiere.Location = New System.Drawing.Point(9, 442)
        Me.Obj_Img_Matiere.Name = "Obj_Img_Matiere"
        Me.Obj_Img_Matiere.Size = New System.Drawing.Size(24, 24)
        Me.Obj_Img_Matiere.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Obj_Img_Matiere.TabIndex = 22
        Me.Obj_Img_Matiere.TabStop = False
        '
        'Obj_Zt_Matiere
        '
        Me.Obj_Zt_Matiere.Location = New System.Drawing.Point(39, 445)
        Me.Obj_Zt_Matiere.MaxLength = 20
        Me.Obj_Zt_Matiere.Name = "Obj_Zt_Matiere"
        Me.Obj_Zt_Matiere.Size = New System.Drawing.Size(143, 20)
        Me.Obj_Zt_Matiere.TabIndex = 21
        '
        'Obj_Liste_Config_Matieres
        '
        Me.Obj_Liste_Config_Matieres.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.Obj_Liste_Config_Matieres.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader14})
        Me.Obj_Liste_Config_Matieres.FullRowSelect = True
        Me.Obj_Liste_Config_Matieres.GridLines = True
        Me.Obj_Liste_Config_Matieres.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.Obj_Liste_Config_Matieres.HideSelection = False
        Me.Obj_Liste_Config_Matieres.HotTracking = True
        Me.Obj_Liste_Config_Matieres.HoverSelection = True
        Me.Obj_Liste_Config_Matieres.Location = New System.Drawing.Point(9, 468)
        Me.Obj_Liste_Config_Matieres.Name = "Obj_Liste_Config_Matieres"
        Me.Obj_Liste_Config_Matieres.Size = New System.Drawing.Size(224, 92)
        Me.Obj_Liste_Config_Matieres.TabIndex = 20
        Me.Obj_Liste_Config_Matieres.UseCompatibleStateImageBehavior = False
        Me.Obj_Liste_Config_Matieres.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Matière"
        Me.ColumnHeader14.Width = 150
        '
        'Obj_Bt_Retirer_Salle
        '
        Me.Obj_Bt_Retirer_Salle.Location = New System.Drawing.Point(208, 302)
        Me.Obj_Bt_Retirer_Salle.Name = "Obj_Bt_Retirer_Salle"
        Me.Obj_Bt_Retirer_Salle.Size = New System.Drawing.Size(25, 23)
        Me.Obj_Bt_Retirer_Salle.TabIndex = 19
        Me.Obj_Bt_Retirer_Salle.Text = "-"
        Me.Obj_Bt_Retirer_Salle.UseVisualStyleBackColor = True
        '
        'Obj_Bt_Ajouter_Salle
        '
        Me.Obj_Bt_Ajouter_Salle.Location = New System.Drawing.Point(184, 302)
        Me.Obj_Bt_Ajouter_Salle.Name = "Obj_Bt_Ajouter_Salle"
        Me.Obj_Bt_Ajouter_Salle.Size = New System.Drawing.Size(25, 23)
        Me.Obj_Bt_Ajouter_Salle.TabIndex = 18
        Me.Obj_Bt_Ajouter_Salle.Text = "+"
        Me.Obj_Bt_Ajouter_Salle.UseVisualStyleBackColor = True
        '
        'Obj_Bt_Retirer_Classe
        '
        Me.Obj_Bt_Retirer_Classe.Location = New System.Drawing.Point(208, 170)
        Me.Obj_Bt_Retirer_Classe.Name = "Obj_Bt_Retirer_Classe"
        Me.Obj_Bt_Retirer_Classe.Size = New System.Drawing.Size(25, 23)
        Me.Obj_Bt_Retirer_Classe.TabIndex = 17
        Me.Obj_Bt_Retirer_Classe.Text = "-"
        Me.Obj_Bt_Retirer_Classe.UseVisualStyleBackColor = True
        '
        'Obj_Bt_Ajouter_Classe
        '
        Me.Obj_Bt_Ajouter_Classe.Location = New System.Drawing.Point(184, 170)
        Me.Obj_Bt_Ajouter_Classe.Name = "Obj_Bt_Ajouter_Classe"
        Me.Obj_Bt_Ajouter_Classe.Size = New System.Drawing.Size(25, 23)
        Me.Obj_Bt_Ajouter_Classe.TabIndex = 16
        Me.Obj_Bt_Ajouter_Classe.Text = "+"
        Me.Obj_Bt_Ajouter_Classe.UseVisualStyleBackColor = True
        '
        'Obj_Bt_Retirer_Enseignant
        '
        Me.Obj_Bt_Retirer_Enseignant.Location = New System.Drawing.Point(208, 8)
        Me.Obj_Bt_Retirer_Enseignant.Name = "Obj_Bt_Retirer_Enseignant"
        Me.Obj_Bt_Retirer_Enseignant.Size = New System.Drawing.Size(25, 23)
        Me.Obj_Bt_Retirer_Enseignant.TabIndex = 15
        Me.Obj_Bt_Retirer_Enseignant.Text = "-"
        Me.Obj_Bt_Retirer_Enseignant.UseVisualStyleBackColor = True
        '
        'Obj_Bt_Ajouter_Enseignant
        '
        Me.Obj_Bt_Ajouter_Enseignant.Location = New System.Drawing.Point(184, 8)
        Me.Obj_Bt_Ajouter_Enseignant.Name = "Obj_Bt_Ajouter_Enseignant"
        Me.Obj_Bt_Ajouter_Enseignant.Size = New System.Drawing.Size(25, 23)
        Me.Obj_Bt_Ajouter_Enseignant.TabIndex = 14
        Me.Obj_Bt_Ajouter_Enseignant.Text = "+"
        Me.Obj_Bt_Ajouter_Enseignant.UseVisualStyleBackColor = True
        '
        'Obj_Img_Enseignant
        '
        Me.Obj_Img_Enseignant.Image = Global.Planning.My.Resources.Resources.enseignement
        Me.Obj_Img_Enseignant.Location = New System.Drawing.Point(9, 6)
        Me.Obj_Img_Enseignant.Name = "Obj_Img_Enseignant"
        Me.Obj_Img_Enseignant.Size = New System.Drawing.Size(24, 24)
        Me.Obj_Img_Enseignant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Obj_Img_Enseignant.TabIndex = 13
        Me.Obj_Img_Enseignant.TabStop = False
        '
        'Obj_Img_Classe
        '
        Me.Obj_Img_Classe.Image = Global.Planning.My.Resources.Resources.travail_en_equipe
        Me.Obj_Img_Classe.Location = New System.Drawing.Point(9, 169)
        Me.Obj_Img_Classe.Name = "Obj_Img_Classe"
        Me.Obj_Img_Classe.Size = New System.Drawing.Size(24, 24)
        Me.Obj_Img_Classe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Obj_Img_Classe.TabIndex = 12
        Me.Obj_Img_Classe.TabStop = False
        '
        'Obj_Img_Salle
        '
        Me.Obj_Img_Salle.Image = Global.Planning.My.Resources.Resources.salle_de_classe
        Me.Obj_Img_Salle.Location = New System.Drawing.Point(9, 302)
        Me.Obj_Img_Salle.Name = "Obj_Img_Salle"
        Me.Obj_Img_Salle.Size = New System.Drawing.Size(24, 24)
        Me.Obj_Img_Salle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Obj_Img_Salle.TabIndex = 11
        Me.Obj_Img_Salle.TabStop = False
        '
        'Obj_Zt_Salle
        '
        Me.Obj_Zt_Salle.Location = New System.Drawing.Point(39, 305)
        Me.Obj_Zt_Salle.MaxLength = 20
        Me.Obj_Zt_Salle.Name = "Obj_Zt_Salle"
        Me.Obj_Zt_Salle.Size = New System.Drawing.Size(143, 20)
        Me.Obj_Zt_Salle.TabIndex = 10
        '
        'Obj_Zt_Classe
        '
        Me.Obj_Zt_Classe.Location = New System.Drawing.Point(39, 173)
        Me.Obj_Zt_Classe.MaxLength = 20
        Me.Obj_Zt_Classe.Name = "Obj_Zt_Classe"
        Me.Obj_Zt_Classe.Size = New System.Drawing.Size(143, 20)
        Me.Obj_Zt_Classe.TabIndex = 9
        '
        'Obj_Zt_Enseignant
        '
        Me.Obj_Zt_Enseignant.Location = New System.Drawing.Point(39, 10)
        Me.Obj_Zt_Enseignant.MaxLength = 20
        Me.Obj_Zt_Enseignant.Name = "Obj_Zt_Enseignant"
        Me.Obj_Zt_Enseignant.Size = New System.Drawing.Size(143, 20)
        Me.Obj_Zt_Enseignant.TabIndex = 8
        '
        'Obj_Liste_Config_Salles
        '
        Me.Obj_Liste_Config_Salles.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.Obj_Liste_Config_Salles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12})
        Me.Obj_Liste_Config_Salles.FullRowSelect = True
        Me.Obj_Liste_Config_Salles.GridLines = True
        Me.Obj_Liste_Config_Salles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.Obj_Liste_Config_Salles.HideSelection = False
        Me.Obj_Liste_Config_Salles.HotTracking = True
        Me.Obj_Liste_Config_Salles.HoverSelection = True
        Me.Obj_Liste_Config_Salles.Location = New System.Drawing.Point(9, 328)
        Me.Obj_Liste_Config_Salles.Name = "Obj_Liste_Config_Salles"
        Me.Obj_Liste_Config_Salles.Size = New System.Drawing.Size(224, 92)
        Me.Obj_Liste_Config_Salles.TabIndex = 7
        Me.Obj_Liste_Config_Salles.UseCompatibleStateImageBehavior = False
        Me.Obj_Liste_Config_Salles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Salle"
        Me.ColumnHeader12.Width = 150
        '
        'Obj_Liste_Config_Classes
        '
        Me.Obj_Liste_Config_Classes.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.Obj_Liste_Config_Classes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10})
        Me.Obj_Liste_Config_Classes.FullRowSelect = True
        Me.Obj_Liste_Config_Classes.GridLines = True
        Me.Obj_Liste_Config_Classes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.Obj_Liste_Config_Classes.HideSelection = False
        Me.Obj_Liste_Config_Classes.HotTracking = True
        Me.Obj_Liste_Config_Classes.HoverSelection = True
        Me.Obj_Liste_Config_Classes.Location = New System.Drawing.Point(9, 195)
        Me.Obj_Liste_Config_Classes.Name = "Obj_Liste_Config_Classes"
        Me.Obj_Liste_Config_Classes.Size = New System.Drawing.Size(224, 101)
        Me.Obj_Liste_Config_Classes.TabIndex = 6
        Me.Obj_Liste_Config_Classes.UseCompatibleStateImageBehavior = False
        Me.Obj_Liste_Config_Classes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Classe"
        Me.ColumnHeader10.Width = 150
        '
        'Obj_Liste_Config_Enseignants
        '
        Me.Obj_Liste_Config_Enseignants.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.Obj_Liste_Config_Enseignants.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8})
        Me.Obj_Liste_Config_Enseignants.FullRowSelect = True
        Me.Obj_Liste_Config_Enseignants.GridLines = True
        Me.Obj_Liste_Config_Enseignants.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.Obj_Liste_Config_Enseignants.HideSelection = False
        Me.Obj_Liste_Config_Enseignants.HotTracking = True
        Me.Obj_Liste_Config_Enseignants.HoverSelection = True
        Me.Obj_Liste_Config_Enseignants.Location = New System.Drawing.Point(9, 32)
        Me.Obj_Liste_Config_Enseignants.Name = "Obj_Liste_Config_Enseignants"
        Me.Obj_Liste_Config_Enseignants.Size = New System.Drawing.Size(224, 131)
        Me.Obj_Liste_Config_Enseignants.TabIndex = 5
        Me.Obj_Liste_Config_Enseignants.UseCompatibleStateImageBehavior = False
        Me.Obj_Liste_Config_Enseignants.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Enseignant"
        Me.ColumnHeader8.Width = 150
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Obj_Split_Principal)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(367, 571)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Attribution"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Obj_Split_Principal
        '
        Me.Obj_Split_Principal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Obj_Split_Principal.Location = New System.Drawing.Point(3, 3)
        Me.Obj_Split_Principal.Name = "Obj_Split_Principal"
        Me.Obj_Split_Principal.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Obj_Split_Principal.Panel1
        '
        Me.Obj_Split_Principal.Panel1.Controls.Add(Me.Obj_Split_Haut)
        '
        'Obj_Split_Principal.Panel2
        '
        Me.Obj_Split_Principal.Panel2.Controls.Add(Me.Obj_Split_Bas)
        Me.Obj_Split_Principal.Size = New System.Drawing.Size(361, 565)
        Me.Obj_Split_Principal.SplitterDistance = 350
        Me.Obj_Split_Principal.TabIndex = 1
        '
        'Obj_Split_Haut
        '
        Me.Obj_Split_Haut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Obj_Split_Haut.Location = New System.Drawing.Point(0, 0)
        Me.Obj_Split_Haut.Name = "Obj_Split_Haut"
        Me.Obj_Split_Haut.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Obj_Split_Haut.Panel1
        '
        Me.Obj_Split_Haut.Panel1.Controls.Add(Me.Obj_Liste1)
        '
        'Obj_Split_Haut.Panel2
        '
        Me.Obj_Split_Haut.Panel2.Controls.Add(Me.Obj_Liste2)
        Me.Obj_Split_Haut.Size = New System.Drawing.Size(361, 350)
        Me.Obj_Split_Haut.SplitterDistance = 180
        Me.Obj_Split_Haut.TabIndex = 0
        '
        'Obj_Split_Bas
        '
        Me.Obj_Split_Bas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Obj_Split_Bas.IsSplitterFixed = True
        Me.Obj_Split_Bas.Location = New System.Drawing.Point(0, 0)
        Me.Obj_Split_Bas.Name = "Obj_Split_Bas"
        Me.Obj_Split_Bas.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Obj_Split_Bas.Panel1
        '
        Me.Obj_Split_Bas.Panel1.Controls.Add(Me.Obj_Liste_Matieres)
        '
        'Obj_Split_Bas.Panel2
        '
        Me.Obj_Split_Bas.Panel2.Controls.Add(Me.Label2)
        Me.Obj_Split_Bas.Panel2.Controls.Add(Me.Obj_Liste_Duree)
        Me.Obj_Split_Bas.Panel2.Controls.Add(Me.Obj_Bt_Calcul_Temps)
        Me.Obj_Split_Bas.Panel2.Controls.Add(Me.Label1)
        Me.Obj_Split_Bas.Panel2.Controls.Add(Me.Obj_Img_Duree2)
        Me.Obj_Split_Bas.Size = New System.Drawing.Size(361, 211)
        Me.Obj_Split_Bas.SplitterDistance = 121
        Me.Obj_Split_Bas.TabIndex = 0
        '
        'Obj_Liste_Matieres
        '
        Me.Obj_Liste_Matieres.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.Obj_Liste_Matieres.CheckBoxes = True
        Me.Obj_Liste_Matieres.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader9, Me.ColumnHeader11})
        Me.Obj_Liste_Matieres.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Obj_Liste_Matieres.HideSelection = False
        Me.Obj_Liste_Matieres.Location = New System.Drawing.Point(0, 0)
        Me.Obj_Liste_Matieres.MultiSelect = False
        Me.Obj_Liste_Matieres.Name = "Obj_Liste_Matieres"
        Me.Obj_Liste_Matieres.Size = New System.Drawing.Size(361, 121)
        Me.Obj_Liste_Matieres.TabIndex = 4
        Me.Obj_Liste_Matieres.UseCompatibleStateImageBehavior = False
        Me.Obj_Liste_Matieres.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = ""
        Me.ColumnHeader4.Width = 40
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Matières"
        Me.ColumnHeader9.Width = 200
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Nb heures"
        Me.ColumnHeader11.Width = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Matière :"
        '
        'Obj_Liste_Duree
        '
        Me.Obj_Liste_Duree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Obj_Liste_Duree.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Obj_Liste_Duree.FormattingEnabled = True
        Me.Obj_Liste_Duree.Items.AddRange(New Object() {"00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00"})
        Me.Obj_Liste_Duree.Location = New System.Drawing.Point(154, 47)
        Me.Obj_Liste_Duree.Name = "Obj_Liste_Duree"
        Me.Obj_Liste_Duree.Size = New System.Drawing.Size(123, 32)
        Me.Obj_Liste_Duree.TabIndex = 11
        '
        'Obj_Bt_Calcul_Temps
        '
        Me.Obj_Bt_Calcul_Temps.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Obj_Bt_Calcul_Temps.Image = Global.Planning.My.Resources.Resources.calculatrice
        Me.Obj_Bt_Calcul_Temps.Location = New System.Drawing.Point(320, 45)
        Me.Obj_Bt_Calcul_Temps.Name = "Obj_Bt_Calcul_Temps"
        Me.Obj_Bt_Calcul_Temps.Size = New System.Drawing.Size(38, 38)
        Me.Obj_Bt_Calcul_Temps.TabIndex = 25
        Me.Obj_Bt_Calcul_Temps.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Durée :"
        '
        'Obj_Img_Duree2
        '
        Me.Obj_Img_Duree2.Image = Global.Planning.My.Resources.Resources.duree
        Me.Obj_Img_Duree2.Location = New System.Drawing.Point(62, 45)
        Me.Obj_Img_Duree2.Name = "Obj_Img_Duree2"
        Me.Obj_Img_Duree2.Size = New System.Drawing.Size(32, 32)
        Me.Obj_Img_Duree2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Obj_Img_Duree2.TabIndex = 24
        Me.Obj_Img_Duree2.TabStop = False
        '
        'Obj_Cadre
        '
        Me.Obj_Cadre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Obj_Cadre.AutoScroll = True
        Me.Obj_Cadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Obj_Cadre.Controls.Add(Me.Obj_Image)
        Me.Obj_Cadre.Location = New System.Drawing.Point(392, 74)
        Me.Obj_Cadre.Name = "Obj_Cadre"
        Me.Obj_Cadre.Size = New System.Drawing.Size(987, 656)
        Me.Obj_Cadre.TabIndex = 13
        '
        'Obj_Image
        '
        Me.Obj_Image.Location = New System.Drawing.Point(3, 3)
        Me.Obj_Image.Name = "Obj_Image"
        Me.Obj_Image.Size = New System.Drawing.Size(548, 626)
        Me.Obj_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Obj_Image.TabIndex = 0
        Me.Obj_Image.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 30
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.ActionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1392, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauToolStripMenuItem, Me.ToolStripMenuItem2, Me.ChargerToolStripMenuItem, Me.ChargerListesToolStripMenuItem, Me.SOSToolStripMenuItem, Me.EnregistrerToolStripMenuItem, Me.EnregistrersousToolStripMenuItem, Me.ToolStripMenuItem1, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "&Fichier"
        '
        'NouveauToolStripMenuItem
        '
        Me.NouveauToolStripMenuItem.Name = "NouveauToolStripMenuItem"
        Me.NouveauToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.NouveauToolStripMenuItem.Text = "&Nouveau"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(166, 6)
        '
        'ChargerToolStripMenuItem
        '
        Me.ChargerToolStripMenuItem.Name = "ChargerToolStripMenuItem"
        Me.ChargerToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ChargerToolStripMenuItem.Text = "Charger ..."
        '
        'ChargerListesToolStripMenuItem
        '
        Me.ChargerListesToolStripMenuItem.Name = "ChargerListesToolStripMenuItem"
        Me.ChargerListesToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ChargerListesToolStripMenuItem.Text = "Charger Listes ..."
        '
        'SOSToolStripMenuItem
        '
        Me.SOSToolStripMenuItem.Name = "SOSToolStripMenuItem"
        Me.SOSToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.SOSToolStripMenuItem.Text = "SOS"
        '
        'EnregistrerToolStripMenuItem
        '
        Me.EnregistrerToolStripMenuItem.Name = "EnregistrerToolStripMenuItem"
        Me.EnregistrerToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.EnregistrerToolStripMenuItem.Text = "&Enregistrer"
        '
        'EnregistrersousToolStripMenuItem
        '
        Me.EnregistrersousToolStripMenuItem.Name = "EnregistrersousToolStripMenuItem"
        Me.EnregistrersousToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.EnregistrersousToolStripMenuItem.Text = "Enregistrer &sous ..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(166, 6)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.QuitterToolStripMenuItem.Text = "&Quitter"
        '
        'ActionsToolStripMenuItem
        '
        Me.ActionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExporterJPGToolStripMenuItem, Me.ExporterHTMLToolStripMenuItem, Me.ExporterCSVToolStripMenuItem})
        Me.ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem"
        Me.ActionsToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.ActionsToolStripMenuItem.Text = "&Exporter"
        '
        'ExporterJPGToolStripMenuItem
        '
        Me.ExporterJPGToolStripMenuItem.Name = "ExporterJPGToolStripMenuItem"
        Me.ExporterJPGToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ExporterJPGToolStripMenuItem.Text = "Exporter JPG ..."
        '
        'ExporterHTMLToolStripMenuItem
        '
        Me.ExporterHTMLToolStripMenuItem.Name = "ExporterHTMLToolStripMenuItem"
        Me.ExporterHTMLToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ExporterHTMLToolStripMenuItem.Text = "Exporter HTML ..."
        '
        'ExporterCSVToolStripMenuItem
        '
        Me.ExporterCSVToolStripMenuItem.Name = "ExporterCSVToolStripMenuItem"
        Me.ExporterCSVToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ExporterCSVToolStripMenuItem.Text = "Exporter XLSX ..."
        '
        'Obj_Bt_PleinEcran
        '
        Me.Obj_Bt_PleinEcran.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Obj_Bt_PleinEcran.Image = Global.Planning.My.Resources.Resources.plein_ecran
        Me.Obj_Bt_PleinEcran.Location = New System.Drawing.Point(1341, 33)
        Me.Obj_Bt_PleinEcran.Name = "Obj_Bt_PleinEcran"
        Me.Obj_Bt_PleinEcran.Size = New System.Drawing.Size(38, 38)
        Me.Obj_Bt_PleinEcran.TabIndex = 15
        Me.Obj_Bt_PleinEcran.UseVisualStyleBackColor = True
        '
        'Obj_Bt_Normal
        '
        Me.Obj_Bt_Normal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Obj_Bt_Normal.Image = Global.Planning.My.Resources.Resources.redimensionnement_vertical
        Me.Obj_Bt_Normal.Location = New System.Drawing.Point(1297, 33)
        Me.Obj_Bt_Normal.Name = "Obj_Bt_Normal"
        Me.Obj_Bt_Normal.Size = New System.Drawing.Size(38, 38)
        Me.Obj_Bt_Normal.TabIndex = 16
        Me.Obj_Bt_Normal.UseVisualStyleBackColor = True
        '
        'Boj_Bt_Zoom
        '
        Me.Boj_Bt_Zoom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Boj_Bt_Zoom.Image = Global.Planning.My.Resources.Resources.redimensionnement_horizontal
        Me.Boj_Bt_Zoom.Location = New System.Drawing.Point(1253, 33)
        Me.Boj_Bt_Zoom.Name = "Boj_Bt_Zoom"
        Me.Boj_Bt_Zoom.Size = New System.Drawing.Size(38, 38)
        Me.Boj_Bt_Zoom.TabIndex = 17
        Me.Boj_Bt_Zoom.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Planning.My.Resources.Resources.back_to_school_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1392, 742)
        Me.Controls.Add(Me.Boj_Bt_Zoom)
        Me.Controls.Add(Me.Obj_Bt_Normal)
        Me.Controls.Add(Me.Obj_Bt_PleinEcran)
        Me.Controls.Add(Me.Obj_Cadre)
        Me.Controls.Add(Me.Obj_Onglets)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Obj_Mode_Enseignants)
        Me.Controls.Add(Me.Obj_Mode_Salles)
        Me.Controls.Add(Me.Obj_Mode_Classes)
        Me.Controls.Add(Me.Obj_Liste_Plannings)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Amandine - Planning"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Obj_Onglets.ResumeLayout(False)
        Me.Obj_Onglet_Donnees.ResumeLayout(False)
        Me.Obj_Onglet_Donnees.PerformLayout()
        CType(Me.Obj_Img_Matiere, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Obj_Img_Enseignant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Obj_Img_Classe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Obj_Img_Salle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.Obj_Split_Principal.Panel1.ResumeLayout(False)
        Me.Obj_Split_Principal.Panel2.ResumeLayout(False)
        CType(Me.Obj_Split_Principal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Obj_Split_Principal.ResumeLayout(False)
        Me.Obj_Split_Haut.Panel1.ResumeLayout(False)
        Me.Obj_Split_Haut.Panel2.ResumeLayout(False)
        CType(Me.Obj_Split_Haut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Obj_Split_Haut.ResumeLayout(False)
        Me.Obj_Split_Bas.Panel1.ResumeLayout(False)
        Me.Obj_Split_Bas.Panel2.ResumeLayout(False)
        Me.Obj_Split_Bas.Panel2.PerformLayout()
        CType(Me.Obj_Split_Bas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Obj_Split_Bas.ResumeLayout(False)
        CType(Me.Obj_Img_Duree2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Obj_Cadre.ResumeLayout(False)
        Me.Obj_Cadre.PerformLayout()
        CType(Me.Obj_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Obj_Liste_Plannings As ComboBox
    Friend WithEvents Obj_Liste2 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Obj_Liste1 As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Obj_Mode_Classes As Button
    Friend WithEvents Obj_Mode_Salles As Button
    Friend WithEvents Obj_Mode_Enseignants As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Obj_Onglets As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Obj_Onglet_Donnees As TabPage
    Friend WithEvents Obj_Bt_Retirer_Salle As Button
    Friend WithEvents Obj_Bt_Ajouter_Salle As Button
    Friend WithEvents Obj_Bt_Retirer_Classe As Button
    Friend WithEvents Obj_Bt_Ajouter_Classe As Button
    Friend WithEvents Obj_Bt_Retirer_Enseignant As Button
    Friend WithEvents Obj_Bt_Ajouter_Enseignant As Button
    Friend WithEvents Obj_Img_Enseignant As PictureBox
    Friend WithEvents Obj_Img_Classe As PictureBox
    Friend WithEvents Obj_Img_Salle As PictureBox
    Friend WithEvents Obj_Zt_Salle As TextBox
    Friend WithEvents Obj_Zt_Classe As TextBox
    Friend WithEvents Obj_Zt_Enseignant As TextBox
    Friend WithEvents Obj_Liste_Config_Salles As ListView
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents Obj_Liste_Config_Classes As ListView
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents Obj_Liste_Config_Enseignants As ListView
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Obj_Liste_Duree As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Obj_Cadre As Panel
    Friend WithEvents Obj_Image As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Obj_Bt_Retirer_Matiere As Button
    Friend WithEvents Obj_Bt_Ajouter_Matiere As Button
    Friend WithEvents Obj_Img_Matiere As PictureBox
    Friend WithEvents Obj_Zt_Matiere As TextBox
    Friend WithEvents Obj_Liste_Config_Matieres As ListView
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Obj_Img_Duree2 As PictureBox
    Friend WithEvents NouveauToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents Obj_Bt_PleinEcran As Button
    Friend WithEvents Obj_Bt_Normal As Button
    Friend WithEvents Boj_Bt_Zoom As Button
    Friend WithEvents Obj_Valider_Matieres As Button
    Friend WithEvents Obj_Bt_Reinitialiser As Button
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ChargerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnregistrerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnregistrersousToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExporterJPGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExporterHTMLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExporterCSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Obj_Bt_Calcul_Temps As Button
    Friend WithEvents Obj_Split_Principal As SplitContainer
    Friend WithEvents Obj_Split_Haut As SplitContainer
    Friend WithEvents Obj_Split_Bas As SplitContainer
    Friend WithEvents Obj_Liste_Matieres As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents SOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChargerListesToolStripMenuItem As ToolStripMenuItem
End Class
