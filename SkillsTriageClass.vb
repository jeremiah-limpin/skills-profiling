Imports System.Data.OleDb

Public Class SkillsTriageClass
    Dim connection As OleDbConnection = SkillsProfile_Database.GetConnection()
    Private employeeForm As EmployeeF

    Public Sub New(ByVal empForm As EmployeeF)
        employeeForm = empForm
    End Sub

    Public Sub DisplaySkillsTriageDataGrid(employeeNumber As String, ByRef dataGrid As DataGridView)

        connection.Close()

        Try
            connection.Open()

            Dim query As String = "SELECT Triage_ID, Concern_By, Start_Date, Date_Closed, Details_of_Concern, Deliberation_Score, Deliberation_Notes FROM Skills_Triage WHERE Employee_Number = @EmployeeNumber"

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
    Public Sub AddDetailsToDatabase(ByRef SkillsTriageDataGrid As DataGridView, ByRef txtEmployeeNumber As TextBox, ByRef txtConcernBy As TextBox, ByRef dtpckerStartDateT As TextBox, ByRef dtpckerDateClose As TextBox, ByRef txtDetailsOfConcern As TextBox, ByRef txtDeliberationScore As TextBox, ByRef txtDeliberationNotes As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        If String.IsNullOrWhiteSpace(txtConcernBy.Text) Or String.IsNullOrWhiteSpace(txtDetailsOfConcern.Text) Or String.IsNullOrWhiteSpace(txtDeliberationScore.Text) Or String.IsNullOrWhiteSpace(txtDeliberationNotes.Text) Then

            MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            connection.Open()

            Dim insertQuery As String = "INSERT INTO Skills_Triage (Employee_Number, Concern_By, Start_Date, Date_Closed, Details_of_Concern, Deliberation_Score, Deliberation_Notes) VALUES (@Employee_Number, @Concern_By, @Start_Date, @Date_Close, @Details_of_Concern, @Deliberation_Score, @Deliberation_Notes)"

            Dim insertCmd As New OleDbCommand(insertQuery, connection)
            insertCmd.Parameters.AddWithValue("@Employee_Number", txtEmployeeNumber.Text)
            insertCmd.Parameters.AddWithValue("@Concern_By", txtConcernBy.Text)
            insertCmd.Parameters.AddWithValue("@Start_Date", dtpckerStartDateT.Text)
            insertCmd.Parameters.AddWithValue("@Date_Close", dtpckerDateClose.Text)
            insertCmd.Parameters.AddWithValue("@Details_of_Concern", txtDetailsOfConcern.Text)
            insertCmd.Parameters.AddWithValue("@Deliberation_Score", txtDeliberationScore.Text)
            insertCmd.Parameters.AddWithValue("@Deliberation_Notes", txtDeliberationNotes.Text)

            insertCmd.ExecuteNonQuery()

            MessageBox.Show("New record has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            employeeForm.ReloadSkillsTriage()
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
    Public Sub UpdateDetailsInDatabase(ByRef SkillsTriageDataGrid As DataGridView, ByRef txtConcernBy As TextBox, ByRef dtpckerStartDateT As TextBox, ByRef dtpckerDateClose As TextBox, ByRef txtDetailsOfConcern As TextBox, ByRef txtDeliberationScore As TextBox, ByRef txtDeliberationNotes As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        Try
            connection.Open()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                Dim selectedRow As DataGridViewRow = SkillsTriageDataGrid.SelectedRows(0)

                Dim triageID As Integer = CInt(selectedRow.Cells("Triage_ID").Value)
                Dim concernBy As String = txtConcernBy.Text
                Dim startDate As String = dtpckerStartDateT.Text
                Dim dateClose As String = dtpckerDateClose.Text
                Dim detailsOfConcern As String = txtDetailsOfConcern.Text
                Dim deliberationScore As String = txtDeliberationScore.Text
                Dim deliberationNotes As String = txtDeliberationNotes.Text

                Dim updateQuery As String = "UPDATE Skills_Triage SET Concern_By = @Concern_By, Start_Date = @Start_Date, Date_Closed = @Date_Closed, Details_of_Concern = @Details_of_Concern, Deliberation_Score = @Deliberation_Score, Deliberation_Notes = @Deliberation_Notes WHERE Triage_ID = @Triage_ID"

                Dim updateCmd As New OleDbCommand(updateQuery, connection)

                updateCmd.Parameters.AddWithValue("@Concern_By", concernBy)
                updateCmd.Parameters.AddWithValue("@Start_Date", startDate)
                updateCmd.Parameters.AddWithValue("@Date_Closed", dateClose)
                updateCmd.Parameters.AddWithValue("@Details_of_Concern", detailsOfConcern)
                updateCmd.Parameters.AddWithValue("@Deliberation_Score", deliberationScore)
                updateCmd.Parameters.AddWithValue("@Deliberation_Notes", deliberationNotes)
                updateCmd.Parameters.AddWithValue("@Triage_ID", triageID)

                updateCmd.ExecuteNonQuery()

                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                employeeForm.ReloadSkillsTriage()
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
    Public Sub DeleteDetailsFromDatabase(ByRef SkillsTriageDataGrid As DataGridView, ByRef employeeForm As EmployeeF)
        connection.Close()
        Try
            connection.Open()

            If SkillsTriageDataGrid.SelectedRows.Count > 0 Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then
                    Dim selectedRow As DataGridViewRow = SkillsTriageDataGrid.SelectedRows(0)

                    Dim triageID As Integer = CInt(selectedRow.Cells("Triage_ID").Value)

                    Dim deleteQuery As String = "DELETE FROM Skills_Triage WHERE Triage_ID = @Triage_ID"
                    Dim deleteCmd As New OleDbCommand(deleteQuery, connection)
                    deleteCmd.Parameters.AddWithValue("@Triage_ID", triageID)

                    deleteCmd.ExecuteNonQuery()

                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    employeeForm.ReloadSkillsTriage()
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
        employeeForm.txtConcernBy.Clear()
        employeeForm.dtpckerStartDateT.Clear()
        employeeForm.dtpckerDateClose.Clear()
        employeeForm.txtDetailsOfConcern.Clear()
        employeeForm.txtDeliberationScore.Clear()
        employeeForm.txtDeliberationNotes.Clear()
        employeeForm.SkillsTriageDataGrid.ClearSelection()
    End Sub
    Public Sub ShowButtons()
        employeeForm.btnAddT.Visible = False
        employeeForm.btnSaveChangesT.Visible = True
        employeeForm.btnDeleteT.Visible = True
        employeeForm.btnCancelT.Visible = True
    End Sub
    Public Sub HideButtons()
        employeeForm.btnAddT.Visible = True
        employeeForm.btnSaveChangesT.Visible = False
        employeeForm.btnDeleteT.Visible = False
        employeeForm.btnCancelT.Visible = False
    End Sub

End Class
