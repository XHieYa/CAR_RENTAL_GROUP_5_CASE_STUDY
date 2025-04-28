Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.Data.SqlClient 'Importing SQL Database Access Commands
Public Class Dashboard
    Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")

    Private Sub ResetClock()
        FromDOB.Value = DateTime.Now
        ToDOB.Value = DateTime.Now
    End Sub
    Private Sub LoadLogs()
        Try
            Dim query As String = "SELECT * From Schedule WHERE Username = @Username"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Username", loginForm.txtuser.Text)
            Dim adapter As New SqlDataAdapter(query, con)
            Dim table As New DataTable()
            DGLogs.DataSource = table
        Catch ex As Exception
            MessageBox.Show($"Error Loading Logs: {ex.Message}")
        End Try
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblgreet.Text = "Hello, " & loginForm.txtuser.Text & " Welcome to Rent 4 Wheelz"
        LoadLogs()
        con.Open()
        Dim query As String = "SELECT Username, Fullname, Age, Sex, Address, Date FROM login WHERE Username = @Username"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@Username", loginForm.txtuser.Text)
        Dim myReader As SqlDataReader = cmd.ExecuteReader()
        If myReader.HasRows Then
            myReader.Read()
            lblFullName.Text = "Full Name: " & myReader("Fullname").ToString()
            lblAge.Text = "Age: " & myReader("Age").ToString()
            lblSex.Text = "Sex: " & myReader("Sex").ToString()
            lblAddress.Text = "Address: " & myReader("Address").ToString()
            lblDOB.Text = "Date Of Birth: " & myReader("Date").ToString()
        End If
        con.Close()

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            Dim query As String = "UPDATE Schedule SET FromDate = @FromDate, ToDate = @ToDate WHERE TransNo = @TransNo"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@FromDate", FromDOB)
            cmd.Parameters.AddWithValue("@ToDate", ToDOB)
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Date Successfully Transfered", "Info")
            ResetClock()
            LoadLogs()
        Catch ex As Exception
            MessageBox.Show($"Error Updating Logs: {ex.Message}")
        End Try
    End Sub
End Class