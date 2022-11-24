Public Class FrmMainPage

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnAddNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewUser.Click
        FrmUserAccounts.ShowDialog()
    End Sub

    Private Sub btnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettings.Click
        FrmServerCon.ShowDialog()
    End Sub

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click
        FrmDatabase.ShowDialog()
    End Sub

    Private Sub btnAddNewFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewFolder.Click
        FrmAddFolders.ShowDialog()
    End Sub

    Private Sub btnAddNewFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewFile.Click
        FrmAddfiles.ShowDialog()
    End Sub

    Private Sub btnSendMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendMail.Click
        FrmEMail.Show(Me)
    End Sub

    Private Sub btnDeletedPin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletedPin.Click
        FrmCyclePin.Show(Me)
    End Sub

    Private Sub btnUserRoles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnUserRoles_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserRoles.Click
        FrmUserRoles.Show(Me)
    End Sub
End Class
