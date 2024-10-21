<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePasswordForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePasswordForm))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnSavePassword = New Button()
        Panel2 = New Panel()
        txtOldPassword = New TextBox()
        Panel1 = New Panel()
        picboxNPHide = New PictureBox()
        picboxNPShow = New PictureBox()
        txtNewPassword = New TextBox()
        Panel3 = New Panel()
        picboxCPHide = New PictureBox()
        picboxCPShow = New PictureBox()
        txtConfirmPassword = New TextBox()
        PictureBox5 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox2 = New PictureBox()
        picboxDashboardBack = New PictureBox()
        lblLogin = New Label()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(picboxNPHide, ComponentModel.ISupportInitialize).BeginInit()
        CType(picboxNPShow, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(picboxCPHide, ComponentModel.ISupportInitialize).BeginInit()
        CType(picboxCPShow, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(picboxDashboardBack, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Drawing.Font("Gotham", 9.0F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(63, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 13)
        Label1.TabIndex = 3
        Label1.Text = "Old Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Drawing.Font("Gotham", 9.0F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(63, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 13)
        Label2.TabIndex = 4
        Label2.Text = "New Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Drawing.Font("Gotham", 9.0F)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(63, 203)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 13)
        Label3.TabIndex = 5
        Label3.Text = "Confirm Password"
        ' 
        ' btnSavePassword
        ' 
        btnSavePassword.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        btnSavePassword.FlatStyle = FlatStyle.Popup
        btnSavePassword.Font = New Drawing.Font("Gotham", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(161))
        btnSavePassword.ForeColor = Color.White
        btnSavePassword.Location = New Point(155, 273)
        btnSavePassword.Margin = New Padding(3, 2, 3, 2)
        btnSavePassword.Name = "btnSavePassword"
        btnSavePassword.Size = New Size(81, 38)
        btnSavePassword.TabIndex = 7
        btnSavePassword.Text = "Save"
        btnSavePassword.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(txtOldPassword)
        Panel2.Location = New Point(63, 107)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(280, 35)
        Panel2.TabIndex = 12
        ' 
        ' txtOldPassword
        ' 
        txtOldPassword.BorderStyle = BorderStyle.FixedSingle
        txtOldPassword.Font = New Drawing.Font("Gotham", 12.0F)
        txtOldPassword.Location = New Point(3, 6)
        txtOldPassword.Margin = New Padding(3, 2, 3, 2)
        txtOldPassword.Name = "txtOldPassword"
        txtOldPassword.Size = New Size(274, 24)
        txtOldPassword.TabIndex = 1
        txtOldPassword.UseSystemPasswordChar = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(picboxNPHide)
        Panel1.Controls.Add(picboxNPShow)
        Panel1.Controls.Add(txtNewPassword)
        Panel1.Location = New Point(63, 163)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(280, 36)
        Panel1.TabIndex = 14
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
        txtNewPassword.Font = New Drawing.Font("Gotham", 12.0F)
        txtNewPassword.Location = New Point(3, 6)
        txtNewPassword.Margin = New Padding(3, 2, 3, 2)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.Size = New Size(275, 24)
        txtNewPassword.TabIndex = 1
        txtNewPassword.UseSystemPasswordChar = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(picboxCPHide)
        Panel3.Controls.Add(picboxCPShow)
        Panel3.Controls.Add(txtConfirmPassword)
        Panel3.Location = New Point(63, 223)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(280, 35)
        Panel3.TabIndex = 15
        ' 
        ' picboxCPHide
        ' 
        picboxCPHide.BackColor = Color.White
        picboxCPHide.BackgroundImage = CType(resources.GetObject("picboxCPHide.BackgroundImage"), Drawing.Image)
        picboxCPHide.BackgroundImageLayout = ImageLayout.Zoom
        picboxCPHide.Location = New Point(244, 8)
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
        picboxCPShow.Location = New Point(244, 8)
        picboxCPShow.Margin = New Padding(3, 2, 3, 2)
        picboxCPShow.Name = "picboxCPShow"
        picboxCPShow.Size = New Size(31, 18)
        picboxCPShow.TabIndex = 10
        picboxCPShow.TabStop = False
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle
        txtConfirmPassword.Font = New Drawing.Font("Gotham", 12.0F)
        txtConfirmPassword.Location = New Point(2, 6)
        txtConfirmPassword.Margin = New Padding(3, 2, 3, 2)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(275, 24)
        txtConfirmPassword.TabIndex = 1
        txtConfirmPassword.UseSystemPasswordChar = True
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
        PictureBox5.Size = New Size(401, 95)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 31
        PictureBox5.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Drawing.Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(-2, 174)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(76, 44)
        PictureBox1.TabIndex = 33
        PictureBox1.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Drawing.Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox6.Location = New Point(63, 141)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(25, 22)
        PictureBox6.TabIndex = 34
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), Drawing.Image)
        PictureBox7.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox7.Location = New Point(-107, 204)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(210, 212)
        PictureBox7.TabIndex = 32
        PictureBox7.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Drawing.Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(287, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(131, 248)
        PictureBox2.TabIndex = 35
        PictureBox2.TabStop = False
        ' 
        ' picboxDashboardBack
        ' 
        picboxDashboardBack.BackgroundImage = CType(resources.GetObject("picboxDashboardBack.BackgroundImage"), Drawing.Image)
        picboxDashboardBack.BackgroundImageLayout = ImageLayout.Zoom
        picboxDashboardBack.Location = New Point(0, 0)
        picboxDashboardBack.Name = "picboxDashboardBack"
        picboxDashboardBack.Size = New Size(33, 26)
        picboxDashboardBack.TabIndex = 39
        picboxDashboardBack.TabStop = False
        ' 
        ' lblLogin
        ' 
        lblLogin.AutoSize = True
        lblLogin.Font = New Drawing.Font("Gotham", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(77))
        lblLogin.Location = New Point(31, 7)
        lblLogin.Name = "lblLogin"
        lblLogin.Size = New Size(70, 12)
        lblLogin.TabIndex = 40
        lblLogin.Text = "Dashboard"
        ' 
        ' ChangePasswordForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(401, 331)
        Controls.Add(lblLogin)
        Controls.Add(picboxDashboardBack)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(btnSavePassword)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox5)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "ChangePasswordForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Change Password"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(picboxNPHide, ComponentModel.ISupportInitialize).EndInit()
        CType(picboxNPShow, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(picboxCPHide, ComponentModel.ISupportInitialize).EndInit()
        CType(picboxCPShow, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(picboxDashboardBack, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSavePassword As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtOldPassword As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picboxNPHide As PictureBox
    Friend WithEvents picboxNPShow As PictureBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents picboxCPHide As PictureBox
    Friend WithEvents picboxCPShow As PictureBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents picboxDashboardBack As PictureBox
    Friend WithEvents lblLogin As Label
End Class
