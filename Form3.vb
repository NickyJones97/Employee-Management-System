Imports System.Data.OleDb
Public Class Form3

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Try
            con = New OleDbConnection(constr)
            sql = "insert into employee(salary) values(?)"

            Dim bas As Single
            Dim trans As Single
            Dim hous, medical, utility As Single
            Dim tax, gross, netpay As Single
            bas = Val(txtBasicSalary.Text)
            trans = bas * 0.25
            hous = bas * 0.15
            medical = bas * 0.5
            utility = bas * 0.8
            tax = bas * 0.3
            gross = bas + trans + hous + medical + utility
            netpay = gross - tax

            txtView.AppendText("Staff ID: " & txtStaffID.Text & vbCrLf)
            txtView.AppendText("Name: " & txtName.Text & vbCrLf)
            txtView.AppendText("Basic Salary: " & txtBasicSalary.Text & vbCrLf)
            txtView.AppendText("Transport: " & trans & vbCrLf)
            txtView.AppendText("Housing: " & hous & vbCrLf)
            txtView.AppendText("Medical: " & medical & vbCrLf)
            txtView.AppendText("Utility: " & utility & vbCrLf)
            txtView.AppendText("tax: " & tax & vbCrLf)
            txtView.AppendText("Gross_Pay: " & gross & vbCrLf)
            txtView.AppendText("Net Pay: " & netpay & vbCrLf)

            txtStaffID.Text = ""
            txtName.Text = ""
            txtBasicSalary.Text = ""





        Catch ex As Exception

        End Try
    End Sub
End Class