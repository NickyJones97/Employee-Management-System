Imports System.Data.OleDb
Module Module1
    Public cmd As OleDbCommand
    Public con As OleDbConnection
    Public ds As DataSet
    Public da As OleDbDataAdapter
    Public sql As String
    Public rdr As OleDbDataReader
    Public constr As String = "Provider=SQLOLEDB;Data Source=DESKTOP-RBFJV33;Integrated Security=SSPI;Initial Catalog=Employee"

End Module
