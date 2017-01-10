Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" Then
            TextBox2.Text = "admin"
            MessageBox.Show("Selamat datang anggota")
            Me.Hide()
            Form2.CustomerToolStripMenuItem.Enabled = True
            Form2.DataToolStripMenuItem.Enabled = True
            Form2.StaffToolStripMenuItem.Enabled = True
            Form2.TentangToolStripMenuItem.Enabled = True
            Form2.LoginToolStripMenuItem.Enabled = False
            Form2.TransaksiToolStripMenuItem.Enabled = True

        Else
            MessageBox.Show("error")
            TextBox1.Clear()
            TextBox2.Clear()

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()


    End Sub
End Class