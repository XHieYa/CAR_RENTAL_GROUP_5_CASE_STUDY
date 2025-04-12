Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.Data.SqlClient 'Importing SQL Database Access Commands
Public Class Form1
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
            MessageBox.Show("Login Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information) 'Will be key to transfering to next Form
            Me.Hide()
            Form2.Show()
        Else
            MessageBox.Show("Login Error") 'Error Message if account is not existing

        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox2.Enabled = False 'When the form load only login and sign up will be used
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked 'if Create account is clicked disable login enable sign-up
        GroupBox2.Enabled = True
        GroupBox1.Enabled = False
    End Sub
    Private Sub BtnSignIn_Click(sender As Object, e As EventArgs) Handles BtnSignIn.Click 'Sign in button Functions
        For Each item As Control In GroupBox2.Controls 'Checks if every Box Is accounted for
            If (TypeOf item Is TextBox) Then
                If (item.Text = "") Then
                    MessageBox.Show("All Fields Must be Filled up", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information) 'Error message if things are not field up
                    Return
                End If
            End If
        Next
        Dim username As String = siusername.Text 'for username checker turns siusername to username variable
        If UsernameExists(username) Then 'uses the UsernameExists Function mentioned above
            MessageBox.Show("Username already exists. Use Another Username", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information) 'Error Message if Username is Already Existing
        Else
            Try
                Dim query As String = "Insert Into login (Username, Fullname, Password, Age, Sex, Address, Date) VALUES (@Username, @Fullname, @Password, @Age, @Sex, @Address, @Date)" 'Basically putting the value on their own cells for the database
                Dim command As New SqlCommand(query, con) 'Individually setting the values and using parameters to be input to their cells
                command.Parameters.AddWithValue("@Username", siusername.Text)
                command.Parameters.AddWithValue("@Fullname", sifullname.Text)
                command.Parameters.AddWithValue("@Password", sipassword.Text)
                command.Parameters.AddWithValue("@Age", siage.Text)
                command.Parameters.AddWithValue("@Sex", Cmbsex.SelectedItem.ToString())
                command.Parameters.AddWithValue("@Address", siaddress.Text)
                command.Parameters.AddWithValue("@Date", DateTimePickerDOB.Value.Date)
                con.Open()
                command.ExecuteNonQuery() 'Used to create or change data within the database
                MessageBox.Show("Successfuly Registered Please Log-in", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information) 'Message confirming your info has been saved
            Catch ex As Exception
                MessageBox.Show($"Error adding account: {ex.Message} ") 'Error message if smthng happen within the server
            Finally
                siusername.Text = "" 'clears sign in for privacy
                sifullname.Text = ""
                siage.Text = ""
                sipassword.Text = ""
                siaddress.Text = ""
                Cmbsex.Items.Clear()
                DateTimePickerDOB.Value = Now
                GroupBox2.Enabled = False 'Makes you relogin to ensure you created the account and it works succesfully
                GroupBox1.Enabled = True
                con.Close()
            End Try
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged 'Just a simple show password
        If CheckBox1.Checked = True Then
            txtpass.PasswordChar = ""
        Else
            txtpass.PasswordChar = "*"
        End If
    End Sub
    Private Sub siage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles siage.KeyPress 'make sure only numbers are held
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class