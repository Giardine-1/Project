<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStuScanPC
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddStuScanPC))
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.StudNUm = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Lname = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Fname = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.StudNum1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LName1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Fname1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Nami = New System.Windows.Forms.Label()
        Me.StringP = New System.Windows.Forms.Label()
        Me.Label1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.Yellow
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.Black
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Capture QR"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.Black
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.Honeydew
        Me.BunifuThinButton21.Location = New System.Drawing.Point(22, 257)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(181, 41)
        Me.BunifuThinButton21.TabIndex = 15
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(246, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(12, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.Label1)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox3)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Goldenrod
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.AntiqueWhite
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.YellowGreen
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Yellow
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 2)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(815, 27)
        Me.BunifuGradientPanel1.TabIndex = 20
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(784, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(28, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'StudNUm
        '
        Me.StudNUm.AutoSize = True
        Me.StudNUm.BackColor = System.Drawing.Color.Transparent
        Me.StudNUm.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudNUm.ForeColor = System.Drawing.Color.White
        Me.StudNUm.Location = New System.Drawing.Point(640, 112)
        Me.StudNUm.Name = "StudNUm"
        Me.StudNUm.Size = New System.Drawing.Size(142, 20)
        Me.StudNUm.TabIndex = 26
        Me.StudNUm.Text = "Student Number"
        '
        'Lname
        '
        Me.Lname.AutoSize = True
        Me.Lname.BackColor = System.Drawing.Color.Transparent
        Me.Lname.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lname.ForeColor = System.Drawing.Color.White
        Me.Lname.Location = New System.Drawing.Point(639, 82)
        Me.Lname.Name = "Lname"
        Me.Lname.Size = New System.Drawing.Size(97, 20)
        Me.Lname.TabIndex = 25
        Me.Lname.Text = "Last Name"
        '
        'Fname
        '
        Me.Fname.AutoSize = True
        Me.Fname.BackColor = System.Drawing.Color.Transparent
        Me.Fname.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fname.ForeColor = System.Drawing.Color.White
        Me.Fname.Location = New System.Drawing.Point(639, 53)
        Me.Fname.Name = "Fname"
        Me.Fname.Size = New System.Drawing.Size(98, 20)
        Me.Fname.TabIndex = 24
        Me.Fname.Text = "First Name"
        '
        'StudNum1
        '
        Me.StudNum1.AutoSize = True
        Me.StudNum1.BackColor = System.Drawing.Color.Transparent
        Me.StudNum1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudNum1.ForeColor = System.Drawing.Color.White
        Me.StudNum1.Location = New System.Drawing.Point(487, 112)
        Me.StudNum1.Name = "StudNum1"
        Me.StudNum1.Size = New System.Drawing.Size(149, 20)
        Me.StudNum1.TabIndex = 23
        Me.StudNum1.Text = "Student Number:"
        '
        'LName1
        '
        Me.LName1.AutoSize = True
        Me.LName1.BackColor = System.Drawing.Color.Transparent
        Me.LName1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LName1.ForeColor = System.Drawing.Color.White
        Me.LName1.Location = New System.Drawing.Point(486, 82)
        Me.LName1.Name = "LName1"
        Me.LName1.Size = New System.Drawing.Size(104, 20)
        Me.LName1.TabIndex = 22
        Me.LName1.Text = "Last Name:"
        '
        'Fname1
        '
        Me.Fname1.AutoSize = True
        Me.Fname1.BackColor = System.Drawing.Color.Transparent
        Me.Fname1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fname1.ForeColor = System.Drawing.Color.White
        Me.Fname1.Location = New System.Drawing.Point(486, 53)
        Me.Fname1.Name = "Fname1"
        Me.Fname1.Size = New System.Drawing.Size(105, 20)
        Me.Fname1.TabIndex = 21
        Me.Fname1.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(767, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Nami
        '
        Me.Nami.AutoSize = True
        Me.Nami.Location = New System.Drawing.Point(716, 304)
        Me.Nami.Name = "Nami"
        Me.Nami.Size = New System.Drawing.Size(39, 13)
        Me.Nami.TabIndex = 28
        Me.Nami.Text = "Label1"
        Me.Nami.Visible = False
        '
        'StringP
        '
        Me.StringP.AutoSize = True
        Me.StringP.Location = New System.Drawing.Point(671, 304)
        Me.StringP.Name = "StringP"
        Me.StringP.Size = New System.Drawing.Size(39, 13)
        Me.StringP.TabIndex = 27
        Me.StringP.Text = "Label1"
        Me.StringP.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Section_Label"
        '
        'AddStuScanPC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(815, 326)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Nami)
        Me.Controls.Add(Me.StringP)
        Me.Controls.Add(Me.StudNUm)
        Me.Controls.Add(Me.Lname)
        Me.Controls.Add(Me.Fname)
        Me.Controls.Add(Me.StudNum1)
        Me.Controls.Add(Me.LName1)
        Me.Controls.Add(Me.Fname1)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "AddStuScanPC"
        Me.Text = "AddStuScanPC"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents StudNUm As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Lname As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Fname As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents StudNum1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LName1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Fname1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Nami As Label
    Friend WithEvents StringP As Label
    Friend WithEvents Label1 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
