Imports MySql.Data.MySqlClient

Public Class AddSubject
    Dim Connection As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=admin")
    Public Property User3 As String
    Public Property Name3 As String
    Dim reader As MySqlDataReader
    Private Sub AddSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Nami.Text = User3
        StringP.Text = Name3
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MainMenu.StringPass = StringP.Text
        MainMenu.Username = Nami.Text
        Me.Close()
        MainMenu.Show()
    End Sub

    Public Function SectionExists(ByVal username As String) As Boolean

        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT * FROM `section` WHERE `Subject_Section` = @sn", Connection)
        command.Parameters.Add("@sn", MySqlDbType.VarChar).Value = Label1.Text
        adapter.SelectCommand = command
        adapter.Fill(table)


        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Label1.Text = (Code1.Text & " " & Section1.Text)
        If BunifuDropdown2.selectedValue > BunifuDropdown3.selectedValue Then
            MsgBox("Selected start time is more than end time. Input is not valid!")
        Else
            If SectionExists(Label1.Text) Then
                MsgBox("Section " & Label1.Text & " Exist.")
            Else
                Dim command As New MySqlCommand("INSERT INTO `section`( `Subject_Section`, `Subject Description`,`Day`, `Start_Time`, `End_Time`) VALUES (@ss, @sd, @dy, @st, @et)", Connection)
                command.Parameters.Add("@ss", MySqlDbType.VarChar).Value = Label1.Text
                command.Parameters.Add("@sd", MySqlDbType.VarChar).Value = Desc.Text
                command.Parameters.Add("@dy", MySqlDbType.VarChar).Value = BunifuDropdown1.selectedValue
                command.Parameters.Add("@st", MySqlDbType.VarChar).Value = BunifuDropdown2.selectedValue
                command.Parameters.Add("@et", MySqlDbType.VarChar).Value = BunifuDropdown3.selectedValue
                Connection.Open()


                If command.ExecuteNonQuery = 1 Then
                    Connection.Close()

                    Dim cd As New MySqlCommand("SELECT * FROM section WHERE Subject_Section='" & Label1.Text & "'", Connection)

                    Connection.Open()
                    reader = cd.ExecuteReader

                    If reader.Read Then
                        Label2.Text = reader(0)
                        Connection.Close()

                    Else
                        Connection.Close()
                        MsgBox("No Section ID")
                    End If

                    Dim ud As New MySqlCommand("SELECT * FROM `faculty` WHERE `username`='" & Nami.Text & "'", Connection)
                    reader = Nothing
                    Connection.Open()
                    reader = ud.ExecuteReader

                    If reader.Read Then
                        Label3.Text = reader(0)
                        Connection.Close()

                    Else
                        Connection.Close()
                        MsgBox("No Faculty ID")
                    End If

                    Dim sd As New MySqlCommand("INSERT INTO `faculty_section`( `user_id`, `section_id`) VALUES (@ui, @si)", Connection)

                    sd.Parameters.Add("@ui", MySqlDbType.VarChar).Value = Label3.Text
                    sd.Parameters.Add("@si", MySqlDbType.VarChar).Value = Label2.Text
                    Connection.Open()


                    If sd.ExecuteNonQuery = 1 Then
                        MsgBox("Section Sucessfully Created!")
                        Connection.Close()
                        Code1.ResetText()
                        Section1.ResetText()
                        Desc.ResetText()
                        BunifuDropdown1.ResetText()
                        BunifuDropdown2.ResetText()
                        BunifuDropdown3.ResetText()
                    Else
                        Connection.Close()
                        MsgBox("There is a problem in creating the section. Try again.")
                    End If
                Else
                    MsgBox("Section is not created")
                    Connection.Close()
                End If
            End If
        End If
    End Sub
End Class