Public Class Form_jeu
    Private Structure jeu
        Dim duree As Integer
    End Structure
    Dim jeux As jeu

    Private Sub btn_quit_Click(sender As Object, e As EventArgs) Handles btn_quit.Click
        Me.Hide()
        FormMenu.Show()

    End Sub

    Private Sub Form_jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        jeux.duree = 100

        lbl_temps.Text = jeux.duree
        For i As Integer = 0 To pnl_jeu.Controls.Count - 1

        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If lbl_temps.Text - 1 > 0 Then
            lbl_temps.Text = lbl_temps.Text - 1
        End If

    End Sub
    Function getDuree() As Integer
        Return jeux.duree
    End Function

    Private Sub btn_pause_Click(sender As Object, e As EventArgs) Handles btn_pause.Click
        Timer1.Stop()
    End Sub
End Class