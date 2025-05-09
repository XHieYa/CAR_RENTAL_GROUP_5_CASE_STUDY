Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel 'From StyleBackground from DataGrid
Imports Microsoft.Data.SqlClient 'Importing SQL Database Access Commands
Public Class BookingForm
    Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomerDB;Integrated Security=True")
    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        If ToDOB.Value.Date <= FromDOB.Value.Date Then 'Checks if both dates are equal or reversed
            MessageBox.Show("Not Equal to Each Other Nor The ToDate must be higher than From", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            Dim query As String = "SELECT COUNT(*) FROM Booking WHERE CarID = @CarID AND @NewStartDate <= EndBookDate AND @NewEndDate >= StartBookDate" 'Checks if schedule thats gonna be input is not between existing dates and divided to by Unique CarID
            Con.Open()
            Using cmd As New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@CarID", TxtCarID.Text)
                cmd.Parameters.AddWithValue("@NewStartDate", FromDOB.Value.Date)
                cmd.Parameters.AddWithValue("@NewEndDate", ToDOB.Value.Date)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Schedule to This Has Been Booked", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            End Using
            PaymentDetailSlip.Show() 'Shows Payment Slip
            Me.Hide()
        End If
    End Sub
    Private Sub ColumnLoader() 'Loads The Whole Column
        DGVSchedules.Columns.Clear()
        DGVSchedules.Columns.Add("CarName", "Car Name") 'The first part which is the car Name
        DGVSchedules.Columns("CarName").Width = 150
        Dim daysInMonth As Integer = DateTime.DaysInMonth(MnthC.SelectionStart.Year, MnthC.SelectionStart.Month)
        For i = 1 To daysInMonth 'loops to make the full calendar days
            DGVSchedules.Columns.Add(i.ToString(), i.ToString())
        Next
        For Each column As DataGridViewColumn In DGVSchedules.Columns 'loops to make the cells fill
            If column.Name <> "CarName" Then 'condition that the first column CarName will not affected by fill
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End If
        Next
    End Sub

    Private Sub RowLoader() 'Loads the Rows AKA the car lists
        DGVSchedules.Rows.Clear()
        Dim query As String = "SELECT DISTINCT CarID, CarName FROM Booking ORDER BY CarID" 'Loads DISTINCT CarID and CARNAME so it will iterate as one line when you seek through days
        con.Open()
        Dim cmd As New SqlCommand(query, con)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While reader.Read() 'SQL data reader call above used before in dashboard please refer there instead but in a loop form
            Dim carName As String = reader("CarName").ToString()
            Dim row As Integer = DGVSchedules.Rows.Add()
            DGVSchedules.Rows(row).Cells("CarName").Value = carName 'Literally adds the carname within the cells in the column
        End While
        con.Close()
    End Sub
    Private Sub MnthC_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MnthC.DateChanged 'calls out 3 functions that updates the datagrid
        ColumnLoader()
        RowLoader()
        ScheduleShower()
    End Sub
    Private Sub ScheduleShower()
        Dim selectedMonth As DateTime = New DateTime(MnthC.SelectionStart.Year, MnthC.SelectionStart.Month, 1)
        Dim startOfMonth As DateTime = selectedMonth
        Dim endOfMonth As DateTime = selectedMonth.AddMonths(1).AddDays(-1)
        Dim query As String = "SELECT CarID, CarName, StartBookDate, EndBookDate FROM Booking WHERE StartBookDate <= @EndOfMonth AND EndBookDate >= @StartOfMonth"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@StartOfMonth", startOfMonth)
        cmd.Parameters.AddWithValue("@EndOfMonth", endOfMonth)
        con.Open()
        Dim Carreader As SqlDataReader = cmd.ExecuteReader()
        For Each row As DataGridViewRow In DGVSchedules.Rows
            For Each cell As DataGridViewCell In row.Cells
                cell.Style.BackColor = Color.White
            Next
        Next
        While Carreader.Read()
            Dim carName As String = Carreader.GetString(1)
            Dim startDate As DateTime = Carreader.GetDateTime(2)
            Dim endDate As DateTime = Carreader.GetDateTime(3)
            Dim currentDate As DateTime = startDate
            While currentDate <= endDate
                If currentDate.Month = startOfMonth.Month AndAlso currentDate.Year = startOfMonth.Year Then
                    Dim column As Integer = currentDate.Day
                    Dim rowIndex As Integer = -1
                    For i As Integer = 0 To DGVSchedules.Rows.Count - 1
                        If DGVSchedules.Rows(i).Cells(0).Value IsNot Nothing AndAlso DGVSchedules.Rows(i).Cells(0).Value.ToString().ToLower() = carName.ToLower() Then
                            rowIndex = i
                            Exit For
                        End If
                    Next
                    If rowIndex >= 0 AndAlso column >= 1 AndAlso column < DGVSchedules.ColumnCount Then
                        DGVSchedules.Rows(rowIndex).Cells(column).Style.BackColor = Color.Red
                    End If
                End If
                currentDate = currentDate.AddDays(1)
            End While
        End While
        con.Close()
    End Sub
    Private Sub BookingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Loads the calendar once the form loads
        ColumnLoader()
        RowLoader()
        ScheduleShower()
    End Sub
End Class