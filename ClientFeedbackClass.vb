Imports System.Data.OleDb

Public Class ClientFeedbackClass
    Dim connection As OleDbConnection = SkillsProfile_Database.GetConnection()
    Private employeeForm As EmployeeF

    Public Sub New(ByVal empForm As EmployeeF)
        employeeForm = empForm
    End Sub

    Public Sub DisplayClientFeedbackDataGrid(employeeNumber As String, ByRef dataGrid As DataGridView)

        connection.Close()

        Try
            connection.Open()

            Dim query As String = "SELECT Feedback_ID, Account_Manager, Client_POC, Feedback_Date, Feedback_Summary, Staff_Performance_Rating FROM Client_Feedback WHERE Employee_Number = @EmployeeNumber"

            Dim adapter As New OleDbDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            dataGrid.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show($"Error(Client Feedback): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Public Sub AddDetailsToDatabase(ByRef ClientFeedbackDataGrid As DataGridView, ByRef txtEmployeeNumber As TextBox, ByRef txtAccountManager As TextBox, ByRef txtClientPOC As TextBox, ByRef txtFeedbackDate As TextBox, ByRef txtFeedbackSummary As TextBox, ByRef txtStaffPerformanceRating As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        If String.IsNullOrWhiteSpace(txtAccountManager.Text) Or String.IsNullOrWhiteSpace(txtClientPOC.Text) Or String.IsNullOrWhiteSpace(txtFeedbackDate.Text) Or String.IsNullOrWhiteSpace(txtFeedbackSummary.Text) Or String.IsNullOrWhiteSpace(txtStaffPerformanceRating.Text) Then

            MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            connection.Open()

            Dim insertQuery As String = "INSERT INTO Client_Feedback (Employee_Number, Account_Manager, Client_POC, Feedback_Date, Feedback_Summary, Staff_Performance_Rating) VALUES (@Employee_Number, @Account_Manager, @Client_POC, @Feedback_Date, @Feedback_Summary, @Staff_Performance_Rating)"
            Dim insertCmd As New OleDbCommand(insertQuery, connection)
            insertCmd.Parameters.AddWithValue("@Employee_Number", txtEmployeeNumber.Text)
            insertCmd.Parameters.AddWithValue("@Account_Manager", txtAccountManager.Text)
            insertCmd.Parameters.AddWithValue("@Client_POC", txtClientPOC.Text)
            insertCmd.Parameters.AddWithValue("@Feedback_Date", txtFeedbackDate.Text)
            insertCmd.Parameters.AddWithValue("@Feedback_Summary", txtFeedbackSummary.Text)
            insertCmd.Parameters.AddWithValue("@Staff_Performance_Rating", txtStaffPerformanceRating.Text)

            insertCmd.ExecuteNonQuery()

            MessageBox.Show("New record has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            employeeForm.ReloadClientFeedback()
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
    Public Sub UpdateDetailsInDatabase(ByRef ClientFeedbackDataGrid As DataGridView, ByRef txtAccountManager As TextBox, ByRef txtClientPOC As TextBox, ByRef txtFeedbackDate As TextBox, ByRef txtFeedbackSummary As TextBox, ByRef txtStaffPerformanceRating As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        Try
            connection.Open()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                Dim selectedRow As DataGridViewRow = ClientFeedbackDataGrid.SelectedRows(0)

                Dim feedbackID As Integer = CInt(selectedRow.Cells("Feedback_ID").Value)
                Dim accountManager As String = txtAccountManager.Text
                Dim clientPOC As String = txtClientPOC.Text
                Dim feedbackDate As String = txtFeedbackDate.Text
                Dim feedbackSummary As String = txtFeedbackSummary.Text
                Dim staffPerformanceRating As String = txtStaffPerformanceRating.Text

                Dim updateQuery As String = "UPDATE Client_Feedback SET Account_Manager = @Account_Manager, Client_POC = @Client_POC, Feedback_Date = @Feedback_Date, Feedback_Summary = @Feedback_Summary, Staff_Performance_Rating = @Staff_Performance_Rating WHERE Job_ID = @Job_ID"
                Dim updateCmd As New OleDbCommand(updateQuery, connection)

                updateCmd.Parameters.AddWithValue("@Account_Manager", accountManager)
                updateCmd.Parameters.AddWithValue("@Client_POC", clientPOC)
                updateCmd.Parameters.AddWithValue("@Feedback_Date", feedbackDate)
                updateCmd.Parameters.AddWithValue("@Feedback_Summary", feedbackSummary)
                updateCmd.Parameters.AddWithValue("@Staff_Performance_Rating", staffPerformanceRating)
                updateCmd.Parameters.AddWithValue("@Feedback_ID", feedbackID)

                updateCmd.ExecuteNonQuery()

                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                employeeForm.ReloadClientFeedback()
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

    Public Sub DeleteDetailsFromDatabase(ByRef ClientFeedbackDataGrid As DataGridView, ByRef employeeForm As EmployeeF)
        connection.Close()
        Try
            connection.Open()

            If ClientFeedbackDataGrid.SelectedRows.Count > 0 Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then
                    Dim selectedRow As DataGridViewRow = ClientFeedbackDataGrid.SelectedRows(0)

                    Dim feedbackID As Integer = CInt(selectedRow.Cells("Feedback_ID").Value)

                    Dim deleteQuery As String = "DELETE FROM Client_Feedback WHERE Feedback_ID = @Feedback_ID"
                    Dim deleteCmd As New OleDbCommand(deleteQuery, connection)
                    deleteCmd.Parameters.AddWithValue("@Feedback_ID", feedbackID)

                    deleteCmd.ExecuteNonQuery()

                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    employeeForm.ReloadClientFeedback()
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
        employeeForm.txtAccountManager.Clear()
        employeeForm.txtClientPOC.Clear()
        employeeForm.txtPOC.Clear()
        employeeForm.txtFeedbackDate.Clear()
        employeeForm.txtFeedbackSummary.Clear()
        employeeForm.txtStaffPerformanceRating.Clear()
        employeeForm.ClientFeedbackDataGrid.ClearSelection()
    End Sub
    Public Sub ShowButtons()
        employeeForm.btnAddCF.Visible = False
        employeeForm.btnSaveChangesCF.Visible = True
        employeeForm.btnDeleteCF.Visible = True
        employeeForm.btnCancelCF.Visible = True

    End Sub
    Public Sub HideButtons()
        employeeForm.btnAddCF.Visible = True
        employeeForm.btnSaveChangesCF.Visible = False
        employeeForm.btnDeleteCF.Visible = False
        employeeForm.btnCancelCF.Visible = False
    End Sub
End Class

