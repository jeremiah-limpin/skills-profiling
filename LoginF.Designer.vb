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
        Label3 = New Label()
        txtEmployeeID = New TextBox()
        lklblForgotPassword = New LinkLabel()
        btnLogin = New Button()
        lblTip = New Label()
        txtPassword = New TextBox()
        Panel1 = New Panel()
        PictureBox4 = New PictureBox()
        Panel6 = New Panel()
        Panel8 = New Panel()
        lblPasswordTip = New Label()
        PictureBox1 = New PictureBox()
        Panel7 = New Panel()
        PictureBox7 = New PictureBox()
        PictureBox6 = New PictureBox()
        Panel5 = New Panel()
        Panel4 = New Panel()
        Panel3 = New Panel()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        PictureBox3 = New PictureBox()
        picboxLoginPShow = New PictureBox()
        picboxLoginPHide = New PictureBox()
        PictureBox5 = New PictureBox()
        timerPassword = New Timer(components)
        Panel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        Panel8.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(picboxLoginPShow, ComponentModel.ISupportInitialize).BeginInit()
        CType(picboxLoginPHide, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Drawing.Font("Gotham", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(214, 12)
        Label3.Margin = New Padding(3)
        Label3.Name = "Label3"
        Label3.RightToLeft = RightToLeft.No
        Label3.Size = New Size(141, 40)
        Label3.TabIndex = 0
        Label3.Text = "Sign In"
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtEmployeeID.BorderStyle = BorderStyle.FixedSingle
        txtEmployeeID.Font = New Drawing.Font("Gotham", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmployeeID.ForeColor = Color.DarkGray
        txtEmployeeID.Location = New Point(52, 16)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(244, 24)
        txtEmployeeID.TabIndex = 0
        txtEmployeeID.Text = "Employee ID"
        ' 
        ' lklblForgotPassword
        ' 
        lklblForgotPassword.Anchor = AnchorStyles.None
        lklblForgotPassword.AutoSize = True
        lklblForgotPassword.BackColor = Color.Transparent
        lklblForgotPassword.Font = New Drawing.Font("Gotham", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lklblForgotPassword.LinkBehavior = LinkBehavior.NeverUnderline
        lklblForgotPassword.LinkColor = Color.Black
        lklblForgotPassword.Location = New Point(237, 221)
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
        btnLogin.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        btnLogin.BackgroundImageLayout = ImageLayout.None
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.Font = New Drawing.Font("Gotham", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(4, 6)
        btnLogin.Margin = New Padding(5)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(128, 41)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Sign in"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' lblTip
        ' 
        lblTip.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblTip.AutoSize = True
        lblTip.BackColor = Color.Transparent
        lblTip.Font = New Drawing.Font("Gotham", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTip.ForeColor = SystemColors.ActiveCaptionText
        lblTip.Location = New Point(5, 4)
        lblTip.Margin = New Padding(4)
        lblTip.Name = "lblTip"
        lblTip.Size = New Size(115, 12)
        lblTip.TabIndex = 7
        lblTip.Text = "ID Format: TBR-XXX"
        lblTip.Visible = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtPassword.BackColor = Color.White
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Drawing.Font("Gotham", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.ForeColor = Color.DarkGray
        txtPassword.Location = New Point(52, 15)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(244, 24)
        txtPassword.TabIndex = 0
        txtPassword.Text = "Password"
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(561, 389)
        Panel1.TabIndex = 14
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Drawing.Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox4.Location = New Point(445, -79)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(131, 460)
        PictureBox4.TabIndex = 40
        PictureBox4.TabStop = False
        ' 
        ' Panel6
        ' 
        Panel6.BackgroundImageLayout = ImageLayout.Zoom
        Panel6.Controls.Add(lklblForgotPassword)
        Panel6.Controls.Add(Panel8)
        Panel6.Controls.Add(PictureBox1)
        Panel6.Controls.Add(Panel7)
        Panel6.Controls.Add(PictureBox6)
        Panel6.Controls.Add(Panel5)
        Panel6.Controls.Add(Panel4)
        Panel6.Controls.Add(Panel3)
        Panel6.Controls.Add(Panel2)
        Panel6.Controls.Add(Label3)
        Panel6.Dock = DockStyle.Top
        Panel6.Font = New Drawing.Font("Gotham", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel6.ImeMode = ImeMode.NoControl
        Panel6.Location = New Point(0, 117)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(561, 273)
        Panel6.TabIndex = 0
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(lblPasswordTip)
        Panel8.Location = New Point(223, 153)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(128, 20)
        Panel8.TabIndex = 24
        ' 
        ' lblPasswordTip
        ' 
        lblPasswordTip.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblPasswordTip.AutoSize = True
        lblPasswordTip.BackColor = Color.Transparent
        lblPasswordTip.Font = New Drawing.Font("Gotham", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPasswordTip.ForeColor = SystemColors.ActiveCaptionText
        lblPasswordTip.Location = New Point(34, 4)
        lblPasswordTip.Margin = New Padding(4)
        lblPasswordTip.Name = "lblPasswordTip"
        lblPasswordTip.Size = New Size(55, 12)
        lblPasswordTip.TabIndex = 7
        lblPasswordTip.Text = "Password"
        lblPasswordTip.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Drawing.Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(10, 97)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(83, 63)
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(PictureBox7)
        Panel7.Location = New Point(0, 168)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(183, 117)
        Panel7.TabIndex = 23
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), Drawing.Image)
        PictureBox7.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox7.Location = New Point(-184, -41)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(361, 338)
        PictureBox7.TabIndex = 22
        PictureBox7.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Drawing.Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox6.Location = New Point(72, 48)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(32, 26)
        PictureBox6.TabIndex = 21
        PictureBox6.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(lblTip)
        Panel5.Location = New Point(223, 100)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(128, 20)
        Panel5.TabIndex = 17
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(btnLogin)
        Panel4.Location = New Point(219, 170)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(136, 70)
        Panel4.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(txtEmployeeID)
        Panel3.Location = New Point(121, 59)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(303, 48)
        Panel3.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Drawing.Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(3, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(45, 46)
        PictureBox2.TabIndex = 16
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(picboxLoginPShow)
        Panel2.Controls.Add(picboxLoginPHide)
        Panel2.Controls.Add(txtPassword)
        Panel2.Location = New Point(121, 112)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(303, 52)
        Panel2.TabIndex = 2
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Drawing.Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(3, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(45, 46)
        PictureBox3.TabIndex = 15
        PictureBox3.TabStop = False
        ' 
        ' picboxLoginPShow
        ' 
        picboxLoginPShow.BackgroundImage = CType(resources.GetObject("picboxLoginPShow.BackgroundImage"), Drawing.Image)
        picboxLoginPShow.BackgroundImageLayout = ImageLayout.Zoom
        picboxLoginPShow.Location = New Point(264, 16)
        picboxLoginPShow.Name = "picboxLoginPShow"
        picboxLoginPShow.Size = New Size(31, 22)
        picboxLoginPShow.TabIndex = 15
        picboxLoginPShow.TabStop = False
        ' 
        ' picboxLoginPHide
        ' 
        picboxLoginPHide.BackgroundImage = CType(resources.GetObject("picboxLoginPHide.BackgroundImage"), Drawing.Image)
        picboxLoginPHide.BackgroundImageLayout = ImageLayout.Zoom
        picboxLoginPHide.Location = New Point(264, 16)
        picboxLoginPHide.Name = "picboxLoginPHide"
        picboxLoginPHide.Size = New Size(31, 22)
        picboxLoginPHide.TabIndex = 16
        picboxLoginPHide.TabStop = False
        picboxLoginPHide.Visible = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox5.Dock = DockStyle.Top
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Drawing.Image)
        PictureBox5.Location = New Point(0, 0)
        PictureBox5.Margin = New Padding(20, 50, 20, 20)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(561, 117)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 19
        PictureBox5.TabStop = False
        ' 
        ' timerPassword
        ' 
        timerPassword.Interval = 500
        ' 
        ' LoginF
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Drawing.Image)
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(561, 389)
        Controls.Add(Panel1)
        DoubleBuffered = True
        ForeColor = SystemColors.ButtonHighlight
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginF"
        SizeGripStyle = SizeGripStyle.Show
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel1.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(picboxLoginPShow, ComponentModel.ISupportInitialize).EndInit()
        CType(picboxLoginPHide, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents lklblForgotPassword As LinkLabel
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblTip As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents picboxLoginPShow As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents picboxLoginPHide As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents passwordCharTimer As Timer
    Friend WithEvents timerPassword As Timer
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblPasswordTip As Label
    Friend WithEvents PictureBox4 As PictureBox
End Class
