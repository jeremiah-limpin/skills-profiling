Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing
Imports System.Text
Imports System.Transactions

Public Class ChangePasswordForm
    Dim connection As OleDbConnection = SkillsProfile_Database.GetConnection()
    Private changesMade As Boolean = False
    Private Sub btnSavePassword_Click(sender As Object, e As EventArgs) Handles btnSavePassword.Click
        SaveChangesToDatabase()
    End Sub

    Private Sub SaveChangesToDatabase()
        Try
            connection.Open()

            Dim loginID As String = LoginF.adminID
            Dim employeeQuery As String = "SELECT Employee_Number, Employee_Password FROM Employee_Profile WHERE Employee_Number = @EmployeeNumber"
            Dim employeeCmd As New OleDbCommand(employeeQuery, connection)
            employeeCmd.Parameters.AddWithValue("@EmployeeNumber", loginID)
            Dim employeeReader As OleDbDataReader = employeeCmd.ExecuteReader()

            If employeeReader.Read() Then

                Dim password As String = employeeReader("Employee_Password").ToString()

                If txtOldPassword.Text = password Then

                    If txtNewPassword.Text = txtConfirmPassword.Text Then

                        Try

                            Dim updateQuery As String = "UPDATE Employee_Profile SET Employee_Password = @Password WHERE Employee_Number = @EmployeeNumber"
                            Dim updateCmd As New OleDbCommand(updateQuery, connection)
                            updateCmd.Parameters.AddWithValue("@Password", txtConfirmPassword.Text)
                            updateCmd.Parameters.AddWithValue("@EmployeeNumber", LoginF.adminID)

                            updateCmd.ExecuteNonQuery()

                            changesMade = False

                            MessageBox.Show("Password saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Catch ex As Exception
                            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try

                        Me.Close()
                    ElseIf txtNewPassword.Text = "" Or txtConfirmPassword.Text = "" Then
                        MessageBox.Show("Please fill in the necessary details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show("New and Confirm password does not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                ElseIf txtOldPassword.Text = "" Then
                    MessageBox.Show("Please input your old password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Old password is incorrect. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

            employeeReader.Close()

        Catch ex As Exception
            MessageBox.Show($"Error(EmployeeF_Load): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Private Sub btnCancelCP_Click(sender As Object, e As EventArgs)
        Close
    End Sub
    Private Sub picboxNPShow_Click(sender As Object, e As EventArgs) Handles picboxNPShow.Click
        txtNewPassword.UseSystemPasswordChar = False
        picboxNPShow.Visible = False
        picboxNPHide.Visible = True
    End Sub
    Private Sub picboxNPHide_Click(sender As Object, e As EventArgs) Handles picboxNPHide.Click
        txtNewPassword.UseSystemPasswordChar = True
        picboxNPShow.Visible = True
        picboxNPHide.Visible = False
    End Sub

    Private Sub picboxCPShow_Click(sender As Object, e As EventArgs) Handles picboxCPShow.Click
        txtConfirmPassword.UseSystemPasswordChar = False
        picboxCPShow.Visible = False
        picboxCPHide.Visible = True
    End Sub

    Private Sub picboxCPHide_Click(sender As Object, e As EventArgs) Handles picboxCPHide.Click
        txtConfirmPassword.UseSystemPasswordChar = True
        picboxCPShow.Visible = True
        picboxCPHide.Visible = False
    End Sub
    Private Sub txtConfirmPassword_GotFocus(sender As Object, e As EventArgs) Handles txtConfirmPassword.GotFocus
        picboxNPShow.Visible = False
        picboxNPHide.Visible = False
        txtNewPassword.UseSystemPasswordChar = True
    End Sub
    Private Sub txtNewPassword_GotFocus(sender As Object, e As EventArgs) Handles txtNewPassword.GotFocus
        If txtConfirmPassword.Text = "" Then
            picboxNPShow.Visible = True
            picboxNPHide.Visible = False
        ElseIf txtConfirmPassword.Text IsNot "" Then
            picboxNPShow.Visible = False
            picboxNPHide.Visible = False
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
    End Sub
End Class