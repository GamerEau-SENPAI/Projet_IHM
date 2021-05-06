<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_para
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
        Me.components = New System.ComponentModel.Container()
        Me.btn_enr = New System.Windows.Forms.Button()
        Me.btn_aban = New System.Windows.Forms.Button()
        Me.lbl_boolTemps = New System.Windows.Forms.Label()
        Me.Chb_temps = New System.Windows.Forms.CheckBox()
        Me.lbl_contTemps = New System.Windows.Forms.Label()
        Me.btn_dim = New System.Windows.Forms.Button()
        Me.btn_aug = New System.Windows.Forms.Button()
        Me.lbl_duree = New System.Windows.Forms.Label()
        Me.lbl_dur = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txt_che = New System.Windows.Forms.TextBox()
        Me.btn_che = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btn_enr
        '
        Me.btn_enr.Location = New System.Drawing.Point(96, 290)
        Me.btn_enr.Name = "btn_enr"
        Me.btn_enr.Size = New System.Drawing.Size(101, 61)
        Me.btn_enr.TabIndex = 0
        Me.btn_enr.Text = "ENREGISTRER"
        Me.btn_enr.UseVisualStyleBackColor = True
        '
        'btn_aban
        '
        Me.btn_aban.Location = New System.Drawing.Point(244, 290)
        Me.btn_aban.Name = "btn_aban"
        Me.btn_aban.Size = New System.Drawing.Size(101, 61)
        Me.btn_aban.TabIndex = 1
        Me.btn_aban.Text = "ABANDONER"
        Me.btn_aban.UseVisualStyleBackColor = True
        '
        'lbl_boolTemps
        '
        Me.lbl_boolTemps.AutoSize = True
        Me.lbl_boolTemps.Location = New System.Drawing.Point(22, 27)
        Me.lbl_boolTemps.Name = "lbl_boolTemps"
        Me.lbl_boolTemps.Size = New System.Drawing.Size(100, 13)
        Me.lbl_boolTemps.TabIndex = 2
        Me.lbl_boolTemps.Text = "Désactiver le temps"
        '
        'Chb_temps
        '
        Me.Chb_temps.AutoSize = True
        Me.Chb_temps.Location = New System.Drawing.Point(133, 26)
        Me.Chb_temps.Name = "Chb_temps"
        Me.Chb_temps.Size = New System.Drawing.Size(15, 14)
        Me.Chb_temps.TabIndex = 3
        Me.Chb_temps.UseVisualStyleBackColor = True
        '
        'lbl_contTemps
        '
        Me.lbl_contTemps.AutoSize = True
        Me.lbl_contTemps.Location = New System.Drawing.Point(22, 86)
        Me.lbl_contTemps.Name = "lbl_contTemps"
        Me.lbl_contTemps.Size = New System.Drawing.Size(157, 13)
        Me.lbl_contTemps.TabIndex = 4
        Me.lbl_contTemps.Text = "Augmanter ou diminuer le temps"
        '
        'btn_dim
        '
        Me.btn_dim.Location = New System.Drawing.Point(202, 69)
        Me.btn_dim.Name = "btn_dim"
        Me.btn_dim.Size = New System.Drawing.Size(54, 46)
        Me.btn_dim.TabIndex = 5
        Me.btn_dim.Text = "<"
        Me.btn_dim.UseVisualStyleBackColor = True
        '
        'btn_aug
        '
        Me.btn_aug.Location = New System.Drawing.Point(275, 69)
        Me.btn_aug.Name = "btn_aug"
        Me.btn_aug.Size = New System.Drawing.Size(54, 46)
        Me.btn_aug.TabIndex = 6
        Me.btn_aug.Text = ">"
        Me.btn_aug.UseVisualStyleBackColor = True
        '
        'lbl_duree
        '
        Me.lbl_duree.AutoSize = True
        Me.lbl_duree.Location = New System.Drawing.Point(349, 86)
        Me.lbl_duree.Name = "lbl_duree"
        Me.lbl_duree.Size = New System.Drawing.Size(36, 13)
        Me.lbl_duree.TabIndex = 7
        Me.lbl_duree.Text = "Durée"
        '
        'lbl_dur
        '
        Me.lbl_dur.AutoSize = True
        Me.lbl_dur.Location = New System.Drawing.Point(406, 86)
        Me.lbl_dur.Name = "lbl_dur"
        Me.lbl_dur.Size = New System.Drawing.Size(39, 13)
        Me.lbl_dur.TabIndex = 8
        Me.lbl_dur.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Choix du thème"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(19, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 35)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Thème normal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(150, 162)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 35)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Thème noir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(282, 162)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 35)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Thème fun"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txt_che
        '
        Me.txt_che.Location = New System.Drawing.Point(19, 223)
        Me.txt_che.Name = "txt_che"
        Me.txt_che.Size = New System.Drawing.Size(310, 20)
        Me.txt_che.TabIndex = 13
        '
        'btn_che
        '
        Me.btn_che.Location = New System.Drawing.Point(352, 223)
        Me.btn_che.Name = "btn_che"
        Me.btn_che.Size = New System.Drawing.Size(75, 23)
        Me.btn_che.TabIndex = 14
        Me.btn_che.Text = "Chemin"
        Me.btn_che.UseVisualStyleBackColor = True
        '
        'Form_para
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 384)
        Me.Controls.Add(Me.btn_che)
        Me.Controls.Add(Me.txt_che)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_dur)
        Me.Controls.Add(Me.lbl_duree)
        Me.Controls.Add(Me.btn_aug)
        Me.Controls.Add(Me.btn_dim)
        Me.Controls.Add(Me.lbl_contTemps)
        Me.Controls.Add(Me.Chb_temps)
        Me.Controls.Add(Me.lbl_boolTemps)
        Me.Controls.Add(Me.btn_aban)
        Me.Controls.Add(Me.btn_enr)
        Me.Name = "Form_para"
        Me.Text = "PARAMETRES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_enr As Button
    Friend WithEvents btn_aban As Button
    Friend WithEvents lbl_boolTemps As Label
    Friend WithEvents Chb_temps As CheckBox
    Friend WithEvents lbl_contTemps As Label
    Friend WithEvents btn_dim As Button
    Friend WithEvents btn_aug As Button
    Friend WithEvents lbl_duree As Label
    Friend WithEvents lbl_dur As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txt_che As TextBox
    Friend WithEvents btn_che As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Timer1 As Timer
End Class
