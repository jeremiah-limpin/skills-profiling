Imports System.Data.OleDb

Public Class SkillsInterviewClass
    Dim connection As OleDbConnection = SkillsProfile_Database.GetConnection()
    Private employeeForm As EmployeeF

    Public Sub New(ByVal empForm As EmployeeF)
        employeeForm = empForm
    End Sub

    Public Sub DisplaySkillsInterviewDataGrid(employeeNumber As String, ByRef dataGrid As DataGridView)

        connection.Close()

        Try
            connection.Open()

            Dim query As String = "SELECT Skills_ID, Role_or_Designation, Date_, Interviewer, Assessment_Notes FROM Skills_Interview WHERE Employee_Number = @EmployeeNumber"

            Dim adapter As New OleDbDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            dataGrid.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show($"Error(Skills Interview): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Public Sub AddDetailsToDatabase(ByRef SkillsInterviewDataGrid As DataGridView, ByRef txtEmployeeNumber As TextBox, ByRef txtRoleOrDesignation As TextBox, ByRef dtpckerDate As TextBox, ByRef txtInterviewer As TextBox, ByRef txtAssessmentNotes As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()
        If String.IsNullOrWhiteSpace(txtRoleOrDesignation.Text) Or String.IsNullOrWhiteSpace(dtpckerDate.Text) Or String.IsNullOrWhiteSpace(txtInterviewer.Text) Or String.IsNullOrWhiteSpace(txtAssessmentNotes.Text) Then

            MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            connection.Open()

            Dim insertQuery As String = "INSERT INTO Skills_Interview (Employee_Number, Role_or_Designation, Date_, Interviewer, Assessment_Notes) VALUES (@Employee_Number, @Role_or_Designation, @Date_, @Interviewer, @Assessment_Notes)"
            Dim insertCmd As New OleDbCommand(insertQuery, connection)
            insertCmd.Parameters.AddWithValue("@Employee_Number", txtEmployeeNumber.Text)
            insertCmd.Parameters.AddWithValue("@Role_or_Designation", txtRoleOrDesignation.Text)
            insertCmd.Parameters.AddWithValue("@Date_", dtpckerDate.Text)
            insertCmd.Parameters.AddWithValue("@Interviewer", txtInterviewer.Text)
            insertCmd.Parameters.AddWithValue("@Assessment_Notes", txtAssessmentNotes.Text)

            insertCmd.ExecuteNonQuery()

            MessageBox.Show("New record has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            employeeForm.ReloadSkillsInterview()
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
    Public Sub UpdateDetailsInDatabase(ByRef SkillsInterviewDataGrid As DataGridView, ByRef txtRoleOrDesignation As TextBox, ByRef dtpckerDate As TextBox, ByRef txtInterviewer As TextBox, ByRef txtAssessmentNotes As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        Try
            connection.Open()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                Dim selectedRow As DataGridViewRow = SkillsInterviewDataGrid.SelectedRows(0)

                Dim skillsID As Integer = CInt(selectedRow.Cells("Skills_ID").Value)
                Dim roleOrDesignation As String = txtRoleOrDesignation.Text
                Dim date_ As String = dtpckerDate.Text
                Dim interviewer As String = txtInterviewer.Text
                Dim assessmentNotes As String = txtAssessmentNotes.Text

                Dim updateQuery As String = "UPDATE Skills_Interview SET Role_or_Designation = @Role_or_Designation, Date_ = @Date_, Interviewer = @Interviewer, Assessment_Notes = @Assessment_Notes WHERE Skills_ID = @Skills_ID"
                Dim updateCmd As New OleDbCommand(updateQuery, connection)

                updateCmd.Parameters.AddWithValue("@Role_or_Designation", roleOrDesignation)
                updateCmd.Parameters.AddWithValue("@Date_", date_)
                updateCmd.Parameters.AddWithValue("@Interviewer", interviewer)
                updateCmd.Parameters.AddWithValue("@Assessment_Notes", assessmentNotes)
                updateCmd.Parameters.AddWithValue("@Skills_ID", skillsID)

                updateCmd.ExecuteNonQuery()

                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                employeeForm.ReloadSkillsInterview()
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

    Public Sub DeleteDetailsFromDatabase(ByRef SkillsInterviewDataGrid As DataGridView, ByRef employeeForm As EmployeeF)
        connection.Close()
        Try
            connection.Open()

            If SkillsInterviewDataGrid.SelectedRows.Count > 0 Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then
                    Dim selectedRow As DataGridViewRow = SkillsInterviewDataGrid.SelectedRows(0)

                    Dim skillsID As Integer = CInt(selectedRow.Cells("Skills_ID").Value)

                    Dim deleteQuery As String = "DELETE FROM Skills_Interview WHERE Skills_ID = @Skills_ID"
                    Dim deleteCmd As New OleDbCommand(deleteQuery, connection)
                    deleteCmd.Parameters.AddWithValue("@Skills_ID", skillsID)

                    deleteCmd.ExecuteNonQuery()

                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    employeeForm.ReloadSkillsInterview()
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
    Public Sub ShowButtons()
        employeeForm.btnAddSI.Visible = False
        employeeForm.btnSaveChangesSI.Visible = True
        employeeForm.btnDeleteSI.Visible = True
        employeeForm.btnCancelSI.Visible = True
    End Sub
    Public Sub HideButtons()
        employeeForm.btnAddSI.Visible = True
        employeeForm.btnSaveChangesSI.Visible = False
        employeeForm.btnDeleteSI.Visible = False
        employeeForm.btnCancelSI.Visible = False
    End Sub
    Public Sub ClearFields()
        employeeForm.txtRoleOrDesignation.Clear()
        employeeForm.txtInterviewer.Clear()
        employeeForm.dtpckerDate.Clear()
        employeeForm.txtAssessmentNotes.Clear()
        employeeForm.SkillsInterviewDataGrid.ClearSelection()
    End Sub

End Class
