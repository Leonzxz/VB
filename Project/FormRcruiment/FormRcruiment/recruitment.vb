Imports System.Data.OleDb

Public Class fRecruitment
    Private Sub clear()
        tbidpel.Clear()
        tbnama.Clear()
        tbnik.Clear()
        tbpendidikan.Clear()
        tbalamat.Clear()
        tbtanggallahir.Clear()
        tbtempatlahir.Clear()
    End Sub

    Dim idpel As String
    Dim nik As String
    Dim nama As String
    Dim tempatl As String
    Dim tanggall As String
    Dim alamat As String
    Dim pendidikan As String
    Dim jk As String

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click

    End Sub
End Class
