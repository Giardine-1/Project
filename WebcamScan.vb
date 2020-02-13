Imports MessagingToolkit.QRCode.Codec
Imports Webcam_Capture
Imports MySql.Data.MySqlClient

Public Class WebcamScan
    Dim Connection As New MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=admin")
    Public Property User1 As String
    Public Property Sec1 As String
    Public Property Name1 As String
    Public Property Secid As String

    WithEvents MyWebcam As WebCamCapture
    Dim Reader As QRCodeDecoder

    Private Sub StartWebCam()
        Try
            StopWebCam()
            MyWebcam = New WebCamCapture
            MyWebcam.Start(0)
            MyWebcam.Start(0)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub StopWebCam()
        Try
            MyWebcam.Stop()
            MyWebcam.Dispose()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub WebcamScan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nami.Text = User1
        StringP.Text = Name1
        Label1.Text = Sec1
        Label2.Text = Secid
        StartWebCam()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MainMenu.Username = Nami.Text
        MainMenu.StringPass = StringP.Text
        Me.Close()
        MainMenu.Show()
    End Sub

    Private Sub MyWebcam_ImageCaptured(source As Object, e As WebcamEventArgs) Handles MyWebcam.ImageCaptured
        PictureBox1.Image = e.WebCamImage
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Try
            StopWebCam()
            Reader = New QRCodeDecoder
            StudNUm.Text = Reader.decode(New Data.QRCodeBitmapImage(PictureBox1.Image))
            MsgBox("Qr Code detected!")
        Catch ex As Exception
            MsgBox("No Qr Code detected!")
            StartWebCam()
        End Try

    End Sub
End Class