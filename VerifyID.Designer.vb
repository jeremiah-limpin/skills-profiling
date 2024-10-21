<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerifyIDForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerifyIDForm))
        txtVerifyID = New TextBox()
        btnVerifyID = New Button()
        PictureBox5 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox2 = New PictureBox()
        lblTip = New Label()
        lblLogin = New Label()
        picboxLoginBack = New PictureBox()
        PictureBox3 = New PictureBox()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(picboxLoginBack, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtVerifyID
        ' 
        txtVerifyID.BorderStyle = BorderStyle.FixedSingle
        txtVerifyID.Font = New Drawing.Font("Gotham", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtVerifyID.ForeColor = Color.DarkGray
        txtVerifyID.Location = New Point(132, 185)
        txtVerifyID.Name = "txtVerifyID"
        txtVerifyID.Size = New Size(156, 27)
        txtVerifyID.TabIndex = 1
        txtVerifyID.Text = "Employee ID"
        ' 
        ' btnVerifyID
        ' 
        btnVerifyID.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        btnVerifyID.Font = New Drawing.Font("Gotham", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVerifyID.ForeColor = Color.Transparent
        btnVerifyID.Location = New Point(160, 240)
        btnVerifyID.Name = "btnVerifyID"
        btnVerifyID.Size = New Size(107, 64)
        btnVerifyID.TabIndex = 1
        btnVerifyID.Text = "Verify"
        btnVerifyID.UseVisualStyleBackColor = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox5.Dock = DockStyle.Top
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Drawing.Image)
        PictureBox5.Location = New Point(0, 0)
        PictureBox5.Margin = New Padding(23, 67, 23, 27)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(416, 124)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 20
        PictureBox5.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), Drawing.Image)
        PictureBox7.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox7.Location = New Point(-121, 216)
        PictureBox7.Margin = New Padding(3, 4, 3, 4)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(240, 282)
        PictureBox7.TabIndex = 23
        PictureBox7.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Drawing.Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(0, 185)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(87, 59)
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Drawing.Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox6.Location = New Point(74, 147)
        PictureBox6.Margin = New Padding(3, 4, 3, 4)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(29, 30)
        PictureBox6.TabIndex = 25
        PictureBox6.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Drawing.Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(277, -1)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(150, 305)
        PictureBox2.TabIndex = 26
        PictureBox2.TabStop = False
        ' 
        ' lblTip
        ' 
        lblTip.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblTip.AutoSize = True
        lblTip.BackColor = Color.Transparent
        lblTip.Font = New Drawing.Font("Gotham", 7.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTip.ForeColor = SystemColors.ActiveCaptionText
        lblTip.Location = New Point(144, 220)
        lblTip.Margin = New Padding(5)
        lblTip.Name = "lblTip"
        lblTip.Size = New Size(107, 12)
        lblTip.TabIndex = 27
        lblTip.Text = "ID Format: TBR-XXX"
        lblTip.Visible = False
        ' 
        ' lblLogin
        ' 
        lblLogin.AutoSize = True
        lblLogin.Font = New Drawing.Font("Gotham", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(77))
        lblLogin.Location = New Point(32, 9)
        lblLogin.Name = "lblLogin"
        lblLogin.Size = New Size(39, 12)
        lblLogin.TabIndex = 28
        lblLogin.Text = "Login"
        ' 
        ' picboxLoginBack
        ' 
        picboxLoginBack.BackgroundImage = CType(resources.GetObject("picboxLoginBack.BackgroundImage"), Drawing.Image)
        picboxLoginBack.BackgroundImageLayout = ImageLayout.Zoom
        picboxLoginBack.Location = New Point(0, 0)
        picboxLoginBack.Margin = New Padding(3, 4, 3, 4)
        picboxLoginBack.Name = "picboxLoginBack"
        picboxLoginBack.Size = New Size(37, 33)
        picboxLoginBack.TabIndex = 29
        picboxLoginBack.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Drawing.Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(164, 121)
        PictureBox3.Margin = New Padding(3, 4, 3, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(94, 56)
        PictureBox3.TabIndex = 30
        PictureBox3.TabStop = False
        ' 
        ' VerifyIDForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 13.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(416, 350)
        Controls.Add(lblLogin)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox7)
        Controls.Add(btnVerifyID)
        Controls.Add(txtVerifyID)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox2)
        Controls.Add(picboxLoginBack)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox3)
        Controls.Add(lblTip)
        Font = New Drawing.Font("Gotham", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(77))
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "VerifyIDForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Verify ID"
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(picboxLoginBack, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtVerifyID As TextBox
    Friend WithEvents btnVerifyID As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblTip As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents picboxLoginBack As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
