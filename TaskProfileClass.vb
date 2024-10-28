Imports System.Data.OleDb

Public Class TaskProfileClass
    Dim connection As OleDbConnection = SkillsProfile_Database.GetConnection()
    Private employeeForm As EmployeeF

    Public Sub New(ByVal empForm As EmployeeF)
        employeeForm = empForm
    End Sub

    Public Sub DisplayTaskProfileDataGrid(employeeNumber As String, ByRef dataGrid As DataGridView)

        connection.Close()

        Try
            connection.Open()

            Dim query As String = "SELECT Task_ID, Task_Name, Category, POC, Description FROM Task_Profile WHERE Employee_Number = @EmployeeNumber"

            Dim adapter As New OleDbDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            dataGrid.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show($"Error(Task Profile): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Public Sub AddDetailsToDatabase(ByRef TaskProfileDataGrid As DataGridView, ByRef txtEmployeeNumber As TextBox, ByRef txtTaskName As TextBox, ByRef txtCategory As TextBox, ByRef txtPOC As TextBox, ByRef txtDescription As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        If String.IsNullOrWhiteSpace(txtTaskName.Text) Or String.IsNullOrWhiteSpace(txtCategory.Text) Or String.IsNullOrWhiteSpace(txtPOC.Text) Or String.IsNullOrWhiteSpace(txtDescription.Text) Then

            MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            connection.Open()

            Dim insertQuery As String = "INSERT INTO Task_Profile (Employee_Number, Task_Name, Category, POC, Description) VALUES (@Employee_Number, @Task_Name, @Category, @POC, @Description)"

            Dim insertCmd As New OleDbCommand(insertQuery, connection)
            insertCmd.Parameters.AddWithValue("@Employee_Number", txtEmployeeNumber.Text)
            insertCmd.Parameters.AddWithValue("@Task_Name", txtTaskName.Text)
            insertCmd.Parameters.AddWithValue("@Category", txtCategory.Text)
            insertCmd.Parameters.AddWithValue("@POC", txtPOC.Text)
            insertCmd.Parameters.AddWithValue("@Description", txtDescription.Text)

            insertCmd.ExecuteNonQuery()

            MessageBox.Show("New record has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            employeeForm.ReloadTaskProfile()
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
    Public Sub UpdateDetailsInDatabase(ByRef TaskProfileDataGrid As DataGridView, ByRef txtTaskName As TextBox, ByRef txtCategory As TextBox, ByRef txtPOC As TextBox, ByRef txtDescription As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        Try
            connection.Open()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                Dim selectedRow As DataGridViewRow = TaskProfileDataGrid.SelectedRows(0)

                Dim taskID As Integer = CInt(selectedRow.Cells("Task_ID").Value)
                Dim taskName As String = txtTaskName.Text
                Dim category As String = txtCategory.Text
                Dim poc As String = txtPOC.Text
                Dim description As String = txtDescription.Text

                Dim updateQuery As String = "UPDATE Task_Profile SET Task_Name = @Task_Name, Category = @Category, POC = @POC, Description = @Description WHERE Task_ID = @Task_ID"

                Dim updateCmd As New OleDbCommand(updateQuery, connection)

                updateCmd.Parameters.AddWithValue("@Task_Name", taskName)
                updateCmd.Parameters.AddWithValue("@Category", category)
                updateCmd.Parameters.AddWithValue("@POC", poc)
                updateCmd.Parameters.AddWithValue("@Description", description)
                updateCmd.Parameters.AddWithValue("@Task_ID", taskID)

                updateCmd.ExecuteNonQuery()

                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                employeeForm.ReloadTaskProfile()
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
    Public Sub DeleteDetailsFromDatabase(ByRef TaskProfileDataGrid As DataGridView, ByRef employeeForm As EmployeeF)
        connection.Close()
        Try
            connection.Open()

            If TaskProfileDataGrid.SelectedRows.Count > 0 Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then
                    Dim selectedRow As DataGridViewRow = TaskProfileDataGrid.SelectedRows(0)

                    Dim taskID As Integer = CInt(selectedRow.Cells("Task_ID").Value)

                    Dim deleteQuery As String = "DELETE FROM Task_Profile WHERE Task_ID = @Task_ID"
                    Dim deleteCmd As New OleDbCommand(deleteQuery, connection)
                    deleteCmd.Parameters.AddWithValue("@Task_ID", taskID)

                    deleteCmd.ExecuteNonQuery()

                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    employeeForm.ReloadTaskProfile()
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
        employeeForm.txtTaskName.Clear()
        employeeForm.txtCategory.Clear()
        employeeForm.txtPOC.Clear()
        employeeForm.txtDescription.Clear()
        employeeForm.TaskProfileDataGrid.ClearSelection()
    End Sub
    Public Sub ShowButtons()
        employeeForm.btnAddTP.Visible = False
        employeeForm.btnAddTP.Visible = True
        employeeForm.btnDeleteTP.Visible = True
        employeeForm.btnCancelTP.Visible = True

    End Sub
    Public Sub HideButtons()
        employeeForm.btnAddTP.Visible = True
        employeeForm.btnAddTP.Visible = False
        employeeForm.btnDeleteTP.Visible = False
        employeeForm.btnCancelTP.Visible = False
    End Sub
End Class
