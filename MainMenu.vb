Imports MySql.Data.MySqlClient
Public Class MainMenu
    Dim Frm1 As New Form1()
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=admin")
    Dim reader As MySqlDataReader


    Public Property StringPass As String
    Public Property Username As String

    'for class list
    Sub list()

        Dim query As String = "select * from section_users where sec_id ='" & Label19.Text & "'"
        Dim ds As New DataSet
        Dim adp As New MySqlDataAdapter(query, connection)
        adp.Fill(ds, "EMP")
        DataGridView1.DataSource = ds.Tables(0)

        connection.Close()
    End Sub
    Sub att()
        Dim some As String = "SELECT * FROM records_attendance WHERE Date='" & Label44.Text & "' AND section_id='" & Label19.Text & "'"
        Dim dA As New DataSet
        Dim adp As New MySqlDataAdapter(some, connection)
        adp.Fill(dA, "EMP")
        DataGridView2.DataSource = dA.Tables(0)
        connection.Close()
    End Sub
    Sub Desc()
        Dim des As New MySqlCommand("SELECT * FROM section WHERE id='" & Label19.Text & "'", connection)
        reader = Nothing
        connection.Open()
        reader = des.ExecuteReader
        If reader.Read Then
            Label46.Text = reader(2)
            connection.Close()
        End If
    End Sub

    Sub SecID()
        'getting section id
        Dim nd As New MySqlCommand("SELECT * FROM section WHERE Subject_Section='" & Label10.Text & "'", connection)
        reader = Nothing
        connection.Open()
        reader = nd.ExecuteReader

        If reader.Read Then
            Label19.Text = reader(0)
            connection.Close()
        Else
            MsgBox("Something went wrong in getting your Section_id")
            connection.Close()
        End If
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()
        Label1.Text = StringPass
        Label4.Text = Username

        'getting faculty sections (id of faculty)
        Dim com As New MySqlCommand("SELECT * FROM `faculty` WHERE `username`='" & Label4.Text & "'", connection)

        connection.Open()
        reader = com.ExecuteReader
        If reader.Read Then

            Label18.Text = reader(0)
            connection.Close()
        Else
            MsgBox("There is a problem in getting your sections.")
            connection.Close()
        End If


        'getting info from database section
        reader = Nothing
        Dim Query As String
        Query = "select * from section INNER JOIN faculty_section ON section.id = faculty_section.section_id WHERE `user_id`='" & Label18.Text & "'"
        Dim imand As New MySqlCommand(Query, connection)
        Dim array(8) As String
        Dim count As Byte
        count = 1
        connection.Open()
        reader = imand.ExecuteReader


        While reader.Read

            array(count) = reader(1)
            Label3.Text = array(1)
            Label6.Text = array(2)
            Label8.Text = array(3)
            Label11.Text = array(4)
            Label26.Text = array(5)
            Label27.Text = array(6)
            Label28.Text = array(7)
            count = count + 1
        End While
        connection.Close()


    End Sub


    'Menu button sa labas
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        BunifuGradientPanel2.Width = 199
        BunifuGradientPanel3.Visible = False
        StartBox.Height = 0
        ADDSTU.Width = 0
    End Sub
    'Menu button sa loob
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        BunifuGradientPanel2.Width = 0
    End Sub

    'X button sa mismong menu
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
        Frm1.Show()
    End Sub

    'click section
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        BunifuGradientPanel2.Width = 0
        BunifuGradientPanel3.Visible = True
        Label10.Text = Label3.Text
        SecID()
        Desc()

    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        BunifuGradientPanel2.Width = 0
        BunifuGradientPanel3.Visible = True
        Label10.Text = Label3.Text
        SecID()
        Desc()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        BunifuGradientPanel2.Width = 0
        BunifuGradientPanel3.Visible = True
        Label10.Text = Label6.Text
        SecID()
        Desc()
    End Sub
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        BunifuGradientPanel2.Width = 0
        BunifuGradientPanel3.Visible = True
        Label10.Text = Label11.Text
        SecID()
        Desc()
    End Sub
    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click
        BunifuGradientPanel2.Width = 0
        BunifuGradientPanel3.Visible = True
        Label10.Text = Label26.Text
        SecID()
        Desc()
    End Sub
    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click
        BunifuGradientPanel2.Width = 0
        BunifuGradientPanel3.Visible = True
        Label10.Text = Label27.Text
        SecID()
        Desc()
    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click
        BunifuGradientPanel2.Width = 0
        BunifuGradientPanel3.Visible = True
        Label10.Text = Label28.Text
        SecID()
        Desc()
    End Sub
    Private Sub StartAttendance_Click(sender As Object, e As EventArgs) Handles StartAttendance.Click
        GroupBox1.Visible = False
        BunifuGradientPanel3.Width = 583
        StartBox.Height = 199
        ADDSTU.Width = 0
    End Sub

    Private Sub ScanWeb_Click(sender As Object, e As EventArgs) Handles ScanWeb.Click
        Me.Hide()

    End Sub

    'go to scan attendance
    Private Sub ScanPC_Click(sender As Object, e As EventArgs) Handles ScanPC.Click
        Me.Hide()
        StartBox.Height = 133
        ScanAttPC.Name1 = StringPass
        ScanAttPC.User1 = Username
        ScanAttPC.Sec1 = Label10.Text
        ScanAttPC.Secid = Label19.Text
        ScanAttPC.Show()
    End Sub

    Private Sub AddStudent_Click(sender As Object, e As EventArgs) Handles AddStudent.Click
        GroupBox1.Visible = False
        BunifuGradientPanel3.Width = 583
        StartBox.Height = 0
        ADDSTU.Width = 254
    End Sub


    'add student
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Timer1.Start()
        If Not ADDSTU.Height = 121 Then
            ADDSTU.Height = 121
            Timer1.Enabled = False
            list()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ADDSTU.Height = 209
        Timer1.Stop()

    End Sub

    'ClassList
    Private Sub ClassList_Click(sender As Object, e As EventArgs) Handles ClassList.Click
        GroupBox1.Visible = False
        Panel1.Visible = True
        BunifuGradientPanel3.Width = 0
        connection.Close()
        list()
    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            Label14.Text = row.Cells(1).Value.ToString
            Label14.Visible = True
            Label17.Text = row.Cells(3).Value.ToString
            Label17.Visible = True
        Catch ex As Exception

        End Try
    End Sub
    Private Sub BunifuCustomTextbox1_TextChanged(sender As Object, e As EventArgs) Handles BunifuCustomTextbox1.TextChanged
        Dim Adapter As New MySqlDataAdapter
        Dim ds As New DataSet
        Try
            connection.Open()
            Adapter = New MySqlDataAdapter("select * from  section_users where sec_id ='" & Label19.Text & "'AND Student_Number like '%" & BunifuCustomTextbox1.Text & "%'", connection)
            Adapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            connection.Close()

        Catch ex As Exception

        End Try
    End Sub


    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click

        Dim Sm As String = "DELETE FROM section_users WHERE Student_Number = '" & Label17.Text & "'"
        Dim cmd As New MySqlCommand(Sm, connection)
        connection.Open()
        cmd.ExecuteNonQuery()
        list()
        connection.Close()

    End Sub

    'Go to Create New QR
    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Me.Hide()
        Dim CRQ As New CreateQRvb()
        CRQ.Nameu = StringPass
        CRQ.User = Username
        CRQ.Sec = Label10.Text
        CRQ.SecIDd = Label19.Text
        CRQ.Show()

    End Sub

    Private Sub Label20_MouseHover(sender As Object, e As EventArgs) Handles Label20.MouseHover
        Label20.ForeColor = Color.White
    End Sub

    Private Sub Label20_MouseLeave(sender As Object, e As EventArgs) Handles Label20.MouseLeave
        Label20.ForeColor = Color.Maroon
    End Sub

    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        Label2.ForeColor = Color.White
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Color.Maroon
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        Frm1.Show()

    End Sub

    Private Sub Label3_MouseHover(sender As Object, e As EventArgs) Handles Label3.MouseHover
        Label3.ForeColor = Color.White
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label3.ForeColor = Color.Black
    End Sub

    Private Sub Label8_MouseHover(sender As Object, e As EventArgs) Handles Label8.MouseHover
        Label8.ForeColor = Color.White
    End Sub

    Private Sub Label8_MouseLeave(sender As Object, e As EventArgs) Handles Label8.MouseLeave
        Label8.ForeColor = Color.Black
    End Sub
    Private Sub Label11_MouseHover(sender As Object, e As EventArgs) Handles Label11.MouseHover
        Label11.ForeColor = Color.White
    End Sub

    Private Sub Label11_MouseLeave(sender As Object, e As EventArgs) Handles Label11.MouseLeave
        Label11.ForeColor = Color.Black
    End Sub
    Private Sub Label6_MouseHover(sender As Object, e As EventArgs) Handles Label6.MouseHover
        Label6.ForeColor = Color.White
    End Sub

    Private Sub Label6_MouseLeave(sender As Object, e As EventArgs) Handles Label6.MouseLeave
        Label6.ForeColor = Color.Black
    End Sub
    'X button on Class list
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Panel1.Visible = False
        BunifuGradientPanel3.Width = 583
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Me.Hide()

        AddStuScanPC.Name2 = StringPass
        AddStuScanPC.User2 = Username
        AddStuScanPC.Sec2 = Label10.Text
        AddStuScanPC.Secid2 = Label19.Text
        AddStuScanPC.Show()
    End Sub

    'Add Subject
    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        AddSubject.Name3 = StringPass
        AddSubject.User3 = Username
        AddSubject.Show()
        Me.Hide()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label21.Text = Date.Now.ToString("dd-MM-yyyy")
        Label22.Text = Date.Now.ToString("dddd")
        Label25.Text = Date.Now.ToString("h:mm:ss")
    End Sub

    'Start Attendance Now
    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        Day()

        If Not Label29.Text = Label22.Text Then
            MsgBox("Your schedule is '" & Label29.Text & "', '" & Label30.Text & "'-" & Label31.Text & "'. Click 'Start Attendance For' to create an attendance.")
        Else
            If Date.Now.ToString("hh:mm:ss") > Label30.Text And Date.Now.ToString("hh:mm:ss") < Label31.Text Then
                ScanPC.Visible = True
                BunifuFlatButton8.Visible = True
                StartBox.Height = 218
                MsgBox("Simulan nayan!")

            Else
                MsgBox("Your schedule is " & Label29.Text & ", " & Label30.Text & "-" & Label31.Text & ". Click 'Start Attendance For' to create an attendance.")

            End If
        End If
    End Sub

    'Start attendance For
    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        Day()
        If Label29.Text = Label22.Text Then
            MsgBox("You still have time to your class. Click 'Start Attendance Now' to easily create an attendance.")
        Else
            StartAttFor.Name4 = StringPass
            StartAttFor.User4 = Username
            StartAttFor.Secid4 = Label19.Text
            StartAttFor.Show()
            Me.Hide()

        End If

    End Sub

    Sub Day()
        Dim Day As New MySqlCommand("SELECT * FROM `section` WHERE `id`='" & Label19.Text & "'", connection)
        reader = Nothing
        connection.Open()
        reader = Day.ExecuteReader
        If reader.Read Then
            Label29.Text = reader(3)
            Label30.Text = reader(4).ToString
            Label31.Text = reader(5).ToString
            connection.Close()
        Else
            MsgBox("There is a problem in making your attendance sheet.")
            connection.Close()
        End If
    End Sub

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
        WebcamScan.Name1 = StringPass
        WebcamScan.User1 = Username
        WebcamScan.Sec1 = Label10.Text
        WebcamScan.Secid = Label19.Text
        Me.Hide()
        WebcamScan.Show()
    End Sub

    Private Sub View_Click(sender As Object, e As EventArgs) Handles View.Click
        StartBox.Height = 0
        ADDSTU.Width = 0
        GroupBox1.Visible = True
        Dim att As New MySqlCommand("SELECT * FROM `records_attendance` WHERE section_id=" & Label19.Text & "", connection)
        reader = Nothing
        connection.Open()
        reader = att.ExecuteReader
        Dim ary(12) As String
        Dim array(14) As String
        Dim cnt As Byte
        cnt = 1
        Dim cn As Byte
        cn = 1
        Dim c As Byte
        c = 1
        While reader.Read
            ary(cnt) = reader(4)
            Label32.Text = ary(1)
            cn = cnt - 1
            If Not ary(cn) = ary(cnt) Then
                array(c) = ary(cnt)
                c = c + 1
            End If

            Label33.Text = array(2)
            Label34.Text = array(3)
            Label35.Text = array(4)
            Label36.Text = array(5)
            Label37.Text = array(6)
            Label38.Text = array(7)
            Label39.Text = array(8)
            Label40.Text = array(9)
            Label41.Text = array(10)
            Label42.Text = array(11)
            Label43.Text = array(12)

            cnt = cnt + 1
        End While
        connection.Close()


    End Sub

    Private Sub Label32_MouseHover(sender As Object, e As EventArgs) Handles Label32.MouseHover
        Label32.ForeColor = Color.White
    End Sub
    Private Sub Label33_MouseHover(sender As Object, e As EventArgs) Handles Label33.MouseHover
        Label33.ForeColor = Color.White
    End Sub
    Private Sub Label34_MouseHover(sender As Object, e As EventArgs) Handles Label34.MouseHover
        Label34.ForeColor = Color.White
    End Sub
    Private Sub Label35_MouseHover(sender As Object, e As EventArgs) Handles Label35.MouseHover
        Label35.ForeColor = Color.White
    End Sub

    Private Sub Label36_MouseHover(sender As Object, e As EventArgs) Handles Label36.MouseHover
        Label36.ForeColor = Color.White
    End Sub

    Private Sub Label32_MouseLeave(sender As Object, e As EventArgs) Handles Label32.MouseLeave
        Label32.ForeColor = Color.Black
    End Sub
    Private Sub Label33_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label33.ForeColor = Color.Black
    End Sub
    Private Sub Label34_MouseLeave(sender As Object, e As EventArgs) Handles Label34.MouseLeave
        Label34.ForeColor = Color.Black
    End Sub
    Private Sub Label35_MouseLeave(sender As Object, e As EventArgs) Handles Label35.MouseLeave
        Label35.ForeColor = Color.Black
    End Sub
    Private Sub Label36_MouseLeave(sender As Object, e As EventArgs) Handles Label36.MouseLeave
        Label36.ForeColor = Color.Black
    End Sub

    Private Sub Label33_Click(sender As Object, e As EventArgs) Handles Label33.Click
        Label44.Text = Label33.Text
        Panel2.Visible = True
        SecID()
        att()
        BunifuGradientPanel3.Visible = False
    End Sub

    Private Sub Label36_Click(sender As Object, e As EventArgs) Handles Label36.Click
        Label44.Text = Label36.Text
        Panel2.Visible = True
        SecID()
        att()
        BunifuGradientPanel3.Visible = False
    End Sub

    Private Sub Label35_Click(sender As Object, e As EventArgs) Handles Label35.Click
        Label44.Text = Label35.Text
        Panel2.Visible = True
        SecID()
        att()
        BunifuGradientPanel3.Visible = False
    End Sub

    Private Sub Label34_Click(sender As Object, e As EventArgs) Handles Label34.Click
        Label44.Text = Label34.Text
        Panel2.Visible = True
        SecID()
        att()
        BunifuGradientPanel3.Visible = False
    End Sub

    Private Sub Label37_Click(sender As Object, e As EventArgs) Handles Label37.Click
        Label44.Text = Label37.Text
        Panel2.Visible = True

        SecID()
        att()
        BunifuGradientPanel3.Visible = False
    End Sub

    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click
        Label44.Text = Label32.Text
        Panel2.Visible = True
        SecID()
        att()
        BunifuGradientPanel3.Visible = False
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Panel2.Visible = False
        BunifuGradientPanel3.Visible = True
    End Sub

    Private Sub BunifuCustomTextbox2_TextChanged(sender As Object, e As EventArgs) Handles BunifuCustomTextbox2.TextChanged
        Dim Adapter As New MySqlDataAdapter
        Dim ds As New DataSet
        Try
            connection.Open()
            Adapter = New MySqlDataAdapter("SELECT * FROM records_attendance WHERE Date='" & Label44.Text & "' AND section_id='" & Label19.Text & "'AND `student number` like '%" & BunifuCustomTextbox2.Text & "%'", connection)
            Adapter.Fill(ds)
            DataGridView2.DataSource = ds.Tables(0)
            connection.Close()

        Catch ex As Exception

        End Try
    End Sub
End Class