Imports System.Data.SqlClient
Public Class MainForm

    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub

    Sub Terkunci()
        LogoutToolStripMenuItem.Enabled = False
        ChangePasswordToolStripMenuItem.Enabled = False
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        LoginForm.ShowDialog()
    End Sub
End Class
