Public Class Form_para
    Dim augmentation As Integer = 0
    Private Sub btn_aban_Click(sender As Object, e As EventArgs) Handles btn_aban.Click
        Me.Hide()
        FormMenu.Show()
    End Sub

    Private Sub btn_che_Click(sender As Object, e As EventArgs) Handles btn_che.Click
        With FolderBrowserDialog1
            .SelectedPath = "C:New Folder"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                txt_che.Text = .SelectedPath
            End If
        End With

    End Sub

    Private Sub Form_para_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_dur.Text = augmentation + Form_jeu.getDuree
    End Sub

    Private Sub btn_aug_Click(sender As Object, e As EventArgs) Handles btn_aug.Click
        augmentation += 1
        lbl_dur.Text = augmentation + Form_jeu.getDuree
    End Sub

    Private Sub btn_dim_Click(sender As Object, e As EventArgs) Handles btn_dim.Click
        If augmentation > 0 Then
            augmentation -= 1
            lbl_dur.Text = augmentation + Form_jeu.getDuree
        End If
    End Sub
End Class