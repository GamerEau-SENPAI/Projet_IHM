Public Class FormMenu
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class
