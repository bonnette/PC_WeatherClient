Public Class Form2
    Private Sub su_ok_btn_Click(sender As Object, e As EventArgs) Handles su_ok_btn.Click
        ' Save setup settings for later use
        My.Settings.su_addr = ip_txt.Text
        My.Settings.Save()
        Me.Hide()
    End Sub

    Private Sub su_cancel_btn_Click(sender As Object, e As EventArgs) Handles su_cancel_btn.Click
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get saved settings and load into form
        ip_txt.Text = My.Settings.su_addr
    End Sub
End Class