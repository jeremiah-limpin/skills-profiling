Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class TrainingPlanClass
    Dim connection As OleDbConnection = SkillsProfile_Database.GetConnection()
    Private employeeForm As EmployeeF

    Public Sub New(ByVal empForm As EmployeeF)
        employeeForm = empForm
    End Sub

    Public Sub DisplayTrainingPlanDataGrid(employeeNumber As String, ByRef dataGrid As DataGridView)

        connection.Close()

        Try
            connection.Open()

            Dim query As String = "SELECT Plan_ID, Topic_or_Module_Name, Facilitator, Target_Date FROM Training_Plan WHERE Employee_Number = @EmployeeNumber"

            Dim adapter As New OleDbDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            dataGrid.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show($"Error(Trainin Plan): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Public Sub AddDetailsToDatabase(ByRef TrainingPlanDataGrid As DataGridView, ByRef txtEmployeeNumber As TextBox, ByRef txtTopicOrModuleName As TextBox, ByRef txtFacilitatorP As TextBox, ByRef dtpckerTargetDate As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()
        If String.IsNullOrWhiteSpace(txtTopicOrModuleName.Text) Or String.IsNullOrWhiteSpace(txtFacilitatorP.Text) Then

            MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            connection.Open()

            Dim insertQuery As String = "INSERT INTO Training_Plan (Employee_Number, Topic_or_Module_Name, Facilitator, Target_Date) VALUES (@Employee_Number, @Topic_or_Module_Name, @Facilitator, @Target_Date)"
            Dim insertCmd As New OleDbCommand(insertQuery, connection)
            insertCmd.Parameters.AddWithValue("@Employee_Number", txtEmployeeNumber.Text)
            insertCmd.Parameters.AddWithValue("@Topic_or_Module_Name", txtTopicOrModuleName.Text)
            insertCmd.Parameters.AddWithValue("@Facilitator", txtFacilitatorP.Text)
            insertCmd.Parameters.AddWithValue("@Target_Date", dtpckerTargetDate.Text)
            insertCmd.ExecuteNonQuery()

            MessageBox.Show("New record has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            employeeForm.ReloadTrainingPlan()
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
    Public Sub UpdateDetailsInDatabase(ByRef TrainingPlanDataGrid As DataGridView, ByRef txtTopicOrModuleName As TextBox, ByRef txtFacilitatorP As TextBox, ByRef dtpckerTargetDate As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        Try
            connection.Open()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                Dim selectedRow As DataGridViewRow = TrainingPlanDataGrid.SelectedRows(0)

                Dim planID As Integer = CInt(selectedRow.Cells("Plan_ID").Value)
                Dim topicOrModuleName As String = txtTopicOrModuleName.Text
                Dim facilitator As String = txtFacilitatorP.Text
                Dim targetDate As String = dtpckerTargetDate.Text

                Dim updateQuery As String = "UPDATE Training_Plan SET Topic_or_Module_Name = @Topic_or_Module_Name, Facilitator = @Facilitator, Target_Date = @Target_Date WHERE Plan_ID = @Plan_ID"
                Dim updateCmd As New OleDbCommand(updateQuery, connection)

                updateCmd.Parameters.AddWithValue("@Topic_or_Module_Name", topicOrModuleName)
                updateCmd.Parameters.AddWithValue("@Facilitator", facilitator)
                updateCmd.Parameters.AddWithValue("@Target_Date", targetDate)
                updateCmd.Parameters.AddWithValue("@Plan_ID", planID)

                updateCmd.ExecuteNonQuery()

                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                employeeForm.ReloadTrainingPlan()
                employeeForm.LastUpdate()
                HideButtons()
                ClearFields()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Public Sub DeleteDetailsFromDatabase(ByRef TrainingPlanDataGrid As DataGridView, ByRef employeeForm As EmployeeF)
        connection.Close()
        Try
            connection.Open()

            If TrainingPlanDataGrid.SelectedRows.Count > 0 Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then
                    Dim selectedRow As DataGridViewRow = TrainingPlanDataGrid.SelectedRows(0)

                    Dim skillsID As Integer = CInt(selectedRow.Cells("Plan_ID").Value)

                    Dim deleteQuery As String = "DELETE FROM Training_PLan WHERE Plan_ID = @Plan_ID"
                    Dim deleteCmd As New OleDbCommand(deleteQuery, connection)
                    deleteCmd.Parameters.AddWithValue("@Plan_ID", skillsID)

                    deleteCmd.ExecuteNonQuery()

                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    employeeForm.ReloadTrainingPlan()
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
        employeeForm.txtTopicOrModuleName.Clear()
        employeeForm.txtFacilitatorP.Clear()
        employeeForm.txtTargetDate.Clear()
        employeeForm.TrainingPlanDataGrid.ClearSelection()
    End Sub
    Public Sub ShowButtons()
        employeeForm.btnAddP.Visible = False
        employeeForm.btnSaveChangesP.Visible = True
        employeeForm.btnDeleteP.Visible = True
        employeeForm.btnCancelP.Visible = True
    End Sub
    Public Sub HideButtons()
        employeeForm.btnAddP.Visible = True
        employeeForm.btnSaveChangesP.Visible = False
        employeeForm.btnDeleteP.Visible = False
        employeeForm.btnCancelP.Visible = False
    End Sub
End Class
