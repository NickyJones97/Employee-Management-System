Imports System.Data.OleDb
Public Class Form5
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Len(txtUsername.Text) = 0 Then
            MessageBox.Show("Please enter username", "Input Error",
            MessageBoxButtons.OK)
            txtUsername.Focus()
            Exit Sub
        End If
        If Len(txtPassword.Text) = 0 Then
            MessageBox.Show("Please enter password", "Input Error",
            MessageBoxButtons.OK)
            txtUsername.Focus()
            Exit Sub
        End If

        Try
            con = New OleDbConnection(constr)
            con.Open()
            sql = "SELECT [uid],[username],[password],[usertype] FROM [login_db]  where [username]=? and [password]=?"
            Dim uname As New OleDbParameter("@username", OleDbType.VarChar)
            Dim pass As New OleDbParameter("@password", OleDbType.VarChar)
            cmd = New OleDbCommand(sql, con)
            uname.Value = txtUsername.Text
            pass.Value = txtPassword.Text
            cmd.Parameters.Add(uname)
            cmd.Parameters.Add(pass)
            Dim rdr As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Dim Login As Object = 0
            If rdr.HasRows() Then
                rdr.Read()
                Login = rdr(Login)
            Else
                MessageBox.Show("Invalid Credentials")
            End If

            If Login = Nothing Then
                MsgBox("Login failed......Try again",
                    MsgBoxStyle.Critical, "Access Denied")
                txtUsername.Clear()
                txtPassword.Clear()
                txtUsername.Focus()
            Else
                Dim mainWindow As New Form4
                mainWindow.Show()
                Me.Hide()
            End If
            cmd.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class