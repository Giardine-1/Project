Imports MySql.Data.MySqlClient
Public Class CreateQRvb
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Dim Connection As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=admin")
    Public Property User As String
    Public Property Sec As String
    Public Property Nameu As String
    Public Property SecIDd As String


    Private Sub CreateQRvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Name1.Text = Nameu
        Label1.Text = Sec
        Label2.Text = User
        Label3.Text = SecIDd
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click

        If StudentNumberExist(TBStuNum.Text) Then
            MsgBox("Student already has a QR Code. Use QR Code to enroll!")
            PictureBox1.Visible = True
        Else
            Me.Width = 607
            PictureBox1.Visible = False
            'connect & insert to database

            Dim command As New MySqlCommand("INSERT INTO users(`firstname`, `surname`, `studentnumber`) VALUES (@fi, @su, @stnum)", Connection)

            Dim sec1 = Label1.Text

            Dim sec As New MySqlCommand("INSERT INTO section_users( `Firstname`, `Lastname`, `Student_Number`, `sec_id`) VALUES (@fii, @suu, @stnuum,@secid)", Connection)

            'parameters
            command.Parameters.Add("@fi", MySqlDbType.VarChar).Value = TBFname.Text
            command.Parameters.Add("@su", MySqlDbType.VarChar).Value = TBLname.Text
            command.Parameters.Add("@stnum", MySqlDbType.VarChar).Value = TBStuNum.Text
            sec.Parameters.Add("@fii", MySqlDbType.VarChar).Value = TBFname.Text
            sec.Parameters.Add("@suu", MySqlDbType.VarChar).Value = TBLname.Text
            sec.Parameters.Add("@stnuum", MySqlDbType.VarChar).Value = TBStuNum.Text
            sec.Parameters.Add("@secid", MySqlDbType.VarChar).Value = Label3.Text
            Connection.Open()

            If command.ExecuteNonQuery() = 1 Then
                MsgBox("User Inserted in All users")
                Connection.Close()
            Else
                MsgBox("NOt inserted in All users")
                Connection.Close()
            End If

            Connection.Open()

            If sec.ExecuteNonQuery() = 1 Then
                MsgBox("User Inserted in section")
                Connection.Close()
            Else
                MsgBox("NOt inserted in section")
                Connection.Close()
            End If

        End If
        'create QR Code and show to PictureBox2
        Try
            PictureBox2.Image = QR_Generator.Encode(TBStuNum.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Try
            Dim img As New Bitmap(PictureBox2.Image)
            img.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Png)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        SaveFileDialog1.ShowDialog()
    End Sub
    Public Function StudentNumberExist(ByVal username As String) As Boolean

        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT * FROM `users` WHERE `studentnumber` = @sn", Connection)
        command.Parameters.Add("@sn", MySqlDbType.VarChar).Value = TBStuNum.Text
        adapter.SelectCommand = command
        adapter.Fill(table)


        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        Connection.Close()
        MainMenu.Username = Label2.Text
        MainMenu.StringPass = Name1.Text
        MainMenu.Show()


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Connection.Close()
        MainMenu.Username = Label2.Text
        MainMenu.StringPass = Name1.Text
        MainMenu.Show()
    End Sub
End Class