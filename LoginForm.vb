Imports System.Data.SqlClient
Public Class LoginForm

    Private Sub LoginForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub Terbuka()
        MainForm.LoginToolStripMenuItem.Enabled = False
        MainForm.LogoutToolStripMenuItem.Enabled = True

    End Sub



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Call koneksi()

        cmd = New SqlCommand("select * from Employee where Email = '" & TextBox1.Text & "' and Password = '" & TextBox2.Text & "'", conn)
        rd = cmd.ExecuteReader
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Fill can't be empty")
        Else
            If rd.Read() Then
                Me.Close()
                MsgBox("welcome!")
                Call Terbuka()
            Else
                MsgBox("Email or Pass incorrect!")
            End If
        End If
        

    End Sub
End Class