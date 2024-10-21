Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing
Imports System.Text
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Transactions


Public Class EmployeeListF
    Dim connection As OleDbConnection = SkillsProfile_Database.GetConnection()

    ' variable for fetching employee id into loginF
    Public Property EmployeeID As String

    ' this is for the text change
    Private changesMade As Boolean = False

    'check if dashboard is closing due to exit button
    Private isLoggingout As Boolean = False

    ' this is for checking if password textbox has been edited
    Private passwordEdited As Boolean = False

    ' this is for button color when clicked to revert
    Private originalBackColor As Color
    Private originalForeColor As Color

    Dim employeeRole As Integer
#Region "Data Grid Events"
    Private Sub EmployeeListDataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmployeeListDataGrid.CellDoubleClick
        If e.RowIndex >= 0 Then
            If EmployeeListDataGrid.ColumnHeadersVisible Then
                Dim employeeNumber As String = EmployeeListDataGrid.Rows(e.RowIndex).Cells("Employee_Number").Value.ToString()
                Dim employeeForm As New EmployeeF()
                employeeForm.txtEmployeeNumber.Text = employeeNumber
                employeeForm.employeeRoleAdmin = employeeRole
                employeeForm.Show()
            Else
                AddHandler EmployeeListDataGrid.ColumnHeadersHeightChanged, AddressOf OnColumnHeadersHeightChanged
            End If
        End If
    End Sub
    Private Sub OnColumnHeadersHeightChanged(sender As Object, e As EventArgs)
        RemoveHandler EmployeeListDataGrid.ColumnHeadersHeightChanged, AddressOf OnColumnHeadersHeightChanged

        Dim selectedRowIndex As Integer = EmployeeListDataGrid.CurrentCell.RowIndex
        Dim employeeNumber As String = EmployeeListDataGrid.Rows(selectedRowIndex).Cells("Employee_Number").Value.ToString()

        Dim employeeForm As New EmployeeF()
        employeeForm.txtEmployeeNumber.Text = employeeNumber
        employeeForm.Show()
    End Sub
#End Region 'Double click and Column Header Change
#Region "EmployeeListF Load and Close"
    Private Sub EmployeeListF_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtEmployeeIDAdmin.Text = EmployeeID
        rdbtnActiveEmployees.Checked = True

        'Load the Color'

        connection.Close()

        Try
            connection.Open()

            Dim employeeQuery As String = "SELECT Employee_Last_Name, Employee_First_Name, Employee_Role FROM Employee_Profile WHERE Employee_Number = @EmployeeNumber"
            Dim employeeCmd As New OleDbCommand(employeeQuery, connection)
            employeeCmd.Parameters.AddWithValue("@EmployeeNumber", EmployeeID)

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

            If employeeRole = 4 Or employeeRole = 3 Then
                btnAddEmployee.Visible = True
                deleteEmployeeBtn.Visible = True
            ElseIf employeeRole = 2 Then
                btnAddEmployee.Visible = False
                deleteEmployeeBtn.Visible = False
                btnImportProfile.Visible = False
            End If

            Dim query As String = ""

            If employeeRole = 4 Then
                query = "SELECT Employee_Number, Employee_First_Name, Employee_Last_Name, Last_Update, Status FROM Employee_Profile WHERE Employee_Number <> @EmployeeID"
            ElseIf employeeRole = 3 Then
                query = "SELECT Employee_Number, Employee_First_Name, Employee_Last_Name, Last_Update, Status FROM Employee_Profile WHERE Employee_Role < 2 AND Employee_Number <> @EmployeeID"
            ElseIf employeeRole = 2 Then
                query = "SELECT Employee_Number, Employee_First_Name, Employee_Last_Name, Last_Update, Status FROM Employee_Profile WHERE Employee_Role = 1 AND Employee_Number <> @EmployeeID"
            End If

            Dim adapter As New OleDbDataAdapter(query, connection)
            Dim dataTable As New DataTable()

            adapter.SelectCommand.Parameters.AddWithValue("@EmployeeID", EmployeeID)
            adapter.Fill(dataTable)

            EmployeeListDataGrid.DataSource = dataTable

            DataGridFormatting()

            For Each column As DataGridViewColumn In EmployeeListDataGrid.Columns
                If column.HeaderText.Contains("_") Then
                    column.HeaderText = column.HeaderText.Replace("_", " ")
                End If
            Next

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Private Sub EmployeeListF_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If Not isLoggingout Then
            Application.Exit()
        End If
    End Sub
