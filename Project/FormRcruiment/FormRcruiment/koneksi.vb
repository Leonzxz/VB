
Imports System.Data.OleDb

Module Koneksi
    Public conn As OleDbConnection
    Public daData As OleDbDataAdapter
    Public dsData As DataSet
    Public query As String

    Public Sub KoneksiAccess()
        conn = New OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\RK.accdb")
        conn.Open()
    End Sub

End Module
