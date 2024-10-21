Imports System.Data.OleDb

Public Class PerformanceEvaluationClass
    Dim connection As OleDbConnection = SkillsProfile_Database.GetConnection()
    Private employeeForm As EmployeeF

    Public Sub New(ByVal empForm As EmployeeF)
        employeeForm = empForm
    End Sub

    Public Sub DisplayPerformanceEvaluationDataGrid(employeeNumber As String, ByRef dataGrid As DataGridView)

        connection.Close()

        Try
            connection.Open()

            Dim query As String = "SELECT Performance_ID, Evaluation_Type, Evaluation_Date, Evaluator, Evaluation_Notes FROM Performance_Evaluation WHERE Employee_Number = @EmployeeNumber"

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
    Public Sub AddDetailsToDatabase(ByRef PerformanceEvaluationDataGrid As DataGridView, ByRef txtEmployeeNumber As TextBox, ByRef txtEvaluationType As TextBox, ByRef dtpckerEvaluationDate As TextBox, ByRef txtEvaluator As TextBox, ByRef txtEvaluationNotes As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        If String.IsNullOrWhiteSpace(txtEvaluationType.Text) Or String.IsNullOrWhiteSpace(txtEvaluator.Text) Or String.IsNullOrWhiteSpace(txtEvaluationNotes.Text) Then

            MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            connection.Open()

            Dim insertQuery As String = "INSERT INTO Performance_Evaluation (Employee_Number, Evaluation_Type, Evaluation_Date, Evaluator, Evaluation_Notes) VALUES (@Employee_Number, @Evaluation_Type, @Evaluation_Date, @Evaluator, @Evaluation_Notes)"

            Dim insertCmd As New OleDbCommand(insertQuery, connection)
            insertCmd.Parameters.AddWithValue("@Employee_Number", txtEmployeeNumber.Text)
            insertCmd.Parameters.AddWithValue("@Evaluation_Type", txtEvaluationType.Text)
            insertCmd.Parameters.AddWithValue("@Evaluation_Date", dtpckerEvaluationDate.Text)
            insertCmd.Parameters.AddWithValue("@Evaluator", txtEvaluator.Text)
            insertCmd.Parameters.AddWithValue("@Evaluation_Notes", txtEvaluationNotes.Text)

            insertCmd.ExecuteNonQuery()

            MessageBox.Show("New record has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            employeeForm.ReloadPerformanceEvaluation()
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
    Public Sub UpdateDetailsInDatabase(ByRef PerformanceEvaluationDataGrid As DataGridView, ByRef txtEvaluationType As TextBox, ByRef dtpckerEvaluationDate As TextBox, ByRef txtEvaluator As TextBox, ByRef txtEvaluationNotes As TextBox, ByRef employeeForm As EmployeeF)
        connection.Close()

        Try
            connection.Open()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                Dim selectedRow As DataGridViewRow = PerformanceEvaluationDataGrid.SelectedRows(0)

                Dim performanceID As Integer = CInt(selectedRow.Cells("Performance_ID").Value)
                Dim evaluationType As String = txtEvaluationType.Text
                Dim evaluationDate As String = dtpckerEvaluationDate.Text
                Dim evaluator As String = txtEvaluator.Text
                Dim evaluationNotes As String = txtEvaluationNotes.Text

                Dim updateQuery As String = "UPDATE Performance_Evaluation SET Evaluation_Type = @Evaluation_Type, Evaluation_Date = @Evaluation_Date, Evaluator = @Evaluator, Evaluation_Notes = @Evaluation_Notes WHERE Performance_ID = @Performance_ID"

                Dim updateCmd As New OleDbCommand(updateQuery, connection)

                updateCmd.Parameters.AddWithValue("@Evaluation_Type", evaluationType)
                updateCmd.Parameters.AddWithValue("@Evaluation_Date", evaluationDate)
                updateCmd.Parameters.AddWithValue("@Evaluator", evaluator)
                updateCmd.Parameters.AddWithValue("@Evaluation_Notes", evaluationNotes)
                updateCmd.Parameters.AddWithValue("@Performance_ID", performanceID)

                updateCmd.ExecuteNonQuery()

                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                employeeForm.ReloadPerformanceEvaluation()
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
    Public Sub DeleteDetailsFromDatabase(ByRef PerformanceEvaluationDataGrid As DataGridView, ByRef employeeForm As EmployeeF)
        connection.Close()
        Try
            connection.Open()

            If PerformanceEvaluationDataGrid.SelectedRows.Count > 0 Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then
                    Dim selectedRow As DataGridViewRow = PerformanceEvaluationDataGrid.SelectedRows(0)

                    Dim performanceID As Integer = CInt(selectedRow.Cells("Performance_ID").Value)

                    Dim deleteQuery As String = "DELETE FROM Performance_Evaluation WHERE Performance_ID = @Performance_ID"
                    Dim deleteCmd As New OleDbCommand(deleteQuery, connection)
                    deleteCmd.Parameters.AddWithValue("@Performance_ID", performanceID)

                    deleteCmd.ExecuteNonQuery()

                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    employeeForm.ReloadPerformanceEvaluation()
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
        employeeForm.txtEvaluationType.Clear()
        employeeForm.dtpckerEvalutionDate.Clear()
        employeeForm.txtEvaluator.Clear()
        employeeForm.txtEvaluationNotes.Clear()
        employeeForm.PerformanceEvaluationDataGrid.ClearSelection()
    End Sub
    Public Sub ShowButtons()
        employeeForm.btnAddPE.Visible = False
        employeeForm.btnSaveChangesPE.Visible = True
        employeeForm.btnDeletePE.Visible = True
        employeeForm.btnCancelPE.Visible = True
    End Sub
    Public Sub HideButtons()
        employeeForm.btnAddPE.Visible = True
        employeeForm.btnSaveChangesPE.Visible = False
        employeeForm.btnDeletePE.Visible = False
        employeeForm.btnCancelPE.Visible = False
    End Sub
End Class
