﻿Public Class Form2
    Private Sub su_ok_btn_Click(sender As Object, e As EventArgs) Handles su_ok_btn.Click
        Me.Hide()
    End Sub

    Private Sub su_cancel_btn_Click(sender As Object, e As EventArgs) Handles su_cancel_btn.Click
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ip_txt.Text = My.Settings.su_addr
        ssid_txt.Text = My.Settings.su_ssid
        su_pw_txt.Text = My.Settings.su_pass
    End Sub
End Class