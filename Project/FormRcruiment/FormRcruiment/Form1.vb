Public Class fRecruitment
    Private Sub clear()
        tbidpel.Clear()
        tbnama.Clear()
        tbnik.Clear()
        tbpendidikan.Clear()
        tbalamat.Clear()
        tbtanggallahir.Clear()
        tbtempatlahir.Clear()
        lbpengalaman.ClearSelected()
        lbsertifikat.ClearSelected()
    End Sub
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()
    End Sub
End Class
