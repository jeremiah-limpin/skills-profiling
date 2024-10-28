Imports ADODB
Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing
Imports System.Text
Imports System.Transactions
Public Class VerifyIDForm
    Dim connection As OleDbConnection = SkillsProfile_Database.GetConnection()
    Friend Shared verifyID As String
    Private Sub btnVerifyID_Click(sender As Object, e As EventArgs) Handles btnVerifyID.Click

        Try
            connection.Open()

            Dim employeeQuery = "SELECT Employee_Number, Employee_Password FROM Employee_Profile WHERE Employee_Number = @EmployeeNumber"
            Dim employeeCmd As New OleDbCommand(employeeQuery, connection)
            employeeCmd.Parameters.AddWithValue("@EmployeeNumber", txtVerifyID.Text)
            Dim employeeReader = employeeCmd.ExecuteReader

            If employeeReader.Read Then

                Dim employeeID = employeeReader("Employee_Number").ToString

                If txtVerifyID.Text = employeeID Then
                    Dim forgot As New ForgotPasswordForm
                    verifyID = txtVerifyID.Text
                    MessageBox.Show("Employee ID verified. You can now change your password", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    forgot.Show()
                    Hide()
                Else
                    MessageBox.Show("Employee ID not found. Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtVerifyID.Clear()
                End If
            Else
                MessageBox.Show("Employee ID not found. Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtVerifyID.Clear()
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

    Private Sub txtVerifyID_GotFocus(sender As Object, e As EventArgs) Handles txtVerifyID.GotFocus
        lblTip.Visible = True
        If txtVerifyID.Text = "" Or String.IsNullOrWhiteSpace(txtVerifyID.Text) Then
            txtVerifyID.Text = ""
            txtVerifyID.ForeColor = Color.Black
        ElseIf txtVerifyID.Text = "Employee ID" Then
            txtVerifyID.Text = ""
            txtVerifyID.ForeColor = Color.Black
        Else

        End If
    End Sub

    Private Sub txtVerifyID_LostFocus(sender As Object, e As EventArgs) Handles txtVerifyID.LostFocus
        lblTip.Visible = False
        If txtVerifyID.Text = "" Or String.IsNullOrWhiteSpace(txtVerifyID.Text) Then
            txtVerifyID.Text = "Employee ID"
            txtVerifyID.ForeColor = Color.DarkGray
        Else

        End If
    End Sub
    Private Sub picboxLoginBack_Click(sender As Object, e As EventArgs) Handles picboxLoginBack.Click
        LoginF.Show()
        Hide()
    End Sub
    Private Sub lblLogin_Click(sender As Object, e As EventArgs)
        LoginF.Show
        Hide
    End Sub
End Class