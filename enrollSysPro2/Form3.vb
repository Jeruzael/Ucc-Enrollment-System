Public Class Form3
    'hidden tools
    'Panel1 => security -show(location.y = 0) -hide(location.y = 1000)
    'Panel2 => course -show(Size.height = 261)
    'Panel4 => side bar -visibility = false
    'Panel7 => theme btn -visibility = false
    'Panel9 => validation  -show(location.y = 25), hide(location.y = 1025)
    'Tabcontrol1 => table -show(Location.Y = 36) -hide(Location.Y = 1036)

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If ComboBox1.Text = "bscs" Then
            Panel9.Location = New System.Drawing.Point(344, 25)
            Panel9.BringToFront()
        Else
            MessageBox.Show("Please select a course")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel2.Height = 261
        TabControl1.Location = New System.Drawing.Point(346, 1036)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel2.Height = 0
        TabControl1.Location = New System.Drawing.Point(346, 36)
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity.ToString() > 0 Then
            Me.Opacity = Opacity.ToString() + 0.1
            If Me.Opacity.ToString = 1 Then
                Timer1.Stop()
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)  'show the reg form
        Form4.Show()
        Me.Hide()
    End Sub

    'events
    Private Sub letsgoHover(sender As Object, e As EventArgs) Handles Button6.MouseHover
        Me.Button6.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.goBTN2
    End Sub

    Private Sub letsgoLeave(sender As Object, e As EventArgs) Handles Button6.MouseLeave
        Me.Button6.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.goBTN3
    End Sub

    Private Sub settingsHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Me.Button1.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.settings2
        Panel4.Visible = True
    End Sub

    Private Sub settingsLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Me.Button1.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.settings
    End Sub

    Private Sub settingsLeave2(sender As Object, e As EventArgs) Handles Button1.Click
        Panel4.Visible = False
    End Sub

    Private Sub ExitBtnHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Me.Button2.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.exitBtn2
    End Sub

    Private Sub ExitBtnLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Me.Button2.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.exitbtn
    End Sub

    Private Sub ThemeHover(sender As Object, e As EventArgs) Handles Panel6.MouseEnter
        Panel7.Visible = True
    End Sub

    Private Sub ThemeLeave(sender As Object, e As EventArgs) Handles Panel6.MouseClick
        Panel7.Visible = False
    End Sub
    'events end

    'Themes
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Me.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.mainFormDefault
        Button1.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.settings
        Panel5.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.security
        Panel6.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.theme
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.MouseHover
        Me.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.mainFormTheme1
        Button3.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0)
        Button4.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0)
        Button5.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0)
        'Button3.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240)
        'Button4.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240)
        'Button5.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Button1.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.settings
        Panel5.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.security
        Panel6.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.theme
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.MouseHover
        Me.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.mainFormTheme21
        Button3.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0)
        Button4.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0)
        Button5.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0)
        Button1.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.settings
        Panel5.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.security
        Panel6.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.theme
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.MouseHover
        Me.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.mainFormTheme31
        Button3.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0)
        Button4.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0)
        Button5.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0)
        Button1.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.settings
        Panel5.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.security
        Panel6.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.theme
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.MouseHover
        Me.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.mainFormTheme41
        Button3.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Button4.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Button5.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Button1.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.settings2
        Panel5.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.security2
        Panel6.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.themeWhite
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.MouseHover
        Me.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.mainFormTheme51
        Button3.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0)
        Button4.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0)
        Button5.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0)
        Button1.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.settings
        Panel5.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.security
        Panel6.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.theme
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.MouseHover
        Me.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.mainFormTheme61
        Button3.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0)
        Button4.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0)
        Button5.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0)
        Button1.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.settings
        Panel5.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.security
        Panel6.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.theme
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.MouseHover
        Me.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.mainFormTheme71
        Button3.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Button4.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Button5.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Button1.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.settings2
        Panel5.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.security2
        Panel6.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.themeWhite
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.MouseHover
        Me.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.mainFormTheme81
        Button3.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0)
        Button4.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0)
        Button5.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0)
        Button1.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.settings
        Panel5.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.security
        Panel6.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.theme
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.MouseHover
        Me.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.mainFormTheme91
        Button3.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Button4.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Button5.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Button1.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.settings2
        Panel5.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.security2
        Panel6.BackgroundImage = Global.enrollSysPro2.My.Resources.Resources.themeWhite
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Panel1.Location = New System.Drawing.Point(1000, 0)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel9.Location = New System.Drawing.Point(7, 1025)
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub


    'Themes
End Class