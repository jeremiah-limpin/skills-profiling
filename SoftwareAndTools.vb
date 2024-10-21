Imports System.Data.OleDb

Public Class SoftwareAndToolsClass
    Dim connection As OleDbConnection = SkillsProfile_Database.GetConnection()
    Private employeeForm As EmployeeF

    Public Sub New(ByVal empForm As EmployeeF)
        employeeForm = empForm
    End Sub

    Public Sub DisplaySoftwareAndToolsDataGrid(employeeNumber As String, ByRef dataGrid As DataGridView)

        connection.Close()

        Try
            connection.Open()

            Dim query As String = "SELECT Software_ID, Software_or_Tool, Used_For FROM Software_Tools WHERE Employee_Number = @EmployeeNumber"

            Dim adapter As New OleDbDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            dataGrid.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show($"Error(Software and Tools): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Public Sub AddDetailsToDatabase(ByRef TaskProfileDataGrid As DataGridView, ByRef txtEmployeeNumber As TextBox, ByRef txtSoftwareOrTools As TextBox, ByRef txtUsedFor As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        If String.IsNullOrWhiteSpace(txtSoftwareOrTools.Text) Then

            MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            connection.Open()

            Dim insertQuery As String = "INSERT INTO Software_Tools (Employee_Number, Software_or_Tool, Used_For) VALUES (@Employee_Number, @Software_or_Tool, @Used_For)"

            Dim insertCmd As New OleDbCommand(insertQuery, connection)
            insertCmd.Parameters.AddWithValue("@Employee_Number", txtEmployeeNumber.Text)
            insertCmd.Parameters.AddWithValue("@Software_or_Tool", txtSoftwareOrTools.Text)
            insertCmd.Parameters.AddWithValue("@Used_For", txtUsedFor.Text)

            insertCmd.ExecuteNonQuery()

            MessageBox.Show("New record has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            employeeForm.ReloadSoftwareAndTools()
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
    Public Sub UpdateDetailsInDatabase(ByRef SoftwareAndToolsDataGrid As DataGridView, ByRef txtSoftwareOrTools As TextBox, ByRef txtUsedFor As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        Try
            connection.Open()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                Dim selectedRow As DataGridViewRow = SoftwareAndToolsDataGrid.SelectedRows(0)

                Dim softwareID As Integer = CInt(selectedRow.Cells("Software_ID").Value)
                Dim softwareAndTools As String = txtSoftwareOrTools.Text
                Dim usedFor As String = txtUsedFor.Text

                Dim updateQuery As String = "UPDATE Software_Tools SET Software_or_Tool = @Software_or_Tool, Used_For = @Used_For WHERE Software_ID = @Software_ID"

                Dim updateCmd As New OleDbCommand(updateQuery, connection)

                updateCmd.Parameters.AddWithValue("@Software_or_Tool", softwareAndTools)
                updateCmd.Parameters.AddWithValue("@Used_For", usedFor)
                updateCmd.Parameters.AddWithValue("@Software_ID", softwareID)

                updateCmd.ExecuteNonQuery()

                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                employeeForm.ReloadSoftwareAndTools()
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
    Public Sub DeleteDetailsFromDatabase(ByRef SoftwareAndToolsDataGrid As DataGridView, ByRef employeeForm As EmployeeF)
        connection.Close()
        Try
            connection.Open()

            If SoftwareAndToolsDataGrid.SelectedRows.Count > 0 Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then
                    Dim selectedRow As DataGridViewRow = SoftwareAndToolsDataGrid.SelectedRows(0)

                    Dim softwareID As Integer = CInt(selectedRow.Cells("Software_ID").Value)

                    Dim deleteQuery As String = "DELETE FROM Software_Tools WHERE Software_ID = @Software_ID"
                    Dim deleteCmd As New OleDbCommand(deleteQuery, connection)
                    deleteCmd.Parameters.AddWithValue("@Software_ID", softwareID)

                    deleteCmd.ExecuteNonQuery()

                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    employeeForm.ReloadSoftwareAndTools()
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
        employeeForm.txtSoftwareOrTools.Clear()
        employeeForm.txtUsedFor.Clear()
        employeeForm.SoftwareAndToolsDataGrid.ClearSelection()
    End Sub
    Public Sub ShowButtons()
        employeeForm.btnAddST.Visible = False
        employeeForm.btnSaveChangesST.Visible = True
        employeeForm.btnDeleteST.Visible = True
        employeeForm.btnCancelST.Visible = True
    End Sub
    Public Sub HideButtons()
        employeeForm.btnAddST.Visible = True
        employeeForm.btnSaveChangesST.Visible = False
        employeeForm.btnDeleteST.Visible = False
        employeeForm.btnCancelST.Visible = False
    End Sub
End Class
