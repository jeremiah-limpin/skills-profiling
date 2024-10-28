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
        PictureBox6 = New PictureBox()
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
        PictureBox1 = New PictureBox()
        Panel4 = New Panel()
        picboxMenu = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(picboxCPHide, ComponentModel.ISupportInitialize).BeginInit()
        CType(picboxCPShow, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(picboxNPHide, ComponentModel.ISupportInitialize).BeginInit()
        CType(picboxNPShow, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(picboxMenu, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        Label3.Font = New System.Drawing.Font("Gotham", 8.999999F)
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
        Label2.Font = New System.Drawing.Font("Gotham", 8.999999F)
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
        btnVerifyID.Font = New System.Drawing.Font("Gotham", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Drawing.Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(37, 33)
        PictureBox1.TabIndex = 43
        PictureBox1.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(53), CByte(37), CByte(107))
        Panel4.BackgroundImageLayout = ImageLayout.Zoom
        Panel4.Controls.Add(PictureBox1)
        Panel4.Controls.Add(picboxMenu)
        Panel4.Controls.Add(PictureBox2)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(364, 84)
        Panel4.TabIndex = 44
        ' 
        ' picboxMenu
        ' 
        picboxMenu.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        picboxMenu.BackColor = Color.Transparent
        picboxMenu.BackgroundImage = CType(resources.GetObject("picboxMenu.BackgroundImage"), Drawing.Image)
        picboxMenu.BackgroundImageLayout = ImageLayout.Zoom
        picboxMenu.Location = New Point(1695, 10)
        picboxMenu.Margin = New Padding(70, 30, 30, 30)
        picboxMenu.Name = "picboxMenu"
        picboxMenu.Padding = New Padding(30, 0, 0, 0)
        picboxMenu.Size = New Size(66, 38)
        picboxMenu.TabIndex = 34
        picboxMenu.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Drawing.Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(0, 5)
        PictureBox2.Margin = New Padding(70, 30, 30, 30)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Padding = New Padding(30, 0, 0, 0)
        PictureBox2.Size = New Size(364, 75)
        PictureBox2.TabIndex = 48
        PictureBox2.TabStop = False
        ' 
        ' ForgotPasswordForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(364, 262)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        Controls.Add(btnVerifyID)
        Controls.Add(Panel3)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox6)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "ForgotPasswordForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Forgot Password"
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(picboxCPHide, ComponentModel.ISupportInitialize).EndInit()
        CType(picboxCPShow, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(picboxNPHide, ComponentModel.ISupportInitialize).EndInit()
        CType(picboxNPShow, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        CType(picboxMenu, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox6 As PictureBox
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents picboxMenu As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
