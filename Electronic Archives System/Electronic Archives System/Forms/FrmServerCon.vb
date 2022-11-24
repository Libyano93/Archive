
Public Class FrmServerCon


    Private Sub CombLoginMothed_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CombLoginMothed.SelectedIndexChanged
        If CombLoginMothed.SelectedIndex = 1 Then
            txtUserName.Enabled = True
            txtUserPassword.Enabled = True
        Else
            txtUserName.Clear()
            txtUserPassword.Clear()
            txtUserName.Enabled = False
            txtUserPassword.Enabled = False
        End If
    End Sub

   
End Class