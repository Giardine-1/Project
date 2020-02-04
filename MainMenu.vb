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
        Dim array(5) As String
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
            count = count + 1
        End While
        connection.Close()

        'getting section id
        Dim nd As New MySqlCommand("SELECT * FROM section WHERE Subject_Section='" & Label3.Text & "'", connection)
        reader = Nothing
        connection.Open()
        reader = nd.ExecuteReader

        If reader.Read Then
            Label19.Text = reader(0)
            connection.Close()
        Else
            MsgBox("Something went wrong in getting your Sections")
            connection.Close()
        End If
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

    End Sub

    Private Sub StartAttendance_Click(sender As Object, e As EventArgs) Handles StartAttendance.Click
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

        ScanAttPC.Name1 = StringPass
        ScanAttPC.User1 = Username
        ScanAttPC.Sec1 = Label10.Text
        ScanAttPC.Secid = Label19.Text
        ScanAttPC.Show()
    End Sub

    Private Sub AddStudent_Click(sender As Object, e As EventArgs) Handles AddStudent.Click
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
            Adapter = New MySqlDataAdapter("select * from  section_users where sec_id ='" & Label19.Text & "'AND firstname like '%" & BunifuCustomTextbox1.Text & "%'", connection)
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

    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        Label2.ForeColor = Color.White
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Color.Black
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


    'X button on Class list
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Panel1.Visible = False
        BunifuGradientPanel3.Width = 583
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click

    End Sub
End Class