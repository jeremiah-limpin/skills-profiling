Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class CertificationAndLicensesClass
    Dim connection As OleDbConnection = SkillsProfile_Database.GetConnection()
    Private employeeForm As EmployeeF

    Public Sub New(ByVal empForm As EmployeeF)
        employeeForm = empForm
    End Sub

    Public Sub DisplayCertificationAndLicensesDataGrid(employeeNumber As String, ByRef dataGrid As DataGridView)

        connection.Close()

        Try
            connection.Open()

            Dim query As String = "SELECT Certification_ID, Certification_Name, Chapter, Provider, License_Number, Grant_Date, Expiry_Date, Status FROM Certifications_and_Licenses WHERE Employee_Number = @EmployeeNumber"

            Dim adapter As New OleDbDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            dataGrid.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show($"Error(Certification and License): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Public Sub AddDetailsToDatabase(ByRef CertificationAndLicenseDataGrid As DataGridView, ByRef txtEmployeeNumber As TextBox, ByRef txtCertificateName As TextBox, ByRef txtChapter As TextBox, ByRef txtProvider As TextBox, ByRef txtLicenseNumber As TextBox, ByRef dtpckerGrantDate As TextBox, ByRef dtpckerExpiryDate As TextBox, ByRef txtStatus As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        If String.IsNullOrWhiteSpace(txtCertificateName.Text) Or String.IsNullOrWhiteSpace(txtChapter.Text) Or String.IsNullOrWhiteSpace(txtProvider.Text) Or String.IsNullOrWhiteSpace(txtLicenseNumber.Text) Or String.IsNullOrWhiteSpace(txtStatus.Text) Then

            MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            connection.Open()

            Dim insertQuery As String = "INSERT INTO Certifications_and_Licenses (Employee_Number, Certification_Name, Chapter, Provider, License_Number, Grant_Date, Expiry_Date, Status) VALUES (@Employee_Number, @Certification_Name, @Chapter, @Provider, @License_Number, @Grant_Date, @Expiry_Date, @Status)"

            Dim insertCmd As New OleDbCommand(insertQuery, connection)
            insertCmd.Parameters.AddWithValue("@Employee_Number", txtEmployeeNumber.Text)
            insertCmd.Parameters.AddWithValue("@Certification_Name", txtCertificateName.Text)
            insertCmd.Parameters.AddWithValue("@Chapter", txtChapter.Text)
            insertCmd.Parameters.AddWithValue("@Provider", txtProvider.Text)
            insertCmd.Parameters.AddWithValue("@License_Number", txtLicenseNumber.Text)

            insertCmd.Parameters.AddWithValue("@Grant_Date", dtpckerGrantDate.Text)
            insertCmd.Parameters.AddWithValue("@Expiry_Date", dtpckerExpiryDate.Text)


            insertCmd.Parameters.AddWithValue("@Status", txtStatus.Text)

            insertCmd.ExecuteNonQuery()

            MessageBox.Show("New record has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            employeeForm.ReloadCertificationAndLicense()
            employeeForm.LastUpdate()
            HideButtons()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show($"Error(Add CL): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Public Sub UpdateDetailsInDatabase(ByRef CertificationAndLicenseDataGrid As DataGridView, ByRef txtCertificateName As TextBox, ByRef txtChapter As TextBox, ByRef txtProvider As TextBox, ByRef txtLicenseNumber As TextBox, ByRef dtpckerGrantDate As TextBox, ByRef dtpckerExpiryDate As TextBox, ByRef txtStatus As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        Try
            connection.Open()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                Dim selectedRow As DataGridViewRow = CertificationAndLicenseDataGrid.SelectedRows(0)

                Dim certificateID As Integer = CInt(selectedRow.Cells("Certification_ID").Value)
                Dim certificateName As String = txtCertificateName.Text
                Dim chapter As String = txtChapter.Text
                Dim provider As String = txtProvider.Text
                Dim licenseNumber As String = txtLicenseNumber.Text
                Dim grantDate As String = dtpckerGrantDate.Text
                Dim expiryDate As String = dtpckerExpiryDate.Text
                Dim status As String = txtStatus.Text

                Dim updateQuery As String = "UPDATE Certifications_and_Licenses SET Certification_Name = @Certification_Name, Chapter = @Chapter, Provider = @Provider, License_Number = @License_Number, Grant_Date = @Grant_Date, Expiry_Date = @Expiry_Date, Status = @Status WHERE Certification_ID = @Certification_ID"

                Dim updateCmd As New OleDbCommand(updateQuery, connection)

                updateCmd.Parameters.AddWithValue("@Certification_Name", certificateName)
                updateCmd.Parameters.AddWithValue("@Chapter", chapter)
                updateCmd.Parameters.AddWithValue("@Provider", provider)
                updateCmd.Parameters.AddWithValue("@License_Number", licenseNumber)
                updateCmd.Parameters.AddWithValue("@Grant_Date", grantDate)
                updateCmd.Parameters.AddWithValue("@Expiry_Date", expiryDate)
                updateCmd.Parameters.AddWithValue("@Status", status)
                updateCmd.Parameters.AddWithValue("@Certification_ID", certificateID)

                updateCmd.ExecuteNonQuery()

                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                employeeForm.ReloadCertificationAndLicense()
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
    Public Sub DeleteDetailsFromDatabase(ByRef CertificateAndLicenseDataGrid As DataGridView, ByRef employeeForm As EmployeeF)
        connection.Close()
        Try
            connection.Open()

            If CertificateAndLicenseDataGrid.SelectedRows.Count > 0 Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then
                    Dim selectedRow As DataGridViewRow = CertificateAndLicenseDataGrid.SelectedRows(0)

                    Dim certificateID As Integer = CInt(selectedRow.Cells("Certification_ID").Value)

                    Dim deleteQuery As String = "DELETE FROM Certifications_and_Licenses WHERE Certification_ID = @Certification_ID"
                    Dim deleteCmd As New OleDbCommand(deleteQuery, connection)
                    deleteCmd.Parameters.AddWithValue("@Certification_ID", certificateID)

                    deleteCmd.ExecuteNonQuery()

                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    employeeForm.ReloadCertificationAndLicense()
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
        employeeForm.txtCertificateName.Clear()
        employeeForm.txtProvider.Clear()
        employeeForm.txtLicenseNumber.Clear()
        employeeForm.dtpckerGrantDate.Clear()
        employeeForm.dtpckerExpiryDate.Clear()
        employeeForm.txtStatus.Clear()
        employeeForm.CertificationAndLicensesDataGrid.ClearSelection()
    End Sub
    Public Sub ShowButtons()
        employeeForm.btnAddCL.Visible = False
        employeeForm.btnSaveChangesCL.Visible = True
        employeeForm.btnDeleteCL.Visible = True
        employeeForm.btnCancelCL.Visible = True
    End Sub
    Public Sub HideButtons()
        employeeForm.btnAddCL.Visible = True
        employeeForm.btnSaveChangesCL.Visible = False
        employeeForm.btnDeleteCL.Visible = False
        employeeForm.btnCancelCL.Visible = False
    End Sub
End Class
