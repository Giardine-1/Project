Imports MySql.Data.MySqlClient
Imports MessagingToolkit.QRCode.Codec

Public Class AddStuScanPC
    Dim Connection As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=admin")
    Public Property User2 As String
    Public Property Sec2 As String
    Public Property Name2 As String
    Public Property Secid2 As String

    Dim something As QRCodeDecoder
    Dim pic As Bitmap = New Bitmap(190, 190)
    Dim gfx As Graphics = Graphics.FromImage(pic)

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        gfx.CopyFromScreen(New Point(Me.Location.X + PictureBox1.Location.X + 4, Me.Location.Y + PictureBox1.Location.Y + 30),
                           New Point(0, 0), pic.Size)
        PictureBox1.Image = pic
        PictureBox1.Image = Nothing
    End Sub



    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        PictureBox2.Image = pic

        Try
            something = New QRCodeDecoder
            Dim decoded As String = something.decode(New Data.QRCodeBitmapImage(PictureBox2.Image))
            StudNUm.Text = decoded
            MsgBox("QR code Detected!")
        Catch ex As Exception

        End Try

        'Search in users
        Dim reader As MySqlDataReader

        reader = Nothing

        Dim Query As String
        Query = "select * from users where studentnumber='" & StudNUm.Text & "' "
        Dim command As New MySqlCommand(Query, Connection)
        Connection.Open()
        reader = command.ExecuteReader
        If reader.Read Then
            Fname.Text = reader(1)
            Lname.Text = reader(2)
            reader = Nothing
            Connection.Close()

            If StudentNumberExist(StudNUm.Text) Then
                MsgBox("Student Number Exists. User Already Enrolled!")
                Connection.Close()
            Else
                Connection.Close()
                Dim sec As New MySqlCommand("INSERT INTO section_users( `Firstname`, `Lastname`, `Student_Number`, `sec_id`) VALUES (@fii, @suu, @stnuum,@secid)", Connection)
                sec.Parameters.Add("@fii", MySqlDbType.VarChar).Value = Fname.Text
                sec.Parameters.Add("@suu", MySqlDbType.VarChar).Value = Lname.Text
                sec.Parameters.Add("@stnuum", MySqlDbType.VarChar).Value = StudNUm.Text
                sec.Parameters.Add("@secid", MySqlDbType.VarChar).Value = Label2.Text

                Connection.Open()
                If sec.ExecuteNonQuery() = 1 Then
                    MsgBox("User is now Enrolled in section")
                    Connection.Close()
                Else
                    MsgBox("Not enrolled in section. Try Again")
                    Connection.Close()
                End If
            End If
        Else
            MsgBox("Student number is not found in database. Create New Student.")
        End If
    End Sub

    Private Sub AddStuScanPC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nami.Text = User2
        StringP.Text = Name2
        Label1.Text = Sec2
        Label2.Text = Secid2
    End Sub

    Public Function StudentNumberExist(ByVal username As String) As Boolean

        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("select * from  section_users where sec_id ='" & Label2.Text & "'AND Student_Number ='" & StudNUm.Text & "'", Connection)
        adapter.SelectCommand = command
        adapter.Fill(table)
        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        Connection.Close()
        MainMenu.Username = Nami.Text
        MainMenu.StringPass = StringP.Text
        MainMenu.Show()
    End Sub
End Class