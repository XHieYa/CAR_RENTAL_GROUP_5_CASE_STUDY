Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel 'From StyleBackground from DataGrid
Imports Microsoft.Data.SqlClient 'Importing SQL Database Access Commands
Public Class BookingForm
    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        If ToDOB.Value.Date <= FromDOB.Value.Date Then
            MessageBox.Show("End date must be later than start date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            Dim Con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")
            Dim query As String = "SELECT COUNT(*) FROM Booking WHERE CarID = @CarID AND @NewStartDate <= EndBookDate AND @NewEndDate >= StartBookDate"
            Con.Open()
            Using cmd As New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@CarID", TxtCarID.Text)
                cmd.Parameters.AddWithValue("@NewStartDate", FromDOB.Value.Date)
                cmd.Parameters.AddWithValue("@NewEndDate", ToDOB.Value.Date)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Schedule to This Had Been Booked", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            End Using
            PaymentDetailSlip.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub ColumnLoader()
        DGVSchedules.Columns.Clear()
        DGVSchedules.Columns.Add("CarName", "Car Name")
        DGVSchedules.Columns("CarName").Width = 150
        Dim daysInMonth As Integer = DateTime.DaysInMonth(MnthC.SelectionStart.Year, MnthC.SelectionStart.Month)
        For i = 1 To daysInMonth
            DGVSchedules.Columns.Add(i.ToString(), i.ToString())
        Next
        For Each column As DataGridViewColumn In DGVSchedules.Columns
            If column.Name <> "CarName" Then
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End If
        Next
    End Sub

    Private Sub RowLoader()
        DGVSchedules.Rows.Clear()

        Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomerDB;Integrated Security=True")
        Dim query As String = "SELECT DISTINCT CarID, CarName FROM Booking ORDER BY CarID"

        con.Open()
        Dim cmd As New SqlCommand(query, con)
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim carName As String = reader("CarName").ToString()
            Dim rowIndex As Integer = DGVSchedules.Rows.Add()
            DGVSchedules.Rows(rowIndex).Cells("CarName").Value = carName
        End While

        con.Close()
    End Sub

    Private Sub MnthC_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MnthC.DateChanged
        ColumnLoader()
        RowLoader()
        ScheduleShower()
    End Sub
    Private Sub ScheduleShower()
        Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomerDB;Integrated Security=True")
        Dim selectedMonth As DateTime = New DateTime(MnthC.SelectionStart.Year, MnthC.SelectionStart.Month, 1)
        Dim startOfMonth As DateTime = selectedMonth
        Dim endOfMonth As DateTime = selectedMonth.AddMonths(1).AddDays(-1)
        Dim query As String = "SELECT CarID, StartBookDate, EndBookDate FROM Booking WHERE StartBookDate <= @EndOfMonth AND EndBookDate >= @StartOfMonth"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@StartOfMonth", startOfMonth)
        cmd.Parameters.AddWithValue("@EndOfMonth", endOfMonth)

        con.Open()
        Dim Carreader As SqlDataReader = cmd.ExecuteReader()

        While Carreader.Read()
            Dim carID As Integer = Carreader.GetInt32(0)
            Dim startDate As DateTime = Carreader.GetDateTime(1)
            Dim endDate As DateTime = Carreader.GetDateTime(2)

            Dim row As Integer = carID - 1

            Dim currentDate As DateTime = startDate
            While currentDate <= endDate
                If currentDate.Month = startOfMonth.Month AndAlso currentDate.Year = startOfMonth.Year Then
                    Dim column As Integer = currentDate.Day
                    If row >= 0 And row < DGVSchedules.Rows.Count And column >= 1 And column < DGVSchedules.ColumnCount Then
                        DGVSchedules.Rows(row).Cells(column).Style.BackColor = Color.Red
                    End If
                End If
                currentDate = currentDate.AddDays(1)
            End While
        End While

        con.Close()
    End Sub

    Private Sub BookingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColumnLoader()
        RowLoader()
        ScheduleShower()
    End Sub
End Class