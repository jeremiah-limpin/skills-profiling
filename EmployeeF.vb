Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.Office.Interop
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Org.BouncyCastle
Imports System.Runtime.InteropServices


Public Class EmployeeF
    Dim connection As OleDbConnection = SkillsProfile_Database.GetConnection()
    Public Property employeeNumber As String
    Public Property EmployeeID As String

    'Declaring instances of respective classes for this form
    Dim employeeProfile As New EmployeeProfileClass(Me)
    Dim jobHistory As New JobHistoryClass(Me)
    Dim taskProfile As New TaskProfileClass(Me)
    Dim softwareAndTools As New SoftwareAndToolsClass(Me)
    Dim skillsInterview As New SkillsInterviewClass(Me)
    Dim performanceEvaluation As New PerformanceEvaluationClass(Me)
    Dim skillsTriage As New SkillsTriageClass(Me)
    Dim trainingHistory As New TrainingHistoryClass(Me)
    Dim certificationAndLicenses As New CertificationAndLicensesClass(Me)
    Dim trainingPlan As New TrainingPlanClass(Me)
    Dim trainingPrograms As New TrainingProgramsClass(Me)
    Dim webinarsAttended As New WebinarsAttendedClass(Me)
    Dim clientFeedback As New ClientFeedbackClass(Me)
    Dim selfAssessment As New SelfAssessmentClass(Me)
    Dim competencyCertification As New CompetencyCertificationClass(Me)

    'this is for user
    Public employeeRoleUser As Integer

    ' this is for the text change
    Private changesMade As Boolean = False

    ' this is for checking if password textbox has been edited
    Private passwordEdited As Boolean = False

    ' this is for button color when clicked to revert
    Private originalBackColor As Color
    Private originalForeColor As Color

    Dim employeeRole As Integer

    ' for the update permission button
    Dim PermissionUpdate As Boolean

    'this is for admin
    Public employeeRoleAdmin As Integer

    Dim PutBackColor As Boolean = False

#Region "Tab Formatting"
#Region "Employee Profile Formatting"
    Public Sub ApplyEmployeeProfileFormatting()

        Dim query As String = "SELECT Employee_ID, Employee_First_Name, Employee_Last_Name, Last_Update, Status, Sharepoint_Link FROM Employee_Profile WHERE Employee_Number = @EmployeeNumber"

        Dim adapter As New OleDbDataAdapter(query, connection)
        adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)

        EmployeeProfileDataGrid.DataSource = dataTable

        ' format of the Skills Triage Data Grid
        EmployeeProfileDataGrid.DefaultCellStyle.Padding = New Padding(8, 8, 8, 8)
        EmployeeProfileDataGrid.ReadOnly = True
        EmployeeProfileDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        EmployeeProfileDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        EmployeeProfileDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

        If EmployeeProfileDataGrid.Columns.Contains("Employee_ID") Then
            EmployeeProfileDataGrid.Columns("Employee_ID").Visible = False
        End If

        ' default width is 226
        'EmployeeProfileDataGrid.Columns("Concern_By").Width = 226
        'EmployeeProfileDataGrid.Columns("Start_Date").Width = 226
        'EmployeeProfileDataGrid.Columns("Date_Closed").Width = 226
        'EmployeeProfileDataGrid.Columns("Details_of_Concern").Width = 226
        'EmployeeProfileDataGrid.Columns("Deliberation_Score").Width = 226
        'EmployeeProfileDataGrid.Columns("Deliberation_Notes").Width = 226

        EmployeeProfileDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        EmployeeProfileDataGrid.MultiSelect = False
        EmployeeProfileDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        For Each column As DataGridViewColumn In EmployeeProfileDataGrid.Columns
            If column.HeaderText.Contains("_") Then
                column.HeaderText = column.HeaderText.Replace("_", " ")
            End If
        Next
    End Sub
#End Region 'Done
#Region "Job History Formatting"
    Public Sub ApplyJobHistoryFormatting()
        Dim query As String = "SELECT Job_ID, Role_and_Designation, Client_Name, Region, Start_Date, End_Date, Reason_for_Change FROM Job_History WHERE Employee_Number = @EmployeeNumber"

        Dim adapter As New OleDbDataAdapter(query, connection)
        adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)

        JobHistoryDataGrid.DataSource = dataTable

        If JobHistoryDataGrid.Columns.Contains("Job_ID") Then
            JobHistoryDataGrid.Columns("Job_ID").Visible = False
        End If

        ' format of the Job History Data Grid
        JobHistoryDataGrid.DefaultCellStyle.Padding = New Padding(8, 8, 8, 8)
        JobHistoryDataGrid.ReadOnly = True
        JobHistoryDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        JobHistoryDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        JobHistoryDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing



        ' Remove manual column width settings
        'JobHistoryDataGrid.Columns("Role_and_Designation").Width = 268
        'JobHistoryDataGrid.Columns("Client_Name").Width = 348
        'JobHistoryDataGrid.Columns("Region").Width = 128
        'JobHistoryDataGrid.Columns("Start_Date").Width = 218
        'JobHistoryDataGrid.Columns("End_Date").Width = 218
        'JobHistoryDataGrid.Columns("Reason_for_Change").Width = 424

        ' Set AutoSizeColumnsMode to Fill
        JobHistoryDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        JobHistoryDataGrid.MultiSelect = False
        JobHistoryDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        For Each column As DataGridViewColumn In JobHistoryDataGrid.Columns
            If column.HeaderText.Contains("_") Then
                column.HeaderText = column.HeaderText.Replace("_", " ")
            End If
        Next
    End Sub

#End Region 'Done
#Region "Task Profile Formatting"
    Private Sub ApplyTaskProfileFormatting()

        Dim query As String = "SELECT Task_ID, Task_Name, Category, POC, Description FROM Task_Profile WHERE Employee_Number = @EmployeeNumber"

        Dim adapter As New OleDbDataAdapter(query, connection)
        adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)

        TaskProfileDataGrid.DataSource = dataTable

        ' format of the Task Profile Data Grid
        TaskProfileDataGrid.DefaultCellStyle.Padding = New Padding(8, 8, 8, 8)
        TaskProfileDataGrid.ReadOnly = True
        TaskProfileDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        TaskProfileDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        TaskProfileDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

        If TaskProfileDataGrid.Columns.Contains("Task_ID") Then
            TaskProfileDataGrid.Columns("Task_ID").Visible = False
        End If

        ' default width is 272
        'TaskProfileDataGrid.Columns("Task_Name").Width = 340 ' +68 pixels
        'TaskProfileDataGrid.Columns("Category").Width = 210 ' -198 pixels
        'TaskProfileDataGrid.Columns("POC").Width = 300 ' -108 pixels
        'TaskProfileDataGrid.Columns("Description").Width = 510 ' +238 pixes

        TaskProfileDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        TaskProfileDataGrid.MultiSelect = False
        TaskProfileDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        For Each column As DataGridViewColumn In TaskProfileDataGrid.Columns
            If column.HeaderText.Contains("_") Then
                column.HeaderText = column.HeaderText.Replace("_", " ")
            End If
        Next
    End Sub
#End Region 'Done
#Region "Software And Tools Formatting"
    Public Sub ApplySoftwareAndToolsFormatting()
        Dim query As String = "SELECT Software_ID, Software_or_Tool, Used_For FROM Software_Tools WHERE Employee_Number = @EmployeeNumber"

        Dim adapter As New OleDbDataAdapter(query, connection)
        adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)

        SoftwareAndToolsDataGrid.DataSource = dataTable

        ' format of the Software And Tool Data Grid
        SoftwareAndToolsDataGrid.DefaultCellStyle.Padding = New Padding(8, 8, 8, 8)
        SoftwareAndToolsDataGrid.ReadOnly = True
        SoftwareAndToolsDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        SoftwareAndToolsDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        SoftwareAndToolsDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

        ' default values are 272
        If SoftwareAndToolsDataGrid.Columns.Contains("Software_ID") Then
            SoftwareAndToolsDataGrid.Columns("Software_ID").Visible = False
        End If

        ' default width is 680
        'SoftwareAndToolsDataGrid.Columns("Software_or_Tool").Width = 430 ' -250 pixels
        'SoftwareAndToolsDataGrid.Columns("Used_For").Width = 930 ' +250 pixes

        SoftwareAndToolsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        SoftwareAndToolsDataGrid.MultiSelect = False
        SoftwareAndToolsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        For Each column As DataGridViewColumn In SoftwareAndToolsDataGrid.Columns
            If column.HeaderText.Contains("_") Then
                column.HeaderText = column.HeaderText.Replace("_", " ")
            End If
        Next
    End Sub
#End Region 'Done
#Region "Skills Interview Formatting"
    Public Sub ApplySkillsInterviewFormatting()

        Dim query As String = "SELECT Skills_ID, Role_or_Designation, Date_, Interviewer, Assessment_Notes FROM Skills_Interview WHERE Employee_Number = @EmployeeNumber"

        Dim adapter As New OleDbDataAdapter(query, connection)
        adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)

        SkillsInterviewDataGrid.DataSource = dataTable

        ' format of the Skills Interview Data Grid
        SkillsInterviewDataGrid.DefaultCellStyle.Padding = New Padding(8, 8, 8, 8)
        SkillsInterviewDataGrid.ReadOnly = True
        SkillsInterviewDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        SkillsInterviewDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        SkillsInterviewDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

        ' default values are 272
        If SkillsInterviewDataGrid.Columns.Contains("Skills_ID") Then
            SkillsInterviewDataGrid.Columns("Skills_ID").Visible = False
        End If

        ' default width is 340
        'SkillsInterviewDataGrid.Columns("Role_or_Designation").Width = 140 ' -200 pixels
        'SkillsInterviewDataGrid.Columns("Date_").Width = 140 ' -200 pixels
        'SkillsInterviewDataGrid.Columns("Interviewer").Width = 140 ' -200 pixels
        'SkillsInterviewDataGrid.Columns("Assessment_Notes").Width = 840 ' +600 pixels

        SkillsInterviewDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        SkillsInterviewDataGrid.MultiSelect = False
        SkillsInterviewDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        For Each column As DataGridViewColumn In SkillsInterviewDataGrid.Columns
            If column.HeaderText.Contains("_") Then
                column.HeaderText = column.HeaderText.Replace("_", " ")
            End If
        Next

    End Sub
#End Region 'Done
#Region "Performance Evaluation Formatting"
    Public Sub ApplyPerformnceFormatting()

        Dim query As String = "SELECT Performance_ID, Evaluation_Type, Evaluation_Date, Evaluator, Evaluation_Notes FROM Performance_Evaluation WHERE Employee_Number = @EmployeeNumber"

        Dim adapter As New OleDbDataAdapter(query, connection)
        adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)

        PerformanceEvaluationDataGrid.DataSource = dataTable

        ' format of the Performance Evaluation Data Grid
        PerformanceEvaluationDataGrid.DefaultCellStyle.Padding = New Padding(8, 8, 8, 8)
        PerformanceEvaluationDataGrid.ReadOnly = True
        PerformanceEvaluationDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        PerformanceEvaluationDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        PerformanceEvaluationDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

        ' default values are 272
        If PerformanceEvaluationDataGrid.Columns.Contains("Performance_ID") Then
            PerformanceEvaluationDataGrid.Columns("Performance_ID").Visible = False
        End If

        ' default width is 340
        'PerformanceEvaluationDataGrid.Columns("Evaluation_Type").Width = 140 ' -200 pixels
        'PerformanceEvaluationDataGrid.Columns("Evaluation_Date").Width = 140 ' -200 pixels
        'PerformanceEvaluationDataGrid.Columns("Evaluator").Width = 140 ' -200 pixels
        'PerformanceEvaluationDataGrid.Columns("Evaluation_Notes").Width = 840 ' +600 pixels

        PerformanceEvaluationDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        PerformanceEvaluationDataGrid.MultiSelect = False
        PerformanceEvaluationDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        For Each column As DataGridViewColumn In PerformanceEvaluationDataGrid.Columns
            If column.HeaderText.Contains("_") Then
                column.HeaderText = column.HeaderText.Replace("_", " ")
            End If
        Next
    End Sub
#End Region'Done
#Region "Skills Triage Formatting"

    Public Sub ApplySkillsTriageFormatting()

        Dim query As String = "SELECT Triage_ID, Concern_By, Start_Date, Date_Closed, Details_of_Concern, Deliberation_Score, Deliberation_Notes FROM Skills_Triage WHERE Employee_Number = @EmployeeNumber"

        Dim adapter As New OleDbDataAdapter(query, connection)
        adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)

        SkillsTriageDataGrid.DataSource = dataTable

        ' format of the Skills Triage Data Grid
        SkillsTriageDataGrid.DefaultCellStyle.Padding = New Padding(8, 8, 8, 8)
        SkillsTriageDataGrid.ReadOnly = True
        SkillsTriageDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        SkillsTriageDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        SkillsTriageDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

        If SkillsTriageDataGrid.Columns.Contains("Triage_ID") Then
            SkillsTriageDataGrid.Columns("Triage_ID").Visible = False
        End If

        ' default width is 226
        'SkillsTriageDataGrid.Columns("Concern_By").Width = 226
        'SkillsTriageDataGrid.Columns("Start_Date").Width = 226
        'SkillsTriageDataGrid.Columns("Date_Closed").Width = 226
        'SkillsTriageDataGrid.Columns("Details_of_Concern").Width = 226
        'SkillsTriageDataGrid.Columns("Deliberation_Score").Width = 226
        'SkillsTriageDataGrid.Columns("Deliberation_Notes").Width = 226

        SkillsTriageDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        SkillsTriageDataGrid.MultiSelect = False
        SkillsTriageDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        For Each column As DataGridViewColumn In SkillsTriageDataGrid.Columns
            If column.HeaderText.Contains("_") Then
                column.HeaderText = column.HeaderText.Replace("_", " ")
            End If
        Next
    End Sub
#End Region 'Done
#Region "Training History Formatting"

    Public Sub ApplyTrainingHistoryFormatting()

        'txtFacilitator.Text = "Moodle"

        Dim query As String = "SELECT Training_ID, Topic_or_Module_Title, Facilitator, Completion_Date, Grade FROM Training_History WHERE Employee_Number = @EmployeeNumber ORDER BY Completion_Date DESC"

        Dim adapter As New OleDbDataAdapter(query, connection)
        adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)

        TrainingHistoryDataGrid.DataSource = dataTable

        ' format of the Training History Data Grid
        TrainingHistoryDataGrid.DefaultCellStyle.Padding = New Padding(8, 8, 8, 8)
        TrainingHistoryDataGrid.ReadOnly = True
        TrainingHistoryDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        TrainingHistoryDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        TrainingHistoryDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

        If TrainingHistoryDataGrid.Columns.Contains("Training_ID") Then
            TrainingHistoryDataGrid.Columns("Training_ID").Visible = False
        End If

        ' default width is 340
        'TrainingHistoryDataGrid.Columns("Topic_or_Module_Title").Width = 540 ' +200 pixels
        'TrainingHistoryDataGrid.Columns("Facilitator").Width = 340
        'TrainingHistoryDataGrid.Columns("Completion_Date").Width = 340
        'TrainingHistoryDataGrid.Columns("Grade").Width = 140 ' -200 pixels

        TrainingHistoryDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        TrainingHistoryDataGrid.MultiSelect = False
        TrainingHistoryDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        For Each column As DataGridViewColumn In TrainingHistoryDataGrid.Columns
            If column.HeaderText.Contains("_") Then
                column.HeaderText = column.HeaderText.Replace("_", " ")
            End If
        Next
    End Sub
    Private Sub TrainingHistoryDataGrid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles TrainingHistoryDataGrid.CellFormatting
        ' Check if the current cell is in the "End_Date" column
        If TrainingHistoryDataGrid.Columns(e.ColumnIndex).Name = "Completion_Date" AndAlso e.Value IsNot Nothing AndAlso TypeOf e.Value Is Date Then
            ' Check if the value is 01/01/2001
            If CType(e.Value, Date) = #01/01/2001# Then
                ' Hide the cell
                e.CellStyle.ForeColor = TrainingHistoryDataGrid.DefaultCellStyle.BackColor
                e.CellStyle.BackColor = TrainingHistoryDataGrid.DefaultCellStyle.BackColor
                e.CellStyle.SelectionForeColor = TrainingHistoryDataGrid.DefaultCellStyle.BackColor
                e.CellStyle.SelectionBackColor = TrainingHistoryDataGrid.DefaultCellStyle.BackColor
                e.CellStyle.Padding = New Padding(0)
                e.Value = ""
            Else
                ' Override the cell's default formatting to display the date in "dd-MMM-yyyy" format
                e.Value = CType(e.Value, Date).ToString("dd-MMM-yyyy")
            End If
        End If
    End Sub

#End Region 'Done
#Region "Certification and Licenses Formatting"

    Public Sub ApplyCertificationAndLicensesFormatting()

        Dim query As String = "SELECT Certification_ID, Certification_Name, Chapter, Provider, License_Number, Grant_Date, Expiry_Date, Status FROM Certifications_and_Licenses WHERE Employee_Number = @EmployeeNumber"

        Dim adapter As New OleDbDataAdapter(query, connection)
        adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)

        CertificationAndLicensesDataGrid.DataSource = dataTable

        ' format of the Certification and Licenses Data Grid
        CertificationAndLicensesDataGrid.DefaultCellStyle.Padding = New Padding(8, 8, 8, 8)
        CertificationAndLicensesDataGrid.ReadOnly = True
        CertificationAndLicensesDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        CertificationAndLicensesDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        CertificationAndLicensesDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

        If CertificationAndLicensesDataGrid.Columns.Contains("Certification_ID") Then
            CertificationAndLicensesDataGrid.Columns("Certification_ID").Visible = False
        End If

        CertificationAndLicensesDataGrid.Columns("Grant_Date").DefaultCellStyle.Format = "dd-MMM-yyyy"
        CertificationAndLicensesDataGrid.Columns("Expiry_Date").DefaultCellStyle.Format = "dd-MMM-yyyy"

        ' default width is 226
        'CertificationAndLicensesDataGrid.Columns("Certification_Name").Width = 216
        'CertificationAndLicensesDataGrid.Columns("Chapter").Width = 106
        'CertificationAndLicensesDataGrid.Columns("Provider").Width = 216
        'CertificationAndLicensesDataGrid.Columns("License_Number").Width = 226
        'CertificationAndLicensesDataGrid.Columns("Grant_Date").Width = 206
        'CertificationAndLicensesDataGrid.Columns("Expiry_Date").Width = 206
        'CertificationAndLicensesDataGrid.Columns("Status").Width = 180

        CertificationAndLicensesDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        CertificationAndLicensesDataGrid.MultiSelect = False
        CertificationAndLicensesDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        For Each column As DataGridViewColumn In CertificationAndLicensesDataGrid.Columns
            If column.HeaderText.Contains("_") Then
                column.HeaderText = column.HeaderText.Replace("_", " ")
            End If
        Next
    End Sub
    Private Sub CertificationAndLicensesDataGrid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles CertificationAndLicensesDataGrid.CellFormatting
        If CertificationAndLicensesDataGrid.Columns(e.ColumnIndex).Name = "Expiry_Date" AndAlso e.Value IsNot Nothing AndAlso TypeOf e.Value Is Date Then
            If CType(e.Value, Date) = #01/01/2001# Then
                e.CellStyle.ForeColor = CertificationAndLicensesDataGrid.DefaultCellStyle.BackColor
                e.CellStyle.BackColor = CertificationAndLicensesDataGrid.DefaultCellStyle.BackColor
                e.CellStyle.SelectionForeColor = CertificationAndLicensesDataGrid.DefaultCellStyle.BackColor
                e.CellStyle.SelectionBackColor = CertificationAndLicensesDataGrid.DefaultCellStyle.BackColor
                e.CellStyle.Padding = New Padding(0)
                e.Value = ""
            Else
                e.Value = CType(e.Value, Date).ToString("dd-MMM-yyyy")
            End If
        End If
        If CertificationAndLicensesDataGrid.Columns(e.ColumnIndex).Name = "Grant_Date" AndAlso e.Value IsNot Nothing AndAlso TypeOf e.Value Is Date Then
            If CType(e.Value, Date) = #01/01/2001# Then
                e.CellStyle.ForeColor = CertificationAndLicensesDataGrid.DefaultCellStyle.BackColor
                e.CellStyle.BackColor = CertificationAndLicensesDataGrid.DefaultCellStyle.BackColor
                e.CellStyle.SelectionForeColor = CertificationAndLicensesDataGrid.DefaultCellStyle.BackColor
                e.CellStyle.SelectionBackColor = CertificationAndLicensesDataGrid.DefaultCellStyle.BackColor
                e.CellStyle.Padding = New Padding(0)
                e.Value = ""
            Else
                e.Value = CType(e.Value, Date).ToString("dd-MMM-yyyy")
            End If
        End If
    End Sub

