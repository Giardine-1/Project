<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateQRvb
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateQRvb))
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.TBStuNum = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TBLname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TBFname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Name1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Label3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox3)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Goldenrod
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.AntiqueWhite
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.YellowGreen
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Yellow
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(-3, -2)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(609, 29)
        Me.BunifuGradientPanel1.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(267, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(578, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(28, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BunifuThinButton21)
        Me.GroupBox1.Controls.Add(Me.TBStuNum)
        Me.GroupBox1.Controls.Add(Me.TBLname)
        Me.GroupBox1.Controls.Add(Me.TBFname)
        Me.GroupBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Khaki
        Me.GroupBox1.Location = New System.Drawing.Point(12, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 249)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Register a New Student"
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
        Me.BunifuThinButton21.ButtonText = "Register"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.Black
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.Honeydew
        Me.BunifuThinButton21.Location = New System.Drawing.Point(48, 200)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(181, 41)
        Me.BunifuThinButton21.TabIndex = 11
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TBStuNum
        '
        Me.TBStuNum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TBStuNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBStuNum.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBStuNum.ForeColor = System.Drawing.Color.White
        Me.TBStuNum.HintForeColor = System.Drawing.Color.Khaki
        Me.TBStuNum.HintText = "Student Number"
        Me.TBStuNum.isPassword = False
        Me.TBStuNum.LineFocusedColor = System.Drawing.Color.Yellow
        Me.TBStuNum.LineIdleColor = System.Drawing.Color.Gray
        Me.TBStuNum.LineMouseHoverColor = System.Drawing.Color.Yellow
        Me.TBStuNum.LineThickness = 5
        Me.TBStuNum.Location = New System.Drawing.Point(28, 150)
        Me.TBStuNum.Margin = New System.Windows.Forms.Padding(5)
        Me.TBStuNum.Name = "TBStuNum"
        Me.TBStuNum.Size = New System.Drawing.Size(220, 36)
        Me.TBStuNum.TabIndex = 10
        Me.TBStuNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TBLname
        '
        Me.TBLname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TBLname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBLname.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBLname.ForeColor = System.Drawing.Color.White
        Me.TBLname.HintForeColor = System.Drawing.Color.Khaki
        Me.TBLname.HintText = "Lastname"
        Me.TBLname.isPassword = False
        Me.TBLname.LineFocusedColor = System.Drawing.Color.Yellow
        Me.TBLname.LineIdleColor = System.Drawing.Color.Gray
        Me.TBLname.LineMouseHoverColor = System.Drawing.Color.Yellow
        Me.TBLname.LineThickness = 5
        Me.TBLname.Location = New System.Drawing.Point(28, 101)
        Me.TBLname.Margin = New System.Windows.Forms.Padding(5)
        Me.TBLname.Name = "TBLname"
        Me.TBLname.Size = New System.Drawing.Size(220, 36)
        Me.TBLname.TabIndex = 9
        Me.TBLname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TBFname
        '
        Me.TBFname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TBFname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBFname.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBFname.ForeColor = System.Drawing.Color.White
        Me.TBFname.HintForeColor = System.Drawing.Color.Khaki
        Me.TBFname.HintText = "First Name"
        Me.TBFname.isPassword = False
        Me.TBFname.LineFocusedColor = System.Drawing.Color.Yellow
        Me.TBFname.LineIdleColor = System.Drawing.Color.Gray
        Me.TBFname.LineMouseHoverColor = System.Drawing.Color.Yellow
        Me.TBFname.LineThickness = 5
        Me.TBFname.Location = New System.Drawing.Point(28, 52)
        Me.TBFname.Margin = New System.Windows.Forms.Padding(5)
        Me.TBFname.Name = "TBFname"
        Me.TBFname.Size = New System.Drawing.Size(220, 36)
        Me.TBFname.TabIndex = 8
        Me.TBFname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Section_Label"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BunifuThinButton22)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Khaki
        Me.GroupBox2.Location = New System.Drawing.Point(324, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(271, 272)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "QR Code"
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.Yellow
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.Black
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Save QR Code"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.Black
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.Honeydew
        Me.BunifuThinButton22.Location = New System.Drawing.Point(78, 231)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(116, 34)
        Me.BunifuThinButton22.TabIndex = 12
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(35, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'SaveFileDialog1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(498, 311)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Section_Label"
        Me.Label2.Visible = False
        '
        'Name1
        '
        Me.Name1.AutoSize = True
        Me.Name1.BackColor = System.Drawing.Color.Transparent
        Me.Name1.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name1.ForeColor = System.Drawing.Color.White
        Me.Name1.Location = New System.Drawing.Point(387, 311)
        Me.Name1.Name = "Name1"
        Me.Name1.Size = New System.Drawing.Size(105, 18)
        Me.Name1.TabIndex = 14
        Me.Name1.Text = "Section_Label"
        Me.Name1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(178, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Section_ID"
        Me.Label3.Visible = False
        '
        'CreateQRvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(297, 333)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Name1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CreateQRvb"
        Me.Text = "CreateQRvb"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TBStuNum As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TBLname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TBFname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Name1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Label3 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
