Imports System.Data.OleDb

Public Class SelfAssessmentClass
    Dim connection As OleDbConnection = SkillsProfile_Database.GetConnection()
    Private employeeForm As EmployeeF

    Public Sub New(ByVal empForm As EmployeeF)
        employeeForm = empForm
    End Sub

    Public Sub DisplaySelfAssessmentDataGrid(employeeNumber As String, ByRef dataGrid As DataGridView)

        connection.Close()

        Try
            connection.Open()

            Dim query As String = "SELECT Self_ID, Account_Manager, Feedback_Date, Personal_Performance_Rating, Client_Rating, TBR_Rating FROM Self_Assessment WHERE Employee_Number = @EmployeeNumber"

            Dim adapter As New OleDbDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            dataGrid.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show($"Error(Self Assessment): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Public Sub AddDetailsToDatabase(ByRef SelfAssessmentDataGrid As DataGridView, ByRef txtEmployeeNumber As TextBox, ByRef txtAccountManagerSA As TextBox, ByRef dtpckerFeedbackDateSA As TextBox, ByRef txtPersonalPerformanceRating As TextBox, ByRef txtClientRating As TextBox, ByRef txtTBRRating As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        If String.IsNullOrWhiteSpace(txtAccountManagerSA.Text) Or String.IsNullOrWhiteSpace(txtPersonalPerformanceRating.Text) Or String.IsNullOrWhiteSpace(txtClientRating.Text) Or String.IsNullOrWhiteSpace(txtTBRRating.Text) Then

            MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            connection.Open()

            Dim insertQuery As String = "INSERT INTO Self_Assessment (Employee_Number, Account_Manager, Feedback_Date, Personal_Performance_Rating, Client_Rating, TBR_Rating) VALUES (@Employee_Number, @Account_Manager, @Feedback_Date, @Personal_Performance_Rating, @Client_Rating, @TBR_Rating)"
            Dim insertCmd As New OleDbCommand(insertQuery, connection)
            insertCmd.Parameters.AddWithValue("@Employee_Number", txtEmployeeNumber.Text)
            insertCmd.Parameters.AddWithValue("@Account_Manager", txtAccountManagerSA.Text)
            insertCmd.Parameters.AddWithValue("@Feedback_Date", dtpckerFeedbackDateSA.Text)
            insertCmd.Parameters.AddWithValue("@Personal_Performance_Rating", txtPersonalPerformanceRating.Text)
            insertCmd.Parameters.AddWithValue("@Client_Rating", txtClientRating.Text)
            insertCmd.Parameters.AddWithValue("@TBR_Rating", txtTBRRating.Text)

            insertCmd.ExecuteNonQuery()

            MessageBox.Show("New record has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            employeeForm.ReloadSelfAssessment()
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
    Public Sub UpdateDetailsInDatabase(ByRef SelfAssessmentDataGrid As DataGridView, ByRef txtAccountManagerSA As TextBox, ByRef dtpckerFeedbackDateSA As TextBox, ByRef txtPersonalPerformanceRating As TextBox, ByRef txtClientRating As TextBox, ByRef txtTBRRating As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        Try
            connection.Open()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                Dim selectedRow As DataGridViewRow = SelfAssessmentDataGrid.SelectedRows(0)

                Dim selfID As Integer = CInt(selectedRow.Cells("Self_ID").Value)
                Dim accountManager As String = txtAccountManagerSA.Text
                Dim feedbackDate As String = dtpckerFeedbackDateSA.Text
                Dim personalPerformanceRating As String = txtPersonalPerformanceRating.Text
                Dim clientRating As String = txtClientRating.Text
                Dim tbrRating As String = txtTBRRating.Text

                Dim updateQuery As String = "UPDATE Self_Assessment SET Account_Manager = @Account_Manager, Feedback_Date = @Feedback_Date, Personal_Performance_Rating = @Personal_Performance_Rating, Client_Rating = @Client_Rating, TBR_Rating = @TBR_Rating WHERE Self_ID = @Self_ID"
                Dim updateCmd As New OleDbCommand(updateQuery, connection)

                updateCmd.Parameters.AddWithValue("@Account_Manager", accountManager)
                updateCmd.Parameters.AddWithValue("@Feedback_Date", feedbackDate)
                updateCmd.Parameters.AddWithValue("@Personal_Performance_Rating", personalPerformanceRating)
                updateCmd.Parameters.AddWithValue("@Client_Rating", clientRating)
                updateCmd.Parameters.AddWithValue("@TBR_Rating", tbrRating)
                updateCmd.Parameters.AddWithValue("@Self_ID", selfID)

                updateCmd.ExecuteNonQuery()

                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                employeeForm.ReloadSelfAssessment()
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

    Public Sub DeleteDetailsFromDatabase(ByRef SelfAssessmentDataGrid As DataGridView, ByRef employeeForm As EmployeeF)
        connection.Close()
        Try
            connection.Open()

            If SelfAssessmentDataGrid.SelectedRows.Count > 0 Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then
                    Dim selectedRow As DataGridViewRow = SelfAssessmentDataGrid.SelectedRows(0)

                    Dim feedbackID As Integer = CInt(selectedRow.Cells("Self_ID").Value)

                    Dim deleteQuery As String = "DELETE FROM Self_Assessment WHERE Self_ID = @Self_ID"
                    Dim deleteCmd As New OleDbCommand(deleteQuery, connection)
                    deleteCmd.Parameters.AddWithValue("@Self_ID", feedbackID)

                    deleteCmd.ExecuteNonQuery()

                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    employeeForm.ReloadSelfAssessment()
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
        employeeForm.txtAccountManagerSA.Clear()
        employeeForm.txtFeedbackDateSA.Clear()
        employeeForm.txtPersonalPerformanceRating.Clear()
        employeeForm.txtClientRating.Clear()
        employeeForm.txtTBRRating.Clear()
        employeeForm.SelfAssessmentDataGrid.ClearSelection()
    End Sub
    Public Sub ShowButtons()
        employeeForm.btnAddSA.Visible = False
        employeeForm.btnSaveChangesSA.Visible = True
        employeeForm.btnDeleteSA.Visible = True
        employeeForm.btnCancelSA.Visible = True

    End Sub
    Public Sub HideButtons()
        employeeForm.btnAddSA.Visible = True
        employeeForm.btnSaveChangesSA.Visible = False
        employeeForm.btnDeleteSA.Visible = False
        employeeForm.btnCancelSA.Visible = False
    End Sub
End Class


