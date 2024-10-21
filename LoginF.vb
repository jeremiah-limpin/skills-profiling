Imports System.Data.OleDb
Imports System.IO


Public Class LoginF
    Dim connection As OleDbConnection = SkillsProfile_Database.GetConnection()
    Dim loginAttempts As Integer = 0
    Const MAX_ATTEMPTS As Integer = 4
    Dim Display_Attempts As Integer = 3
    Dim employeeNumber As String
    Friend Shared adminID As String

#Region "Login Button"
    Public Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        adminID = txtEmployeeID.Text
        ' check if textboxes are empty
        If txtEmployeeID.Text = "" Or String.IsNullOrWhiteSpace(txtEmployeeID.Text) OrElse txtPassword.Text = "" Or String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please fill up the missing fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf txtEmployeeID.Text = "Employee ID" Or txtPassword.Text = "Password" Then
            MessageBox.Show("Please fill up the missing fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim employeeID = txtEmployeeID.Text
        Dim password = txtPassword.Text
        Dim employeeListForm As New EmployeeListF
        Dim employeeF As New EmployeeF
        Dim tempEmployeeNumber = txtEmployeeID.Text

        ' passing of Employee ID to EmployeeF
        employeeListForm.EmployeeID = txtEmployeeID.Text

        Try
            connection.Open()

            ' query to check username and password against the database with case-sensitive comparison
            Dim query = "SELECT * FROM Employee_Profile WHERE StrComp(Employee_Number, @EmployeeID, 0) = 0 AND StrComp(Employee_Password, @Password, 0) = 0"
            Dim cmd As New OleDbCommand(query, connection)
            cmd.Parameters.AddWithValue("@EmployeeID", employeeID)
            cmd.Parameters.AddWithValue("@Password", password)

            Dim reader = cmd.ExecuteReader

            If reader.Read Then
                ' successful login
                Dim employeeRole As Integer = reader("Employee_Role")
                Dim employeeNumber As String = reader("Employee_Number")
                Dim permission As Boolean = reader("Permission")
                Dim status As String = reader("Status")

                If permission = True Then

                    Select Case employeeRole
                        Case 4
                            ' super admin login
                            MessageBox.Show($"Welcome, " & employeeNumber & "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtEmployeeID.Focus()
                            txtEmployeeID.Clear()
                            txtPassword.Clear()


                            employeeListForm.Show()
                            Hide()

                            loginAttempts = 0

                        Case 3
                            ' admin login
                            MessageBox.Show($"Welcome, " & employeeNumber & "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtEmployeeID.Focus()
                            txtEmployeeID.Clear()
                            txtPassword.Clear()

                            employeeListForm.Show()
                            Hide()

                            loginAttempts = 0

                        Case 2
                            'test for only pdf and excel export
                            MessageBox.Show($"Welcome, " & employeeNumber & "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtEmployeeID.Focus()
                            txtEmployeeID.Clear()
                            txtPassword.Clear()


                            employeeListForm.Show()
                            Hide()

                        Case 1
                            ' user login
                            MessageBox.Show("Insufficient Role. Closing application. " & txtEmployeeID.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            Application.Exit()
                    End Select
                Else
                    Try
                        Dim attemptEmployeeNumber = txtEmployeeID.Text
                        Dim attemptDate = Date.Today.ToString("MM/dd/yyyy")
                        Dim description = "Unauthorized log-in attempt"

                        Dim attemptedAccessQuery = "INSERT INTO Attempted_Access (Employee_Number, Date_Attempt, Description) VALUES (@Employee_Number, @Date_Attempt, @Description)"
                        Dim attemptedAccessCmd As New OleDbCommand(attemptedAccessQuery, connection)
                        attemptedAccessCmd.Parameters.AddWithValue("@Employee_Number", attemptEmployeeNumber)
                        attemptedAccessCmd.Parameters.AddWithValue("@Date_Attempt", attemptDate)
                        attemptedAccessCmd.Parameters.AddWithValue("@Description", description)

                        attemptedAccessCmd.ExecuteNonQuery()

                    Catch ex As Exception
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                    MessageBox.Show("You do not have a permission to login." & Environment.NewLine & "Please request a permission.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtEmployeeID.Focus()
                    txtEmployeeID.Clear()
                    txtPassword.Clear()
                End If


            Else
                If EmployeeExists(employeeID) Then
                    ' failed attempt saved
                    Try
                        Dim attemptEmployeeNumber = txtEmployeeID.Text
                        Dim attemptDate = Date.Today.ToString("MM/dd/yyyy")
                        Dim description = "Failed log-in"

                        Dim attemptedAccessQuery = "INSERT INTO Attempted_Access (Employee_Number, Date_Attempt, Description) VALUES (@Employee_Number, @Date_Attempt, @Description)"
                        Dim attemptedAccessCmd As New OleDbCommand(attemptedAccessQuery, connection)
                        attemptedAccessCmd.Parameters.AddWithValue("@Employee_Number", attemptEmployeeNumber)
                        attemptedAccessCmd.Parameters.AddWithValue("@Date_Attempt", attemptDate)
                        attemptedAccessCmd.Parameters.AddWithValue("@Description", description)

                        attemptedAccessCmd.ExecuteNonQuery()

                    Catch ex As Exception
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                    MessageBox.Show("Incorrect ID or Password" & Environment.NewLine & "Please try again. Remaining attempts: " & Display_Attempts - loginAttempts, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    txtEmployeeID.Focus()
                    txtEmployeeID.Clear()
                    txtPassword.Clear()
                Else

                    MessageBox.Show("Incorrect ID or Password" & Environment.NewLine & "Please try again. Remaining attempts: " & Display_Attempts - loginAttempts, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtEmployeeID.Focus()
                    txtEmployeeID.Clear()
                    txtPassword.Clear()
                End If

                loginAttempts += 1

                ' check if maximum attempts reached
                If loginAttempts >= MAX_ATTEMPTS Then

                    Try

                        Dim permission = False

                        Dim loginQuery = "UPDATE Employee_Profile SET Permission = @Permission WHERE Employee_Number = @EmployeeNumber"
                        Dim permissionQuery As New OleDbCommand(loginQuery, connection)
                        permissionQuery.Parameters.AddWithValue("@Permission", permission)
                        permissionQuery.Parameters.AddWithValue("@EmployeeNumber", tempEmployeeNumber)

                        permissionQuery.ExecuteNonQuery()

                        Dim attemptEmployeeNumber = tempEmployeeNumber
                        Dim attemptDate = Date.Today.ToString("MM/dd/yyyy")
                        Dim description = "Revoked Permission"

                        Dim attemptedAccessQuery = "INSERT INTO Attempted_Access (Employee_Number, Date_Attempt, Description) VALUES (@Employee_Number, @Date_Attempt, @Description)"
                        Dim attemptedAccessCmd As New OleDbCommand(attemptedAccessQuery, connection)
                        attemptedAccessCmd.Parameters.AddWithValue("@Employee_Number", attemptEmployeeNumber)
                        attemptedAccessCmd.Parameters.AddWithValue("@Date_Attempt", attemptDate)
                        attemptedAccessCmd.Parameters.AddWithValue("@Description", description)

                        attemptedAccessCmd.ExecuteNonQuery()

                    Catch ex As Exception
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    MessageBox.Show("Maximum login attempts reached. Closing application." & txtEmployeeID.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Application.Exit()
                End If

            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Public Function EmployeeExists(employeeNumber As String) As Boolean
        Dim strSQL As String = "SELECT * FROM Employee_Profile WHERE StrComp(Employee_Number, @EmployeeNumber, 0) = 0"
        Dim cmd As New OleDbCommand(strSQL, connection)
        cmd.Parameters.AddWithValue("@EmployeeNumber", employeeNumber)

        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim exists As Boolean = reader.Read()

        reader.Close()

        Return exists
    End Function
#End Region
#Region "Textboxes"
#Region "EmployeeID Events"
    Private Sub txtEmployeeID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmployeeID.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnLogin.PerformClick()
        End If
    End Sub
    Private Sub txtEmployeeID_GotFocus(sender As Object, e As EventArgs) Handles txtEmployeeID.GotFocus
        lblTip.Visible = True
        If txtEmployeeID.Text = "" Or String.IsNullOrWhiteSpace(txtEmployeeID.Text) Then
            txtEmployeeID.Text = ""
            txtEmployeeID.ForeColor = Color.Black
        ElseIf txtEmployeeID.Text = "Employee ID" Then
            txtEmployeeID.Text = ""
            txtEmployeeID.ForeColor = Color.Black
        Else

        End If
    End Sub

    Private Sub txtEmployeeID_LostFocus(sender As Object, e As EventArgs) Handles txtEmployeeID.LostFocus
        lblTip.Visible = False
        If txtEmployeeID.Text = "" Or String.IsNullOrWhiteSpace(txtEmployeeID.Text) Then
            txtEmployeeID.Text = "Employee ID"
            txtEmployeeID.ForeColor = Color.DarkGray
        Else

        End If
    End Sub
#End Region
#Region "Password Events"
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnLogin.PerformClick()
        End If
    End Sub
    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        lblPasswordTip.Visible = True
        If txtPassword.Text = "" Or String.IsNullOrWhiteSpace(txtPassword.Text) Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Black
        ElseIf txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Black
        Else

        End If
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        lblPasswordTip.Visible = False
        If txtPassword.Text = "" Or String.IsNullOrWhiteSpace(txtPassword.Text) Then
            txtPassword.Text = "Password"
            txtPassword.ForeColor = Color.DarkGray
        Else

        End If
    End Sub

    Private Sub passwordCharTimer_Tick(sender As Object, e As EventArgs) Handles timerPassword.Tick
        txtPassword.UseSystemPasswordChar = False
        timerPassword.Stop()
    End Sub
#End Region
#Region "Show/Hide Password"
    Private picboxLoginPShow_Clicked As Boolean = False
    Private picboxLoginPHide_Clicked As Boolean = False
    Private Sub picboxLoginPShow_Click(sender As Object, e As EventArgs) Handles picboxLoginPShow.Click
        txtPassword.UseSystemPasswordChar = False
        picboxLoginPShow.Visible = False
        picboxLoginPHide.Visible = True
        picboxLoginPShow_Clicked = True
    End Sub
    Private Sub ShowClickMethod()
        picboxLoginPShow_Click(picboxLoginPShow, EventArgs.Empty)
    End Sub

    Private Sub picboxLoginPHide_Click(sender As Object, e As EventArgs) Handles picboxLoginPHide.Click
        txtPassword.UseSystemPasswordChar = True
        picboxLoginPShow.Visible = True
        picboxLoginPHide.Visible = False
    End Sub

    Private Sub HideClickMethod()
        picboxLoginPHide_Click(picboxLoginPHide, EventArgs.Empty)
    End Sub
#End Region
#Region "Forgot Password"
    Private Sub lklblForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklblForgotPassword.LinkClicked
        VerifyIDForm.Show()
        Hide()
    End Sub
#End Region
#End Region 'Username and Password Textboxes Events
#Region "LoginF Load and Close"
    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub


    Private Sub LoginF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        Label3.Select()
    End Sub
#End Region
End Class
