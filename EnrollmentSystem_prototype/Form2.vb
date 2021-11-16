Imports MySql.Data.MySqlClient

Public Class Form2
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim query As String

    'This is for coding system
    'This is global variables for generate code function   
    Dim inc As Integer
    Dim q1, q2, q3, q4, q5 As Integer

    Private Function generateCode() As String
        Dim code As String
        Dim fn, mn, ln As String
        Dim count As String
        Dim batch As String

        fn = TextBox2.Text.Chars(0)
        mn = TextBox4.Text.Chars(0)
        ln = TextBox3.Text.Chars(0)

        count = tnsg(1)

        batch = "B2101"

        code = ln & fn & mn & count & batch
        '
        Return code
    End Function


    Private Function tnsg(ByRef x As Integer) As String

        Dim final As String

        Dim a() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        Dim b() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        Dim c() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        Dim d() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}



        If q4 >= 9 Then
            q3 = q3 + 1
            If q3 = 9 Then
                q2 = q2 + 1
                q3 = q3 - 9
                If q2 = 9 Then
                    q1 = q1 + 1
                    q2 = q2 - 9
                End If
            End If

            inc = inc - 10
            x = x - 10
        End If

        q4 = x

        final = a(q1) & b(q2) & c(q3) & d(q4)

        Return final
    End Function

    Private Function incrementNo() As Integer


        inc = inc + 1

        Return inc
    End Function



    'End of coding system



    Private Function blankChecker() As Boolean
        'MessageBox.Show("Pleas fill up those blanks")
        Dim a As Integer
        a = 2
        If TextBox2.Text = "" Then
            Return False
        ElseIf TextBox3.Text = "" Then
            Return False
        ElseIf TextBox4.Text = "" Then
            Return False
        ElseIf TextBox5.Text = "" Then
            Return False
        ElseIf TextBox7.Text = "" Then
            Return False
        ElseIf TextBox8.Text = "" Then
            Return False
        ElseIf TextBox9.Text = "" Then
            Return False
        ElseIf TextBox10.Text = "" Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub unChecks()

        CheckedListBox1.SetItemCheckState(0, False)
        CheckedListBox1.SetItemCheckState(1, False)
        CheckedListBox1.SetItemCheckState(2, False)
        CheckedListBox1.SetItemCheckState(3, False)
        CheckedListBox1.SetItemCheckState(4, False)
        CheckedListBox1.SetItemCheckState(5, False)
        CheckedListBox1.SetItemCheckState(6, False)

    End Sub

    Private Sub clearTxtB()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub

    Private Function gender() As String
        Dim a As String
        If (RadioButton1.Checked) Then
            Return RadioButton1.Text
        Else
            Return RadioButton2.Text
        End If

    End Function



    Private Sub testB()
        MessageBox.Show(DateTimePicker1.Value)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click REM EXIT butn
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click REM menu
        Timer1.Start()
        Panel2.BringToFront()
    End Sub

    Private Sub openMenu()
        Dim a As Integer
        a = -238

        While a <= 0
            Panel2.Location = New System.Drawing.Point(a, 1)

            a += 1
        End While
        Timer1.Stop()
        Timer1.Dispose()
    End Sub

    Private Sub closeMenu()
        Dim a As Integer
        a = 0

        'While a >= -238
        'Panel2.Location = New System.Drawing.Point(a, 1)
        'a -= 1
        'End While

        Panel2.Location = New System.Drawing.Point(-238, 1)
        Timer1.Stop()
        Timer1.Dispose()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim a, b As Integer
        a = Panel2.Location.X

        If a = -238 Then
            openMenu()
        ElseIf a = 0 Then

            closeMenu()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim usern, passw As String
        Dim rd As MySqlDataReader
        'conn = New MySqlConnection
        'conn.ConnectionString = "server=localhost;uid=root;password=asd098qwe9ijmjy6;database=cs"
        'query = "select user,pass From acc WHERE no = 2"

        'Try
        'conn.Open()
        'MessageBox.Show("connected")
        'cmd = New MySqlCommand(query, conn)
        'cmd.ExecuteNonQuery()
        'rd = cmd.ExecuteReader()
        'rd.Read()

        'usern = rd("user")
        'passw = rd("pass")

        'If TextBox22.Text = usern Then
        'If TextBox1.Text = passw Then
        'Panel20.Hide()
        'End If
        'Else
        'Box.Show("Account doesnt exist")
        'End If
        'conn.Close()
        ' Catch ex As MySqlException
        'MessageBox.Show("failed " & ex.Message)
        'End Try
        If TextBox22.Text = "admin" Then
            If TextBox1.Text = "root" Then
                Panel20.Hide()
            End If
        Else
            MessageBox.Show("Account doesnt exist")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Census._census' table. You can move, or remove it, as needed.
        'Me.CensusTableAdapter.Fill(Me.Census._census)
        'TODO: This line of code loads data into the 'RegMax.reg' table. You can move, or remove it, as needed.
        'Me.RegTableAdapter2.Fill(Me.RegMax.reg)

        'TODO: This line of code loads data into the 'Reg._reg' table. You can move, or remove it, as needed.
        'Me.RegTableAdapter.Fill(Me.Reg._reg)

        'TODO: This line of code loads data into the 'CsDataSet.hometable' table. You can move, or remove it, as needed.
        'Me.HometableTableAdapter.Fill(Me.CsDataSet.hometable)

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Panel24.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel24.Location = New System.Drawing.Point(1, 1)
        Panel24.BringToFront()
        Panel24.Show()
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub

    Private Sub finish()
        'collectData()
        clearTxtB()
        Me.RegTableAdapter.Fill(Me.Reg._reg)
        Panel24.Hide()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click REM finish button
        'testB()
        'finish()

        If blankChecker() = False Then
            MessageBox.Show("please complete details")
        Else
            finish()
        unChecks()
        End If

        'MessageBox.Show(noChecker())

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click REM button for examination panel
        Panel22.Location = New System.Drawing.Point(0, 0)
        Panel22.BringToFront()
        Panel21.BringToFront()
        Panel21.Location = New System.Drawing.Point(0, 0)
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged REM textbox for security in exam panel
        If TextBox11.Text = "root" Then
            Panel22.Location = New System.Drawing.Point(-1500, 0)
            Panel21.Location = New System.Drawing.Point(0, 0)
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click REM button to exit on security at examination panel
        Panel21.Location = New System.Drawing.Point(-1500, 0)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click REM to show questionnaire sets

        If Panel60.Location.X = -1500 Then
            Panel60.Location = New System.Drawing.Point(0, 65)
        ElseIf Panel60.Location.X = 0 Then
            Panel60.Location = New System.Drawing.Point(-1500, 65)
        End If

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click REM button to add questionnaires 
        Button16.Visible = True
        Panel56.Visible = True
        Button15.Visible = False
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click REM button to add questionnaires2         

        If TextBox12.Text = "" Then
            MessageBox.Show("Please Finish the new questionnaire first")
        Else
            Button17.Visible = True
            Panel57.Visible = True
            Button16.Visible = False
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click REM button to add questionnaires2 
        Button18.Visible = True
        Panel58.Visible = True
        Button17.Visible = False
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click REM button to add questionnaires2 
        Button19.Visible = True
        Panel59.Visible = True
        Button18.Visible = False
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click REM to open the add question        
        If TextBox12.Text = "" Then
            MessageBox.Show("Please set questionnaire name")
        Else
            Panel62.Location = New System.Drawing.Point(0, 25)
        End If
    End Sub

    Private Sub TextBox21_TextChanged(sender As Object, e As EventArgs) Handles TextBox21.TextChanged

    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs)  REM button change the admin to student panel

    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs)  REM button change the student to admin panel

    End Sub

    Private Sub Panel23_Paint(sender As Object, e As PaintEventArgs) Handles Panel23.Paint

    End Sub

    Private Sub Panel18_Paint(sender As Object, e As PaintEventArgs) Handles Panel18.Paint

    End Sub

    Private Sub MaxNoToolStripButton_Click(sender As Object, e As EventArgs)
        'Try
        'Me.RegTableAdapter1.maxNo(Me.CsDataSet2.reg)
        'Catch ex As System.Exception
        'System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class