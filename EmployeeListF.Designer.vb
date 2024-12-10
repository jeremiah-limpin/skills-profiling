<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeListF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeListF))
        EmployeeListDataGrid = New DataGridView()
        txtSearchEmployeeNumber = New TextBox()
        rdbtnAllEmployees = New RadioButton()
        rdbtnActiveEmployees = New RadioButton()
        rdbtnInactiveEmployees = New RadioButton()
        PictureBox1 = New PictureBox()
        btnImportProfile = New Button()
        btnAddEmployee = New Button()
        deleteEmployeeBtn = New Button()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        picboxReload = New PictureBox()
        lblReload = New Label()
        Panel1 = New Panel()
        picboxMenu = New PictureBox()
        pnlButtons = New Panel()
        btnBulkImport = New Button()
        txtLastName = New TextBox()
        lblFirstName = New Label()
        btnEdit = New Button()
        btnSave = New Button()
        txtFirstName = New TextBox()
        btnAttemptedAccess = New Button()
        btnCancel = New Button()
        lblLastName = New Label()
        txtEmployeeIDAdmin = New TextBox()
        btnLogout = New Button()
        lblEmployeeID = New Label()
        btnChangePassword = New Button()
        grpEmployeeProfile = New GroupBox()
        CType(EmployeeListDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(picboxReload, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(picboxMenu, ComponentModel.ISupportInitialize).BeginInit()
        pnlButtons.SuspendLayout()
        grpEmployeeProfile.SuspendLayout()
        SuspendLayout()
        ' 
        ' EmployeeListDataGrid
        ' 
        EmployeeListDataGrid.AllowUserToAddRows = False
        EmployeeListDataGrid.AllowUserToDeleteRows = False
        EmployeeListDataGrid.AllowUserToOrderColumns = True
        EmployeeListDataGrid.AllowUserToResizeColumns = False
        EmployeeListDataGrid.AllowUserToResizeRows = False
        EmployeeListDataGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        EmployeeListDataGrid.BackgroundColor = Color.White
        EmployeeListDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        EmployeeListDataGrid.GridColor = SystemColors.Window
        EmployeeListDataGrid.Location = New Point(89, 164)
        EmployeeListDataGrid.Margin = New Padding(3, 2, 3, 2)
        EmployeeListDataGrid.Name = "EmployeeListDataGrid"
        EmployeeListDataGrid.RowHeadersWidth = 51
        EmployeeListDataGrid.Size = New Size(681, 632)
        EmployeeListDataGrid.TabIndex = 2
        ' 
        ' txtSearchEmployeeNumber
        ' 
        txtSearchEmployeeNumber.BackColor = Color.White
        txtSearchEmployeeNumber.BorderStyle = BorderStyle.FixedSingle
        txtSearchEmployeeNumber.Font = New System.Drawing.Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearchEmployeeNumber.ForeColor = Color.Black
        txtSearchEmployeeNumber.Location = New Point(91, 3)
        txtSearchEmployeeNumber.Margin = New Padding(0)
        txtSearchEmployeeNumber.Name = "txtSearchEmployeeNumber"
        txtSearchEmployeeNumber.PlaceholderText = "Search by TBR Number"
        txtSearchEmployeeNumber.Size = New Size(266, 24)
        txtSearchEmployeeNumber.TabIndex = 3
        ' 
        ' rdbtnAllEmployees
        ' 
        rdbtnAllEmployees.AutoSize = True
        rdbtnAllEmployees.BackColor = Color.Transparent
        rdbtnAllEmployees.Font = New System.Drawing.Font("Gotham", 9F)
        rdbtnAllEmployees.ForeColor = Color.Black
        rdbtnAllEmployees.Location = New Point(372, 6)
        rdbtnAllEmployees.Margin = New Padding(0)
        rdbtnAllEmployees.Name = "rdbtnAllEmployees"
        rdbtnAllEmployees.Padding = New Padding(5, 0, 0, 0)
        rdbtnAllEmployees.Size = New Size(114, 17)
        rdbtnAllEmployees.TabIndex = 5
        rdbtnAllEmployees.Text = "All Employees"
        rdbtnAllEmployees.UseVisualStyleBackColor = False
        ' 
        ' rdbtnActiveEmployees
        ' 
        rdbtnActiveEmployees.AutoSize = True
        rdbtnActiveEmployees.BackColor = Color.Transparent
        rdbtnActiveEmployees.Font = New System.Drawing.Font("Gotham", 9F)
        rdbtnActiveEmployees.ForeColor = Color.Black
        rdbtnActiveEmployees.Location = New Point(576, 6)
        rdbtnActiveEmployees.Margin = New Padding(0)
        rdbtnActiveEmployees.Name = "rdbtnActiveEmployees"
        rdbtnActiveEmployees.Padding = New Padding(5, 0, 0, 0)
        rdbtnActiveEmployees.Size = New Size(68, 17)
        rdbtnActiveEmployees.TabIndex = 6
        rdbtnActiveEmployees.TabStop = True
        rdbtnActiveEmployees.Text = "Active"
        rdbtnActiveEmployees.UseVisualStyleBackColor = False
        ' 
        ' rdbtnInactiveEmployees
        ' 
        rdbtnInactiveEmployees.AutoSize = True
        rdbtnInactiveEmployees.BackColor = Color.Transparent
        rdbtnInactiveEmployees.Font = New System.Drawing.Font("Gotham", 9F)
        rdbtnInactiveEmployees.ForeColor = Color.Black
        rdbtnInactiveEmployees.Location = New Point(495, 6)
        rdbtnInactiveEmployees.Margin = New Padding(0)
        rdbtnInactiveEmployees.Name = "rdbtnInactiveEmployees"
        rdbtnInactiveEmployees.Padding = New Padding(5, 0, 0, 0)
        rdbtnInactiveEmployees.Size = New Size(76, 17)
        rdbtnInactiveEmployees.TabIndex = 7
        rdbtnInactiveEmployees.TabStop = True
        rdbtnInactiveEmployees.Text = "Inactive"
        rdbtnInactiveEmployees.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Drawing.Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(9, 9)
        PictureBox1.Margin = New Padding(70, 30, 30, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Padding = New Padding(30, 0, 0, 0)
        PictureBox1.Size = New Size(57, 38)
        PictureBox1.TabIndex = 29
        PictureBox1.TabStop = False
        ' 
        ' btnImportProfile
        ' 
        btnImportProfile.Anchor = AnchorStyles.Top
        btnImportProfile.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnImportProfile.BackgroundImageLayout = ImageLayout.None
        btnImportProfile.FlatAppearance.BorderSize = 0
        btnImportProfile.FlatStyle = FlatStyle.Popup
        btnImportProfile.Font = New System.Drawing.Font("Gotham", 10.8F, FontStyle.Bold)
        btnImportProfile.ForeColor = Color.White
        btnImportProfile.Location = New Point(456, 14)
        btnImportProfile.Margin = New Padding(25, 3, 3, 3)
        btnImportProfile.Name = "btnImportProfile"
        btnImportProfile.Size = New Size(136, 46)
        btnImportProfile.TabIndex = 28
        btnImportProfile.Text = "Import Profile"
        btnImportProfile.UseVisualStyleBackColor = False
        ' 
        ' btnAddEmployee
        ' 
        btnAddEmployee.Anchor = AnchorStyles.Top
        btnAddEmployee.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnAddEmployee.FlatAppearance.BorderSize = 0
        btnAddEmployee.FlatStyle = FlatStyle.Popup
        btnAddEmployee.Font = New System.Drawing.Font("Gotham", 10.8F, FontStyle.Bold)
        btnAddEmployee.ForeColor = Color.White
        btnAddEmployee.Location = New Point(111, 14)
        btnAddEmployee.Margin = New Padding(25, 2, 3, 2)
        btnAddEmployee.Name = "btnAddEmployee"
        btnAddEmployee.Size = New Size(136, 46)
        btnAddEmployee.TabIndex = 27
        btnAddEmployee.Text = "Add Employee"
        btnAddEmployee.UseVisualStyleBackColor = False
        ' 
        ' deleteEmployeeBtn
        ' 
        deleteEmployeeBtn.Anchor = AnchorStyles.Top
        deleteEmployeeBtn.BackColor = Color.FromArgb(CByte(221), CByte(60), CByte(39))
        deleteEmployeeBtn.FlatStyle = FlatStyle.Popup
        deleteEmployeeBtn.Font = New System.Drawing.Font("Gotham", 10.8F, FontStyle.Bold)
        deleteEmployeeBtn.ForeColor = Color.White
        deleteEmployeeBtn.Location = New Point(275, 14)
        deleteEmployeeBtn.Margin = New Padding(25, 2, 3, 2)
        deleteEmployeeBtn.Name = "deleteEmployeeBtn"
        deleteEmployeeBtn.Size = New Size(153, 46)
        deleteEmployeeBtn.TabIndex = 30
        deleteEmployeeBtn.Text = "Delete Employee"
        deleteEmployeeBtn.UseVisualStyleBackColor = False
        deleteEmployeeBtn.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New System.Drawing.Font("Gotham", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, CByte(161))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(67, 13)
        Label1.Margin = New Padding(0)
        Label1.Name = "Label1"
        Label1.Size = New Size(209, 31)
        Label1.TabIndex = 20
        Label1.Text = "Skills Profiling"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.White
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Drawing.Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(325, 4)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(25, 18)
        PictureBox2.TabIndex = 32
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(picboxReload)
        Panel2.Controls.Add(lblReload)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(txtSearchEmployeeNumber)
        Panel2.Controls.Add(rdbtnActiveEmployees)
        Panel2.Controls.Add(rdbtnInactiveEmployees)
        Panel2.Controls.Add(rdbtnAllEmployees)
        Panel2.Location = New Point(0, 130)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(859, 30)
        Panel2.TabIndex = 33
        ' 
        ' picboxReload
        ' 
        picboxReload.BackColor = Color.Transparent
        picboxReload.BackgroundImage = CType(resources.GetObject("picboxReload.BackgroundImage"), Drawing.Image)
        picboxReload.BackgroundImageLayout = ImageLayout.Zoom
        picboxReload.Location = New Point(656, 6)
        picboxReload.Margin = New Padding(70, 30, 30, 30)
        picboxReload.Name = "picboxReload"
        picboxReload.Padding = New Padding(30, 0, 0, 0)
        picboxReload.Size = New Size(14, 16)
        picboxReload.TabIndex = 33
        picboxReload.TabStop = False
        ' 
        ' lblReload
        ' 
        lblReload.AutoSize = True
        lblReload.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblReload.Location = New Point(669, 8)
        lblReload.Name = "lblReload"
        lblReload.Size = New Size(52, 13)
        lblReload.TabIndex = 34
        lblReload.Text = "Refresh"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        Panel1.Controls.Add(picboxMenu)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(858, 53)
        Panel1.TabIndex = 31
        ' 
        ' picboxMenu
        ' 
        picboxMenu.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        picboxMenu.BackColor = Color.Transparent
        picboxMenu.BackgroundImage = CType(resources.GetObject("picboxMenu.BackgroundImage"), Drawing.Image)
        picboxMenu.BackgroundImageLayout = ImageLayout.Zoom
        picboxMenu.Cursor = Cursors.Hand
        picboxMenu.Location = New Point(795, 9)
        picboxMenu.Margin = New Padding(70, 30, 30, 30)
        picboxMenu.Name = "picboxMenu"
        picboxMenu.Padding = New Padding(30, 0, 0, 0)
        picboxMenu.Size = New Size(57, 38)
        picboxMenu.TabIndex = 30
        picboxMenu.TabStop = False
        ' 
        ' pnlButtons
        ' 
        pnlButtons.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlButtons.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        pnlButtons.Controls.Add(btnBulkImport)
        pnlButtons.Controls.Add(btnImportProfile)
        pnlButtons.Controls.Add(deleteEmployeeBtn)
        pnlButtons.Controls.Add(btnAddEmployee)
        pnlButtons.Location = New Point(-4, 54)
        pnlButtons.Margin = New Padding(3, 2, 3, 2)
        pnlButtons.Name = "pnlButtons"
        pnlButtons.Size = New Size(863, 74)
        pnlButtons.TabIndex = 34
        ' 
        ' btnBulkImport
        ' 
        btnBulkImport.Anchor = AnchorStyles.Top
        btnBulkImport.BackColor = Color.SeaGreen
        btnBulkImport.BackgroundImageLayout = ImageLayout.None
        btnBulkImport.FlatAppearance.BorderSize = 0
        btnBulkImport.FlatStyle = FlatStyle.Popup
        btnBulkImport.Font = New System.Drawing.Font("Gotham", 10.8F, FontStyle.Bold)
        btnBulkImport.ForeColor = Color.White
        btnBulkImport.Location = New Point(620, 14)
        btnBulkImport.Margin = New Padding(25, 3, 3, 3)
        btnBulkImport.Name = "btnBulkImport"
        btnBulkImport.Size = New Size(136, 46)
        btnBulkImport.TabIndex = 31
        btnBulkImport.Text = "Bulk Import"
        btnBulkImport.UseVisualStyleBackColor = False
        ' 
        ' txtLastName
        ' 
        txtLastName.BackColor = Color.White
        txtLastName.BorderStyle = BorderStyle.None
        txtLastName.Enabled = False
        txtLastName.Font = New System.Drawing.Font("Gotham", 12F)
        txtLastName.ForeColor = SystemColors.WindowText
        txtLastName.Location = New Point(32, 104)
        txtLastName.Margin = New Padding(3, 2, 3, 2)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(228, 17)
        txtLastName.TabIndex = 4
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New System.Drawing.Font("Gotham", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(161))
        lblFirstName.ForeColor = Color.White
        lblFirstName.Location = New Point(32, 33)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(103, 18)
        lblFirstName.TabIndex = 8
        lblFirstName.Text = "First Name:"
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnEdit.FlatAppearance.BorderSize = 0
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New System.Drawing.Font("Gotham", 10.8F, FontStyle.Bold)
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(32, 206)
        btnEdit.Margin = New Padding(3, 2, 3, 2)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(231, 46)
        btnEdit.TabIndex = 10
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New System.Drawing.Font("Gotham", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(31, 306)
        btnSave.Margin = New Padding(3, 2, 3, 2)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(111, 46)
        btnSave.TabIndex = 5
        btnSave.Text = "Save Changes"
        btnSave.UseVisualStyleBackColor = False
        btnSave.Visible = False
        ' 
        ' txtFirstName
        ' 
        txtFirstName.BackColor = Color.White
        txtFirstName.BorderStyle = BorderStyle.None
        txtFirstName.Enabled = False
        txtFirstName.Font = New System.Drawing.Font("Gotham", 12F)
        txtFirstName.ForeColor = SystemColors.WindowText
        txtFirstName.Location = New Point(33, 52)
        txtFirstName.Margin = New Padding(3, 2, 3, 2)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(228, 17)
        txtFirstName.TabIndex = 3
        ' 
        ' btnAttemptedAccess
        ' 
        btnAttemptedAccess.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnAttemptedAccess.FlatAppearance.BorderSize = 0
        btnAttemptedAccess.FlatStyle = FlatStyle.Flat
        btnAttemptedAccess.Font = New System.Drawing.Font("Gotham", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAttemptedAccess.ForeColor = Color.White
        btnAttemptedAccess.Location = New Point(31, 256)
        btnAttemptedAccess.Margin = New Padding(3, 2, 3, 2)
        btnAttemptedAccess.Name = "btnAttemptedAccess"
        btnAttemptedAccess.Size = New Size(112, 46)
        btnAttemptedAccess.TabIndex = 5
        btnAttemptedAccess.Text = "Attempted Access"
        btnAttemptedAccess.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New System.Drawing.Font("Gotham", 10.8F, FontStyle.Bold)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(148, 306)
        btnCancel.Margin = New Padding(3, 2, 3, 2)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(115, 46)
        btnCancel.TabIndex = 10
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        btnCancel.Visible = False
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Font = New System.Drawing.Font("Gotham", 11.999999F, FontStyle.Bold)
        lblLastName.ForeColor = Color.White
        lblLastName.Location = New Point(31, 83)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(99, 18)
        lblLastName.TabIndex = 9
        lblLastName.Text = "Last Name:"
        ' 
        ' txtEmployeeIDAdmin
        ' 
        txtEmployeeIDAdmin.BackColor = Color.White
        txtEmployeeIDAdmin.BorderStyle = BorderStyle.None
        txtEmployeeIDAdmin.Enabled = False
        txtEmployeeIDAdmin.Font = New System.Drawing.Font("Gotham", 12F)
        txtEmployeeIDAdmin.ForeColor = SystemColors.WindowText
        txtEmployeeIDAdmin.Location = New Point(32, 158)
        txtEmployeeIDAdmin.Margin = New Padding(3, 2, 3, 2)
        txtEmployeeIDAdmin.Name = "txtEmployeeIDAdmin"
        txtEmployeeIDAdmin.Size = New Size(228, 17)
        txtEmployeeIDAdmin.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(221), CByte(60), CByte(39))
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New System.Drawing.Font("Gotham", 10.8F, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(84, 356)
        btnLogout.Margin = New Padding(3, 2, 3, 2)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(115, 46)
        btnLogout.TabIndex = 16
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' lblEmployeeID
        ' 
        lblEmployeeID.AutoSize = True
        lblEmployeeID.Font = New System.Drawing.Font("Gotham", 11.999999F, FontStyle.Bold)
        lblEmployeeID.ForeColor = Color.White
        lblEmployeeID.Location = New Point(30, 139)
        lblEmployeeID.Name = "lblEmployeeID"
        lblEmployeeID.Size = New Size(119, 18)
        lblEmployeeID.TabIndex = 2
        lblEmployeeID.Text = "Employee ID:"
        ' 
        ' btnChangePassword
        ' 
        btnChangePassword.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnChangePassword.FlatAppearance.BorderSize = 0
        btnChangePassword.FlatStyle = FlatStyle.Flat
        btnChangePassword.Font = New System.Drawing.Font("Gotham", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnChangePassword.ForeColor = Color.White
        btnChangePassword.Location = New Point(147, 256)
        btnChangePassword.Margin = New Padding(3, 2, 3, 2)
        btnChangePassword.Name = "btnChangePassword"
        btnChangePassword.Size = New Size(116, 46)
        btnChangePassword.TabIndex = 17
        btnChangePassword.Text = "Change Password"
        btnChangePassword.UseVisualStyleBackColor = False
        ' 
        ' grpEmployeeProfile
        ' 
        grpEmployeeProfile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        grpEmployeeProfile.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        grpEmployeeProfile.BackgroundImageLayout = ImageLayout.None
        grpEmployeeProfile.Controls.Add(btnChangePassword)
        grpEmployeeProfile.Controls.Add(lblEmployeeID)
        grpEmployeeProfile.Controls.Add(btnLogout)
        grpEmployeeProfile.Controls.Add(txtEmployeeIDAdmin)
        grpEmployeeProfile.Controls.Add(lblLastName)
        grpEmployeeProfile.Controls.Add(btnCancel)
        grpEmployeeProfile.Controls.Add(btnAttemptedAccess)
        grpEmployeeProfile.Controls.Add(txtFirstName)
        grpEmployeeProfile.Controls.Add(btnSave)
        grpEmployeeProfile.Controls.Add(btnEdit)
        grpEmployeeProfile.Controls.Add(lblFirstName)
        grpEmployeeProfile.Controls.Add(txtLastName)
        grpEmployeeProfile.FlatStyle = FlatStyle.Flat
        grpEmployeeProfile.Location = New Point(571, 45)
        grpEmployeeProfile.Margin = New Padding(3, 2, 3, 2)
        grpEmployeeProfile.Name = "grpEmployeeProfile"
        grpEmployeeProfile.Padding = New Padding(3, 2, 3, 2)
        grpEmployeeProfile.Size = New Size(288, 434)
        grpEmployeeProfile.TabIndex = 0
        grpEmployeeProfile.TabStop = False
        grpEmployeeProfile.Visible = False
        ' 
        ' EmployeeListF
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(858, 796)
        Controls.Add(grpEmployeeProfile)
        Controls.Add(Panel2)
        Controls.Add(EmployeeListDataGrid)
        Controls.Add(pnlButtons)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        MinimumSize = New Size(874, 835)
        Name = "EmployeeListF"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        CType(EmployeeListDataGrid, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(picboxReload, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(picboxMenu, ComponentModel.ISupportInitialize).EndInit()
        pnlButtons.ResumeLayout(False)
        grpEmployeeProfile.ResumeLayout(False)
        grpEmployeeProfile.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents EmployeeListDataGrid As DataGridView
    Friend WithEvents txtSearchEmployeeNumber As TextBox
    Friend WithEvents rdbtnAllEmployees As RadioButton
    Friend WithEvents rdbtnActiveEmployees As RadioButton
    Friend WithEvents rdbtnInactiveEmployees As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnImportProfile As Button
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents deleteEmployeeBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents picboxMenu As PictureBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents btnAttemptedAccess As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtEmployeeIDAdmin As TextBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblEmployeeID As Label
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents grpEmployeeProfile As GroupBox
    Friend WithEvents picboxReload As PictureBox
    Friend WithEvents lblReload As Label
    Friend WithEvents btnBulkImport As Button
End Class
