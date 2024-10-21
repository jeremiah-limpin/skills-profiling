<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPasswordForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPasswordForm))
        PictureBox1 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        Panel3 = New Panel()
        picboxCPHide = New PictureBox()
        picboxCPShow = New PictureBox()
        txtConfirmPassword = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        btnVerifyID = New Button()
        Panel1 = New Panel()
        picboxNPHide = New PictureBox()
        picboxNPShow = New PictureBox()
        txtNewPassword = New TextBox()
        lblLogin = New Label()
        picboxLoginBack = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(picboxCPHide, ComponentModel.ISupportInitialize).BeginInit()
        CType(picboxCPShow, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(picboxNPHide, ComponentModel.ISupportInitialize).BeginInit()
        CType(picboxNPShow, ComponentModel.ISupportInitialize).BeginInit()
        CType(picboxLoginBack, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Drawing.Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(0, 139)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(76, 44)
        PictureBox1.TabIndex = 27
        PictureBox1.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), Drawing.Image)
        PictureBox7.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox7.Location = New Point(-106, 162)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(210, 212)
        PictureBox7.TabIndex = 26
        PictureBox7.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Drawing.Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox6.Location = New Point(65, 110)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(25, 22)
        PictureBox6.TabIndex = 28
        PictureBox6.TabStop = False
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
        PictureBox5.Size = New Size(364, 93)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 30
        PictureBox5.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(picboxCPHide)
        Panel3.Controls.Add(picboxCPShow)
        Panel3.Controls.Add(txtConfirmPassword)
        Panel3.Location = New Point(45, 162)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(283, 31)
        Panel3.TabIndex = 34
        ' 
        ' picboxCPHide
        ' 
        picboxCPHide.BackColor = Color.White
        picboxCPHide.BackgroundImage = CType(resources.GetObject("picboxCPHide.BackgroundImage"), Drawing.Image)
        picboxCPHide.BackgroundImageLayout = ImageLayout.Zoom
        picboxCPHide.Location = New Point(244, 7)
        picboxCPHide.Margin = New Padding(3, 2, 3, 2)
        picboxCPHide.Name = "picboxCPHide"
        picboxCPHide.Size = New Size(31, 18)
        picboxCPHide.TabIndex = 16
        picboxCPHide.TabStop = False
        picboxCPHide.Visible = False
        ' 
        ' picboxCPShow
        ' 
        picboxCPShow.BackColor = Color.White
        picboxCPShow.BackgroundImage = CType(resources.GetObject("picboxCPShow.BackgroundImage"), Drawing.Image)
        picboxCPShow.BackgroundImageLayout = ImageLayout.Zoom
        picboxCPShow.Location = New Point(244, 7)
        picboxCPShow.Margin = New Padding(3, 2, 3, 2)
        picboxCPShow.Name = "picboxCPShow"
        picboxCPShow.Size = New Size(31, 18)
        picboxCPShow.TabIndex = 10
        picboxCPShow.TabStop = False
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle
        txtConfirmPassword.Location = New Point(3, 4)
        txtConfirmPassword.Margin = New Padding(3, 2, 3, 2)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(275, 23)
        txtConfirmPassword.TabIndex = 2
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Drawing.Font("Gotham", 8.999999F)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(45, 145)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 13)
        Label3.TabIndex = 32
        Label3.Text = "Confirm Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Drawing.Font("Gotham", 8.999999F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(45, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 13)
        Label2.TabIndex = 31
        Label2.Text = "New Password"
        ' 
        ' btnVerifyID
        ' 
        btnVerifyID.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        btnVerifyID.Font = New Drawing.Font("Gotham", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVerifyID.ForeColor = Color.Transparent
        btnVerifyID.Location = New Point(135, 197)
        btnVerifyID.Margin = New Padding(3, 2, 3, 2)
        btnVerifyID.Name = "btnVerifyID"
        btnVerifyID.Size = New Size(94, 48)
        btnVerifyID.TabIndex = 3
        btnVerifyID.Text = "Save"
        btnVerifyID.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(picboxNPHide)
        Panel1.Controls.Add(picboxNPShow)
        Panel1.Controls.Add(txtNewPassword)
        Panel1.Location = New Point(45, 110)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(283, 33)
        Panel1.TabIndex = 36
        ' 
        ' picboxNPHide
        ' 
        picboxNPHide.BackColor = Color.White
        picboxNPHide.BackgroundImage = CType(resources.GetObject("picboxNPHide.BackgroundImage"), Drawing.Image)
        picboxNPHide.BackgroundImageLayout = ImageLayout.Zoom
        picboxNPHide.Location = New Point(244, 8)
        picboxNPHide.Margin = New Padding(3, 2, 3, 2)
        picboxNPHide.Name = "picboxNPHide"
        picboxNPHide.Size = New Size(31, 18)
        picboxNPHide.TabIndex = 15
        picboxNPHide.TabStop = False
        picboxNPHide.Visible = False
        ' 
        ' picboxNPShow
        ' 
        picboxNPShow.BackColor = Color.White
        picboxNPShow.BackgroundImage = CType(resources.GetObject("picboxNPShow.BackgroundImage"), Drawing.Image)
        picboxNPShow.BackgroundImageLayout = ImageLayout.Zoom
        picboxNPShow.Location = New Point(244, 8)
        picboxNPShow.Margin = New Padding(3, 2, 3, 2)
        picboxNPShow.Name = "picboxNPShow"
        picboxNPShow.Size = New Size(31, 18)
        picboxNPShow.TabIndex = 10
        picboxNPShow.TabStop = False
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.BorderStyle = BorderStyle.FixedSingle
        txtNewPassword.Location = New Point(6, 5)
        txtNewPassword.Margin = New Padding(3, 2, 3, 2)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.Size = New Size(272, 23)
        txtNewPassword.TabIndex = 1
        txtNewPassword.UseSystemPasswordChar = True
        ' 
        ' lblLogin
        ' 
        lblLogin.AutoSize = True
        lblLogin.Font = New Drawing.Font("Gotham", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(77))
        lblLogin.Location = New Point(29, 7)
        lblLogin.Name = "lblLogin"
        lblLogin.Size = New Size(39, 12)
        lblLogin.TabIndex = 37
        lblLogin.Text = "Login"
        ' 
        ' picboxLoginBack
        ' 
        picboxLoginBack.BackgroundImage = CType(resources.GetObject("picboxLoginBack.BackgroundImage"), Drawing.Image)
        picboxLoginBack.BackgroundImageLayout = ImageLayout.Zoom
        picboxLoginBack.Location = New Point(1, 0)
        picboxLoginBack.Name = "picboxLoginBack"
        picboxLoginBack.Size = New Size(32, 25)
        picboxLoginBack.TabIndex = 38
        picboxLoginBack.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Drawing.Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(242, -1)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(131, 229)
        PictureBox2.TabIndex = 29
        PictureBox2.TabStop = False
        ' 
        ' ForgotPasswordForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(364, 262)
        Controls.Add(lblLogin)
        Controls.Add(picboxLoginBack)
        Controls.Add(Panel1)
        Controls.Add(btnVerifyID)
        Controls.Add(Panel3)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox7)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "ForgotPasswordForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Forgot Password"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(picboxCPHide, ComponentModel.ISupportInitialize).EndInit()
        CType(picboxCPShow, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(picboxNPHide, ComponentModel.ISupportInitialize).EndInit()
        CType(picboxNPShow, ComponentModel.ISupportInitialize).EndInit()
        CType(picboxLoginBack, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents picboxCPHide As PictureBox
    Friend WithEvents picboxCPShow As PictureBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnVerifyID As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picboxNPHide As PictureBox
    Friend WithEvents picboxNPShow As PictureBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents picboxLoginBack As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
