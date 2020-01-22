Imports MySql.Data.MySqlClient
Public Class Form1
    Dim reader As MySqlDataReader
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub TBPassword_Enter(sender As Object, e As EventArgs) Handles TBPassword.Enter

        ' when textbox password has focus
        Dim pass As String = TBPassword.Text
        If pass.Trim().ToLower() = "Password" Or pass.Trim() = "" Then

            ' clear the textbox text
            TBPassword.Text = ""
            ' change the textbox font color
            TBPassword.ForeColor = Color.White

            ' use system password
            TBPassword.isPassword = True

        End If

    End Sub

    ' textbox password leave
    Private Sub TBPassword_Leave(sender As Object, e As EventArgs) Handles TBPassword.Leave

        ' when textbox password lost focus
        Dim pass As String = TBPassword.Text
        If pass.Trim().ToLower() = "Password" Or pass.Trim() = "" Then

            ' set the textbox text
            TBPassword.Text = "Password"
            ' change the textbox font color
            TBPassword.ForeColor = Color.DimGray
            ' set system password to false
            TBPassword.isPassword = False

        End If

    End Sub
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim connection As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=admin")
        Dim command As New MySqlCommand("SELECT * FROM `faculty` WHERE username='" & TBUsername.Text & "' and password='" & TBPassword.Text & "' ", connection)
        'getting Name
        connection.Open()
        reader = command.ExecuteReader
        Dim count As Integer
        count = 0
        While reader.Read
            count = count + 1
        End While
        connection.Close()
        If count = 1 Then
            connection.Open()
            Dim MM As New MainMenu()
            Dim mnd As New MySqlCommand("SELECT * FROM `faculty` WHERE `username`='" & TBUsername.Text & "'", connection)
            reader = Nothing
            reader = mnd.ExecuteReader
            If reader.Read Then
                MM.StringPass = (reader(3) & " " & reader(4))
                MM.username = TBUsername.Text
                connection.Close()
            End If
            Me.Hide()
            MM.Show()
        Else
            MsgBox("Invalid Credentials!")
        End If

    End Sub

End Class
