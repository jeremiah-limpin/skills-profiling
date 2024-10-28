<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginF
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginF))
        txtEmployeeID = New TextBox()
        lklblForgotPassword = New LinkLabel()
        btnLogin = New Button()
        lblTip = New Label()
        txtPassword = New TextBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        picboxMenu = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel6 = New Panel()
        lblEPName = New Label()
        picboxLoginPHide = New PictureBox()
        picboxLoginPShow = New PictureBox()
        lblPasswordTip = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        timerPassword = New Timer(components)
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(picboxMenu, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(picboxLoginPHide, ComponentModel.ISupportInitialize).BeginInit()
        CType(picboxLoginPShow, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Anchor = AnchorStyles.None
        txtEmployeeID.BorderStyle = BorderStyle.FixedSingle
        txtEmployeeID.Font = New System.Drawing.Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmployeeID.ForeColor = Color.DarkGray
        txtEmployeeID.Location = New Point(119, 147)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(201, 24)
        txtEmployeeID.TabIndex = 0
        txtEmployeeID.Text = "Employee ID"
        ' 
        ' lklblForgotPassword
        ' 
        lklblForgotPassword.Anchor = AnchorStyles.None
        lklblForgotPassword.AutoSize = True
        lklblForgotPassword.BackColor = Color.Transparent
        lklblForgotPassword.Font = New System.Drawing.Font("Gotham", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lklblForgotPassword.LinkBehavior = LinkBehavior.NeverUnderline
        lklblForgotPassword.LinkColor = Color.Black
        lklblForgotPassword.Location = New Point(165, 290)
        lklblForgotPassword.Name = "lklblForgotPassword"
        lklblForgotPassword.Size = New Size(100, 12)
        lklblForgotPassword.TabIndex = 4
        lklblForgotPassword.TabStop = True
        lklblForgotPassword.Text = "Forgot Password?"
        lklblForgotPassword.VisitedLinkColor = Color.Black
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.None
        btnLogin.AutoSize = True
        btnLogin.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        btnLogin.BackgroundImageLayout = ImageLayout.None
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.Font = New System.Drawing.Font("Gotham", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(145, 244)
        btnLogin.Margin = New Padding(5)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(128, 41)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Sign in"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' lblTip
        ' 
        lblTip.Anchor = AnchorStyles.None
        lblTip.AutoSize = True
        lblTip.BackColor = Color.Transparent
        lblTip.Cursor = Cursors.Help
        lblTip.Font = New System.Drawing.Font("Gotham", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTip.ForeColor = SystemColors.ActiveCaptionText
        lblTip.Location = New Point(158, 178)
        lblTip.Margin = New Padding(4)
        lblTip.Name = "lblTip"
        lblTip.Size = New Size(115, 12)
        lblTip.TabIndex = 7
        lblTip.Text = "ID Format: TBR-XXX"
        lblTip.Visible = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.None
        txtPassword.BackColor = Color.White
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New System.Drawing.Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.ForeColor = Color.DarkGray
        txtPassword.Location = New Point(116, 198)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(208, 24)
        txtPassword.TabIndex = 0
        txtPassword.Text = "Password"
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel6)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(423, 341)
        Panel1.TabIndex = 14
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(53), CByte(37), CByte(107))
        Panel2.BackgroundImageLayout = ImageLayout.Zoom
        Panel2.Controls.Add(picboxMenu)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(423, 84)
        Panel2.TabIndex = 15
        ' 
        ' picboxMenu
        ' 
        picboxMenu.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        picboxMenu.BackColor = Color.Transparent
        picboxMenu.BackgroundImage = CType(resources.GetObject("picboxMenu.BackgroundImage"), Drawing.Image)
        picboxMenu.BackgroundImageLayout = ImageLayout.Zoom
        picboxMenu.Location = New Point(1114, 10)
        picboxMenu.Margin = New Padding(70, 30, 30, 30)
        picboxMenu.Name = "picboxMenu"
        picboxMenu.Padding = New Padding(30, 0, 0, 0)
        picboxMenu.Size = New Size(66, 38)
        picboxMenu.TabIndex = 34
        picboxMenu.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Drawing.Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(10, 5)
        PictureBox1.Margin = New Padding(70, 30, 30, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Padding = New Padding(30, 0, 0, 0)
        PictureBox1.Size = New Size(401, 75)
        PictureBox1.TabIndex = 48
        PictureBox1.TabStop = False
        ' 
        ' Panel6
        ' 
        Panel6.BackgroundImageLayout = ImageLayout.Zoom
        Panel6.Controls.Add(lblEPName)
        Panel6.Controls.Add(picboxLoginPHide)
        Panel6.Controls.Add(picboxLoginPShow)
        Panel6.Controls.Add(lblPasswordTip)
        Panel6.Controls.Add(lklblForgotPassword)
        Panel6.Controls.Add(lblTip)
        Panel6.Controls.Add(btnLogin)
        Panel6.Controls.Add(PictureBox2)
        Panel6.Controls.Add(txtEmployeeID)
        Panel6.Controls.Add(PictureBox3)
        Panel6.Controls.Add(txtPassword)
        Panel6.Dock = DockStyle.Fill
        Panel6.Font = New System.Drawing.Font("Gotham", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel6.ImeMode = ImeMode.NoControl
        Panel6.Location = New Point(0, 0)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(423, 341)
        Panel6.TabIndex = 0
        ' 
        ' lblEPName
        ' 
        lblEPName.Anchor = AnchorStyles.None
        lblEPName.AutoSize = True
        lblEPName.BackColor = Color.Transparent
        lblEPName.Font = New System.Drawing.Font("Gotham", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(161))
        lblEPName.ForeColor = Color.Black
        lblEPName.Location = New Point(135, 93)
        lblEPName.Margin = New Padding(0)
        lblEPName.Name = "lblEPName"
        lblEPName.Size = New Size(147, 42)
        lblEPName.TabIndex = 47
        lblEPName.Text = "Sign In"
        ' 
        ' picboxLoginPHide
        ' 
        picboxLoginPHide.Anchor = AnchorStyles.None
        picboxLoginPHide.BackgroundImage = CType(resources.GetObject("picboxLoginPHide.BackgroundImage"), Drawing.Image)
        picboxLoginPHide.BackgroundImageLayout = ImageLayout.Zoom
        picboxLoginPHide.Location = New Point(292, 199)
        picboxLoginPHide.Name = "picboxLoginPHide"
        picboxLoginPHide.Size = New Size(31, 22)
        picboxLoginPHide.TabIndex = 16
        picboxLoginPHide.TabStop = False
        picboxLoginPHide.Visible = False
        ' 
        ' picboxLoginPShow
        ' 
        picboxLoginPShow.Anchor = AnchorStyles.None
        picboxLoginPShow.BackgroundImage = CType(resources.GetObject("picboxLoginPShow.BackgroundImage"), Drawing.Image)
        picboxLoginPShow.BackgroundImageLayout = ImageLayout.Zoom
        picboxLoginPShow.Location = New Point(292, 199)
        picboxLoginPShow.Name = "picboxLoginPShow"
        picboxLoginPShow.Size = New Size(31, 22)
        picboxLoginPShow.TabIndex = 15
        picboxLoginPShow.TabStop = False
        ' 
        ' lblPasswordTip
        ' 
        lblPasswordTip.Anchor = AnchorStyles.None
        lblPasswordTip.AutoSize = True
        lblPasswordTip.BackColor = Color.Transparent
        lblPasswordTip.Cursor = Cursors.Help
        lblPasswordTip.Font = New System.Drawing.Font("Gotham", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPasswordTip.ForeColor = SystemColors.ActiveCaptionText
        lblPasswordTip.Location = New Point(183, 229)
        lblPasswordTip.Margin = New Padding(4)
        lblPasswordTip.Name = "lblPasswordTip"
        lblPasswordTip.Size = New Size(55, 12)
        lblPasswordTip.TabIndex = 7
        lblPasswordTip.Text = "Password"
        lblPasswordTip.Visible = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Drawing.Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(67, 134)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(45, 46)
        PictureBox2.TabIndex = 16
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Drawing.Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(67, 186)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(45, 46)
        PictureBox3.TabIndex = 15
        PictureBox3.TabStop = False
        ' 
        ' timerPassword
        ' 
        timerPassword.Interval = 500
        ' 
        ' LoginF
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(423, 341)
        Controls.Add(Panel1)
        DoubleBuffered = True
        ForeColor = SystemColors.ButtonHighlight
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        MinimumSize = New Size(439, 356)
        Name = "LoginF"
        SizeGripStyle = SizeGripStyle.Show
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(picboxMenu, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(picboxLoginPHide, ComponentModel.ISupportInitialize).EndInit()
        CType(picboxLoginPShow, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents lklblForgotPassword As LinkLabel
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblTip As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents picboxLoginPShow As PictureBox
    Friend WithEvents picboxLoginPHide As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents passwordCharTimer As Timer
    Friend WithEvents timerPassword As Timer
    Friend WithEvents lblPasswordTip As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblEPName As Label
    Friend WithEvents picboxMenu As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