#End Region 'Done
#Region "Training Plan Formatting"

    Public Sub ApplyTrainingPlanFormatting()

        Dim query As String = "SELECT Plan_ID, Topic_or_Module_Name, Facilitator, Target_Date FROM Training_Plan WHERE Employee_Number = @EmployeeNumber"

        Dim adapter As New OleDbDataAdapter(query, connection)
        adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)

        TrainingPlanDataGrid.DataSource = dataTable

        ' format of the Training Plan Data Grid
        TrainingPlanDataGrid.DefaultCellStyle.Padding = New Padding(8, 8, 8, 8)
        TrainingPlanDataGrid.ReadOnly = True
        TrainingPlanDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        TrainingPlanDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        TrainingPlanDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

        If TrainingPlanDataGrid.Columns.Contains("Plan_ID") Then
            TrainingPlanDataGrid.Columns("Plan_ID").Visible = False
        End If

        TrainingPlanDataGrid.Columns("Target_Date").DefaultCellStyle.Format = "dd-MMM-yyyy"

        ' default width is 453
        'TrainingPlanDataGrid.Columns("Topic_or_Module_Name").Width = 453
        'TrainingPlanDataGrid.Columns("Facilitator").Width = 453
        'TrainingPlanDataGrid.Columns("Target_Date").Width = 453

        TrainingPlanDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        TrainingPlanDataGrid.MultiSelect = False
        TrainingPlanDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        For Each column As DataGridViewColumn In TrainingPlanDataGrid.Columns
            If column.HeaderText.Contains("_") Then
                column.HeaderText = column.HeaderText.Replace("_", " ")
            End If
        Next
    End Sub
    Private Sub TrainingPlanDataGrid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles TrainingPlanDataGrid.CellFormatting
        ' Check if the current cell is in the "End_Date" column
        If TrainingPlanDataGrid.Columns(e.ColumnIndex).Name = "Target_Date" AndAlso e.Value IsNot Nothing AndAlso TypeOf e.Value Is Date Then
            ' Check if the value is 01/01/2001
            If CType(e.Value, Date) = #01/01/2001# Then
                ' Hide the cell
                e.CellStyle.ForeColor = TrainingPlanDataGrid.DefaultCellStyle.BackColor
                e.CellStyle.BackColor = TrainingPlanDataGrid.DefaultCellStyle.BackColor
                e.CellStyle.SelectionForeColor = TrainingPlanDataGrid.DefaultCellStyle.BackColor
                e.CellStyle.SelectionBackColor = TrainingPlanDataGrid.DefaultCellStyle.BackColor
                e.CellStyle.Padding = New Padding(0)
                e.Value = ""
            Else
                ' Override the cell's default formatting to display the date in "dd-MMM-yyyy" format
                e.Value = CType(e.Value, Date).ToString("dd-MMM-yyyy")
            End If
        End If
    End Sub

#End Region 'Done
#Region "Training Programs Formatting"

    Public Sub ApplyTrainingProgramsFormatting()

        Dim query As String = "SELECT Program_ID, Program_Title, Start_Date, Completion_Date, Deliberation_Score, Deliberation_Notes FROM Training_Programs WHERE Employee_Number = @EmployeeNumber"

        Dim adapter As New OleDbDataAdapter(query, connection)
        adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)

        TrainingProgramsDataGrid.DataSource = dataTable

        ' format of the Training Programs Data Grid
        TrainingProgramsDataGrid.DefaultCellStyle.Padding = New Padding(8, 8, 8, 8)
        TrainingProgramsDataGrid.ReadOnly = True
        TrainingProgramsDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        TrainingProgramsDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        TrainingProgramsDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

        If TrainingProgramsDataGrid.Columns.Contains("Program_ID") Then
            TrainingProgramsDataGrid.Columns("Program_ID").Visible = False
        End If

        TrainingProgramsDataGrid.Columns("Start_Date").DefaultCellStyle.Format = "dd-MMM-yyyy"
        TrainingProgramsDataGrid.Columns("Completion_Date").DefaultCellStyle.Format = "dd-MMM-yyyy"

        ' default width is 272
        'TrainingProgramsDataGrid.Columns("Program_Title").Width = 272
        'TrainingProgramsDataGrid.Columns("Start_Date").Width = 272
        'TrainingProgramsDataGrid.Columns("Completion_Date").Width = 272
        'TrainingProgramsDataGrid.Columns("Deliberation_Score").Width = 272
        'TrainingProgramsDataGrid.Columns("Deliberation_Notes").Width = 272

        TrainingProgramsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        TrainingProgramsDataGrid.MultiSelect = False
        TrainingProgramsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        For Each column As DataGridViewColumn In TrainingProgramsDataGrid.Columns
            If column.HeaderText.Contains("_") Then
                column.HeaderText = column.HeaderText.Replace("_", " ")
            End If
        Next
    End Sub
#End Region 'Done
#Region "Webinars Attended Formatting"

    Public Sub ApplyWebinarsAttendedFormatting()

        Dim query As String = "SELECT Webinar_ID, Webinar_Title, Date_, CPD_Units FROM Webinars_Attended WHERE Employee_Number = @EmployeeNumber"

        Dim adapter As New OleDbDataAdapter(query, connection)
        adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)

        WebinarsAttendedDataGrid.DataSource = dataTable

        ' format of the Training Plan Data Grid
        WebinarsAttendedDataGrid.DefaultCellStyle.Padding = New Padding(8, 8, 8, 8)
        WebinarsAttendedDataGrid.ReadOnly = True
        WebinarsAttendedDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        WebinarsAttendedDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        WebinarsAttendedDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

        If WebinarsAttendedDataGrid.Columns.Contains("Webinar_ID") Then
            WebinarsAttendedDataGrid.Columns("Webinar_ID").Visible = False
        End If

        WebinarsAttendedDataGrid.Columns("Date_").DefaultCellStyle.Format = "dd-MMM-yyyy"

        ' default width is 453
        'WebinarsAttendedDataGrid.Columns("Webinar_Title").Width = 453
        'WebinarsAttendedDataGrid.Columns("Date_").Width = 453
        'WebinarsAttendedDataGrid.Columns("CPD_Units").Width = 453

        WebinarsAttendedDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        WebinarsAttendedDataGrid.MultiSelect = False
        WebinarsAttendedDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        For Each column As DataGridViewColumn In WebinarsAttendedDataGrid.Columns
            If column.HeaderText.Contains("_") Then
                column.HeaderText = column.HeaderText.Replace("_", " ")
            End If
        Next
    End Sub
#End Region 'Done
#Region "Client Feedback"
    Public Sub ApplyClientFeedbackFormatting()

        Dim query As String = "SELECT Feedback_ID, Account_Manager, Client_POC, Feedback_Date, Feedback_Summary, Staff_Performance_Rating FROM Client_Feedback WHERE Employee_Number = @EmployeeNumber"

        Dim adapter As New OleDbDataAdapter(query, connection)
        adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)

        ClientFeedbackDataGrid.DataSource = dataTable

        ' format of the Training Programs Data Grid
        ClientFeedbackDataGrid.DefaultCellStyle.Padding = New Padding(8, 8, 8, 8)
        ClientFeedbackDataGrid.ReadOnly = True
        ClientFeedbackDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        ClientFeedbackDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        ClientFeedbackDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

        If ClientFeedbackDataGrid.Columns.Contains("Feedback_ID") Then
            ClientFeedbackDataGrid.Columns("Feedback_ID").Visible = False
        End If

        ClientFeedbackDataGrid.Columns("Feedback_Date").DefaultCellStyle.Format = "dd-MMM-yyyy"
        ' default width is 272
        'ClientFeedbackDataGrid.Columns("Account_Manager").Width = 272
        'ClientFeedbackDataGrid.Columns("Client_POC").Width = 272
        'ClientFeedbackDataGrid.Columns("Feedback_Date").Width = 272
        'ClientFeedbackDataGrid.Columns("Feedback_Summary").Width = 272
        'ClientFeedbackDataGrid.Columns("Staff_Performance_Rating").Width = 272

        ClientFeedbackDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ClientFeedbackDataGrid.MultiSelect = False
        ClientFeedbackDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        For Each column As DataGridViewColumn In ClientFeedbackDataGrid.Columns
            If column.HeaderText.Contains("_") Then
                column.HeaderText = column.HeaderText.Replace("_", " ")
            End If
        Next
    End Sub
#End Region 'Done
#Region "Self Assessment"
    Public Sub ApplySelfAssessmentFormatting()

        Dim query As String = "SELECT Self_ID, Account_Manager, Feedback_Date, Personal_Performance_Rating, Client_Rating, TBR_Rating FROM Self_Assessment WHERE Employee_Number = @EmployeeNumber"

        Dim adapter As New OleDbDataAdapter(query, connection)
        adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)

        SelfAssessmentDataGrid.DataSource = dataTable

        ' format of the Training Programs Data Grid
        SelfAssessmentDataGrid.DefaultCellStyle.Padding = New Padding(8, 8, 8, 8)
        SelfAssessmentDataGrid.ReadOnly = True
        SelfAssessmentDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        SelfAssessmentDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        SelfAssessmentDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

        If SelfAssessmentDataGrid.Columns.Contains("Self_ID") Then
            SelfAssessmentDataGrid.Columns("Self_ID").Visible = False
        End If

        SelfAssessmentDataGrid.Columns("Feedback_Date").DefaultCellStyle.Format = "dd-MMM-yyyy"

        ' default width is 272
        'SelfAssessmentDataGrid.Columns("Account_Manager").Width = 272
        'SelfAssessmentDataGrid.Columns("Feedback_Date").Width = 272
        'SelfAssessmentDataGrid.Columns("Personal_Performance_Rating").Width = 272
        'SelfAssessmentDataGrid.Columns("Client_Rating").Width = 272
        'SelfAssessmentDataGrid.Columns("TBR_Rating").Width = 272

        SelfAssessmentDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        SelfAssessmentDataGrid.MultiSelect = False
        SelfAssessmentDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        For Each column As DataGridViewColumn In SelfAssessmentDataGrid.Columns
            If column.HeaderText.Contains("_") Then
                column.HeaderText = column.HeaderText.Replace("_", " ")
            End If
        Next
    End Sub
#End Region 'Done
#Region "Competency Completion"
    Public Sub ApplyCompetencyCertificationFormatting()

        Dim query As String = "SELECT Competency_ID, Certification_Name, Grant_Date, Deliberation_Summary, Overall_Grade FROM Competency_Certification WHERE Employee_Number = @EmployeeNumber ORDER BY Grant_Date DESC"

        Dim adapter As New OleDbDataAdapter(query, connection)
        adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)

        CompetencyCertificationDataGrid.DataSource = dataTable

        ' format of the Training History Data Grid
        CompetencyCertificationDataGrid.DefaultCellStyle.Padding = New Padding(8, 8, 8, 8)
        CompetencyCertificationDataGrid.ReadOnly = True
        CompetencyCertificationDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        CompetencyCertificationDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        CompetencyCertificationDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

        If CompetencyCertificationDataGrid.Columns.Contains("Competency_ID") Then
            CompetencyCertificationDataGrid.Columns("Competency_ID").Visible = False
        End If

        CompetencyCertificationDataGrid.Columns("Grant_Date").DefaultCellStyle.Format = "dd-MMM-yyyy"

        ' default width is 340
        'CompetencyCertificationDataGrid.Columns("Certification_Name").Width = 340
        'CompetencyCertificationDataGrid.Columns("Grant_Date").Width = 340
        'CompetencyCertificationDataGrid.Columns("Deliberation_Summary").Width = 540 ' +200 pixels
        'CompetencyCertificationDataGrid.Columns("Overall_Grade").Width = 140 ' -200 pixels

        CompetencyCertificationDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        CompetencyCertificationDataGrid.MultiSelect = False
        CompetencyCertificationDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        For Each column As DataGridViewColumn In CompetencyCertificationDataGrid.Columns
            If column.HeaderText.Contains("_") Then
                column.HeaderText = column.HeaderText.Replace("_", " ")
            End If
        Next
    End Sub
