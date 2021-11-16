Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim query As String

    Private Sub chkConn()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;uid=root;password=;database=busyman"

        Try
            conn.Open()
            'MessageBox.Show("Connected Successfuly")
            Timer1.Start()
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show("ooops failed")
        End Try

    End Sub

    Private Sub pb()
        Dim a, b As Integer
        a = 0
        b = 0

        While a < 10000
            a = a + 2
            Panel2.Width = a
        End While

        If Panel2.Width = 10000 Then
            Form2.Show()
            Me.Hide()
        End If
        Timer1.Stop()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'chkConn()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pb()
    End Sub
End Class