#End Region
#Region "Functions"
#Region "Save"
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveChangesToDatabase()
        ActiveEmployees()
        HideButtons()
    End Sub

    Private Sub SaveChangesToDatabase()
        Try
            connection.Open()

            Dim updateQuery As String = "UPDATE Employee_Profile SET Employee_Last_Name = @LastName, Employee_First_Name = @FirstName WHERE Employee_Number = @EmployeeNumber"
            Dim updateCmd As New OleDbCommand(updateQuery, connection)
            updateCmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
            updateCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            updateCmd.Parameters.AddWithValue("@EmployeeNumber", EmployeeID)

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
#End Region
#Region "Data Grid Formatting"
    Public Sub Reload()
        ReloadDataAndBindGrid()
    End Sub
    Public Sub ReloadDataAndBindGrid()
        Try
            EmployeeListDataGrid.DataSource = Nothing

            Dim query As String = ""

            If employeeRole = 4 Then
                query = "SELECT Employee_Number, Employee_Last_Name, Employee_First_Name, Last_Update, Status FROM Employee_Profile WHERE Employee_Number <> @EmployeeID"
            ElseIf employeeRole = 3 Then
                query = "SELECT Employee_Number, Employee_First_Name, Employee_Last_Name, Last_Update, Status FROM Employee_Profile WHERE Employee_Role = 1"
            ElseIf employeeRole = 2 Then
                query = "SELECT Employee_Number, Employee_First_Name, Employee_Last_Name, Last_Update, Status FROM Employee_Profile WHERE Employee_Role = 1"
            End If

            Dim adapter As New OleDbDataAdapter(query, connection)
            Dim dataTable As New DataTable()

            adapter.SelectCommand.Parameters.AddWithValue("@EmployeeID", EmployeeID)
            adapter.Fill(dataTable)

            EmployeeListDataGrid.DataSource = dataTable

            DataGridFormatting()

            For Each column As DataGridViewColumn In EmployeeListDataGrid.Columns
                If column.HeaderText.Contains("_") Then
                    column.HeaderText = column.HeaderText.Replace("_", " ")
                End If
            Next

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub DataGridFormatting()
        EmployeeListDataGrid.ReadOnly = True
        EmployeeListDataGrid.MultiSelect = False
        EmployeeListDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        EmployeeListDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

        EmployeeListDataGrid.AllowUserToAddRows = False
        EmployeeListDataGrid.ScrollBars = ScrollBars.Vertical
        EmployeeListDataGrid.Sort(EmployeeListDataGrid.Columns("Employee_Number"), System.ComponentModel.ListSortDirection.Ascending)

        EmployeeListDataGrid.Font = New Font("Gotham", 9)
        ' 1642 Old Grid View
        ' 1568 New Grid View Size
        ' 778
        EmployeeListDataGrid.Columns("Employee_Number").Width = 140 '200 '212.83
        EmployeeListDataGrid.Columns("Employee_Last_Name").Width = 150 '300 '312.83
        EmployeeListDataGrid.Columns("Employee_First_Name").Width = 150 '300 '312.83
        EmployeeListDataGrid.Columns("Status").Width = 138 '484 '115.83
        EmployeeListDataGrid.Columns("Last_Update").Width = 100 '484 '312.83

    End Sub
#End Region
#Region "Unknown Password Event"
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
#End Region 'Probably from last menu design and is now unused
#Region "Logout"
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            isLoggingout = True
            Dim loginForm As New LoginF
            loginForm.Show()

            Close()

        End If
    End Sub
