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
        Panel4 = New Panel()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(picboxNPHide, ComponentModel.ISupportInitialize).BeginInit()
        CType(picboxNPShow, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(picboxCPHide, ComponentModel.ISupportInitialize).BeginInit()
        CType(picboxCPShow, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Gotham", 9F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(61, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 13)
        Label1.TabIndex = 3
        Label1.Text = "Old Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Gotham", 9F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(61, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 13)
        Label2.TabIndex = 4
        Label2.Text = "New Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Gotham", 9F)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(61, 181)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 13)
        Label3.TabIndex = 5
        Label3.Text = "Confirm Password"
        ' 
        ' btnSavePassword
        ' 
        btnSavePassword.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        btnSavePassword.FlatStyle = FlatStyle.Popup
        btnSavePassword.Font = New System.Drawing.Font("Gotham", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(161))
        btnSavePassword.ForeColor = Color.White
        btnSavePassword.Location = New Point(153, 251)
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
        Panel2.Location = New Point(61, 85)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(280, 35)
        Panel2.TabIndex = 12
        ' 
        ' txtOldPassword
        ' 
        txtOldPassword.BorderStyle = BorderStyle.FixedSingle
        txtOldPassword.Font = New System.Drawing.Font("Gotham", 12F)
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
        Panel1.Location = New Point(61, 141)
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
        txtNewPassword.Font = New System.Drawing.Font("Gotham", 12F)
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
        Panel3.Location = New Point(61, 201)
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
        txtConfirmPassword.Font = New System.Drawing.Font("Gotham", 12F)
        txtConfirmPassword.Location = New Point(2, 6)
        txtConfirmPassword.Margin = New Padding(3, 2, 3, 2)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(275, 24)
        txtConfirmPassword.TabIndex = 1
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(53), CByte(37), CByte(107))
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(PictureBox1)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(405, 53)
        Panel4.TabIndex = 42
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New System.Drawing.Font("Gotham", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, CByte(161))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(67, 14)
        Label4.Margin = New Padding(0)
        Label4.Name = "Label4"
        Label4.Size = New Size(259, 31)
        Label4.TabIndex = 47
        Label4.Text = "Change Password"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Drawing.Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Location = New Point(9, 9)
        PictureBox1.Margin = New Padding(70, 30, 30, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Padding = New Padding(30, 0, 0, 0)
        PictureBox1.Size = New Size(57, 38)
        PictureBox1.TabIndex = 48
        PictureBox1.TabStop = False
        ' 
        ' ChangePasswordForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(405, 307)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(btnSavePassword)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
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
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
