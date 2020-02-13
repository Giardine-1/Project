Imports MySql.Data.MySqlClient
Imports MessagingToolkit.QRCode.Codec
Public Class StartAttFor
    Dim Connection As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=admin")
    Public Property User4 As String
    Public Property Name4 As String
    Public Property Secid4 As String
    Dim reader As MySqlDataReader

    Sub List()

        Dim query As String = "select * from records_attendance where section_id='" & Label1.Text & "' AND Date ='" & Label2.Text & "' "
        Dim ds As New DataSet
        Dim adp As New MySqlDataAdapter(query, Connection)
        adp.Fill(ds, "EMP")
        DataGridView1.DataSource = ds.Tables(0)
        Connection.Close()
    End Sub

    Private Sub StartAttFor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Nami.Text = User4
        StringP.Text = Name4
        Label1.Text = Secid4
        Label21.Text = Date.Now.ToString("dd/MM/yyyy")
        Label22.Text = Date.Now.ToString("dddd")
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        MainMenu.StringPass = StringP.Text
        MainMenu.Username = Nami.Text
        Me.Close()
        MainMenu.Show()
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        Label2.Text = BunifuDatepicker1.Value.ToString("dd-MM-yyyy")

        If DateExist(Label2.Text) Then
            MsgBox("You have an existing attendance for " & Label2.Text & " . You cannot edit this for now.")
            Connection.Close()
        Else
            Panel1.Visible = False
            PictureBox4.Visible = False
            Panel2.Visible = True
            Me.Width = 787
            Me.Height = 584
            Connection.Close()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MainMenu.StringPass = StringP.Text
        MainMenu.Username = Nami.Text
        Me.Close()
        MainMenu.Show()
    End Sub

    Dim something As QRCodeDecoder
    Dim pic As Bitmap = New Bitmap(190, 190)
    Dim gfx As Graphics = Graphics.FromImage(pic)

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        gfx.CopyFromScreen(New Point(Me.Location.X + PictureBox1.Location.X + 4, Me.Location.Y + PictureBox1.Location.Y + 60),
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
        Query = "select * from section_users where sec_id='" & Label1.Text & "' AND  Student_Number ='" & StudNUm.Text & "' "
        Dim command As New MySqlCommand(Query, Connection)
        reader = Nothing
        Connection.Open()
        reader = command.ExecuteReader


        If reader.Read Then
            Fname.Text = reader(1)
            Lname.Text = reader(2)

            MessageBox.Show("Student is enrolled in this Section")
            Connection.Close()
            If StudentExist(StudNUm.Text) Then
                MsgBox("Student is already in the attendance!")
            Else
                Dim ins As New MySqlCommand("INSERT INTO `records_attendance`(`Time`, `firstname`, `lastname`, `student number`, `Date`, `section_id`) VALUES(@tim, @fn, @ln, @sn, @dat, @scc)", Connection)
                ins.Parameters.Add("@tim", MySqlDbType.Text).Value = Label4.Text
                ins.Parameters.Add("@fn", MySqlDbType.VarChar).Value = Fname.Text
                ins.Parameters.Add("@ln", MySqlDbType.VarChar).Value = Lname.Text
                ins.Parameters.Add("@sn", MySqlDbType.VarChar).Value = StudNUm.Text
                ins.Parameters.Add("@dat", MySqlDbType.Text).Value = Label2.Text
                ins.Parameters.Add("@scc", MySqlDbType.Int16).Value = Label1.Text

                Connection.Open()
                If ins.ExecuteNonQuery() = 1 Then
                    MsgBox("Student is now at attendance")
                    Connection.Close()
                    List()

                Else
                    MsgBox("Error!")
                End If

            End If
        Else
            MsgBox("Student is not enrolled in this section")
            Connection.Close()

        End If


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label25.Text = Date.Now.ToString("h:mm:ss")
        Label4.Text = Date.Now.ToString("h:mm:ss")
    End Sub

    Public Function StudentExist(ByVal username As String) As Boolean

        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT * FROM `records_attendance` WHERE `student number`=@sn AND `Date`=@dat AND `section_id`=@secc", Connection)
        command.Parameters.Add("@sn", MySqlDbType.VarChar).Value = StudNUm.Text
        command.Parameters.Add("@dat", MySqlDbType.Text).Value = Label2.Text
        command.Parameters.Add("@secc", MySqlDbType.Int16).Value = Label1.Text
        adapter.SelectCommand = command
        adapter.Fill(table)


        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function DateExist(ByVal username As String) As Boolean

        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT * FROM records_attendance WHERE `Date`=@dat AND `section_id`=@secc", Connection)
        command.Parameters.Add("@dat", MySqlDbType.Text).Value = Label2.Text
        command.Parameters.Add("@secc", MySqlDbType.Int16).Value = Label1.Text
        adapter.SelectCommand = command
        adapter.Fill(table)


        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class