#End Region 'Done
#End Region
#Region "EmployeeF Load"
    Public Sub EmployeeF_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True

        employeeNumber = txtEmployeeNumber.Text
        EmployeeID = txtEmployeeNumber.Text
        DisplayEmployeeDetails(employeeNumber)

        employeeProfile.DisplayEmployeeProfileDataGrid(employeeNumber, EmployeeProfileDataGrid)
        jobHistory.DisplayJobHistoryDataGrid(employeeNumber, JobHistoryDataGrid)
        taskProfile.DisplayTaskProfileDataGrid(employeeNumber, TaskProfileDataGrid)
        softwareAndTools.DisplaySoftwareAndToolsDataGrid(employeeNumber, SoftwareAndToolsDataGrid)
        skillsInterview.DisplaySkillsInterviewDataGrid(employeeNumber, SkillsInterviewDataGrid)
        performanceEvaluation.DisplayPerformanceEvaluationDataGrid(employeeNumber, PerformanceEvaluationDataGrid)
        skillsTriage.DisplaySkillsTriageDataGrid(employeeNumber, SkillsTriageDataGrid)
        trainingHistory.DisplayTrainingHistoryDataGrid(employeeNumber, TrainingHistoryDataGrid)
        certificationAndLicenses.DisplayCertificationAndLicensesDataGrid(employeeNumber, CertificationAndLicensesDataGrid)
        trainingPlan.DisplayTrainingPlanDataGrid(employeeNumber, TrainingPlanDataGrid)
        trainingPrograms.DisplayTrainingProgramsDataGrid(employeeNumber, TrainingProgramsDataGrid)
        webinarsAttended.DisplayWebinarsAttendedDataGrid(employeeNumber, WebinarsAttendedDataGrid)
        clientFeedback.DisplayClientFeedbackDataGrid(employeeNumber, ClientFeedbackDataGrid)
        competencyCertification.DisplayCompetencyCertificationDataGrid(employeeNumber, CompetencyCertificationDataGrid)

        AddHandler EmployeeTabControl.SelectedIndexChanged, AddressOf EmployeeTabControl_SelectedIndexChanged

        ApplyEmployeeProfileFormatting()

        Try
            connection.Open()


            Dim employeeQuery As String = "SELECT Employee_Number, Employee_First_Name, Employee_Last_Name FROM Employee_Profile WHERE Employee_Number = @EmployeeNumber"
            Dim employeeCmd As New OleDbCommand(employeeQuery, connection)
            employeeCmd.Parameters.AddWithValue("@EmployeeNumber", EmployeeID)
            Dim fname As String
            Dim lname As String
            Dim employeeReader As OleDbDataReader = employeeCmd.ExecuteReader()

            If employeeReader.Read() Then

                fname = employeeReader("Employee_First_Name").ToString()
                lname = employeeReader("Employee_Last_Name").ToString()

                lblEPName.Text = lblEPName.Text + " of " + fname.Trim + " " + lname

                'For Header Purposes'

            Else
                MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            employeeReader.Close()


        Catch ex As Exception
            MessageBox.Show($"Error(EmployeeF_Load): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try

        If employeeRoleAdmin = 2 Then
            'Employee Profile
            EmployeeProfileDataGrid.Enabled = False
            btnSaveEP.Visible = False
            btnCancelEP.Visible = False
            btnExportPDF.Location = New Point(13, 354)
            btnExportExcelSheets.Visible = False
            'Job History
            JobHistoryDataGrid.Enabled = False
            btnSaveChanges.Visible = False
            btnAdd.Visible = False
            btnCancel.Visible = False
            btnDelete.Visible = False
            btnClear.Visible = False
            'Task Profile
            TaskProfileDataGrid.Enabled = False
            btnSaveChangesTP.Visible = False
            btnAddTP.Visible = False
            btnCancelTP.Visible = False
            btnDeleteTP.Visible = False
            btnClearTP.Visible = False
            'Software and Tools
            SoftwareAndToolsDataGrid.Enabled = False
            btnSaveChangesST.Visible = False
            btnAddST.Visible = False
            btnCancelST.Visible = False
            btnDeleteST.Visible = False
            btnClearST.Visible = False
            'Skills Interview
            SkillsInterviewDataGrid.Enabled = False
            btnSaveChangesSI.Visible = False
            btnAddSI.Visible = False
            btnCancelSI.Visible = False
            btnDeleteSI.Visible = False
            btnClearSI.Visible = False
            'Performance Evaluation
            PerformanceEvaluationDataGrid.Enabled = False
            btnSaveChangesPE.Visible = False
            btnAddPE.Visible = False
            btnCancelPE.Visible = False
            btnDeletePE.Visible = False
            btnClearPE.Visible = False
            'Skills Triage
            SkillsTriageDataGrid.Enabled = False
            btnSaveChangesT.Visible = False
            btnAddT.Visible = False
            btnCancelT.Visible = False
            btnDeleteT.Visible = False
            btnClearT.Visible = False
            'Training History
            TrainingHistoryDataGrid.Enabled = False
            btnSaveChangesTH.Visible = False
            btnAddTH.Visible = False
            btnCancelTH.Visible = False
            btnDeleteTH.Visible = False
            btnClearTH.Visible = False
            'Certification and Licenses
            CertificationAndLicensesDataGrid.Enabled = False
            btnSaveChangesCL.Visible = False
            btnAddCL.Visible = False
            btnCancelCL.Visible = False
            btnDeleteCL.Visible = False
            btnClearCL.Visible = False
            'Training Plan
            TrainingPlanDataGrid.Enabled = False
            btnSaveChangesP.Visible = False
            btnAddP.Visible = False
            btnCancelP.Visible = False
            btnDeleteP.Visible = False
            btnClearP.Visible = False
            'Training Programs
            TrainingProgramsDataGrid.Enabled = False
            btnSaveChangesTPr.Visible = False
            btnAddTPr.Visible = False
            btnCancelTPr.Visible = False
            btnDeleteTPr.Visible = False
            btnClearTPr.Visible = False
            'Webinars Attended
            WebinarsAttendedDataGrid.Enabled = False
            btnSaveChangesW.Visible = False
            btnAddW.Visible = False
            btnCancelW.Visible = False
            btnDeleteW.Visible = False
            btnClearW.Visible = False
            'Client Feedback
            ClientFeedbackDataGrid.Enabled = False
            btnSaveChangesCF.Visible = False
            btnAddCF.Visible = False
            btnCancelCF.Visible = False
            btnDeleteCF.Visible = False
            btnClearCF.Visible = False
            'Self-Assessment
            SelfAssessmentDataGrid.Enabled = False
            btnSaveChangesSA.Visible = False
            btnAddSA.Visible = False
            btnCancelSA.Visible = False
            btnDeleteSA.Visible = False
            btnClearSA.Visible = False
            'Competency Certifications
            CompetencyCertificationDataGrid.Enabled = False
            btnSaveChangesCC.Visible = False
            btnAddCC.Visible = False
            btnCancelCC.Visible = False
            btnDeleteCC.Visible = False
            btnClearCC.Visible = False
        End If

    End Sub
    Private Sub EmployeeF_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyData = Keys.PrintScreen Then
            Clipboard.Clear()
        End If
    End Sub
#End Region 'EMPLOYEE LOADING
#Region "EmployeeTab Format"
    Private Sub ResetTabs()
        ' Reset to the default FillToRight mode
        EmployeeTabControl.SizeMode = TabSizeMode.FillToRight
    End Sub
    Private Sub ResizeTabs()
        Dim totalTabs As Integer = EmployeeTabControl.TabCount
        If totalTabs > 0 Then
            ' Calculate the width for each tab
            Dim tabWidth As Integer = (EmployeeTabControl.Width \ totalTabs) - 2.501

            ' Set the size mode to Fixed and update the tab size
            EmployeeTabControl.SizeMode = TabSizeMode.Fixed
            EmployeeTabControl.ItemSize = New Size(tabWidth, EmployeeTabControl.ItemSize.Height)
        End If
    End Sub
    Private Sub EmployeeF_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then
            ResizeTabs()
        Else
            ResetTabs()
        End If
    End Sub
    Private Sub EmployeeTabControl_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles EmployeeTabControl.DrawItem

        Dim CurrentTab As TabPage = EmployeeTabControl.TabPages(e.Index)
        Dim ItemRect As Drawing.Rectangle = EmployeeTabControl.GetTabRect(e.Index)
        Dim TextColor As New Color
        Dim ButtonColorFondo As New Color
        ButtonColorFondo = Color.FromArgb(52, 37, 107)
        TextColor = Color.White
        Dim FillBrush As New SolidBrush(ButtonColorFondo)
        Dim TextBrush As New SolidBrush(TextColor)
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        ItemRect.Inflate(3, 3)

        e.Graphics.FillRectangle(FillBrush, ItemRect)

        e.Graphics.DrawString(CurrentTab.Text, e.Font, TextBrush, RectangleF.op_Implicit(ItemRect), sf)

        e.Graphics.ResetTransform()

    End Sub

    Private Sub EmployeeTabControl_SelectedIndexChanged(sender As Object, e As EventArgs)

        If EmployeeTabControl.SelectedIndex = 15 Then

            ApplyEmployeeProfileFormatting()

        ElseIf EmployeeTabControl.SelectedIndex = 1 Then

            ApplyJobHistoryFormatting()

        ElseIf EmployeeTabControl.SelectedIndex = 2 Then

            ApplyTaskProfileFormatting()

        ElseIf EmployeeTabControl.SelectedIndex = 3 Then

            ApplySoftwareAndToolsFormatting()

        ElseIf EmployeeTabControl.SelectedIndex = 4 Then

            ApplySkillsInterviewFormatting()

        ElseIf EmployeeTabControl.SelectedIndex = 5 Then

            ApplyPerformnceFormatting()

        ElseIf EmployeeTabControl.SelectedIndex = 6 Then

            ApplySkillsTriageFormatting()

        ElseIf EmployeeTabControl.SelectedIndex = 7 Then

            ApplyTrainingHistoryFormatting()

        ElseIf EmployeeTabControl.SelectedIndex = 8 Then

            ApplyCertificationAndLicensesFormatting()

        ElseIf EmployeeTabControl.SelectedIndex = 9 Then

            ApplyTrainingPlanFormatting()

        ElseIf EmployeeTabControl.SelectedIndex = 10 Then

            ApplyTrainingProgramsFormatting()

        ElseIf EmployeeTabControl.SelectedIndex = 11 Then

            ApplyWebinarsAttendedFormatting()

        ElseIf EmployeeTabControl.SelectedIndex = 12 Then

            ApplyClientFeedbackFormatting()

        ElseIf EmployeeTabControl.SelectedIndex = 13 Then

            ApplySelfAssessmentFormatting()

        ElseIf EmployeeTabControl.SelectedIndex = 14 Then

            ApplyCompetencyCertificationFormatting()

        End If
    End Sub
#End Region
#Region "User Account Controls"
#Region "AdminDetails"
    Private Sub EmployeeListF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PermissionUpdate = False

        txtEmployeeIDAdmin.Text = LoginF.adminID

        connection.Close()

        Try
            connection.Open()

            Dim loginID As String = LoginF.adminID
            Dim employeeQuery As String = "SELECT Employee_Last_Name, Employee_First_Name, Employee_Password, Employee_Role FROM Employee_Profile WHERE Employee_Number = @EmployeeNumber"
            Dim employeeCmd As New OleDbCommand(employeeQuery, connection)
            employeeCmd.Parameters.AddWithValue("@EmployeeNumber", loginID)

            Dim employeeReader As OleDbDataReader = employeeCmd.ExecuteReader()

            If employeeReader.Read() Then
                employeeRole = employeeReader("Employee_Role")
                txtFirstName.Text = employeeReader("Employee_First_Name").ToString()
                txtLastName.Text = employeeReader("Employee_Last_Name").ToString()

                'For Dashboard Purposes'

            Else
                MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            employeeReader.Close()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub btnSaveAdmin_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveChangesToDatabase()
        HideButtons()
    End Sub

    Private Sub SaveChangesToDatabase()
        Try
            connection.Open()

            Dim updateQuery As String = "UPDATE Employee_Profile SET Employee_First_Name = @FirstName, Employee_Last_Name = @LastName WHERE Employee_Number = @EmployeeNumber"
            Dim updateCmd As New OleDbCommand(updateQuery, connection)
            updateCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            updateCmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
            updateCmd.Parameters.AddWithValue("@EmployeeNumber", txtEmployeeIDAdmin.Text)

            updateCmd.ExecuteNonQuery()

            changesMade = False

            MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Private Sub btnAttemptedAccess_Click(sender As Object, e As EventArgs) Handles btnAttemptedAccess.Click
        Dim attemptedAccess As New Attempt
        attemptedAccess.ShowDialog()
    End Sub
    Private Sub btnEditAdmin_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ShowButtons()
    End Sub
    Private Sub btnCancelAdmin_Click(sender As Object, e As EventArgs) Handles btnUserCancel.Click
        HideButtons()
    End Sub
    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        ChangePasswordForm.Show()
    End Sub
    Private Sub ShowButtons()
        btnSave.Visible = True
        btnUserCancel.Visible = True
        btnEdit.Visible = False

        txtFirstName.Enabled = True
        txtLastName.Enabled = True
    End Sub
    Private Sub HideButtons()
        btnSave.Visible = False
        btnUserCancel.Visible = False
        btnEdit.Visible = True

        txtFirstName.Enabled = False
        txtLastName.Enabled = False
    End Sub

    Private Sub DisplayEmployeeDetails(employeeNumber As String)
        connection.Close()

        Try
            connection.Open()
            Dim loginID As String = LoginF.adminID
            Dim query As String = "SELECT Employee_Last_Name, Employee_First_Name, Employee_Password, Employee_Role, Last_Update, Status, Sharepoint_Link FROM Employee_Profile WHERE Employee_Number = @Employee_Number"
            Dim cmd As New OleDbCommand(query, connection)
            cmd.Parameters.AddWithValue("@Employee_Number", loginID)

            Dim employeeReader As OleDbDataReader = cmd.ExecuteReader()

            If employeeReader.Read() Then
                txtLastName.Text = employeeReader("Employee_Last_Name").ToString()
                txtFirstName.Text = employeeReader("Employee_First_Name").ToString()

            Else
                MessageBox.Show("Employee details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            employeeReader.Close()
        Catch ex As Exception
            MessageBox.Show($"Error(Displaying Employee): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Public Sub LastUpdate()
        connection.Close()

        Try
            connection.Open()

            Dim lastUpdateQuery As String = "UPDATE Employee_Profile SET Last_Update = @Last_Update WHERE Employee_Number = @Employee_Number"
            Dim lastUpdateCmd As New OleDbCommand(lastUpdateQuery, connection)

            lastUpdateCmd.Parameters.AddWithValue("@Last_Update", DateTime.Today.ToShortDateString)
            lastUpdateCmd.Parameters.AddWithValue("@Employee_Number", txtEmployeeNumber.Text)

            lastUpdateCmd.ExecuteNonQuery()

            DisplayEmployeeDetails(employeeNumber)

        Catch ex As Exception
            MessageBox.Show($"Error updating Last_Update: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Private Sub EmployeeF_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Dim employeeListForm As EmployeeListF = Application.OpenForms("EmployeeListF")

        If employeeListForm IsNot Nothing Then
            employeeListForm.ActiveEmployees()
            employeeListForm.rdbtnActiveEmployees.Checked = True
        End If
    End Sub

    Private Sub grpEnable()
        txtFirstName.Enabled = True
        txtLastName.Enabled = True
        btnSave.Visible = True
        btnUserCancel.Visible = True
        btnEdit.Visible = False
    End Sub
    Private Sub grpDisable()
        txtFirstName.Enabled = False
        txtLastName.Enabled = False
        btnSave.Visible = False
        btnUserCancel.Visible = False
        btnEdit.Visible = True

        DisplayEmployeeDetails(employeeNumber)
    End Sub
#End Region 'TOP RIGHT BUTTON
#End Region 'Top Right Button
#Region "Applying Tab Formatting and Buttons"
#Region "Employee Profile"
    Public Sub ReloadEmployeeProfile()
        ApplyEmployeeProfileFormatting()
    End Sub
    Private Sub EmployeeProfileDataGrid_CellClick(sender As Object, e As EventArgs) Handles EmployeeProfileDataGrid.Click

        If EmployeeProfileDataGrid.SelectedRows.Count > 0 Then

            Dim fname = EmployeeProfileDataGrid.SelectedRows(0).Cells("Employee_First_Name").Value
            Dim lname = EmployeeProfileDataGrid.SelectedRows(0).Cells("Employee_Last_Name").Value
            Dim lastupdate = EmployeeProfileDataGrid.SelectedRows(0).Cells("Last_Update").Value
            Dim status = EmployeeProfileDataGrid.SelectedRows(0).Cells("Status").Value
            Dim sharepointlink = EmployeeProfileDataGrid.SelectedRows(0).Cells("Sharepoint_Link").Value

            txtFname.Text = fname.ToString
            txtLname.Text = lname.ToString
            txtLastUpdate.Text = lastupdate.ToString
            If status = "Active" Then
                chkbxIsActive.Checked = True
            ElseIf status = "Inactive" Then
                chkbxIsActive.Checked = False
            End If
            txtSharepointLink.Text = sharepointlink.ToString

            employeeProfile.ShowButtons()
        End If
    End Sub
    Private Sub btnClearEP_Click(sender As Object, e As EventArgs) Handles btnCancelEP.Click
        employeeProfile.ClearFields()
        employeeProfile.HideButtons()
    End Sub
    Private Sub btnSaveChangesEP_Click(sender As Object, e As EventArgs) Handles btnSaveEP.Click
        employeeProfile.UpdateDetailsInDatabase(EmployeeProfileDataGrid, txtFname, txtLname, txtLastUpdate, chkbxIsActive, txtSharepointLink, Me)
        ApplyEmployeeProfileFormatting()
    End Sub

#End Region
#Region "Job History"
    Public Sub ReloadJobHistory()
        ApplyJobHistoryFormatting()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        jobHistory.ClearFields()
        jobHistory.HideButtons()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        jobHistory.UpdateDetailsInDatabase(JobHistoryDataGrid, txtRoleDesignation, txtClientName, txtRegion, txtStartDateJ, txtEndDateJ, txtReasonForChange, Me)
        ApplyJobHistoryFormatting()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        jobHistory.AddDetailsToDatabase(JobHistoryDataGrid, txtEmployeeNumber, txtRoleDesignation, txtClientName, txtRegion, txtStartDateJ, txtEndDateJ, txtReasonForChange, Me)
        ApplyJobHistoryFormatting()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        jobHistory.DeleteDetailsFromDatabase(JobHistoryDataGrid, Me)
        ApplyJobHistoryFormatting()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        jobHistory.HideButtons()
        jobHistory.ClearFields()
    End Sub
    Private Sub JobHistoryDataGrid_CellClick(sender As Object, e As EventArgs) Handles JobHistoryDataGrid.Click
        If JobHistoryDataGrid.SelectedRows.Count > 0 Then

            Dim roleDesignation = JobHistoryDataGrid.SelectedRows(0).Cells("Role_And_Designation").Value
            Dim clientName = JobHistoryDataGrid.SelectedRows(0).Cells("Client_Name").Value
            Dim region = JobHistoryDataGrid.SelectedRows(0).Cells("Region").Value
            Dim startDate = JobHistoryDataGrid.SelectedRows(0).Cells("Start_Date").Value
            Dim endDate = JobHistoryDataGrid.SelectedRows(0).Cells("End_Date").Value
            Dim reasonChange = JobHistoryDataGrid.SelectedRows(0).Cells("Reason_for_Change").Value

            txtRoleDesignation.Text = roleDesignation.ToString
            txtClientName.Text = clientName.ToString
            txtRegion.Text = region.ToString
            txtStartDateJ.Text = startDate.ToString
            txtEndDateJ.Text = endDate.ToString
            txtReasonForChange.Text = reasonChange.ToString

            jobHistory.ShowButtons()
        End If
    End Sub
#End Region
#Region "Task Profile"
    Public Sub ReloadTaskProfile()
        ApplyTaskProfileFormatting()
    End Sub
    Private Sub TaskProfileDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TaskProfileDataGrid.CellClick
        If TaskProfileDataGrid.SelectedRows.Count > 0 Then
            Dim taskName = TaskProfileDataGrid.SelectedRows(0).Cells("Task_Name").Value
            Dim category = TaskProfileDataGrid.SelectedRows(0).Cells("Category").Value
            Dim poc = TaskProfileDataGrid.SelectedRows(0).Cells("POC").Value
            Dim description = TaskProfileDataGrid.SelectedRows(0).Cells("Description").Value

            txtTaskName.Text = taskName.ToString
            txtCategory.Text = category.ToString
            txtPOC.Text = poc.ToString
            txtDescription.Text = description.ToString

            taskProfile.ShowButtons()
        End If
    End Sub
    Private Sub lklblOpenFile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim query = "SELECT Sharepoint_Link FROM Employee_Profile WHERE Employee_Number = @EmployeeNumber"

        Try
            connection.Open()

            Dim adapter As New OleDbDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

            Dim sharepointLink = adapter.SelectCommand.ExecuteScalar

            If sharepointLink IsNot Nothing Then
                Dim processDocumentLink = sharepointLink.ToString

                Process.Start(New ProcessStartInfo With {
                .FileName = "cmd",
                .Arguments = $"/c start {processDocumentLink}",
                .UseShellExecute = False,
                .CreateNoWindow = True
            })
            Else
                MessageBox.Show("SharePoint link not found for the employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub btnClearTP_Click(sender As Object, e As EventArgs) Handles btnClearTP.Click
        taskProfile.ClearFields()
        taskProfile.HideButtons()
    End Sub

    Private Sub btnAddTP_Click(sender As Object, e As EventArgs) Handles btnAddTP.Click
        taskProfile.AddDetailsToDatabase(TaskProfileDataGrid, txtEmployeeNumber, txtTaskName, txtCategory, txtPOC, txtDescription, Me)
        ApplyTaskProfileFormatting()
    End Sub

    Private Sub btnSaveChangesTP_Click(sender As Object, e As EventArgs) Handles btnSaveChangesTP.Click
        taskProfile.UpdateDetailsInDatabase(TaskProfileDataGrid, txtTaskName, txtCategory, txtPOC, txtDescription, Me)
        ApplyTaskProfileFormatting()
    End Sub

    Private Sub btnDeleteTP_Click(sender As Object, e As EventArgs) Handles btnDeleteTP.Click
        taskProfile.DeleteDetailsFromDatabase(TaskProfileDataGrid, Me)
        ApplyTaskProfileFormatting()
    End Sub

    Private Sub btnCancelTP_Click(sender As Object, e As EventArgs) Handles btnCancelTP.Click
        taskProfile.HideButtons()
        taskProfile.ClearFields()
    End Sub
#End Region
#Region "Software and Tools"
    Public Sub ReloadSoftwareAndTools()
        ApplySoftwareAndToolsFormatting()
    End Sub
    Private Sub SoftwareAndToolsDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SoftwareAndToolsDataGrid.CellClick
        If SoftwareAndToolsDataGrid.SelectedRows.Count > 0 Then

            Dim softwareOrTool = SoftwareAndToolsDataGrid.SelectedRows(0).Cells("Software_or_Tool").Value
            Dim usedFor = SoftwareAndToolsDataGrid.SelectedRows(0).Cells("Used_For").Value

            txtSoftwareOrTools.Text = softwareOrTool.ToString
            txtUsedFor.Text = usedFor.ToString

            softwareAndTools.ShowButtons()
        End If
    End Sub
    Private Sub btnClearST_Click(sender As Object, e As EventArgs) Handles btnClearST.Click
        softwareAndTools.ClearFields()
        softwareAndTools.HideButtons()
    End Sub

    Private Sub btnAddST_Click(sender As Object, e As EventArgs) Handles btnAddST.Click
        softwareAndTools.AddDetailsToDatabase(SoftwareAndToolsDataGrid, txtEmployeeNumber, txtSoftwareOrTools, txtUsedFor, Me)
        ApplySoftwareAndToolsFormatting()
    End Sub

    Private Sub btnSaveChangesST_Click(sender As Object, e As EventArgs) Handles btnSaveChangesST.Click
        softwareAndTools.UpdateDetailsInDatabase(SoftwareAndToolsDataGrid, txtSoftwareOrTools, txtUsedFor, Me)
        ApplySoftwareAndToolsFormatting()
    End Sub

    Private Sub btnDeleteST_Click(sender As Object, e As EventArgs) Handles btnDeleteST.Click
        softwareAndTools.DeleteDetailsFromDatabase(SoftwareAndToolsDataGrid, Me)
        ApplySoftwareAndToolsFormatting()
    End Sub

    Private Sub btnCancelst_Click(sender As Object, e As EventArgs) Handles btnCancelST.Click
        softwareAndTools.HideButtons()
        softwareAndTools.ClearFields()
    End Sub
#End Region
#Region "Skills and Interview"
    Public Sub ReloadSkillsInterview()
        ApplySkillsInterviewFormatting()
    End Sub
    Private Sub SkillsInterviewDataGrid_CellClick(sender As Object, e As EventArgs) Handles SkillsInterviewDataGrid.Click
        If SkillsInterviewDataGrid.SelectedRows.Count > 0 Then

            Dim roleOrDesignation = SkillsInterviewDataGrid.SelectedRows(0).Cells("Role_or_Designation").Value
            Dim date_ = SkillsInterviewDataGrid.SelectedRows(0).Cells("Date_").Value
            Dim interviewer = SkillsInterviewDataGrid.SelectedRows(0).Cells("Interviewer").Value
            Dim assessmentNotes = SkillsInterviewDataGrid.SelectedRows(0).Cells("Assessment_Notes").Value

            txtRoleOrDesignation.Text = roleOrDesignation.ToString
            dtpckerDate.Text = date_.ToString
            txtInterviewer.Text = interviewer.ToString
            txtAssessmentNotes.Text = assessmentNotes.ToString

            skillsInterview.ShowButtons()
        End If
    End Sub
    Private Sub btnClearSI_Click(sender As Object, e As EventArgs) Handles btnClearSI.Click
        skillsInterview.ClearFields()
        skillsInterview.HideButtons()
    End Sub

    Private Sub btnAddSI_Click(sender As Object, e As EventArgs) Handles btnAddSI.Click
        skillsInterview.AddDetailsToDatabase(SkillsInterviewDataGrid, txtEmployeeNumber, txtRoleOrDesignation, dtpckerDate, txtInterviewer, txtAssessmentNotes, Me)
        ApplySkillsInterviewFormatting()
    End Sub

    Private Sub btnSaveChangesSI_Click(sender As Object, e As EventArgs) Handles btnSaveChangesSI.Click
        skillsInterview.UpdateDetailsInDatabase(SkillsInterviewDataGrid, txtRoleOrDesignation, dtpckerDate, txtInterviewer, txtAssessmentNotes, Me)
        ApplySkillsInterviewFormatting()
    End Sub

    Private Sub btnDeleteSI_Click(sender As Object, e As EventArgs) Handles btnDeleteSI.Click
        skillsInterview.DeleteDetailsFromDatabase(SkillsInterviewDataGrid, Me)
        ApplySkillsInterviewFormatting()
    End Sub

    Private Sub btnCancelSI_Click(sender As Object, e As EventArgs) Handles btnCancelSI.Click
        skillsInterview.HideButtons()
        skillsInterview.ClearFields()
    End Sub
#End Region
#Region "Performance Evaluation"
    Public Sub ReloadPerformanceEvaluation()
        ApplyPerformnceFormatting()
    End Sub
    Private Sub btnClearPE_Click(sender As Object, e As EventArgs) Handles btnClearPE.Click
        performanceEvaluation.ClearFields()
        performanceEvaluation.HideButtons()
    End Sub
    Private Sub btnSaveChangesPE_Click(sender As Object, e As EventArgs) Handles btnSaveChangesPE.Click
        performanceEvaluation.UpdateDetailsInDatabase(PerformanceEvaluationDataGrid, txtEvaluationType, dtpckerEvalutionDate, txtEvaluator, txtEvaluationNotes, Me)
        ApplyPerformnceFormatting()
    End Sub
    Private Sub btnAddPE_Click(sender As Object, e As EventArgs) Handles btnAddPE.Click
        performanceEvaluation.AddDetailsToDatabase(PerformanceEvaluationDataGrid, txtEmployeeNumber, txtEvaluationType, dtpckerEvalutionDate, txtEvaluator, txtEvaluationNotes, Me)
        ApplyPerformnceFormatting()
    End Sub

    Private Sub btnDeletePE_Click(sender As Object, e As EventArgs) Handles btnDeletePE.Click
        performanceEvaluation.DeleteDetailsFromDatabase(PerformanceEvaluationDataGrid, Me)
        ApplyPerformnceFormatting()
    End Sub
    Private Sub btnCancelPE_Click(sender As Object, e As EventArgs) Handles btnCancelPE.Click
        performanceEvaluation.HideButtons()
        performanceEvaluation.ClearFields()
    End Sub
    Private Sub PerformanceEvaluationDataGrid_CellClick(sender As Object, e As EventArgs) Handles PerformanceEvaluationDataGrid.Click
        If PerformanceEvaluationDataGrid.SelectedRows.Count > 0 Then

            Dim evaluationType = PerformanceEvaluationDataGrid.SelectedRows(0).Cells("Evaluation_Type").Value
            Dim evaluationDate = PerformanceEvaluationDataGrid.SelectedRows(0).Cells("Evaluation_Date").Value
            Dim evaluator = PerformanceEvaluationDataGrid.SelectedRows(0).Cells("Evaluator").Value
            Dim evaluationNotes = PerformanceEvaluationDataGrid.SelectedRows(0).Cells("Evaluation_Notes").Value

            txtEvaluationType.Text = evaluationType.ToString
            dtpckerEvalutionDate.Text = evaluationDate.ToString
            txtEvaluator.Text = evaluator.ToString
            txtEvaluationNotes.Text = evaluationNotes.ToString

            performanceEvaluation.ShowButtons()
        End If
    End Sub
#End Region
#Region "Skills Triage"
    Public Sub ReloadSkillsTriage()
        ApplySkillsTriageFormatting()
    End Sub
    Private Sub SkillsTriageDataGrid_CellClick(sender As Object, e As EventArgs) Handles SkillsTriageDataGrid.Click
        If SkillsTriageDataGrid.SelectedRows.Count > 0 Then

            Dim concernBy = SkillsTriageDataGrid.SelectedRows(0).Cells("Concern_By").Value
            Dim startDate = SkillsTriageDataGrid.SelectedRows(0).Cells("Start_Date").Value
            Dim dateClose = SkillsTriageDataGrid.SelectedRows(0).Cells("Date_Closed").Value
            Dim detailsOfConcern = SkillsTriageDataGrid.SelectedRows(0).Cells("Details_of_Concern").Value
            Dim deliberationScore = SkillsTriageDataGrid.SelectedRows(0).Cells("Deliberation_Score").Value
            Dim deliberationNotes = SkillsTriageDataGrid.SelectedRows(0).Cells("Deliberation_Notes").Value

            txtConcernBy.Text = concernBy.ToString
            dtpckerStartDateT.Text = startDate.ToString
            dtpckerDateClose.Text = dateClose.ToString
            txtDetailsOfConcern.Text = detailsOfConcern.ToString
            txtDeliberationScore.Text = deliberationScore.ToString
            txtDeliberationNotes.Text = deliberationNotes.ToString

            skillsTriage.ShowButtons()
        End If
    End Sub
    Private Sub btnClearT_Click(sender As Object, e As EventArgs) Handles btnClearT.Click
        skillsTriage.ClearFields()
        skillsTriage.HideButtons()
    End Sub

    Private Sub btnAddT_Click(sender As Object, e As EventArgs) Handles btnAddT.Click
        skillsTriage.AddDetailsToDatabase(SkillsTriageDataGrid, txtEmployeeNumber, txtConcernBy, dtpckerStartDateT, dtpckerDateClose, txtDetailsOfConcern, txtDeliberationScore, txtDeliberationNotes, Me)
        ApplySkillsTriageFormatting()
    End Sub

    Private Sub btnSaveChangesT_Click(sender As Object, e As EventArgs) Handles btnSaveChangesT.Click
        skillsTriage.UpdateDetailsInDatabase(SkillsTriageDataGrid, txtConcernBy, dtpckerStartDateT, dtpckerDateClose, txtDetailsOfConcern, txtDeliberationScore, txtDeliberationNotes, Me)
        ApplySkillsTriageFormatting()
    End Sub

    Private Sub btnDeleteT_Click(sender As Object, e As EventArgs) Handles btnDeleteT.Click
        skillsTriage.DeleteDetailsFromDatabase(SkillsTriageDataGrid, Me)
        ApplySkillsTriageFormatting()
    End Sub

    Private Sub btnCancelT_Click(sender As Object, e As EventArgs) Handles btnCancelT.Click
        skillsTriage.HideButtons()
        skillsTriage.ClearFields()
    End Sub
#End Region
#Region "Training History"
    Public Sub ReloadTrainingHistory()
        ApplyTrainingHistoryFormatting()
    End Sub
    Private Sub TrainingHistoryDataGrid_CellClick(sender As Object, e As EventArgs) Handles TrainingHistoryDataGrid.Click
        If TrainingHistoryDataGrid.SelectedRows.Count > 0 Then

            Dim topicOrModuleTitle = TrainingHistoryDataGrid.SelectedRows(0).Cells("Topic_or_Module_Title").Value
            Dim facilitator = TrainingHistoryDataGrid.SelectedRows(0).Cells("Facilitator").Value
            Dim completionDate = TrainingHistoryDataGrid.SelectedRows(0).Cells("Completion_Date").Value
            Dim grade = TrainingHistoryDataGrid.SelectedRows(0).Cells("Grade").Value

            txtTopicOrModuleTitle.Text = topicOrModuleTitle.ToString
            txtFacilitator.Text = facilitator.ToString
            dtpckerCompletion.Text = completionDate.ToString
            txtGrade.Text = grade.ToString

            trainingHistory.ShowButtons()
        End If
    End Sub
    Private Sub btnClearTH_Click(sender As Object, e As EventArgs) Handles btnClearTH.Click
        trainingHistory.ClearFields()
        trainingHistory.HideButtons()
    End Sub

    Private Sub btnAddTH_Click(sender As Object, e As EventArgs) Handles btnAddTH.Click
        trainingHistory.AddDetailsToDatabase(TrainingHistoryDataGrid, txtEmployeeNumber, txtTopicOrModuleTitle, txtFacilitator, dtpckerCompletion, txtGrade, Me)
        ApplyTrainingHistoryFormatting()
    End Sub

    Private Sub btnSaveChangesTH_Click(sender As Object, e As EventArgs) Handles btnSaveChangesTH.Click
        trainingHistory.UpdateDetailsInDatabase(TrainingHistoryDataGrid, txtTopicOrModuleTitle, txtFacilitator, dtpckerCompletion, txtGrade, Me)
        ApplyTrainingHistoryFormatting()
    End Sub

    Private Sub btnDeleteTH_Click(sender As Object, e As EventArgs) Handles btnDeleteTH.Click
        trainingHistory.DeleteDetailsFromDatabase(TrainingHistoryDataGrid, Me)
        ApplyTrainingHistoryFormatting()
    End Sub

    Private Sub btnCancelTH_Click(sender As Object, e As EventArgs) Handles btnCancelTH.Click
        trainingHistory.HideButtons()
        trainingHistory.ClearFields()
    End Sub
#End Region
#Region "Certification and License"
    Public Sub ReloadCertificationAndLicense()
        ApplyCertificationAndLicensesFormatting()
    End Sub
    Private Sub CertificationAndLicensesDataGrid_CellClick(sender As Object, e As EventArgs) Handles CertificationAndLicensesDataGrid.Click
        If CertificationAndLicensesDataGrid.SelectedRows.Count > 0 Then

            Dim certificationName = CertificationAndLicensesDataGrid.SelectedRows(0).Cells("Certification_Name").Value
            Dim chapter = CertificationAndLicensesDataGrid.SelectedRows(0).Cells("Chapter").Value
            Dim provider = CertificationAndLicensesDataGrid.SelectedRows(0).Cells("Provider").Value
            Dim licenseNumber = CertificationAndLicensesDataGrid.SelectedRows(0).Cells("License_Number").Value
            Dim grantDate = CertificationAndLicensesDataGrid.SelectedRows(0).Cells("Grant_Date").Value
            Dim expiryDate = CertificationAndLicensesDataGrid.SelectedRows(0).Cells("Expiry_Date").Value
            Dim status = CertificationAndLicensesDataGrid.SelectedRows(0).Cells("Status").Value

            txtCertificateName.Text = certificationName.ToString
            txtChapter.Text = chapter.ToString
            txtProvider.Text = provider.ToString
            txtLicenseNumber.Text = licenseNumber.ToString
            dtpckerGrantDate.Text = grantDate.ToString
            dtpckerExpiryDate.Text = expiryDate.ToString
            txtStatus.Text = status.ToString

            certificationAndLicenses.ShowButtons()
        End If
    End Sub
    Private Sub btnClearCL_Click(sender As Object, e As EventArgs) Handles btnClearCL.Click
        certificationAndLicenses.ClearFields()
        certificationAndLicenses.HideButtons()
    End Sub

    Private Sub btnAddCL_Click(sender As Object, e As EventArgs) Handles btnAddCL.Click
        certificationAndLicenses.AddDetailsToDatabase(CertificationAndLicensesDataGrid, txtEmployeeNumber, txtCertificateName, txtChapter, txtProvider, txtLicenseNumber, dtpckerGrantDate, dtpckerExpiryDate, txtStatus, Me)
        ApplyCertificationAndLicensesFormatting()
    End Sub

    Private Sub btnSaveChangesCL_Click(sender As Object, e As EventArgs) Handles btnSaveChangesCL.Click
        certificationAndLicenses.UpdateDetailsInDatabase(CertificationAndLicensesDataGrid, txtCertificateName, txtChapter, txtProvider, txtLicenseNumber, dtpckerGrantDate, dtpckerExpiryDate, txtStatus, Me)
        ApplyCertificationAndLicensesFormatting()
    End Sub

    Private Sub btnDeleteCL_Click(sender As Object, e As EventArgs) Handles btnDeleteCL.Click
        certificationAndLicenses.DeleteDetailsFromDatabase(CertificationAndLicensesDataGrid, Me)
        ApplyCertificationAndLicensesFormatting()
    End Sub

    Private Sub btnCancelCL_Click(sender As Object, e As EventArgs) Handles btnCancelCL.Click
        certificationAndLicenses.HideButtons()
        certificationAndLicenses.ClearFields()
    End Sub

#End Region
#Region "Training Plan"
    Public Sub ReloadTrainingPlan()
        ApplyTrainingPlanFormatting()
    End Sub
    Private Sub TrainingPlanDataGrid_CellClick(sender As Object, e As EventArgs) Handles TrainingPlanDataGrid.Click
        If TrainingPlanDataGrid.SelectedRows.Count > 0 Then

            Dim topicOrModuleName = TrainingPlanDataGrid.SelectedRows(0).Cells("Topic_or_Module_Name").Value
            Dim facilitator = TrainingPlanDataGrid.SelectedRows(0).Cells("Facilitator").Value
            Dim targetDate = TrainingPlanDataGrid.SelectedRows(0).Cells("Target_Date").Value

            txtTopicOrModuleName.Text = topicOrModuleName.ToString
            txtFacilitatorP.Text = facilitator.ToString
            txtTargetDate.Text = targetDate.ToString

            trainingPlan.ShowButtons()
        End If
    End Sub
    Private Sub btnClearP_Click(sender As Object, e As EventArgs) Handles btnClearP.Click
        trainingPlan.ClearFields()
        trainingPlan.HideButtons()
    End Sub

    Private Sub btnAddP_Click(sender As Object, e As EventArgs) Handles btnAddP.Click
        trainingPlan.AddDetailsToDatabase(TrainingPlanDataGrid, txtEmployeeNumber, txtTopicOrModuleName, txtFacilitatorP, txtTargetDate, Me)
        ApplyTrainingPlanFormatting()
    End Sub

    Private Sub btnSaveChangesP_Click(sender As Object, e As EventArgs) Handles btnSaveChangesP.Click
        trainingPlan.UpdateDetailsInDatabase(TrainingPlanDataGrid, txtTopicOrModuleName, txtFacilitatorP, txtTargetDate, Me)
        ApplyTrainingPlanFormatting()
    End Sub

    Private Sub btnDeleteP_Click(sender As Object, e As EventArgs) Handles btnDeleteP.Click
        trainingPlan.DeleteDetailsFromDatabase(TrainingPlanDataGrid, Me)
        ApplyTrainingPlanFormatting()
    End Sub

    Private Sub btnCancelP_Click(sender As Object, e As EventArgs) Handles btnCancelP.Click
        trainingPlan.HideButtons()
        trainingPlan.ClearFields()
    End Sub

#End Region
#Region "Training Programs"
    Public Sub ReloadTrainingPrograms()
        ApplyTrainingProgramsFormatting()
    End Sub
    Private Sub TrainingProgramsDataGrid_CellClick(sender As Object, e As EventArgs) Handles TrainingProgramsDataGrid.Click
        If TrainingProgramsDataGrid.SelectedRows.Count > 0 Then

            Dim programTitle = TrainingProgramsDataGrid.SelectedRows(0).Cells("Program_Title").Value
            Dim startDate = TrainingProgramsDataGrid.SelectedRows(0).Cells("Start_Date").Value
            Dim completionDate = TrainingProgramsDataGrid.SelectedRows(0).Cells("Completion_Date").Value
            Dim deliberationScore = TrainingProgramsDataGrid.SelectedRows(0).Cells("Deliberation_Score").Value
            Dim deliberationNote = TrainingProgramsDataGrid.SelectedRows(0).Cells("Deliberation_Notes").Value

            txtProgramTitle.Text = programTitle.ToString
            txtStartDateTPr.Text = startDate.ToString
            txtCompletionDateTPr.Text = completionDate.ToString

            txtDeliberationScoreTPr.Text = deliberationScore.ToString
            txtDeliberationNotesTPr.Text = deliberationNote.ToString

            trainingPrograms.ShowButtons()
        End If
    End Sub
    Private Sub btnClearTPr_Click(sender As Object, e As EventArgs) Handles btnClearTPr.Click
        trainingPrograms.ClearFields()
        trainingPrograms.HideButtons()
    End Sub

    Private Sub btnAddTPr_Click(sender As Object, e As EventArgs) Handles btnAddTPr.Click
        trainingPrograms.AddDetailsToDatabase(TrainingProgramsDataGrid, txtEmployeeNumber, txtProgramTitle, txtStartDateTPr, txtCompletionDateTPr, txtDeliberationScoreTPr, txtDeliberationNotesTPr, Me)
        ApplyTrainingProgramsFormatting()
    End Sub

    Private Sub btnSaveChangesTPr_Click(sender As Object, e As EventArgs) Handles btnSaveChangesTPr.Click
        trainingPrograms.UpdateDetailsInDatabase(TrainingProgramsDataGrid, txtProgramTitle, txtStartDateTPr, txtCompletionDateTPr, txtDeliberationScoreTPr, txtDeliberationNotesTPr, Me)
        ApplyTrainingProgramsFormatting()
    End Sub

    Private Sub btnDeleteTPr_Click(sender As Object, e As EventArgs) Handles btnDeleteTPr.Click
        trainingPrograms.DeleteDetailsFromDatabase(TrainingProgramsDataGrid, Me)
        ApplyTrainingProgramsFormatting()
    End Sub

    Private Sub btnCancelTPr_Click(sender As Object, e As EventArgs) Handles btnCancelTPr.Click
        trainingPrograms.HideButtons()
        trainingPrograms.ClearFields()
    End Sub

#End Region
#Region "Webinars Attended"
    Public Sub ReloadWebinarsAttended()
        ApplyWebinarsAttendedFormatting()
    End Sub
    Private Sub WebinarsAttendedDataGrid_CellClick(sender As Object, e As EventArgs) Handles WebinarsAttendedDataGrid.Click
        If WebinarsAttendedDataGrid.SelectedRows.Count > 0 Then

            Dim webinarTitle = WebinarsAttendedDataGrid.SelectedRows(0).Cells("Webinar_Title").Value
            Dim date_ = WebinarsAttendedDataGrid.SelectedRows(0).Cells("Date_").Value
            Dim cpdUnits = WebinarsAttendedDataGrid.SelectedRows(0).Cells("CPD_Units").Value

            txtWebinarTitle.Text = webinarTitle.ToString
            txtDateW.Text = date_.ToString
            txtCPDUnits.Text = cpdUnits.ToString

            webinarsAttended.ShowButtons()
        End If
    End Sub
    Private Sub btnClearW_Click(sender As Object, e As EventArgs) Handles btnClearW.Click
        webinarsAttended.ClearFields()
        webinarsAttended.HideButtons()
    End Sub

    Private Sub btnAddW_Click(sender As Object, e As EventArgs) Handles btnAddW.Click
        webinarsAttended.AddDetailsToDatabase(WebinarsAttendedDataGrid, txtEmployeeNumber, txtWebinarTitle, txtDateW, txtCPDUnits, Me)
        ApplyWebinarsAttendedFormatting()
    End Sub

    Private Sub btnSaveChangesW_Click(sender As Object, e As EventArgs) Handles btnSaveChangesW.Click
        webinarsAttended.UpdateDetailsInDatabase(WebinarsAttendedDataGrid, txtWebinarTitle, txtDateW, txtCPDUnits, Me)
        ApplyWebinarsAttendedFormatting()
    End Sub

    Private Sub btnDeleteW_Click(sender As Object, e As EventArgs) Handles btnDeleteW.Click
        webinarsAttended.DeleteDetailsFromDatabase(WebinarsAttendedDataGrid, Me)
        ApplyWebinarsAttendedFormatting()
    End Sub

    Private Sub btnCancelW_Click(sender As Object, e As EventArgs) Handles btnCancelW.Click
        webinarsAttended.HideButtons()
        webinarsAttended.ClearFields()
    End Sub
#End Region
#Region "Client Feedback"
    Public Sub ReloadClientFeedback()
        ApplyClientFeedbackFormatting()
    End Sub
    Private Sub ClientFeedbackDataGrid_CellClick(sender As Object, e As EventArgs) Handles ClientFeedbackDataGrid.Click
        If ClientFeedbackDataGrid.SelectedRows.Count > 0 Then

            Dim accountManager = ClientFeedbackDataGrid.SelectedRows(0).Cells("Account_Manager").Value
            Dim clientPOC = ClientFeedbackDataGrid.SelectedRows(0).Cells("Client_POC").Value
            Dim feedbackDate = ClientFeedbackDataGrid.SelectedRows(0).Cells("Feedback_Date").Value
            Dim feedbackSummary = ClientFeedbackDataGrid.SelectedRows(0).Cells("Feedback_Summary").Value
            Dim staffPerformanceRating = ClientFeedbackDataGrid.SelectedRows(0).Cells("Staff_Performance_Rating").Value

            txtAccountManager.Text = accountManager.ToString
            txtClientPOC.Text = clientPOC.ToString
            txtFeedbackDate.Text = feedbackDate.ToString
            txtFeedbackSummary.Text = feedbackSummary.ToString
            txtStaffPerformanceRating.Text = staffPerformanceRating.ToString

            clientFeedback.ShowButtons()
        End If
    End Sub
    Private Sub btnClearCF_Click(sender As Object, e As EventArgs) Handles btnClearCF.Click
        clientFeedback.ClearFields()
        clientFeedback.HideButtons()
    End Sub

    Private Sub btnAddCF_Click(sender As Object, e As EventArgs) Handles btnAddCF.Click
        clientFeedback.AddDetailsToDatabase(ClientFeedbackDataGrid, txtEmployeeNumber, txtAccountManager, txtClientPOC, txtFeedbackDate, txtFeedbackSummary, txtStaffPerformanceRating, Me)
        ApplyClientFeedbackFormatting()
    End Sub

    Private Sub btnSaveChangesCF_Click(sender As Object, e As EventArgs) Handles btnSaveChangesCF.Click
        clientFeedback.UpdateDetailsInDatabase(ClientFeedbackDataGrid, txtAccountManager, txtClientPOC, txtFeedbackDate, txtFeedbackSummary, txtStaffPerformanceRating, Me)
        ApplyClientFeedbackFormatting()
    End Sub

    Private Sub btnDeleteCF_Click(sender As Object, e As EventArgs) Handles btnDeleteCF.Click
        clientFeedback.DeleteDetailsFromDatabase(ClientFeedbackDataGrid, Me)
        ApplyClientFeedbackFormatting()
    End Sub

    Private Sub btnCancelCF_Click(sender As Object, e As EventArgs) Handles btnCancelCF.Click
        clientFeedback.HideButtons()
        clientFeedback.ClearFields()
    End Sub
#End Region
#Region "Self Assessment"
    Public Sub ReloadSelfAssessment()
        ApplySelfAssessmentFormatting()
    End Sub
    Private Sub SelfAssessmentDataGrid_CellClick(sender As Object, e As EventArgs) Handles SelfAssessmentDataGrid.Click
        If SelfAssessmentDataGrid.SelectedRows.Count > 0 Then

            Dim accountManagerSA = SelfAssessmentDataGrid.SelectedRows(0).Cells("Account_Manager").Value
            Dim feedbackDateSA = SelfAssessmentDataGrid.SelectedRows(0).Cells("Feedback_Date").Value
            Dim personalPerformanceRating = SelfAssessmentDataGrid.SelectedRows(0).Cells("Personal_Performance_Rating").Value
            Dim clientRating = SelfAssessmentDataGrid.SelectedRows(0).Cells("Client_Rating").Value
            Dim tbrRating = SelfAssessmentDataGrid.SelectedRows(0).Cells("TBR_Rating").Value

            txtAccountManagerSA.Text = accountManagerSA.ToString
            txtFeedbackDateSA.Text = feedbackDateSA.ToString
            txtPersonalPerformanceRating.Text = personalPerformanceRating.ToString
            txtClientRating.Text = clientRating.ToString
            txtTBRRating.Text = tbrRating.ToString

            selfAssessment.ShowButtons()
        End If
    End Sub
    Private Sub btnClearSA_Click(sender As Object, e As EventArgs) Handles btnClearSA.Click
        selfAssessment.ClearFields()
        selfAssessment.HideButtons()
    End Sub

    Private Sub btnAddSA_Click(sender As Object, e As EventArgs) Handles btnAddSA.Click
        selfAssessment.AddDetailsToDatabase(SelfAssessmentDataGrid, txtEmployeeNumber, txtAccountManagerSA, txtFeedbackDateSA, txtPersonalPerformanceRating, txtClientRating, txtTBRRating, Me)
        ApplySelfAssessmentFormatting()
    End Sub

    Private Sub btnSaveChangesSA_Click(sender As Object, e As EventArgs) Handles btnSaveChangesSA.Click
        selfAssessment.UpdateDetailsInDatabase(SelfAssessmentDataGrid, txtAccountManagerSA, txtFeedbackDateSA, txtPersonalPerformanceRating, txtClientRating, txtTBRRating, Me)
        ApplySelfAssessmentFormatting()
    End Sub

    Private Sub btnDeleteSA_Click(sender As Object, e As EventArgs) Handles btnDeleteSA.Click
        selfAssessment.DeleteDetailsFromDatabase(SelfAssessmentDataGrid, Me)
        ApplySelfAssessmentFormatting()
    End Sub

    Private Sub btnCancelSA_Click(sender As Object, e As EventArgs) Handles btnCancelSA.Click
        selfAssessment.HideButtons()
        selfAssessment.ClearFields()
    End Sub
#End Region
#Region "Competency Certification"
    Public Sub ReloadCompetencyCertification()
        ApplyCompetencyCertificationFormatting()
    End Sub
    Private Sub CompetencyCertificationDataGrid_CellClick(sender As Object, e As EventArgs) Handles CompetencyCertificationDataGrid.Click
        If CompetencyCertificationDataGrid.SelectedRows.Count > 0 Then

            Dim certificationName = CompetencyCertificationDataGrid.SelectedRows(0).Cells("Certification_Name").Value
            Dim grantDate = CompetencyCertificationDataGrid.SelectedRows(0).Cells("Grant_Date").Value
            Dim deliberationSummary = CompetencyCertificationDataGrid.SelectedRows(0).Cells("Deliberation_Summary").Value
            Dim overallGrade = CompetencyCertificationDataGrid.SelectedRows(0).Cells("Overall_Grade").Value

            txtCertificationName.Text = certificationName.ToString
            txtGrantDateCC.Text = grantDate.ToString
            txtDeliberationSummary.Text = deliberationSummary.ToString
            txtOverallGrade.Text = overallGrade.ToString

            competencyCertification.ShowButtons()
        End If
    End Sub
    Private Sub btnClearCC_Click(sender As Object, e As EventArgs) Handles btnClearCC.Click
        competencyCertification.ClearFields()
        competencyCertification.HideButtons()
    End Sub

    Private Sub btnAddCC_Click(sender As Object, e As EventArgs) Handles btnAddCC.Click
        competencyCertification.AddDetailsToDatabase(CompetencyCertificationDataGrid, txtEmployeeNumber, txtCertificationName, txtGrantDateCC, txtDeliberationSummary, txtOverallGrade, Me)
        ApplyCompetencyCertificationFormatting()
    End Sub

    Private Sub btnSaveChangesCC_Click(sender As Object, e As EventArgs) Handles btnSaveChangesCC.Click
        competencyCertification.UpdateDetailsInDatabase(CompetencyCertificationDataGrid, txtCertificationName, txtGrantDateCC, txtDeliberationSummary, txtOverallGrade, Me)
        ApplyCompetencyCertificationFormatting()
    End Sub

    Private Sub btnDeleteCC_Click(sender As Object, e As EventArgs) Handles btnDeleteCC.Click
        competencyCertification.DeleteDetailsFromDatabase(CompetencyCertificationDataGrid, Me)
        ApplyCompetencyCertificationFormatting()
    End Sub

    Private Sub btnCancelCC_Click(sender As Object, e As EventArgs) Handles btnCancelCC.Click
        competencyCertification.HideButtons()
        competencyCertification.ClearFields()
    End Sub
#End Region
#End Region
#Region "Exporting"
#Region "Fetch Employee Profile for Exporting"
    Public Function FetchEmployeeName(employeeNumber As String) As (String, String)
        Dim firstName As String = ""
        Dim lastName As String = ""

        connection.Close()

        Try
            connection.Open()

            Dim query As String = "SELECT Employee_Last_Name, Employee_First_Name FROM Employee_Profile WHERE Employee_Number = @Employee_Number"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("@Employee_Number", employeeNumber)
                Dim employeeReader As OleDbDataReader = cmd.ExecuteReader()
                If employeeReader.Read() Then
                    lastName = employeeReader("Employee_Last_Name").ToString()
                    firstName = employeeReader("Employee_First_Name").ToString()
                End If
            End Using

            Return (firstName, lastName)

        Catch ex As Exception
            MessageBox.Show($"Error(Job History): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Neil Added this Function to remove Error of doesn't return a value on all code paths'
            Return ("", "")
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Function

    Private Function FetchEmployeeStatus(employeeNumber As String) As (String, String)
        Dim lastUpdate As String = ""
        Dim status As String = ""

        connection.Close()

        Try
            connection.Open()

            Dim query As String = "SELECT Last_Update, Status FROM Employee_Profile WHERE Employee_Number = @Employee_Number"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("@Employee_Number", employeeNumber)
                Dim employeeReader As OleDbDataReader = cmd.ExecuteReader()
                If employeeReader.Read() Then
                    lastUpdate = employeeReader("Last_Update").ToString()
                    status = employeeReader("Status").ToString()
                End If
            End Using

            Return (lastUpdate, status)

        Catch ex As Exception
            MessageBox.Show($"Error(Job History): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Neil Added this Function to remove Error of doesn't return a value on all code paths'
            Return ("", "")
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Function
    Private Function FetchEmployeeNumPass(employeeNumber As String) As (String, String)
        Dim employeeNum As String = ""
        Dim password As String = ""

        connection.Close()

        Try
            connection.Open()

            Dim query As String = "SELECT Employee_Number, Employee_Password FROM Employee_Profile WHERE Employee_Number = @Employee_Number"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("@Employee_Number", employeeNumber)
                Dim employeeReader As OleDbDataReader = cmd.ExecuteReader()
                If employeeReader.Read() Then
                    employeeNum = employeeReader("Employee_Number").ToString()
                    password = employeeReader("Employee_Password").ToString()
                End If
            End Using

            Return (employeeNum, password)

        Catch ex As Exception
            MessageBox.Show($"Error(Job History): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Neil Added this Function to remove Error of doesn't return a value on all code paths'
            Return ("", "")
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Function
    Private Function FetchEmployeeRoleLink(employeeNumber As String) As (String, String)
        Dim role As String = ""
        Dim link As String = ""

        connection.Close()

        Try
            connection.Open()

            Dim query As String = "SELECT Employee_Role, Sharepoint_Link FROM Employee_Profile WHERE Employee_Number = @Employee_Number"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("@Employee_Number", employeeNumber)
                Dim employeeReader As OleDbDataReader = cmd.ExecuteReader()
                If employeeReader.Read() Then
                    role = employeeReader("Employee_Role").ToString()
                    link = employeeReader("Sharepoint_Link").ToString()
                End If
            End Using

            Return (role, link)

        Catch ex As Exception
            MessageBox.Show($"Error(Job History): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Neil Added this Function to remove Error of doesn't return a value on all code paths'
            Return ("", "")
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Function
#End Region
#Region "Export To Word (NOT USED)"
    Private Sub btnExportWord_Click(sender As Object, e As EventArgs) Handles btnExportToWord.Click

        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "Word Documents (*.docx)|(*.docx)"
        saveFileDialog.Title = "Save Employee Profile"
        saveFileDialog.ShowDialog()

        MessageBox.Show("Please wait while the profile is exporting. Thank you", "Profile Exporting", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If saveFileDialog.FileName <> "" Then
            ExportToWord(connection, saveFileDialog.FileName, employeeNumber)
            MessageBox.Show(" Thank you for the wait. The profile has been exported!", "Profile Exported", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        grpDisable()
    End Sub


    Private Sub ExportToWord(connection As OleDbConnection, filePath As String, employeeNumber As String)
        Dim wordApp As New Word.Application()
        Dim wordDoc As Word.Document = wordApp.Documents.Add()

        Dim employeeName As (String, String) = FetchEmployeeName(employeeNumber)
        Dim firstName As String = employeeName.Item1
        Dim lastName As String = employeeName.Item2

        Dim fileName As String = $"{employeeNumber} {firstName} {lastName}.docx"

        filePath = Path.Combine(Path.GetDirectoryName(filePath), fileName)

        ' employee profile
        Dim employeeProfileQuery As String = "SELECT Employee_Number, Employee_First_Name, Employee_Last_Name, Last_Update FROM Employee_Profile WHERE Employee_Number = @EmployeeNumber"
        ExportTableToWord(connection, wordDoc, employeeProfileQuery, "", employeeNumber)

        Dim employeeProfileTable As Word.Table = wordDoc.Tables(wordDoc.Tables.Count)
        ApplyTableFormatting(employeeProfileTable)

        wordDoc.Paragraphs.Add()

        ' job history
        Dim jobHistoryQuery As String = "SELECT Role_and_Designation, Client_Name, Region, Start_Date, End_Date, Reason_for_Change FROM Job_History WHERE Employee_Number = @EmployeeNumber"
        ExportTableToWord(connection, wordDoc, jobHistoryQuery, "Job History", employeeNumber)

        Dim jobHistoryTable As Word.Table = wordDoc.Tables(wordDoc.Tables.Count)
        ApplyTableFormatting(jobHistoryTable)

        wordDoc.Paragraphs.Add()

        ' task profile
        Dim taskProfileQuery As String = "SELECT Task_Name, Category, POC, Description FROM Task_Profile WHERE Employee_Number = @EmployeeNumber"
        ExportTableToWord(connection, wordDoc, taskProfileQuery, "Task Profile", employeeNumber)

        Dim taskProfileTable As Word.Table = wordDoc.Tables(wordDoc.Tables.Count)
        ApplyTableFormatting(taskProfileTable)

        wordDoc.Paragraphs.Add()

        ' software tools
        Dim softwareToolsQuery As String = "SELECT Software_or_Tool, Used_For FROM Software_Tools WHERE Employee_Number = @EmployeeNumber"
        ExportTableToWord(connection, wordDoc, softwareToolsQuery, "Software/Tools", employeeNumber)

        Dim softwareToolsTable As Word.Table = wordDoc.Tables(wordDoc.Tables.Count)
        ApplyTableFormatting(softwareToolsTable)

        wordDoc.Paragraphs.Add()

        ' skills interview
        Dim skillsInterviewQuery As String = "SELECT Role_or_Designation, Date_, Interviewer, Assessment_Notes FROM Skills_Interview WHERE Employee_Number = @EmployeeNumber"
        ExportTableToWord(connection, wordDoc, skillsInterviewQuery, "Skills Interview", employeeNumber)

        Dim skillsInterviewTable As Word.Table = wordDoc.Tables(wordDoc.Tables.Count)
        ApplyTableFormatting(skillsInterviewTable)

        wordDoc.Paragraphs.Add()

        ' performance evaluation
        Dim performanceEvaluationQuery As String = "SELECT Evaluation_Type, Evaluation_Date, Evaluator, Evaluation_Notes FROM Performance_Evaluation WHERE Employee_Number = @EmployeeNumber"
        ExportTableToWord(connection, wordDoc, performanceEvaluationQuery, "Performance Evaluation", employeeNumber)

        Dim performanceEvaluationTable As Word.Table = wordDoc.Tables(wordDoc.Tables.Count)
        ApplyTableFormatting(performanceEvaluationTable)

        wordDoc.Paragraphs.Add()

        ' skills triage
        Dim skillsTriageQuery As String = "SELECT Concern_By, Start_Date, Date_Closed, Details_of_Concern, Deliberation_Score, Deliberation_Notes FROM Skills_Triage WHERE Employee_Number = @EmployeeNumber"
        ExportTableToWord(connection, wordDoc, skillsTriageQuery, "Skills Triage", employeeNumber)

        Dim skillsTriageTable As Word.Table = wordDoc.Tables(wordDoc.Tables.Count)
        ApplyTableFormatting(skillsTriageTable)

        wordDoc.Paragraphs.Add()

        ' training history
        Dim trainingHistoryQuery As String = "SELECT Topic_or_Module_Title, Facilitator, Completion_Date, Grade FROM Training_History WHERE Employee_Number = @EmployeeNumber ORDER BY Completion_Date DESC"
        ExportTableToWord(connection, wordDoc, trainingHistoryQuery, "Training History", employeeNumber)

        Dim trainingHistoryTable As Word.Table = wordDoc.Tables(wordDoc.Tables.Count)
        ApplyTableFormatting(trainingHistoryTable)

        wordDoc.Paragraphs.Add()

        ' certification and licenses
        Dim certificationAndLicensesQuery As String = "SELECT Certification_Name, Provider, License_Number, Grant_Date, Expiry_Date, Status FROM Certifications_and_Licenses WHERE Employee_Number = @EmployeeNumber"
        ExportTableToWord(connection, wordDoc, certificationAndLicensesQuery, "Certification and Licenses", employeeNumber)

        Dim certificationAndLicensesTable As Word.Table = wordDoc.Tables(wordDoc.Tables.Count)
        ApplyTableFormatting(certificationAndLicensesTable)

        wordDoc.Paragraphs.Add()

        ' trainingPlan
        Dim trainingPlanQuery As String = "SELECT Topic_or_Module_Name, Facilitator, Target_Date FROM Training_Plan WHERE Employee_Number = @EmployeeNumber"
        ExportTableToWord(connection, wordDoc, trainingPlanQuery, "Training Plan", employeeNumber)

        Dim trainingPlanTable As Word.Table = wordDoc.Tables(wordDoc.Tables.Count)
        ApplyTableFormatting(trainingPlanTable)

        wordDoc.Paragraphs.Add()

        ' trainingProgram
        Dim trainingProgramQuery As String = "SELECT Program_Title, Start_Date, Completion_Date, Deliberation_Score, Deliberation_Notes FROM Training_Programs WHERE Employee_Number = @EmployeeNumber"
        ExportTableToWord(connection, wordDoc, trainingProgramQuery, "Training Program", employeeNumber)

        Dim trainingProgramTable As Word.Table = wordDoc.Tables(wordDoc.Tables.Count)
        ApplyTableFormatting(trainingProgramTable)

        wordDoc.Paragraphs.Add()

        ' webinarsAttendad
        Dim webinarsAttendadQuery As String = "SELECT Webinar_Title, Date_, CPD_Units FROM Webinars_Attended WHERE Employee_Number = @EmployeeNumber"
        ExportTableToWord(connection, wordDoc, webinarsAttendadQuery, "Webinars Attended", employeeNumber)

        Dim webinarsAttendadTable As Word.Table = wordDoc.Tables(wordDoc.Tables.Count)
        ApplyTableFormatting(webinarsAttendadTable)

        wordDoc.Paragraphs.Add()

        ' clientFeedback
        Dim clientFeedbackQuery As String = "SELECT Account_Manager, Client_POC, Feedback_Date, Feedback_Summary, Staff_Performance_Rating FROM Client_Feedback WHERE Employee_Number = @EmployeeNumber"
        ExportTableToWord(connection, wordDoc, clientFeedbackQuery, "Client Feedback", employeeNumber)

        Dim clientFeedbackTable As Word.Table = wordDoc.Tables(wordDoc.Tables.Count)
        ApplyTableFormatting(clientFeedbackTable)

        wordDoc.Paragraphs.Add()

        ' selfAssessment
        Dim selfAssessmentQuery As String = "SELECT Account_Manager, Feedback_Date, Personal_Performance_Rating, Client_Rating, TBR_Rating FROM Self_Assessment WHERE Employee_Number = @EmployeeNumber"
        ExportTableToWord(connection, wordDoc, selfAssessmentQuery, "Self Assessment", employeeNumber)

        Dim selfAssessmentTable As Word.Table = wordDoc.Tables(wordDoc.Tables.Count)
        ApplyTableFormatting(selfAssessmentTable)

        wordDoc.Paragraphs.Add()

        ' competencyCertification
        Dim competencyCertificationQuery As String = "SELECT Certification_Name, Grant_Date, Deliberation_Summary, Overall_Grade FROM Competency_Certification WHERE Employee_Number = @EmployeeNumber"
        ExportTableToWord(connection, wordDoc, competencyCertificationQuery, "Competency Certification", employeeNumber)

        Dim competencyCertificationTable As Word.Table = wordDoc.Tables(wordDoc.Tables.Count)
        ApplyTableFormatting(competencyCertificationTable)

        wordDoc.SaveAs(filePath)
        wordDoc.Close()
        wordApp.Quit()

        ReleaseObject(wordDoc)
        ReleaseObject(wordApp)
    End Sub
    Private Sub ApplyTableFormatting(table As Word.Table)
        For Each cell As Word.Cell In table.Range.Cells
            If cell.RowIndex = 1 Then
                cell.Range.Font.Bold = True
            Else
                cell.Range.Font.Bold = False
            End If
            cell.Range.Font.Size = 10

            cell.Borders.Enable = True
            cell.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
            cell.Borders.OutsideLineWidth = Word.WdLineWidth.wdLineWidth050pt
            cell.Borders.OutsideColor = Word.WdColor.wdColorBlack
        Next
    End Sub

    Private Sub ExportTableToWord(connection As OleDbConnection, wordDoc As Word.Document, query As String, tableName As String, employeeNumber As String)
        connection.Open()

        Using command As New OleDbCommand(query, connection)
            command.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

            Dim reader As OleDbDataReader = command.ExecuteReader()
            Dim totalColumns As Integer = reader.FieldCount
            Dim tableRange As Word.Range = wordDoc.Range()

            If wordDoc.Content.End > wordDoc.Content.Start Then
                tableRange = wordDoc.Range(wordDoc.Content.End - 1)
            End If

            Dim titleRange As Word.Range = tableRange.Duplicate
            titleRange.Text = tableName
            titleRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            titleRange.Font.Bold = True
            titleRange.Font.Size = 12
            titleRange.InsertParagraphAfter()

            tableRange = titleRange.Paragraphs(2).Range
            tableRange.Collapse(Word.WdCollapseDirection.wdCollapseEnd)

            Dim table As Word.Table = wordDoc.Tables.Add(tableRange, 1, totalColumns)

            Dim excludedColumns As New List(Of String)

            Dim colIndex As Integer = 1
            For i As Integer = 0 To totalColumns - 1
                Dim columnName As String = reader.GetName(i)
                Dim columnHeader As String = columnName.Replace("_", " ")

                If colIndex <= table.Columns.Count Then
                    table.Cell(1, colIndex).Range.Text = ColumnHeader
            table.Cell(1, colIndex).Range.Font.Bold = True
            table.Cell(1, colIndex).Range.Font.Size = 10

        Else
            Console.WriteLine("Error: Column index exceeds the number of columns in the table.")
                End If

                colIndex += 1
            Next

            Dim rowCount As Integer = 0
            While reader.Read()
                rowCount += 1
                colIndex = 1
                table.Rows.Add()
                For i As Integer = 0 To totalColumns - 1
                    Dim columnName As String = reader.GetName(i)
                    If Not excludedColumns.Contains(columnName) Then
                        If TypeOf reader(i) Is Date Then
                            Dim dateValue As Date = Convert.ToDateTime(reader(i))
                            If dateValue <> #1/1/2001# Then
                                table.Cell(rowCount + 1, colIndex).Range.Text = dateValue.ToString("MM/dd/yyyy")
                            End If
                        Else
                            table.Cell(rowCount + 1, colIndex).Range.Text = reader(i).ToString()
                        End If
                        table.Cell(rowCount + 1, colIndex).Borders.Enable = True
                        table.Cell(rowCount + 1, colIndex).Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
                        table.Cell(rowCount + 1, colIndex).Borders.OutsideLineWidth = Word.WdLineWidth.wdLineWidth050pt
                        table.Cell(rowCount + 1, colIndex).Borders.OutsideColor = Word.WdColor.wdColorBlack

                        colIndex += 1
                    End If
                Next
            End While


        End Using

        connection.Close()
    End Sub
    Private Sub ReleaseObject(obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
#End Region
#Region "Export to PDF"
    Public Sub btnExportEmployeePDF_Click() Handles btnExportPDF.Click
        Dim employeeName As (String, String) = FetchEmployeeName(employeeNumber)
        Dim firstName As String = employeeName.Item1
        Dim lastName As String = employeeName.Item2

        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"
        saveFileDialog.Title = "Save Employee Profile"
        saveFileDialog.FileName = $"{employeeNumber} {firstName} {lastName}.pdf"

        If saveFileDialog.ShowDialog = DialogResult.OK AndAlso saveFileDialog.FileName <> "" Then
            ' Display the "Please wait" message after confirming the file save
            MessageBox.Show("Please wait while the profile is exporting. Thank you", "Profile Exporting", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Proceed with exporting the PDF
            ExportToPDF(connection, saveFileDialog.FileName, employeeNumber)

            ' Inform the user that the export is complete
            MessageBox.Show("Thank you for the wait. The profile has been exported!", "Profile Exported", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Optionally inform the user they cancelled the save
            MessageBox.Show("Export canceled. No file was saved or No file name detected.", "Export Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


        grpDisable()
    End Sub

    Public Sub ExportToPDF(connection As OleDbConnection, filePath As String, employeeNumber As String)
        Dim employeeName1 As (String, String) = FetchEmployeeName(employeeNumber)
        Dim firstName1 As String = employeeName1.Item1
        Dim lastName1 As String = employeeName1.Item2
        Dim fullname As String = $"{firstName1.Trim} {lastName1}"

        Dim doc As New Document()
        Dim output As New FileStream(filePath, FileMode.Create, FileAccess.Write)
        Dim pdfWriter As PdfWriter = PdfWriter.GetInstance(doc, output)

        Dim footerEvent As New FooterClass(fullname)
        pdfWriter.PageEvent = footerEvent
        doc.Open()

        ' Fetch employee name
        Dim employeeName As (String, String) = FetchEmployeeName(employeeNumber)
        Dim firstName As String = employeeName.Item1
        Dim lastName As String = employeeName.Item2

        ' Add Title
        Dim thisDate As Date
        thisDate = Today
        Dim pic = iTextSharp.text.Image.GetInstance("\\Backroom_NAS\SkillsProfiling\Resources\TBR_Logo.png")

        Dim test As New Paragraph()

        pic.Alignment = Element.ALIGN_CENTER

        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)
        Dim fontPath As String = "\\Backroom_NAS\SkillsProfiling\Resources\Fonts\GothamBold.ttf"
        Dim fontPath2 As String = "\\Backroom_NAS\SkillsProfiling\Resources\Fonts\GothamBook.ttf"
        Dim bfGothamBold As BaseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED)
        Dim bfGothamBook As BaseFont = BaseFont.CreateFont(fontPath2, BaseFont.IDENTITY_H, BaseFont.EMBEDDED)
        Dim gothamboldFont As New iTextSharp.text.Font(bfGothamBold, 12, iTextSharp.text.Font.NORMAL)
        Dim gothambookFont As New iTextSharp.text.Font(bfGothamBook, 12, iTextSharp.text.Font.NORMAL)
        Dim littlebookFont As New iTextSharp.text.Font(bfGothamBook, 10, iTextSharp.text.Font.NORMAL)

        Dim title As New Paragraph($"Skills Profile for {fullname}", gothamboldFont)
        Dim title2 As New Paragraph($"Date Exported: {thisDate.ToString("dd MMM yyyy")}", littlebookFont)
        Dim title3 As New Paragraph("THE BACKROOM OFFSHORING INC.", gothamboldFont)
        title.Alignment = Element.ALIGN_CENTER
        title2.Alignment = Element.ALIGN_CENTER
        title3.Alignment = Element.ALIGN_CENTER


        doc.Add(pic)
        doc.Add(title3)
        doc.Add(title)
        doc.Add(title2)

        doc.Add(New Paragraph(" "))



        ExportTableToPDF(connection, doc, "Employee_Profile", employeeNumber, "Employee Profile", "This section provides a comprehensive overview of the employee, including personal details, date of admission, and current position. It serves as the foundational data point for understanding everyone's journey within the company. ")
        doc.Add(New Paragraph(" "))

        ExportTableToPDF(connection, doc, "Job_History", employeeNumber, "Job History", "This outlines the employee's career trajectory within the organization, detailing previous roles, responsibilities, and promotion timelines. It helps track growth and experience over time.")
        doc.Add(New Paragraph(" "))

        ExportTableToPDF(connection, doc, "Task_Profile", employeeNumber, "Task Profile", "This section lists the specific tasks and responsibilities assigned to the employees in their current and past positions. It highlights their contributions and areas of expertise.")
        doc.Add(New Paragraph(" "))

        ExportTableToPDF(connection, doc, "Software_Tools", employeeNumber, "Software/Tools", "This is the list of software and tools that the employee is proficient in. This provides insight into their technical capabilities.")
        doc.Add(New Paragraph(" "))

        ExportTableToPDF(connection, doc, "Skills_Interview", employeeNumber, "Skills Interview", "This is a qualitative assessment where employees discuss their skills, strengths, and areas for improvement. It fosters self-reflection and allows for tailored development plans.")
        doc.Add(New Paragraph(" "))

        ExportTableToPDF(connection, doc, "Performance_Evaluation", employeeNumber, "Performance Evaluation", "This section captures the results of formal performance reviews, summarizing achievements and areas needing attention. It is essential for measuring progress and planning career development.")
        doc.Add(New Paragraph(" "))

        ExportTableToPDF(connection, doc, "Skills_Triage", employeeNumber, "Skills Triage", "This section assesses employees facing performance challenges, categorizing their issues to identify specific areas for improvement. It serves as a framework for monitoring progress and implementing targeted interventions, ensuring employees receive the support needed to enhance their performance and effectively fulfill their roles. ")
        doc.Add(New Paragraph(" "))

        ExportTableToPDF(connection, doc, "Training_History", employeeNumber, "Training History", "This records all formal training programs the employee has participated in, detailing topics covered, and skills acquired. ")
        doc.Add(New Paragraph(" "))

        ExportTableToPDF(connection, doc, "Certifications_and_Licenses", employeeNumber, "Certification and Licenses", "This section lists any relevant certifications or licenses held by the employee, showcasing their qualifications and commitment to professional growth.")
        doc.Add(New Paragraph(" "))

        ExportTableToPDF(connection, doc, "Training_Plan", employeeNumber, "Training Plan", "This outlines a personalized development plan for the employee, including specific training goals and timelines. It serves as a potential roadmap for skill enhancement and career advancement.")
        doc.Add(New Paragraph(" "))

        ExportTableToPDF(connection, doc, "Training_Programs", employeeNumber, "Training Programs", "(Description Placeholder)")
        doc.Add(New Paragraph(" "))

        ExportTableToPDF(connection, doc, "Webinars_Attended", employeeNumber, "Webinars Attended", "This records webinars and online learning sessions attended by the employee, highlighting their efforts to stay current with industry trends and continuously improve their skills.")
        doc.Add(New Paragraph(" "))

        ExportTableToPDF(connection, doc, "Client_Feedback", employeeNumber, "Client Feedback", "This section compiles feedback from clients regarding the employee’s performance, interactions, and contributions to projects. It provides valuable insights into the employee's impact on client relationships and helps identify strengths and areas for improvement.")
        doc.Add(New Paragraph(" "))

        ExportTableToPDF(connection, doc, "Self_Assessment", employeeNumber, "Self Assessment", "(Description Placeholder)")
        doc.Add(New Paragraph(" "))

        ExportTableToPDF(connection, doc, "Competency_Certification", employeeNumber, "Competency Certification", "(Description Placeholder)")
        doc.Add(New Paragraph(" "))



        doc.Close()
        pdfWriter.Close()
        output.Close()

        Dim tempFileName As String = filePath.Replace(".pdf", "_temp.pdf")


        ' Update total pages
        Using reader As New PdfReader(filePath)
            ' Create PdfStamper to modify the PDF
            Using stamper As New PdfStamper(reader, New FileStream(tempFileName, FileMode.Create, FileAccess.Write))
                Dim total As Integer = reader.NumberOfPages

                ' Loop through each page and add the total page number
                For i As Integer = 1 To total
                    Dim cb As PdfContentByte = stamper.GetOverContent(i)
                    ColumnText.ShowTextAligned(cb, Element.ALIGN_RIGHT, New Phrase($"Page {i} of {total}", footerEvent.pageFont), 559, 30, 0)
                Next
            End Using
        End Using

        ' Replace the original file with the updated one
        File.Delete(filePath)  ' Delete the original file
        File.Move(tempFileName, filePath)  ' Rename the temp file to the original file name
    End Sub

    Public Sub ExportTableToPDF(connection As OleDbConnection, pdfDoc As Document, tableName As String, employeeNumber As String, sectionTitle As String, description As String)
        connection.Open()

        Dim query As String

        If tableName = "Employee_Profile" Then
            ' Specify the columns you want from Employee_Profile
            query = "SELECT Employee_ID, Status, Employee_Number, Employee_First_Name, Employee_Last_Name, Last_Update FROM Employee_Profile WHERE Employee_Number = @EmployeeNumber"
        Else
            ' For other tables, keep the original query
            query = $"SELECT * FROM {tableName} WHERE Employee_Number = @EmployeeNumber"
        End If

        Using command As New OleDbCommand(query, connection)
            command.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

            Dim reader As OleDbDataReader = command.ExecuteReader()
            Dim totalColumns As Integer = reader.FieldCount

            ' Add section title
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)
            Dim fontPath As String = "\\Backroom_NAS\SkillsProfiling\Resources\Fonts\GothamBold.ttf"
            Dim fontPath2 As String = "\\Backroom_NAS\SkillsProfiling\Resources\Fonts\GothamBook.ttf"
            Dim bfGothamBold As BaseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED)
            Dim bfGothamBook As BaseFont = BaseFont.CreateFont(fontPath2, BaseFont.IDENTITY_H, BaseFont.EMBEDDED)
            Dim gothamboldFont As New iTextSharp.text.Font(bfGothamBold, 12, iTextSharp.text.Font.NORMAL)
            Dim gothambookFont As New iTextSharp.text.Font(bfGothamBook, 12, iTextSharp.text.Font.NORMAL)

            Dim title As New Paragraph(sectionTitle, gothamboldFont)


            title.Alignment = Element.ALIGN_LEFT
            pdfDoc.Add(title)
            Dim descriptionParagraph As New Paragraph(description, gothambookFont)
            descriptionParagraph.Alignment = Element.ALIGN_JUSTIFIED
            pdfDoc.Add(descriptionParagraph)

            pdfDoc.Add(New Paragraph(" "))

            ' Create a table with the number of columns in the query
            Dim pdfTable As New PdfPTable(totalColumns - 2)
            pdfTable.WidthPercentage = 100

            Dim customColor As New BaseColor(52, 37, 107)
            Dim textColor As New BaseColor(255, 255, 255)

            ' Add headers
            For i As Integer = 2 To totalColumns - 1
                Dim columnHeader As String = reader.GetName(i).Replace("_", " ")
                Dim headerfont As New iTextSharp.text.Font(bfGothamBook, 9, iTextSharp.text.Font.NORMAL)
                headerfont.Color = textColor
                Dim headercell As New PdfPCell(New Phrase(columnHeader, headerfont))
                headercell.BackgroundColor = customColor
                headercell.Padding = 10
                pdfTable.AddCell(headercell)
            Next

            ' Add rows
            While reader.Read()
                For i As Integer = 2 To totalColumns - 1
                    Dim cellValue As String = reader(i).ToString()
                    Dim rowfont As New iTextSharp.text.Font(bfGothamBook, 8.5, iTextSharp.text.Font.NORMAL)
                    Dim rowcell As New PdfPCell(New Phrase(cellValue, rowfont))
                    rowcell.Padding = 10
                    pdfTable.AddCell(rowcell)
                Next
            End While

            ' Add the table to the PDF document
            pdfDoc.Add(pdfTable)
        End Using

        connection.Close()
    End Sub
#End Region ' Working
#Region "Export To Excel (1 Sheet - NOT USED)"
    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) 'Handles btnExportExcelSheets.Click

        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx"
        saveFileDialog.Title = "Save Employee Profile"

        If saveFileDialog.ShowDialog = DialogResult.OK And saveFileDialog.FileName <> "" Then
            ' Display the "Please wait" message after confirming the file save
            MessageBox.Show("Please wait while the profile is exporting. Thank you", "Profile Exporting", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ExportToExcel(connection, "C:\Users\VinceAndreiCabral\Downloads\ExcelExportTemplate.xlsx", saveFileDialog.FileName, employeeNumber)

            MessageBox.Show("Thank you for the wait. The profile has been exported!", "Profile Exported", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            ' Optionally inform the user they cancelled the save
            MessageBox.Show("Export canceled. No file was saved or No file name detected.", "Export Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        grpDisable()
    End Sub

    Private Sub ExportToExcel(connection As OleDbConnection, templatePath As String, outputFilePath As String, employeeNumber As String)

        If File.Exists(outputFilePath) Then
            File.Delete(outputFilePath)
        End If
        File.Copy(templatePath, outputFilePath)

        Dim excelApp As New Excel.Application()
        Dim excelWorkbook As Excel.Workbook = excelApp.Workbooks.Open(outputFilePath)
        Dim excelWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets(1), Excel.Worksheet)

        Dim employeeName As (String, String) = FetchEmployeeName(employeeNumber)
        Dim firstName As String = employeeName.Item1
        Dim lastName As String = employeeName.Item2
        Dim employeeStatus As (String, String) = FetchEmployeeStatus(employeeNumber)
        Dim lastUpdate As String = employeeStatus.Item1
        Dim status As String = employeeStatus.Item2

        Dim formattedLastUpdate As String = lastUpdate.Trim()
        ' Check if the string contains "00:00:00" and remove it if present
        If formattedLastUpdate.Contains("00:00:00") Then
            formattedLastUpdate = formattedLastUpdate.Replace(" 00:00:00", "")
        End If

        excelWorksheet.Cells(3, 1).Value = employeeNumber
        excelWorksheet.Cells(3, 2).Value = $"{firstName} {lastName}"
        excelWorksheet.Cells(3, 3).Value = formattedLastUpdate


        Dim currentRow As Integer = 9

        Dim jobHistoryQuery As String = "SELECT Role_and_Designation, Client_Name, Region, Start_Date, End_Date, Reason_for_Change FROM Job_History WHERE Employee_Number = @EmployeeNumber"
        currentRow = ExportTableToExcel(connection, excelWorksheet, jobHistoryQuery, "Job History", employeeNumber, currentRow)

        Dim taskProfileQuery As String = "SELECT Task_Name, Category, POC, Description FROM Task_Profile WHERE Employee_Number = @EmployeeNumber"
        currentRow = ExportTableToExcel(connection, excelWorksheet, taskProfileQuery, "Task Profile", employeeNumber, currentRow)

        Dim softwareToolsQuery As String = "SELECT Software_or_Tool, Used_For FROM Software_Tools WHERE Employee_Number = @EmployeeNumber"
        currentRow = ExportTableToExcel(connection, excelWorksheet, softwareToolsQuery, "Software/Tools", employeeNumber, currentRow)

        Dim skillsInterviewQuery As String = "SELECT Role_or_Designation, Date_, Interviewer, Assessment_Notes FROM Skills_Interview WHERE Employee_Number = @EmployeeNumber"
        currentRow = ExportTableToExcel(connection, excelWorksheet, skillsInterviewQuery, "Skills Interview", employeeNumber, currentRow)

        Dim performanceEvalQuery As String = "SELECT Evaluation_Type, Evaluation_Date, Evaluator, Evaluation_Notes FROM Performance_Evaluation WHERE Employee_Number = @EmployeeNumber"
        currentRow = ExportTableToExcel(connection, excelWorksheet, performanceEvalQuery, "Performance Evaluation", employeeNumber, currentRow)

        Dim skillsTriageQuery As String = "SELECT Concern_By, Details_of_Concern, Start_Date, Date_Closed, Deliberation_Score, Deliberation_Notes FROM Skills_Triage WHERE Employee_Number = @EmployeeNumber"
        currentRow = ExportTableToExcel(connection, excelWorksheet, skillsTriageQuery, "Skills Triage", employeeNumber, currentRow)

        Dim trainingHistoryQuery As String = "SELECT Topic_or_Module_Title, Facilitator, Completion_Date, Grade FROM Training_History WHERE Employee_Number = @EmployeeNumber"
        currentRow = ExportTableToExcel(connection, excelWorksheet, trainingHistoryQuery, "Training History", employeeNumber, currentRow)

        Dim certificationsLicensesQuery As String = "SELECT Certification_Name, Chapter, Provider, License_Number, Grant_Date, Expiry_Date, Status FROM Certifications_and_Licenses WHERE Employee_Number = @EmployeeNumber"
        currentRow = ExportTableToExcel(connection, excelWorksheet, certificationsLicensesQuery, "Certifications and Licenses", employeeNumber, currentRow)

        Dim trainingPlanQuery As String = "SELECT Topic_or_Module_Name, Facilitator, Target_Date FROM Training_Plan WHERE Employee_Number = @EmployeeNumber"
        currentRow = ExportTableToExcel(connection, excelWorksheet, trainingPlanQuery, "Training Plan", employeeNumber, currentRow)

        Dim trainingProgramsQuery As String = "SELECT Program_Title, Start_Date, Completion_Date, Deliberation_Score, Deliberation_Notes FROM Training_Programs WHERE Employee_Number = @EmployeeNumber"
        currentRow = ExportTableToExcel(connection, excelWorksheet, trainingProgramsQuery, "Training Programs", employeeNumber, currentRow)

        Dim webinarsAttendedQuery As String = "SELECT Webinar_Title, Date_, CPD_Units FROM Webinars_Attended WHERE Employee_Number = @EmployeeNumber"
        currentRow = ExportTableToExcel(connection, excelWorksheet, webinarsAttendedQuery, "Webinars Attended", employeeNumber, currentRow)

        Dim clientFeedbackQuery As String = "SELECT Account_Manager, Client_POC, Feedback_Date, Feedback_Summary, Staff_Performance_Rating FROM Client_Feedback WHERE Employee_Number = @EmployeeNumber"
        currentRow = ExportTableToExcel(connection, excelWorksheet, clientFeedbackQuery, "Client Feedback", employeeNumber, currentRow)

        Dim selfAssessmentQuery As String = "SELECT Account_Manager, Feedback_Date, Personal_Performance_Rating, Client_Rating, TBR_Rating FROM Self_Assessment WHERE Employee_Number = @EmployeeNumber"
        currentRow = ExportTableToExcel(connection, excelWorksheet, selfAssessmentQuery, "Self Assessment", employeeNumber, currentRow)

        Dim competencyCertificationQuery As String = "SELECT Certification_Name, Grant_Date, Deliberation_Summary, Overall_Grade FROM Competency_Certification WHERE Employee_Number = @EmployeeNumber"
        currentRow = ExportTableToExcel(connection, excelWorksheet, competencyCertificationQuery, "Competency Certification", employeeNumber, currentRow)

        excelWorkbook.Save()
        excelWorkbook.Close()
        excelApp.Quit()

        ' Release COM objects
        ReleaseObject(excelWorksheet)
        ReleaseObject(excelWorkbook)
        ReleaseObject(excelApp)
    End Sub

    ' Helper function to export data and format it
    Private Function ExportTableToExcel(connection As OleDbConnection, worksheet As Excel.Worksheet, query As String, tableName As String, employeeNumber As String, startRow As Integer) As Integer
        connection.Open()
        Dim currentRow As Integer = startRow
        Using command As New OleDbCommand(query, connection)
            command.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)
            Dim reader As OleDbDataReader = command.ExecuteReader()



            FormatRow(worksheet, startRow)

            While reader.Read()

                If worksheet.Cells(currentRow, 2).Value Is Nothing Then
                    ' Insert a new row if data overflows the existing rows in the template
                    worksheet.Rows(currentRow).Insert(Excel.XlInsertShiftDirection.xlShiftDown)

                    ' Copy formatting and merged cells from the row above to the new row
                    worksheet.Rows(currentRow - 1).Copy()
                    worksheet.Rows(currentRow).PasteSpecial(Excel.XlPasteType.xlPasteFormats)
                    worksheet.Rows(currentRow).PasteSpecial(Excel.XlPasteType.xlPasteAll)
                    worksheet.Rows(currentRow).PasteSpecial(Excel.XlPasteType.xlPasteColumnWidths)
                End If

                ' Job History
                If tableName = "Job History" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Role_and_Designation").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Client_Name").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Region").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Start_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("End_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 6), reader("Reason_for_Change").ToString())
                End If
                ' Task Profile
                If tableName = "Task Profile" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Task_Name").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Category").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("POC").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("Description").ToString())
                End If
                ' Software/Tools
                If tableName = "Software/Tools" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Software_or_Tool").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Used_For").ToString())
                End If
                ' Skills Interview
                If tableName = "Skills Interview" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Role_or_Designation").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Date_").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Interviewer").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("Assessment_Notes").ToString())
                End If
                ' Performance Evaluation
                If tableName = "Performance Evaluation" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Evaluation_Type").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Evaluation_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Evaluator").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("Evaluation_Notes").ToString())
                End If

                ' Skills Triage
                If tableName = "Skills Triage" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Concern_By").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Details_of_Concern").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Start_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Date_Closed").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("Deliberation_Score").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 6), reader("Deliberation_Notes").ToString())
                End If

                ' Training History
                If tableName = "Training History" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Topic_or_Module_Title").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Facilitator").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Completion_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 6), reader("Grade").ToString())
                End If

                ' Certifications and Licenses
                If tableName = "Certifications and Licenses" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Certification_Name").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Chapter").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Provider").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("License_Number").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("Grant_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 6), reader("Expiry_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 7), reader("Status").ToString())
                End If

                ' Training Plan
                If tableName = "Training Plan" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Topic_or_Module_Name").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Facilitator").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 6), reader("Target_Date").ToString())
                End If

                ' Training Programs
                If tableName = "Training Programs" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Program_Title").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Start_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Completion_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("Deliberation_Score").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 6), reader("Deliberation_Notes").ToString())
                End If

                ' Webinars Attended
                If tableName = "Webinars Attended" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Webinar_Title").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Date_").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 6), reader("CPD_Units").ToString())
                End If

                ' Client Feedback
                If tableName = "Client Feedback" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Account_Manager").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Client_POC").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Feedback_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("Feedback_Summary").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 7), reader("Staff_Performance_Rating").ToString())
                End If

                ' Self Assessment
                If tableName = "Self Assessment" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Account_Manager").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Feedback_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Personal_Performance_Rating").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 6), reader("Client_Rating").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 7), reader("TBR_Rating").ToString())
                End If

                ' Competency Certification
                If tableName = "Competency Certification" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Certification_Name").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Grant_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Deliberation_Summary").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 7), reader("Overall_Grade").ToString())
                End If
                ' Apply borders to the row
                worksheet.Range($"A{currentRow}:F{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                worksheet.Range($"A{currentRow}:F{currentRow}").Borders.Color = RGB(0, 0, 0)

                currentRow += 1
            End While
            worksheet.Rows(startRow - 1).Delete()
        End Using

        connection.Close()
        Return currentRow + 3
    End Function
#End Region
#Region "Excel Formatting"
    Public Sub SetMergedCellValue(targetCell As Excel.Range, value As String)
        ' Check if the cell is merged
        If targetCell.MergeCells Then
            ' Get the full merged range
            Dim mergedRange As Excel.Range = targetCell.MergeArea
            ' Set the value to the entire merged range (or the first cell of that merged range)
            mergedRange.Cells(1, 1).Value = value
        Else
            ' If not merged, set the value normally
            targetCell.Value = value
        End If
    End Sub
    Public Sub FormatRow(worksheet As Excel.Worksheet, row As Integer)

        worksheet.Range($"B{row}:F{row}").Interior.Color = Color.White
        worksheet.Range($"B{row}:F{row}").Font.Color = RGB(0, 0, 0) ' Black font
        worksheet.Range($"B{row}:F{row}").Font.Bold = False ' Not bold
    End Sub
    Public Sub CopyRowFormat(startRow As Integer, newRow As Integer, worksheet As Excel.Worksheet)
        ' Copy the formatting from the startRow to the newRow
        worksheet.Range($"B{startRow}:F{startRow}").Copy()
        worksheet.Range($"B{newRow}:F{newRow}").PasteSpecial(Excel.XlPasteType.xlPasteFormats)
        System.Windows.Forms.Clipboard.Clear()
    End Sub
#End Region
#Region "Export to Excel Different Format for Report"

    Public Sub btnExportExcelSheets_Click()

        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx"
        saveFileDialog.Title = "Save Employee Profile"

        If saveFileDialog.ShowDialog = DialogResult.OK And saveFileDialog.FileName <> "" Then
            ' Display the "Please wait" message after confirming the file save
            MessageBox.Show("Please wait while the profile is exporting. Thank you", "Profile Exporting", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ExportToExcelSheets(connection, "C:\Users\VinceAndreiCabral\Downloads\ExcelExportSheets2Template.xlsx", saveFileDialog.FileName, employeeNumber)

            MessageBox.Show("Thank you for the wait. The profile has been exported!", "Profile Exported", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            ' Optionally inform the user they cancelled the save
            MessageBox.Show("Export canceled. No file was saved or No file name detected.", "Export Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        grpDisable()
    End Sub

    Public Sub ExportToExcelSheets(connection As OleDbConnection, templatePath As String, outputFilePath As String, employeeNumber As String)

        If File.Exists(outputFilePath) Then
            File.Delete(outputFilePath)
        End If
        File.Copy(templatePath, outputFilePath)

        Dim excelApp As New Excel.Application()
        Dim excelWorkbook As Excel.Workbook = excelApp.Workbooks.Open(outputFilePath)
        Dim excelWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets(1), Excel.Worksheet)

        Dim employeeName As (String, String) = FetchEmployeeName(employeeNumber)
        Dim firstName As String = employeeName.Item1
        Dim lastName As String = employeeName.Item2
        Dim employeeStatus As (String, String) = FetchEmployeeStatus(employeeNumber)
        Dim lastUpdate As String = employeeStatus.Item1
        Dim status As String = employeeStatus.Item2

        Dim employeeWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Employee Profile"), Excel.Worksheet)
        Dim formattedLastUpdate As String = lastUpdate.Trim()
        ' Check if the string contains "00:00:00" and remove it if present
        If formattedLastUpdate.Contains("00:00:00") Then
            formattedLastUpdate = formattedLastUpdate.Replace(" 00:00:00", "")
        End If
        employeeWorksheet.Cells(3, 1).Value = employeeNumber
        employeeWorksheet.Cells(3, 2).Value = $"{firstName.Trim} {lastName}"
        employeeWorksheet.Cells(3, 3).Value = formattedLastUpdate

        Dim startRow = 4
        Dim jobHistoryWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Job History"), Excel.Worksheet)
        Dim jobHistoryQuery As String = "SELECT Role_and_Designation, Client_Name, Region, Start_Date, End_Date, Reason_for_Change FROM Job_History WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelSheets(connection, jobHistoryWorksheet, jobHistoryQuery, "Job History", employeeNumber, startRow)

        Dim taskProfileWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Task Profile"), Excel.Worksheet)
        Dim taskProfileQuery As String = "SELECT Task_Name, Category, POC, Description FROM Task_Profile WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelSheets(connection, taskProfileWorksheet, taskProfileQuery, "Task Profile", employeeNumber, startRow)

        Dim softwareToolsWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Software and Tools"), Excel.Worksheet)
        Dim softwareToolsQuery As String = "SELECT Software_or_Tool, Used_For FROM Software_Tools WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelSheets(connection, softwareToolsWorksheet, softwareToolsQuery, "Software/Tools", employeeNumber, startRow)

        Dim skillsInterviewWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Skills Interview"), Excel.Worksheet)
        Dim skillsInterviewQuery As String = "SELECT Role_or_Designation, Date_, Interviewer, Assessment_Notes FROM Skills_Interview WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelSheets(connection, skillsInterviewWorksheet, skillsInterviewQuery, "Skills Interview", employeeNumber, startRow)

        Dim performanceEvalWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Performance Evaluation"), Excel.Worksheet)
        Dim performanceEvalQuery As String = "SELECT Evaluation_Type, Evaluation_Date, Evaluator, Evaluation_Notes FROM Performance_Evaluation WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelSheets(connection, performanceEvalWorksheet, performanceEvalQuery, "Performance Evaluation", employeeNumber, startRow)

        Dim skillsTriageWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Skills Triage"), Excel.Worksheet)
        Dim skillsTriageQuery As String = "SELECT Concern_By, Details_of_Concern, Start_Date, Date_Closed, Deliberation_Score, Deliberation_Notes FROM Skills_Triage WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelSheets(connection, skillsTriageWorksheet, skillsTriageQuery, "Skills Triage", employeeNumber, startRow)

        Dim trainingHistoryWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Training History"), Excel.Worksheet)
        Dim trainingHistoryQuery As String = "SELECT Topic_or_Module_Title, Facilitator, Completion_Date, Grade FROM Training_History WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelSheets(connection, trainingHistoryWorksheet, trainingHistoryQuery, "Training History", employeeNumber, startRow)

        Dim certificationsLicensesWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Certifications and Licenses"), Excel.Worksheet)
        Dim certificationsLicensesQuery As String = "SELECT Certification_Name, Chapter, Provider, License_Number, Grant_Date, Expiry_Date, Status FROM Certifications_and_Licenses WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelSheets(connection, certificationsLicensesWorksheet, certificationsLicensesQuery, "Certifications and Licenses", employeeNumber, startRow)

        Dim trainingPlanWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Training Plan"), Excel.Worksheet)
        Dim trainingPlanQuery As String = "SELECT Topic_or_Module_Name, Facilitator, Target_Date FROM Training_Plan WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelSheets(connection, trainingPlanWorksheet, trainingPlanQuery, "Training Plan", employeeNumber, startRow)

        Dim trainingProgramsWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Training Programs"), Excel.Worksheet)
        Dim trainingProgramsQuery As String = "SELECT Program_Title, Start_Date, Completion_Date, Deliberation_Score, Deliberation_Notes FROM Training_Programs WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelSheets(connection, trainingProgramsWorksheet, trainingProgramsQuery, "Training Programs", employeeNumber, startRow)

        Dim webinarsAttendedWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Webinars Attended"), Excel.Worksheet)
        Dim webinarsAttendedQuery As String = "SELECT Webinar_Title, Date_, CPD_Units FROM Webinars_Attended WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelSheets(connection, webinarsAttendedWorksheet, webinarsAttendedQuery, "Webinars Attended", employeeNumber, startRow)

        Dim clientFeedbackWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Client Feedback"), Excel.Worksheet)
        Dim clientFeedbackQuery As String = "SELECT Account_Manager, Client_POC, Feedback_Date, Feedback_Summary, Staff_Performance_Rating FROM Client_Feedback WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelSheets(connection, clientFeedbackWorksheet, clientFeedbackQuery, "Client Feedback", employeeNumber, startRow)

        Dim selfAssessmentWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Self Assessment"), Excel.Worksheet)
        Dim selfAssessmentQuery As String = "SELECT Account_Manager, Feedback_Date, Personal_Performance_Rating, Client_Rating, TBR_Rating FROM Self_Assessment WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelSheets(connection, selfAssessmentWorksheet, selfAssessmentQuery, "Self Assessment", employeeNumber, startRow)

        Dim competencyCertificationWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Competency Certifications"), Excel.Worksheet)
        Dim competencyCertificationQuery As String = "SELECT Certification_Name, Grant_Date, Deliberation_Summary, Overall_Grade FROM Competency_Certification WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelSheets(connection, competencyCertificationWorksheet, competencyCertificationQuery, "Competency Certification", employeeNumber, startRow)

        'To focus on the first row and column when opening the excel file

        jobHistoryWorksheet.Activate()
        jobHistoryWorksheet.Cells(1, 1).Select()

        taskProfileWorksheet.Activate()
        taskProfileWorksheet.Cells(1, 1).Select()

        softwareToolsWorksheet.Activate()
        softwareToolsWorksheet.Cells(1, 1).Select()

        skillsInterviewWorksheet.Activate()
        skillsInterviewWorksheet.Cells(1, 1).Select()

        performanceEvalWorksheet.Activate()
        performanceEvalWorksheet.Cells(1, 1).Select()

        skillsTriageWorksheet.Activate()
        skillsTriageWorksheet.Cells(1, 1).Select()

        trainingHistoryWorksheet.Activate()
        trainingHistoryWorksheet.Cells(1, 1).Select()

        certificationsLicensesWorksheet.Activate()
        certificationsLicensesWorksheet.Cells(1, 1).Select()

        trainingPlanWorksheet.Activate()
        trainingPlanWorksheet.Cells(1, 1).Select()

        trainingProgramsWorksheet.Activate()
        trainingProgramsWorksheet.Cells(1, 1).Select()

        webinarsAttendedWorksheet.Activate()
        webinarsAttendedWorksheet.Cells(1, 1).Select()

        clientFeedbackWorksheet.Activate()
        clientFeedbackWorksheet.Cells(1, 1).Select()

        selfAssessmentWorksheet.Activate()
        selfAssessmentWorksheet.Cells(1, 1).Select()

        competencyCertificationWorksheet.Activate()
        competencyCertificationWorksheet.Cells(1, 1).Select()

        employeeWorksheet.Activate()
        employeeWorksheet.Cells(1, 1).Select()

        excelWorkbook.Save()
        excelWorkbook.Close()
        excelApp.Quit()

        ' Release COM objects
        ReleaseObject(employeeWorksheet)
        ReleaseObject(jobHistoryWorksheet)
        ReleaseObject(taskProfileWorksheet)
        ReleaseObject(softwareToolsWorksheet)
        ReleaseObject(skillsInterviewWorksheet)
        ReleaseObject(performanceEvalWorksheet)
        ReleaseObject(skillsTriageWorksheet)
        ReleaseObject(trainingHistoryWorksheet)
        ReleaseObject(certificationsLicensesWorksheet)
        ReleaseObject(trainingPlanWorksheet)
        ReleaseObject(trainingProgramsWorksheet)
        ReleaseObject(webinarsAttendedWorksheet)
        ReleaseObject(clientFeedbackWorksheet)
        ReleaseObject(selfAssessmentWorksheet)
        ReleaseObject(competencyCertificationWorksheet)
        ReleaseObject(excelWorksheet)
        ReleaseObject(excelWorkbook)
        ReleaseObject(excelApp)
    End Sub

    ' Helper function to export data and format it
    Public Sub ExportTableToExcelSheets(connection As OleDbConnection, worksheet As Excel.Worksheet, query As String, tableName As String, employeeNumber As String, startRow As Integer)
        connection.Open()
        Dim currentRow As Integer = startRow
        Using command As New OleDbCommand(query, connection)
            command.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)
            Dim reader As OleDbDataReader = command.ExecuteReader()



            FormatRow(worksheet, startRow)

            While reader.Read()

                If worksheet.Cells(currentRow, 2).Value Is Nothing Then
                    ' Insert a new row if data overflows the existing rows in the template
                    worksheet.Rows(currentRow).Insert(Excel.XlInsertShiftDirection.xlShiftDown)

                    ' Copy formatting and merged cells from the row above to the new row
                    worksheet.Rows(currentRow - 1).Copy()
                    worksheet.Rows(currentRow).PasteSpecial(Excel.XlPasteType.xlPasteFormats)
                    worksheet.Rows(currentRow).PasteSpecial(Excel.XlPasteType.xlPasteAll)
                    worksheet.Rows(currentRow).PasteSpecial(Excel.XlPasteType.xlPasteColumnWidths)
                End If

                ' Job History
                If tableName = "Job History" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Role_and_Designation").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Client_Name").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Region").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Start_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("End_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 6), reader("Reason_for_Change").ToString())
                    worksheet.Range($"A{currentRow}:F{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:F{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:F{currentRow}").HorizontalAlignment = -4108
                End If
                ' Task Profile
                If tableName = "Task Profile" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Task_Name").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Category").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("POC").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Description").ToString())
                    worksheet.Range($"A{currentRow}:D{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:D{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:D{currentRow}").HorizontalAlignment = -4108
                End If
                ' Software/Tools
                If tableName = "Software/Tools" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Software_or_Tool").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Used_For").ToString())
                    worksheet.Range($"A{currentRow}:B{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:B{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:B{currentRow}").HorizontalAlignment = -4108
                End If
                ' Skills Interview
                If tableName = "Skills Interview" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Role_or_Designation").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Date_").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Interviewer").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Assessment_Notes").ToString())
                    worksheet.Range($"A{currentRow}:D{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:D{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:D{currentRow}").HorizontalAlignment = -4108
                End If
                ' Performance Evaluation
                If tableName = "Performance Evaluation" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Evaluation_Type").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Evaluation_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Evaluator").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Evaluation_Notes").ToString())
                    worksheet.Range($"A{currentRow}:D{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:D{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:D{currentRow}").HorizontalAlignment = -4108
                End If

                ' Skills Triage
                If tableName = "Skills Triage" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Concern_By").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Details_of_Concern").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Start_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Date_Closed").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("Deliberation_Score").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 6), reader("Deliberation_Notes").ToString())
                    worksheet.Range($"A{currentRow}:F{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:F{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:F{currentRow}").HorizontalAlignment = -4108
                End If

                ' Training History
                If tableName = "Training History" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Topic_or_Module_Title").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Facilitator").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Completion_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Grade").ToString())
                    worksheet.Range($"A{currentRow}:D{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:D{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:D{currentRow}").HorizontalAlignment = -4108
                End If

                ' Certifications and Licenses
                If tableName = "Certifications and Licenses" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Certification_Name").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Chapter").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Provider").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("License_Number").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("Grant_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 6), reader("Expiry_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 7), reader("Status").ToString())
                    worksheet.Range($"A{currentRow}:G{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:G{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:G{currentRow}").HorizontalAlignment = -4108
                End If

                ' Training Plan
                If tableName = "Training Plan" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Topic_or_Module_Name").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Facilitator").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Target_Date").ToString())
                    worksheet.Range($"A{currentRow}:C{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:C{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:C{currentRow}").HorizontalAlignment = -4108
                End If

                ' Training Programs
                If tableName = "Training Programs" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Program_Title").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Start_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Completion_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Deliberation_Score").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("Deliberation_Notes").ToString())
                    worksheet.Range($"A{currentRow}:E{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:E{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:E{currentRow}").HorizontalAlignment = -4108
                End If

                ' Webinars Attended
                If tableName = "Webinars Attended" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Webinar_Title").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Date_").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("CPD_Units").ToString())
                    worksheet.Range($"A{currentRow}:C{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:C{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:C{currentRow}").HorizontalAlignment = -4108
                End If

                ' Client Feedback
                If tableName = "Client Feedback" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Account_Manager").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Client_POC").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Feedback_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Feedback_Summary").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("Staff_Performance_Rating").ToString())
                    worksheet.Range($"A{currentRow}:E{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:E{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:E{currentRow}").HorizontalAlignment = -4108
                End If

                ' Self Assessment
                If tableName = "Self Assessment" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Account_Manager").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Feedback_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Personal_Performance_Rating").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Client_Rating").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("TBR_Rating").ToString())
                    worksheet.Range($"A{currentRow}:E{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:E{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:E{currentRow}").HorizontalAlignment = -4108
                End If

                ' Competency Certification
                If tableName = "Competency Certification" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Certification_Name").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Grant_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Deliberation_Summary").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Overall_Grade").ToString())
                    worksheet.Range($"A{currentRow}:D{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:D{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:D{currentRow}").HorizontalAlignment = -4108
                End If
                ' Apply borders to the row

                currentRow += 1
            End While
            worksheet.Rows(startRow - 1).Delete()
        End Using

        connection.Close()
    End Sub
