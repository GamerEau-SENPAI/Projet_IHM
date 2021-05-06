<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.btn_stats = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_param = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Entrez votre nom"
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(131, 176)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(161, 20)
        Me.txt_nom.TabIndex = 1
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(45, 223)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(111, 47)
        Me.btn_start.TabIndex = 2
        Me.btn_start.Text = "START GAME !"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'btn_stats
        '
        Me.btn_stats.Location = New System.Drawing.Point(181, 223)
        Me.btn_stats.Name = "btn_stats"
        Me.btn_stats.Size = New System.Drawing.Size(111, 47)
        Me.btn_stats.TabIndex = 3
        Me.btn_stats.Text = "STATISTIQUES"
        Me.btn_stats.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(181, 294)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(111, 47)
        Me.btn_close.TabIndex = 4
        Me.btn_close.Text = "FERMER"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_param
        '
        Me.btn_param.Location = New System.Drawing.Point(45, 294)
        Me.btn_param.Name = "btn_param"
        Me.btn_param.Size = New System.Drawing.Size(111, 47)
        Me.btn_param.TabIndex = 5
        Me.btn_param.Text = "PARAMETRES"
        Me.btn_param.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projet_IHM.My.Resources.Resources.memorylogo
        Me.PictureBox1.Location = New System.Drawing.Point(22, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(286, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 361)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_param)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_stats)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormMenu"
        Me.Text = "MENU"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents btn_start As Button
    Friend WithEvents btn_stats As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_param As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
