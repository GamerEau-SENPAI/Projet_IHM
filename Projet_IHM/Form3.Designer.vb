<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_jeu
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
        Me.btn_quit = New System.Windows.Forms.Button()
        Me.lbl_temps = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_pause = New System.Windows.Forms.Button()
        Me.pnl_jeu = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_quit
        '
        Me.btn_quit.Location = New System.Drawing.Point(583, 2)
        Me.btn_quit.Name = "btn_quit"
        Me.btn_quit.Size = New System.Drawing.Size(88, 37)
        Me.btn_quit.TabIndex = 0
        Me.btn_quit.Text = "QUIT"
        Me.btn_quit.UseVisualStyleBackColor = True
        '
        'lbl_temps
        '
        Me.lbl_temps.AutoSize = True
        Me.lbl_temps.Location = New System.Drawing.Point(519, 14)
        Me.lbl_temps.Name = "lbl_temps"
        Me.lbl_temps.Size = New System.Drawing.Size(39, 13)
        Me.lbl_temps.TabIndex = 1
        Me.lbl_temps.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'btn_pause
        '
        Me.btn_pause.Location = New System.Drawing.Point(24, 2)
        Me.btn_pause.Name = "btn_pause"
        Me.btn_pause.Size = New System.Drawing.Size(88, 37)
        Me.btn_pause.TabIndex = 2
        Me.btn_pause.Text = "PAUSE"
        Me.btn_pause.UseVisualStyleBackColor = True
        '
        'pnl_jeu
        '
        Me.pnl_jeu.Location = New System.Drawing.Point(24, 40)
        Me.pnl_jeu.Name = "pnl_jeu"
        Me.pnl_jeu.Size = New System.Drawing.Size(682, 618)
        Me.pnl_jeu.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(425, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Temps restant"
        '
        'Form_jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 660)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnl_jeu)
        Me.Controls.Add(Me.btn_pause)
        Me.Controls.Add(Me.lbl_temps)
        Me.Controls.Add(Me.btn_quit)
        Me.Name = "Form_jeu"
        Me.Text = "JEU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_quit As Button
    Friend WithEvents lbl_temps As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_pause As Button
    Friend WithEvents pnl_jeu As Panel
    Friend WithEvents Label1 As Label
End Class
