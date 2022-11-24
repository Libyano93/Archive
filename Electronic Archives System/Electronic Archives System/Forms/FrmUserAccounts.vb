Public Class FrmUserAccounts

    Dim cls As New ProjectClass
   
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        'لإزاله جميع النصوص الموجوده على الادوات على الفورم
        cls.ClearControls_FrmUsers(Me)
    End Sub

    Private Sub FrmUserAccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'لإزاله جميع النصوص الموجوده على الادوات على الفورم
        cls.ClearControls_FrmUsers(Me)
    End Sub

    Private Sub ck_ShowPasword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ck_ShowPasword.CheckedChanged
        If ck_ShowPasword.Checked = True Then
            UserPassword.UseSystemPasswordChar = False 'Show Password
            ck_ShowPasword.Text = "إخفاء"
        Else
            UserPassword.UseSystemPasswordChar = True ' hide Password
            ck_ShowPasword.Text = "إضهار"
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        cls.Save_In_UsersTbl(Me)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblconfirmMessage.Text = Nothing
        PicMessage.Image = Nothing
        Timer1.Stop()
    End Sub

    Private Sub FrmUserAccounts_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, False, True)
        ElseIf e.KeyCode = Keys.Up Then
            Me.SelectNextControl(Me.ActiveControl, False, True, False, True)

        End If
    End Sub

    Private Sub btnChooseImage_Click(sender As Object, e As EventArgs) Handles btnChooseImage.Click
        img = 1
        cls.GetImageTo_PictureBox(UserImage)
    End Sub

    Private Sub btnDeleteImage_Click(sender As Object, e As EventArgs) Handles btnDeleteImage.Click
        UserImage.Image = Nothing
    End Sub
End Class