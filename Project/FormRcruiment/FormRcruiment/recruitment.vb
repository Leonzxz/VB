Imports System.Data.OleDb

Public Class fRecruitment
    Dim idpel As String
    Dim nik As String
    Dim nama As String
    Dim tempatl As String
    Dim tanggall As DateTime
    Dim alamat As String
    Dim pendidikan As String
    Dim jk As String
    Dim rt As String
    Dim rw As String
    Dim kelurahan As String
    Dim kecamatan As String
    Dim kota As String
    Dim agama As String
    Dim pekerjaan As String
    Dim kwn As String
    Dim pengalaman As String
    Dim sertifikat As String

    Private Sub clear()
        tbidpel.Clear()
        tbnama.Clear()
        tbnik.Clear()
        tbalamat.Clear()
        tbtanggallahir.Clear()
        tbtempatlahir.Clear()
        tbalamat.Clear()
        tbpendidikan.Clear()
        tbrt.Clear()
        tbrw.Clear()
        tbkelurahan.Clear()
        tbkecamatan.Clear()
        tbkota.Clear()
        tbagama.Clear()
        tbpekerjaan.Clear()
        tbkwn.Clear()
        tbpengalaman.Clear()
        tbsertifikat.Clear()

    End Sub
    Private Function SaveData()
        Try
            idpel = tbidpel.Text
            nik = tbnik.Text
            nama = tbnama.Text
            tempatl = tbtempatlahir.Text
            tanggall = DateTime.ParseExact(tbtanggallahir.Text, "ddMMyyyy", Nothing)
            alamat = tbalamat.Text
            If rbpria.Checked = True Then
                jk = rbpria.Text
            ElseIf rbwanita.Checked = True Then
                jk = rbwanita.Text
            End If
            pendidikan = tbpendidikan.Text
            rt = tbrt.Text
            rw = tbrw.Text
            kelurahan = tbkelurahan.Text
            kecamatan = tbkecamatan.Text
            kota = tbkota.Text
            agama = tbagama.Text
            pekerjaan = tbpekerjaan.Text
            kwn = tbkwn.Text

            query = "INSERT INTO bio VALUES('" & idpel & "','" & nik & "','" & nama & "','" & tempatl & "','" & tanggall & "','" & jk & "','" & alamat & "','" & rt & "','" & rw & "','" & kelurahan & "','" & kecamatan & "','" & kota & "','" & agama & "','" & pekerjaan & "','" & kwn & "')"
            daData = New OleDbDataAdapter(Query, conn)
            dsData = New DataSet
            daData.Fill(dsData)
          
            MsgBox("Save Data Succeeded", MsgBoxStyle.Exclamation, "Error")
            Return query
        Catch ex As Exception
            MsgBox("Data Already Exist", MsgBoxStyle.Exclamation, "Error")
            Return 0
        End Try
    End Function
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        SaveData()
    End Sub

    Private Sub btnaddpeng_Click(sender As Object, e As EventArgs) Handles btnaddpeng.Click
        lbpengalaman.Items.Add(tbpengalaman.Text)
    End Sub

    Private Sub btneditpeng_Click(sender As Object, e As EventArgs) Handles btneditpeng.Click
        lbpengalaman.Items(lbpengalaman.SelectedIndex) = tbpengalaman.Text
    End Sub

    Private Sub lbpengalaman_MouseClick(sender As Object, e As MouseEventArgs) Handles lbpengalaman.MouseClick
        tbpengalaman.Text = lbpengalaman.SelectedItem
    End Sub

    Private Sub btndelpeng_Click(sender As Object, e As EventArgs) Handles btndelpeng.Click
        lbpengalaman.Items.RemoveAt(lbpengalaman.SelectedIndex)
    End Sub

    Private Sub btnaddser_Click(sender As Object, e As EventArgs) Handles btnaddser.Click
        lbsertifikat.Items.Add(tbsertifikat.Text)
    End Sub

    Private Sub lbsertifikat_MouseClick(sender As Object, e As MouseEventArgs) Handles lbsertifikat.MouseClick
        tbsertifikat.Text = lbsertifikat.SelectedItem
    End Sub

    Private Sub btneditser_Click(sender As Object, e As EventArgs) Handles btneditser.Click
        lbsertifikat.Items(lbsertifikat.SelectedIndex) = tbsertifikat.Text
    End Sub

    Private Sub btndelser_Click(sender As Object, e As EventArgs) Handles btndelser.Click
        lbsertifikat.Items.RemoveAt(lbsertifikat.SelectedIndex)
    End Sub
End Class
