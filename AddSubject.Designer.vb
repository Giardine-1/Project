<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddSubject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddSubject))
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BunifuDropdown3 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuDropdown2 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuDropdown1 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Desc = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Section1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Code1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Nami = New System.Windows.Forms.Label()
        Me.StringP = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Goldenrod
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.AntiqueWhite
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.YellowGreen
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Yellow
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 1)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(609, 29)
        Me.BunifuGradientPanel1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(537, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BunifuDropdown3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.BunifuDropdown2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BunifuDropdown1)
        Me.GroupBox1.Controls.Add(Me.BunifuThinButton21)
        Me.GroupBox1.Controls.Add(Me.Desc)
        Me.GroupBox1.Controls.Add(Me.Section1)
        Me.GroupBox1.Controls.Add(Me.Code1)
        Me.GroupBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Khaki
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(551, 286)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add a New Subject"
        '
        'BunifuDropdown3
        '
        Me.BunifuDropdown3.AutoScroll = True
        Me.BunifuDropdown3.AutoScrollMinSize = New System.Drawing.Size(0, 5)
        Me.BunifuDropdown3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuDropdown3.BorderRadius = 10
        Me.BunifuDropdown3.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.BunifuDropdown3.ForeColor = System.Drawing.Color.Black
        Me.BunifuDropdown3.Items = New String() {"07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "Select End Time"}
        Me.BunifuDropdown3.Location = New System.Drawing.Point(316, 192)
        Me.BunifuDropdown3.Margin = New System.Windows.Forms.Padding(20, 6, 7, 6)
        Me.BunifuDropdown3.Name = "BunifuDropdown3"
        Me.BunifuDropdown3.NomalColor = System.Drawing.Color.DimGray
        Me.BunifuDropdown3.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuDropdown3.selectedIndex = 29
        Me.BunifuDropdown3.Size = New System.Drawing.Size(208, 35)
        Me.BunifuDropdown3.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(313, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "End Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(312, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Start Time"
        '
        'BunifuDropdown2
        '
        Me.BunifuDropdown2.AutoScroll = True
        Me.BunifuDropdown2.AutoScrollMinSize = New System.Drawing.Size(0, 5)
        Me.BunifuDropdown2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown2.BorderRadius = 3
        Me.BunifuDropdown2.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.BunifuDropdown2.ForeColor = System.Drawing.Color.Black
        Me.BunifuDropdown2.Items = New String() {"07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "Select Start Time"}
        Me.BunifuDropdown2.Location = New System.Drawing.Point(316, 125)
        Me.BunifuDropdown2.Margin = New System.Windows.Forms.Padding(20, 6, 7, 6)
        Me.BunifuDropdown2.Name = "BunifuDropdown2"
        Me.BunifuDropdown2.NomalColor = System.Drawing.Color.DimGray
        Me.BunifuDropdown2.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuDropdown2.selectedIndex = 29
        Me.BunifuDropdown2.Size = New System.Drawing.Size(208, 35)
        Me.BunifuDropdown2.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(312, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Day"
        '
        'BunifuDropdown1
        '
        Me.BunifuDropdown1.AutoScroll = True
        Me.BunifuDropdown1.AutoScrollMinSize = New System.Drawing.Size(0, 5)
        Me.BunifuDropdown1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown1.BorderRadius = 3
        Me.BunifuDropdown1.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.BunifuDropdown1.ForeColor = System.Drawing.Color.Black
        Me.BunifuDropdown1.Items = New String() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Select Day"}
        Me.BunifuDropdown1.Location = New System.Drawing.Point(316, 56)
        Me.BunifuDropdown1.Margin = New System.Windows.Forms.Padding(20, 6, 7, 6)
        Me.BunifuDropdown1.Name = "BunifuDropdown1"
        Me.BunifuDropdown1.NomalColor = System.Drawing.Color.DimGray
        Me.BunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuDropdown1.selectedIndex = 6
        Me.BunifuDropdown1.Size = New System.Drawing.Size(208, 35)
        Me.BunifuDropdown1.TabIndex = 12
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
        Me.BunifuThinButton21.ButtonText = "Add Subject"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.Black
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.Honeydew
        Me.BunifuThinButton21.Location = New System.Drawing.Point(189, 235)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(181, 41)
        Me.BunifuThinButton21.TabIndex = 11
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Desc
        '
        Me.Desc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Desc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Desc.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desc.ForeColor = System.Drawing.Color.White
        Me.Desc.HintForeColor = System.Drawing.Color.Khaki
        Me.Desc.HintText = "Subject Description"
        Me.Desc.isPassword = False
        Me.Desc.LineFocusedColor = System.Drawing.Color.Yellow
        Me.Desc.LineIdleColor = System.Drawing.Color.Gray
        Me.Desc.LineMouseHoverColor = System.Drawing.Color.Yellow
        Me.Desc.LineThickness = 5
        Me.Desc.Location = New System.Drawing.Point(28, 150)
        Me.Desc.Margin = New System.Windows.Forms.Padding(5)
        Me.Desc.Name = "Desc"
        Me.Desc.Size = New System.Drawing.Size(220, 36)
        Me.Desc.TabIndex = 10
        Me.Desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Section1
        '
        Me.Section1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Section1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Section1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Section1.ForeColor = System.Drawing.Color.White
        Me.Section1.HintForeColor = System.Drawing.Color.Khaki
        Me.Section1.HintText = "Enter Section"
        Me.Section1.isPassword = False
        Me.Section1.LineFocusedColor = System.Drawing.Color.Yellow
        Me.Section1.LineIdleColor = System.Drawing.Color.Gray
        Me.Section1.LineMouseHoverColor = System.Drawing.Color.Yellow
        Me.Section1.LineThickness = 5
        Me.Section1.Location = New System.Drawing.Point(28, 101)
        Me.Section1.Margin = New System.Windows.Forms.Padding(5)
        Me.Section1.Name = "Section1"
        Me.Section1.Size = New System.Drawing.Size(220, 36)
        Me.Section1.TabIndex = 9
        Me.Section1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Code1
        '
        Me.Code1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Code1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Code1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Code1.ForeColor = System.Drawing.Color.White
        Me.Code1.HintForeColor = System.Drawing.Color.Khaki
        Me.Code1.HintText = "Subject Code"
        Me.Code1.isPassword = False
        Me.Code1.LineFocusedColor = System.Drawing.Color.Yellow
        Me.Code1.LineIdleColor = System.Drawing.Color.Gray
        Me.Code1.LineMouseHoverColor = System.Drawing.Color.Yellow
        Me.Code1.LineThickness = 5
        Me.Code1.Location = New System.Drawing.Point(28, 52)
        Me.Code1.Margin = New System.Windows.Forms.Padding(5)
        Me.Code1.Name = "Code1"
        Me.Code1.Size = New System.Drawing.Size(220, 36)
        Me.Code1.TabIndex = 8
        Me.Code1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Nami
        '
        Me.Nami.AutoSize = True
        Me.Nami.Location = New System.Drawing.Point(570, 259)
        Me.Nami.Name = "Nami"
        Me.Nami.Size = New System.Drawing.Size(39, 13)
        Me.Nami.TabIndex = 11
        Me.Nami.Text = "Label1"
        '
        'StringP
        '
        Me.StringP.AutoSize = True
        Me.StringP.Location = New System.Drawing.Point(569, 276)
        Me.StringP.Name = "StringP"
        Me.StringP.Size = New System.Drawing.Size(39, 13)
        Me.StringP.TabIndex = 12
        Me.StringP.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(570, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(570, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(570, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Label3"
        '
        'AddSubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(570, 334)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StringP)
        Me.Controls.Add(Me.Nami)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddSubject"
        Me.Text = "AddSubject"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Desc As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Section1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Code1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Nami As Label
    Friend WithEvents StringP As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuDropdown1 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuDropdown2 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuDropdown3 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label6 As Label
End Class
