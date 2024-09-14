Public Class Form4
    Private Sub AddEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        Dim f1 As New Form1
        f1.MdiParent = Me
        f1.Show()
    End Sub

    Private Sub DeleteEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteEmployeeToolStripMenuItem.Click
        Dim f1 As New Form1
        f1.MdiParent = Me
        f1.Show()
    End Sub

    Private Sub UpdateEmployeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateEmployeToolStripMenuItem.Click
        Dim f1 As New Form1
        f1.MdiParent = Me
        f1.Show()
    End Sub

    Private Sub ViewEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewEmployeeToolStripMenuItem.Click
        Dim f2 As New Form2
        f2.MdiParent = Me
        f2.Show()
    End Sub

    Private Sub ViewSalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSalaryToolStripMenuItem.Click
        Dim f3 As New Form3
        f3.MdiParent = Me
        f3.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class