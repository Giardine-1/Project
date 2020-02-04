Imports MySql.Data.MySqlClient
Imports MessagingToolkit.QRCode.Codec
Public Class ScanAttPC

    Dim Connection As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=admin")
    Public Property User1 As String
    Public Property Sec1 As String
    Public Property Name1 As String
    Public Property Secid As String

    Dim something As QRCodeDecoder
    Dim pic As Bitmap = New Bitmap(190, 190)
    Dim gfx As Graphics = Graphics.FromImage(pic)

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        gfx.CopyFromScreen(New Point(Me.Location.X + PictureBox1.Location.X + 4, Me.Location.Y + PictureBox1.Location.Y + 30),
                           New Point(0, 0), pic.Size)
        PictureBox1.Image = pic
        PictureBox1.Image = Nothing
    End Sub

    Private Sub ScanAttPC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nami.Text = User1
        StringP.Text = Name1
        Label1.Text = Sec1
        Label2.Text = Secid

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Connection.Close()
        MainMenu.Username = Nami.Text
        MainMenu.StringPass = StringP.Text
        MainMenu.Show()
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
        Query = "select * from section_users where sec_id='" & Label2.Text & "' "
        Dim command As New MySqlCommand(Query, Connection)
            Dim array(5) As String
            Dim count As Byte
            Dim sec As Boolean = True
            count = 0
            Connection.Open()
            reader = command.ExecuteReader

            While reader.Read
                While sec = True
                    array(count) = reader(3)
                    Connection.Close()

                    If array(count) = StudNUm.Text Then
                        Dim First As New MySqlCommand("SELECT * FROM section_users WHERE Student_Number ='" & StudNUm.Text & "' ", Connection)
                        reader = Nothing
                        Connection.Open()
                        reader = First.ExecuteReader
                        MsgBox("pumasok sa student number")
                        If reader.Read Then
                        Fname.Text = reader(1)
                        Lname.Text = reader(2)
                        MessageBox.Show("Student is enrolled in this Section")

                        'dito mo ipasok yung sa attendance!
                        Connection.Close()
                            sec = False
                        End If
                    Else
                        MsgBox("hindi pumasok sa student number")
                    End If
                    Connection.Open()
                    reader = command.ExecuteReader
                    count = count + 1
                End While
            End While
            Connection.Close()



    End Sub
End Class