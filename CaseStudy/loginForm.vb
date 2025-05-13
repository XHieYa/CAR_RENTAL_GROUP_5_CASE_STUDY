Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.Data.SqlClient 'Importing SQL Database Access Commands
Public Class loginForm
    Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CaseStudy;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False") 'connection to SQL SERVER
    'Function to check and make the Username Unique
    Private Function UsernameExists(username) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM login WHERE Username = @Username"
        Try
            con.Open() 'Open Connection to SQL
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Username", username)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
            Return False
        Finally

            con.Close() 'Closes Connection to SQL
        End Try
    End Function
    'Login Button
    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        'If admin on user and password were entered admin form will be open else they go to dashboard
        If txtuser.Text = "admin" And txtpass.Text = "admin" Then
            Hide()
            AdminForm.Show()
        Else
            con.Open()
            'Check Database for the matching Password and Username
            Dim query = "SELECT COUNT(*) FROM login WHERE username=@username AND password=@password"
            Dim cmd As New SqlCommand(query, con)
            'Both adds Value to @Variables to be checked or compared as Boolean
            cmd.Parameters.AddWithValue("@username", txtuser.Text)
            cmd.Parameters.AddWithValue("@password", txtpass.Text)
            Dim count As Integer = Convert.ToInt64(cmd.ExecuteScalar)
            con.Close()
            If count > 0 Then
                MessageBox.Show("Login Successfully", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbShowPassLI.Checked = False
                Hide()
                Dashboard.Close()
                Dashboard.Show()
            Else
                MessageBox.Show("Login Error") 'Error Message if account is not existing

            End If
        End If
    End Sub
    'When the form load only login and sign up will be used
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox2.Enabled = False
        dtpDOB.Value = Now
    End Sub
    'When the link label is clicked then sign up will be enabled and login will be disabled
    Private Sub llblCreateAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblCreateAccount.LinkClicked 'if Create account is clicked disable login enable sign-up
        GroupBox2.Enabled = True
        GroupBox1.Enabled = False
        txtuser.Text = String.Empty
        txtpass.Text = String.Empty
    End Sub
    'Sign in button sub
    Private Sub BtnSignIn_Click(sender As Object, e As EventArgs) Handles BtnSignIn.Click
        ' Automatically update txtAge based on the selected date of birth
        Dim DateNow As DateTime = dtpDOB.Value.Date
        Dim age As Integer = AgeaCalculator(DateNow)
        txtAge.Text = age.ToString()
        ' Checks if every Box Is accounted for
        For Each item As Control In GroupBox2.Controls
            If (TypeOf item Is TextBox) Then
                If (item.Text = "") Then
                    ' Error message if things are not filled up
                    MessageBox.Show("All Fields Must be Filled up", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
            End If
        Next
        ' Validate that the age in txtAge matches the calculated age
        If Not Integer.TryParse(txtAge.Text, age) OrElse age <> AgeaCalculator(DateNow) Then
            MessageBox.Show("The entered age does not match the selected date of birth.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ' Validate Email using StringBuilder for custom email validation
        Dim sb As New Text.StringBuilder(txtEmail.Text)
        If Not sb.ToString().Contains("@") OrElse Not sb.ToString().EndsWith(".com") Then
            MessageBox.Show("Please enter a valid email address (must contain '@' and end with '.com').", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ' For username checker turns siusername to username variable
        Dim username As String = txtUsername.Text
        ' Uses the UsernameExists Function mentioned above
        If UsernameExists(username) Then
            ' Error Message if Username is Already Existing
            MessageBox.Show("Username already exists. Use Another Username", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                ' Individually setting the values and using parameters to be input to their cells
                Dim query As String = "Insert Into login (Username, Email, Fullname, Password, Age, Sex, Address, Date) VALUES (@Username,@Email, @Fullname, @Password, @Age, @Sex, @Address, @Date)" ' Basically putting the value on their own cells for the database
                Dim command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@Username", txtUsername.Text)
                command.Parameters.AddWithValue("@Email", txtEmail.Text)
                command.Parameters.AddWithValue("@Fullname", txtFullName.Text)
                command.Parameters.AddWithValue("@Password", txtPassword.Text)
                command.Parameters.AddWithValue("@Age", txtAge.Text)
                command.Parameters.AddWithValue("@Sex", cmbSex.SelectedItem.ToString())
                command.Parameters.AddWithValue("@Address", txtAddress.Text)
                command.Parameters.AddWithValue("@Date", DateOnly.FromDateTime(dtpDOB.Value.Date))
                con.Open()
                ' Used to create or change data within the database
                command.ExecuteNonQuery()
                ' Message confirming your info has been saved
                MessageBox.Show("Successfully Registered! Please Log-in", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                ' Error message if something happens within the server
                MessageBox.Show($"Error adding account: {ex.Message} ")
            Finally
                ' Clears sign-in for privacy
                txtUsername.Text = ""
                txtFullName.Text = ""
                txtAge.Text = ""
                txtPassword.Text = ""
                txtAddress.Text = ""
                txtEmail.Text = ""
                cmbSex.Items.Clear()
                dtpDOB.Value = Now
                ' Makes you re-login to ensure you created the account and it works successfully
                GroupBox2.Enabled = False
                GroupBox1.Enabled = True
                con.Close()
            End Try
        End If
    End Sub
    ' Function to calculate the age based on the date of birth
    Private Function AgeaCalculator(birthDate As DateTime) As Integer
        Dim today As DateTime = DateTime.Now
        Dim age As Integer = today.Year - birthDate.Year
        If today.Month < birthDate.Month Or (today.Month = birthDate.Month And today.Day < birthDate.Day) Then
            age -= 1
        End If
        Return age
    End Function
    'Just a simple show password
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPassLI.CheckedChanged
        If cbShowPassLI.Checked = True Then
            txtpass.PasswordChar = ""
        Else
            txtpass.PasswordChar = "●"
        End If
    End Sub
    Private Sub siage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress 'make sure only numbers are held
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    'clears sign in for privacy and enables login disables sign up
    Private Sub llblHaveAnAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblHaveAnAccount.LinkClicked
        txtUsername.Text = ""
        txtFullName.Text = ""
        txtAge.Text = ""
        txtPassword.Text = ""
        txtEmail.Text = ""
        txtAddress.Text = ""
        cmbSex.Items.Clear()
        dtpDOB.Value = Now
        GroupBox2.Enabled = False
        GroupBox1.Enabled = True
    End Sub
    'Just a simple show password
    Private Sub cbShowPasswordSI_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPasswordSI.CheckedChanged
        If cbShowPasswordSI.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "●"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        FrontPage.Show()
    End Sub
End Class