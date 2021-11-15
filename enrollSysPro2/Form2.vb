Public Class Form2
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity.ToString() > 0 Then
            Me.Opacity = Opacity.ToString() + 0.1
            If Me.Opacity.ToString() = 1 Then
                Timer1.Stop()
            End If
        End If
    End Sub

    Private Sub Button1_(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackgroundImage = Global.enrollSysPro2.My.Resources.rf_panel
    End Sub

    Private Sub Button1_1(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackgroundImage = Nothing
    End Sub

    Private Sub Button1_2(sender As Object, e As EventArgs) Handles Button1.MouseDown

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.BackgroundImage = Global.enrollSysPro2.My.Resources.admin
    End Sub

    Private Sub Button2_Click2(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackgroundImage = Nothing
    End Sub

    Private Sub Button2_Click3(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
        Me.Hide()
    End Sub
End Class