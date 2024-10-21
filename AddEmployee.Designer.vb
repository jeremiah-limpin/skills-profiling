<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddEmployee))
        txtLastName = New TextBox()
        txtFirstName = New TextBox()
        txtEmployeeID = New TextBox()
        btnAdd = New Button()
        lblEmployeeID = New Label()
        lblLastName = New Label()
        lblFirstName = New Label()
        btnCancelAdd = New Button()
        lblTooltip = New Label()
        chkbxSaveInfo = New CheckBox()
        txtSharepoint = New TextBox()
        lblSharepoint = New Label()
        lnklblSharepoint = New LinkLabel()
        Panel1 = New Panel()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtLastName
        ' 
        txtLastName.Font = New Drawing.Font("Gotham", 9.0F)
        txtLastName.Location = New Point(279, 38)
        txtLastName.Margin = New Padding(3, 2, 3, 2)
        txtLastName.Name = "txtLastName"
        txtLastName.PlaceholderText = "Enter Employee's Last Name"
        txtLastName.Size = New Size(206, 20)
        txtLastName.TabIndex = 4
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Drawing.Font("Gotham", 9.0F)
        txtFirstName.Location = New Point(29, 38)
        txtFirstName.Margin = New Padding(3, 2, 3, 2)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.PlaceholderText = "Enter Employee's First Name"
        txtFirstName.Size = New Size(206, 20)
        txtFirstName.TabIndex = 3
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Font = New Drawing.Font("Gotham", 9.0F)
        txtEmployeeID.Location = New Point(29, 88)
        txtEmployeeID.Margin = New Padding(3, 2, 3, 2)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.PlaceholderText = "Enter Employee's ID Number ONLY"
        txtEmployeeID.Size = New Size(206, 20)
        txtEmployeeID.TabIndex = 0
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnAdd.Enabled = False
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Drawing.Font("Gotham", 11.999999F, FontStyle.Bold)
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(51, 175)
        btnAdd.Margin = New Padding(3, 2, 3, 2)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(206, 46)
        btnAdd.TabIndex = 5
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' lblEmployeeID
        ' 
        lblEmployeeID.AutoSize = True
        lblEmployeeID.Font = New Drawing.Font("Gotham", 12.0F)
        lblEmployeeID.Location = New Point(29, 69)
        lblEmployeeID.Name = "lblEmployeeID"
        lblEmployeeID.Size = New Size(109, 18)
        lblEmployeeID.TabIndex = 6
        lblEmployeeID.Text = "Employee ID"
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Font = New Drawing.Font("Gotham", 12.0F)
        lblLastName.Location = New Point(279, 15)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(92, 18)
        lblLastName.TabIndex = 9
        lblLastName.Text = "Last Name"
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New Drawing.Font("Gotham", 12.0F)
        lblFirstName.Location = New Point(29, 15)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(94, 18)
        lblFirstName.TabIndex = 8
        lblFirstName.Text = "First Name"
        ' 
        ' btnCancelAdd
        ' 
        btnCancelAdd.BackColor = Color.FromArgb(CByte(221), CByte(60), CByte(39))
        btnCancelAdd.FlatAppearance.BorderSize = 0
        btnCancelAdd.FlatStyle = FlatStyle.Flat
        btnCancelAdd.Font = New Drawing.Font("Gotham", 11.999999F, FontStyle.Bold)
        btnCancelAdd.ForeColor = Color.White
        btnCancelAdd.Location = New Point(262, 175)
        btnCancelAdd.Margin = New Padding(3, 2, 3, 2)
        btnCancelAdd.Name = "btnCancelAdd"
        btnCancelAdd.Size = New Size(206, 46)
        btnCancelAdd.TabIndex = 10
        btnCancelAdd.Text = "Cancel"
        btnCancelAdd.UseVisualStyleBackColor = False
        ' 
        ' lblTooltip
        ' 
        lblTooltip.AutoSize = True
        lblTooltip.Font = New Drawing.Font("Gotham", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTooltip.Location = New Point(88, 108)
        lblTooltip.Name = "lblTooltip"
        lblTooltip.Size = New Size(104, 12)
        lblTooltip.TabIndex = 13
        lblTooltip.Text = "TBR Number Only"
        lblTooltip.Visible = False
        ' 
        ' chkbxSaveInfo
        ' 
        chkbxSaveInfo.AutoSize = True
        chkbxSaveInfo.Enabled = False
        chkbxSaveInfo.Font = New Drawing.Font("Gotham", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkbxSaveInfo.Location = New Point(29, 150)
        chkbxSaveInfo.Margin = New Padding(3, 2, 3, 2)
        chkbxSaveInfo.Name = "chkbxSaveInfo"
        chkbxSaveInfo.Size = New Size(172, 20)
        chkbxSaveInfo.TabIndex = 14
        chkbxSaveInfo.Text = "Save the Information"
        chkbxSaveInfo.UseVisualStyleBackColor = True
        ' 
        ' txtSharepoint
        ' 
        txtSharepoint.Font = New Drawing.Font("Gotham", 9.0F)
        txtSharepoint.Location = New Point(279, 88)
        txtSharepoint.Margin = New Padding(3, 2, 3, 2)
        txtSharepoint.Multiline = True
        txtSharepoint.Name = "txtSharepoint"
        txtSharepoint.PlaceholderText = "Enter Employee's Sharepoint Folder"
        txtSharepoint.Size = New Size(206, 66)
        txtSharepoint.TabIndex = 15
        txtSharepoint.Visible = False
        ' 
        ' lblSharepoint
        ' 
        lblSharepoint.AutoSize = True
        lblSharepoint.Font = New Drawing.Font("Gotham", 9.0F)
        lblSharepoint.Location = New Point(279, 74)
        lblSharepoint.Name = "lblSharepoint"
        lblSharepoint.Size = New Size(172, 13)
        lblSharepoint.TabIndex = 16
        lblSharepoint.Text = "Employee's Sharepoint Link"
        lblSharepoint.Visible = False
        ' 
        ' lnklblSharepoint
        ' 
        lnklblSharepoint.AutoSize = True
        lnklblSharepoint.Font = New Drawing.Font("Gotham", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lnklblSharepoint.LinkColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        lnklblSharepoint.Location = New Point(29, 129)
        lnklblSharepoint.Name = "lnklblSharepoint"
        lnklblSharepoint.Size = New Size(185, 12)
        lnklblSharepoint.TabIndex = 17
        lnklblSharepoint.TabStop = True
        lnklblSharepoint.Text = "Open ""Skills Profiling"" Sharepoint"
        lnklblSharepoint.Visible = False
        lnklblSharepoint.VisitedLinkColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(53), CByte(37), CByte(107))
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(556, 53)
        Panel1.TabIndex = 20
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Drawing.Font("Gotham", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, CByte(161))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(68, 16)
        Label2.Margin = New Padding(0)
        Label2.Name = "Label2"
        Label2.Size = New Size(217, 31)
        Label2.TabIndex = 47
        Label2.Text = "Add Employee"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.The_Back_Room_Logo_WHT_optimised
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(9, 9)
        PictureBox1.Margin = New Padding(70, 30, 30, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Padding = New Padding(30, 0, 0, 0)
        PictureBox1.Size = New Size(57, 38)
        PictureBox1.TabIndex = 48
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(lblFirstName)
        Panel2.Controls.Add(txtLastName)
        Panel2.Controls.Add(lnklblSharepoint)
        Panel2.Controls.Add(lblLastName)
        Panel2.Controls.Add(lblSharepoint)
        Panel2.Controls.Add(txtEmployeeID)
        Panel2.Controls.Add(txtSharepoint)
        Panel2.Controls.Add(lblEmployeeID)
        Panel2.Controls.Add(chkbxSaveInfo)
        Panel2.Controls.Add(btnAdd)
        Panel2.Controls.Add(lblTooltip)
        Panel2.Controls.Add(txtFirstName)
        Panel2.Controls.Add(btnCancelAdd)
        Panel2.Location = New Point(21, 74)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(515, 248)
        Panel2.TabIndex = 21
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Drawing.Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(-6, 217)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(76, 44)
        PictureBox2.TabIndex = 29
        PictureBox2.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), Drawing.Image)
        PictureBox7.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox7.Location = New Point(-112, 253)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(210, 212)
        PictureBox7.TabIndex = 28
        PictureBox7.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Drawing.Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(493, 36)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(108, 243)
        PictureBox3.TabIndex = 30
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Drawing.Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox4.Location = New Point(541, 253)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(30, 23)
        PictureBox4.TabIndex = 31
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Drawing.Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox5.Location = New Point(571, 317)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(30, 23)
        PictureBox5.TabIndex = 32
        PictureBox5.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        Panel3.Location = New Point(12, 65)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(534, 264)
        Panel3.TabIndex = 33
        ' 
        ' AddEmployee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(556, 336)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(PictureBox5)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "AddEmployee"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Employee"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grpEmployeeProfile As GroupBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents lblEmployeeID As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancelAdd As Button
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents lblRole As Label
    Friend WithEvents lblTooltip As Label
    Friend WithEvents chkbxSaveInfo As CheckBox
    Friend WithEvents txtSharepoint As TextBox
    Friend WithEvents lblSharepoint As Label
    Friend WithEvents lnklblSharepoint As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
