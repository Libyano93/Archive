Imports System.Data.SqlClient
Module ConnectionModule
    'ADO.Net
    ' Connection Function
    Public Function Con() As SqlConnection

        Dim conn As New SqlConnection

        If My.Settings.LoginMothed = 0 Then

            ' Connection Statement by Windows Authentication
            conn = New SqlConnection("Data Source ='" & My.Settings.ServerName & "';Initial Catalog ='" & My.Settings.DataBaseName & "';Integrated Security=True ")
        ElseIf My.Settings.LoginMothed = 1 Then
            ' Connection Statement by SQL Serve Authentication
            conn = New SqlConnection("Data Source ='" & My.Settings.ServerName & "';Initial Catalog ='" & My.Settings.DataBaseName & "';user ID ='" & My.Settings.LoginID & "'; Password='" & My.Settings.LogPassword & "' ")
        End If

        Return conn
    End Function

    Public img As Int16 = 0

End Module
