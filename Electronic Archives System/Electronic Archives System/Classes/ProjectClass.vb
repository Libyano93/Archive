Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging

Public Class ProjectClass

#Region "UserAcounts"


    'CommandBuilder Class

    'Clear Controls Data
    Public Sub ClearControls_FrmUsers(ByVal xx As FrmUserAccounts)

        xx.UserAccID.Text = GetNewID("UserAccID", "UserAccounts")
        xx.UserAccountName.Clear()
        xx.UserName.Clear()
        xx.UserPassword.Clear()
        xx.AccType.Text = Nothing
        xx.AccActivate.Checked = False
        xx.UserImage.Image = Nothing
        xx.ck_ShowPasword.Checked = False
        xx.txtNevigate.Text = Nothing

        xx.btnSave.Enabled = True
        xx.btnEdit.Enabled = False
        xx.btnDelete.Enabled = False
        xx.UserAccountName.Focus()

    End Sub

    ' Get New ID
    Public Function GetNewID(ByVal ColumnName As String, ByVal TableName As String)

        Dim dt As New DataTable
        dt.Clear()
        Dim da As New SqlDataAdapter
        da = New SqlDataAdapter("select MAX(" & ColumnName & ") from " & TableName & "", Con)
        da.Fill(dt)

        Dim MyNewID As Int64
        If IsDBNull(dt(0)(0)) = True Then
            MyNewID = 1
        Else
            MyNewID = dt(0)(0) + 1
        End If

        Return MyNewID
        da.Dispose()
        dt.Dispose()
    End Function

    'Save Users Acounts Data 
    Public Sub Save_In_UsersTbl(ByVal xx As FrmUserAccounts)
        Try

            If xx.UserAccountName.Text.Trim = Nothing Then
                MessageBox.Show("من فضلك ادخل اسم الحساب", "رسالة تنبيه")
                Exit Sub
            ElseIf xx.UserName.Text.Trim = Nothing Then
                MessageBox.Show("من فضلك ادخل اسم المستخدم", "رسالة تنبيه")
                xx.UserName.Focus()
            ElseIf xx.UserPassword.Text.Trim = Nothing Then
                MessageBox.Show("من فضلك ادخل كلمة المرور", "رسالة تنبيه")
                xx.UserPassword.Focus()
            ElseIf xx.AccType.SelectedIndex = -1 Then
                MessageBox.Show("من فضلك اختر نوع الحساب", "رسالة تنبيه")
                xx.AccType.Focus()

            End If

            Dim dt As New DataTable
            dt.Clear()
            Dim da As New SqlDataAdapter
            Dim sqlstr As String
            sqlstr = "Select * FROM UserAccounts where UserAccID = " & xx.UserAccID.Text & " "
            da = New SqlDataAdapter(sqlstr, Con)
            da.Fill(dt)

            If dt.Rows.Count = 0 Then

                dt.Rows.Add()
                Dim last As Integer = dt.Rows.Count - 1

                dt.Rows(last).Item("UserAccID") = xx.UserAccID.Text
                dt.Rows(last).Item("UserAccName") = xx.UserAccountName.Text
                dt.Rows(last).Item("UserName") = xx.UserName.Text
                dt.Rows(last).Item("UserPassword") = xx.UserPassword.Text
                dt.Rows(last).Item("AccType") = xx.AccType.SelectedIndex
                dt.Rows(last).Item("AccActivate") = xx.AccActivate.Checked
                dt.Rows(last).Item("AddUser") = 1

                '==============================================
                If IsNothing(xx.UserImage.Image) Then
                    dt.Rows(last).Item("UserImage") = DBNull.Value
                Else
                    SavePicture(xx.UserImage, dt, last, "UserImage")
                End If

                '==============================================


                Dim Save As New SqlCommandBuilder(da)
                da.Update(dt)
                dt.AcceptChanges()

                dt.Dispose()
                da.Dispose()

                ClearControls_FrmUsers(FrmUserAccounts)

                xx.lblconfirmMessage.Text = " تم الحفظ بنجاح "
                xx.PicMessage.Image = My.Resources.OK

                xx.Timer1.Start()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub

    'To Get Image to pictureBox
    Public Sub GetImageTo_PictureBox(ByVal pic As PictureBox)
        Dim ofd As New OpenFileDialog
        ofd.Filter = "(Choose Image)|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg, | *.jpg|Png, | *.png|Bmp, | *.bmp|Gif, | *.gif|Ico | *.ico"

        If ofd.ShowDialog() = DialogResult.OK Then
            pic.SizeMode = PictureBoxSizeMode.StretchImage
            pic.Load(ofd.FileName)
        End If
    End Sub

    'Save Picture Inside Database
    Public Sub SavePicture(ByVal pic As PictureBox, ByVal dt As DataTable, ByVal RowIndex As Integer, ByVal imgCol As String)

        Dim ImgArray() As Byte
            Dim stream As New MemoryStream
            pic.Image.Save(stream, ImageFormat.Png)
            ImgArray = stream.ToArray()
            stream.Close()

            dt.Rows(RowIndex).Item("" & imgCol & "") = ImgArray

    End Sub

#End Region

End Class
