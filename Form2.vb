Imports System.Data.OleDb

Public Class Form2

    Sub loadEmployee()
        con = New OleDbConnection(constr)
        sql = "select * from employee"
        cmd = New OleDbCommand(sql, con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "employee")
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = ds.Tables("employee")

    End Sub



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadEmployee()



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim f1 As New Form1
        f1.txtEmpID.Text = dr.Cells(0).Value
        f1.txtFirstName.Text = dr.Cells(1).Value
        f1.txtLastName.Text = dr.Cells(2).Value
        f1.cmbGender.Text = dr.Cells(3).Value
        f1.dtpDateofbirth.Text = dr.Cells(4).Value
        f1.txtTel.Text = dr.Cells(5).Value
        f1.txtEmail.Text = dr.Cells(6).Value
        f1.cmbCountry.Text = dr.Cells(7).Value
        f1.txtHomeTown.Text = dr.Cells(8).Value
        f1.txtHomeAddress.Text = dr.Cells(9).Value
        f1.txtSsnitNo.Text = dr.Cells(10).Value
        f1.cmbDepartment.Text = dr.Cells(11).Value
        f1.Show()
        Me.Hide()
    End Sub


    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        con = New OleDbConnection(constr)
        sql = "select * from employee where firstName like '%" & txtName.Text & "%' or lastName like '%" & txtName.Text & "%'"
        cmd = New OleDbCommand(sql, con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "employee")
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = ds.Tables("employee")
    End Sub



    Private Sub txtHomeTown_TextChanged(sender As Object, e As EventArgs) Handles txtHomeTown.TextChanged
        con = New OleDbConnection(constr)
        sql = "select * from employee where homeTown like '%" & txtHomeTown.Text & "%' "
        cmd = New OleDbCommand(sql, con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "employee")
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = ds.Tables("employee")
    End Sub

    Private Sub cmbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartment.SelectedIndexChanged
        con = New OleDbConnection(constr)
        sql = "select * from employee where department like '%" & cmbDepartment.Text & "%' "
        cmd = New OleDbCommand(sql, con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "employee")
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = ds.Tables("employee")
    End Sub
End Class