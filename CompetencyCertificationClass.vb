Imports System.Data.OleDb

Public Class CompetencyCertificationClass
    Dim connection As OleDbConnection = SkillsProfile_Database.GetConnection()
    Private employeeForm As EmployeeF

    Public Sub New(ByVal empForm As EmployeeF)
        employeeForm = empForm
    End Sub

    Public Sub DisplayCompetencyCertificationDataGrid(employeeNumber As String, ByRef dataGrid As DataGridView)

        connection.Close()

        Try
            connection.Open()

            Dim query As String = "SELECT Competency_ID, Certification_Name, Grant_Date, Deliberation_Summary, Overall_Grade FROM Competency_Certification WHERE Employee_Number = @EmployeeNumber ORDER BY Grant_Date DESC"

            Dim adapter As New OleDbDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            dataGrid.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show($"Error(Competency Certification): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Public Sub AddDetailsToDatabase(ByRef CompetencyCertificationDataGrid As DataGridView, ByRef txtEmployeeNumber As TextBox, ByRef txtCertificationName As TextBox, ByRef dtpckerGrantDateCC As TextBox, ByRef txtDeliberationSummary As TextBox, ByRef txtOverallGrade As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        If String.IsNullOrWhiteSpace(txtCertificationName.Text) Or String.IsNullOrWhiteSpace(txtDeliberationSummary.Text) Or String.IsNullOrWhiteSpace(txtOverallGrade.Text) Then
            MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            connection.Open()

            Dim insertQuery As String = "INSERT INTO Competency_Certification (Employee_Number, Certification_Name, Grant_Date, Deliberation_Summary, Overall_Grade) VALUES (@Employee_Number, @Certification_Name, @Grant_Date, @Deliberation_Summary, @Overall_Grade)"

            Dim insertCmd As New OleDbCommand(insertQuery, connection)
            insertCmd.Parameters.AddWithValue("@Employee_Number", txtEmployeeNumber.Text)
            insertCmd.Parameters.AddWithValue("@Certification_Name", txtCertificationName.Text)
            insertCmd.Parameters.AddWithValue("@Grant_Date", dtpckerGrantDateCC.Text)
            insertCmd.Parameters.AddWithValue("@Deliberation_Summary", txtDeliberationSummary.Text)
            insertCmd.Parameters.AddWithValue("@Overall_Grade", txtOverallGrade.Text)

            insertCmd.ExecuteNonQuery()

            MessageBox.Show("New record has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            employeeForm.ReloadCompetencyCertification()
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
    Public Sub UpdateDetailsInDatabase(ByRef CompetencyCertificationDataGrid As DataGridView, ByRef txtCertificationName As TextBox, ByRef dtpckerGrantDateCC As TextBox, ByRef txtDeliberationSummary As TextBox, ByRef txtOverallGrade As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        Try
            connection.Open()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                Dim selectedRow As DataGridViewRow = CompetencyCertificationDataGrid.SelectedRows(0)
                Dim competencyID As Integer = CInt(selectedRow.Cells("Competency_ID").Value)
                Dim certificateName As String = txtCertificationName.Text
                Dim grantDate As String = dtpckerGrantDateCC.Text
                Dim deliberationSummary As String = txtDeliberationSummary.Text
                Dim overallGrade As String = txtOverallGrade.Text

                Dim updateQuery As String = "UPDATE Competency_Certification SET Certification_Name = @Certification_Name, Grant_Date = @Grant_Date, Deliberation_Summary = @Deliberation_Summary, Overall_Grade = @Overall_Grade WHERE Competency_ID = @Competency_ID"

                Dim updateCmd As New OleDbCommand(updateQuery, connection)

                updateCmd.Parameters.AddWithValue("@Certification_Name", certificateName)
                updateCmd.Parameters.AddWithValue("@Grant_Date", grantDate)
                updateCmd.Parameters.AddWithValue("@Deliberation_Summary", deliberationSummary)
                updateCmd.Parameters.AddWithValue("@Overall_Grade", overallGrade)
                updateCmd.Parameters.AddWithValue("@Competency_ID", competencyID)

                updateCmd.ExecuteNonQuery()

                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                employeeForm.ReloadCompetencyCertification()
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
    Public Sub DeleteDetailsFromDatabase(ByRef CompetencyCertificationDataGrid As DataGridView, ByRef employeeForm As EmployeeF)
        connection.Close()
        Try
            connection.Open()

            If CompetencyCertificationDataGrid.SelectedRows.Count > 0 Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then
                    Dim selectedRow As DataGridViewRow = CompetencyCertificationDataGrid.SelectedRows(0)

                    Dim competencyID As Integer = CInt(selectedRow.Cells("Competency_ID").Value)

                    Dim deleteQuery As String = "DELETE FROM Competency_Certification WHERE Competency_ID = @Competency_ID"
                    Dim deleteCmd As New OleDbCommand(deleteQuery, connection)
                    deleteCmd.Parameters.AddWithValue("@Competency_ID", competencyID)

                    deleteCmd.ExecuteNonQuery()

                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    employeeForm.ReloadCompetencyCertification()
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
        employeeForm.txtCertificationName.Clear()
        employeeForm.txtGrantDateCC.Clear()
        employeeForm.txtDeliberationSummary.Clear()
        employeeForm.txtOverallGrade.Clear()
        employeeForm.CompetencyCertificationDataGrid.ClearSelection()
    End Sub
    Public Sub ShowButtons()
        employeeForm.btnAddCC.Visible = False
        employeeForm.btnSaveChangesCC.Visible = True
        employeeForm.btnDeleteCC.Visible = True
        employeeForm.btnCancelCC.Visible = True
    End Sub
    Public Sub HideButtons()
        employeeForm.btnAddCC.Visible = True
        employeeForm.btnSaveChangesCC.Visible = False
        employeeForm.btnDeleteCC.Visible = False
        employeeForm.btnCancelCC.Visible = False
    End Sub

End Class

