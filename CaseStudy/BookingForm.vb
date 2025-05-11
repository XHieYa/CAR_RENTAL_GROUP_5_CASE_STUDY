Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel 'From StyleBackground from DataGrid
Imports Microsoft.Data.SqlClient 'Importing SQL Database Access Commands
Public Class BookingForm
    'SQL Conenction
    Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CaseStudy;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")
    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        'Checks if both dates are equal or reversed
        If ToDOB.Value.Date <= FromDOB.Value.Date Then
            MessageBox.Show("Not Equal to Each Other Nor The ToDate must be higher than From", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            'Checks if schedule thats gonna be input is not between existing dates and divided to by Unique CarID
            Dim query As String = "SELECT COUNT(*) FROM Booking WHERE CarID = @CarID AND @NewStartDate <= EndBookDate AND @NewEndDate >= StartBookDate"
            con.Open()
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@CarID", TxtCarID.Text)
                cmd.Parameters.AddWithValue("@NewStartDate", FromDOB.Value.Date)
                cmd.Parameters.AddWithValue("@NewEndDate", ToDOB.Value.Date)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("Schedule to This Has Been Booked", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                con.Close()
                Return
            End If
            'Shows Payment Slip
            PaymentDetailSlip.Show()
            Me.Hide()
            con.Close()
        End If
    End Sub
    'Loads The Whole Column
    Private Sub ColumnLoader()
        DGVSchedules.Columns.Clear()
        'The first part which is the car Name
        DGVSchedules.Columns.Add("CarName", "Car Name")
        DGVSchedules.Columns("CarName").Width = 180
        Dim daysInMonth As Integer = DateTime.DaysInMonth(MnthC.SelectionStart.Year, MnthC.SelectionStart.Month)
        'loops to make the full calendar days
        For i = 1 To daysInMonth
            DGVSchedules.Columns.Add(i.ToString(), i.ToString())
        Next
        'loops to make the cells fill
        For Each column As DataGridViewColumn In DGVSchedules.Columns
            'condition that the first column CarName will not affected by fill
            If column.Name <> "CarName" Then
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End If
        Next
    End Sub
    'Loads the Rows AKA the car lists
    Private Sub RowLoader()
        DGVSchedules.Rows.Clear()
        'Loads DISTINCT CarID and CARNAME so it will iterate as one line when you seek through days
        Dim query As String = "SELECT DISTINCT CarID, CarName FROM Booking ORDER BY CarID"
        con.Open()
        Dim cmd As New SqlCommand(query, con)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        'SQL data reader call above used before in dashboard please refer there instead but in a loop form
        While reader.Read()
            Dim carName As String = reader("CarName").ToString()
            Dim row As Integer = DGVSchedules.Rows.Add()
            'Literally adds the carname within the cells in the column
            DGVSchedules.Rows(row).Cells("CarName").Value = carName
        End While
        con.Close()
    End Sub
    'calls out 3 functions that updates the datagrid when Month Calendar is changed/Moved
    Private Sub MnthC_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MnthC.DateChanged
        ColumnLoader()
        RowLoader()
        ScheduleShower()
    End Sub
    Private Sub ScheduleShower()
        'Setting up objects
        Dim selectedMonth As DateTime = New DateTime(MnthC.SelectionStart.Year, MnthC.SelectionStart.Month, 1)
        Dim startOfMonth As DateTime = selectedMonth
        Dim endOfMonth As DateTime = selectedMonth.AddMonths(1).AddDays(-1)
        'query on what should SQL Do or Compare
        Dim query As String = "SELECT CarID, CarName, StartBookDate, EndBookDate FROM Booking WHERE StartBookDate <= @EndOfMonth AND EndBookDate >= @StartOfMonth"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@StartOfMonth", startOfMonth)
        cmd.Parameters.AddWithValue("@EndOfMonth", endOfMonth)
        con.Open()
        Dim Carreader As SqlDataReader = cmd.ExecuteReader()
        'makes sure that each cells are color white
        For Each row As DataGridViewRow In DGVSchedules.Rows
            For Each cell As DataGridViewCell In row.Cells
                cell.Style.BackColor = Color.White
            Next
        Next
        'SQL reader initialized/Start
        While Carreader.Read()
            'Gets each items specified to the reader
            Dim carName As String = Carreader.GetString(1)
            Dim startDate As DateTime = Carreader.GetDateTime(2)
            Dim endDate As DateTime = Carreader.GetDateTime(3)
            Dim currentDate As DateTime = startDate
            'sets a loop while
            While currentDate <= endDate
                'compares the month and year from the selected month and year from the Month Calendar
                If currentDate.Month = startOfMonth.Month And currentDate.Year = startOfMonth.Year Then
                    Dim column As Integer = currentDate.Day
                    Dim rowIndex As Integer = -1
                    'finds the column value and compares it to carname and assign the index of the row that will be modified
                    For i As Integer = 0 To DGVSchedules.Rows.Count - 1
                        If DGVSchedules.Rows(i).Cells(0).Value IsNot Nothing AndAlso DGVSchedules.Rows(i).Cells(0).Value.ToString().ToLower() = carName.ToLower() Then
                            rowIndex = i
                            Exit For
                        End If
                    Next
                    'checks if it has the same index and column and column count that will be painted red for the schedule
                    If rowIndex >= 0 AndAlso column >= 1 AndAlso column < DGVSchedules.ColumnCount Then
                        DGVSchedules.Rows(rowIndex).Cells(column).Style.BackColor = Color.Red
                    End If
                End If
                'iteration to add days count preventing inf loop
                currentDate = currentDate.AddDays(1)
            End While
        End While
        con.Close()
    End Sub
    'Actions called when the booking form load
    Private Sub BookingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColumnLoader()
        RowLoader()
        ScheduleShower()
    End Sub

    Private Sub BtnBackToSeater_Click(sender As Object, e As EventArgs) Handles BtnBackToSeater.Click
        Me.Hide()
        Seaters.Show()
    End Sub

  
End Class