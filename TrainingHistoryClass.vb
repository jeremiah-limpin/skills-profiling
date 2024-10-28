Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class TrainingHistoryClass
    Dim connection As OleDbConnection = SkillsProfile_Database.GetConnection()
    Private employeeForm As EmployeeF

    Public Sub New(ByVal empForm As EmployeeF)
        employeeForm = empForm
    End Sub

    Public Sub DisplayTrainingHistoryDataGrid(employeeNumber As String, ByRef dataGrid As DataGridView)

        connection.Close()

        Try
            connection.Open()

            Dim query As String = "SELECT Training_ID, Topic_or_Module_Title, Facilitator, Completion_Date, Grade FROM Training_History WHERE Employee_Number = @EmployeeNumber ORDER BY Completion_Date DESC"

            Dim adapter As New OleDbDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            dataGrid.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show($"Error(Training History): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Public Sub AddDetailsToDatabase(ByRef TrainingHistoryDataGrid As DataGridView, ByRef txtEmployeeNumber As TextBox, ByRef txtTopicOrModuleTitle As TextBox, ByRef txtFacilitator As TextBox, ByRef dtpckerCompletionDate As TextBox, ByRef txtGrade As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        If String.IsNullOrWhiteSpace(txtTopicOrModuleTitle.Text) Or String.IsNullOrWhiteSpace(txtFacilitator.Text) Or String.IsNullOrWhiteSpace(txtGrade.Text) Then

            MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            connection.Open()

            Dim insertQuery As String = "INSERT INTO Training_History (Employee_Number, Topic_or_Module_Title, Facilitator, Completion_Date, Grade) VALUES (@Employee_Number, @Topic_or_Module_Title, @Facilitator, @Completion_Date, @Grade)"

            Dim insertCmd As New OleDbCommand(insertQuery, connection)
            insertCmd.Parameters.AddWithValue("@Employee_Number", txtEmployeeNumber.Text)
            insertCmd.Parameters.AddWithValue("@Topic_or_Module_Title", txtTopicOrModuleTitle.Text)
            insertCmd.Parameters.AddWithValue("@Facilitator", txtFacilitator.Text)
            insertCmd.Parameters.AddWithValue("@Completion_Date", dtpckerCompletionDate.Text)

            insertCmd.Parameters.AddWithValue("@Grade", txtGrade.Text)

            insertCmd.ExecuteNonQuery()

            MessageBox.Show("New record has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            employeeForm.ReloadTrainingHistory()
            employeeForm.LastUpdate()
            HideButtons()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Public Sub UpdateDetailsInDatabase(ByRef TrainingHistoryDataGrid As DataGridView, ByRef txtTopicOrModuleTitle As TextBox, ByRef txtFacilitator As TextBox, ByRef dtpckerCompletionDate As TextBox, ByRef txtGrade As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        Try
            connection.Open()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                Dim selectedRow As DataGridViewRow = TrainingHistoryDataGrid.SelectedRows(0)

                Dim trainingID As Integer = CInt(selectedRow.Cells("Training_ID").Value)
                Dim topicOrModuleTitle As String = txtTopicOrModuleTitle.Text
                Dim facilitator As String = txtFacilitator.Text
                Dim completionDate As String = dtpckerCompletionDate.Text
                Dim grade As String = txtGrade.Text

                Dim updateQuery As String = "UPDATE Training_History SET Topic_or_Module_Title = @Topic_or_Module_Title, Facilitator = @Facilitator, Completion_Date = @Completion_Date, Grade = @Grade WHERE Training_ID = @Training_ID"

                Dim updateCmd As New OleDbCommand(updateQuery, connection)

                updateCmd.Parameters.AddWithValue("@Topic_or_Module_Title", topicOrModuleTitle)
                updateCmd.Parameters.AddWithValue("@Facilitator", facilitator)
                updateCmd.Parameters.AddWithValue("@Completion_Date", completionDate)
                updateCmd.Parameters.AddWithValue("@Grade", grade)
                updateCmd.Parameters.AddWithValue("@Training_ID", trainingID)

                updateCmd.ExecuteNonQuery()

                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                employeeForm.ReloadTrainingHistory()
                employeeForm.LastUpdate()
                HideButtons()
                ClearFields()

            End If
        Catch ex As Exception
            MessageBox.Show($"Error(Update) : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Public Sub DeleteDetailsFromDatabase(ByRef TrainingHistoryDataGrid As DataGridView, ByRef employeeForm As EmployeeF)
        connection.Close()
        Try
            connection.Open()

            If TrainingHistoryDataGrid.SelectedRows.Count > 0 Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then
                    Dim selectedRow As DataGridViewRow = TrainingHistoryDataGrid.SelectedRows(0)

                    Dim triageID As Integer = CInt(selectedRow.Cells("Training_ID").Value)

                    Dim deleteQuery As String = "DELETE FROM Training_History WHERE Training_ID = @Training_ID"
                    Dim deleteCmd As New OleDbCommand(deleteQuery, connection)
                    deleteCmd.Parameters.AddWithValue("@Training_ID", triageID)

                    deleteCmd.ExecuteNonQuery()

                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    employeeForm.ReloadTrainingHistory()
                    employeeForm.LastUpdate()
                    HideButtons()
                    ClearFields()

                End If
            Else
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show($"Error(DataGridLoad): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Public Sub ClearFields()
        employeeForm.txtTopicOrModuleTitle.Clear()
        employeeForm.dtpckerCompletion.Clear()
        employeeForm.txtFacilitator.Clear()
        employeeForm.txtGrade.Clear()
        employeeForm.txtFacilitator.Text = "Moodle"
        employeeForm.TrainingHistoryDataGrid.ClearSelection()
    End Sub
    Public Sub ShowButtons()
        employeeForm.btnAddTH.Visible = False
        employeeForm.btnSaveChangesTH.Visible = True
        employeeForm.btnDeleteTH.Visible = True
        employeeForm.btnCancelTH.Visible = True
    End Sub
    Public Sub HideButtons()
        employeeForm.btnAddTH.Visible = True
        employeeForm.btnSaveChangesTH.Visible = False
        employeeForm.btnDeleteTH.Visible = False
        employeeForm.btnCancelTH.Visible = False
    End Sub

End Class
