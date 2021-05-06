Public Class FormMenu
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_start.Enabled = False
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        End
    End Sub

    Private Sub btn_param_Click(sender As Object, e As EventArgs) Handles btn_param.Click
        Me.Hide()
        Form_para.Show()
    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        Me.Hide()
        Form_jeu.Show()
        Form_jeu.Timer1.Start()

    End Sub

    Private Sub txt_nom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nom.KeyPress
        btn_start.Enabled = True
    End Sub
End Class
