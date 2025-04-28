Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.Data.SqlClient 'Importing SQL Database Access Commands
Public Class Dashboard
    Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False") 'SQL Connection

    Private Sub ResetClock() 'Function to Reset time Back to Original state
        FromDOB.Value = DateTime.Now
        ToDOB.Value = DateTime.Now
    End Sub
    Private Sub LoadLogs() 'Function to load data within the database (USE MS ACCESS HERE JUST CHANGE SQL TO MSACCESS FORM)
        Try
            Dim query As String = "SELECT * From Schedule WHERE Username = @Username" 'Finds EVERY SAME USERNAME(UNIQUE ID)
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Username", loginForm.txtuser.Text)
            Dim adapter As New SqlDataAdapter(query, con) 'CONNECTION TO ADAPTERS
            Dim table As New DataTable() 'CREATES A TABLE OUT OF THE DATABASE
            DGLogs.DataSource = table 'LOADS THE TABLE WITH THE DATASOURCE
        Catch ex As Exception
            MessageBox.Show($"Error Loading Logs: {ex.Message}") 'ERROR MESSAGE IF UNEXPECTED VARIABLE HAPPEN
        End Try
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'DASHBOARD LOADER
        lblgreet.Text = "Hello, " & loginForm.txtuser.Text & " Welcome to Rent 4 Wheelz" 'WAS A TEST BUT OUTLINE FOR WELCOME PROMPT
        LoadLogs() 'LOADS FUNCTION
        con.Open() 'ESTABLISHES CONNECTION
        Dim query As String = "SELECT Username, Fullname, Age, Sex, Address, Date FROM login WHERE Username = @Username" 'CONDITION PROMPT ON WHAT TO SELECT FROM THE DATA BASE
        Dim cmd As New SqlCommand(query, con) 'SEE BACK ON LOGIN FORM
        cmd.Parameters.AddWithValue("@Username", loginForm.txtuser.Text)
        Dim myReader As SqlDataReader = cmd.ExecuteReader() 'MAKES A SQL READER IN ORDER TO READ THE DATA THAT'S IN THE DATA BASE
        If myReader.HasRows Then 'CHECKS IF THE USERNAME/ROW HAS A DATA
            myReader.Read() 'EXECUTES READ COMMAND
            lblFullName.Text = "Full Name: " & myReader("Fullname").ToString() 'PLACES THE VARIABLES TO THE LABELS
            lblAge.Text = "Age: " & myReader("Age").ToString()
            lblSex.Text = "Sex: " & myReader("Sex").ToString()
            lblAddress.Text = "Address: " & myReader("Address").ToString()
            lblDOB.Text = "Date Of Birth: " & myReader("Date").ToString()
        End If
        con.Close() 'CLOSES THE CONNECTION

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click 'UPDATE BUTTON
        Try
            Dim query As String = "UPDATE Schedule SET FromDate = @FromDate, ToDate = @ToDate WHERE TransNo = @TransNo" 'SET PARAMETERS (MUST BE MS ACCESS/CHANGE SYNTAX TO MS ACCESS)
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@FromDate", FromDOB) 'DATES TO UPDATE
            cmd.Parameters.AddWithValue("@ToDate", ToDOB)
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Date Successfully Transfered", "Info") 'INFORMS THAT UPDATE WAS SUCCESSFUL
            ResetClock() 'USES FUNCTION TO CLEAR CLOCK
            LoadLogs() 'RELOADS FOR AN UPDATED LOG
        Catch ex As Exception
            MessageBox.Show($"Error Updating Logs: {ex.Message}") 'ERROR MESSAGE
        End Try
    End Sub
End Class