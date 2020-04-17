Imports System.Data.SqlClient
Module Module1

    Public conn As SqlConnection
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public rd As SqlDataReader
    Public cmd As SqlCommand
    Public query As String

    Public Sub koneksi()
        conn = New SqlConnection("data source=ILHAM-PC\ILHAM;initial catalog=esemkamart;user=bgsilham;password=123")


        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Failed to connect! " & Err.Description)
        End Try
    End Sub

End Module
