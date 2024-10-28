Imports System.Data.OleDb

Public Class EmployeeProfileClass
    Dim connection As OleDbConnection = SkillsProfile_Database.GetConnection()
    Private employeeForm As EmployeeF

    Public Sub New(ByVal empForm As EmployeeF)
        employeeForm = empForm
    End Sub

    Public Sub DisplayEmployeeProfileDataGrid(employeeNumber As String, ByRef dataGrid As DataGridView)

        connection.Close()

        Try
            connection.Open()

            Dim query As String = "SELECT Employee_ID, Employee_First_Name, Employee_Last_Name, Last_Update, Status, Sharepoint_Link FROM Employee_Profile WHERE Employee_Number = @EmployeeNumber"

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
    Public Sub UpdateDetailsInDatabase(ByRef EmployeeProfileDataGrid As DataGridView, ByRef txtFname As TextBox, ByRef txtLname As TextBox, ByRef txtLastUpdate As TextBox, ByRef chkbxIsActive As CheckBox, ByRef txtSharepointLink As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        Try
            connection.Open()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                Dim selectedRow As DataGridViewRow = EmployeeProfileDataGrid.SelectedRows(0)

                Dim employeeID As Integer = CInt(selectedRow.Cells("Employee_ID").Value)
                Dim fname As String = txtFname.Text
                Dim lname As String = txtLname.Text
                Dim lastupdate As String = txtLastUpdate.Text
                Dim status As String = If(chkbxIsActive.Checked, "Active", "Inactive")
                Dim sharepointlink As String = txtSharepointLink.Text

                Dim updateQuery As String = "UPDATE Employee_Profile SET Employee_First_Name = @Employee_First_Name, Employee_Last_Name = @Employee_Last_Name, Last_Update = @Last_Update, Status = @Status, Sharepoint_Link = @Sharepoint_Link WHERE Employee_ID = @Employee_ID"

                Dim updateCmd As New OleDbCommand(updateQuery, connection)

                updateCmd.Parameters.AddWithValue("@Employee_First_Name", fname)
                updateCmd.Parameters.AddWithValue("@Employee_Last_Name", lname)
                updateCmd.Parameters.AddWithValue("@Last_Update", lastupdate)
                updateCmd.Parameters.AddWithValue("@Status", status)
                updateCmd.Parameters.AddWithValue("@Sharepoint_Link", sharepointlink)
                updateCmd.Parameters.AddWithValue("@Employee_ID", employeeID)

                updateCmd.ExecuteNonQuery()

                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                employeeForm.ReloadEmployeeProfile()
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

    Public Sub ClearFields()
        employeeForm.txtFname.Clear()
        employeeForm.txtLname.Clear()
        employeeForm.txtLastUpdate.Clear()
        employeeForm.chkbxIsActive.Checked = False
        employeeForm.txtSharepointLink.Clear()
        employeeForm.EmployeeProfileDataGrid.ClearSelection()
    End Sub
    Public Sub ShowButtons()
        employeeForm.btnSaveChangesT.Visible = True
        employeeForm.btnDeleteT.Visible = True
        employeeForm.btnCancelT.Visible = True
    End Sub
    Public Sub HideButtons()
        employeeForm.btnSaveChangesT.Visible = False
        employeeForm.btnDeleteT.Visible = False
        employeeForm.btnCancelT.Visible = False
    End Sub

End Class
