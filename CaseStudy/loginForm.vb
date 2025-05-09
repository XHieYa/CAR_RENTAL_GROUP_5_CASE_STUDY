Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.Data.SqlClient 'Importing SQL Database Access Commands
Public Class loginForm
    Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False") 'connection to SQL SERVER
    Private Function UsernameExists(username) As Boolean 'Function to make Username Unique
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
    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click 'Login Button
        con.Open()
        Dim query As String = "SELECT COUNT(*) FROM login WHERE username=@username AND password=@password" 'Check Database for the matching Password and Username
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@username", txtuser.Text) 'Both adds Value to @Variables to be checked or compared as Boolean
        cmd.Parameters.AddWithValue("@password", txtpass.Text)
        Dim count As Integer = Convert.ToInt64(cmd.ExecuteScalar)
        con.Close()

        If count > 0 Then
            If txtuser.Text = "admin" And txtpass.Text = "admin" Then
                Me.Hide()
                AdminForm.Show()
            Else
                MessageBox.Show("Login Successfully", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information) 'Will be key to transfering to next Form
                Me.Hide()
                Dashboard.Show()
            End If

        Else
            MessageBox.Show("Login Error") 'Error Message if account is not existing

        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox2.Enabled = False 'When the form load only login and sign up will be used
        dtpDOB.Value = Now
    End Sub
    Private Sub llblCreateAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblCreateAccount.LinkClicked 'if Create account is clicked disable login enable sign-up
        GroupBox2.Enabled = True
        GroupBox1.Enabled = False
    End Sub
    Private Sub BtnSignIn_Click(sender As Object, e As EventArgs) Handles BtnSignIn.Click 'Sign in button Functions
        For Each item As Control In GroupBox2.Controls 'Checks if every Box Is accounted for
            If (TypeOf item Is TextBox) Then
                If (item.Text = "") Then
                    MessageBox.Show("All Fields Must be Filled up", "info", MessageBoxButtons.OK, MessageBoxIcon.Information) 'Error message if things are not field up
                    Return
                End If
            End If
        Next
        Dim username As String = txtUsername.Text 'for username checker turns siusername to username variable
        If UsernameExists(username) Then 'uses the UsernameExists Function mentioned above
            MessageBox.Show("Username already exists. Use Another Username", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information) 'Error Message if Username is Already Existing
        Else
            Try
                Dim query As String = "Insert Into login (Username, Email, Fullname, Password, Age, Sex, Address, Date) VALUES (@Username,@Email, @Fullname, @Password, @Age, @Sex, @Address, @Date)" 'Basically putting the value on their own cells for the database
                Dim command As New SqlCommand(query, con) 'Individually setting the values and using parameters to be input to their cells
                command.Parameters.AddWithValue("@Username", txtUsername.Text)
                command.Parameters.AddWithValue("@Email", txtEmail.Text)
                command.Parameters.AddWithValue("@Fullname", txtFullName.Text)
                command.Parameters.AddWithValue("@Password", txtPassword.Text)
                command.Parameters.AddWithValue("@Age", txtAge.Text)
                command.Parameters.AddWithValue("@Sex", cmbSex.SelectedItem.ToString())
                command.Parameters.AddWithValue("@Address", txtAddress.Text)
                command.Parameters.AddWithValue("@Date", DateOnly.FromDateTime(dtpDOB.Value.Date))
                con.Open()
                command.ExecuteNonQuery() 'Used to create or change data within the database
                MessageBox.Show("Successfuly Registered Please Log-in", "info", MessageBoxButtons.OK, MessageBoxIcon.Information) 'Message confirming your info has been saved
            Catch ex As Exception
                MessageBox.Show($"Error adding account: {ex.Message} ") 'Error message if smthng happen within the server
            Finally
                txtUsername.Text = "" 'clears sign in for privacy
                txtFullName.Text = ""
                txtAge.Text = ""
                txtPassword.Text = ""
                txtAddress.Text = ""
                txtEmail.Text = ""
                cmbSex.Items.Clear()
                dtpDOB.Value = Now
                GroupBox2.Enabled = False 'Makes you relogin to ensure you created the account and it works succesfully
                GroupBox1.Enabled = True
                con.Close()
            End Try
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPassLI.CheckedChanged 'Just a simple show password
        If cbShowPassLI.Checked = True Then
            txtpass.PasswordChar = ""
        Else
            txtpass.PasswordChar = "*"
        End If
    End Sub
    Private Sub siage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress 'make sure only numbers are held
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub llblHaveAnAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblHaveAnAccount.LinkClicked
        txtUsername.Text = "" 'clears sign in for privacy
        txtFullName.Text = ""
        txtAge.Text = ""
        txtPassword.Text = ""
        txtEmail.Text = ""
        txtAddress.Text = ""
        cmbSex.Items.Clear()
        dtpDOB.Value = Now
        GroupBox2.Enabled = False 'Makes you relogin to ensure you created the account and it works succesfully
        GroupBox1.Enabled = True
    End Sub

    Private Sub cbShowPasswordSI_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPasswordSI.CheckedChanged 'same as the checkbox above
        If cbShowPasswordSI.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

End Class