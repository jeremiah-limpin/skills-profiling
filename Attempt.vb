Imports System.Data.OleDb

Public Class Attempt
    Dim connection As OleDbConnection = SkillsProfile_Database.GetConnection()

    Public Sub Attempt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Close()

        Try
            connection.Open()

            Dim loginID As String = LoginF.adminID
            Dim query As String = "SELECT Employee_Number, Employee_Role FROM Employee_Profile Where Employee_Number = @EmployeeNumber"
            Dim cmd As New OleDbCommand(query, connection)
            cmd.Parameters.AddWithValue("@EmployeeNumber", loginID)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            If reader.Read Then

                Dim employeeRole As Integer = reader("Employee_Role")
                'Check for role level to display appropriate login logs
                If employeeRole = 4 Then
                    Try

                        ' Query to retrieve all employees from the Employee_Profile table
                        Dim adapter As New OleDbDataAdapter("SELECT Attempt_ID, Employee_Number, Date_Attempt, Description FROM Attempted_Access ORDER BY Date_Attempt DESC", connection)
                        Dim dataTable As New DataTable()

                        ' Fill the DataTable with data from the database
                        adapter.Fill(dataTable)

                        ' formatting of data grid
                        AttemptAccessDataGrid.DataSource = dataTable

                        AttemptAccessDataGrid.Columns("Attempt_ID").Visible = False

                        AttemptAccessDataGrid.ReadOnly = True
                        AttemptAccessDataGrid.MultiSelect = False
                        AttemptAccessDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                        AttemptAccessDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

                        AttemptAccessDataGrid.AllowUserToAddRows = False
                        AttemptAccessDataGrid.ScrollBars = ScrollBars.Vertical
                        AttemptAccessDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                        AttemptAccessDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True

                        AttemptAccessDataGrid.Columns("Description").Width = 160.3

                        For Each column As DataGridViewColumn In AttemptAccessDataGrid.Columns
                            If column.HeaderText.Contains("_") Then
                                column.HeaderText = column.HeaderText.Replace("_", " ")
                            End If
                        Next

                    Catch ex As Exception
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        ' Close the connection
                        If connection.State = ConnectionState.Open Then
                            connection.Close()
                        End If
                    End Try
                ElseIf employeeRole = 3 Or employeeRole = 2 Then
                    Try

                        Dim adapter As New OleDbDataAdapter("SELECT Attempt_ID, Employee_Number, Date_Attempt, Description FROM Attempted_Access Where Employee_Number = '" & loginID & "' ORDER BY Date_Attempt DESC", connection)
                        Dim dataTable As New DataTable()

                        ' Fill the DataTable with data from the database
                        adapter.Fill(dataTable)

                        ' formatting of data grid
                        AttemptAccessDataGrid.DataSource = dataTable

                        AttemptAccessDataGrid.Columns("Attempt_ID").Visible = False

                        AttemptAccessDataGrid.ReadOnly = True
                        AttemptAccessDataGrid.MultiSelect = False
                        AttemptAccessDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                        AttemptAccessDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

                        AttemptAccessDataGrid.AllowUserToAddRows = False
                        AttemptAccessDataGrid.ScrollBars = ScrollBars.Vertical
                        AttemptAccessDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                        AttemptAccessDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True

                        AttemptAccessDataGrid.Columns("Employee_Number").Width = 288.3
                        AttemptAccessDataGrid.Columns("Date_Attempt").Width = 288.3
                        AttemptAccessDataGrid.Columns("Description").Width = 288.3

                        For Each column As DataGridViewColumn In AttemptAccessDataGrid.Columns
                            If column.HeaderText.Contains("_") Then
                                column.HeaderText = column.HeaderText.Replace("_", " ")
                            End If
                        Next

                    Catch ex As Exception
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        ' Close the connection
                        If connection.State = ConnectionState.Open Then
                            connection.Close()
                        End If
                    End Try
                End If
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
    End Sub
End Class