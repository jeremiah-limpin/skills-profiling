Imports System.Data.OleDb
Imports ADODB

Public Class AddEmployee
    Dim connection As OleDbConnection = SkillsProfile_Database.GetConnection()
    Dim employeeListF As New EmployeeListF
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, Button2.Click
        connection.Close()

        If String.IsNullOrWhiteSpace(txtEmployeeID.Text) Then
            MessageBox.Show("Please fill in the Employee ID field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmployeeID.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtFirstName.Text) Then
            MessageBox.Show("Please fill in the First Name field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFirstName.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtLastName.Text) Then
            MessageBox.Show("Please fill in the Last Name field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLastName.Focus()
            Return
        End If


        Try
            connection.Open()

            Dim checkQuery = "SELECT COUNT(*) FROM Employee_Profile WHERE Employee_Number = @Employee_Number"
            Dim checkCmd As New OleDbCommand(checkQuery, connection)
            checkCmd.Parameters.AddWithValue("@Employee_Number", txtEmployeeID.Text)
            Dim count As Integer = checkCmd.ExecuteScalar

            If count > 0 Then
                MessageBox.Show("Employee ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim employeeNumber = "TBR-" & txtEmployeeID.Text
            Dim employeePassword = "Spl3ndid2024"
            Dim firstName = txtFirstName.Text
            Dim lastName = txtLastName.Text
            Dim employeeRole = "1"
            Dim lastUpdate = Date.Today
            Dim status = "Active"
            Dim sharepointLink = txtSharepoint.Text

            Dim insertQuery = "INSERT INTO Employee_Profile (Employee_Number, Employee_Password, Employee_First_Name, Employee_Last_Name, Employee_Role, Last_Update, Status, Sharepoint_Link) VALUES (@Employee_Number, @Employee_Password, @Employee_First_Name, @Employee_Last_Name, @Employee_Role, @Last_Update, @Status, @Sharepoint_Link)"

            Dim insertCmd As New OleDbCommand(insertQuery, connection)
            insertCmd.Parameters.AddWithValue("@Employee_Number", employeeNumber)
            insertCmd.Parameters.AddWithValue("@Employee_Password", employeePassword)
            insertCmd.Parameters.AddWithValue("@Employee_First_Name", firstName)
            insertCmd.Parameters.AddWithValue("@Employee_Last_Name", lastName)
            insertCmd.Parameters.AddWithValue("@Employee_Role", employeeRole)
            insertCmd.Parameters.AddWithValue("@Last_Update", lastUpdate)
            insertCmd.Parameters.AddWithValue("@Status", status)
            insertCmd.Parameters.AddWithValue("@Sharepoint_Link", sharepointLink)

            insertCmd.ExecuteNonQuery()

            ClearFields()
            MessageBox.Show("New record has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Close()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Private Sub txtEmployeeID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmployeeID.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEmployeeID_Leave(sender As Object, e As EventArgs) Handles txtEmployeeID.Leave
        txtEmployeeID.Text = txtEmployeeID.Text.Trim
    End Sub

    Private Sub ClearFields()
        txtEmployeeID.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
    End Sub

    Private Sub btnCancelAdd_Click(sender As Object, e As EventArgs) Handles btnCancelAdd.Click, Button1.Click
        Close()
    End Sub

    Private Sub txtEmployeeID_GotFocus(sender As Object, e As EventArgs) Handles txtEmployeeID.GotFocus
        lblTooltip.Visible = True
    End Sub
    Private Sub txtEmployeeID_LostFocus(sender As Object, e As EventArgs) Handles txtEmployeeID.LostFocus
        lblTooltip.Visible = False
    End Sub
    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeID.TextChanged, txtFirstName.TextChanged, txtLastName.TextChanged, txtSharepoint.TextChanged
        UpdateControlsVisibility()
    End Sub
    Private Sub UpdateControlsVisibility()
        Dim allTextboxesFilled As Boolean = Not String.IsNullOrEmpty(txtEmployeeID.Text) AndAlso Not String.IsNullOrEmpty(txtFirstName.Text) AndAlso Not String.IsNullOrEmpty(txtLastName.Text)

        If allTextboxesFilled Then
            txtSharepoint.Visible = True
            lblSharepoint.Visible = True
            lnklblSharepoint.Visible = True

        Else
            txtSharepoint.Visible = False
            lblSharepoint.Visible = False
            lnklblSharepoint.Visible = False
            txtSharepoint.Clear()
        End If
    End Sub

    Private Sub TextBoxesOrComboBoxChanged(sender As Object, e As EventArgs) Handles txtEmployeeID.TextChanged, txtFirstName.TextChanged, txtLastName.TextChanged
        UpdateControlsVisibility()
    End Sub
    Private Sub txtSharepoint_TextChanged(sender As Object, e As EventArgs) Handles txtSharepoint.TextChanged
        Dim expectedStartOfLink = "https://thebackroommop.sharepoint.com/:f:/s/BackroomSkillsProfiling/"
        Dim currentLink = txtSharepoint.Text.Trim

        If Not currentLink.StartsWith(expectedStartOfLink) AndAlso Not String.IsNullOrEmpty(currentLink) Then
            MessageBox.Show("Please make sure you have entered a valid SharePoint link.", "Invalid SharePoint Link", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            chkbxSaveInfo.Enabled = False
        Else
            chkbxSaveInfo.Enabled = True
        End If

        If String.IsNullOrEmpty(txtSharepoint.Text) Then
            chkbxSaveInfo.Enabled = False
            chkbxSaveInfo.Checked = False
        End If
    End Sub


    Private Sub chkbxSaveInfo_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxSaveInfo.CheckedChanged
        If chkbxSaveInfo.Checked = True Then
            btnAdd.Enabled = True
        Else
            btnAdd.Enabled = False
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblSharepoint.LinkClicked
        Process.Start(New ProcessStartInfo With {
            .FileName = "cmd",
            .Arguments = $"/c start https://thebackroommop.sharepoint.com/sites/BackroomSkillsProfiling/Shared%20Documents/Forms/AllItems.aspx",
            .UseShellExecute = False,
            .CreateNoWindow = True
        })
    End Sub
    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso
           Not e.KeyChar = " "c AndAlso
           Not e.KeyChar = "."c AndAlso
           Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso
           Not e.KeyChar = " "c AndAlso
           Not e.KeyChar = "."c AndAlso
           Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub AddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox5.Focus()
    End Sub
End Class