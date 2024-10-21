Imports System.Data.OleDb

Public Class WebinarsAttendedClass
    Dim connection As OleDbConnection = SkillsProfile_Database.GetConnection()
    Private employeeForm As EmployeeF

    Public Sub New(ByVal empForm As EmployeeF)
        employeeForm = empForm
    End Sub

    Public Sub DisplayWebinarsAttendedDataGrid(employeeNumber As String, ByRef dataGrid As DataGridView)

        connection.Close()

        Try
            connection.Open()

            Dim query As String = "SELECT Webinar_ID, Webinar_Title, Date_, CPD_Units FROM Webinars_Attended WHERE Employee_Number = @EmployeeNumber"

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
    Public Sub AddDetailsToDatabase(ByRef WebinarsAttendedDataGrid As DataGridView, ByRef txtEmployeeNumber As TextBox, ByRef txtWebinarTitle As TextBox, ByRef dtpckerDateW As TextBox, ByRef txtCPDUnits As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()
        If String.IsNullOrWhiteSpace(txtWebinarTitle.Text) Or String.IsNullOrWhiteSpace(txtCPDUnits.Text) Then

            MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            connection.Open()

            Dim insertQuery As String = "INSERT INTO Webinars_Attended (Employee_Number, Webinar_Title, Date_, CPD_Units) VALUES (@Employee_Number, @Webinar_Title, @Date_, @CPD_Units)"
            Dim insertCmd As New OleDbCommand(insertQuery, connection)
            insertCmd.Parameters.AddWithValue("@Employee_Number", txtEmployeeNumber.Text)
            insertCmd.Parameters.AddWithValue("@Webinar_Title", txtWebinarTitle.Text)
            insertCmd.Parameters.AddWithValue("@Date_", dtpckerDateW.Text)
            insertCmd.Parameters.AddWithValue("@CPD_Units", txtCPDUnits.Text)

            insertCmd.ExecuteNonQuery()

            MessageBox.Show("New record has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            employeeForm.ReloadWebinarsAttended()
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
    Public Sub UpdateDetailsInDatabase(ByRef WebinarsAttendedDataGrid As DataGridView, ByRef txtWebinarTitle As TextBox, ByRef dtpckerDateW As TextBox, ByRef txtCPDUnits As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        Try
            connection.Open()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                Dim selectedRow As DataGridViewRow = WebinarsAttendedDataGrid.SelectedRows(0)

                Dim webinarID As Integer = CInt(selectedRow.Cells("Webinar_ID").Value)
                Dim webinarTitle As String = txtWebinarTitle.Text
                Dim date_ As String = dtpckerDateW.Text
                Dim cpdUnits As String = txtCPDUnits.Text

                Dim updateQuery As String = "UPDATE Webinars_Attended SET Webinar_Title = @Webinar_Title, Date_ = @Date_, CPD_Units = @CPD_Units WHERE Webinar_ID = @Webinar_ID"
                Dim updateCmd As New OleDbCommand(updateQuery, connection)

                updateCmd.Parameters.AddWithValue("@Webinar_Title", webinarTitle)
                updateCmd.Parameters.AddWithValue("@Date_", date_)
                updateCmd.Parameters.AddWithValue("@CPD_Units", cpdUnits)
                updateCmd.Parameters.AddWithValue("@Webinar_ID", webinarID)

                updateCmd.ExecuteNonQuery()

                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                employeeForm.ReloadWebinarsAttended()
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

    Public Sub DeleteDetailsFromDatabase(ByRef WebinarsAttendedDataGrid As DataGridView, ByRef employeeForm As EmployeeF)
        connection.Close()
        Try
            connection.Open()

            If WebinarsAttendedDataGrid.SelectedRows.Count > 0 Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then
                    Dim selectedRow As DataGridViewRow = WebinarsAttendedDataGrid.SelectedRows(0)

                    Dim webinarID As Integer = CInt(selectedRow.Cells("Webinar_ID").Value)

                    Dim deleteQuery As String = "DELETE FROM Webinars_Attended WHERE Webinar_ID = @Webinar_ID"
                    Dim deleteCmd As New OleDbCommand(deleteQuery, connection)
                    deleteCmd.Parameters.AddWithValue("@Webinar_ID", webinarID)

                    deleteCmd.ExecuteNonQuery()

                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    employeeForm.ReloadWebinarsAttended()
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
        employeeForm.txtWebinarTitle.Clear()
        employeeForm.txtDateW.Clear()
        employeeForm.txtCPDUnits.Clear()
        employeeForm.WebinarsAttendedDataGrid.ClearSelection()
    End Sub
    Public Sub ShowButtons()
        employeeForm.btnAddW.Visible = False
        employeeForm.btnSaveChangesW.Visible = True
        employeeForm.btnDeleteW.Visible = True
        employeeForm.btnCancelW.Visible = True
    End Sub
    Public Sub HideButtons()
        employeeForm.btnAddW.Visible = True
        employeeForm.btnSaveChangesW.Visible = False
        employeeForm.btnDeleteW.Visible = False
        employeeForm.btnCancelW.Visible = False
    End Sub
End Class
