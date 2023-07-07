<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Obj_Liste_Plannings = New System.Windows.Forms.ComboBox()
        Me.Obj_Liste2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Obj_Liste1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Obj_Mode_Classes = New System.Windows.Forms.Button()
        Me.Obj_Mode_Salles = New System.Windows.Forms.Button()
        Me.Obj_Mode_Enseignants = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Obj_Onglets = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Obj_Liste_Matiere = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Obj_Nb_Heures = New System.Windows.Forms.ComboBox()
        Me.Obj_Cadre = New System.Windows.Forms.Panel()
        Me.Obj_Image = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Obj_Opt_Gr1 = New System.Windows.Forms.RadioButton()
        Me.Obj_Opt_Gr2 = New System.Windows.Forms.RadioButton()
        Me.Obj_Opt_Classe = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Obj_Onglets.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.Obj_Cadre.SuspendLayout()
        CType(Me.Obj_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Obj_Liste_Plannings
        '
        Me.Obj_Liste_Plannings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Obj_Liste_Plannings.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Obj_Liste_Plannings.FormattingEnabled = True
        Me.Obj_Liste_Plannings.Location = New System.Drawing.Point(506, 12)
        Me.Obj_Liste_Plannings.Name = "Obj_Liste_Plannings"
        Me.Obj_Liste_Plannings.Size = New System.Drawing.Size(225, 32)
        Me.Obj_Liste_Plannings.TabIndex = 1
        '
        'Obj_Liste2
        '
        Me.Obj_Liste2.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.Obj_Liste2.CheckBoxes = True
        Me.Obj_Liste2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.Obj_Liste2.HideSelection = False
        Me.Obj_Liste2.Location = New System.Drawing.Point(6, 168)
        Me.Obj_Liste2.MultiSelect = False
        Me.Obj_Liste2.Name = "Obj_Liste2"
        Me.Obj_Liste2.Size = New System.Drawing.Size(354, 176)
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
        Me.Obj_Liste1.HideSelection = False
        Me.Obj_Liste1.Location = New System.Drawing.Point(6, 6)
        Me.Obj_Liste1.MultiSelect = False
        Me.Obj_Liste1.Name = "Obj_Liste1"
        Me.Obj_Liste1.Size = New System.Drawing.Size(354, 156)
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
        Me.ColumnHeader6.Text = "Enseignant"
        Me.ColumnHeader6.Width = 200
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Nb heures"
        Me.ColumnHeader7.Width = 70
        '
        'Button1
        '
        Me.Button1.Image = Global.Planning.My.Resources.Resources.fleche_droite
        Me.Button1.Location = New System.Drawing.Point(365, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 69)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Obj_Mode_Classes
        '
        Me.Obj_Mode_Classes.Image = Global.Planning.My.Resources.Resources.travail_en_equipe
        Me.Obj_Mode_Classes.Location = New System.Drawing.Point(12, 12)
        Me.Obj_Mode_Classes.Name = "Obj_Mode_Classes"
        Me.Obj_Mode_Classes.Size = New System.Drawing.Size(75, 57)
        Me.Obj_Mode_Classes.TabIndex = 7
        Me.Obj_Mode_Classes.UseVisualStyleBackColor = True
        '
        'Obj_Mode_Salles
        '
        Me.Obj_Mode_Salles.Image = Global.Planning.My.Resources.Resources.salle_de_classe
        Me.Obj_Mode_Salles.Location = New System.Drawing.Point(93, 12)
        Me.Obj_Mode_Salles.Name = "Obj_Mode_Salles"
        Me.Obj_Mode_Salles.Size = New System.Drawing.Size(75, 57)
        Me.Obj_Mode_Salles.TabIndex = 8
        Me.Obj_Mode_Salles.Text = "Salles"
        Me.Obj_Mode_Salles.UseVisualStyleBackColor = True
        '
        'Obj_Mode_Enseignants
        '
        Me.Obj_Mode_Enseignants.Image = Global.Planning.My.Resources.Resources.enseignement
        Me.Obj_Mode_Enseignants.Location = New System.Drawing.Point(174, 12)
        Me.Obj_Mode_Enseignants.Name = "Obj_Mode_Enseignants"
        Me.Obj_Mode_Enseignants.Size = New System.Drawing.Size(75, 57)
        Me.Obj_Mode_Enseignants.TabIndex = 9
        Me.Obj_Mode_Enseignants.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Planning.My.Resources.Resources.effacer
        Me.Button2.Location = New System.Drawing.Point(365, 259)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 69)
        Me.Button2.TabIndex = 10
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Planning.My.Resources.Resources.calendrier
        Me.PictureBox1.Location = New System.Drawing.Point(456, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Obj_Onglets
        '
        Me.Obj_Onglets.Controls.Add(Me.TabPage2)
        Me.Obj_Onglets.Controls.Add(Me.TabPage1)
        Me.Obj_Onglets.Location = New System.Drawing.Point(12, 115)
        Me.Obj_Onglets.Name = "Obj_Onglets"
        Me.Obj_Onglets.SelectedIndex = 0
        Me.Obj_Onglets.Size = New System.Drawing.Size(438, 568)
        Me.Obj_Onglets.TabIndex = 12
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button7)
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.PictureBox4)
        Me.TabPage2.Controls.Add(Me.PictureBox3)
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Controls.Add(Me.TextBox3)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.ListView3)
        Me.TabPage2.Controls.Add(Me.ListView2)
        Me.TabPage2.Controls.Add(Me.ListView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(430, 542)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Réglages"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(208, 355)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(25, 23)
        Me.Button7.TabIndex = 19
        Me.Button7.Text = "-"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(184, 355)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(25, 23)
        Me.Button8.TabIndex = 18
        Me.Button8.Text = "+"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(208, 186)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(25, 23)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "-"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(184, 186)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(25, 23)
        Me.Button6.TabIndex = 16
        Me.Button6.Text = "+"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(208, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 23)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "-"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(184, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "+"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Planning.My.Resources.Resources.enseignement
        Me.PictureBox4.Location = New System.Drawing.Point(9, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Planning.My.Resources.Resources.travail_en_equipe
        Me.PictureBox3.Location = New System.Drawing.Point(9, 185)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Planning.My.Resources.Resources.salle_de_classe
        Me.PictureBox2.Location = New System.Drawing.Point(9, 355)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(39, 358)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(143, 20)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(39, 189)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(143, 20)
        Me.TextBox2.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(39, 10)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(143, 20)
        Me.TextBox1.TabIndex = 8
        '
        'ListView3
        '
        Me.ListView3.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12})
        Me.ListView3.FullRowSelect = True
        Me.ListView3.HideSelection = False
        Me.ListView3.HotTracking = True
        Me.ListView3.HoverSelection = True
        Me.ListView3.Location = New System.Drawing.Point(9, 381)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(224, 138)
        Me.ListView3.TabIndex = 7
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = ""
        Me.ColumnHeader11.Width = 40
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Salle"
        Me.ColumnHeader12.Width = 150
        '
        'ListView2
        '
        Me.ListView2.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.HideSelection = False
        Me.ListView2.HotTracking = True
        Me.ListView2.HoverSelection = True
        Me.ListView2.Location = New System.Drawing.Point(9, 211)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(224, 138)
        Me.ListView2.TabIndex = 6
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = ""
        Me.ColumnHeader9.Width = 40
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Classe"
        Me.ColumnHeader10.Width = 150
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader8})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.HotTracking = True
        Me.ListView1.HoverSelection = True
        Me.ListView1.Location = New System.Drawing.Point(9, 32)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(224, 147)
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = ""
        Me.ColumnHeader4.Width = 40
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Enseignant"
        Me.ColumnHeader8.Width = 150
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Obj_Opt_Classe)
        Me.TabPage1.Controls.Add(Me.Obj_Opt_Gr2)
        Me.TabPage1.Controls.Add(Me.Obj_Opt_Gr1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Obj_Liste_Matiere)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Obj_Nb_Heures)
        Me.TabPage1.Controls.Add(Me.Obj_Liste1)
        Me.TabPage1.Controls.Add(Me.Obj_Liste2)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(430, 542)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Attribution"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 428)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Matière :"
        '
        'Obj_Liste_Matiere
        '
        Me.Obj_Liste_Matiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Obj_Liste_Matiere.FormattingEnabled = True
        Me.Obj_Liste_Matiere.Items.AddRange(New Object() {"E2", "E33", "E32", "Techno"})
        Me.Obj_Liste_Matiere.Location = New System.Drawing.Point(92, 425)
        Me.Obj_Liste_Matiere.Name = "Obj_Liste_Matiere"
        Me.Obj_Liste_Matiere.Size = New System.Drawing.Size(121, 21)
        Me.Obj_Liste_Matiere.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 401)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Durée :"
        '
        'Obj_Nb_Heures
        '
        Me.Obj_Nb_Heures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Obj_Nb_Heures.FormattingEnabled = True
        Me.Obj_Nb_Heures.Items.AddRange(New Object() {"00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00"})
        Me.Obj_Nb_Heures.Location = New System.Drawing.Point(92, 398)
        Me.Obj_Nb_Heures.Name = "Obj_Nb_Heures"
        Me.Obj_Nb_Heures.Size = New System.Drawing.Size(121, 21)
        Me.Obj_Nb_Heures.TabIndex = 11
        '
        'Obj_Cadre
        '
        Me.Obj_Cadre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Obj_Cadre.AutoScroll = True
        Me.Obj_Cadre.Controls.Add(Me.Obj_Image)
        Me.Obj_Cadre.Location = New System.Drawing.Point(456, 50)
        Me.Obj_Cadre.Name = "Obj_Cadre"
        Me.Obj_Cadre.Size = New System.Drawing.Size(1085, 692)
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
        'Obj_Opt_Gr1
        '
        Me.Obj_Opt_Gr1.AutoSize = True
        Me.Obj_Opt_Gr1.Location = New System.Drawing.Point(45, 362)
        Me.Obj_Opt_Gr1.Name = "Obj_Opt_Gr1"
        Me.Obj_Opt_Gr1.Size = New System.Drawing.Size(66, 17)
        Me.Obj_Opt_Gr1.TabIndex = 15
        Me.Obj_Opt_Gr1.Text = "Groupe1"
        Me.Obj_Opt_Gr1.UseVisualStyleBackColor = True
        '
        'Obj_Opt_Gr2
        '
        Me.Obj_Opt_Gr2.AutoSize = True
        Me.Obj_Opt_Gr2.Location = New System.Drawing.Point(117, 362)
        Me.Obj_Opt_Gr2.Name = "Obj_Opt_Gr2"
        Me.Obj_Opt_Gr2.Size = New System.Drawing.Size(66, 17)
        Me.Obj_Opt_Gr2.TabIndex = 16
        Me.Obj_Opt_Gr2.Text = "Groupe2"
        Me.Obj_Opt_Gr2.UseVisualStyleBackColor = True
        '
        'Obj_Opt_Classe
        '
        Me.Obj_Opt_Classe.AutoSize = True
        Me.Obj_Opt_Classe.Checked = True
        Me.Obj_Opt_Classe.Location = New System.Drawing.Point(189, 362)
        Me.Obj_Opt_Classe.Name = "Obj_Opt_Classe"
        Me.Obj_Opt_Classe.Size = New System.Drawing.Size(91, 17)
        Me.Obj_Opt_Classe.TabIndex = 17
        Me.Obj_Opt_Classe.TabStop = True
        Me.Obj_Opt_Classe.Text = "Classe entière"
        Me.Obj_Opt_Classe.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Planning.My.Resources.Resources.back_to_school_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1553, 754)
        Me.Controls.Add(Me.Obj_Cadre)
        Me.Controls.Add(Me.Obj_Onglets)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Obj_Mode_Enseignants)
        Me.Controls.Add(Me.Obj_Mode_Salles)
        Me.Controls.Add(Me.Obj_Mode_Classes)
        Me.Controls.Add(Me.Obj_Liste_Plannings)
        Me.Name = "Form1"
        Me.Text = "Amandine - Planning"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Obj_Onglets.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Obj_Cadre.ResumeLayout(False)
        Me.Obj_Cadre.PerformLayout()
        CType(Me.Obj_Image, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Obj_Mode_Classes As Button
    Friend WithEvents Obj_Mode_Salles As Button
    Friend WithEvents Obj_Mode_Enseignants As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Obj_Onglets As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListView3 As ListView
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Obj_Nb_Heures As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Obj_Liste_Matiere As ComboBox
    Friend WithEvents Obj_Cadre As Panel
    Friend WithEvents Obj_Image As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Obj_Opt_Classe As RadioButton
    Friend WithEvents Obj_Opt_Gr2 As RadioButton
    Friend WithEvents Obj_Opt_Gr1 As RadioButton
End Class
