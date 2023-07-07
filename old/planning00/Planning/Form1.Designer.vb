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
        Me.Obj_Liste_Plannings = New System.Windows.Forms.ComboBox()
        Me.Obj_Liste2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Obj_Liste1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Obj_Grille = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Obj_Mode_Classes = New System.Windows.Forms.Button()
        Me.Obj_Mode_Salles = New System.Windows.Forms.Button()
        Me.Obj_Mode_Enseignants = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Obj_Grille, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Obj_Liste_Plannings
        '
        Me.Obj_Liste_Plannings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Obj_Liste_Plannings.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Obj_Liste_Plannings.FormattingEnabled = True
        Me.Obj_Liste_Plannings.Location = New System.Drawing.Point(456, 12)
        Me.Obj_Liste_Plannings.Name = "Obj_Liste_Plannings"
        Me.Obj_Liste_Plannings.Size = New System.Drawing.Size(374, 32)
        Me.Obj_Liste_Plannings.TabIndex = 1
        '
        'Obj_Liste2
        '
        Me.Obj_Liste2.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.Obj_Liste2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.Obj_Liste2.FullRowSelect = True
        Me.Obj_Liste2.HideSelection = False
        Me.Obj_Liste2.HotTracking = True
        Me.Obj_Liste2.HoverSelection = True
        Me.Obj_Liste2.Location = New System.Drawing.Point(6, 224)
        Me.Obj_Liste2.Name = "Obj_Liste2"
        Me.Obj_Liste2.Size = New System.Drawing.Size(354, 280)
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
        Me.Obj_Liste1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.Obj_Liste1.FullRowSelect = True
        Me.Obj_Liste1.HideSelection = False
        Me.Obj_Liste1.HotTracking = True
        Me.Obj_Liste1.HoverSelection = True
        Me.Obj_Liste1.Location = New System.Drawing.Point(6, 19)
        Me.Obj_Liste1.Name = "Obj_Liste1"
        Me.Obj_Liste1.Size = New System.Drawing.Size(354, 199)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Obj_Liste1)
        Me.GroupBox1.Controls.Add(Me.Obj_Liste2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 155)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 516)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Obj_Grille
        '
        Me.Obj_Grille.AllowUserToAddRows = False
        Me.Obj_Grille.AllowUserToDeleteRows = False
        Me.Obj_Grille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Obj_Grille.Location = New System.Drawing.Point(456, 46)
        Me.Obj_Grille.MultiSelect = False
        Me.Obj_Grille.Name = "Obj_Grille"
        Me.Obj_Grille.ReadOnly = True
        Me.Obj_Grille.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.Obj_Grille.ShowCellErrors = False
        Me.Obj_Grille.ShowCellToolTips = False
        Me.Obj_Grille.ShowEditingIcon = False
        Me.Obj_Grille.ShowRowErrors = False
        Me.Obj_Grille.Size = New System.Drawing.Size(589, 629)
        Me.Obj_Grille.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(388, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 69)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "&Affecter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Obj_Mode_Classes
        '
        Me.Obj_Mode_Classes.Location = New System.Drawing.Point(12, 12)
        Me.Obj_Mode_Classes.Name = "Obj_Mode_Classes"
        Me.Obj_Mode_Classes.Size = New System.Drawing.Size(75, 57)
        Me.Obj_Mode_Classes.TabIndex = 7
        Me.Obj_Mode_Classes.Text = "Classes"
        Me.Obj_Mode_Classes.UseVisualStyleBackColor = True
        '
        'Obj_Mode_Salles
        '
        Me.Obj_Mode_Salles.Location = New System.Drawing.Point(93, 12)
        Me.Obj_Mode_Salles.Name = "Obj_Mode_Salles"
        Me.Obj_Mode_Salles.Size = New System.Drawing.Size(75, 57)
        Me.Obj_Mode_Salles.TabIndex = 8
        Me.Obj_Mode_Salles.Text = "Salles"
        Me.Obj_Mode_Salles.UseVisualStyleBackColor = True
        '
        'Obj_Mode_Enseignants
        '
        Me.Obj_Mode_Enseignants.Location = New System.Drawing.Point(174, 12)
        Me.Obj_Mode_Enseignants.Name = "Obj_Mode_Enseignants"
        Me.Obj_Mode_Enseignants.Size = New System.Drawing.Size(75, 57)
        Me.Obj_Mode_Enseignants.TabIndex = 9
        Me.Obj_Mode_Enseignants.Text = "Enseignants"
        Me.Obj_Mode_Enseignants.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(388, 364)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 69)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 683)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Obj_Mode_Enseignants)
        Me.Controls.Add(Me.Obj_Mode_Salles)
        Me.Controls.Add(Me.Obj_Mode_Classes)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Obj_Liste_Plannings)
        Me.Controls.Add(Me.Obj_Grille)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Amandine - Planning"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Obj_Grille, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Obj_Grille As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Obj_Mode_Classes As Button
    Friend WithEvents Obj_Mode_Salles As Button
    Friend WithEvents Obj_Mode_Enseignants As Button
    Friend WithEvents Button2 As Button
End Class
