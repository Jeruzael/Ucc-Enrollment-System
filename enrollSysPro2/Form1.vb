Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity.ToString() > 0 Then
            Me.Opacity = Opacity.ToString() + 0.01
            Panel1.Width = Panel1.Width.ToString() + 1
            If Panel1.Width.ToString() = 453 Then
                Form2.Show()
                Me.Hide()
                Timer1.Stop()
                Timer2.Stop()
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer1.Start()
    End Sub
End Class
