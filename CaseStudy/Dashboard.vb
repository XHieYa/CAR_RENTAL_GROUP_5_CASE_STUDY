Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports Microsoft.Data.SqlClient 'Importing SQL Database Access Commands
Public Class Dashboard
    'variable sets
    Dim Discount As Integer
    Dim DriverFee As Integer
    Dim totalpay As Double
    'Connection to SQL
    Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CaseStudy;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False") 'SQL Connection
    'Function to Reset time Back to Original state
    Private Sub ResetClock()
        FromDOB.Value = DateTime.Now
        ToDOB.Value = DateTime.Now
    End Sub
    'Function to load data within the database
    Private Sub LoadLogs()
        Try
            'Finds EVERY SAME USERNAME(UNIQUE ID)
            Dim query As String = "SELECT * From Booking WHERE Username = @Username"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Username", loginForm.txtuser.Text)
            'CONNECTION TO ADAPTERS
            Dim adapter As New SqlDataAdapter(cmd)
            'CREATES A TABLE OUT OF THE DATABASE
            Dim table As New DataTable()
            'LOADS THE TABLE WITH THE DATASOURCE
            DGLogs.DataSource = table
            adapter.Fill(table)
            DGLogs.DataSource = table
        Catch ex As Exception
            'ERROR MESSAGE IF UNEXPECTED VARIABLE HAPPEN
            MessageBox.Show($"Error Loading Logs: {ex.Message}")
        End Try
    End Sub
    'DASHBOARD LOADER
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'WAS A TEST BUT OUTLINE FOR WELCOME PROMPT
        lblgreet.Text = "Hello, " & loginForm.txtuser.Text & " Welcome to Wheel-Away! Let's get you on the road."
        'LOADS FUNCTION
        LoadLogs()
        'ESTABLISHES CONNECTION
        con.Open()
        'CONDITION PROMPT ON WHAT TO SELECT FROM THE DATA BASE
        Dim query As String = "SELECT Username, Email, Fullname, Age, Sex, Address, Date, Records FROM login WHERE Username = @Username"
        'SEE BACK ON LOGIN FORM
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@Username", loginForm.txtuser.Text)
        'MAKES A SQL READER IN ORDER TO READ THE DATA THAT'S IN THE DATA BASE
        Dim myReader As SqlDataReader = cmd.ExecuteReader()
        'CHECKS IF THE USERNAME/ROW HAS A DATA
        If myReader.HasRows Then
            'EXECUTES READ COMMAND
            myReader.Read()
            'PLACES THE VARIABLES TO THE LABELS
            lblFullName.Text = myReader("Fullname").ToString()
            lblAge.Text = myReader("Age").ToString()
            lblSex.Text = myReader("Sex").ToString()
            lblAddress.Text = myReader("Address").ToString()
            lblDOB.Text = myReader("Date").ToString()
            lblEmail.Text = myReader("Email").ToString
            lblRecord.Text = myReader("Records").ToString
        End If
        'CLOSES THE CONNECTION
        con.Close()
        CheckBookingDates()
    End Sub
    ' Get the current booking details for the selected row
    Private Sub CheckBookingDates()
        If dgLogs.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgLogs.SelectedRows(0)
            Dim currentFromDate As DateTime = Convert.ToDateTime(row.Cells("StartBookDate").Value)
            Dim currentToDate As DateTime = Convert.ToDateTime(row.Cells("EndBookDate").Value)
            ' If both FromDOB and ToDOB are in the past, disable FromDOB and allow only ToDOB to be changed
            If currentFromDate < DateTime.Now AndAlso currentToDate < DateTime.Now Then
                FromDOB.Enabled = False
                ' Allow modification of ToDOB (but check if it's before current date)
                If ToDOB.Value.Date < DateTime.Now.Date Then
                    ToDOB.Enabled = False
                Else
                    ToDOB.Enabled = True
                End If
            Else
                ' If the booking is in the future, allow both FromDOB and ToDOB to be modified
                FromDOB.Enabled = True
                ToDOB.Enabled = True
            End If
        End If
    End Sub
    'Function that checks if there was a booking that is already existing
    Private Function Checker() As Boolean
        'query for the SQL on what it should do
        Dim query As String = "SELECT COUNT(*) FROM Booking WHERE CarID = @CarID AND Username = @Username AND BookingID <> @BookingID AND StartBookDate <= @NewEndDate AND EndBookDate >= @NewStartDate"
        Using cmd As New SqlCommand(query, con)
            'sets the parameters and objects to be compared to the SQL and most of it are from Value Date or Selected row of a data grid viewer
            cmd.Parameters.AddWithValue("@CarID", DGLogs.CurrentRow.Cells("CarID").Value)
            cmd.Parameters.AddWithValue("@Username", DGLogs.CurrentRow.Cells("Username").Value)
            cmd.Parameters.AddWithValue("@BookingID", DGLogs.CurrentRow.Cells("BookingID").Value)
            cmd.Parameters.AddWithValue("@NewStartDate", FromDOB.Value.Date)
            cmd.Parameters.AddWithValue("@NewEndDate", ToDOB.Value.Date)

            con.Open()
            'gets the current count that is on the SQL Iteration
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            con.Close()
            'if count is already existing then schedule is taken
            If count > 0 Then
                MessageBox.Show("Schedule for this car and date is already booked.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            'terminates using and return that there's no date exisitng for this
        End Using
        Return True
    End Function
    'calculations to update if the user changed the time and re calculates their total
    Private Sub CarPay()
        Dim TotalDays As Integer = (ToDOB.Value.Date - FromDOB.Value.Date).Days
        Dim query As String = "SELECT Rate, WDriver FROM Booking WHERE BookingID = @BookingID AND CarID = @CarID AND Username = @Username"
        Dim rate As Decimal = 0
        Dim driver As String = ""
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@CarID", DGLogs.CurrentRow.Cells("CarID").Value)
        cmd.Parameters.AddWithValue("@Username", DGLogs.CurrentRow.Cells("Username").Value)
        cmd.Parameters.AddWithValue("@BookingID", DGLogs.CurrentRow.Cells("BookingID").Value)
        con.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            rate = Convert.ToDecimal(reader("Rate"))
            driver = reader("WDriver").ToString()
        End If
        con.Close()

        If driver = "Yes" Then
            DriverFee = 1000
            If TotalDays >= 1 And TotalDays <= 6 Then
                Discount = 0
            ElseIf TotalDays >= 7 And TotalDays <= 13 Then
                Discount = 500
            ElseIf TotalDays >= 14 And TotalDays <= 29 Then
                Discount = 1000
            ElseIf TotalDays >= 30 Then
                Discount = 1400
            Else
                Discount = 0
                DriverFee = 0
            End If
            totalpay = (rate * TotalDays) - Discount + DriverFee
        ElseIf driver = "No" Then
            DriverFee = 0
            If TotalDays >= 1 And TotalDays <= 6 Then
                Discount = 0
            ElseIf TotalDays >= 7 And TotalDays <= 13 Then
                Discount = 500
            ElseIf TotalDays >= 14 And TotalDays <= 29 Then
                Discount = 1000
            ElseIf TotalDays >= 30 Then
                Discount = 1400
            Else
                Discount = 0
            End If
            totalpay = (rate * TotalDays) - Discount
        End If
    End Sub
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        'Checks if both Date and time value are the same
        If ToDOB.Value.Date <= FromDOB.Value.Date Then
            MessageBox.Show("The end date must be after the start date.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'check if user selected a row
        If DGLogs.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a row to update.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If Not Checker() Then Exit Sub
        Try
            'loads calculations
            CarPay()
            'gets the item from the selected row cell
            Dim BookingID = Convert.ToInt32(dgLogs.CurrentRow.Cells("BookingID").Value)
            'SQL query
            Dim query = "UPDATE Booking SET StartBookDate = @FromDate, EndBookDate = @ToDate, Price = @Price WHERE BookingID = @BookingID"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@FromDate", FromDOB.Value)
                cmd.Parameters.AddWithValue("@ToDate", ToDOB.Value)
                cmd.Parameters.AddWithValue("@BookingID", BookingID)
                cmd.Parameters.AddWithValue("@Price", totalpay)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
            MessageBox.Show("Date successfully updated.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CalendarChecker.Close()
            ResetClock()
            LoadLogs()
        Catch ex As Exception
            MessageBox.Show($"Error updating schedule: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Seaters.Close()
        Seaters.Show()
        Hide()
    End Sub
    'Cell selection that updates the current selected row of date and time From and To
    Private Sub DGLogs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgLogs.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgLogs.Rows(e.RowIndex)
            Dim currentFromDate As DateTime = Convert.ToDateTime(row.Cells("StartBookDate").Value)
            Dim currentToDate As DateTime = Convert.ToDateTime(row.Cells("EndBookDate").Value)
            ' If both FromDOB and ToDOB are in the past, disable FromDOB and allow only ToDOB to be changed
            If currentFromDate < DateTime.Now OrElse currentToDate < DateTime.Now Then
                FromDOB.Enabled = False
                ' Allow modification of ToDOB (but check if it's before current date)
                If currentToDate < DateTime.Now.Date Then
                    ToDOB.Enabled = False
                Else
                    ToDOB.Enabled = True
                End If
            Else
                ' If the booking is in the future, allow both FromDOB and ToDOB to be modified
                FromDOB.Enabled = True
                ToDOB.Enabled = True
            End If
        End If
    End Sub
    'Deletes log it has query and the selection where it compares the Username,CarID and Booking ID for a perfect log deletion
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If DGLogs.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.")
            Exit Sub
        End If
        Dim CarId As Integer = Convert.ToInt32(DGLogs.CurrentRow.Cells("CarId").Value)
        Dim BookingID As Integer = Convert.ToInt32(DGLogs.CurrentRow.Cells("BookingID").Value)
        Dim Username As String = DGLogs.CurrentRow.Cells("Username").Value.ToString()
        Try
            Dim query As String = "DELETE FROM Booking WHERE CarID = @CarID AND Username = @Username AND BookingID = @BookingID"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@BookingID", BookingID)
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
    'Just calculates this came from the Update Button and the calculation with added message box
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If ToDOB.Value.Date <= FromDOB.Value.Date Then
            MessageBox.Show("The end date must be after the start date.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If DGLogs.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a row to update.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If Not Checker() Then Exit Sub
        CarPay()
        MessageBox.Show("Your New Total Will be " & totalpay, "Info")
    End Sub

    Private Sub BtnSchedCheck_Click(sender As Object, e As EventArgs) Handles BtnSchedCheck.Click
        CalendarChecker.Close()
        CalendarChecker.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        FrontPage.Show()
        loginForm.txtuser.Text = String.Empty
        loginForm.txtpass.Text = String.Empty
    End Sub
End Class