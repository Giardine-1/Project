Imports MySql.Data.MySqlClient
Public Class MainMenu
    Dim Frm1 As New Form1()

    Public Property StringPass As String
    Public Property username As String
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()
        Label1.Text = StringPass
        Label4.Text = username
        Dim connection As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=admin")
        Dim reader As MySqlDataReader
        'getting faculty sections
        Dim com As New MySqlCommand("SELECT * FROM `faculty` WHERE `username`='" & Label4.Text & "'", connection)

        connection.Open()
        reader = com.ExecuteReader
        If reader.Read Then

            Label4.Text = reader(5)
            connection.Close()
        Else
            MsgBox("There is a problem in getting your sections.")
        End If

        'faculty_section
        Dim mand As New MySqlCommand("SELECT * FROM `section` WHERE `id`='" & Label4.Text & "'", connection)
        reader = Nothing
        connection.Open()
        reader = mand.ExecuteReader
        If reader.Read Then
            Label3.Text = (reader(1) & " " & reader(2))
            connection.Close()

        End If
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

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        BunifuGradientPanel2.Width = 199
        BunifuGradientPanel3.Visible = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        BunifuGradientPanel2.Width = 0
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
        Frm1.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        BunifuGradientPanel2.Width = 0
        BunifuGradientPanel3.Visible = True
        Label10.Text = Label3.Text

    End Sub
End Class