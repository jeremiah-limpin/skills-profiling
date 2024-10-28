<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeF))
        EmployeeTabControl = New TabControl()
        EmployeeProfileTab = New TabPage()
        btnExportExcelSheets = New Button()
        btnExportPDF = New Button()
        chkbxIsActive = New CheckBox()
        EmployeeProfileDataGrid = New DataGridView()
        btnSaveEP = New Button()
        btnCancelEP = New Button()
        txtSharepointLink = New TextBox()
        Label4 = New Label()
        txtLastUpdate = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtFname = New TextBox()
        txtLname = New TextBox()
        JobHistoryTab = New TabPage()
        txtClientName = New TextBox()
        btnCancel = New Button()
        btnClear = New Button()
        btnDelete = New Button()
        btnSaveChanges = New Button()
        txtReasonForChange = New TextBox()
        lblReasonFrChange = New Label()
        lblEndDate = New Label()
        lblStartDate = New Label()
        txtRegion = New TextBox()
        lblRegion = New Label()
        lblClientName = New Label()
        txtRoleDesignation = New TextBox()
        lblRoleDesignation = New Label()
        btnAdd = New Button()
        txtStartDateJ = New TextBox()
        txtEndDateJ = New TextBox()
        JobHistoryDataGrid = New DataGridView()
        TaskProfileTab = New TabPage()
        btnCancelTP = New Button()
        btnClearTP = New Button()
        btnDeleteTP = New Button()
        btnSaveChangesTP = New Button()
        btnAddTP = New Button()
        txtDescription = New TextBox()
        lblDescription = New Label()
        txtPOC = New TextBox()
        lblPOC = New Label()
        txtCategory = New TextBox()
        lblCategory = New Label()
        txtTaskName = New TextBox()
        lblTaskProfile = New Label()
        TaskProfileDataGrid = New DataGridView()
        SoftwareAndToolsTab = New TabPage()
        btnDeleteST = New Button()
        btnSaveChangesST = New Button()
        btnAddST = New Button()
        btnCancelST = New Button()
        btnClearST = New Button()
        lblUsedFor = New Label()
        txtUsedFor = New TextBox()
        lblSoftwareOrTools = New Label()
        txtSoftwareOrTools = New TextBox()
        SoftwareAndToolsDataGrid = New DataGridView()
        SkillsInterviewTab = New TabPage()
        btnDeleteSI = New Button()
        btnSaveChangesSI = New Button()
        btnCancelSI = New Button()
        txtAssessmentNotes = New TextBox()
        btnAddSI = New Button()
        lblAssessmentNotes = New Label()
        txtInterviewer = New TextBox()
        lblInterviewer = New Label()
        lblDate = New Label()
        txtRoleOrDesignation = New TextBox()
        lblRoleOrDesignation = New Label()
        btnClearSI = New Button()
        SkillsInterviewDataGrid = New DataGridView()
        dtpckerDate = New TextBox()
        PerformanceEvaluationTab = New TabPage()
        btnDeletePE = New Button()
        btnSaveChangesPE = New Button()
        btnCancelPE = New Button()
        btnClearPE = New Button()
        btnAddPE = New Button()
        txtEvaluationNotes = New TextBox()
        lblEvaluationNotes = New Label()
        txtEvaluator = New TextBox()
        lblEvaluator = New Label()
        lblEvaluationDate = New Label()
        txtEvaluationType = New TextBox()
        lblEvaluationType = New Label()
        PerformanceEvaluationDataGrid = New DataGridView()
        dtpckerEvalutionDate = New TextBox()
        SkillsTriageTab = New TabPage()
        txtDeliberationScore = New TextBox()
        lblDeliberationScore = New Label()
        txtDeliberationNotes = New TextBox()
        lblDeliberationNotes = New Label()
        btnDeleteT = New Button()
        btnSaveChangesT = New Button()
        btnClearT = New Button()
        btnCancelT = New Button()
        btnAddT = New Button()
        txtDetailsOfConcern = New TextBox()
        lblDetailsOfConcern = New Label()
        lblDateClose = New Label()
        lblStartDateT = New Label()
        txtConcernBy = New TextBox()
        lblConcernBy = New Label()
        SkillsTriageDataGrid = New DataGridView()
        dtpckerStartDateT = New TextBox()
        dtpckerDateClose = New TextBox()
        TrainingHistoryTab = New TabPage()
        btnClearTH = New Button()
        btnCancelTH = New Button()
        btnDeleteTH = New Button()
        btnSaveChangesTH = New Button()
        txtGrade = New TextBox()
        lblGrade = New Label()
        lblCompletion = New Label()
        txtFacilitator = New TextBox()
        lblFacilitator = New Label()
        txtTopicOrModuleTitle = New TextBox()
        lblTopicOrModuleTitle = New Label()
        TrainingHistoryDataGrid = New DataGridView()
        btnAddTH = New Button()
        dtpckerCompletion = New TextBox()
        CertificationsAndLicenses = New TabPage()
        txtChapter = New TextBox()
        Label1 = New Label()
        btnCancelCL = New Button()
        btnClearCL = New Button()
        btnDeleteCL = New Button()
        btnSaveChangesCL = New Button()
        txtLicenseNumber = New TextBox()
        lblLicenseNumber = New Label()
        txtStatus = New TextBox()
        lblStatus = New Label()
        lblGrantDate = New Label()
        lblExpiryDate = New Label()
        txtCertificateName = New TextBox()
        lblCertificateName = New Label()
        CertificationAndLicensesDataGrid = New DataGridView()
        txtProvider = New TextBox()
        lblProvider = New Label()
        btnAddCL = New Button()
        dtpckerGrantDate = New TextBox()
        dtpckerExpiryDate = New TextBox()
        TrainingPlanTab = New TabPage()
        lblTargetDate = New Label()
        txtTopicOrModuleName = New TextBox()
        lblTopicOrModuleName = New Label()
        txtFacilitatorP = New TextBox()
        lblFacilitatorP = New Label()
        btnCancelP = New Button()
        btnClearP = New Button()
        btnDeleteP = New Button()
        btnSaveChangesP = New Button()
        TrainingPlanDataGrid = New DataGridView()
        btnAddP = New Button()
        txtTargetDate = New TextBox()
        TrainingProgramsTab = New TabPage()
        txtCompletionDateTPr = New TextBox()
        txtStartDateTPr = New TextBox()
        btnCancelTPr = New Button()
        btnClearTPr = New Button()
        btnDeleteTPr = New Button()
        btnSaveChangesTPr = New Button()
        txtDeliberationScoreTPr = New TextBox()
        lblDeliberationScoreTPr = New Label()
        txtDeliberationNotesTPr = New TextBox()
        lblDeliberationNotesTPr = New Label()
        lblCompletionDate = New Label()
        lblStartDateTPr = New Label()
        txtProgramTitle = New TextBox()
        lblProgramTitle = New Label()
        TrainingProgramsDataGrid = New DataGridView()
        btnAddTPr = New Button()
        WebinarsAttendedTab = New TabPage()
        txtDateW = New TextBox()
        btnCancelW = New Button()
        btnClearW = New Button()
        btnDeleteW = New Button()
        btnSaveChangesW = New Button()
        txtWebinarTitle = New TextBox()
        lblWebinarTitle = New Label()
        WebinarsAttendedDataGrid = New DataGridView()
        lblCPDUnits = New Label()
        lblDateW = New Label()
        txtCPDUnits = New TextBox()
        btnAddW = New Button()
        ClientFeedbackTab = New TabPage()
        txtFeedbackDate = New TextBox()
        btnCancelCF = New Button()
        btnClearCF = New Button()
        btnDeleteCF = New Button()
        btnSaveChangesCF = New Button()
        lblStaffPerformanceRating = New Label()
        txtStaffPerformanceRating = New TextBox()
        txtFeedbackSummary = New TextBox()
        lblFeedbackSummary = New Label()
        lblFeedbackDate = New Label()
        txt = New Label()
        txtClientPOC = New TextBox()
        lblAccountManager = New Label()
        txtAccountManager = New TextBox()
        ClientFeedbackDataGrid = New DataGridView()
        btnAddCF = New Button()
        SelfAssessmentTab = New TabPage()
        txtFeedbackDateSA = New TextBox()
        btnCancelSA = New Button()
        btnClearSA = New Button()
        btnDeleteSA = New Button()
        btnSaveChangesSA = New Button()
        lblTBRRating = New Label()
        txtTBRRating = New TextBox()
        txtClientRating = New TextBox()
        lblClientRating = New Label()
        lblAccountManagerSA = New Label()
        txtAccountManagerSA = New TextBox()
        SelfAssessmentDataGrid = New DataGridView()
        lblFeedbackDateSA = New Label()
        l = New Label()
        txtPersonalPerformanceRating = New TextBox()
        btnAddSA = New Button()
        CompetencyCertificationsTab = New TabPage()
        txtGrantDateCC = New TextBox()
        btnCancelCC = New Button()
        btnClearCC = New Button()
        btnDeleteCC = New Button()
        btnSaveChangesCC = New Button()
        btnAddCC = New Button()
        txtOverallGrade = New TextBox()
        lblOverallGrade = New Label()
        lblGrantDateCC = New Label()
        txtCertificationName = New TextBox()
        lblCertificationName = New Label()
        CompetencyCertificationDataGrid = New DataGridView()
        txtDeliberationSummary = New TextBox()
        lblDeliberationSummary = New Label()
        PrintEmployeeDetails = New Printing.PrintDocument()
        PrintEmployeeDetailsDialog = New PrintPreviewDialog()
        Panel1 = New Panel()
        lblEPName = New Label()
        picboxMenu = New PictureBox()
        PictureBox1 = New PictureBox()
        grpEmployeeProfile = New GroupBox()
        btnChangePassword = New Button()
        txtEmployeeNumber = New TextBox()
        lblEmployeeID = New Label()
        txtEmployeeIDAdmin = New TextBox()
        lblLastName = New Label()
        btnUserCancel = New Button()
        btnAttemptedAccess = New Button()
        txtFirstName = New TextBox()
        btnSave = New Button()
        btnEdit = New Button()
        lblFirstName = New Label()
        txtLastName = New TextBox()
        PictureBox6 = New PictureBox()
        EmployeeTabControl.SuspendLayout()
        EmployeeProfileTab.SuspendLayout()
        CType(EmployeeProfileDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        JobHistoryTab.SuspendLayout()
        CType(JobHistoryDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        TaskProfileTab.SuspendLayout()
        CType(TaskProfileDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        SoftwareAndToolsTab.SuspendLayout()
        CType(SoftwareAndToolsDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        SkillsInterviewTab.SuspendLayout()
        CType(SkillsInterviewDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        PerformanceEvaluationTab.SuspendLayout()
        CType(PerformanceEvaluationDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        SkillsTriageTab.SuspendLayout()
        CType(SkillsTriageDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        TrainingHistoryTab.SuspendLayout()
        CType(TrainingHistoryDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        CertificationsAndLicenses.SuspendLayout()
        CType(CertificationAndLicensesDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        TrainingPlanTab.SuspendLayout()
        CType(TrainingPlanDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        TrainingProgramsTab.SuspendLayout()
        CType(TrainingProgramsDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        WebinarsAttendedTab.SuspendLayout()
        CType(WebinarsAttendedDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        ClientFeedbackTab.SuspendLayout()
        CType(ClientFeedbackDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        SelfAssessmentTab.SuspendLayout()
        CType(SelfAssessmentDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        CompetencyCertificationsTab.SuspendLayout()
        CType(CompetencyCertificationDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(picboxMenu, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        grpEmployeeProfile.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' EmployeeTabControl
        ' 
        EmployeeTabControl.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        EmployeeTabControl.Appearance = TabAppearance.Buttons
        EmployeeTabControl.Controls.Add(EmployeeProfileTab)
        EmployeeTabControl.Controls.Add(JobHistoryTab)
        EmployeeTabControl.Controls.Add(TaskProfileTab)
        EmployeeTabControl.Controls.Add(SoftwareAndToolsTab)
        EmployeeTabControl.Controls.Add(SkillsInterviewTab)
        EmployeeTabControl.Controls.Add(PerformanceEvaluationTab)
        EmployeeTabControl.Controls.Add(SkillsTriageTab)
        EmployeeTabControl.Controls.Add(TrainingHistoryTab)
        EmployeeTabControl.Controls.Add(CertificationsAndLicenses)
        EmployeeTabControl.Controls.Add(TrainingPlanTab)
        EmployeeTabControl.Controls.Add(TrainingProgramsTab)
        EmployeeTabControl.Controls.Add(WebinarsAttendedTab)
        EmployeeTabControl.Controls.Add(ClientFeedbackTab)
        EmployeeTabControl.Controls.Add(SelfAssessmentTab)
        EmployeeTabControl.Controls.Add(CompetencyCertificationsTab)
        EmployeeTabControl.DrawMode = TabDrawMode.OwnerDrawFixed
        EmployeeTabControl.Font = New System.Drawing.Font("Gotham", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        EmployeeTabControl.Location = New Point(27, 62)
        EmployeeTabControl.Margin = New Padding(0)
        EmployeeTabControl.Multiline = True
        EmployeeTabControl.Name = "EmployeeTabControl"
        EmployeeTabControl.Padding = New Point(8, 8)
        EmployeeTabControl.RightToLeft = RightToLeft.No
        EmployeeTabControl.SelectedIndex = 0
        EmployeeTabControl.Size = New Size(892, 723)
        EmployeeTabControl.SizeMode = TabSizeMode.FillToRight
        EmployeeTabControl.TabIndex = 1
        ' 
        ' EmployeeProfileTab
        ' 
        EmployeeProfileTab.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        EmployeeProfileTab.Controls.Add(btnExportExcelSheets)
        EmployeeProfileTab.Controls.Add(btnExportPDF)
        EmployeeProfileTab.Controls.Add(chkbxIsActive)
        EmployeeProfileTab.Controls.Add(EmployeeProfileDataGrid)
        EmployeeProfileTab.Controls.Add(btnSaveEP)
        EmployeeProfileTab.Controls.Add(btnCancelEP)
        EmployeeProfileTab.Controls.Add(txtSharepointLink)
        EmployeeProfileTab.Controls.Add(Label4)
        EmployeeProfileTab.Controls.Add(txtLastUpdate)
        EmployeeProfileTab.Controls.Add(Label5)
        EmployeeProfileTab.Controls.Add(Label6)
        EmployeeProfileTab.Controls.Add(Label7)
        EmployeeProfileTab.Controls.Add(txtFname)
        EmployeeProfileTab.Controls.Add(txtLname)
        EmployeeProfileTab.Font = New System.Drawing.Font("Gotham", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        EmployeeProfileTab.Location = New Point(4, 67)
        EmployeeProfileTab.Margin = New Padding(3, 2, 3, 2)
        EmployeeProfileTab.Name = "EmployeeProfileTab"
        EmployeeProfileTab.Padding = New Padding(3, 2, 3, 2)
        EmployeeProfileTab.Size = New Size(884, 652)
        EmployeeProfileTab.TabIndex = 14
        EmployeeProfileTab.Text = "Employee Profile"
        ' 
        ' btnExportExcelSheets
        ' 
        btnExportExcelSheets.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnExportExcelSheets.FlatAppearance.BorderSize = 0
        btnExportExcelSheets.FlatStyle = FlatStyle.Flat
        btnExportExcelSheets.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnExportExcelSheets.ForeColor = Color.White
        btnExportExcelSheets.Location = New Point(13, 436)
        btnExportExcelSheets.Margin = New Padding(3, 2, 3, 2)
        btnExportExcelSheets.Name = "btnExportExcelSheets"
        btnExportExcelSheets.Size = New Size(209, 53)
        btnExportExcelSheets.TabIndex = 57
        btnExportExcelSheets.Text = "Export Employee Details to Excel"
        btnExportExcelSheets.UseVisualStyleBackColor = False
        ' 
        ' btnExportPDF
        ' 
        btnExportPDF.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnExportPDF.FlatAppearance.BorderSize = 0
        btnExportPDF.FlatStyle = FlatStyle.Flat
        btnExportPDF.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnExportPDF.ForeColor = Color.White
        btnExportPDF.Location = New Point(13, 494)
        btnExportPDF.Margin = New Padding(3, 2, 3, 2)
        btnExportPDF.Name = "btnExportPDF"
        btnExportPDF.Size = New Size(209, 53)
        btnExportPDF.TabIndex = 56
        btnExportPDF.Text = "Export Employee Details to PDF"
        btnExportPDF.UseVisualStyleBackColor = False
        ' 
        ' chkbxIsActive
        ' 
        chkbxIsActive.AutoSize = True
        chkbxIsActive.ForeColor = Color.White
        chkbxIsActive.Location = New Point(17, 104)
        chkbxIsActive.Margin = New Padding(3, 2, 3, 2)
        chkbxIsActive.Name = "chkbxIsActive"
        chkbxIsActive.Size = New Size(77, 17)
        chkbxIsActive.TabIndex = 54
        chkbxIsActive.Text = "Is Active"
        chkbxIsActive.UseVisualStyleBackColor = True
        ' 
        ' EmployeeProfileDataGrid
        ' 
        EmployeeProfileDataGrid.AllowUserToAddRows = False
        EmployeeProfileDataGrid.AllowUserToDeleteRows = False
        EmployeeProfileDataGrid.AllowUserToOrderColumns = True
        EmployeeProfileDataGrid.AllowUserToResizeColumns = False
        EmployeeProfileDataGrid.AllowUserToResizeRows = False
        EmployeeProfileDataGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        EmployeeProfileDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        EmployeeProfileDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        EmployeeProfileDataGrid.BackgroundColor = SystemColors.ButtonHighlight
        EmployeeProfileDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        EmployeeProfileDataGrid.Location = New Point(230, 4)
        EmployeeProfileDataGrid.Margin = New Padding(3, 2, 3, 2)
        EmployeeProfileDataGrid.Name = "EmployeeProfileDataGrid"
        EmployeeProfileDataGrid.RowHeadersWidth = 51
        EmployeeProfileDataGrid.Size = New Size(652, 645)
        EmployeeProfileDataGrid.TabIndex = 52
        ' 
        ' btnSaveEP
        ' 
        btnSaveEP.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnSaveEP.FlatAppearance.BorderSize = 0
        btnSaveEP.FlatStyle = FlatStyle.Flat
        btnSaveEP.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnSaveEP.ForeColor = Color.White
        btnSaveEP.Location = New Point(13, 354)
        btnSaveEP.Margin = New Padding(3, 2, 3, 2)
        btnSaveEP.Name = "btnSaveEP"
        btnSaveEP.Size = New Size(208, 37)
        btnSaveEP.TabIndex = 50
        btnSaveEP.Text = "Save Changes"
        btnSaveEP.UseVisualStyleBackColor = False
        ' 
        ' btnCancelEP
        ' 
        btnCancelEP.BackColor = Color.FromArgb(CByte(221), CByte(60), CByte(39))
        btnCancelEP.FlatAppearance.BorderSize = 0
        btnCancelEP.FlatStyle = FlatStyle.Flat
        btnCancelEP.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnCancelEP.ForeColor = Color.White
        btnCancelEP.Location = New Point(13, 395)
        btnCancelEP.Margin = New Padding(3, 2, 3, 2)
        btnCancelEP.Name = "btnCancelEP"
        btnCancelEP.Size = New Size(208, 37)
        btnCancelEP.TabIndex = 49
        btnCancelEP.Text = "Cancel"
        btnCancelEP.UseVisualStyleBackColor = False
        ' 
        ' txtSharepointLink
        ' 
        txtSharepointLink.Font = New System.Drawing.Font("Gotham", 9F)
        txtSharepointLink.Location = New Point(13, 193)
        txtSharepointLink.Margin = New Padding(3, 2, 3, 2)
        txtSharepointLink.Multiline = True
        txtSharepointLink.Name = "txtSharepointLink"
        txtSharepointLink.ScrollBars = ScrollBars.Both
        txtSharepointLink.Size = New Size(210, 140)
        txtSharepointLink.TabIndex = 45
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.White
        Label4.Location = New Point(13, 177)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 13)
        Label4.TabIndex = 44
        Label4.Text = "Sharepoint Link"
        ' 
        ' txtLastUpdate
        ' 
        txtLastUpdate.Font = New System.Drawing.Font("Gotham", 9F)
        txtLastUpdate.Location = New Point(14, 143)
        txtLastUpdate.Margin = New Padding(3, 2, 3, 2)
        txtLastUpdate.Name = "txtLastUpdate"
        txtLastUpdate.Size = New Size(209, 20)
        txtLastUpdate.TabIndex = 43
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.White
        Label5.Location = New Point(14, 127)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 13)
        Label5.TabIndex = 42
        Label5.Text = "Last Update"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.White
        Label6.Location = New Point(14, 58)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 13)
        Label6.TabIndex = 41
        Label6.Text = "Last Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.White
        Label7.Location = New Point(13, 16)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 13)
        Label7.TabIndex = 40
        Label7.Text = "First Name"
        ' 
        ' txtFname
        ' 
        txtFname.Font = New System.Drawing.Font("Gotham", 9F)
        txtFname.Location = New Point(13, 32)
        txtFname.Margin = New Padding(3, 2, 3, 2)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(210, 20)
        txtFname.TabIndex = 46
        ' 
        ' txtLname
        ' 
        txtLname.Font = New System.Drawing.Font("Gotham", 9F)
        txtLname.Location = New Point(13, 76)
        txtLname.Margin = New Padding(3, 2, 3, 2)
        txtLname.Name = "txtLname"
        txtLname.Size = New Size(210, 20)
        txtLname.TabIndex = 47
        ' 
        ' JobHistoryTab
        ' 
        JobHistoryTab.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        JobHistoryTab.Controls.Add(txtClientName)
        JobHistoryTab.Controls.Add(btnCancel)
        JobHistoryTab.Controls.Add(btnClear)
        JobHistoryTab.Controls.Add(btnDelete)
        JobHistoryTab.Controls.Add(btnSaveChanges)
        JobHistoryTab.Controls.Add(txtReasonForChange)
        JobHistoryTab.Controls.Add(lblReasonFrChange)
        JobHistoryTab.Controls.Add(lblEndDate)
        JobHistoryTab.Controls.Add(lblStartDate)
        JobHistoryTab.Controls.Add(txtRegion)
        JobHistoryTab.Controls.Add(lblRegion)
        JobHistoryTab.Controls.Add(lblClientName)
        JobHistoryTab.Controls.Add(txtRoleDesignation)
        JobHistoryTab.Controls.Add(lblRoleDesignation)
        JobHistoryTab.Controls.Add(btnAdd)
        JobHistoryTab.Controls.Add(txtStartDateJ)
        JobHistoryTab.Controls.Add(txtEndDateJ)
        JobHistoryTab.Controls.Add(JobHistoryDataGrid)
        JobHistoryTab.Font = New System.Drawing.Font("Gotham", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        JobHistoryTab.Location = New Point(4, 67)
        JobHistoryTab.Margin = New Padding(3, 2, 3, 2)
        JobHistoryTab.Name = "JobHistoryTab"
        JobHistoryTab.Padding = New Padding(4)
        JobHistoryTab.Size = New Size(884, 652)
        JobHistoryTab.TabIndex = 0
        JobHistoryTab.Text = "Job History"
        ' 
        ' txtClientName
        ' 
        txtClientName.Font = New System.Drawing.Font("Gotham", 9F)
        txtClientName.Location = New Point(13, 90)
        txtClientName.Margin = New Padding(3, 2, 3, 2)
        txtClientName.Multiline = True
        txtClientName.Name = "txtClientName"
        txtClientName.ScrollBars = ScrollBars.Both
        txtClientName.Size = New Size(210, 33)
        txtClientName.TabIndex = 24
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(13, 510)
        btnCancel.Margin = New Padding(3, 2, 3, 2)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(211, 37)
        btnCancel.TabIndex = 18
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        btnCancel.Visible = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(13, 469)
        btnClear.Margin = New Padding(3, 2, 3, 2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(211, 37)
        btnClear.TabIndex = 16
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(221), CByte(60), CByte(39))
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(122, 428)
        btnDelete.Margin = New Padding(3, 2, 3, 2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(102, 37)
        btnDelete.TabIndex = 15
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        btnDelete.Visible = False
        ' 
        ' btnSaveChanges
        ' 
        btnSaveChanges.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnSaveChanges.FlatAppearance.BorderSize = 0
        btnSaveChanges.FlatStyle = FlatStyle.Flat
        btnSaveChanges.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnSaveChanges.ForeColor = Color.White
        btnSaveChanges.Location = New Point(13, 428)
        btnSaveChanges.Margin = New Padding(3, 2, 3, 2)
        btnSaveChanges.Name = "btnSaveChanges"
        btnSaveChanges.Size = New Size(102, 36)
        btnSaveChanges.TabIndex = 13
        btnSaveChanges.Text = "Save Changes"
        btnSaveChanges.UseVisualStyleBackColor = False
        btnSaveChanges.Visible = False
        ' 
        ' txtReasonForChange
        ' 
        txtReasonForChange.Font = New System.Drawing.Font("Gotham", 9F)
        txtReasonForChange.Location = New Point(14, 260)
        txtReasonForChange.Margin = New Padding(3, 2, 3, 2)
        txtReasonForChange.Multiline = True
        txtReasonForChange.Name = "txtReasonForChange"
        txtReasonForChange.ScrollBars = ScrollBars.Both
        txtReasonForChange.Size = New Size(210, 151)
        txtReasonForChange.TabIndex = 12
        ' 
        ' lblReasonFrChange
        ' 
        lblReasonFrChange.AutoSize = True
        lblReasonFrChange.ForeColor = Color.White
        lblReasonFrChange.Location = New Point(13, 243)
        lblReasonFrChange.Name = "lblReasonFrChange"
        lblReasonFrChange.Size = New Size(121, 13)
        lblReasonFrChange.TabIndex = 11
        lblReasonFrChange.Text = "Reason for Change"
        ' 
        ' lblEndDate
        ' 
        lblEndDate.AutoSize = True
        lblEndDate.ForeColor = Color.White
        lblEndDate.Location = New Point(13, 202)
        lblEndDate.Name = "lblEndDate"
        lblEndDate.Size = New Size(62, 13)
        lblEndDate.TabIndex = 9
        lblEndDate.Text = "End Date"
        ' 
        ' lblStartDate
        ' 
        lblStartDate.AutoSize = True
        lblStartDate.ForeColor = Color.White
        lblStartDate.Location = New Point(13, 164)
        lblStartDate.Name = "lblStartDate"
        lblStartDate.Size = New Size(69, 13)
        lblStartDate.TabIndex = 7
        lblStartDate.Text = "Start Date"
        ' 
        ' txtRegion
        ' 
        txtRegion.Font = New System.Drawing.Font("Gotham", 9F)
        txtRegion.Location = New Point(13, 141)
        txtRegion.Margin = New Padding(3, 2, 3, 2)
        txtRegion.Name = "txtRegion"
        txtRegion.ScrollBars = ScrollBars.Horizontal
        txtRegion.Size = New Size(210, 20)
        txtRegion.TabIndex = 6
        ' 
        ' lblRegion
        ' 
        lblRegion.AutoSize = True
        lblRegion.ForeColor = Color.White
        lblRegion.Location = New Point(13, 126)
        lblRegion.Name = "lblRegion"
        lblRegion.Size = New Size(49, 13)
        lblRegion.TabIndex = 5
        lblRegion.Text = "Region"
        ' 
        ' lblClientName
        ' 
        lblClientName.AutoSize = True
        lblClientName.ForeColor = Color.White
        lblClientName.Location = New Point(13, 74)
        lblClientName.Name = "lblClientName"
        lblClientName.Size = New Size(79, 13)
        lblClientName.TabIndex = 3
        lblClientName.Text = "Client Name"
        ' 
        ' txtRoleDesignation
        ' 
        txtRoleDesignation.Font = New System.Drawing.Font("Gotham", 9F)
        txtRoleDesignation.Location = New Point(13, 32)
        txtRoleDesignation.Margin = New Padding(3, 2, 3, 2)
        txtRoleDesignation.Multiline = True
        txtRoleDesignation.Name = "txtRoleDesignation"
        txtRoleDesignation.ScrollBars = ScrollBars.Both
        txtRoleDesignation.Size = New Size(210, 36)
        txtRoleDesignation.TabIndex = 2
        ' 
        ' lblRoleDesignation
        ' 
        lblRoleDesignation.AutoSize = True
        lblRoleDesignation.ForeColor = Color.White
        lblRoleDesignation.Location = New Point(13, 14)
        lblRoleDesignation.Name = "lblRoleDesignation"
        lblRoleDesignation.Size = New Size(110, 13)
        lblRoleDesignation.TabIndex = 1
        lblRoleDesignation.Text = "Role/Designation"
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(12, 428)
        btnAdd.Margin = New Padding(3, 2, 3, 2)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(211, 37)
        btnAdd.TabIndex = 17
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' txtStartDateJ
        ' 
        txtStartDateJ.Font = New System.Drawing.Font("Gotham", 9F)
        txtStartDateJ.Location = New Point(13, 178)
        txtStartDateJ.Margin = New Padding(3, 2, 3, 2)
        txtStartDateJ.Name = "txtStartDateJ"
        txtStartDateJ.ScrollBars = ScrollBars.Horizontal
        txtStartDateJ.Size = New Size(210, 20)
        txtStartDateJ.TabIndex = 22
        ' 
        ' txtEndDateJ
        ' 
        txtEndDateJ.Font = New System.Drawing.Font("Gotham", 9F)
        txtEndDateJ.Location = New Point(13, 218)
        txtEndDateJ.Margin = New Padding(3, 2, 3, 2)
        txtEndDateJ.Name = "txtEndDateJ"
        txtEndDateJ.ScrollBars = ScrollBars.Horizontal
        txtEndDateJ.Size = New Size(210, 20)
        txtEndDateJ.TabIndex = 23
        ' 
        ' JobHistoryDataGrid
        ' 
        JobHistoryDataGrid.AllowUserToAddRows = False
        JobHistoryDataGrid.AllowUserToDeleteRows = False
        JobHistoryDataGrid.AllowUserToOrderColumns = True
        JobHistoryDataGrid.AllowUserToResizeColumns = False
        JobHistoryDataGrid.AllowUserToResizeRows = False
        JobHistoryDataGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        JobHistoryDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        JobHistoryDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        JobHistoryDataGrid.BackgroundColor = SystemColors.ButtonHighlight
        JobHistoryDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        JobHistoryDataGrid.Location = New Point(230, 4)
        JobHistoryDataGrid.Margin = New Padding(3, 2, 3, 2)
        JobHistoryDataGrid.Name = "JobHistoryDataGrid"
        JobHistoryDataGrid.RowHeadersWidth = 51
        JobHistoryDataGrid.Size = New Size(652, 711)
        JobHistoryDataGrid.TabIndex = 0
        ' 
        ' TaskProfileTab
        ' 
        TaskProfileTab.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        TaskProfileTab.Controls.Add(btnCancelTP)
        TaskProfileTab.Controls.Add(btnClearTP)
        TaskProfileTab.Controls.Add(btnDeleteTP)
        TaskProfileTab.Controls.Add(btnSaveChangesTP)
        TaskProfileTab.Controls.Add(btnAddTP)
        TaskProfileTab.Controls.Add(txtDescription)
        TaskProfileTab.Controls.Add(lblDescription)
        TaskProfileTab.Controls.Add(txtPOC)
        TaskProfileTab.Controls.Add(lblPOC)
        TaskProfileTab.Controls.Add(txtCategory)
        TaskProfileTab.Controls.Add(lblCategory)
        TaskProfileTab.Controls.Add(txtTaskName)
        TaskProfileTab.Controls.Add(lblTaskProfile)
        TaskProfileTab.Controls.Add(TaskProfileDataGrid)
        TaskProfileTab.Font = New System.Drawing.Font("Gotham", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TaskProfileTab.Location = New Point(4, 67)
        TaskProfileTab.Margin = New Padding(3, 2, 3, 2)
        TaskProfileTab.Name = "TaskProfileTab"
        TaskProfileTab.Padding = New Padding(3, 2, 3, 2)
        TaskProfileTab.Size = New Size(884, 652)
        TaskProfileTab.TabIndex = 1
        TaskProfileTab.Text = "Task Profile"
        ' 
        ' btnCancelTP
        ' 
        btnCancelTP.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnCancelTP.FlatAppearance.BorderSize = 0
        btnCancelTP.FlatStyle = FlatStyle.Flat
        btnCancelTP.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnCancelTP.ForeColor = Color.White
        btnCancelTP.Location = New Point(12, 506)
        btnCancelTP.Margin = New Padding(3, 2, 3, 2)
        btnCancelTP.Name = "btnCancelTP"
        btnCancelTP.Size = New Size(210, 37)
        btnCancelTP.TabIndex = 23
        btnCancelTP.Text = "Cancel"
        btnCancelTP.UseVisualStyleBackColor = False
        btnCancelTP.Visible = False
        ' 
        ' btnClearTP
        ' 
        btnClearTP.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnClearTP.FlatAppearance.BorderSize = 0
        btnClearTP.FlatStyle = FlatStyle.Flat
        btnClearTP.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnClearTP.ForeColor = Color.White
        btnClearTP.Location = New Point(12, 464)
        btnClearTP.Margin = New Padding(3, 2, 3, 2)
        btnClearTP.Name = "btnClearTP"
        btnClearTP.Size = New Size(209, 37)
        btnClearTP.TabIndex = 21
        btnClearTP.Text = "Clear"
        btnClearTP.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteTP
        ' 
        btnDeleteTP.BackColor = Color.FromArgb(CByte(221), CByte(60), CByte(39))
        btnDeleteTP.FlatAppearance.BorderSize = 0
        btnDeleteTP.FlatStyle = FlatStyle.Flat
        btnDeleteTP.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnDeleteTP.ForeColor = Color.White
        btnDeleteTP.Location = New Point(121, 424)
        btnDeleteTP.Margin = New Padding(3, 2, 3, 2)
        btnDeleteTP.Name = "btnDeleteTP"
        btnDeleteTP.Size = New Size(102, 36)
        btnDeleteTP.TabIndex = 20
        btnDeleteTP.Text = "Delete"
        btnDeleteTP.UseVisualStyleBackColor = False
        btnDeleteTP.Visible = False
        ' 
        ' btnSaveChangesTP
        ' 
        btnSaveChangesTP.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnSaveChangesTP.FlatAppearance.BorderSize = 0
        btnSaveChangesTP.FlatStyle = FlatStyle.Flat
        btnSaveChangesTP.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnSaveChangesTP.ForeColor = Color.White
        btnSaveChangesTP.Location = New Point(12, 424)
        btnSaveChangesTP.Margin = New Padding(3, 2, 3, 2)
        btnSaveChangesTP.Name = "btnSaveChangesTP"
        btnSaveChangesTP.Size = New Size(102, 36)
        btnSaveChangesTP.TabIndex = 19
        btnSaveChangesTP.Text = "Save Changes"
        btnSaveChangesTP.UseVisualStyleBackColor = False
        btnSaveChangesTP.Visible = False
        ' 
        ' btnAddTP
        ' 
        btnAddTP.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnAddTP.FlatAppearance.BorderSize = 0
        btnAddTP.FlatStyle = FlatStyle.Flat
        btnAddTP.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnAddTP.ForeColor = Color.White
        btnAddTP.Location = New Point(12, 424)
        btnAddTP.Margin = New Padding(3, 2, 3, 2)
        btnAddTP.Name = "btnAddTP"
        btnAddTP.Size = New Size(209, 37)
        btnAddTP.TabIndex = 22
        btnAddTP.Text = "Add"
        btnAddTP.UseVisualStyleBackColor = False
        ' 
        ' txtDescription
        ' 
        txtDescription.Font = New System.Drawing.Font("Gotham", 9F)
        txtDescription.Location = New Point(13, 168)
        txtDescription.Margin = New Padding(3, 2, 3, 2)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.ScrollBars = ScrollBars.Both
        txtDescription.Size = New Size(210, 238)
        txtDescription.TabIndex = 9
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.ForeColor = Color.White
        lblDescription.Location = New Point(13, 150)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(75, 13)
        lblDescription.TabIndex = 8
        lblDescription.Text = "Description"
        ' 
        ' txtPOC
        ' 
        txtPOC.Font = New System.Drawing.Font("Gotham", 9F)
        txtPOC.Location = New Point(13, 119)
        txtPOC.Margin = New Padding(3, 2, 3, 2)
        txtPOC.Name = "txtPOC"
        txtPOC.ScrollBars = ScrollBars.Horizontal
        txtPOC.Size = New Size(210, 20)
        txtPOC.TabIndex = 7
        ' 
        ' lblPOC
        ' 
        lblPOC.AutoSize = True
        lblPOC.ForeColor = Color.White
        lblPOC.Location = New Point(13, 104)
        lblPOC.Name = "lblPOC"
        lblPOC.Size = New Size(34, 13)
        lblPOC.TabIndex = 6
        lblPOC.Text = "POC"
        ' 
        ' txtCategory
        ' 
        txtCategory.Font = New System.Drawing.Font("Gotham", 9F)
        txtCategory.Location = New Point(13, 76)
        txtCategory.Margin = New Padding(3, 2, 3, 2)
        txtCategory.Name = "txtCategory"
        txtCategory.ScrollBars = ScrollBars.Horizontal
        txtCategory.Size = New Size(210, 20)
        txtCategory.TabIndex = 5
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.ForeColor = Color.White
        lblCategory.Location = New Point(13, 62)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(63, 13)
        lblCategory.TabIndex = 4
        lblCategory.Text = "Category"
        ' 
        ' txtTaskName
        ' 
        txtTaskName.Font = New System.Drawing.Font("Gotham", 9F)
        txtTaskName.Location = New Point(13, 32)
        txtTaskName.Margin = New Padding(3, 2, 3, 2)
        txtTaskName.Name = "txtTaskName"
        txtTaskName.ScrollBars = ScrollBars.Horizontal
        txtTaskName.Size = New Size(210, 20)
        txtTaskName.TabIndex = 3
        ' 
        ' lblTaskProfile
        ' 
        lblTaskProfile.AutoSize = True
        lblTaskProfile.ForeColor = Color.White
        lblTaskProfile.Location = New Point(13, 14)
        lblTaskProfile.Name = "lblTaskProfile"
        lblTaskProfile.Size = New Size(73, 13)
        lblTaskProfile.TabIndex = 2
        lblTaskProfile.Text = "Task Name"
        ' 
        ' TaskProfileDataGrid
        ' 
        TaskProfileDataGrid.AllowUserToAddRows = False
        TaskProfileDataGrid.AllowUserToDeleteRows = False
        TaskProfileDataGrid.AllowUserToOrderColumns = True
        TaskProfileDataGrid.AllowUserToResizeColumns = False
        TaskProfileDataGrid.AllowUserToResizeRows = False
        TaskProfileDataGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TaskProfileDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        TaskProfileDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        TaskProfileDataGrid.BackgroundColor = SystemColors.ButtonHighlight
        TaskProfileDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TaskProfileDataGrid.GridColor = Color.Black
        TaskProfileDataGrid.Location = New Point(230, 4)
        TaskProfileDataGrid.Margin = New Padding(3, 2, 3, 2)
        TaskProfileDataGrid.Name = "TaskProfileDataGrid"
        TaskProfileDataGrid.RowHeadersWidth = 51
        TaskProfileDataGrid.Size = New Size(652, 711)
        TaskProfileDataGrid.TabIndex = 1
        ' 
        ' SoftwareAndToolsTab
        ' 
        SoftwareAndToolsTab.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        SoftwareAndToolsTab.Controls.Add(btnDeleteST)
        SoftwareAndToolsTab.Controls.Add(btnSaveChangesST)
        SoftwareAndToolsTab.Controls.Add(btnAddST)
        SoftwareAndToolsTab.Controls.Add(btnCancelST)
        SoftwareAndToolsTab.Controls.Add(btnClearST)
        SoftwareAndToolsTab.Controls.Add(lblUsedFor)
        SoftwareAndToolsTab.Controls.Add(txtUsedFor)
        SoftwareAndToolsTab.Controls.Add(lblSoftwareOrTools)
        SoftwareAndToolsTab.Controls.Add(txtSoftwareOrTools)
        SoftwareAndToolsTab.Controls.Add(SoftwareAndToolsDataGrid)
        SoftwareAndToolsTab.Font = New System.Drawing.Font("Gotham", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SoftwareAndToolsTab.ForeColor = Color.Black
        SoftwareAndToolsTab.Location = New Point(4, 67)
        SoftwareAndToolsTab.Margin = New Padding(3, 2, 3, 2)
        SoftwareAndToolsTab.Name = "SoftwareAndToolsTab"
        SoftwareAndToolsTab.Size = New Size(884, 652)
        SoftwareAndToolsTab.TabIndex = 2
        SoftwareAndToolsTab.Text = "Software & Tools"
        ' 
        ' btnDeleteST
        ' 
        btnDeleteST.BackColor = Color.FromArgb(CByte(221), CByte(60), CByte(39))
        btnDeleteST.FlatAppearance.BorderSize = 0
        btnDeleteST.FlatStyle = FlatStyle.Flat
        btnDeleteST.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnDeleteST.ForeColor = Color.White
        btnDeleteST.Location = New Point(121, 423)
        btnDeleteST.Margin = New Padding(3, 2, 3, 2)
        btnDeleteST.Name = "btnDeleteST"
        btnDeleteST.Size = New Size(102, 37)
        btnDeleteST.TabIndex = 11
        btnDeleteST.Text = "Delete"
        btnDeleteST.UseVisualStyleBackColor = False
        btnDeleteST.Visible = False
        ' 
        ' btnSaveChangesST
        ' 
        btnSaveChangesST.BackColor = Color.FromArgb(CByte(236), CByte(206), CByte(0))
        btnSaveChangesST.FlatAppearance.BorderSize = 0
        btnSaveChangesST.FlatStyle = FlatStyle.Flat
        btnSaveChangesST.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnSaveChangesST.ForeColor = Color.White
        btnSaveChangesST.Location = New Point(13, 423)
        btnSaveChangesST.Margin = New Padding(3, 2, 3, 2)
        btnSaveChangesST.Name = "btnSaveChangesST"
        btnSaveChangesST.Size = New Size(102, 37)
        btnSaveChangesST.TabIndex = 10
        btnSaveChangesST.Text = "Save Changes"
        btnSaveChangesST.UseVisualStyleBackColor = False
        btnSaveChangesST.Visible = False
        ' 
        ' btnAddST
        ' 
        btnAddST.BackColor = Color.FromArgb(CByte(236), CByte(206), CByte(0))
        btnAddST.FlatAppearance.BorderSize = 0
        btnAddST.FlatStyle = FlatStyle.Flat
        btnAddST.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnAddST.ForeColor = Color.White
        btnAddST.Location = New Point(13, 423)
        btnAddST.Margin = New Padding(3, 2, 3, 2)
        btnAddST.Name = "btnAddST"
        btnAddST.Size = New Size(209, 37)
        btnAddST.TabIndex = 9
        btnAddST.Text = "Add"
        btnAddST.UseVisualStyleBackColor = False
        ' 
        ' btnCancelST
        ' 
        btnCancelST.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnCancelST.FlatAppearance.BorderSize = 0
        btnCancelST.FlatStyle = FlatStyle.Flat
        btnCancelST.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnCancelST.ForeColor = Color.White
        btnCancelST.Location = New Point(13, 506)
        btnCancelST.Margin = New Padding(3, 2, 3, 2)
        btnCancelST.Name = "btnCancelST"
        btnCancelST.Size = New Size(209, 37)
        btnCancelST.TabIndex = 8
        btnCancelST.Text = "Cancel"
        btnCancelST.UseVisualStyleBackColor = False
        btnCancelST.Visible = False
        ' 
        ' btnClearST
        ' 
        btnClearST.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnClearST.FlatAppearance.BorderSize = 0
        btnClearST.FlatStyle = FlatStyle.Flat
        btnClearST.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnClearST.ForeColor = Color.White
        btnClearST.Location = New Point(13, 465)
        btnClearST.Margin = New Padding(3, 2, 3, 2)
        btnClearST.Name = "btnClearST"
        btnClearST.Size = New Size(209, 37)
        btnClearST.TabIndex = 7
        btnClearST.Text = "Clear"
        btnClearST.UseVisualStyleBackColor = False
        ' 
        ' lblUsedFor
        ' 
        lblUsedFor.AutoSize = True
        lblUsedFor.ForeColor = Color.White
        lblUsedFor.Location = New Point(13, 58)
        lblUsedFor.Name = "lblUsedFor"
        lblUsedFor.Size = New Size(62, 13)
        lblUsedFor.TabIndex = 6
        lblUsedFor.Text = "Used For"
        ' 
        ' txtUsedFor
        ' 
        txtUsedFor.Font = New System.Drawing.Font("Gotham", 9F)
        txtUsedFor.Location = New Point(13, 73)
        txtUsedFor.Margin = New Padding(3, 2, 3, 2)
        txtUsedFor.Multiline = True
        txtUsedFor.Name = "txtUsedFor"
        txtUsedFor.ScrollBars = ScrollBars.Both
        txtUsedFor.Size = New Size(210, 342)
        txtUsedFor.TabIndex = 5
        ' 
        ' lblSoftwareOrTools
        ' 
        lblSoftwareOrTools.AutoSize = True
        lblSoftwareOrTools.ForeColor = Color.White
        lblSoftwareOrTools.Location = New Point(13, 14)
        lblSoftwareOrTools.Name = "lblSoftwareOrTools"
        lblSoftwareOrTools.Size = New Size(100, 13)
        lblSoftwareOrTools.TabIndex = 4
        lblSoftwareOrTools.Text = "Software/Tools"
        ' 
        ' txtSoftwareOrTools
        ' 
        txtSoftwareOrTools.Font = New System.Drawing.Font("Gotham", 9F)
        txtSoftwareOrTools.Location = New Point(13, 32)
        txtSoftwareOrTools.Margin = New Padding(3, 2, 3, 2)
        txtSoftwareOrTools.Name = "txtSoftwareOrTools"
        txtSoftwareOrTools.ScrollBars = ScrollBars.Horizontal
        txtSoftwareOrTools.Size = New Size(210, 20)
        txtSoftwareOrTools.TabIndex = 3
        ' 
        ' SoftwareAndToolsDataGrid
        ' 
        SoftwareAndToolsDataGrid.AllowUserToAddRows = False
        SoftwareAndToolsDataGrid.AllowUserToDeleteRows = False
        SoftwareAndToolsDataGrid.AllowUserToOrderColumns = True
        SoftwareAndToolsDataGrid.AllowUserToResizeColumns = False
        SoftwareAndToolsDataGrid.AllowUserToResizeRows = False
        SoftwareAndToolsDataGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        SoftwareAndToolsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        SoftwareAndToolsDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        SoftwareAndToolsDataGrid.BackgroundColor = SystemColors.ButtonHighlight
        SoftwareAndToolsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        SoftwareAndToolsDataGrid.Location = New Point(230, 4)
        SoftwareAndToolsDataGrid.Margin = New Padding(3, 2, 3, 2)
        SoftwareAndToolsDataGrid.Name = "SoftwareAndToolsDataGrid"
        SoftwareAndToolsDataGrid.RowHeadersWidth = 51
        SoftwareAndToolsDataGrid.Size = New Size(652, 711)
        SoftwareAndToolsDataGrid.TabIndex = 2
        ' 
        ' SkillsInterviewTab
        ' 
        SkillsInterviewTab.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        SkillsInterviewTab.Controls.Add(btnDeleteSI)
        SkillsInterviewTab.Controls.Add(btnSaveChangesSI)
        SkillsInterviewTab.Controls.Add(btnCancelSI)
        SkillsInterviewTab.Controls.Add(txtAssessmentNotes)
        SkillsInterviewTab.Controls.Add(btnAddSI)
        SkillsInterviewTab.Controls.Add(lblAssessmentNotes)
        SkillsInterviewTab.Controls.Add(txtInterviewer)
        SkillsInterviewTab.Controls.Add(lblInterviewer)
        SkillsInterviewTab.Controls.Add(lblDate)
        SkillsInterviewTab.Controls.Add(txtRoleOrDesignation)
        SkillsInterviewTab.Controls.Add(lblRoleOrDesignation)
        SkillsInterviewTab.Controls.Add(btnClearSI)
        SkillsInterviewTab.Controls.Add(SkillsInterviewDataGrid)
        SkillsInterviewTab.Controls.Add(dtpckerDate)
        SkillsInterviewTab.Font = New System.Drawing.Font("Gotham", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SkillsInterviewTab.ForeColor = Color.Black
        SkillsInterviewTab.Location = New Point(4, 67)
        SkillsInterviewTab.Margin = New Padding(3, 2, 3, 2)
        SkillsInterviewTab.Name = "SkillsInterviewTab"
        SkillsInterviewTab.Size = New Size(884, 652)
        SkillsInterviewTab.TabIndex = 3
        SkillsInterviewTab.Text = "Skills Interview"
        ' 
        ' btnDeleteSI
        ' 
        btnDeleteSI.BackColor = Color.FromArgb(CByte(221), CByte(60), CByte(39))
        btnDeleteSI.FlatAppearance.BorderSize = 0
        btnDeleteSI.FlatStyle = FlatStyle.Flat
        btnDeleteSI.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnDeleteSI.ForeColor = Color.White
        btnDeleteSI.Location = New Point(121, 419)
        btnDeleteSI.Margin = New Padding(3, 2, 3, 2)
        btnDeleteSI.Name = "btnDeleteSI"
        btnDeleteSI.Size = New Size(102, 36)
        btnDeleteSI.TabIndex = 29
        btnDeleteSI.Text = "Delete"
        btnDeleteSI.UseVisualStyleBackColor = False
        btnDeleteSI.Visible = False
        ' 
        ' btnSaveChangesSI
        ' 
        btnSaveChangesSI.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnSaveChangesSI.FlatAppearance.BorderSize = 0
        btnSaveChangesSI.FlatStyle = FlatStyle.Flat
        btnSaveChangesSI.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnSaveChangesSI.ForeColor = Color.White
        btnSaveChangesSI.Location = New Point(13, 419)
        btnSaveChangesSI.Margin = New Padding(3, 2, 3, 2)
        btnSaveChangesSI.Name = "btnSaveChangesSI"
        btnSaveChangesSI.Size = New Size(102, 36)
        btnSaveChangesSI.TabIndex = 28
        btnSaveChangesSI.Text = "Save Changes"
        btnSaveChangesSI.UseVisualStyleBackColor = False
        btnSaveChangesSI.Visible = False
        ' 
        ' btnCancelSI
        ' 
        btnCancelSI.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnCancelSI.FlatAppearance.BorderSize = 0
        btnCancelSI.FlatStyle = FlatStyle.Flat
        btnCancelSI.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnCancelSI.ForeColor = Color.White
        btnCancelSI.Location = New Point(13, 502)
        btnCancelSI.Margin = New Padding(3, 2, 3, 2)
        btnCancelSI.Name = "btnCancelSI"
        btnCancelSI.Size = New Size(209, 37)
        btnCancelSI.TabIndex = 26
        btnCancelSI.Text = "Cancel"
        btnCancelSI.UseVisualStyleBackColor = False
        btnCancelSI.Visible = False
        ' 
        ' txtAssessmentNotes
        ' 
        txtAssessmentNotes.Font = New System.Drawing.Font("Gotham", 9F)
        txtAssessmentNotes.Location = New Point(13, 177)
        txtAssessmentNotes.Margin = New Padding(3, 2, 3, 2)
        txtAssessmentNotes.Multiline = True
        txtAssessmentNotes.Name = "txtAssessmentNotes"
        txtAssessmentNotes.ScrollBars = ScrollBars.Both
        txtAssessmentNotes.Size = New Size(210, 239)
        txtAssessmentNotes.TabIndex = 25
        ' 
        ' btnAddSI
        ' 
        btnAddSI.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnAddSI.FlatAppearance.BorderSize = 0
        btnAddSI.FlatStyle = FlatStyle.Flat
        btnAddSI.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnAddSI.ForeColor = Color.White
        btnAddSI.Location = New Point(13, 419)
        btnAddSI.Margin = New Padding(3, 2, 3, 2)
        btnAddSI.Name = "btnAddSI"
        btnAddSI.Size = New Size(209, 37)
        btnAddSI.TabIndex = 24
        btnAddSI.Text = "Add"
        btnAddSI.UseVisualStyleBackColor = False
        ' 
        ' lblAssessmentNotes
        ' 
        lblAssessmentNotes.AutoSize = True
        lblAssessmentNotes.ForeColor = Color.White
        lblAssessmentNotes.Location = New Point(13, 160)
        lblAssessmentNotes.Name = "lblAssessmentNotes"
        lblAssessmentNotes.Size = New Size(116, 13)
        lblAssessmentNotes.TabIndex = 23
        lblAssessmentNotes.Text = "Assessment Notes"
        ' 
        ' txtInterviewer
        ' 
        txtInterviewer.Font = New System.Drawing.Font("Gotham", 9F)
        txtInterviewer.Location = New Point(13, 119)
        txtInterviewer.Margin = New Padding(3, 2, 3, 2)
        txtInterviewer.Name = "txtInterviewer"
        txtInterviewer.ScrollBars = ScrollBars.Horizontal
        txtInterviewer.Size = New Size(210, 20)
        txtInterviewer.TabIndex = 22
        ' 
        ' lblInterviewer
        ' 
        lblInterviewer.AutoSize = True
        lblInterviewer.ForeColor = Color.White
        lblInterviewer.Location = New Point(13, 106)
        lblInterviewer.Name = "lblInterviewer"
        lblInterviewer.Size = New Size(73, 13)
        lblInterviewer.TabIndex = 21
        lblInterviewer.Text = "Interviewer"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.ForeColor = Color.White
        lblDate.Location = New Point(13, 56)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(35, 13)
        lblDate.TabIndex = 6
        lblDate.Text = "Date"
        ' 
        ' txtRoleOrDesignation
        ' 
        txtRoleOrDesignation.Font = New System.Drawing.Font("Gotham", 9F)
        txtRoleOrDesignation.Location = New Point(13, 32)
        txtRoleOrDesignation.Margin = New Padding(3, 2, 3, 2)
        txtRoleOrDesignation.Name = "txtRoleOrDesignation"
        txtRoleOrDesignation.ScrollBars = ScrollBars.Horizontal
        txtRoleOrDesignation.Size = New Size(210, 20)
        txtRoleOrDesignation.TabIndex = 5
        ' 
        ' lblRoleOrDesignation
        ' 
        lblRoleOrDesignation.AutoSize = True
        lblRoleOrDesignation.ForeColor = Color.White
        lblRoleOrDesignation.Location = New Point(13, 8)
        lblRoleOrDesignation.Name = "lblRoleOrDesignation"
        lblRoleOrDesignation.Size = New Size(110, 13)
        lblRoleOrDesignation.TabIndex = 4
        lblRoleOrDesignation.Text = "Role/Designation"
        ' 
        ' btnClearSI
        ' 
        btnClearSI.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnClearSI.FlatAppearance.BorderSize = 0
        btnClearSI.FlatStyle = FlatStyle.Flat
        btnClearSI.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnClearSI.ForeColor = Color.White
        btnClearSI.Location = New Point(13, 461)
        btnClearSI.Margin = New Padding(3, 2, 3, 2)
        btnClearSI.Name = "btnClearSI"
        btnClearSI.Size = New Size(209, 37)
        btnClearSI.TabIndex = 27
        btnClearSI.Text = "Clear"
        btnClearSI.UseVisualStyleBackColor = False
        ' 
        ' SkillsInterviewDataGrid
        ' 
        SkillsInterviewDataGrid.AllowUserToAddRows = False
        SkillsInterviewDataGrid.AllowUserToDeleteRows = False
        SkillsInterviewDataGrid.AllowUserToOrderColumns = True
        SkillsInterviewDataGrid.AllowUserToResizeColumns = False
        SkillsInterviewDataGrid.AllowUserToResizeRows = False
        SkillsInterviewDataGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        SkillsInterviewDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        SkillsInterviewDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        SkillsInterviewDataGrid.BackgroundColor = SystemColors.ButtonHighlight
        SkillsInterviewDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        SkillsInterviewDataGrid.Location = New Point(230, 4)
        SkillsInterviewDataGrid.Margin = New Padding(3, 2, 3, 2)
        SkillsInterviewDataGrid.Name = "SkillsInterviewDataGrid"
        SkillsInterviewDataGrid.RowHeadersWidth = 51
        SkillsInterviewDataGrid.Size = New Size(652, 711)
        SkillsInterviewDataGrid.TabIndex = 3
        ' 
        ' dtpckerDate
        ' 
        dtpckerDate.Font = New System.Drawing.Font("Gotham", 9F)
        dtpckerDate.Location = New Point(13, 72)
        dtpckerDate.Margin = New Padding(3, 2, 3, 2)
        dtpckerDate.Name = "dtpckerDate"
        dtpckerDate.ScrollBars = ScrollBars.Horizontal
        dtpckerDate.Size = New Size(210, 20)
        dtpckerDate.TabIndex = 30
        ' 
        ' PerformanceEvaluationTab
        ' 
        PerformanceEvaluationTab.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        PerformanceEvaluationTab.Controls.Add(btnDeletePE)
        PerformanceEvaluationTab.Controls.Add(btnSaveChangesPE)
        PerformanceEvaluationTab.Controls.Add(btnCancelPE)
        PerformanceEvaluationTab.Controls.Add(btnClearPE)
        PerformanceEvaluationTab.Controls.Add(btnAddPE)
        PerformanceEvaluationTab.Controls.Add(txtEvaluationNotes)
        PerformanceEvaluationTab.Controls.Add(lblEvaluationNotes)
        PerformanceEvaluationTab.Controls.Add(txtEvaluator)
        PerformanceEvaluationTab.Controls.Add(lblEvaluator)
        PerformanceEvaluationTab.Controls.Add(lblEvaluationDate)
        PerformanceEvaluationTab.Controls.Add(txtEvaluationType)
        PerformanceEvaluationTab.Controls.Add(lblEvaluationType)
        PerformanceEvaluationTab.Controls.Add(PerformanceEvaluationDataGrid)
        PerformanceEvaluationTab.Controls.Add(dtpckerEvalutionDate)
        PerformanceEvaluationTab.Font = New System.Drawing.Font("Gotham", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PerformanceEvaluationTab.ForeColor = Color.Black
        PerformanceEvaluationTab.Location = New Point(4, 67)
        PerformanceEvaluationTab.Margin = New Padding(3, 2, 3, 2)
        PerformanceEvaluationTab.Name = "PerformanceEvaluationTab"
        PerformanceEvaluationTab.Size = New Size(884, 652)
        PerformanceEvaluationTab.TabIndex = 4
        PerformanceEvaluationTab.Text = "Performance Evaluation"
        ' 
        ' btnDeletePE
        ' 
        btnDeletePE.BackColor = Color.FromArgb(CByte(221), CByte(60), CByte(39))
        btnDeletePE.FlatAppearance.BorderSize = 0
        btnDeletePE.FlatStyle = FlatStyle.Flat
        btnDeletePE.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnDeletePE.ForeColor = Color.White
        btnDeletePE.Location = New Point(121, 419)
        btnDeletePE.Margin = New Padding(3, 2, 3, 2)
        btnDeletePE.Name = "btnDeletePE"
        btnDeletePE.Size = New Size(102, 36)
        btnDeletePE.TabIndex = 32
        btnDeletePE.Text = "Delete"
        btnDeletePE.UseVisualStyleBackColor = False
        btnDeletePE.Visible = False
        ' 
        ' btnSaveChangesPE
        ' 
        btnSaveChangesPE.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnSaveChangesPE.FlatAppearance.BorderSize = 0
        btnSaveChangesPE.FlatStyle = FlatStyle.Flat
        btnSaveChangesPE.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnSaveChangesPE.ForeColor = Color.White
        btnSaveChangesPE.Location = New Point(13, 419)
        btnSaveChangesPE.Margin = New Padding(3, 2, 3, 2)
        btnSaveChangesPE.Name = "btnSaveChangesPE"
        btnSaveChangesPE.Size = New Size(102, 36)
        btnSaveChangesPE.TabIndex = 31
        btnSaveChangesPE.Text = "Save Changes"
        btnSaveChangesPE.UseVisualStyleBackColor = False
        btnSaveChangesPE.Visible = False
        ' 
        ' btnCancelPE
        ' 
        btnCancelPE.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnCancelPE.FlatAppearance.BorderSize = 0
        btnCancelPE.FlatStyle = FlatStyle.Flat
        btnCancelPE.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnCancelPE.ForeColor = Color.White
        btnCancelPE.Location = New Point(13, 502)
        btnCancelPE.Margin = New Padding(3, 2, 3, 2)
        btnCancelPE.Name = "btnCancelPE"
        btnCancelPE.Size = New Size(209, 37)
        btnCancelPE.TabIndex = 30
        btnCancelPE.Text = "Cancel"
        btnCancelPE.UseVisualStyleBackColor = False
        btnCancelPE.Visible = False
        ' 
        ' btnClearPE
        ' 
        btnClearPE.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnClearPE.FlatAppearance.BorderSize = 0
        btnClearPE.FlatStyle = FlatStyle.Flat
        btnClearPE.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnClearPE.ForeColor = Color.White
        btnClearPE.Location = New Point(13, 461)
        btnClearPE.Margin = New Padding(3, 2, 3, 2)
        btnClearPE.Name = "btnClearPE"
        btnClearPE.Size = New Size(209, 37)
        btnClearPE.TabIndex = 29
        btnClearPE.Text = "Clear"
        btnClearPE.UseVisualStyleBackColor = False
        ' 
        ' btnAddPE
        ' 
        btnAddPE.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnAddPE.FlatAppearance.BorderSize = 0
        btnAddPE.FlatStyle = FlatStyle.Flat
        btnAddPE.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnAddPE.ForeColor = Color.White
        btnAddPE.Location = New Point(13, 419)
        btnAddPE.Margin = New Padding(3, 2, 3, 2)
        btnAddPE.Name = "btnAddPE"
        btnAddPE.Size = New Size(209, 37)
        btnAddPE.TabIndex = 28
        btnAddPE.Text = "Add"
        btnAddPE.UseVisualStyleBackColor = False
        ' 
        ' txtEvaluationNotes
        ' 
        txtEvaluationNotes.Font = New System.Drawing.Font("Gotham", 9F)
        txtEvaluationNotes.Location = New Point(13, 176)
        txtEvaluationNotes.Margin = New Padding(3, 2, 3, 2)
        txtEvaluationNotes.Multiline = True
        txtEvaluationNotes.Name = "txtEvaluationNotes"
        txtEvaluationNotes.ScrollBars = ScrollBars.Both
        txtEvaluationNotes.Size = New Size(210, 239)
        txtEvaluationNotes.TabIndex = 27
        ' 
        ' lblEvaluationNotes
        ' 
        lblEvaluationNotes.AutoSize = True
        lblEvaluationNotes.ForeColor = Color.White
        lblEvaluationNotes.Location = New Point(13, 160)
        lblEvaluationNotes.Name = "lblEvaluationNotes"
        lblEvaluationNotes.Size = New Size(108, 13)
        lblEvaluationNotes.TabIndex = 26
        lblEvaluationNotes.Text = "Evaluation Notes"
        ' 
        ' txtEvaluator
        ' 
        txtEvaluator.Font = New System.Drawing.Font("Gotham", 9F)
        txtEvaluator.Location = New Point(13, 123)
        txtEvaluator.Margin = New Padding(3, 2, 3, 2)
        txtEvaluator.Name = "txtEvaluator"
        txtEvaluator.ScrollBars = ScrollBars.Horizontal
        txtEvaluator.Size = New Size(210, 20)
        txtEvaluator.TabIndex = 24
        ' 
        ' lblEvaluator
        ' 
        lblEvaluator.AutoSize = True
        lblEvaluator.ForeColor = Color.White
        lblEvaluator.Location = New Point(13, 106)
        lblEvaluator.Name = "lblEvaluator"
        lblEvaluator.Size = New Size(64, 13)
        lblEvaluator.TabIndex = 23
        lblEvaluator.Text = "Evaluator"
        ' 
        ' lblEvaluationDate
        ' 
        lblEvaluationDate.AutoSize = True
        lblEvaluationDate.ForeColor = Color.White
        lblEvaluationDate.Location = New Point(13, 56)
        lblEvaluationDate.Name = "lblEvaluationDate"
        lblEvaluationDate.Size = New Size(101, 13)
        lblEvaluationDate.TabIndex = 21
        lblEvaluationDate.Text = "Evaluation Date"
        ' 
        ' txtEvaluationType
        ' 
        txtEvaluationType.Font = New System.Drawing.Font("Gotham", 9F)
        txtEvaluationType.Location = New Point(13, 25)
        txtEvaluationType.Margin = New Padding(3, 2, 3, 2)
        txtEvaluationType.Name = "txtEvaluationType"
        txtEvaluationType.ScrollBars = ScrollBars.Horizontal
        txtEvaluationType.Size = New Size(210, 20)
        txtEvaluationType.TabIndex = 6
        ' 
        ' lblEvaluationType
        ' 
        lblEvaluationType.AutoSize = True
        lblEvaluationType.ForeColor = Color.White
        lblEvaluationType.Location = New Point(13, 8)
        lblEvaluationType.Name = "lblEvaluationType"
        lblEvaluationType.Size = New Size(103, 13)
        lblEvaluationType.TabIndex = 5
        lblEvaluationType.Text = "Evaluation Type"
        ' 
        ' PerformanceEvaluationDataGrid
        ' 
        PerformanceEvaluationDataGrid.AllowUserToAddRows = False
        PerformanceEvaluationDataGrid.AllowUserToDeleteRows = False
        PerformanceEvaluationDataGrid.AllowUserToOrderColumns = True
        PerformanceEvaluationDataGrid.AllowUserToResizeColumns = False
        PerformanceEvaluationDataGrid.AllowUserToResizeRows = False
        PerformanceEvaluationDataGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PerformanceEvaluationDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        PerformanceEvaluationDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        PerformanceEvaluationDataGrid.BackgroundColor = SystemColors.ButtonHighlight
        PerformanceEvaluationDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        PerformanceEvaluationDataGrid.Location = New Point(230, 4)
        PerformanceEvaluationDataGrid.Margin = New Padding(3, 2, 3, 2)
        PerformanceEvaluationDataGrid.Name = "PerformanceEvaluationDataGrid"
        PerformanceEvaluationDataGrid.RowHeadersWidth = 51
        PerformanceEvaluationDataGrid.Size = New Size(652, 711)
        PerformanceEvaluationDataGrid.TabIndex = 4
        ' 
        ' dtpckerEvalutionDate
        ' 
        dtpckerEvalutionDate.Font = New System.Drawing.Font("Gotham", 9F)
        dtpckerEvalutionDate.Location = New Point(13, 73)
        dtpckerEvalutionDate.Margin = New Padding(3, 2, 3, 2)
        dtpckerEvalutionDate.Name = "dtpckerEvalutionDate"
        dtpckerEvalutionDate.ScrollBars = ScrollBars.Horizontal
        dtpckerEvalutionDate.Size = New Size(210, 20)
        dtpckerEvalutionDate.TabIndex = 33
        ' 
        ' SkillsTriageTab
        ' 
        SkillsTriageTab.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        SkillsTriageTab.Controls.Add(txtDeliberationScore)
        SkillsTriageTab.Controls.Add(lblDeliberationScore)
        SkillsTriageTab.Controls.Add(txtDeliberationNotes)
        SkillsTriageTab.Controls.Add(lblDeliberationNotes)
        SkillsTriageTab.Controls.Add(btnDeleteT)
        SkillsTriageTab.Controls.Add(btnSaveChangesT)
        SkillsTriageTab.Controls.Add(btnClearT)
        SkillsTriageTab.Controls.Add(btnCancelT)
        SkillsTriageTab.Controls.Add(btnAddT)
        SkillsTriageTab.Controls.Add(txtDetailsOfConcern)
        SkillsTriageTab.Controls.Add(lblDetailsOfConcern)
        SkillsTriageTab.Controls.Add(lblDateClose)
        SkillsTriageTab.Controls.Add(lblStartDateT)
        SkillsTriageTab.Controls.Add(txtConcernBy)
        SkillsTriageTab.Controls.Add(lblConcernBy)
        SkillsTriageTab.Controls.Add(SkillsTriageDataGrid)
        SkillsTriageTab.Controls.Add(dtpckerStartDateT)
        SkillsTriageTab.Controls.Add(dtpckerDateClose)
        SkillsTriageTab.Font = New System.Drawing.Font("Gotham", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SkillsTriageTab.ForeColor = Color.Black
        SkillsTriageTab.Location = New Point(4, 67)
        SkillsTriageTab.Margin = New Padding(3, 2, 3, 2)
        SkillsTriageTab.Name = "SkillsTriageTab"
        SkillsTriageTab.Size = New Size(884, 652)
        SkillsTriageTab.TabIndex = 5
        SkillsTriageTab.Text = "Skills Triage"
        ' 
        ' txtDeliberationScore
        ' 
        txtDeliberationScore.Font = New System.Drawing.Font("Gotham", 9F)
        txtDeliberationScore.Location = New Point(13, 263)
        txtDeliberationScore.Margin = New Padding(3, 2, 3, 2)
        txtDeliberationScore.Name = "txtDeliberationScore"
        txtDeliberationScore.ScrollBars = ScrollBars.Horizontal
        txtDeliberationScore.Size = New Size(210, 20)
        txtDeliberationScore.TabIndex = 35
        ' 
        ' lblDeliberationScore
        ' 
        lblDeliberationScore.AutoSize = True
        lblDeliberationScore.ForeColor = Color.White
        lblDeliberationScore.Location = New Point(13, 247)
        lblDeliberationScore.Name = "lblDeliberationScore"
        lblDeliberationScore.Size = New Size(118, 13)
        lblDeliberationScore.TabIndex = 34
        lblDeliberationScore.Text = "Deliberation Score"
        ' 
        ' txtDeliberationNotes
        ' 
        txtDeliberationNotes.Font = New System.Drawing.Font("Gotham", 9F)
        txtDeliberationNotes.Location = New Point(13, 308)
        txtDeliberationNotes.Margin = New Padding(3, 2, 3, 2)
        txtDeliberationNotes.Multiline = True
        txtDeliberationNotes.Name = "txtDeliberationNotes"
        txtDeliberationNotes.ScrollBars = ScrollBars.Both
        txtDeliberationNotes.Size = New Size(210, 107)
        txtDeliberationNotes.TabIndex = 33
        ' 
        ' lblDeliberationNotes
        ' 
        lblDeliberationNotes.AutoSize = True
        lblDeliberationNotes.ForeColor = Color.White
        lblDeliberationNotes.Location = New Point(13, 292)
        lblDeliberationNotes.Name = "lblDeliberationNotes"
        lblDeliberationNotes.Size = New Size(118, 13)
        lblDeliberationNotes.TabIndex = 32
        lblDeliberationNotes.Text = "Deliberation Notes"
        ' 
        ' btnDeleteT
        ' 
        btnDeleteT.BackColor = Color.FromArgb(CByte(221), CByte(60), CByte(39))
        btnDeleteT.FlatAppearance.BorderSize = 0
        btnDeleteT.FlatStyle = FlatStyle.Flat
        btnDeleteT.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnDeleteT.ForeColor = Color.White
        btnDeleteT.Location = New Point(121, 419)
        btnDeleteT.Margin = New Padding(3, 2, 3, 2)
        btnDeleteT.Name = "btnDeleteT"
        btnDeleteT.Size = New Size(102, 36)
        btnDeleteT.TabIndex = 31
        btnDeleteT.Text = "Delete"
        btnDeleteT.UseVisualStyleBackColor = False
        btnDeleteT.Visible = False
        ' 
        ' btnSaveChangesT
        ' 
        btnSaveChangesT.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnSaveChangesT.FlatAppearance.BorderSize = 0
        btnSaveChangesT.FlatStyle = FlatStyle.Flat
        btnSaveChangesT.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnSaveChangesT.ForeColor = Color.White
        btnSaveChangesT.Location = New Point(13, 419)
        btnSaveChangesT.Margin = New Padding(3, 2, 3, 2)
        btnSaveChangesT.Name = "btnSaveChangesT"
        btnSaveChangesT.Size = New Size(102, 36)
        btnSaveChangesT.TabIndex = 30
        btnSaveChangesT.Text = "Save Changes"
        btnSaveChangesT.UseVisualStyleBackColor = False
        btnSaveChangesT.Visible = False
        ' 
        ' btnClearT
        ' 
        btnClearT.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnClearT.FlatAppearance.BorderSize = 0
        btnClearT.FlatStyle = FlatStyle.Flat
        btnClearT.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnClearT.ForeColor = Color.White
        btnClearT.Location = New Point(13, 461)
        btnClearT.Margin = New Padding(3, 2, 3, 2)
        btnClearT.Name = "btnClearT"
        btnClearT.Size = New Size(209, 37)
        btnClearT.TabIndex = 29
        btnClearT.Text = "Clear"
        btnClearT.UseVisualStyleBackColor = False
        ' 
        ' btnCancelT
        ' 
        btnCancelT.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnCancelT.FlatAppearance.BorderSize = 0
        btnCancelT.FlatStyle = FlatStyle.Flat
        btnCancelT.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnCancelT.ForeColor = Color.White
        btnCancelT.Location = New Point(13, 502)
        btnCancelT.Margin = New Padding(3, 2, 3, 2)
        btnCancelT.Name = "btnCancelT"
        btnCancelT.Size = New Size(209, 37)
        btnCancelT.TabIndex = 28
        btnCancelT.Text = "Cancel"
        btnCancelT.UseVisualStyleBackColor = False
        btnCancelT.Visible = False
        ' 
        ' btnAddT
        ' 
        btnAddT.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnAddT.FlatAppearance.BorderSize = 0
        btnAddT.FlatStyle = FlatStyle.Flat
        btnAddT.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnAddT.ForeColor = Color.White
        btnAddT.Location = New Point(13, 419)
        btnAddT.Margin = New Padding(3, 2, 3, 2)
        btnAddT.Name = "btnAddT"
        btnAddT.Size = New Size(209, 37)
        btnAddT.TabIndex = 27
        btnAddT.Text = "Add"
        btnAddT.UseVisualStyleBackColor = False
        ' 
        ' txtDetailsOfConcern
        ' 
        txtDetailsOfConcern.Font = New System.Drawing.Font("Gotham", 9F)
        txtDetailsOfConcern.Location = New Point(13, 176)
        txtDetailsOfConcern.Margin = New Padding(3, 2, 3, 2)
        txtDetailsOfConcern.Multiline = True
        txtDetailsOfConcern.Name = "txtDetailsOfConcern"
        txtDetailsOfConcern.ScrollBars = ScrollBars.Both
        txtDetailsOfConcern.Size = New Size(210, 65)
        txtDetailsOfConcern.TabIndex = 26
        ' 
        ' lblDetailsOfConcern
        ' 
        lblDetailsOfConcern.AutoSize = True
        lblDetailsOfConcern.ForeColor = Color.White
        lblDetailsOfConcern.Location = New Point(13, 160)
        lblDetailsOfConcern.Name = "lblDetailsOfConcern"
        lblDetailsOfConcern.Size = New Size(117, 13)
        lblDetailsOfConcern.TabIndex = 25
        lblDetailsOfConcern.Text = "Details of Concern"
        ' 
        ' lblDateClose
        ' 
        lblDateClose.AutoSize = True
        lblDateClose.ForeColor = Color.White
        lblDateClose.Location = New Point(13, 110)
        lblDateClose.Name = "lblDateClose"
        lblDateClose.Size = New Size(72, 13)
        lblDateClose.TabIndex = 22
        lblDateClose.Text = "Date Close"
        ' 
        ' lblStartDateT
        ' 
        lblStartDateT.AutoSize = True
        lblStartDateT.ForeColor = Color.White
        lblStartDateT.Location = New Point(13, 56)
        lblStartDateT.Name = "lblStartDateT"
        lblStartDateT.Size = New Size(69, 13)
        lblStartDateT.TabIndex = 21
        lblStartDateT.Text = "Start Date"
        ' 
        ' txtConcernBy
        ' 
        txtConcernBy.Font = New System.Drawing.Font("Gotham", 9F)
        txtConcernBy.Location = New Point(13, 25)
        txtConcernBy.Margin = New Padding(3, 2, 3, 2)
        txtConcernBy.Name = "txtConcernBy"
        txtConcernBy.ScrollBars = ScrollBars.Horizontal
        txtConcernBy.Size = New Size(210, 20)
        txtConcernBy.TabIndex = 7
        ' 
        ' lblConcernBy
        ' 
        lblConcernBy.AutoSize = True
        lblConcernBy.ForeColor = Color.White
        lblConcernBy.Location = New Point(13, 8)
        lblConcernBy.Name = "lblConcernBy"
        lblConcernBy.Size = New Size(77, 13)
        lblConcernBy.TabIndex = 6
        lblConcernBy.Text = "Concern By"
        ' 
        ' SkillsTriageDataGrid
        ' 
        SkillsTriageDataGrid.AllowUserToAddRows = False
        SkillsTriageDataGrid.AllowUserToDeleteRows = False
        SkillsTriageDataGrid.AllowUserToOrderColumns = True
        SkillsTriageDataGrid.AllowUserToResizeColumns = False
        SkillsTriageDataGrid.AllowUserToResizeRows = False
        SkillsTriageDataGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        SkillsTriageDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        SkillsTriageDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        SkillsTriageDataGrid.BackgroundColor = SystemColors.ButtonHighlight
        SkillsTriageDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        SkillsTriageDataGrid.Location = New Point(230, 4)
        SkillsTriageDataGrid.Margin = New Padding(3, 2, 3, 2)
        SkillsTriageDataGrid.Name = "SkillsTriageDataGrid"
        SkillsTriageDataGrid.RowHeadersWidth = 51
        SkillsTriageDataGrid.Size = New Size(652, 711)
        SkillsTriageDataGrid.TabIndex = 5
        ' 
        ' dtpckerStartDateT
        ' 
        dtpckerStartDateT.Font = New System.Drawing.Font("Gotham", 9F)
        dtpckerStartDateT.Location = New Point(13, 73)
        dtpckerStartDateT.Margin = New Padding(3, 2, 3, 2)
        dtpckerStartDateT.Name = "dtpckerStartDateT"
        dtpckerStartDateT.ScrollBars = ScrollBars.Horizontal
        dtpckerStartDateT.Size = New Size(210, 20)
        dtpckerStartDateT.TabIndex = 36
        ' 
        ' dtpckerDateClose
        ' 
        dtpckerDateClose.Font = New System.Drawing.Font("Gotham", 9F)
        dtpckerDateClose.Location = New Point(13, 126)
        dtpckerDateClose.Margin = New Padding(3, 2, 3, 2)
        dtpckerDateClose.Name = "dtpckerDateClose"
        dtpckerDateClose.ScrollBars = ScrollBars.Horizontal
        dtpckerDateClose.Size = New Size(210, 20)
        dtpckerDateClose.TabIndex = 37
        ' 
        ' TrainingHistoryTab
        ' 
        TrainingHistoryTab.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        TrainingHistoryTab.Controls.Add(btnClearTH)
        TrainingHistoryTab.Controls.Add(btnCancelTH)
        TrainingHistoryTab.Controls.Add(btnDeleteTH)
        TrainingHistoryTab.Controls.Add(btnSaveChangesTH)
        TrainingHistoryTab.Controls.Add(txtGrade)
        TrainingHistoryTab.Controls.Add(lblGrade)
        TrainingHistoryTab.Controls.Add(lblCompletion)
        TrainingHistoryTab.Controls.Add(txtFacilitator)
        TrainingHistoryTab.Controls.Add(lblFacilitator)
        TrainingHistoryTab.Controls.Add(txtTopicOrModuleTitle)
        TrainingHistoryTab.Controls.Add(lblTopicOrModuleTitle)
        TrainingHistoryTab.Controls.Add(TrainingHistoryDataGrid)
        TrainingHistoryTab.Controls.Add(btnAddTH)
        TrainingHistoryTab.Controls.Add(dtpckerCompletion)
        TrainingHistoryTab.Font = New System.Drawing.Font("Gotham", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TrainingHistoryTab.ForeColor = Color.Black
        TrainingHistoryTab.Location = New Point(4, 67)
        TrainingHistoryTab.Margin = New Padding(3, 2, 3, 2)
        TrainingHistoryTab.Name = "TrainingHistoryTab"
        TrainingHistoryTab.Size = New Size(884, 652)
        TrainingHistoryTab.TabIndex = 6
        TrainingHistoryTab.Text = "Training History"
        ' 
        ' btnClearTH
        ' 
        btnClearTH.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnClearTH.FlatAppearance.BorderSize = 0
        btnClearTH.FlatStyle = FlatStyle.Flat
        btnClearTH.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnClearTH.ForeColor = Color.White
        btnClearTH.Location = New Point(13, 463)
        btnClearTH.Margin = New Padding(3, 2, 3, 2)
        btnClearTH.Name = "btnClearTH"
        btnClearTH.Size = New Size(209, 37)
        btnClearTH.TabIndex = 30
        btnClearTH.Text = "Clear"
        btnClearTH.UseVisualStyleBackColor = False
        ' 
        ' btnCancelTH
        ' 
        btnCancelTH.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnCancelTH.FlatAppearance.BorderSize = 0
        btnCancelTH.FlatStyle = FlatStyle.Flat
        btnCancelTH.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnCancelTH.ForeColor = Color.White
        btnCancelTH.Location = New Point(13, 504)
        btnCancelTH.Margin = New Padding(3, 2, 3, 2)
        btnCancelTH.Name = "btnCancelTH"
        btnCancelTH.Size = New Size(209, 37)
        btnCancelTH.TabIndex = 29
        btnCancelTH.Text = "Cancel"
        btnCancelTH.UseVisualStyleBackColor = False
        btnCancelTH.Visible = False
        ' 
        ' btnDeleteTH
        ' 
        btnDeleteTH.BackColor = Color.FromArgb(CByte(221), CByte(60), CByte(39))
        btnDeleteTH.FlatAppearance.BorderSize = 0
        btnDeleteTH.FlatStyle = FlatStyle.Flat
        btnDeleteTH.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnDeleteTH.ForeColor = Color.White
        btnDeleteTH.Location = New Point(121, 421)
        btnDeleteTH.Margin = New Padding(3, 2, 3, 2)
        btnDeleteTH.Name = "btnDeleteTH"
        btnDeleteTH.Size = New Size(102, 36)
        btnDeleteTH.TabIndex = 28
        btnDeleteTH.Text = "Delete"
        btnDeleteTH.UseVisualStyleBackColor = False
        btnDeleteTH.Visible = False
        ' 
        ' btnSaveChangesTH
        ' 
        btnSaveChangesTH.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnSaveChangesTH.FlatAppearance.BorderSize = 0
        btnSaveChangesTH.FlatStyle = FlatStyle.Flat
        btnSaveChangesTH.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnSaveChangesTH.ForeColor = Color.White
        btnSaveChangesTH.Location = New Point(13, 421)
        btnSaveChangesTH.Margin = New Padding(3, 2, 3, 2)
        btnSaveChangesTH.Name = "btnSaveChangesTH"
        btnSaveChangesTH.Size = New Size(102, 36)
        btnSaveChangesTH.TabIndex = 27
        btnSaveChangesTH.Text = "Save Changes"
        btnSaveChangesTH.UseVisualStyleBackColor = False
        btnSaveChangesTH.Visible = False
        ' 
        ' txtGrade
        ' 
        txtGrade.Font = New System.Drawing.Font("Gotham", 9F)
        txtGrade.Location = New Point(13, 394)
        txtGrade.Margin = New Padding(3, 2, 3, 2)
        txtGrade.Name = "txtGrade"
        txtGrade.ScrollBars = ScrollBars.Horizontal
        txtGrade.Size = New Size(210, 20)
        txtGrade.TabIndex = 26
        ' 
        ' lblGrade
        ' 
        lblGrade.AutoSize = True
        lblGrade.ForeColor = Color.White
        lblGrade.Location = New Point(13, 377)
        lblGrade.Name = "lblGrade"
        lblGrade.Size = New Size(43, 13)
        lblGrade.TabIndex = 25
        lblGrade.Text = "Grade"
        ' 
        ' lblCompletion
        ' 
        lblCompletion.AutoSize = True
        lblCompletion.ForeColor = Color.White
        lblCompletion.Location = New Point(13, 328)
        lblCompletion.Name = "lblCompletion"
        lblCompletion.Size = New Size(108, 13)
        lblCompletion.TabIndex = 11
        lblCompletion.Text = "Completion Date"
        ' 
        ' txtFacilitator
        ' 
        txtFacilitator.Font = New System.Drawing.Font("Gotham", 9F)
        txtFacilitator.Location = New Point(13, 239)
        txtFacilitator.Margin = New Padding(3, 2, 3, 2)
        txtFacilitator.Multiline = True
        txtFacilitator.Name = "txtFacilitator"
        txtFacilitator.ScrollBars = ScrollBars.Both
        txtFacilitator.Size = New Size(210, 75)
        txtFacilitator.TabIndex = 10
        ' 
        ' lblFacilitator
        ' 
        lblFacilitator.AutoSize = True
        lblFacilitator.ForeColor = Color.White
        lblFacilitator.Location = New Point(13, 223)
        lblFacilitator.Name = "lblFacilitator"
        lblFacilitator.Size = New Size(68, 13)
        lblFacilitator.TabIndex = 9
        lblFacilitator.Text = "Facilitator"
        ' 
        ' txtTopicOrModuleTitle
        ' 
        txtTopicOrModuleTitle.Font = New System.Drawing.Font("Gotham", 9F)
        txtTopicOrModuleTitle.Location = New Point(13, 25)
        txtTopicOrModuleTitle.Margin = New Padding(3, 2, 3, 2)
        txtTopicOrModuleTitle.Multiline = True
        txtTopicOrModuleTitle.Name = "txtTopicOrModuleTitle"
        txtTopicOrModuleTitle.ScrollBars = ScrollBars.Both
        txtTopicOrModuleTitle.Size = New Size(210, 190)
        txtTopicOrModuleTitle.TabIndex = 8
        ' 
        ' lblTopicOrModuleTitle
        ' 
        lblTopicOrModuleTitle.AutoSize = True
        lblTopicOrModuleTitle.ForeColor = Color.White
        lblTopicOrModuleTitle.Location = New Point(13, 8)
        lblTopicOrModuleTitle.Name = "lblTopicOrModuleTitle"
        lblTopicOrModuleTitle.Size = New Size(120, 13)
        lblTopicOrModuleTitle.TabIndex = 7
        lblTopicOrModuleTitle.Text = "Topic/Module Title"
        ' 
        ' TrainingHistoryDataGrid
        ' 
        TrainingHistoryDataGrid.AllowUserToAddRows = False
        TrainingHistoryDataGrid.AllowUserToDeleteRows = False
        TrainingHistoryDataGrid.AllowUserToOrderColumns = True
        TrainingHistoryDataGrid.AllowUserToResizeColumns = False
        TrainingHistoryDataGrid.AllowUserToResizeRows = False
        TrainingHistoryDataGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TrainingHistoryDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        TrainingHistoryDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        TrainingHistoryDataGrid.BackgroundColor = SystemColors.ButtonHighlight
        TrainingHistoryDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TrainingHistoryDataGrid.Location = New Point(230, 4)
        TrainingHistoryDataGrid.Margin = New Padding(3, 2, 3, 2)
        TrainingHistoryDataGrid.Name = "TrainingHistoryDataGrid"
        TrainingHistoryDataGrid.RowHeadersWidth = 51
        TrainingHistoryDataGrid.Size = New Size(652, 711)
        TrainingHistoryDataGrid.TabIndex = 6
        ' 
        ' btnAddTH
        ' 
        btnAddTH.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnAddTH.FlatAppearance.BorderSize = 0
        btnAddTH.FlatStyle = FlatStyle.Flat
        btnAddTH.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnAddTH.ForeColor = Color.White
        btnAddTH.Location = New Point(13, 421)
        btnAddTH.Margin = New Padding(3, 2, 3, 2)
        btnAddTH.Name = "btnAddTH"
        btnAddTH.Size = New Size(209, 37)
        btnAddTH.TabIndex = 31
        btnAddTH.Text = "Add"
        btnAddTH.UseVisualStyleBackColor = False
        ' 
        ' dtpckerCompletion
        ' 
        dtpckerCompletion.Font = New System.Drawing.Font("Gotham", 9F)
        dtpckerCompletion.Location = New Point(13, 346)
        dtpckerCompletion.Margin = New Padding(3, 2, 3, 2)
        dtpckerCompletion.Name = "dtpckerCompletion"
        dtpckerCompletion.ScrollBars = ScrollBars.Horizontal
        dtpckerCompletion.Size = New Size(210, 20)
        dtpckerCompletion.TabIndex = 32
        ' 
        ' CertificationsAndLicenses
        ' 
        CertificationsAndLicenses.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        CertificationsAndLicenses.Controls.Add(txtChapter)
        CertificationsAndLicenses.Controls.Add(Label1)
        CertificationsAndLicenses.Controls.Add(btnCancelCL)
        CertificationsAndLicenses.Controls.Add(btnClearCL)
        CertificationsAndLicenses.Controls.Add(btnDeleteCL)
        CertificationsAndLicenses.Controls.Add(btnSaveChangesCL)
        CertificationsAndLicenses.Controls.Add(txtLicenseNumber)
        CertificationsAndLicenses.Controls.Add(lblLicenseNumber)
        CertificationsAndLicenses.Controls.Add(txtStatus)
        CertificationsAndLicenses.Controls.Add(lblStatus)
        CertificationsAndLicenses.Controls.Add(lblGrantDate)
        CertificationsAndLicenses.Controls.Add(lblExpiryDate)
        CertificationsAndLicenses.Controls.Add(txtCertificateName)
        CertificationsAndLicenses.Controls.Add(lblCertificateName)
        CertificationsAndLicenses.Controls.Add(CertificationAndLicensesDataGrid)
        CertificationsAndLicenses.Controls.Add(txtProvider)
        CertificationsAndLicenses.Controls.Add(lblProvider)
        CertificationsAndLicenses.Controls.Add(btnAddCL)
        CertificationsAndLicenses.Controls.Add(dtpckerGrantDate)
        CertificationsAndLicenses.Controls.Add(dtpckerExpiryDate)
        CertificationsAndLicenses.Font = New System.Drawing.Font("Gotham", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CertificationsAndLicenses.ForeColor = Color.Black
        CertificationsAndLicenses.Location = New Point(4, 67)
        CertificationsAndLicenses.Margin = New Padding(3, 2, 3, 2)
        CertificationsAndLicenses.Name = "CertificationsAndLicenses"
        CertificationsAndLicenses.Size = New Size(884, 652)
        CertificationsAndLicenses.TabIndex = 7
        CertificationsAndLicenses.Text = "Certification & Licenses"
        ' 
        ' txtChapter
        ' 
        txtChapter.Font = New System.Drawing.Font("Gotham", 9F)
        txtChapter.Location = New Point(13, 163)
        txtChapter.Margin = New Padding(3, 2, 3, 2)
        txtChapter.Name = "txtChapter"
        txtChapter.ScrollBars = ScrollBars.Horizontal
        txtChapter.Size = New Size(210, 20)
        txtChapter.TabIndex = 58
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(13, 147)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 13)
        Label1.TabIndex = 57
        Label1.Text = "Chapter"
        ' 
        ' btnCancelCL
        ' 
        btnCancelCL.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnCancelCL.FlatAppearance.BorderSize = 0
        btnCancelCL.FlatStyle = FlatStyle.Flat
        btnCancelCL.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnCancelCL.ForeColor = Color.White
        btnCancelCL.Location = New Point(13, 555)
        btnCancelCL.Margin = New Padding(3, 2, 3, 2)
        btnCancelCL.Name = "btnCancelCL"
        btnCancelCL.Size = New Size(209, 37)
        btnCancelCL.TabIndex = 51
        btnCancelCL.Text = "Cancel"
        btnCancelCL.UseVisualStyleBackColor = False
        btnCancelCL.Visible = False
        ' 
        ' btnClearCL
        ' 
        btnClearCL.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnClearCL.FlatAppearance.BorderSize = 0
        btnClearCL.FlatStyle = FlatStyle.Flat
        btnClearCL.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnClearCL.ForeColor = Color.White
        btnClearCL.Location = New Point(13, 514)
        btnClearCL.Margin = New Padding(3, 2, 3, 2)
        btnClearCL.Name = "btnClearCL"
        btnClearCL.Size = New Size(209, 37)
        btnClearCL.TabIndex = 50
        btnClearCL.Text = "Clear"
        btnClearCL.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteCL
        ' 
        btnDeleteCL.BackColor = Color.FromArgb(CByte(221), CByte(60), CByte(39))
        btnDeleteCL.FlatAppearance.BorderSize = 0
        btnDeleteCL.FlatStyle = FlatStyle.Flat
        btnDeleteCL.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnDeleteCL.ForeColor = Color.White
        btnDeleteCL.Location = New Point(121, 472)
        btnDeleteCL.Margin = New Padding(3, 2, 3, 2)
        btnDeleteCL.Name = "btnDeleteCL"
        btnDeleteCL.Size = New Size(102, 36)
        btnDeleteCL.TabIndex = 49
        btnDeleteCL.Text = "Delete"
        btnDeleteCL.UseVisualStyleBackColor = False
        btnDeleteCL.Visible = False
        ' 
        ' btnSaveChangesCL
        ' 
        btnSaveChangesCL.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnSaveChangesCL.FlatAppearance.BorderSize = 0
        btnSaveChangesCL.FlatStyle = FlatStyle.Flat
        btnSaveChangesCL.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnSaveChangesCL.ForeColor = Color.White
        btnSaveChangesCL.Location = New Point(13, 472)
        btnSaveChangesCL.Margin = New Padding(3, 2, 3, 2)
        btnSaveChangesCL.Name = "btnSaveChangesCL"
        btnSaveChangesCL.Size = New Size(102, 36)
        btnSaveChangesCL.TabIndex = 48
        btnSaveChangesCL.Text = "Save Changes"
        btnSaveChangesCL.UseVisualStyleBackColor = False
        btnSaveChangesCL.Visible = False
        ' 
        ' txtLicenseNumber
        ' 
        txtLicenseNumber.Font = New System.Drawing.Font("Gotham", 9F)
        txtLicenseNumber.Location = New Point(13, 289)
        txtLicenseNumber.Margin = New Padding(3, 2, 3, 2)
        txtLicenseNumber.Name = "txtLicenseNumber"
        txtLicenseNumber.ScrollBars = ScrollBars.Horizontal
        txtLicenseNumber.Size = New Size(210, 20)
        txtLicenseNumber.TabIndex = 47
        ' 
        ' lblLicenseNumber
        ' 
        lblLicenseNumber.AutoSize = True
        lblLicenseNumber.ForeColor = Color.White
        lblLicenseNumber.Location = New Point(13, 273)
        lblLicenseNumber.Name = "lblLicenseNumber"
        lblLicenseNumber.Size = New Size(102, 13)
        lblLicenseNumber.TabIndex = 46
        lblLicenseNumber.Text = "License Number"
        ' 
        ' txtStatus
        ' 
        txtStatus.Font = New System.Drawing.Font("Gotham", 9F)
        txtStatus.Location = New Point(13, 445)
        txtStatus.Margin = New Padding(3, 2, 3, 2)
        txtStatus.Name = "txtStatus"
        txtStatus.ScrollBars = ScrollBars.Horizontal
        txtStatus.Size = New Size(210, 20)
        txtStatus.TabIndex = 45
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.ForeColor = Color.White
        lblStatus.Location = New Point(13, 428)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(45, 13)
        lblStatus.TabIndex = 44
        lblStatus.Text = "Status"
        ' 
        ' lblGrantDate
        ' 
        lblGrantDate.AutoSize = True
        lblGrantDate.ForeColor = Color.White
        lblGrantDate.Location = New Point(13, 323)
        lblGrantDate.Name = "lblGrantDate"
        lblGrantDate.Size = New Size(72, 13)
        lblGrantDate.TabIndex = 39
        lblGrantDate.Text = "Grant Date"
        ' 
        ' lblExpiryDate
        ' 
        lblExpiryDate.AutoSize = True
        lblExpiryDate.ForeColor = Color.White
        lblExpiryDate.Location = New Point(13, 376)
        lblExpiryDate.Name = "lblExpiryDate"
        lblExpiryDate.Size = New Size(77, 13)
        lblExpiryDate.TabIndex = 38
        lblExpiryDate.Text = "Expiry Date"
        ' 
        ' txtCertificateName
        ' 
        txtCertificateName.Font = New System.Drawing.Font("Gotham", 9F)
        txtCertificateName.Location = New Point(13, 25)
        txtCertificateName.Margin = New Padding(3, 2, 3, 2)
        txtCertificateName.Multiline = True
        txtCertificateName.Name = "txtCertificateName"
        txtCertificateName.ScrollBars = ScrollBars.Both
        txtCertificateName.Size = New Size(210, 110)
        txtCertificateName.TabIndex = 37
        ' 
        ' lblCertificateName
        ' 
        lblCertificateName.AutoSize = True
        lblCertificateName.ForeColor = Color.White
        lblCertificateName.Location = New Point(13, 8)
        lblCertificateName.Name = "lblCertificateName"
        lblCertificateName.Size = New Size(118, 13)
        lblCertificateName.TabIndex = 36
        lblCertificateName.Text = "Certification Name"
        ' 
        ' CertificationAndLicensesDataGrid
        ' 
        CertificationAndLicensesDataGrid.AllowUserToAddRows = False
        CertificationAndLicensesDataGrid.AllowUserToDeleteRows = False
        CertificationAndLicensesDataGrid.AllowUserToOrderColumns = True
        CertificationAndLicensesDataGrid.AllowUserToResizeColumns = False
        CertificationAndLicensesDataGrid.AllowUserToResizeRows = False
        CertificationAndLicensesDataGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        CertificationAndLicensesDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        CertificationAndLicensesDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        CertificationAndLicensesDataGrid.BackgroundColor = SystemColors.ButtonHighlight
        CertificationAndLicensesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        CertificationAndLicensesDataGrid.Location = New Point(230, 4)
        CertificationAndLicensesDataGrid.Margin = New Padding(3, 2, 3, 2)
        CertificationAndLicensesDataGrid.Name = "CertificationAndLicensesDataGrid"
        CertificationAndLicensesDataGrid.RowHeadersWidth = 51
        CertificationAndLicensesDataGrid.Size = New Size(652, 645)
        CertificationAndLicensesDataGrid.TabIndex = 7
        ' 
        ' txtProvider
        ' 
        txtProvider.Font = New System.Drawing.Font("Gotham", 9F)
        txtProvider.Location = New Point(13, 212)
        txtProvider.Margin = New Padding(3, 2, 3, 2)
        txtProvider.Multiline = True
        txtProvider.Name = "txtProvider"
        txtProvider.ScrollBars = ScrollBars.Both
        txtProvider.Size = New Size(210, 50)
        txtProvider.TabIndex = 43
        ' 
        ' lblProvider
        ' 
        lblProvider.AutoSize = True
        lblProvider.ForeColor = Color.White
        lblProvider.Location = New Point(13, 196)
        lblProvider.Name = "lblProvider"
        lblProvider.Size = New Size(58, 13)
        lblProvider.TabIndex = 42
        lblProvider.Text = "Provider"
        ' 
        ' btnAddCL
        ' 
        btnAddCL.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnAddCL.FlatAppearance.BorderSize = 0
        btnAddCL.FlatStyle = FlatStyle.Flat
        btnAddCL.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnAddCL.ForeColor = Color.White
        btnAddCL.Location = New Point(13, 472)
        btnAddCL.Margin = New Padding(3, 2, 3, 2)
        btnAddCL.Name = "btnAddCL"
        btnAddCL.Size = New Size(209, 37)
        btnAddCL.TabIndex = 52
        btnAddCL.Text = "Add"
        btnAddCL.UseVisualStyleBackColor = False
        ' 
        ' dtpckerGrantDate
        ' 
        dtpckerGrantDate.Font = New System.Drawing.Font("Gotham", 9F)
        dtpckerGrantDate.Location = New Point(13, 340)
        dtpckerGrantDate.Margin = New Padding(3, 2, 3, 2)
        dtpckerGrantDate.Name = "dtpckerGrantDate"
        dtpckerGrantDate.ScrollBars = ScrollBars.Horizontal
        dtpckerGrantDate.Size = New Size(210, 20)
        dtpckerGrantDate.TabIndex = 59
        ' 
        ' dtpckerExpiryDate
        ' 
        dtpckerExpiryDate.Font = New System.Drawing.Font("Gotham", 9F)
        dtpckerExpiryDate.Location = New Point(13, 394)
        dtpckerExpiryDate.Margin = New Padding(3, 2, 3, 2)
        dtpckerExpiryDate.Name = "dtpckerExpiryDate"
        dtpckerExpiryDate.ScrollBars = ScrollBars.Horizontal
        dtpckerExpiryDate.Size = New Size(210, 20)
        dtpckerExpiryDate.TabIndex = 60
        ' 
        ' TrainingPlanTab
        ' 
        TrainingPlanTab.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        TrainingPlanTab.Controls.Add(lblTargetDate)
        TrainingPlanTab.Controls.Add(txtTopicOrModuleName)
        TrainingPlanTab.Controls.Add(lblTopicOrModuleName)
        TrainingPlanTab.Controls.Add(txtFacilitatorP)
        TrainingPlanTab.Controls.Add(lblFacilitatorP)
        TrainingPlanTab.Controls.Add(btnCancelP)
        TrainingPlanTab.Controls.Add(btnClearP)
        TrainingPlanTab.Controls.Add(btnDeleteP)
        TrainingPlanTab.Controls.Add(btnSaveChangesP)
        TrainingPlanTab.Controls.Add(TrainingPlanDataGrid)
        TrainingPlanTab.Controls.Add(btnAddP)
        TrainingPlanTab.Controls.Add(txtTargetDate)
        TrainingPlanTab.Font = New System.Drawing.Font("Gotham", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TrainingPlanTab.ForeColor = Color.Black
        TrainingPlanTab.Location = New Point(4, 67)
        TrainingPlanTab.Margin = New Padding(3, 2, 3, 2)
        TrainingPlanTab.Name = "TrainingPlanTab"
        TrainingPlanTab.Size = New Size(884, 652)
        TrainingPlanTab.TabIndex = 8
        TrainingPlanTab.Text = "Training Plan"
        ' 
        ' lblTargetDate
        ' 
        lblTargetDate.AutoSize = True
        lblTargetDate.ForeColor = Color.White
        lblTargetDate.Location = New Point(13, 377)
        lblTargetDate.Name = "lblTargetDate"
        lblTargetDate.Size = New Size(79, 13)
        lblTargetDate.TabIndex = 56
        lblTargetDate.Text = "Target Date"
        ' 
        ' txtTopicOrModuleName
        ' 
        txtTopicOrModuleName.Font = New System.Drawing.Font("Gotham", 9F)
        txtTopicOrModuleName.Location = New Point(13, 25)
        txtTopicOrModuleName.Margin = New Padding(3, 2, 3, 2)
        txtTopicOrModuleName.Multiline = True
        txtTopicOrModuleName.Name = "txtTopicOrModuleName"
        txtTopicOrModuleName.ScrollBars = ScrollBars.Both
        txtTopicOrModuleName.Size = New Size(210, 186)
        txtTopicOrModuleName.TabIndex = 55
        ' 
        ' lblTopicOrModuleName
        ' 
        lblTopicOrModuleName.AutoSize = True
        lblTopicOrModuleName.ForeColor = Color.White
        lblTopicOrModuleName.Location = New Point(13, 8)
        lblTopicOrModuleName.Name = "lblTopicOrModuleName"
        lblTopicOrModuleName.Size = New Size(128, 13)
        lblTopicOrModuleName.TabIndex = 54
        lblTopicOrModuleName.Text = "Topic/Module Name"
        ' 
        ' txtFacilitatorP
        ' 
        txtFacilitatorP.Font = New System.Drawing.Font("Gotham", 9F)
        txtFacilitatorP.Location = New Point(13, 236)
        txtFacilitatorP.Margin = New Padding(3, 2, 3, 2)
        txtFacilitatorP.Multiline = True
        txtFacilitatorP.Name = "txtFacilitatorP"
        txtFacilitatorP.ScrollBars = ScrollBars.Both
        txtFacilitatorP.Size = New Size(210, 130)
        txtFacilitatorP.TabIndex = 58
        ' 
        ' lblFacilitatorP
        ' 
        lblFacilitatorP.AutoSize = True
        lblFacilitatorP.ForeColor = Color.White
        lblFacilitatorP.Location = New Point(13, 220)
        lblFacilitatorP.Name = "lblFacilitatorP"
        lblFacilitatorP.Size = New Size(68, 13)
        lblFacilitatorP.TabIndex = 57
        lblFacilitatorP.Text = "Facilitator"
        ' 
        ' btnCancelP
        ' 
        btnCancelP.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnCancelP.FlatAppearance.BorderSize = 0
        btnCancelP.FlatStyle = FlatStyle.Flat
        btnCancelP.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnCancelP.ForeColor = Color.White
        btnCancelP.Location = New Point(13, 504)
        btnCancelP.Margin = New Padding(3, 2, 3, 2)
        btnCancelP.Name = "btnCancelP"
        btnCancelP.Size = New Size(209, 37)
        btnCancelP.TabIndex = 12
        btnCancelP.Text = "Cancel"
        btnCancelP.UseVisualStyleBackColor = False
        btnCancelP.Visible = False
        ' 
        ' btnClearP
        ' 
        btnClearP.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnClearP.FlatAppearance.BorderSize = 0
        btnClearP.FlatStyle = FlatStyle.Flat
        btnClearP.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnClearP.ForeColor = Color.White
        btnClearP.Location = New Point(13, 463)
        btnClearP.Margin = New Padding(3, 2, 3, 2)
        btnClearP.Name = "btnClearP"
        btnClearP.Size = New Size(209, 37)
        btnClearP.TabIndex = 11
        btnClearP.Text = "Clear"
        btnClearP.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteP
        ' 
        btnDeleteP.BackColor = Color.FromArgb(CByte(221), CByte(60), CByte(39))
        btnDeleteP.FlatAppearance.BorderSize = 0
        btnDeleteP.FlatStyle = FlatStyle.Flat
        btnDeleteP.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnDeleteP.ForeColor = Color.White
        btnDeleteP.Location = New Point(121, 421)
        btnDeleteP.Margin = New Padding(3, 2, 3, 2)
        btnDeleteP.Name = "btnDeleteP"
        btnDeleteP.Size = New Size(102, 36)
        btnDeleteP.TabIndex = 10
        btnDeleteP.Text = "Delete"
        btnDeleteP.UseVisualStyleBackColor = False
        btnDeleteP.Visible = False
        ' 
        ' btnSaveChangesP
        ' 
        btnSaveChangesP.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnSaveChangesP.FlatAppearance.BorderSize = 0
        btnSaveChangesP.FlatStyle = FlatStyle.Flat
        btnSaveChangesP.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnSaveChangesP.ForeColor = Color.White
        btnSaveChangesP.Location = New Point(13, 421)
        btnSaveChangesP.Margin = New Padding(3, 2, 3, 2)
        btnSaveChangesP.Name = "btnSaveChangesP"
        btnSaveChangesP.Size = New Size(102, 36)
        btnSaveChangesP.TabIndex = 9
        btnSaveChangesP.Text = "Save Changes"
        btnSaveChangesP.UseVisualStyleBackColor = False
        btnSaveChangesP.Visible = False
        ' 
        ' TrainingPlanDataGrid
        ' 
        TrainingPlanDataGrid.AllowUserToAddRows = False
        TrainingPlanDataGrid.AllowUserToDeleteRows = False
        TrainingPlanDataGrid.AllowUserToOrderColumns = True
        TrainingPlanDataGrid.AllowUserToResizeColumns = False
        TrainingPlanDataGrid.AllowUserToResizeRows = False
        TrainingPlanDataGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TrainingPlanDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        TrainingPlanDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        TrainingPlanDataGrid.BackgroundColor = SystemColors.ButtonHighlight
        TrainingPlanDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TrainingPlanDataGrid.Location = New Point(230, 4)
        TrainingPlanDataGrid.Margin = New Padding(3, 2, 3, 2)
        TrainingPlanDataGrid.Name = "TrainingPlanDataGrid"
        TrainingPlanDataGrid.RowHeadersWidth = 51
        TrainingPlanDataGrid.Size = New Size(652, 645)
        TrainingPlanDataGrid.TabIndex = 8
        ' 
        ' btnAddP
        ' 
        btnAddP.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnAddP.FlatAppearance.BorderSize = 0
        btnAddP.FlatStyle = FlatStyle.Flat
        btnAddP.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnAddP.ForeColor = Color.White
        btnAddP.Location = New Point(13, 421)
        btnAddP.Margin = New Padding(3, 2, 3, 2)
        btnAddP.Name = "btnAddP"
        btnAddP.Size = New Size(209, 37)
        btnAddP.TabIndex = 13
        btnAddP.Text = "Add"
        btnAddP.UseVisualStyleBackColor = False
        ' 
        ' txtTargetDate
        ' 
        txtTargetDate.Font = New System.Drawing.Font("Gotham", 9F)
        txtTargetDate.Location = New Point(13, 394)
        txtTargetDate.Margin = New Padding(3, 2, 3, 2)
        txtTargetDate.Name = "txtTargetDate"
        txtTargetDate.ScrollBars = ScrollBars.Horizontal
        txtTargetDate.Size = New Size(210, 20)
        txtTargetDate.TabIndex = 61
        ' 
        ' TrainingProgramsTab
        ' 
        TrainingProgramsTab.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        TrainingProgramsTab.Controls.Add(txtCompletionDateTPr)
        TrainingProgramsTab.Controls.Add(txtStartDateTPr)
        TrainingProgramsTab.Controls.Add(btnCancelTPr)
        TrainingProgramsTab.Controls.Add(btnClearTPr)
        TrainingProgramsTab.Controls.Add(btnDeleteTPr)
        TrainingProgramsTab.Controls.Add(btnSaveChangesTPr)
        TrainingProgramsTab.Controls.Add(txtDeliberationScoreTPr)
        TrainingProgramsTab.Controls.Add(lblDeliberationScoreTPr)
        TrainingProgramsTab.Controls.Add(txtDeliberationNotesTPr)
        TrainingProgramsTab.Controls.Add(lblDeliberationNotesTPr)
        TrainingProgramsTab.Controls.Add(lblCompletionDate)
        TrainingProgramsTab.Controls.Add(lblStartDateTPr)
        TrainingProgramsTab.Controls.Add(txtProgramTitle)
        TrainingProgramsTab.Controls.Add(lblProgramTitle)
        TrainingProgramsTab.Controls.Add(TrainingProgramsDataGrid)
        TrainingProgramsTab.Controls.Add(btnAddTPr)
        TrainingProgramsTab.Font = New System.Drawing.Font("Gotham", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TrainingProgramsTab.ForeColor = Color.Black
        TrainingProgramsTab.Location = New Point(4, 67)
        TrainingProgramsTab.Margin = New Padding(3, 2, 3, 2)
        TrainingProgramsTab.Name = "TrainingProgramsTab"
        TrainingProgramsTab.Size = New Size(884, 652)
        TrainingProgramsTab.TabIndex = 9
        TrainingProgramsTab.Text = "Training Programs"
        ' 
        ' txtCompletionDateTPr
        ' 
        txtCompletionDateTPr.Font = New System.Drawing.Font("Gotham", 9F)
        txtCompletionDateTPr.Location = New Point(13, 123)
        txtCompletionDateTPr.Margin = New Padding(3, 2, 3, 2)
        txtCompletionDateTPr.Name = "txtCompletionDateTPr"
        txtCompletionDateTPr.ScrollBars = ScrollBars.Horizontal
        txtCompletionDateTPr.Size = New Size(210, 20)
        txtCompletionDateTPr.TabIndex = 62
        ' 
        ' txtStartDateTPr
        ' 
        txtStartDateTPr.Font = New System.Drawing.Font("Gotham", 9F)
        txtStartDateTPr.Location = New Point(13, 74)
        txtStartDateTPr.Margin = New Padding(3, 2, 3, 2)
        txtStartDateTPr.Name = "txtStartDateTPr"
        txtStartDateTPr.ScrollBars = ScrollBars.Horizontal
        txtStartDateTPr.Size = New Size(210, 20)
        txtStartDateTPr.TabIndex = 61
        ' 
        ' btnCancelTPr
        ' 
        btnCancelTPr.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnCancelTPr.FlatAppearance.BorderSize = 0
        btnCancelTPr.FlatStyle = FlatStyle.Flat
        btnCancelTPr.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnCancelTPr.ForeColor = Color.White
        btnCancelTPr.Location = New Point(13, 503)
        btnCancelTPr.Margin = New Padding(3, 2, 3, 2)
        btnCancelTPr.Name = "btnCancelTPr"
        btnCancelTPr.Size = New Size(209, 37)
        btnCancelTPr.TabIndex = 39
        btnCancelTPr.Text = "Cancel"
        btnCancelTPr.UseVisualStyleBackColor = False
        btnCancelTPr.Visible = False
        ' 
        ' btnClearTPr
        ' 
        btnClearTPr.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnClearTPr.FlatAppearance.BorderSize = 0
        btnClearTPr.FlatStyle = FlatStyle.Flat
        btnClearTPr.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnClearTPr.ForeColor = Color.White
        btnClearTPr.Location = New Point(13, 462)
        btnClearTPr.Margin = New Padding(3, 2, 3, 2)
        btnClearTPr.Name = "btnClearTPr"
        btnClearTPr.Size = New Size(209, 37)
        btnClearTPr.TabIndex = 38
        btnClearTPr.Text = "Clear"
        btnClearTPr.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteTPr
        ' 
        btnDeleteTPr.BackColor = Color.FromArgb(CByte(221), CByte(60), CByte(39))
        btnDeleteTPr.FlatAppearance.BorderSize = 0
        btnDeleteTPr.FlatStyle = FlatStyle.Flat
        btnDeleteTPr.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnDeleteTPr.ForeColor = Color.White
        btnDeleteTPr.Location = New Point(121, 420)
        btnDeleteTPr.Margin = New Padding(3, 2, 3, 2)
        btnDeleteTPr.Name = "btnDeleteTPr"
        btnDeleteTPr.Size = New Size(102, 36)
        btnDeleteTPr.TabIndex = 37
        btnDeleteTPr.Text = "Delete"
        btnDeleteTPr.UseVisualStyleBackColor = False
        btnDeleteTPr.Visible = False
        ' 
        ' btnSaveChangesTPr
        ' 
        btnSaveChangesTPr.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnSaveChangesTPr.FlatAppearance.BorderSize = 0
        btnSaveChangesTPr.FlatStyle = FlatStyle.Flat
        btnSaveChangesTPr.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnSaveChangesTPr.ForeColor = Color.White
        btnSaveChangesTPr.Location = New Point(13, 420)
        btnSaveChangesTPr.Margin = New Padding(3, 2, 3, 2)
        btnSaveChangesTPr.Name = "btnSaveChangesTPr"
        btnSaveChangesTPr.Size = New Size(102, 36)
        btnSaveChangesTPr.TabIndex = 36
        btnSaveChangesTPr.Text = "Save Changes"
        btnSaveChangesTPr.UseVisualStyleBackColor = False
        btnSaveChangesTPr.Visible = False
        ' 
        ' txtDeliberationScoreTPr
        ' 
        txtDeliberationScoreTPr.Font = New System.Drawing.Font("Gotham", 9F)
        txtDeliberationScoreTPr.Location = New Point(13, 176)
        txtDeliberationScoreTPr.Margin = New Padding(3, 2, 3, 2)
        txtDeliberationScoreTPr.Name = "txtDeliberationScoreTPr"
        txtDeliberationScoreTPr.ScrollBars = ScrollBars.Horizontal
        txtDeliberationScoreTPr.Size = New Size(210, 20)
        txtDeliberationScoreTPr.TabIndex = 35
        ' 
        ' lblDeliberationScoreTPr
        ' 
        lblDeliberationScoreTPr.AutoSize = True
        lblDeliberationScoreTPr.ForeColor = Color.White
        lblDeliberationScoreTPr.Location = New Point(13, 160)
        lblDeliberationScoreTPr.Name = "lblDeliberationScoreTPr"
        lblDeliberationScoreTPr.Size = New Size(118, 13)
        lblDeliberationScoreTPr.TabIndex = 34
        lblDeliberationScoreTPr.Text = "Deliberation Score"
        ' 
        ' txtDeliberationNotesTPr
        ' 
        txtDeliberationNotesTPr.Font = New System.Drawing.Font("Gotham", 9F)
        txtDeliberationNotesTPr.Location = New Point(13, 230)
        txtDeliberationNotesTPr.Margin = New Padding(3, 2, 3, 2)
        txtDeliberationNotesTPr.Multiline = True
        txtDeliberationNotesTPr.Name = "txtDeliberationNotesTPr"
        txtDeliberationNotesTPr.ScrollBars = ScrollBars.Both
        txtDeliberationNotesTPr.Size = New Size(210, 186)
        txtDeliberationNotesTPr.TabIndex = 31
        ' 
        ' lblDeliberationNotesTPr
        ' 
        lblDeliberationNotesTPr.AutoSize = True
        lblDeliberationNotesTPr.ForeColor = Color.White
        lblDeliberationNotesTPr.Location = New Point(13, 213)
        lblDeliberationNotesTPr.Name = "lblDeliberationNotesTPr"
        lblDeliberationNotesTPr.Size = New Size(118, 13)
        lblDeliberationNotesTPr.TabIndex = 30
        lblDeliberationNotesTPr.Text = "Deliberation Notes"
        ' 
        ' lblCompletionDate
        ' 
        lblCompletionDate.AutoSize = True
        lblCompletionDate.ForeColor = Color.White
        lblCompletionDate.Location = New Point(13, 105)
        lblCompletionDate.Name = "lblCompletionDate"
        lblCompletionDate.Size = New Size(108, 13)
        lblCompletionDate.TabIndex = 29
        lblCompletionDate.Text = "Completion Date"
        ' 
        ' lblStartDateTPr
        ' 
        lblStartDateTPr.AutoSize = True
        lblStartDateTPr.ForeColor = Color.White
        lblStartDateTPr.Location = New Point(13, 56)
        lblStartDateTPr.Name = "lblStartDateTPr"
        lblStartDateTPr.Size = New Size(69, 13)
        lblStartDateTPr.TabIndex = 28
        lblStartDateTPr.Text = "Start Date"
        ' 
        ' txtProgramTitle
        ' 
        txtProgramTitle.Font = New System.Drawing.Font("Gotham", 9F)
        txtProgramTitle.Location = New Point(13, 25)
        txtProgramTitle.Margin = New Padding(3, 2, 3, 2)
        txtProgramTitle.Name = "txtProgramTitle"
        txtProgramTitle.ScrollBars = ScrollBars.Horizontal
        txtProgramTitle.Size = New Size(210, 20)
        txtProgramTitle.TabIndex = 23
        ' 
        ' lblProgramTitle
        ' 
        lblProgramTitle.AutoSize = True
        lblProgramTitle.ForeColor = Color.White
        lblProgramTitle.Location = New Point(13, 8)
        lblProgramTitle.Name = "lblProgramTitle"
        lblProgramTitle.Size = New Size(89, 13)
        lblProgramTitle.TabIndex = 22
        lblProgramTitle.Text = "Program Title"
        ' 
        ' TrainingProgramsDataGrid
        ' 
        TrainingProgramsDataGrid.AllowUserToAddRows = False
        TrainingProgramsDataGrid.AllowUserToDeleteRows = False
        TrainingProgramsDataGrid.AllowUserToOrderColumns = True
        TrainingProgramsDataGrid.AllowUserToResizeColumns = False
        TrainingProgramsDataGrid.AllowUserToResizeRows = False
        TrainingProgramsDataGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TrainingProgramsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        TrainingProgramsDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        TrainingProgramsDataGrid.BackgroundColor = SystemColors.ButtonHighlight
        TrainingProgramsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TrainingProgramsDataGrid.Location = New Point(230, 4)
        TrainingProgramsDataGrid.Margin = New Padding(3, 2, 3, 2)
        TrainingProgramsDataGrid.Name = "TrainingProgramsDataGrid"
        TrainingProgramsDataGrid.RowHeadersWidth = 51
        TrainingProgramsDataGrid.Size = New Size(652, 645)
        TrainingProgramsDataGrid.TabIndex = 8
        ' 
        ' btnAddTPr
        ' 
        btnAddTPr.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnAddTPr.FlatAppearance.BorderSize = 0
        btnAddTPr.FlatStyle = FlatStyle.Flat
        btnAddTPr.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnAddTPr.ForeColor = Color.White
        btnAddTPr.Location = New Point(13, 420)
        btnAddTPr.Margin = New Padding(3, 2, 3, 2)
        btnAddTPr.Name = "btnAddTPr"
        btnAddTPr.Size = New Size(209, 37)
        btnAddTPr.TabIndex = 40
        btnAddTPr.Text = "Add"
        btnAddTPr.UseVisualStyleBackColor = False
        ' 
        ' WebinarsAttendedTab
        ' 
        WebinarsAttendedTab.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        WebinarsAttendedTab.Controls.Add(txtDateW)
        WebinarsAttendedTab.Controls.Add(btnCancelW)
        WebinarsAttendedTab.Controls.Add(btnClearW)
        WebinarsAttendedTab.Controls.Add(btnDeleteW)
        WebinarsAttendedTab.Controls.Add(btnSaveChangesW)
        WebinarsAttendedTab.Controls.Add(txtWebinarTitle)
        WebinarsAttendedTab.Controls.Add(lblWebinarTitle)
        WebinarsAttendedTab.Controls.Add(WebinarsAttendedDataGrid)
        WebinarsAttendedTab.Controls.Add(lblCPDUnits)
        WebinarsAttendedTab.Controls.Add(lblDateW)
        WebinarsAttendedTab.Controls.Add(txtCPDUnits)
        WebinarsAttendedTab.Controls.Add(btnAddW)
        WebinarsAttendedTab.Font = New System.Drawing.Font("Gotham", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        WebinarsAttendedTab.ForeColor = Color.Black
        WebinarsAttendedTab.Location = New Point(4, 67)
        WebinarsAttendedTab.Margin = New Padding(3, 2, 3, 2)
        WebinarsAttendedTab.Name = "WebinarsAttendedTab"
        WebinarsAttendedTab.Size = New Size(884, 652)
        WebinarsAttendedTab.TabIndex = 10
        WebinarsAttendedTab.Text = "Webinars Attended"
        ' 
        ' txtDateW
        ' 
        txtDateW.Font = New System.Drawing.Font("Gotham", 9F)
        txtDateW.Location = New Point(13, 340)
        txtDateW.Margin = New Padding(3, 2, 3, 2)
        txtDateW.Name = "txtDateW"
        txtDateW.ScrollBars = ScrollBars.Horizontal
        txtDateW.Size = New Size(210, 20)
        txtDateW.TabIndex = 73
        ' 
        ' btnCancelW
        ' 
        btnCancelW.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnCancelW.FlatAppearance.BorderSize = 0
        btnCancelW.FlatStyle = FlatStyle.Flat
        btnCancelW.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnCancelW.ForeColor = Color.White
        btnCancelW.Location = New Point(13, 499)
        btnCancelW.Margin = New Padding(3, 2, 3, 2)
        btnCancelW.Name = "btnCancelW"
        btnCancelW.Size = New Size(209, 37)
        btnCancelW.TabIndex = 71
        btnCancelW.Text = "Cancel"
        btnCancelW.UseVisualStyleBackColor = False
        btnCancelW.Visible = False
        ' 
        ' btnClearW
        ' 
        btnClearW.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnClearW.FlatAppearance.BorderSize = 0
        btnClearW.FlatStyle = FlatStyle.Flat
        btnClearW.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnClearW.ForeColor = Color.White
        btnClearW.Location = New Point(13, 458)
        btnClearW.Margin = New Padding(3, 2, 3, 2)
        btnClearW.Name = "btnClearW"
        btnClearW.Size = New Size(209, 37)
        btnClearW.TabIndex = 70
        btnClearW.Text = "Clear"
        btnClearW.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteW
        ' 
        btnDeleteW.BackColor = Color.FromArgb(CByte(221), CByte(60), CByte(39))
        btnDeleteW.FlatAppearance.BorderSize = 0
        btnDeleteW.FlatStyle = FlatStyle.Flat
        btnDeleteW.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnDeleteW.ForeColor = Color.White
        btnDeleteW.Location = New Point(121, 416)
        btnDeleteW.Margin = New Padding(3, 2, 3, 2)
        btnDeleteW.Name = "btnDeleteW"
        btnDeleteW.Size = New Size(102, 36)
        btnDeleteW.TabIndex = 69
        btnDeleteW.Text = "Delete"
        btnDeleteW.UseVisualStyleBackColor = False
        btnDeleteW.Visible = False
        ' 
        ' btnSaveChangesW
        ' 
        btnSaveChangesW.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnSaveChangesW.FlatAppearance.BorderSize = 0
        btnSaveChangesW.FlatStyle = FlatStyle.Flat
        btnSaveChangesW.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnSaveChangesW.ForeColor = Color.White
        btnSaveChangesW.Location = New Point(13, 416)
        btnSaveChangesW.Margin = New Padding(3, 2, 3, 2)
        btnSaveChangesW.Name = "btnSaveChangesW"
        btnSaveChangesW.Size = New Size(102, 36)
        btnSaveChangesW.TabIndex = 68
        btnSaveChangesW.Text = "Save Changes"
        btnSaveChangesW.UseVisualStyleBackColor = False
        btnSaveChangesW.Visible = False
        ' 
        ' txtWebinarTitle
        ' 
        txtWebinarTitle.Font = New System.Drawing.Font("Gotham", 9F)
        txtWebinarTitle.Location = New Point(13, 25)
        txtWebinarTitle.Margin = New Padding(3, 2, 3, 2)
        txtWebinarTitle.Multiline = True
        txtWebinarTitle.Name = "txtWebinarTitle"
        txtWebinarTitle.ScrollBars = ScrollBars.Both
        txtWebinarTitle.Size = New Size(210, 285)
        txtWebinarTitle.TabIndex = 61
        ' 
        ' lblWebinarTitle
        ' 
        lblWebinarTitle.AutoSize = True
        lblWebinarTitle.ForeColor = Color.White
        lblWebinarTitle.Location = New Point(13, 8)
        lblWebinarTitle.Name = "lblWebinarTitle"
        lblWebinarTitle.Size = New Size(87, 13)
        lblWebinarTitle.TabIndex = 60
        lblWebinarTitle.Text = "Webinar Title"
        ' 
        ' WebinarsAttendedDataGrid
        ' 
        WebinarsAttendedDataGrid.AllowUserToAddRows = False
        WebinarsAttendedDataGrid.AllowUserToDeleteRows = False
        WebinarsAttendedDataGrid.AllowUserToOrderColumns = True
        WebinarsAttendedDataGrid.AllowUserToResizeColumns = False
        WebinarsAttendedDataGrid.AllowUserToResizeRows = False
        WebinarsAttendedDataGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        WebinarsAttendedDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        WebinarsAttendedDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        WebinarsAttendedDataGrid.BackgroundColor = SystemColors.ButtonHighlight
        WebinarsAttendedDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        WebinarsAttendedDataGrid.Location = New Point(230, 4)
        WebinarsAttendedDataGrid.Margin = New Padding(3, 2, 3, 2)
        WebinarsAttendedDataGrid.Name = "WebinarsAttendedDataGrid"
        WebinarsAttendedDataGrid.RowHeadersWidth = 51
        WebinarsAttendedDataGrid.Size = New Size(652, 645)
        WebinarsAttendedDataGrid.TabIndex = 8
        ' 
        ' lblCPDUnits
        ' 
        lblCPDUnits.AutoSize = True
        lblCPDUnits.ForeColor = Color.White
        lblCPDUnits.Location = New Point(13, 372)
        lblCPDUnits.Name = "lblCPDUnits"
        lblCPDUnits.Size = New Size(67, 13)
        lblCPDUnits.TabIndex = 66
        lblCPDUnits.Text = "CPD Units"
        ' 
        ' lblDateW
        ' 
        lblDateW.AutoSize = True
        lblDateW.ForeColor = Color.White
        lblDateW.Location = New Point(13, 322)
        lblDateW.Name = "lblDateW"
        lblDateW.Size = New Size(35, 13)
        lblDateW.TabIndex = 62
        lblDateW.Text = "Date"
        ' 
        ' txtCPDUnits
        ' 
        txtCPDUnits.Font = New System.Drawing.Font("Gotham", 9F)
        txtCPDUnits.Location = New Point(13, 389)
        txtCPDUnits.Margin = New Padding(3, 2, 3, 2)
        txtCPDUnits.Name = "txtCPDUnits"
        txtCPDUnits.ScrollBars = ScrollBars.Horizontal
        txtCPDUnits.Size = New Size(210, 20)
        txtCPDUnits.TabIndex = 67
        ' 
        ' btnAddW
        ' 
        btnAddW.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnAddW.FlatAppearance.BorderSize = 0
        btnAddW.FlatStyle = FlatStyle.Flat
        btnAddW.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnAddW.ForeColor = Color.White
        btnAddW.Location = New Point(13, 416)
        btnAddW.Margin = New Padding(3, 2, 3, 2)
        btnAddW.Name = "btnAddW"
        btnAddW.Size = New Size(209, 37)
        btnAddW.TabIndex = 72
        btnAddW.Text = "Add"
        btnAddW.UseVisualStyleBackColor = False
        ' 
        ' ClientFeedbackTab
        ' 
        ClientFeedbackTab.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        ClientFeedbackTab.Controls.Add(txtFeedbackDate)
        ClientFeedbackTab.Controls.Add(btnCancelCF)
        ClientFeedbackTab.Controls.Add(btnClearCF)
        ClientFeedbackTab.Controls.Add(btnDeleteCF)
        ClientFeedbackTab.Controls.Add(btnSaveChangesCF)
        ClientFeedbackTab.Controls.Add(lblStaffPerformanceRating)
        ClientFeedbackTab.Controls.Add(txtStaffPerformanceRating)
        ClientFeedbackTab.Controls.Add(txtFeedbackSummary)
        ClientFeedbackTab.Controls.Add(lblFeedbackSummary)
        ClientFeedbackTab.Controls.Add(lblFeedbackDate)
        ClientFeedbackTab.Controls.Add(txt)
        ClientFeedbackTab.Controls.Add(txtClientPOC)
        ClientFeedbackTab.Controls.Add(lblAccountManager)
        ClientFeedbackTab.Controls.Add(txtAccountManager)
        ClientFeedbackTab.Controls.Add(ClientFeedbackDataGrid)
        ClientFeedbackTab.Controls.Add(btnAddCF)
        ClientFeedbackTab.Font = New System.Drawing.Font("Gotham", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ClientFeedbackTab.ForeColor = Color.Black
        ClientFeedbackTab.Location = New Point(4, 67)
        ClientFeedbackTab.Name = "ClientFeedbackTab"
        ClientFeedbackTab.Size = New Size(884, 652)
        ClientFeedbackTab.TabIndex = 11
        ClientFeedbackTab.Text = "Client Feedback"
        ' 
        ' txtFeedbackDate
        ' 
        txtFeedbackDate.Font = New System.Drawing.Font("Gotham", 9F)
        txtFeedbackDate.Location = New Point(13, 126)
        txtFeedbackDate.Name = "txtFeedbackDate"
        txtFeedbackDate.ScrollBars = ScrollBars.Horizontal
        txtFeedbackDate.Size = New Size(210, 20)
        txtFeedbackDate.TabIndex = 31
        ' 
        ' btnCancelCF
        ' 
        btnCancelCF.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnCancelCF.FlatAppearance.BorderSize = 0
        btnCancelCF.FlatStyle = FlatStyle.Flat
        btnCancelCF.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnCancelCF.ForeColor = Color.White
        btnCancelCF.Location = New Point(13, 501)
        btnCancelCF.Name = "btnCancelCF"
        btnCancelCF.Size = New Size(209, 37)
        btnCancelCF.TabIndex = 30
        btnCancelCF.Text = "Cancel"
        btnCancelCF.UseVisualStyleBackColor = False
        btnCancelCF.Visible = False
        ' 
        ' btnClearCF
        ' 
        btnClearCF.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnClearCF.FlatAppearance.BorderSize = 0
        btnClearCF.FlatStyle = FlatStyle.Flat
        btnClearCF.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnClearCF.ForeColor = Color.White
        btnClearCF.Location = New Point(13, 460)
        btnClearCF.Name = "btnClearCF"
        btnClearCF.Size = New Size(209, 37)
        btnClearCF.TabIndex = 29
        btnClearCF.Text = "Clear"
        btnClearCF.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteCF
        ' 
        btnDeleteCF.BackColor = Color.FromArgb(CByte(221), CByte(60), CByte(39))
        btnDeleteCF.FlatAppearance.BorderSize = 0
        btnDeleteCF.FlatStyle = FlatStyle.Flat
        btnDeleteCF.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnDeleteCF.ForeColor = Color.White
        btnDeleteCF.Location = New Point(121, 418)
        btnDeleteCF.Name = "btnDeleteCF"
        btnDeleteCF.Size = New Size(102, 36)
        btnDeleteCF.TabIndex = 27
        btnDeleteCF.Text = "Delete"
        btnDeleteCF.UseVisualStyleBackColor = False
        btnDeleteCF.Visible = False
        ' 
        ' btnSaveChangesCF
        ' 
        btnSaveChangesCF.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnSaveChangesCF.FlatAppearance.BorderSize = 0
        btnSaveChangesCF.FlatStyle = FlatStyle.Flat
        btnSaveChangesCF.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnSaveChangesCF.ForeColor = Color.White
        btnSaveChangesCF.Location = New Point(13, 418)
        btnSaveChangesCF.Name = "btnSaveChangesCF"
        btnSaveChangesCF.Size = New Size(102, 36)
        btnSaveChangesCF.TabIndex = 26
        btnSaveChangesCF.Text = "Save Changes"
        btnSaveChangesCF.UseVisualStyleBackColor = False
        btnSaveChangesCF.Visible = False
        ' 
        ' lblStaffPerformanceRating
        ' 
        lblStaffPerformanceRating.AutoSize = True
        lblStaffPerformanceRating.ForeColor = Color.White
        lblStaffPerformanceRating.Location = New Point(13, 372)
        lblStaffPerformanceRating.Name = "lblStaffPerformanceRating"
        lblStaffPerformanceRating.Size = New Size(158, 13)
        lblStaffPerformanceRating.TabIndex = 25
        lblStaffPerformanceRating.Text = "Staff Performance Rating"
        ' 
        ' txtStaffPerformanceRating
        ' 
        txtStaffPerformanceRating.Font = New System.Drawing.Font("Gotham", 9F)
        txtStaffPerformanceRating.Location = New Point(13, 389)
        txtStaffPerformanceRating.Name = "txtStaffPerformanceRating"
        txtStaffPerformanceRating.ScrollBars = ScrollBars.Horizontal
        txtStaffPerformanceRating.Size = New Size(210, 20)
        txtStaffPerformanceRating.TabIndex = 24
        ' 
        ' txtFeedbackSummary
        ' 
        txtFeedbackSummary.Font = New System.Drawing.Font("Gotham", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFeedbackSummary.Location = New Point(13, 176)
        txtFeedbackSummary.Margin = New Padding(3, 2, 3, 2)
        txtFeedbackSummary.Multiline = True
        txtFeedbackSummary.Name = "txtFeedbackSummary"
        txtFeedbackSummary.ScrollBars = ScrollBars.Both
        txtFeedbackSummary.Size = New Size(210, 185)
        txtFeedbackSummary.TabIndex = 23
        ' 
        ' lblFeedbackSummary
        ' 
        lblFeedbackSummary.AutoSize = True
        lblFeedbackSummary.ForeColor = Color.White
        lblFeedbackSummary.Location = New Point(13, 160)
        lblFeedbackSummary.Name = "lblFeedbackSummary"
        lblFeedbackSummary.Size = New Size(126, 13)
        lblFeedbackSummary.TabIndex = 22
        lblFeedbackSummary.Text = "Feedback Summary"
        ' 
        ' lblFeedbackDate
        ' 
        lblFeedbackDate.AutoSize = True
        lblFeedbackDate.ForeColor = Color.White
        lblFeedbackDate.Location = New Point(13, 107)
        lblFeedbackDate.Name = "lblFeedbackDate"
        lblFeedbackDate.Size = New Size(98, 13)
        lblFeedbackDate.TabIndex = 20
        lblFeedbackDate.Text = "Feedback Date"
        ' 
        ' txt
        ' 
        txt.AutoSize = True
        txt.ForeColor = Color.White
        txt.Location = New Point(13, 56)
        txt.Name = "txt"
        txt.Size = New Size(72, 13)
        txt.TabIndex = 13
        txt.Text = "Client POC"
        ' 
        ' txtClientPOC
        ' 
        txtClientPOC.Font = New System.Drawing.Font("Gotham", 9F)
        txtClientPOC.Location = New Point(13, 73)
        txtClientPOC.Name = "txtClientPOC"
        txtClientPOC.ScrollBars = ScrollBars.Horizontal
        txtClientPOC.Size = New Size(210, 20)
        txtClientPOC.TabIndex = 12
        ' 
        ' lblAccountManager
        ' 
        lblAccountManager.AutoSize = True
        lblAccountManager.ForeColor = Color.White
        lblAccountManager.Location = New Point(13, 8)
        lblAccountManager.Name = "lblAccountManager"
        lblAccountManager.Size = New Size(112, 13)
        lblAccountManager.TabIndex = 11
        lblAccountManager.Text = "Account Manager"
        ' 
        ' txtAccountManager
        ' 
        txtAccountManager.Font = New System.Drawing.Font("Gotham", 9F)
        txtAccountManager.Location = New Point(13, 25)
        txtAccountManager.Name = "txtAccountManager"
        txtAccountManager.ScrollBars = ScrollBars.Horizontal
        txtAccountManager.Size = New Size(210, 20)
        txtAccountManager.TabIndex = 10
        ' 
        ' ClientFeedbackDataGrid
        ' 
        ClientFeedbackDataGrid.AllowUserToAddRows = False
        ClientFeedbackDataGrid.AllowUserToDeleteRows = False
        ClientFeedbackDataGrid.AllowUserToOrderColumns = True
        ClientFeedbackDataGrid.AllowUserToResizeColumns = False
        ClientFeedbackDataGrid.AllowUserToResizeRows = False
        ClientFeedbackDataGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ClientFeedbackDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ClientFeedbackDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        ClientFeedbackDataGrid.BackgroundColor = SystemColors.ButtonHighlight
        ClientFeedbackDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ClientFeedbackDataGrid.Location = New Point(230, 4)
        ClientFeedbackDataGrid.Margin = New Padding(3, 2, 3, 2)
        ClientFeedbackDataGrid.Name = "ClientFeedbackDataGrid"
        ClientFeedbackDataGrid.RowHeadersWidth = 51
        ClientFeedbackDataGrid.Size = New Size(652, 645)
        ClientFeedbackDataGrid.TabIndex = 9
        ' 
        ' btnAddCF
        ' 
        btnAddCF.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnAddCF.FlatAppearance.BorderSize = 0
        btnAddCF.FlatStyle = FlatStyle.Flat
        btnAddCF.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnAddCF.ForeColor = Color.White
        btnAddCF.Location = New Point(13, 418)
        btnAddCF.Name = "btnAddCF"
        btnAddCF.Size = New Size(209, 37)
        btnAddCF.TabIndex = 28
        btnAddCF.Text = "Add"
        btnAddCF.UseVisualStyleBackColor = False
        ' 
        ' SelfAssessmentTab
        ' 
        SelfAssessmentTab.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        SelfAssessmentTab.Controls.Add(txtFeedbackDateSA)
        SelfAssessmentTab.Controls.Add(btnCancelSA)
        SelfAssessmentTab.Controls.Add(btnClearSA)
        SelfAssessmentTab.Controls.Add(btnDeleteSA)
        SelfAssessmentTab.Controls.Add(btnSaveChangesSA)
        SelfAssessmentTab.Controls.Add(lblTBRRating)
        SelfAssessmentTab.Controls.Add(txtTBRRating)
        SelfAssessmentTab.Controls.Add(txtClientRating)
        SelfAssessmentTab.Controls.Add(lblClientRating)
        SelfAssessmentTab.Controls.Add(lblAccountManagerSA)
        SelfAssessmentTab.Controls.Add(txtAccountManagerSA)
        SelfAssessmentTab.Controls.Add(SelfAssessmentDataGrid)
        SelfAssessmentTab.Controls.Add(lblFeedbackDateSA)
        SelfAssessmentTab.Controls.Add(l)
        SelfAssessmentTab.Controls.Add(txtPersonalPerformanceRating)
        SelfAssessmentTab.Controls.Add(btnAddSA)
        SelfAssessmentTab.Font = New System.Drawing.Font("Gotham", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SelfAssessmentTab.ForeColor = Color.Black
        SelfAssessmentTab.Location = New Point(4, 67)
        SelfAssessmentTab.Name = "SelfAssessmentTab"
        SelfAssessmentTab.Size = New Size(884, 652)
        SelfAssessmentTab.TabIndex = 12
        SelfAssessmentTab.Text = "Self Assessment"
        ' 
        ' txtFeedbackDateSA
        ' 
        txtFeedbackDateSA.Font = New System.Drawing.Font("Gotham", 9F)
        txtFeedbackDateSA.Location = New Point(13, 75)
        txtFeedbackDateSA.Margin = New Padding(3, 2, 3, 2)
        txtFeedbackDateSA.Name = "txtFeedbackDateSA"
        txtFeedbackDateSA.ScrollBars = ScrollBars.Horizontal
        txtFeedbackDateSA.Size = New Size(210, 20)
        txtFeedbackDateSA.TabIndex = 61
        ' 
        ' btnCancelSA
        ' 
        btnCancelSA.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnCancelSA.FlatAppearance.BorderSize = 0
        btnCancelSA.FlatStyle = FlatStyle.Flat
        btnCancelSA.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnCancelSA.ForeColor = Color.White
        btnCancelSA.Location = New Point(13, 341)
        btnCancelSA.Name = "btnCancelSA"
        btnCancelSA.Size = New Size(209, 37)
        btnCancelSA.TabIndex = 42
        btnCancelSA.Text = "Cancel"
        btnCancelSA.UseVisualStyleBackColor = False
        btnCancelSA.Visible = False
        ' 
        ' btnClearSA
        ' 
        btnClearSA.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnClearSA.FlatAppearance.BorderSize = 0
        btnClearSA.FlatStyle = FlatStyle.Flat
        btnClearSA.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnClearSA.ForeColor = Color.White
        btnClearSA.Location = New Point(13, 300)
        btnClearSA.Name = "btnClearSA"
        btnClearSA.Size = New Size(209, 37)
        btnClearSA.TabIndex = 41
        btnClearSA.Text = "Clear"
        btnClearSA.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteSA
        ' 
        btnDeleteSA.BackColor = Color.FromArgb(CByte(221), CByte(60), CByte(39))
        btnDeleteSA.FlatAppearance.BorderSize = 0
        btnDeleteSA.FlatStyle = FlatStyle.Flat
        btnDeleteSA.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnDeleteSA.ForeColor = Color.White
        btnDeleteSA.Location = New Point(121, 258)
        btnDeleteSA.Name = "btnDeleteSA"
        btnDeleteSA.Size = New Size(102, 36)
        btnDeleteSA.TabIndex = 39
        btnDeleteSA.Text = "Delete"
        btnDeleteSA.UseVisualStyleBackColor = False
        btnDeleteSA.Visible = False
        ' 
        ' btnSaveChangesSA
        ' 
        btnSaveChangesSA.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnSaveChangesSA.FlatAppearance.BorderSize = 0
        btnSaveChangesSA.FlatStyle = FlatStyle.Flat
        btnSaveChangesSA.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnSaveChangesSA.ForeColor = Color.White
        btnSaveChangesSA.Location = New Point(13, 258)
        btnSaveChangesSA.Name = "btnSaveChangesSA"
        btnSaveChangesSA.Size = New Size(102, 36)
        btnSaveChangesSA.TabIndex = 38
        btnSaveChangesSA.Text = "Save Changes"
        btnSaveChangesSA.UseVisualStyleBackColor = False
        btnSaveChangesSA.Visible = False
        ' 
        ' lblTBRRating
        ' 
        lblTBRRating.AutoSize = True
        lblTBRRating.ForeColor = Color.White
        lblTBRRating.Location = New Point(13, 212)
        lblTBRRating.Name = "lblTBRRating"
        lblTBRRating.Size = New Size(76, 13)
        lblTBRRating.TabIndex = 35
        lblTBRRating.Text = "TBR Rating"
        ' 
        ' txtTBRRating
        ' 
        txtTBRRating.Font = New System.Drawing.Font("Gotham", 9F)
        txtTBRRating.Location = New Point(13, 229)
        txtTBRRating.Name = "txtTBRRating"
        txtTBRRating.ScrollBars = ScrollBars.Horizontal
        txtTBRRating.Size = New Size(210, 20)
        txtTBRRating.TabIndex = 34
        ' 
        ' txtClientRating
        ' 
        txtClientRating.Font = New System.Drawing.Font("Gotham", 9F)
        txtClientRating.Location = New Point(13, 176)
        txtClientRating.Margin = New Padding(3, 2, 3, 2)
        txtClientRating.Name = "txtClientRating"
        txtClientRating.ScrollBars = ScrollBars.Horizontal
        txtClientRating.Size = New Size(210, 20)
        txtClientRating.TabIndex = 33
        ' 
        ' lblClientRating
        ' 
        lblClientRating.AutoSize = True
        lblClientRating.ForeColor = Color.White
        lblClientRating.Location = New Point(13, 160)
        lblClientRating.Name = "lblClientRating"
        lblClientRating.Size = New Size(84, 13)
        lblClientRating.TabIndex = 32
        lblClientRating.Text = "Client Rating"
        ' 
        ' lblAccountManagerSA
        ' 
        lblAccountManagerSA.AutoSize = True
        lblAccountManagerSA.ForeColor = Color.White
        lblAccountManagerSA.Location = New Point(13, 8)
        lblAccountManagerSA.Name = "lblAccountManagerSA"
        lblAccountManagerSA.Size = New Size(112, 13)
        lblAccountManagerSA.TabIndex = 27
        lblAccountManagerSA.Text = "Account Manager"
        ' 
        ' txtAccountManagerSA
        ' 
        txtAccountManagerSA.Font = New System.Drawing.Font("Gotham", 9F)
        txtAccountManagerSA.Location = New Point(13, 25)
        txtAccountManagerSA.Name = "txtAccountManagerSA"
        txtAccountManagerSA.ScrollBars = ScrollBars.Horizontal
        txtAccountManagerSA.Size = New Size(210, 20)
        txtAccountManagerSA.TabIndex = 26
        ' 
        ' SelfAssessmentDataGrid
        ' 
        SelfAssessmentDataGrid.AllowUserToAddRows = False
        SelfAssessmentDataGrid.AllowUserToDeleteRows = False
        SelfAssessmentDataGrid.AllowUserToOrderColumns = True
        SelfAssessmentDataGrid.AllowUserToResizeColumns = False
        SelfAssessmentDataGrid.AllowUserToResizeRows = False
        SelfAssessmentDataGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        SelfAssessmentDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        SelfAssessmentDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        SelfAssessmentDataGrid.BackgroundColor = SystemColors.ButtonHighlight
        SelfAssessmentDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        SelfAssessmentDataGrid.Location = New Point(230, 4)
        SelfAssessmentDataGrid.Margin = New Padding(3, 2, 3, 2)
        SelfAssessmentDataGrid.Name = "SelfAssessmentDataGrid"
        SelfAssessmentDataGrid.RowHeadersWidth = 51
        SelfAssessmentDataGrid.Size = New Size(1559, 678)
        SelfAssessmentDataGrid.TabIndex = 10
        ' 
        ' lblFeedbackDateSA
        ' 
        lblFeedbackDateSA.AutoSize = True
        lblFeedbackDateSA.ForeColor = Color.White
        lblFeedbackDateSA.Location = New Point(13, 57)
        lblFeedbackDateSA.Name = "lblFeedbackDateSA"
        lblFeedbackDateSA.Size = New Size(98, 13)
        lblFeedbackDateSA.TabIndex = 30
        lblFeedbackDateSA.Text = "Feedback Date"
        ' 
        ' l
        ' 
        l.AutoSize = True
        l.ForeColor = Color.White
        l.Location = New Point(13, 106)
        l.Name = "l"
        l.Size = New Size(181, 13)
        l.TabIndex = 37
        l.Text = "Personal Performance Rating"
        ' 
        ' txtPersonalPerformanceRating
        ' 
        txtPersonalPerformanceRating.Font = New System.Drawing.Font("Gotham", 9F)
        txtPersonalPerformanceRating.Location = New Point(13, 123)
        txtPersonalPerformanceRating.Name = "txtPersonalPerformanceRating"
        txtPersonalPerformanceRating.ScrollBars = ScrollBars.Horizontal
        txtPersonalPerformanceRating.Size = New Size(210, 20)
        txtPersonalPerformanceRating.TabIndex = 36
        ' 
        ' btnAddSA
        ' 
        btnAddSA.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnAddSA.FlatAppearance.BorderSize = 0
        btnAddSA.FlatStyle = FlatStyle.Flat
        btnAddSA.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnAddSA.ForeColor = Color.White
        btnAddSA.Location = New Point(13, 258)
        btnAddSA.Name = "btnAddSA"
        btnAddSA.Size = New Size(209, 37)
        btnAddSA.TabIndex = 40
        btnAddSA.Text = "Add"
        btnAddSA.UseVisualStyleBackColor = False
        ' 
        ' CompetencyCertificationsTab
        ' 
        CompetencyCertificationsTab.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        CompetencyCertificationsTab.Controls.Add(txtGrantDateCC)
        CompetencyCertificationsTab.Controls.Add(btnCancelCC)
        CompetencyCertificationsTab.Controls.Add(btnClearCC)
        CompetencyCertificationsTab.Controls.Add(btnDeleteCC)
        CompetencyCertificationsTab.Controls.Add(btnSaveChangesCC)
        CompetencyCertificationsTab.Controls.Add(btnAddCC)
        CompetencyCertificationsTab.Controls.Add(txtOverallGrade)
        CompetencyCertificationsTab.Controls.Add(lblOverallGrade)
        CompetencyCertificationsTab.Controls.Add(lblGrantDateCC)
        CompetencyCertificationsTab.Controls.Add(txtCertificationName)
        CompetencyCertificationsTab.Controls.Add(lblCertificationName)
        CompetencyCertificationsTab.Controls.Add(CompetencyCertificationDataGrid)
        CompetencyCertificationsTab.Controls.Add(txtDeliberationSummary)
        CompetencyCertificationsTab.Controls.Add(lblDeliberationSummary)
        CompetencyCertificationsTab.Font = New System.Drawing.Font("Gotham", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CompetencyCertificationsTab.ForeColor = Color.Black
        CompetencyCertificationsTab.Location = New Point(4, 67)
        CompetencyCertificationsTab.Name = "CompetencyCertificationsTab"
        CompetencyCertificationsTab.Size = New Size(884, 652)
        CompetencyCertificationsTab.TabIndex = 13
        CompetencyCertificationsTab.Text = "Competency Certifications"
        ' 
        ' txtGrantDateCC
        ' 
        txtGrantDateCC.Font = New System.Drawing.Font("Gotham", 9F)
        txtGrantDateCC.Location = New Point(13, 126)
        txtGrantDateCC.Margin = New Padding(3, 2, 3, 2)
        txtGrantDateCC.Name = "txtGrantDateCC"
        txtGrantDateCC.ScrollBars = ScrollBars.Horizontal
        txtGrantDateCC.Size = New Size(210, 20)
        txtGrantDateCC.TabIndex = 48
        ' 
        ' btnCancelCC
        ' 
        btnCancelCC.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnCancelCC.FlatAppearance.BorderSize = 0
        btnCancelCC.FlatStyle = FlatStyle.Flat
        btnCancelCC.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnCancelCC.ForeColor = Color.White
        btnCancelCC.Location = New Point(13, 504)
        btnCancelCC.Name = "btnCancelCC"
        btnCancelCC.Size = New Size(209, 37)
        btnCancelCC.TabIndex = 47
        btnCancelCC.Text = "Cancel"
        btnCancelCC.UseVisualStyleBackColor = False
        btnCancelCC.Visible = False
        ' 
        ' btnClearCC
        ' 
        btnClearCC.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnClearCC.FlatAppearance.BorderSize = 0
        btnClearCC.FlatStyle = FlatStyle.Flat
        btnClearCC.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnClearCC.ForeColor = Color.White
        btnClearCC.Location = New Point(13, 463)
        btnClearCC.Name = "btnClearCC"
        btnClearCC.Size = New Size(209, 37)
        btnClearCC.TabIndex = 46
        btnClearCC.Text = "Clear"
        btnClearCC.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteCC
        ' 
        btnDeleteCC.BackColor = Color.FromArgb(CByte(221), CByte(60), CByte(39))
        btnDeleteCC.FlatAppearance.BorderSize = 0
        btnDeleteCC.FlatStyle = FlatStyle.Flat
        btnDeleteCC.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnDeleteCC.ForeColor = Color.White
        btnDeleteCC.Location = New Point(121, 421)
        btnDeleteCC.Name = "btnDeleteCC"
        btnDeleteCC.Size = New Size(102, 36)
        btnDeleteCC.TabIndex = 44
        btnDeleteCC.Text = "Delete"
        btnDeleteCC.UseVisualStyleBackColor = False
        btnDeleteCC.Visible = False
        ' 
        ' btnSaveChangesCC
        ' 
        btnSaveChangesCC.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnSaveChangesCC.FlatAppearance.BorderSize = 0
        btnSaveChangesCC.FlatStyle = FlatStyle.Flat
        btnSaveChangesCC.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnSaveChangesCC.ForeColor = Color.White
        btnSaveChangesCC.Location = New Point(13, 421)
        btnSaveChangesCC.Name = "btnSaveChangesCC"
        btnSaveChangesCC.Size = New Size(102, 36)
        btnSaveChangesCC.TabIndex = 43
        btnSaveChangesCC.Text = "Save Changes"
        btnSaveChangesCC.UseVisualStyleBackColor = False
        btnSaveChangesCC.Visible = False
        ' 
        ' btnAddCC
        ' 
        btnAddCC.BackColor = Color.FromArgb(CByte(245), CByte(206), CByte(0))
        btnAddCC.FlatAppearance.BorderSize = 0
        btnAddCC.FlatStyle = FlatStyle.Flat
        btnAddCC.Font = New System.Drawing.Font("Gotham", 8.999999F, FontStyle.Bold)
        btnAddCC.ForeColor = Color.White
        btnAddCC.Location = New Point(13, 421)
        btnAddCC.Name = "btnAddCC"
        btnAddCC.Size = New Size(209, 37)
        btnAddCC.TabIndex = 45
        btnAddCC.Text = "Add"
        btnAddCC.UseVisualStyleBackColor = False
        ' 
        ' txtOverallGrade
        ' 
        txtOverallGrade.Font = New System.Drawing.Font("Gotham", 9F)
        txtOverallGrade.Location = New Point(13, 390)
        txtOverallGrade.Margin = New Padding(3, 2, 3, 2)
        txtOverallGrade.Name = "txtOverallGrade"
        txtOverallGrade.ScrollBars = ScrollBars.Horizontal
        txtOverallGrade.Size = New Size(210, 20)
        txtOverallGrade.TabIndex = 34
        ' 
        ' lblOverallGrade
        ' 
        lblOverallGrade.AutoSize = True
        lblOverallGrade.ForeColor = Color.White
        lblOverallGrade.Location = New Point(13, 374)
        lblOverallGrade.Name = "lblOverallGrade"
        lblOverallGrade.Size = New Size(89, 13)
        lblOverallGrade.TabIndex = 33
        lblOverallGrade.Text = "Overall Grade"
        ' 
        ' lblGrantDateCC
        ' 
        lblGrantDateCC.AutoSize = True
        lblGrantDateCC.ForeColor = Color.White
        lblGrantDateCC.Location = New Point(13, 108)
        lblGrantDateCC.Name = "lblGrantDateCC"
        lblGrantDateCC.Size = New Size(72, 13)
        lblGrantDateCC.TabIndex = 31
        lblGrantDateCC.Text = "Grant Date"
        ' 
        ' txtCertificationName
        ' 
        txtCertificationName.Font = New System.Drawing.Font("Gotham", 9F)
        txtCertificationName.Location = New Point(13, 24)
        txtCertificationName.Margin = New Padding(3, 2, 3, 2)
        txtCertificationName.Multiline = True
        txtCertificationName.Name = "txtCertificationName"
        txtCertificationName.ScrollBars = ScrollBars.Both
        txtCertificationName.Size = New Size(210, 75)
        txtCertificationName.TabIndex = 30
        ' 
        ' lblCertificationName
        ' 
        lblCertificationName.AutoSize = True
        lblCertificationName.ForeColor = Color.White
        lblCertificationName.Location = New Point(13, 8)
        lblCertificationName.Name = "lblCertificationName"
        lblCertificationName.Size = New Size(118, 13)
        lblCertificationName.TabIndex = 29
        lblCertificationName.Text = "Certification Name"
        ' 
        ' CompetencyCertificationDataGrid
        ' 
        CompetencyCertificationDataGrid.AllowUserToAddRows = False
        CompetencyCertificationDataGrid.AllowUserToDeleteRows = False
        CompetencyCertificationDataGrid.AllowUserToOrderColumns = True
        CompetencyCertificationDataGrid.AllowUserToResizeColumns = False
        CompetencyCertificationDataGrid.AllowUserToResizeRows = False
        CompetencyCertificationDataGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        CompetencyCertificationDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        CompetencyCertificationDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        CompetencyCertificationDataGrid.BackgroundColor = SystemColors.ButtonHighlight
        CompetencyCertificationDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        CompetencyCertificationDataGrid.Location = New Point(230, 4)
        CompetencyCertificationDataGrid.Margin = New Padding(3, 2, 3, 2)
        CompetencyCertificationDataGrid.Name = "CompetencyCertificationDataGrid"
        CompetencyCertificationDataGrid.RowHeadersWidth = 51
        CompetencyCertificationDataGrid.Size = New Size(652, 645)
        CompetencyCertificationDataGrid.TabIndex = 11
        ' 
        ' txtDeliberationSummary
        ' 
        txtDeliberationSummary.Font = New System.Drawing.Font("Gotham", 9F)
        txtDeliberationSummary.Location = New Point(13, 177)
        txtDeliberationSummary.Margin = New Padding(3, 2, 3, 2)
        txtDeliberationSummary.Multiline = True
        txtDeliberationSummary.Name = "txtDeliberationSummary"
        txtDeliberationSummary.ScrollBars = ScrollBars.Both
        txtDeliberationSummary.Size = New Size(210, 190)
        txtDeliberationSummary.TabIndex = 28
        ' 
        ' lblDeliberationSummary
        ' 
        lblDeliberationSummary.AutoSize = True
        lblDeliberationSummary.ForeColor = Color.White
        lblDeliberationSummary.Location = New Point(13, 160)
        lblDeliberationSummary.Name = "lblDeliberationSummary"
        lblDeliberationSummary.Size = New Size(139, 13)
        lblDeliberationSummary.TabIndex = 27
        lblDeliberationSummary.Text = "Deliberation Summary"
        ' 
        ' PrintEmployeeDetailsDialog
        ' 
        PrintEmployeeDetailsDialog.AutoScrollMargin = New Size(0, 0)
        PrintEmployeeDetailsDialog.AutoScrollMinSize = New Size(0, 0)
        PrintEmployeeDetailsDialog.ClientSize = New Size(400, 300)
        PrintEmployeeDetailsDialog.Enabled = True
        PrintEmployeeDetailsDialog.Icon = CType(resources.GetObject("PrintEmployeeDetailsDialog.Icon"), Icon)
        PrintEmployeeDetailsDialog.Name = "PrintEmployeeDetailsDialog"
        PrintEmployeeDetailsDialog.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(53), CByte(37), CByte(107))
        Panel1.Controls.Add(lblEPName)
        Panel1.Controls.Add(picboxMenu)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(945, 53)
        Panel1.TabIndex = 12
        ' 
        ' lblEPName
        ' 
        lblEPName.AutoSize = True
        lblEPName.BackColor = Color.Transparent
        lblEPName.Font = New System.Drawing.Font("Gotham", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, CByte(161))
        lblEPName.ForeColor = Color.White
        lblEPName.Location = New Point(68, 13)
        lblEPName.Margin = New Padding(0)
        lblEPName.Name = "lblEPName"
        lblEPName.Size = New Size(250, 31)
        lblEPName.TabIndex = 47
        lblEPName.Text = "Employee Profile"
        ' 
        ' picboxMenu
        ' 
        picboxMenu.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        picboxMenu.BackColor = Color.Transparent
        picboxMenu.BackgroundImage = CType(resources.GetObject("picboxMenu.BackgroundImage"), Drawing.Image)
        picboxMenu.BackgroundImageLayout = ImageLayout.Zoom
        picboxMenu.Cursor = Cursors.Hand
        picboxMenu.Location = New Point(879, 10)
        picboxMenu.Margin = New Padding(70, 30, 30, 30)
        picboxMenu.Name = "picboxMenu"
        picboxMenu.Padding = New Padding(30, 0, 0, 0)
        picboxMenu.Size = New Size(66, 38)
        picboxMenu.TabIndex = 34
        picboxMenu.TabStop = False
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
        ' grpEmployeeProfile
        ' 
        grpEmployeeProfile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        grpEmployeeProfile.BackColor = Color.FromArgb(CByte(52), CByte(37), CByte(107))
        grpEmployeeProfile.BackgroundImageLayout = ImageLayout.None
        grpEmployeeProfile.Controls.Add(btnChangePassword)
        grpEmployeeProfile.Controls.Add(txtEmployeeNumber)
        grpEmployeeProfile.Controls.Add(lblEmployeeID)
        grpEmployeeProfile.Controls.Add(txtEmployeeIDAdmin)
        grpEmployeeProfile.Controls.Add(lblLastName)
        grpEmployeeProfile.Controls.Add(btnUserCancel)
        grpEmployeeProfile.Controls.Add(btnAttemptedAccess)
        grpEmployeeProfile.Controls.Add(txtFirstName)
        grpEmployeeProfile.Controls.Add(btnSave)
        grpEmployeeProfile.Controls.Add(btnEdit)
        grpEmployeeProfile.Controls.Add(lblFirstName)
        grpEmployeeProfile.Controls.Add(txtLastName)
        grpEmployeeProfile.FlatStyle = FlatStyle.Flat
        grpEmployeeProfile.Location = New Point(659, 45)
        grpEmployeeProfile.Margin = New Padding(3, 2, 3, 2)
        grpEmployeeProfile.Name = "grpEmployeeProfile"
        grpEmployeeProfile.Padding = New Padding(3, 2, 3, 2)
        grpEmployeeProfile.Size = New Size(288, 434)
        grpEmployeeProfile.TabIndex = 13
        grpEmployeeProfile.TabStop = False
        grpEmployeeProfile.Visible = False
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
        ' txtEmployeeNumber
        ' 
        txtEmployeeNumber.BackColor = Color.White
        txtEmployeeNumber.BorderStyle = BorderStyle.None
        txtEmployeeNumber.Enabled = False
        txtEmployeeNumber.Font = New System.Drawing.Font("Gotham", 12F)
        txtEmployeeNumber.ForeColor = SystemColors.WindowText
        txtEmployeeNumber.Location = New Point(36, 372)
        txtEmployeeNumber.Margin = New Padding(3, 2, 3, 2)
        txtEmployeeNumber.Name = "txtEmployeeNumber"
        txtEmployeeNumber.Size = New Size(228, 17)
        txtEmployeeNumber.TabIndex = 14
        txtEmployeeNumber.Visible = False
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
        ' btnUserCancel
        ' 
        btnUserCancel.BackColor = Color.FromArgb(CByte(245), CByte(155), CByte(184))
        btnUserCancel.FlatAppearance.BorderSize = 0
        btnUserCancel.FlatStyle = FlatStyle.Flat
        btnUserCancel.Font = New System.Drawing.Font("Gotham", 10.8F, FontStyle.Bold)
        btnUserCancel.ForeColor = Color.White
        btnUserCancel.Location = New Point(147, 306)
        btnUserCancel.Margin = New Padding(3, 2, 3, 2)
        btnUserCancel.Name = "btnUserCancel"
        btnUserCancel.Size = New Size(116, 46)
        btnUserCancel.TabIndex = 10
        btnUserCancel.Text = "Cancel"
        btnUserCancel.UseVisualStyleBackColor = False
        btnUserCancel.Visible = False
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
        btnSave.Size = New Size(112, 46)
        btnSave.TabIndex = 5
        btnSave.Text = "Save Changes"
        btnSave.UseVisualStyleBackColor = False
        btnSave.Visible = False
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
        ' PictureBox6
        ' 
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Drawing.Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox6.Location = New Point(808, 320)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(86, 75)
        PictureBox6.TabIndex = 44
        PictureBox6.TabStop = False
        ' 
        ' EmployeeF
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.White
        ClientSize = New Size(945, 809)
        Controls.Add(grpEmployeeProfile)
        Controls.Add(Panel1)
        Controls.Add(EmployeeTabControl)
        Controls.Add(PictureBox6)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        ImeMode = ImeMode.Hiragana
        Margin = New Padding(3, 2, 3, 2)
        MinimumSize = New Size(961, 848)
        Name = "EmployeeF"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee Profiling"
        EmployeeTabControl.ResumeLayout(False)
        EmployeeProfileTab.ResumeLayout(False)
        EmployeeProfileTab.PerformLayout()
        CType(EmployeeProfileDataGrid, ComponentModel.ISupportInitialize).EndInit()
        JobHistoryTab.ResumeLayout(False)
        JobHistoryTab.PerformLayout()
        CType(JobHistoryDataGrid, ComponentModel.ISupportInitialize).EndInit()
        TaskProfileTab.ResumeLayout(False)
        TaskProfileTab.PerformLayout()
        CType(TaskProfileDataGrid, ComponentModel.ISupportInitialize).EndInit()
        SoftwareAndToolsTab.ResumeLayout(False)
        SoftwareAndToolsTab.PerformLayout()
        CType(SoftwareAndToolsDataGrid, ComponentModel.ISupportInitialize).EndInit()
        SkillsInterviewTab.ResumeLayout(False)
        SkillsInterviewTab.PerformLayout()
        CType(SkillsInterviewDataGrid, ComponentModel.ISupportInitialize).EndInit()
        PerformanceEvaluationTab.ResumeLayout(False)
        PerformanceEvaluationTab.PerformLayout()
        CType(PerformanceEvaluationDataGrid, ComponentModel.ISupportInitialize).EndInit()
        SkillsTriageTab.ResumeLayout(False)
        SkillsTriageTab.PerformLayout()
        CType(SkillsTriageDataGrid, ComponentModel.ISupportInitialize).EndInit()
        TrainingHistoryTab.ResumeLayout(False)
        TrainingHistoryTab.PerformLayout()
        CType(TrainingHistoryDataGrid, ComponentModel.ISupportInitialize).EndInit()
        CertificationsAndLicenses.ResumeLayout(False)
        CertificationsAndLicenses.PerformLayout()
        CType(CertificationAndLicensesDataGrid, ComponentModel.ISupportInitialize).EndInit()
        TrainingPlanTab.ResumeLayout(False)
        TrainingPlanTab.PerformLayout()
        CType(TrainingPlanDataGrid, ComponentModel.ISupportInitialize).EndInit()
        TrainingProgramsTab.ResumeLayout(False)
        TrainingProgramsTab.PerformLayout()
        CType(TrainingProgramsDataGrid, ComponentModel.ISupportInitialize).EndInit()
        WebinarsAttendedTab.ResumeLayout(False)
        WebinarsAttendedTab.PerformLayout()
        CType(WebinarsAttendedDataGrid, ComponentModel.ISupportInitialize).EndInit()
        ClientFeedbackTab.ResumeLayout(False)
        ClientFeedbackTab.PerformLayout()
        CType(ClientFeedbackDataGrid, ComponentModel.ISupportInitialize).EndInit()
        SelfAssessmentTab.ResumeLayout(False)
        SelfAssessmentTab.PerformLayout()
        CType(SelfAssessmentDataGrid, ComponentModel.ISupportInitialize).EndInit()
        CompetencyCertificationsTab.ResumeLayout(False)
        CompetencyCertificationsTab.PerformLayout()
        CType(CompetencyCertificationDataGrid, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(picboxMenu, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        grpEmployeeProfile.ResumeLayout(False)
        grpEmployeeProfile.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents EmployeeTabControl As TabControl
    Friend WithEvents JobHistoryTab As TabPage
    Friend WithEvents TaskProfileTab As TabPage
    Friend WithEvents JobHistoryDataGrid As DataGridView
    Friend WithEvents lblRoleDesignation As Label
    Friend WithEvents txtRoleDesignation As TextBox
    Friend WithEvents lblClientName As Label
    Friend WithEvents txtEndDate As TextBox
    Friend WithEvents lblEndDate As Label
    Friend WithEvents txtStartDate As TextBox
    Friend WithEvents lblStartDate As Label
    Friend WithEvents txtRegion As TextBox
    Friend WithEvents lblRegion As Label
    Friend WithEvents txtReasonForChange As TextBox
    Friend WithEvents lblReasonFrChange As Label
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents SoftwareAndToolsTab As TabPage
    Friend WithEvents SkillsInterviewTab As TabPage
    Friend WithEvents PerformanceEvaluationTab As TabPage
    Friend WithEvents SkillsTriageTab As TabPage
    Friend WithEvents TrainingHistoryTab As TabPage
    Friend WithEvents CertificationsAndLicenses As TabPage
    Friend WithEvents TrainingPlanTab As TabPage
    Friend WithEvents TrainingProgramsTab As TabPage
    Friend WithEvents WebinarsAttendedTab As TabPage
    Friend WithEvents TaskProfileDataGrid As DataGridView
    Friend WithEvents txtTaskName As TextBox
    Friend WithEvents lblTaskProfile As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents txtPOC As TextBox
    Friend WithEvents lblPOC As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents SoftwareAndToolsDataGrid As DataGridView
    Friend WithEvents SkillsInterviewDataGrid As DataGridView
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblUsedFor As Label
    Friend WithEvents txtUsedFor As TextBox
    Friend WithEvents lblSoftwareOrTools As Label
    Friend WithEvents txtSoftwareOrTools As TextBox
    Friend WithEvents btnClearST As Button
    Friend WithEvents btnAddST As Button
    Friend WithEvents btnCancelST As Button
    Friend WithEvents btnDeleteST As Button
    Friend WithEvents btnSaveChangesST As Button
    Friend WithEvents txtRoleOrDesignation As TextBox
    Friend WithEvents lblRoleOrDesignation As Label
    Friend WithEvents lblInterviewer As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents txtInterviewer As TextBox
    Friend WithEvents lblAssessmentNotes As Label
    Friend WithEvents btnAddSI As Button
    Friend WithEvents txtAssessmentNotes As TextBox
    Friend WithEvents btnSaveChangesSI As Button
    Friend WithEvents btnCancelSI As Button
    Friend WithEvents btnClearSI As Button
    Friend WithEvents btnDeleteSI As Button
    Friend WithEvents PerformanceEvaluationDataGrid As DataGridView
    Friend WithEvents txtEvaluationType As TextBox
    Friend WithEvents lblEvaluationType As Label
    Friend WithEvents lblEvaluationDate As Label
    Friend WithEvents txtEvaluator As TextBox
    Friend WithEvents lblEvaluator As Label
    Friend WithEvents txtEvaluationNotes As TextBox
    Friend WithEvents lblEvaluationNotes As Label
    Friend WithEvents btnAddPE As Button
    Friend WithEvents btnCancelPE As Button
    Friend WithEvents btnClearPE As Button
    Friend WithEvents btnSaveChangesPE As Button
    Friend WithEvents btnDeletePE As Button
    Friend WithEvents SkillsTriageDataGrid As DataGridView
    Friend WithEvents txtConcernBy As TextBox
    Friend WithEvents lblConcernBy As Label
    Friend WithEvents lblDateClose As Label
    Friend WithEvents lblStartDateT As Label
    Friend WithEvents txtDetailsOfConcern As TextBox
    Friend WithEvents lblDetailsOfConcern As Label
    Friend WithEvents btnAddT As Button
    Friend WithEvents btnClearT As Button
    Friend WithEvents btnCancelT As Button
    Friend WithEvents btnDeleteT As Button
    Friend WithEvents btnSaveChangesT As Button
    Friend WithEvents txtDeliberationNotes As TextBox
    Friend WithEvents lblDeliberationNotes As Label
    Friend WithEvents txtDeliberationScore As TextBox
    Friend WithEvents lblDeliberationScore As Label
    Friend WithEvents TrainingHistoryDataGrid As DataGridView
    Friend WithEvents CertificationAndLicensesDataGrid As DataGridView
    Friend WithEvents TrainingPlanDataGrid As DataGridView
    Friend WithEvents TrainingProgramsDataGrid As DataGridView
    Friend WithEvents WebinarsAttendedDataGrid As DataGridView
    Friend WithEvents txtFacilitator As TextBox
    Friend WithEvents lblFacilitator As Label
    Friend WithEvents txtTopicOrModuleTitle As TextBox
    Friend WithEvents lblTopicOrModuleTitle As Label
    Friend WithEvents lblCompletion As Label
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents lblGrade As Label
    Friend WithEvents btnSaveChangesTH As Button
    Friend WithEvents btnClearTH As Button
    Friend WithEvents btnCancelTH As Button
    Friend WithEvents btnDeleteTH As Button
    Friend WithEvents btnAddTH As Button
    Friend WithEvents txtLicenseNumber As TextBox
    Friend WithEvents lblLicenseNumber As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtProvider As TextBox
    Friend WithEvents lblProvider As Label
    Friend WithEvents lblGrantDate As Label
    Friend WithEvents lblExpiryDate As Label
    Friend WithEvents txtCertificateName As TextBox
    Friend WithEvents lblCertificateName As Label
    Friend WithEvents btnCancelCL As Button
    Friend WithEvents btnClearCL As Button
    Friend WithEvents btnDeleteCL As Button
    Friend WithEvents btnSaveChangesCL As Button
    Friend WithEvents btnAddCL As Button
    Friend WithEvents btnSaveChangesP As Button
    Friend WithEvents btnDeleteP As Button
    Friend WithEvents btnCancelP As Button
    Friend WithEvents btnClearP As Button
    Friend WithEvents btnAddP As Button
    Friend WithEvents lblTargetDate As Label
    Friend WithEvents txtTopicOrModuleName As TextBox
    Friend WithEvents lblTopicOrModuleName As Label
    Friend WithEvents txtFacilitatorP As TextBox
    Friend WithEvents lblFacilitatorP As Label
    Friend WithEvents dtpckerTargetDate As DateTimePicker
    Friend WithEvents dtpckerCompletionDate As DateTimePicker
    Friend WithEvents txtDeliberationNotesTPr As TextBox
    Friend WithEvents lblDeliberationNotesTPr As Label
    Friend WithEvents lblCompletionDate As Label
    Friend WithEvents lblStartDateTPr As Label
    Friend WithEvents txtProgramTitle As TextBox
    Friend WithEvents lblProgramTitle As Label
    Friend WithEvents txtDeliberationScoreTPr As TextBox
    Friend WithEvents lblDeliberationScoreTPr As Label
    Friend WithEvents btnCancelTPr As Button
    Friend WithEvents btnClearTPr As Button
    Friend WithEvents btnDeleteTPr As Button
    Friend WithEvents btnSaveChangesTPr As Button
    Friend WithEvents btnAddTPr As Button
    Friend WithEvents btnCancelW As Button
    Friend WithEvents btnClearW As Button
    Friend WithEvents btnDeleteW As Button
    Friend WithEvents btnSaveChangesW As Button
    Friend WithEvents txtWebinarTitle As TextBox
    Friend WithEvents lblWebinarTitle As Label
    Friend WithEvents lblCPDUnits As Label
    Friend WithEvents lblDateW As Label
    Friend WithEvents txtCPDUnits As TextBox
    Friend WithEvents btnAddW As Button
    Friend WithEvents btnExportEmploye As Button
    Friend WithEvents PrintEmployeeDetails As Printing.PrintDocument
    Friend WithEvents PrintEmployeeDetailsDialog As PrintPreviewDialog
    Friend WithEvents ClientFeedbackTab As TabPage
    Friend WithEvents ClientFeedbackDataGrid As DataGridView
    Friend WithEvents SelfAssessmentTab As TabPage
    Friend WithEvents SelfAssessmentDataGrid As DataGridView
    Friend WithEvents CompetencyCertificationsTab As TabPage
    Friend WithEvents CompetencyCertificationDataGrid As DataGridView
    Friend WithEvents txtAccountManager As TextBox
    Friend WithEvents txtFeedbackSummary As TextBox
    Friend WithEvents lblFeedbackSummary As Label
    Friend WithEvents dtpckerFeedbackDate As DateTimePicker
    Friend WithEvents lblFeedbackDate As Label
    Friend WithEvents txt As Label
    Friend WithEvents txtClientPOC As TextBox
    Friend WithEvents lblAccountManager As Label
    Friend WithEvents btnCancelCF As Button
    Friend WithEvents btnClearCF As Button
    Friend WithEvents btnDeleteCF As Button
    Friend WithEvents btnSaveChangesCF As Button
    Friend WithEvents lblStaffPerformanceRating As Label
    Friend WithEvents txtStaffPerformanceRating As TextBox
    Friend WithEvents btnAddCF As Button
    Friend WithEvents lblTBRRating As Label
    Friend WithEvents txtTBRRating As TextBox
    Friend WithEvents txtClientRating As TextBox
    Friend WithEvents lblClientRating As Label
    Friend WithEvents lblAccountManagerSA As Label
    Friend WithEvents txtAccountManagerSA As TextBox
    Friend WithEvents dtpckerFeedbackDateSA As DateTimePicker
    Friend WithEvents lblFeedbackDateSA As Label
    Friend WithEvents l As Label
    Friend WithEvents txtPersonalPerformanceRating As TextBox
    Friend WithEvents btnCancelSA As Button
    Friend WithEvents btnClearSA As Button
    Friend WithEvents btnDeleteSA As Button
    Friend WithEvents btnSaveChangesSA As Button
    Friend WithEvents btnAddSA As Button
    Friend WithEvents txtOverallGrade As TextBox
    Friend WithEvents lblOverallGrade As Label
    Friend WithEvents dtpckerGrantDateCC As DateTimePicker
    Friend WithEvents lblGrantDateCC As Label
    Friend WithEvents txtCertificationName As TextBox
    Friend WithEvents lblCertificationName As Label
    Friend WithEvents txtDeliberationSummary As TextBox
    Friend WithEvents lblDeliberationSummary As Label
    Friend WithEvents btnCancelCC As Button
    Friend WithEvents btnClearCC As Button
    Friend WithEvents btnDeleteCC As Button
    Friend WithEvents btnSaveChangesCC As Button
    Friend WithEvents btnAddCC As Button
    Friend WithEvents chkNATP As CheckBox
    Friend WithEvents txtChapter As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpckerGrantDate As TextBox
    Friend WithEvents dtpckerExpiryDate As TextBox
    Friend WithEvents txtStartDateJ As TextBox
    Friend WithEvents txtEndDateJ As TextBox
    Friend WithEvents dtpckerDate As TextBox
    Friend WithEvents dtpckerEvalutionDate As TextBox
    Friend WithEvents dtpckerStartDateT As TextBox
    Friend WithEvents dtpckerDateClose As TextBox
    Friend WithEvents dtpckerCompletion As TextBox
    Friend WithEvents txtTargetDate As TextBox
    Friend WithEvents txtStartDateTPr As TextBox
    Friend WithEvents txtFeedbackDateSA As TextBox
    Friend WithEvents txtCompletionDateTPr As TextBox
    Friend WithEvents txtDateW As TextBox
    Friend WithEvents txtFeedbackDate As TextBox
    Friend WithEvents txtGrantDateCC As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents EmployeeProfileTab As TabPage
    Friend WithEvents EmployeeProfileDataGrid As DataGridView
    Friend WithEvents btnSaveEP As Button
    Friend WithEvents btnCancelEP As Button
    Friend WithEvents txtSharepointLink As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLastUpdate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents chkbxIsActive As CheckBox
    Friend WithEvents txtClientName As TextBox
    Friend WithEvents picboxMenu As PictureBox
    Friend WithEvents grpEmployeeProfile As GroupBox
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents lblEmployeeID As Label
    Friend WithEvents txtEmployeeIDAdmin As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents btnUserCancel As Button
    Friend WithEvents btnAttemptedAccess As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmployeeNumber As TextBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents btnCancelTP As Button
    Friend WithEvents btnClearTP As Button
    Friend WithEvents btnDeleteTP As Button
    Friend WithEvents btnSaveChangesTP As Button
    Friend WithEvents btnAddTP As Button
    Friend WithEvents lblEPName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnExportPDF As Button
    Friend WithEvents btnExportExcelSheets As Button
End Class
