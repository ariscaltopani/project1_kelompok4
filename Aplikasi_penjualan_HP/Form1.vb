Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            MsgBox("Anda berhasil masuk")
            Me.Hide()
            Form2.Show()
        Else
            MsgBox("Error")
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub Button1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Enter
       
    End Sub
End Class
