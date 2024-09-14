Imports System.Data.OleDb
Public Class Form1



    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnSave.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSave.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            con = New OleDbConnection(constr)
            sql = "insert into employee(FirstName,LastName,Gender,Dob,Tel,Email,Country,HomeTown,HomeAddress,Ssnit_No,Department) values(?,?,?,?,?,?,?,?,?,?,?)"
            Dim p1 As New OleDbParameter("@FirstName", OleDbType.VarChar)
            Dim p2 As New OleDbParameter("@LastName", OleDbType.VarChar)
            Dim p3 As New OleDbParameter("@Gender", OleDbType.Char)
            Dim p4 As New OleDbParameter("@Dob", OleDbType.Date)
            Dim p5 As New OleDbParameter("@Tel", OleDbType.Char)
            Dim p6 As New OleDbParameter("@Email", OleDbType.VarChar)
            Dim p7 As New OleDbParameter("@Country", OleDbType.VarChar)
            Dim p8 As New OleDbParameter("@HomeTown", OleDbType.VarChar)
            Dim p9 As New OleDbParameter("@HomeAddress", OleDbType.VarChar)
            Dim p10 As New OleDbParameter("@Ssnit_No", OleDbType.Char)
            Dim p11 As New OleDbParameter("@Department", OleDbType.VarChar)

            cmd = New OleDbCommand(sql, con)

            p1.Value = txtFirstName.Text
            p2.Value = txtLastName.Text
            p3.Value = cmbGender.Text
            p4.Value = dtpDateofbirth.Text
            p5.Value = txtTel.Text
            p6.Value = txtEmail.Text
            p7.Value = cmbCountry.Text
            p8.Value = txtHomeTown.Text
            p9.Value = txtHomeAddress.Text
            p10.Value = txtSsnitNo.Text
            p11.Value = cmbDepartment.Text

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)
            cmd.Parameters.Add(p4)
            cmd.Parameters.Add(p5)
            cmd.Parameters.Add(p6)
            cmd.Parameters.Add(p7)
            cmd.Parameters.Add(p8)
            cmd.Parameters.Add(p9)
            cmd.Parameters.Add(p10)
            cmd.Parameters.Add(p11)


            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Employee data saved")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            con = New OleDbConnection(constr)
            sql = "update employee set FirstName=?,LastName=?,Gender=?,Dob=?,Tel=?,Email=?,Country=?,HomeTown=?,HomeAddress=?,Ssnit_No=?,Department=? where EmpID=?"
            Dim p1 As New OleDbParameter("@FirstName", OleDbType.VarChar)
            Dim p2 As New OleDbParameter("@LastName", OleDbType.VarChar)
            Dim p3 As New OleDbParameter("@Gender", OleDbType.Char)
            Dim p4 As New OleDbParameter("@Dob", OleDbType.Date)
            Dim p5 As New OleDbParameter("@Tel", OleDbType.Char)
            Dim p6 As New OleDbParameter("@Email", OleDbType.VarChar)
            Dim p7 As New OleDbParameter("@Country", OleDbType.VarChar)
            Dim p8 As New OleDbParameter("@HomeTown", OleDbType.VarChar)
            Dim p9 As New OleDbParameter("@HomeAddress", OleDbType.VarChar)
            Dim p10 As New OleDbParameter("@Ssnit_No", OleDbType.Char)
            Dim p11 As New OleDbParameter("@Department", OleDbType.VarChar)
            Dim p12 As New OleDbParameter("@EmpID", OleDbType.Integer)

            cmd = New OleDbCommand(sql, con)

            p1.Value = txtFirstName.Text
            p2.Value = txtLastName.Text
            p3.Value = cmbGender.Text
            p4.Value = dtpDateofbirth.Text
            p5.Value = txtTel.Text
            p6.Value = txtEmail.Text
            p7.Value = cmbCountry.Text
            p8.Value = txtHomeTown.Text
            p9.Value = txtHomeAddress.Text
            p10.Value = txtSsnitNo.Text
            p11.Value = cmbDepartment.Text
            p12.Value = txtEmpID.Text

            cmd.Parameters.Add(p1)
            cmd.Parameters.Add(p2)
            cmd.Parameters.Add(p3)
            cmd.Parameters.Add(p4)
            cmd.Parameters.Add(p5)
            cmd.Parameters.Add(p6)
            cmd.Parameters.Add(p7)
            cmd.Parameters.Add(p8)
            cmd.Parameters.Add(p9)
            cmd.Parameters.Add(p10)
            cmd.Parameters.Add(p11)
            cmd.Parameters.Add(p12)


            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Employee data updated")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            con = New OleDbConnection(constr)
            sql = "delete from  employee  where EmpID=?"
            Dim p1 As New OleDbParameter("@EmpID", OleDbType.Integer)

            cmd = New OleDbCommand(sql, con)

            p1.Value = txtEmpID.Text

            cmd.Parameters.Add(p1)

            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Employee data deleted")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnViewdata_Click(sender As Object, e As EventArgs) Handles btnViewdata.Click
        Dim f2 As New Form2
        f2.Show()
        Me.Hide()
    End Sub





    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field allows only Letters")
        End If
    End Sub




End Class
