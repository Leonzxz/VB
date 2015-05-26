Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            KoneksiAccess()
            MsgBox("ss")
        Catch ex As Exception
            MsgBox("nn")
        End Try
        
    End Sub
End Class