#End Region
#Region "Export Excel (Same as OFF Format)"
    Public Sub btnExportExcelOffFormat_Click() Handles btnExportExcelSheets.Click

        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx"
        saveFileDialog.Title = "Save Employee Profile"

        If saveFileDialog.ShowDialog = DialogResult.OK And saveFileDialog.FileName <> "" Then
            ' Display the "Please wait" message after confirming the file save
            MessageBox.Show("Please wait while the profile is exporting. Thank you", "Profile Exporting", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Takes Template format from Backroom_NAS\SkillsProfiling folder
            ExportToExcelOffFormat(connection, "\\Backroom_NAS\SkillsProfiling\Skills Profiling - Export Template.xlsx", saveFileDialog.FileName, employeeNumber)

            MessageBox.Show("Thank you for the wait. The profile has been exported!", "Profile Exported", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            ' Optionally inform the user they cancelled the save
            MessageBox.Show("Export canceled. No file was saved or No file name detected.", "Export Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        grpDisable()
    End Sub

    Public Sub ExportToExcelOffFormat(connection As OleDbConnection, templatePath As String, outputFilePath As String, employeeNumber As String)

        If File.Exists(outputFilePath) Then
            File.Delete(outputFilePath)
        End If
        File.Copy(templatePath, outputFilePath)

        Dim excelApp As New Excel.Application()
        Dim excelWorkbook As Excel.Workbook = excelApp.Workbooks.Open(outputFilePath)
        Dim excelWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets(1), Excel.Worksheet)

        'Declare variables for fetched Employee Details
        Dim employeeName As (String, String) = FetchEmployeeName(employeeNumber)
        Dim firstName As String = employeeName.Item1
        Dim lastName As String = employeeName.Item2
        Dim employeeStatus As (String, String) = FetchEmployeeStatus(employeeNumber)
        Dim lastUpdate As String = employeeStatus.Item1
        Dim status As String = employeeStatus.Item2
        Dim employeeNumPass As (String, String) = FetchEmployeeNumPass(employeeNumber)
        Dim employeeNum As String = employeeNumPass.Item1
        Dim password As String = employeeNumPass.Item2
        Dim employeeRoleLink As (String, String) = FetchEmployeeRoleLink(employeeNumber)
        Dim role As String = employeeRoleLink.Item1
        Dim link As String = employeeRoleLink.Item2

        Dim employeeWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Employee_Profile"), Excel.Worksheet)
        Dim formattedLastUpdate As String = lastUpdate.Trim()
        ' Check if the string contains "00:00:00" and remove it if present
        If formattedLastUpdate.Contains("00:00:00") Then
            formattedLastUpdate = formattedLastUpdate.Replace(" 00:00:00", "")
        End If
        employeeWorksheet.Cells(2, 1).Value = employeeNumber
        employeeWorksheet.Cells(2, 2).Value = password
        employeeWorksheet.Cells(2, 3).Value = firstName.Trim
        employeeWorksheet.Cells(2, 4).Value = lastName
        employeeWorksheet.Cells(2, 5).Value = role
        employeeWorksheet.Cells(2, 6).Value = formattedLastUpdate
        employeeWorksheet.Cells(2, 7).Value = status
        employeeWorksheet.Cells(2, 8).Value = link

        'Queries for Selecting Tables and inserting data into cells
        Dim startRow = 3
        Dim jobHistoryWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Job_History"), Excel.Worksheet)
        Dim jobHistoryQuery As String = "SELECT Employee_Number, Role_and_Designation, Client_Name, Region, Start_Date, End_Date, Reason_for_Change FROM Job_History WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelOffFormat(connection, jobHistoryWorksheet, jobHistoryQuery, "Job History", employeeNumber, startRow)

        Dim taskProfileWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Task_Profile"), Excel.Worksheet)
        Dim taskProfileQuery As String = "SELECT Employee_Number, Task_Name, Category, POC, Description FROM Task_Profile WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelOffFormat(connection, taskProfileWorksheet, taskProfileQuery, "Task Profile", employeeNumber, startRow)

        Dim softwareToolsWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Software_Tools"), Excel.Worksheet)
        Dim softwareToolsQuery As String = "SELECT Employee_Number, Software_or_Tool, Used_For FROM Software_Tools WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelOffFormat(connection, softwareToolsWorksheet, softwareToolsQuery, "Software/Tools", employeeNumber, startRow)

        Dim skillsInterviewWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Skills_Interview"), Excel.Worksheet)
        Dim skillsInterviewQuery As String = "SELECT Employee_Number, Role_or_Designation, Date_, Interviewer, Assessment_Notes FROM Skills_Interview WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelOffFormat(connection, skillsInterviewWorksheet, skillsInterviewQuery, "Skills Interview", employeeNumber, startRow)

        Dim performanceEvalWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Performance_Evaluation"), Excel.Worksheet)
        Dim performanceEvalQuery As String = "SELECT Employee_Number, Evaluation_Type, Evaluation_Date, Evaluator, Evaluation_Notes FROM Performance_Evaluation WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelOffFormat(connection, performanceEvalWorksheet, performanceEvalQuery, "Performance Evaluation", employeeNumber, startRow)

        Dim skillsTriageWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Skills_Triage"), Excel.Worksheet)
        Dim skillsTriageQuery As String = "SELECT Employee_Number, Concern_By, Details_of_Concern, Start_Date, Date_Closed, Deliberation_Score, Deliberation_Notes FROM Skills_Triage WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelOffFormat(connection, skillsTriageWorksheet, skillsTriageQuery, "Skills Triage", employeeNumber, startRow)

        Dim trainingHistoryWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Training_History"), Excel.Worksheet)
        Dim trainingHistoryQuery As String = "SELECT Employee_Number, Topic_or_Module_Title, Facilitator, Completion_Date, Grade FROM Training_History WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelOffFormat(connection, trainingHistoryWorksheet, trainingHistoryQuery, "Training History", employeeNumber, startRow)

        Dim certificationsLicensesWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Certifications_and_Licenses"), Excel.Worksheet)
        Dim certificationsLicensesQuery As String = "SELECT Employee_Number, Certification_Name, Chapter, Provider, License_Number, Grant_Date, Expiry_Date, Status FROM Certifications_and_Licenses WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelOffFormat(connection, certificationsLicensesWorksheet, certificationsLicensesQuery, "Certifications and Licenses", employeeNumber, startRow)

        Dim trainingPlanWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Training_Plan"), Excel.Worksheet)
        Dim trainingPlanQuery As String = "SELECT Employee_Number, Topic_or_Module_Name, Facilitator, Target_Date FROM Training_Plan WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelOffFormat(connection, trainingPlanWorksheet, trainingPlanQuery, "Training Plan", employeeNumber, startRow)

        Dim trainingProgramsWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Training_Programs"), Excel.Worksheet)
        Dim trainingProgramsQuery As String = "SELECT Employee_Number, Program_Title, Start_Date, Completion_Date, Deliberation_Score, Deliberation_Notes FROM Training_Programs WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelOffFormat(connection, trainingProgramsWorksheet, trainingProgramsQuery, "Training Programs", employeeNumber, startRow)

        Dim webinarsAttendedWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Webinars_Attended"), Excel.Worksheet)
        Dim webinarsAttendedQuery As String = "SELECT Employee_Number, Webinar_Title, Date_, CPD_Units FROM Webinars_Attended WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelOffFormat(connection, webinarsAttendedWorksheet, webinarsAttendedQuery, "Webinars Attended", employeeNumber, startRow)

        Dim clientFeedbackWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Client_Feedback"), Excel.Worksheet)
        Dim clientFeedbackQuery As String = "SELECT Employee_Number, Account_Manager, Client_POC, Feedback_Date, Feedback_Summary, Staff_Performance_Rating FROM Client_Feedback WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelOffFormat(connection, clientFeedbackWorksheet, clientFeedbackQuery, "Client Feedback", employeeNumber, startRow)

        Dim selfAssessmentWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Self_Assessment"), Excel.Worksheet)
        Dim selfAssessmentQuery As String = "SELECT Employee_Number, Account_Manager, Feedback_Date, Personal_Performance_Rating, Client_Rating, TBR_Rating FROM Self_Assessment WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelOffFormat(connection, selfAssessmentWorksheet, selfAssessmentQuery, "Self Assessment", employeeNumber, startRow)

        Dim competencyCertificationWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets("Competency_Certification"), Excel.Worksheet)
        Dim competencyCertificationQuery As String = "SELECT Employee_Number, Certification_Name, Grant_Date, Deliberation_Summary, Overall_Grade FROM Competency_Certification WHERE Employee_Number = @EmployeeNumber"
        ExportTableToExcelOffFormat(connection, competencyCertificationWorksheet, competencyCertificationQuery, "Competency Certification", employeeNumber, startRow)

        'To focus on the first row and column when opening the excel file

        jobHistoryWorksheet.Activate()
        jobHistoryWorksheet.Cells(1, 1).Select()

        taskProfileWorksheet.Activate()
        taskProfileWorksheet.Cells(1, 1).Select()

        softwareToolsWorksheet.Activate()
        softwareToolsWorksheet.Cells(1, 1).Select()

        skillsInterviewWorksheet.Activate()
        skillsInterviewWorksheet.Cells(1, 1).Select()

        performanceEvalWorksheet.Activate()
        performanceEvalWorksheet.Cells(1, 1).Select()

        skillsTriageWorksheet.Activate()
        skillsTriageWorksheet.Cells(1, 1).Select()

        trainingHistoryWorksheet.Activate()
        trainingHistoryWorksheet.Cells(1, 1).Select()

        certificationsLicensesWorksheet.Activate()
        certificationsLicensesWorksheet.Cells(1, 1).Select()

        trainingPlanWorksheet.Activate()
        trainingPlanWorksheet.Cells(1, 1).Select()

        trainingProgramsWorksheet.Activate()
        trainingProgramsWorksheet.Cells(1, 1).Select()

        webinarsAttendedWorksheet.Activate()
        webinarsAttendedWorksheet.Cells(1, 1).Select()

        clientFeedbackWorksheet.Activate()
        clientFeedbackWorksheet.Cells(1, 1).Select()

        selfAssessmentWorksheet.Activate()
        selfAssessmentWorksheet.Cells(1, 1).Select()

        competencyCertificationWorksheet.Activate()
        competencyCertificationWorksheet.Cells(1, 1).Select()

        employeeWorksheet.Activate()
        employeeWorksheet.Cells(1, 1).Select()

        excelWorkbook.Save()
        excelWorkbook.Close()
        excelApp.Quit()

        ' Release COM objects
        ReleaseObject(employeeWorksheet)
        ReleaseObject(jobHistoryWorksheet)
        ReleaseObject(taskProfileWorksheet)
        ReleaseObject(softwareToolsWorksheet)
        ReleaseObject(skillsInterviewWorksheet)
        ReleaseObject(performanceEvalWorksheet)
        ReleaseObject(skillsTriageWorksheet)
        ReleaseObject(trainingHistoryWorksheet)
        ReleaseObject(certificationsLicensesWorksheet)
        ReleaseObject(trainingPlanWorksheet)
        ReleaseObject(trainingProgramsWorksheet)
        ReleaseObject(webinarsAttendedWorksheet)
        ReleaseObject(clientFeedbackWorksheet)
        ReleaseObject(selfAssessmentWorksheet)
        ReleaseObject(competencyCertificationWorksheet)
        ReleaseObject(excelWorksheet)
        ReleaseObject(excelWorkbook)
        ReleaseObject(excelApp)
    End Sub

    ' Helper function to export data and format it
    Public Sub ExportTableToExcelOffFormat(connection As OleDbConnection, worksheet As Excel.Worksheet, query As String, tableName As String, employeeNumber As String, startRow As Integer)
        connection.Open()

        'Declare row in which data will be inserted into
        Dim currentRow As Integer = startRow
        Using command As New OleDbCommand(query, connection)
            command.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)
            Dim reader As OleDbDataReader = command.ExecuteReader()



            FormatRow(worksheet, startRow)

            While reader.Read()
                If worksheet.Cells(currentRow, 2).Value Is Nothing Then
                    ' Insert a new row if data overflows the existing rows in the template
                    worksheet.Rows(currentRow).Insert(Excel.XlInsertShiftDirection.xlShiftDown)

                    ' Copy formatting and merged cells from the row above to the new row
                    worksheet.Rows(currentRow - 1).Copy()

                    ' Now perform paste operations
                    worksheet.Rows(currentRow).PasteSpecial(Excel.XlPasteType.xlPasteFormats)
                    worksheet.Rows(currentRow).PasteSpecial(Excel.XlPasteType.xlPasteAll)
                    worksheet.Rows(currentRow).PasteSpecial(Excel.XlPasteType.xlPasteColumnWidths)
                End If
                ' Job History
                If tableName = "Job History" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Employee_Number").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Role_and_Designation").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Client_Name").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Region").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("Start_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 6), reader("End_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 7), reader("Reason_for_Change").ToString())
                    worksheet.Range($"A{currentRow}:G{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:G{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:G{currentRow}").HorizontalAlignment = -4108
                End If
                ' Task Profile
                If tableName = "Task Profile" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Employee_Number").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Task_Name").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Category").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("POC").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("Description").ToString())
                    worksheet.Range($"A{currentRow}:E{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:E{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:E{currentRow}").HorizontalAlignment = -4108
                End If
                ' Software/Tools
                If tableName = "Software/Tools" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Employee_Number").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Software_or_Tool").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Used_For").ToString())
                    worksheet.Range($"A{currentRow}:C{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:C{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:C{currentRow}").HorizontalAlignment = -4108
                End If
                ' Skills Interview
                If tableName = "Skills Interview" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Employee_Number").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Role_or_Designation").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Date_").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Interviewer").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("Assessment_Notes").ToString())
                    worksheet.Range($"A{currentRow}:E{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:E{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:E{currentRow}").HorizontalAlignment = -4108
                End If
                ' Performance Evaluation
                If tableName = "Performance Evaluation" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Employee_Number").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Evaluation_Type").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Evaluation_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Evaluator").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("Evaluation_Notes").ToString())
                    worksheet.Range($"A{currentRow}:E{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:E{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:E{currentRow}").HorizontalAlignment = -4108
                End If

                ' Skills Triage
                If tableName = "Skills Triage" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Employee_Number").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Concern_By").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Start_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Date_Closed").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("Details_of_Concern").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 6), reader("Deliberation_Score").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 7), reader("Deliberation_Notes").ToString())
                    worksheet.Range($"A{currentRow}:G{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:G{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:G{currentRow}").HorizontalAlignment = -4108
                End If

                ' Training History
                If tableName = "Training History" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Employee_Number").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Topic_or_Module_Title").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Facilitator").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Completion_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("Grade").ToString())
                    worksheet.Range($"A{currentRow}:E{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:E{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:E{currentRow}").HorizontalAlignment = -4108
                End If

                ' Certifications and Licenses
                If tableName = "Certifications and Licenses" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Employee_Number").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Certification_Name").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Chapter").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Provider").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("License_Number").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 6), reader("Grant_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 7), reader("Expiry_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 8), reader("Status").ToString())
                    worksheet.Range($"A{currentRow}:H{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:H{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:H{currentRow}").HorizontalAlignment = -4108
                End If

                ' Training Plan
                If tableName = "Training Plan" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Employee_Number").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Topic_or_Module_Name").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Facilitator").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Target_Date").ToString())
                    worksheet.Range($"A{currentRow}:D{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:D{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:D{currentRow}").HorizontalAlignment = -4108
                End If

                ' Training Programs
                If tableName = "Training Programs" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Employee_Number").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Program_Title").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Start_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Completion_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("Deliberation_Score").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 6), reader("Deliberation_Notes").ToString())
                    worksheet.Range($"A{currentRow}:F{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:F{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:F{currentRow}").HorizontalAlignment = -4108
                End If

                ' Webinars Attended
                If tableName = "Webinars Attended" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Employee_Number").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Webinar_Title").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Date_").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("CPD_Units").ToString())
                    worksheet.Range($"A{currentRow}:D{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:D{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:D{currentRow}").HorizontalAlignment = -4108
                End If

                ' Client Feedback
                If tableName = "Client Feedback" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Employee_Number").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Account_Manager").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Client_POC").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Feedback_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("Feedback_Summary").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 6), reader("Staff_Performance_Rating").ToString())
                    worksheet.Range($"A{currentRow}:F{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:F{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:F{currentRow}").HorizontalAlignment = -4108
                End If

                ' Self Assessment
                If tableName = "Self Assessment" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Employee_Number").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Account_Manager").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Feedback_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Personal_Performance_Rating").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("Client_Rating").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 6), reader("TBR_Rating").ToString())
                    worksheet.Range($"A{currentRow}:F{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:F{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:F{currentRow}").HorizontalAlignment = -4108
                End If

                ' Competency Certification
                If tableName = "Competency Certification" Then
                    SetMergedCellValue(worksheet.Cells(currentRow, 1), reader("Employee_Number").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 2), reader("Certification_Name").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 3), reader("Grant_Date").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 4), reader("Deliberation_Summary").ToString())
                    SetMergedCellValue(worksheet.Cells(currentRow, 5), reader("Overall_Grade").ToString())
                    worksheet.Range($"A{currentRow}:E{currentRow}").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Range($"A{currentRow}:E{currentRow}").Borders.Color = RGB(0, 0, 0)
                    worksheet.Range($"A{currentRow}:E{currentRow}").HorizontalAlignment = -4108
                End If
                ' Apply borders to the row

                currentRow += 1
            End While
            worksheet.Rows(startRow - 1).Delete()
        End Using

        connection.Close()
    End Sub
#End Region 'Current Working Excel Format
#End Region 'Contains WORD(UNUSED), PDF (WORKING), EXCEL (OFF FORMAT WORKING, Others have Report Format)
#Region "Others"
    'Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
    'Process.Start(New ProcessStartInfo With {
    '.FileName = "cmd",
    '.Arguments = $"/c start https://thebackroommop.sharepoint.com/sites/BackroomSkillsProfiling/Shared%20Documents/Forms/AllItems.aspx",
    '.UseShellExecute = False,
    '.CreateNoWindow = True
    '})
    'End Sub

    Private Sub accountButton_Click(sender As Object, e As EventArgs) Handles picboxMenu.Click
        If grpEmployeeProfile.Visible = True Then
            grpEmployeeProfile.Visible = False
        Else
            grpEmployeeProfile.Visible = True
        End If

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
    End Sub


#End Region
End Class
