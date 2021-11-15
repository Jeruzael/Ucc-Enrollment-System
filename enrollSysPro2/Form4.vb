Public Class Form4
    'Panel2 => validation - show(7,4), hide(7, 504)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "bscs" Then
            Panel2.BackgroundImage = Global.enrollSysPro2.My.Resources.bscs
            Panel2.Location = New System.Drawing.Point(7, 4)
        ElseIf ComboBox1.Text = "bsit" Then
            Panel2.Location = New System.Drawing.Point(7, 4)
        Else
            MessageBox.Show("Please select course")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel2.BackgroundImage = Nothing
        Panel2.Location = New System.Drawing.Point(7, 504)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class