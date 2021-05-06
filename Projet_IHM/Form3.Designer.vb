<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_jeu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btn_quit = New System.Windows.Forms.Button()
        Me.lbl_temps = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_pause = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_quit
        '
        Me.btn_quit.Location = New System.Drawing.Point(700, 12)
        Me.btn_quit.Name = "btn_quit"
        Me.btn_quit.Size = New System.Drawing.Size(88, 37)
        Me.btn_quit.TabIndex = 0
        Me.btn_quit.Text = "QUIT"
        Me.btn_quit.UseVisualStyleBackColor = True
        '
        'lbl_temps
        '
        Me.lbl_temps.AutoSize = True
        Me.lbl_temps.Location = New System.Drawing.Point(581, 24)
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
        Me.btn_pause.Location = New System.Drawing.Point(448, 12)
        Me.btn_pause.Name = "btn_pause"
        Me.btn_pause.Size = New System.Drawing.Size(88, 37)
        Me.btn_pause.TabIndex = 2
        Me.btn_pause.Text = "PAUSE"
        Me.btn_pause.UseVisualStyleBackColor = True
        '
        'Form_jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