#End Region
#Region "Edit and Cancel"
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ShowButtons()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        HideButtons()
    End Sub
    Private Sub ShowButtons()
        btnSave.Visible = True
        btnCancel.Visible = True
        btnEdit.Visible = False

        txtFirstName.Enabled = True
        txtLastName.Enabled = True
    End Sub
    Private Sub HideButtons()
        btnSave.Visible = False
        btnCancel.Visible = False
        btnEdit.Visible = True

        txtFirstName.Enabled = False
        txtLastName.Enabled = False
    End Sub
#End Region
#Region "Attempted Acess"
    Private Sub btnAttemptedAccess_Click(sender As Object, e As EventArgs) Handles btnAttemptedAccess.Click
        Dim attemptedAccess As New Attempt
        attemptedAccess.ShowDialog()
    End Sub
#End Region
#Region "Add Employee"
    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Dim addEmployee As New AddEmployee
        addEmployee.ShowDialog()
    End Sub
#End Region
#Region "Delete Employee"
    Private Sub deleteEmployeeBtn_Click(sender As Object, e As EventArgs) Handles deleteEmployeeBtn.Click
        If EmployeeListDataGrid.SelectedRows.Count > 0 Then
            Dim selectedRow = EmployeeListDataGrid.SelectedRows(0)
            Dim employeeNumber = selectedRow.Cells("Employee_Number").Value.ToString

            Dim result = MessageBox.Show("Are you sure you want to delete employee " & employeeNumber & " and all of their records?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    connection.Open()

                    Dim deleteEPQuery = "DELETE FROM Employee_Profile WHERE Employee_Number = @EmployeeNumber"
                    Dim deleteEPCmd As New OleDbCommand(deleteEPQuery, connection)
                    deleteEPCmd.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)
                    deleteEPCmd.ExecuteNonQuery()

                    Dim deleteJHQuery = "DELETE FROM Job_History WHERE Employee_Number = @EmployeeNumber"
                    Dim deleteJHCmd As New OleDbCommand(deleteJHQuery, connection)
                    deleteJHCmd.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)
                    deleteJHCmd.ExecuteNonQuery()

                    Dim deleteTPfQuery = "DELETE FROM Task_Profile WHERE Employee_Number = @EmployeeNumber"
                    Dim deleteTPfCmd As New OleDbCommand(deleteTPfQuery, connection)
                    deleteTPfCmd.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)
                    deleteTPfCmd.ExecuteNonQuery()

                    Dim deleteSATQuery = "DELETE FROM Software_Tools WHERE Employee_Number = @EmployeeNumber"
                    Dim deleteSATCmd As New OleDbCommand(deleteSATQuery, connection)
                    deleteSATCmd.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)
                    deleteSATCmd.ExecuteNonQuery()

                    Dim deleteSIQuery = "DELETE FROM Skills_Interview WHERE Employee_Number = @EmployeeNumber"
                    Dim deleteSICmd As New OleDbCommand(deleteSIQuery, connection)
                    deleteSICmd.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)
                    deleteSICmd.ExecuteNonQuery()

                    Dim deletePEQuery = "DELETE FROM Performance_Evaluation WHERE Employee_Number = @EmployeeNumber"
                    Dim deletePECmd As New OleDbCommand(deletePEQuery, connection)
                    deletePECmd.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)
                    deletePECmd.ExecuteNonQuery()

                    Dim deleteSTQuery = "DELETE FROM Skills_Triage WHERE Employee_Number = @EmployeeNumber"
                    Dim deleteSTCmd As New OleDbCommand(deleteSTQuery, connection)
                    deleteSTCmd.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)
                    deleteSTCmd.ExecuteNonQuery()

                    Dim deleteTHQuery = "DELETE FROM Training_History WHERE Employee_Number = @EmployeeNumber"
                    Dim deleteTHCmd As New OleDbCommand(deleteTHQuery, connection)
                    deleteTHCmd.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)
                    deleteTHCmd.ExecuteNonQuery()

                    Dim deleteCLQuery = "DELETE FROM Certifications_and_Licenses WHERE Employee_Number = @EmployeeNumber"
                    Dim deleteCLCmd As New OleDbCommand(deleteCLQuery, connection)
                    deleteCLCmd.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)
                    deleteCLCmd.ExecuteNonQuery()

                    Dim deleteTPnQuery = "DELETE FROM Training_Plan WHERE Employee_Number = @EmployeeNumber"
                    Dim deleteTPnCmd As New OleDbCommand(deleteTPnQuery, connection)
                    deleteTPnCmd.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)
                    deleteTPnCmd.ExecuteNonQuery()

                    Dim deleteTPgQuery = "DELETE FROM Training_Programs WHERE Employee_Number = @EmployeeNumber"
                    Dim deleteTPgCmd As New OleDbCommand(deleteTPgQuery, connection)
                    deleteTPgCmd.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)
                    deleteTPgCmd.ExecuteNonQuery()

                    Dim deleteWAQuery = "DELETE FROM Webinars_Attended WHERE Employee_Number = @EmployeeNumber"
                    Dim deleteWACmd As New OleDbCommand(deleteWAQuery, connection)
                    deleteWACmd.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)
                    deleteWACmd.ExecuteNonQuery()

                    Dim deleteCFQuery = "DELETE FROM Client_Feedback WHERE Employee_Number = @EmployeeNumber"
                    Dim deleteCFCmd As New OleDbCommand(deleteCFQuery, connection)
                    deleteCFCmd.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)
                    deleteCFCmd.ExecuteNonQuery()

                    Dim deleteSAQuery = "DELETE FROM Self_Assessment WHERE Employee_Number = @EmployeeNumber"
                    Dim deleteSACmd As New OleDbCommand(deleteSAQuery, connection)
                    deleteSACmd.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)
                    deleteSACmd.ExecuteNonQuery()

                    Dim deleteCCQuery = "DELETE FROM Competency_Certification WHERE Employee_Number = @EmployeeNumber"
                    Dim deleteCCCmd As New OleDbCommand(deleteCCQuery, connection)
                    deleteCCCmd.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)
                    deleteCCCmd.ExecuteNonQuery()

                    EmployeeListDataGrid.Rows.Remove(selectedRow)

                    MessageBox.Show("Employee " & employeeNumber & " has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error deleting employee: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If connection.State = ConnectionState.Open Then
                        connection.Close()
                    End If
                End Try
            End If
        End If
    End Sub
#End Region
#Region "Change Password"
    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        ChangePasswordForm.Show()
    End Sub
#End Region
#End Region 'Button Events and Data Grid Format
#Region "Search"
    Private Sub txtSearchEmployeeNumber_TextChanged(sender As Object, e As EventArgs) Handles txtSearchEmployeeNumber.TextChanged
        Dim searchText = txtSearchEmployeeNumber.Text.Trim
        Dim query = ""

        If String.IsNullOrWhiteSpace(searchText) Then
            If employeeRole = 4 Then
                query = "SELECT Employee_Number, Employee_First_Name, Employee_Last_Name, Last_Update, Status FROM Employee_Profile WHERE Employee_Number <> @EmployeeID AND Status = 'Active'"
            ElseIf employeeRole = 3 Then
                query = "SELECT Employee_Number, Employee_First_Name, Employee_Last_Name, Last_Update, Status FROM Employee_Profile WHERE Employee_Role = 1 AND Status = 'Active'"
            ElseIf employeeRole = 2 Then
                query = "SELECT Employee_Number, Employee_First_Name, Employee_Last_Name, Last_Update, Status FROM Employee_Profile WHERE Employee_Role = 1 AND Status = 'Active'"
            End If
        Else
            searchText = "TBR-" & searchText
            If employeeRole = 4 Then
                query = "SELECT Employee_Number, Employee_First_Name, Employee_Last_Name, Last_Update, Status FROM Employee_Profile WHERE (Employee_Number <> @EmployeeID) AND (Employee_Number LIKE @SearchText)"
            ElseIf employeeRole = 3 Then
                query = "SELECT Employee_Number, Employee_First_Name, Employee_Last_Name, Last_Update, Status FROM Employee_Profile WHERE (Employee_Role = 1) AND (Employee_Number LIKE @SearchText)"
            ElseIf employeeRole = 2 Then
                query = "SELECT Employee_Number, Employee_First_Name, Employee_Last_Name, Last_Update, Status FROM Employee_Profile WHERE (Employee_Role = 1) AND (Employee_Number LIKE @SearchText)"
            End If
        End If

        Dim adapter As New OleDbDataAdapter(query, connection)
        Dim dataTable As New DataTable

        adapter.SelectCommand.Parameters.AddWithValue("@EmployeeID", EmployeeID)
        adapter.SelectCommand.Parameters.AddWithValue("@SearchText", searchText & "%")

        adapter.Fill(dataTable)

        EmployeeListDataGrid.DataSource = dataTable
    End Sub
    Public Sub ActiveEmployees()
        Try
            EmployeeListDataGrid.DataSource = Nothing

            Dim query As String = ""

            If employeeRole = 4 Then
                query = "SELECT Employee_Number, Employee_Last_Name, Employee_First_Name, Last_Update, Status FROM Employee_Profile WHERE Employee_Number <> @EmployeeID AND Status = 'Active'"
            ElseIf employeeRole = 3 Then
                query = "SELECT Employee_Number, Employee_First_Name, Employee_Last_Name, Last_Update, Status FROM Employee_Profile WHERE Employee_Role = 1 AND Status ='Active'"
            ElseIf employeeRole = 2 Then
                query = "SELECT Employee_Number, Employee_First_Name, Employee_Last_Name, Last_Update, Status FROM Employee_Profile WHERE Employee_Role = 1 AND Status ='Active'"
            End If

            Dim adapter As New OleDbDataAdapter(query, connection)
            Dim dataTable As New DataTable()

            adapter.SelectCommand.Parameters.AddWithValue("@EmployeeID", EmployeeID)
            adapter.Fill(dataTable)

            EmployeeListDataGrid.DataSource = dataTable

            DataGridFormatting()

            For Each column As DataGridViewColumn In EmployeeListDataGrid.Columns
                If column.HeaderText.Contains("_") Then
                    column.HeaderText = column.HeaderText.Replace("_", " ")
                End If
            Next

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub InactiveEmployees()
        Try
            EmployeeListDataGrid.DataSource = Nothing

            Dim query As String = ""

            If employeeRole = 4 Then
                query = "SELECT Employee_Number, Employee_Last_Name, Employee_First_Name, Last_Update, Status FROM Employee_Profile WHERE Employee_Number <> @EmployeeID AND Status = 'Inactive'"
            ElseIf employeeRole = 3 Then
                query = "SELECT Employee_Number, Employee_First_Name, Employee_Last_Name, Last_Update, Status FROM Employee_Profile WHERE Employee_Role = 1 AND Status = 'Inactive'"
            ElseIf employeeRole = 2 Then
                query = "SELECT Employee_Number, Employee_First_Name, Employee_Last_Name, Last_Update, Status FROM Employee_Profile WHERE Employee_Role = 1 AND Status = 'Inactive'"
            End If

            Dim adapter As New OleDbDataAdapter(query, connection)
            Dim dataTable As New DataTable()

            adapter.SelectCommand.Parameters.AddWithValue("@EmployeeID", EmployeeID)
            adapter.Fill(dataTable)

            EmployeeListDataGrid.DataSource = dataTable

            DataGridFormatting()

            For Each column As DataGridViewColumn In EmployeeListDataGrid.Columns
                If column.HeaderText.Contains("_") Then
                    column.HeaderText = column.HeaderText.Replace("_", " ")
                End If
            Next

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub rdbtnAllEmployees_Click(sender As Object, e As EventArgs) Handles rdbtnAllEmployees.Click
        ReloadDataAndBindGrid()
    End Sub

    Private Sub rdbtnActiveEmployees_Click(sender As Object, e As EventArgs) Handles rdbtnActiveEmployees.Click
        ActiveEmployees()
    End Sub

    Private Sub rdbtnInactiveEmployees_Click(sender As Object, e As EventArgs) Handles rdbtnInactiveEmployees.Click
        InactiveEmployees()
    End Sub
    Private Sub txtSearchEmployeeNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchEmployeeNumber.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
#End Region 'Search Functions
#Region "Importing"
    Private Sub btnImportProfile_Click(sender As Object, e As EventArgs) Handles btnImportProfile.Click
        Try
            Using openFileDialog As New OpenFileDialog
                openFileDialog.Filter = "Excel Files|*.xlsm;*.xlsx|All Files|*.*"
                openFileDialog.Title = "Select Excel File"
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

                If openFileDialog.ShowDialog = DialogResult.OK Then
                    Dim excelFilePath = openFileDialog.FileName

                    If Not File.Exists(excelFilePath) Then
                        MessageBox.Show("The selected file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    Dim fileInfo As New FileInfo(excelFilePath)
                    If IsFileLocked(fileInfo) OrElse Not HasReadWritePermissions(fileInfo) Then
                        MessageBox.Show("The selected file is either opened by another user or you do not have permission to view and write its data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    Dim excelConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={excelFilePath};Extended Properties=Excel 12.0;"

                    Using excelConnection As New OleDbConnection(excelConnectionString)
                        excelConnection.Open()

                        Dim sheetColumns As New Dictionary(Of String, String()) From {
                    {"Employee_Profile$", {"Employee_Number", "Employee_Password", "Employee_First_Name", "Employee_Last_Name", "Employee_Role", "Last_Update", "Status", "Sharepoint_Link"}},
                    {"Job_History$", {"Job_ID", "Employee_Number", "Role_and_Designation", "Client_Name", "Region", "Start_Date", "End_Date", "Reason_for_Change"}},
                    {"Task_Profile$", {"Task_ID", "Employee_Number", "Task_Name", "Category", "POC", "Description"}},
                    {"Software_Tools$", {"Software_ID", "Employee_Number", "Software_or_Tool", "Used_For"}},
                    {"Skills_Interview$", {"Skills_ID", "Employee_Number", "Role_or_Designation", "Date_", "Interviewer", "Assessment_Notes"}},
                    {"Performance_Evaluation$", {"Performance_ID", "Employee_Number", "Evaluation_Type", "Evaluation_Date", "Evaluator", "Evaluation_Notes"}},
                    {"Skills_Triage$", {"Triage_ID", "Employee_Number", "Concern_By", "Start_Date", "Date_Closed", "Details_of_Concern", "Deliberation_Score", "Deliberation_Notes"}},
                    {"Training_History$", {"Training_ID", "Employee_Number", "Topic_or_Module_Title", "Facilitator", "Completion_Date", "Grade"}},
                    {"Certifications_and_Licenses$", {"Certification_ID", "Employee_Number", "Certification_Name", "Chapter", "Provider", "License_Number", "Grant_Date", "Expiry_Date", "Status"}},
                    {"Training_Plan$", {"Plan_ID", "Employee_Number", "Topic_or_Module_Name", "Facilitator", "Target_Date"}},
                    {"Training_Programs$", {"Program_ID", "Employee_Number", "Program_Title", "Start_Date", "Completion_Date", "Deliberation_Score", "Deliberation_Notes"}},
                    {"Webinars_Attended$", {"Webinar_ID", "Employee_Number", "Webinar_Title", "Date_", "CPD_Units"}},
                    {"Client_Feedback$", {"Feedback_ID", "Employee_Number", "Account_Manager", "Client_POC", "Feedback_Date", "Feedback_Summary", "Staff_Performance_Rating"}},
                    {"Self_Assessment$", {"Self_ID", "Employee_Number", "Account_Manager", "Feedback_Date", "Personal_Performance_Rating", "Client_Rating", "TBR_Rating"}},
                    {"Competency_Certification$", {"Competency_ID", "Employee_Number", "Certification_Name", "Grant_Date", "Deliberation_Summary", "Overall_Grade"}}
                }

                        connection.Open()
                        Dim successMessageShown = False

                        For Each kvp In sheetColumns
                            Dim sheetName = kvp.Key
                            Dim columns = kvp.Value

                            Dim selectCommand As New OleDbCommand($"SELECT * FROM [{sheetName}]", excelConnection)
                            Dim excelDataAdapter As New OleDbDataAdapter(selectCommand)
                            Dim excelDataTable As New DataTable
                            excelDataAdapter.Fill(excelDataTable)

                            ' Determine valid columns present in both the Excel sheet and the table
                            Dim availableColumns = excelDataTable.Columns.Cast(Of DataColumn).Select(Function(c) c.ColumnName).ToArray
                            Dim validColumns = columns.Where(Function(col) availableColumns.Contains(col)).ToArray

                            If validColumns.Length = 0 Then Continue For



                            Try
                                For Each row As DataRow In excelDataTable.Rows
                                    If validColumns.All(Function(col) Not IsDBNull(row(col)) AndAlso Not String.IsNullOrEmpty(row(col).ToString)) Then
                                        Dim employeeNumber = row("Employee_Number").ToString.Trim
                                        If Not EmployeeExists(employeeNumber) Then
                                            MessageBox.Show($"Employee number '{employeeNumber}' does not exist.{vbCrLf}Please create an Employee Profile for this TBR ID first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            Continue For
                                        End If
                                        Dim tableName = sheetName.Replace("$", "")

                                        Dim checkDuplicateQuery = $"SELECT COUNT(*) FROM {tableName} WHERE " & String.Join(" AND ", validColumns.Select(Function(col) $"{col} = ?"))



                                        Using checkCommand As New OleDbCommand(checkDuplicateQuery, connection)
                                            ' Add parameters for all the columns in the query
                                            For Each col In validColumns
                                                Dim value = row(col)
                                                checkCommand.Parameters.AddWithValue($"@{col}".Trim, value)
                                            Next



                                            ' Execute the query to check for duplicates
                                            Dim duplicateCount As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())


                                            ' If the row already exists, skip the insertion
                                            If duplicateCount > 0 Then
                                                Continue For
                                            End If
                                        End Using
                                        ' Insert the new record
                                        Dim commandText = $"INSERT INTO {tableName} ({String.Join(", ", validColumns).Trim}) VALUES ({String.Join(", ", validColumns.Select(Function(col) $"?")).Trim})"
                                        Using command As New OleDbCommand(commandText, connection)
                                            For Each col In validColumns
                                                Dim value = row(col)

                                                ' Treat all values as strings
                                                command.Parameters.AddWithValue($"@{col}".Trim, value)
                                            Next

                                            command.ExecuteNonQuery()
                                        End Using
                                        successMessageShown = True
                                    End If
                                Next
                            Catch ex As Exception
                                MessageBox.Show($"An error occurred while importing data from sheet '{sheetName}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                successMessageShown = False
                            Finally

                            End Try
                        Next

                        If successMessageShown Then
                            MessageBox.Show("Data imported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                        connection.Close()
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Private Function EmployeeExists(employeeNumber As String) As Boolean
        Dim exists As Boolean = False
        Dim query As String = "SELECT COUNT(*) FROM Employee_Profile WHERE Employee_Number = ?"
        Using checkCommand As New OleDbCommand(query, connection)
            checkCommand.Parameters.AddWithValue("@Employee_Number", employeeNumber)
            exists = Convert.ToInt32(checkCommand.ExecuteScalar()) > 0
        End Using
        Return exists
    End Function
    Private Function IsFileLocked(fileInfo As FileInfo) As Boolean
        Dim fileStream As FileStream = Nothing
        Try
            fileStream = fileInfo.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None)
        Catch ex As Exception
            Return True
        Finally
            If fileStream IsNot Nothing Then
                fileStream.Close()
            End If
        End Try
        Return False
    End Function

    Private Function HasReadWritePermissions(fileInfo As FileInfo) As Boolean
        Try
            Using fileStream As FileStream = fileInfo.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region 'Import Functions
#Region "User Menu"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles picboxMenu.Click
        If grpEmployeeProfile.Visible = False Then
            grpEmployeeProfile.Visible = True
        Else
            grpEmployeeProfile.Visible = False
        End If
    End Sub

    Private Sub picboxReload_Click(sender As Object, e As EventArgs) Handles picboxReload.Click
        Reload()
    End Sub

    Private Sub lblReload_Click(sender As Object, e As EventArgs) Handles lblReload.Click
        Reload()
    End Sub
#End Region 'Top Right Button
End Class