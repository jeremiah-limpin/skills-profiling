Imports System.Data.OleDb

Public Class ClientF
    Dim connection As OleDbConnection = SkillsProfile_Database.GetConnection()

    Private Sub ClientF_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection.Close()

        Try
            connection.Open()

            Dim query As String = "SELECT ClientID, Client_Name, Region FROM Client ORDER BY Client_Name ASC"
            Dim adapter As New OleDbDataAdapter(query, connection)
            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            ClientDataGrid.DataSource = dataTable

            ClientDataGrid.Columns("ClientID").Visible = False

            ClientDataGrid.ReadOnly = True
            ClientDataGrid.MultiSelect = False
            ClientDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            ClientDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            ClientDataGrid.AllowUserToAddRows = False
            ClientDataGrid.ScrollBars = ScrollBars.Vertical
            ClientDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            ClientDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True

            ClientDataGrid.Columns("Client_Name").Width = 370
            ClientDataGrid.Columns("Region").Width = 370

            rdbtnClientName.Checked = True
            rdbtnRegion.Checked = False

            For Each column As DataGridViewColumn In ClientDataGrid.Columns
                If column.HeaderText.Contains("_") Then
                    column.HeaderText = column.HeaderText.Replace("_", " ")
                End If
            Next

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Private Sub rdbtnClientName_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtnClientName.CheckedChanged
        Dim dataTable As DataTable = CType(ClientDataGrid.DataSource, DataTable)

        If dataTable IsNot Nothing AndAlso dataTable.DefaultView IsNot Nothing Then
            If rdbtnClientName.Checked Then
                dataTable.DefaultView.Sort = "Client_Name ASC"
            End If
        End If
    End Sub

    Private Sub rdbtnRegion_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtnRegion.CheckedChanged
        Dim dataTable As DataTable = CType(ClientDataGrid.DataSource, DataTable)

        If dataTable IsNot Nothing AndAlso dataTable.DefaultView IsNot Nothing Then
            If rdbtnRegion.Checked Then
                dataTable.DefaultView.Sort = "Region ASC"
            End If
        End If
    End Sub

    Private Sub btnAddClient_Click(sender As Object, e As EventArgs) Handles btnAddClient.Click
        If String.IsNullOrWhiteSpace(txtClientName.Text) OrElse String.IsNullOrWhiteSpace(cmbRegion.Text) Then
            MessageBox.Show("Please fill up the missing fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            AddClientToDatabase()
        End If
    End Sub
    Private Sub AddClientToDatabase()
        Try
            connection.Open()

            Dim insertQuery As String = "INSERT INTO Client (Client_Name, Region) VALUES (@Client_Name, @Region)"
            Dim insertCmd As New OleDbCommand(insertQuery, connection)
            insertCmd.Parameters.AddWithValue("@Client_Name", txtClientName.Text)
            insertCmd.Parameters.AddWithValue("@Region", cmbRegion.Text)

            insertCmd.ExecuteNonQuery()

            MessageBox.Show("Client " & txtClientName.Text & " from " & cmbRegion.Text & " has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            txtClientName.Clear()
            cmbRegion.SelectedIndex = -1

            ReloadDataAndBindGrid()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Private Sub ClientDataGrid_CellClick(sender As Object, e As EventArgs) Handles ClientDataGrid.Click
        If ClientDataGrid.SelectedRows.Count > 0 Then
            btnSaveChanges.Visible = True
            btnDelete.Visible = True
            btnCancel.Visible = True
            btnAddClient.Visible = False

            Dim clientName As Object = ClientDataGrid.SelectedRows(0).Cells("Client_Name").Value
            Dim region As Object = ClientDataGrid.SelectedRows(0).Cells("Region").Value

            txtClientName.Text = clientName.ToString()
            cmbRegion.Text = region.ToString()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnSaveChanges.Visible = False
        btnDelete.Visible = False
        btnCancel.Visible = False
        btnAddClient.Visible = True

        ClientDataGrid.ClearSelection()
        txtClientName.Clear()
        cmbRegion.SelectedIndex = -1
    End Sub
    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        If ClientDataGrid.SelectedRows.Count > 0 Then
            Try
                connection.Open()
                Dim selectedRow As DataGridViewRow = ClientDataGrid.SelectedRows(0)

                Dim clientID As Integer = selectedRow.Cells("ClientID").Value
                Dim clientName As String = txtClientName.Text
                Dim region As String = cmbRegion.Text

                Dim updateQuery As String = "UPDATE Client SET Client_Name = @Client_Name, Region = @Region WHERE ClientID = @ClientID"
                Dim updateCmd As New OleDbCommand(updateQuery, connection)
                updateCmd.Parameters.AddWithValue("@Client_Name", clientName)
                updateCmd.Parameters.AddWithValue("@Region", region)
                updateCmd.Parameters.AddWithValue("@ClientID", clientID)

                updateCmd.ExecuteNonQuery()

                btnSaveChanges.Visible = False
                btnDelete.Visible = False
                btnCancel.Visible = False
                btnAddClient.Visible = True

                txtClientName.Clear()
                cmbRegion.SelectedIndex = -1

                ClientDataGrid.ClearSelection()
                ReloadDataAndBindGrid()
                MessageBox.Show("Details for " & clientName & " has been updated.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error updating Permission: {ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ClientDataGrid.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected client?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    connection.Open()
                    Dim selectedRow As DataGridViewRow = ClientDataGrid.SelectedRows(0)

                    Dim clientID As Integer = selectedRow.Cells("ClientID").Value

                    Dim deleteQuery As String = "DELETE FROM Client WHERE ClientID = @ClientID"
                    Dim deleteCmd As New OleDbCommand(deleteQuery, connection)
                    deleteCmd.Parameters.AddWithValue("@ClientID", clientID)

                    deleteCmd.ExecuteNonQuery()

                    btnSaveChanges.Visible = False
                    btnDelete.Visible = False
                    btnCancel.Visible = False
                    btnAddClient.Visible = True

                    txtClientName.Clear()
                    cmbRegion.SelectedIndex = -1

                    MessageBox.Show("Client details deleted successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ClientDataGrid.ClearSelection()
                    ReloadDataAndBindGrid()
                Catch ex As Exception
                    MessageBox.Show($"Error deleting client details: {ex.Message}", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If connection.State = ConnectionState.Open Then
                        connection.Close()
                    End If
                End Try
            End If
        Else
            MessageBox.Show("Please select a client to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub ReloadDataAndBindGrid()
        Try
            Dim query As String = "SELECT ClientID, Client_Name, Region FROM Client ORDER BY Client_Name ASC"
            Dim adapter As New OleDbDataAdapter(query, connection)
            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            ClientDataGrid.DataSource = dataTable

            ClientDataGrid.ReadOnly = True
            ClientDataGrid.MultiSelect = False
            ClientDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            ClientDataGrid.AllowUserToAddRows = False
            ClientDataGrid.ScrollBars = ScrollBars.Vertical

            ClientDataGrid.Columns("Client_Name").Width = 370
            ClientDataGrid.Columns("Region").Width = 370

            rdbtnClientName.Checked = True
            rdbtnRegion.Checked = False

            For Each column As DataGridViewColumn In ClientDataGrid.Columns
                If column.HeaderText.Contains("_") Then
                    column.HeaderText = column.HeaderText.Replace("_", " ")
                End If
            Next

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class