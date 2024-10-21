Imports System.Data.OleDb

Public Class JobHistoryClass
    Dim connection As OleDbConnection = SkillsProfile_Database.GetConnection()
    Private employeeForm As EmployeeF

    Public Sub New(ByVal empForm As EmployeeF)
        employeeForm = empForm
    End Sub
    Public Sub DisplayJobHistoryDataGrid(employeeNumber As String, ByRef dataGrid As DataGridView)

        connection.Close()

        Try
            connection.Open()

            Dim query As String = "SELECT Role_and_Designation, Client_Name, Region, Start_Date, End_Date, Reason_for_Change FROM Job_History WHERE Employee_Number = @EmployeeNumber"

            Dim adapter As New OleDbDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            dataGrid.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show($"Error(Job History): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Public Sub AddDetailsToDatabase(ByRef JobHistoryDataGrid As DataGridView, ByRef txtEmployeeNumber As TextBox, ByRef txtRoleDesignation As TextBox, ByRef txtClientName As TextBox, ByRef txtRegion As TextBox, ByRef dtpckerStartDate As TextBox, ByRef dtpckerEndDate As TextBox, ByRef txtReasonForChange As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()
        If String.IsNullOrWhiteSpace(txtRoleDesignation.Text) Or
            String.IsNullOrWhiteSpace(txtClientName.Text) Or
            String.IsNullOrWhiteSpace(txtRegion.Text) Or
            String.IsNullOrWhiteSpace(dtpckerStartDate.Text) Or
            String.IsNullOrWhiteSpace(dtpckerEndDate.Text) Then

            MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            connection.Open()

            Dim insertQuery As String = "INSERT INTO Job_History (Employee_Number, Role_And_Designation, Client_Name, Region, Start_Date, End_Date, Reason_for_Change) VALUES (@Employee_Number, @Role_And_Designation, @Client_Name, @Region, @Start_Date, @End_Date, @Reason_for_Change)"
            Dim insertCmd As New OleDbCommand(insertQuery, connection)
            insertCmd.Parameters.AddWithValue("@Employee_Number", txtEmployeeNumber.Text)
            insertCmd.Parameters.AddWithValue("@Role_And_Designation", txtRoleDesignation.Text)
            insertCmd.Parameters.AddWithValue("@Client_Name", txtClientName.Text)
            insertCmd.Parameters.AddWithValue("@Region", txtRegion.Text)
            insertCmd.Parameters.AddWithValue("@Start_Date", dtpckerStartDate.Text)
            insertCmd.Parameters.AddWithValue("@End_Date", dtpckerEndDate.Text)
            insertCmd.Parameters.AddWithValue("@Reason_for_Change", txtReasonForChange.Text)

            insertCmd.ExecuteNonQuery()

            MessageBox.Show("New record has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            employeeForm.ReloadJobHistory()
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
    Public Sub UpdateDetailsInDatabase(ByRef JobHistoryDataGrid As DataGridView, ByRef txtRoleDesignation As TextBox, ByRef txtClientName As TextBox, ByRef txtRegion As TextBox, ByRef dtpckerStartDate As TextBox, ByRef dtpckerEndDate As TextBox, ByRef txtReasonForChange As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        Try
            connection.Open()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                Dim selectedRow As DataGridViewRow = JobHistoryDataGrid.SelectedRows(0)

                Dim jobID As Integer = CInt(selectedRow.Cells("Job_ID").Value)
                Dim roleDesignation As String = txtRoleDesignation.Text
                Dim clientName As String = txtClientName.Text
                Dim region As String = txtRegion.Text
                Dim startDate As String = dtpckerStartDate.Text
                Dim endDate As String = dtpckerEndDate.Text
                Dim reasonForChange As String = txtReasonForChange.Text

                Dim updateQuery As String = "UPDATE Job_History SET Role_And_Designation = @Role_And_Designation, Client_Name = @Client_Name, Region = @Region, Start_Date = @Start_Date, End_Date = @End_Date, Reason_for_Change = @Reason_for_Change WHERE Job_ID = @Job_ID"
                Dim updateCmd As New OleDbCommand(updateQuery, connection)

                updateCmd.Parameters.AddWithValue("@Role_And_Designation", roleDesignation)
                updateCmd.Parameters.AddWithValue("@Client_Name", clientName)
                updateCmd.Parameters.AddWithValue("@Region", region)
                updateCmd.Parameters.AddWithValue("@Start_Date", startDate)
                updateCmd.Parameters.AddWithValue("@End_Date", endDate)
                updateCmd.Parameters.AddWithValue("@Reason_for_Change", reasonForChange)
                updateCmd.Parameters.AddWithValue("@Job_ID", jobID)

                updateCmd.ExecuteNonQuery()

                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                employeeForm.ReloadJobHistory()
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

    Public Sub DeleteDetailsFromDatabase(ByRef JobHistoryDataGrid As DataGridView, ByRef employeeForm As EmployeeF)
        connection.Close()
        Try
            connection.Open()

            If JobHistoryDataGrid.SelectedRows.Count > 0 Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then
                    Dim selectedRow As DataGridViewRow = JobHistoryDataGrid.SelectedRows(0)

                    Dim jobID As Integer = CInt(selectedRow.Cells("Job_ID").Value)

                    Dim deleteQuery As String = "DELETE FROM Job_History WHERE Job_ID = @Job_ID"
                    Dim deleteCmd As New OleDbCommand(deleteQuery, connection)
                    deleteCmd.Parameters.AddWithValue("@Job_ID", jobID)

                    deleteCmd.ExecuteNonQuery()

                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    employeeForm.ReloadJobHistory()
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
            ' Close the connection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Public Sub ClearFields()
        employeeForm.txtRoleDesignation.Clear()
        employeeForm.txtClientName.Clear()
        employeeForm.txtRegion.Clear()
        employeeForm.txtStartDateJ.Clear()
        employeeForm.txtEndDateJ.Clear()
        employeeForm.txtReasonForChange.Clear()
        employeeForm.JobHistoryDataGrid.ClearSelection()
    End Sub
    Public Sub ShowButtons()
        employeeForm.btnAdd.Visible = False
        employeeForm.btnSaveChanges.Visible = True
        employeeForm.btnDelete.Visible = True
        employeeForm.btnCancel.Visible = True
    End Sub
    Public Sub HideButtons()
        employeeForm.btnAdd.Visible = True
        employeeForm.btnSaveChanges.Visible = False
        employeeForm.btnDelete.Visible = False
        employeeForm.btnCancel.Visible = False
    End Sub
End Class
