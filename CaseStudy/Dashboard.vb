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
            Dim query As String = "SELECT * From Booking WHERE Username = @Username" 'Finds EVERY SAME USERNAME(UNIQUE ID)
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Username", "Justine")
            Dim adapter As New SqlDataAdapter(cmd) 'CONNECTION TO ADAPTERS
            Dim table As New DataTable() 'CREATES A TABLE OUT OF THE DATABASE
            DGLogs.DataSource = table 'LOADS THE TABLE WITH THE DATASOURCE
            adapter.Fill(table)
            DGLogs.DataSource = table
        Catch ex As Exception
            MessageBox.Show($"Error Loading Logs: {ex.Message}") 'ERROR MESSAGE IF UNEXPECTED VARIABLE HAPPEN
        End Try
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'DASHBOARD LOADER
        lblgreet.Text = "Hello, " & loginForm.txtuser.Text & " Welcome to Rent 4 Wheelz" 'WAS A TEST BUT OUTLINE FOR WELCOME PROMPT
        LoadLogs() 'LOADS FUNCTION
        con.Open() 'ESTABLISHES CONNECTION
        Dim query As String = "SELECT Username, Email, Fullname, Age, Sex, Address, Date FROM login WHERE Username = @Username" 'CONDITION PROMPT ON WHAT TO SELECT FROM THE DATA BASE
        Dim cmd As New SqlCommand(query, con) 'SEE BACK ON LOGIN FORM
        cmd.Parameters.AddWithValue("@Username", loginForm.txtuser.Text)
        Dim myReader As SqlDataReader = cmd.ExecuteReader() 'MAKES A SQL READER IN ORDER TO READ THE DATA THAT'S IN THE DATA BASE
        If myReader.HasRows Then 'CHECKS IF THE USERNAME/ROW HAS A DATA
            myReader.Read() 'EXECUTES READ COMMAND
            lblFullName.Text = myReader("Fullname").ToString() 'PLACES THE VARIABLES TO THE LABELS
            lblAge.Text = myReader("Age").ToString()
            lblSex.Text = myReader("Sex").ToString()
            lblAddress.Text = myReader("Address").ToString()
            lblDOB.Text = myReader("Date").ToString()
            lblEmail.Text = myReader("Email").ToString
        End If
        con.Close() 'CLOSES THE CONNECTION

    End Sub
    Private Function Checker() As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Booking WHERE CarID = @CarID AND Username <> @Username AND StartBookDate <= @NewEndDate AND EndBookDate >= @NewStartDate"
        Using cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@CarID", DGLogs.CurrentRow.Cells("CarID").Value)
            cmd.Parameters.AddWithValue("@Username", DGLogs.CurrentRow.Cells("Username").Value)
            cmd.Parameters.AddWithValue("@NewStartDate", FromDOB.Value.Date)
            cmd.Parameters.AddWithValue("@NewEndDate", ToDOB.Value.Date)

            con.Open()
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            con.Close()

            If count > 0 Then
                MessageBox.Show("Schedule to This Had Been Booked", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
        End Using

        Return True
    End Function
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If ToDOB.Value.Date <= FromDOB.Value.Date Then
            MessageBox.Show("End date must be later than start date.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If DGLogs.SelectedRows.Count = 0 Then
            MessageBox.Show("Select A Row From The Left Empty Space that you wanna Update", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If
        If Not Checker() Then Exit Sub
        Try
            Dim BookingID As Integer = Convert.ToInt32(DGLogs.CurrentRow.Cells("BookingID").Value)
            Dim query As String = "UPDATE Booking SET StartBookDate = @FromDate, EndBookDate = @ToDate WHERE BookingID = @BookingID"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@FromDate", FromDOB.Value)
            cmd.Parameters.AddWithValue("@ToDate", ToDOB.Value)
            cmd.Parameters.AddWithValue("@BookingID", BookingID)
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Date Successfully Updated", "Info")
            ResetClock()
            LoadLogs()
        Catch ex As Exception
            MessageBox.Show($"Error Updating Logs: {ex.Message}")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BookingForm.Show()
        Me.Hide()
    End Sub

    Private Sub DGLogs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGLogs.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DGLogs.Rows(e.RowIndex)
            FromDOB.Value = Convert.ToDateTime(row.Cells("StartBookDate").Value)
            ToDOB.Value = Convert.ToDateTime(row.Cells("EndBookDate").Value)
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If DGLogs.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.")
            Exit Sub
        End If
        Dim CarId As Integer = Convert.ToInt32(DGLogs.CurrentRow.Cells("CarId").Value)
        Dim Username As String = DGLogs.CurrentRow.Cells("Username").Value.ToString()
        Try
            Dim query As String = "DELETE FROM Booking WHERE CarID = @CarID AND Username = @Username"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@CarID", CarId)
            cmd.Parameters.AddWithValue("@Username", Username)

            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Log Deleted Successfully")
            LoadLogs()
        Catch ex As Exception
            MessageBox.Show($"Error Deleting Logs: {ex.Message}")
        Finally
            con.Close()
        End Try
    End Sub
End Class