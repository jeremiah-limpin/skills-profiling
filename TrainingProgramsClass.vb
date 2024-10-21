Imports System.Data.OleDb

Public Class TrainingProgramsClass
    Dim connection As OleDbConnection = SkillsProfile_Database.GetConnection()
    Private employeeForm As EmployeeF

    Public Sub New(ByVal empForm As EmployeeF)
        employeeForm = empForm
    End Sub
    Public Sub DisplayTrainingProgramsDataGrid(employeeNumber As String, ByRef dataGrid As DataGridView)

        connection.Close()

        Try
            connection.Open()

            Dim query As String = "SELECT Program_ID, Program_Title, Start_Date, Completion_Date, Deliberation_Score, Deliberation_Notes FROM Training_Programs WHERE Employee_Number = @EmployeeNumber"

            Dim adapter As New OleDbDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            dataGrid.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show($"Error(Training Programs): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Public Sub AddDetailsToDatabase(ByRef TrainingProgramsDataGrid As DataGridView, ByRef txtEmployeeNumber As TextBox, ByRef txtProgramTitle As TextBox, ByRef dtpckerStartDateTPr As TextBox, ByRef dtpckerCompletionDate As TextBox, ByRef txtDeliberationScoreTPr As TextBox, ByRef txtDeliberationNotesTPr As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        If String.IsNullOrWhiteSpace(txtProgramTitle.Text) Or String.IsNullOrWhiteSpace(txtDeliberationScoreTPr.Text) Or String.IsNullOrWhiteSpace(txtDeliberationNotesTPr.Text) Then

            MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            connection.Open()

            Dim insertQuery As String = "INSERT INTO Training_Programs (Employee_Number, Program_Title, Start_Date, Completion_Date, Deliberation_Score, Deliberation_Notes) VALUES (@Employee_Number, @Program_Title, @Start_Date, @Completion_Date, @Deliberation_Score, @Deliberation_Notes)"

            Dim insertCmd As New OleDbCommand(insertQuery, connection)
            insertCmd.Parameters.AddWithValue("@Employee_Number", txtEmployeeNumber.Text)
            insertCmd.Parameters.AddWithValue("@Program_Title", txtProgramTitle.Text)
            insertCmd.Parameters.AddWithValue("@Start_Date", dtpckerStartDateTPr.Text)
            insertCmd.Parameters.AddWithValue("@Completion_Date", dtpckerCompletionDate.Text)
            insertCmd.Parameters.AddWithValue("@Deliberation_Score", txtDeliberationScoreTPr.Text)
            insertCmd.Parameters.AddWithValue("@Deliberation_Notes", txtDeliberationNotesTPr.Text)

            insertCmd.ExecuteNonQuery()

            MessageBox.Show("New record has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            employeeForm.ReloadTrainingPrograms()
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
    Public Sub UpdateDetailsInDatabase(ByRef TrainingProgramsDataGrid As DataGridView, ByRef txtProgramTitle As TextBox, ByRef dtpckerStartDateTPr As TextBox, ByRef dtpckerCompletionDate As TextBox, ByRef txtDeliberationScoreTPr As TextBox, ByRef txtDeliberationNotesTPr As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        Try
            connection.Open()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                Dim selectedRow As DataGridViewRow = TrainingProgramsDataGrid.SelectedRows(0)

                Dim trainingID As Integer = CInt(selectedRow.Cells("Program_ID").Value)
                Dim programTitle As String = txtProgramTitle.Text
                Dim startDate As String = dtpckerStartDateTPr.Text
                Dim completionDate As String = dtpckerCompletionDate.Text
                Dim deliberationScore As String = txtDeliberationScoreTPr.Text
                Dim deliberationNotes As String = txtDeliberationNotesTPr.Text

                Dim updateQuery As String = "UPDATE Training_Programs SET Program_Title = @Program_Title, Start_Date = @Start_Date, Completion_Date = @Completion_Date, Deliberation_Score = @Deliberation_Score, Deliberation_Notes = @Deliberation_Notes WHERE Program_ID = @Program_ID"
                Dim updateCmd As New OleDbCommand(updateQuery, connection)

                updateCmd.Parameters.AddWithValue("@Program_Title", programTitle)
                updateCmd.Parameters.AddWithValue("@Start_Date", startDate)
                updateCmd.Parameters.AddWithValue("@Completion_Date", completionDate)
                updateCmd.Parameters.AddWithValue("@Deliberation_Score", deliberationScore)
                updateCmd.Parameters.AddWithValue("@Deliberation_Notes", deliberationNotes)
                updateCmd.Parameters.AddWithValue("@Program_ID", trainingID)

                updateCmd.ExecuteNonQuery()

                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                employeeForm.ReloadTrainingPrograms()
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

    Public Sub DeleteDetailsFromDatabase(ByRef TrainingProgramsDataGrid As DataGridView, ByRef employeeForm As EmployeeF)
        connection.Close()
        Try
            connection.Open()

            If TrainingProgramsDataGrid.SelectedRows.Count > 0 Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then
                    Dim selectedRow As DataGridViewRow = TrainingProgramsDataGrid.SelectedRows(0)

                    Dim jobID As Integer = CInt(selectedRow.Cells("Program_ID").Value)

                    Dim deleteQuery As String = "DELETE FROM Training_Programs WHERE Program_ID = @Program_ID"
                    Dim deleteCmd As New OleDbCommand(deleteQuery, connection)
                    deleteCmd.Parameters.AddWithValue("@Program_ID", jobID)

                    deleteCmd.ExecuteNonQuery()

                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    employeeForm.ReloadTrainingPrograms()
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
        employeeForm.txtProgramTitle.Clear()
        employeeForm.txtStartDateTPr.Clear()
        employeeForm.txtCompletionDateTPr.Clear()
        employeeForm.txtDeliberationScoreTPr.Clear()
        employeeForm.txtDeliberationNotesTPr.Clear()
        employeeForm.TrainingProgramsDataGrid.ClearSelection()
    End Sub
    Public Sub ShowButtons()
        employeeForm.btnAddTPr.Visible = False
        employeeForm.btnSaveChangesTPr.Visible = True
        employeeForm.btnDeleteTPr.Visible = True
        employeeForm.btnCancelTPr.Visible = True
    End Sub
    Public Sub HideButtons()
        employeeForm.btnAddTPr.Visible = True
        employeeForm.btnSaveChangesTPr.Visible = False
        employeeForm.btnDeleteTPr.Visible = False
        employeeForm.btnCancelTPr.Visible = False
    End Sub
End Class
