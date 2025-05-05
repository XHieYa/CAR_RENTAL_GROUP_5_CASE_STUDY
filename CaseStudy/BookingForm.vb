Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel 'From StyleBackground from DataGrid
Imports Microsoft.Data.SqlClient 'Importing SQL Database Access Commands
Public Class BookingForm
    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        If FromDOB.Value.Date = ToDOB.Value.Date Then
            MessageBox.Show("Cannot Book Within The Same Day", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            PaymentDetailSlip.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub ColumnLoader()
        DGVSchedules.Columns.Clear()
        DGVSchedules.Columns.Add("CarName", "Car Name")

        Dim daysInMonth As Integer = DateTime.DaysInMonth(MnthC.SelectionStart.Year, MnthC.SelectionStart.Month)
        For i = 1 To daysInMonth
            DGVSchedules.Columns.Add(i.ToString(), i.ToString())
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
        ' This query gets bookings that overlap the current month

        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@StartOfMonth", startOfMonth)
        cmd.Parameters.AddWithValue("@EndOfMonth", endOfMonth)

        con.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim carID As Integer = reader.GetInt32(0)
            Dim startDate As DateTime = reader.GetDateTime(1)
            Dim endDate As DateTime = reader.GetDateTime(2)

            Dim rowIndex As Integer = carID - 1

            Dim currentDate As DateTime = startDate
            While currentDate <= endDate
                If currentDate.Month = startOfMonth.Month AndAlso currentDate.Year = startOfMonth.Year Then
                    Dim colIndex As Integer = currentDate.Day
                    If rowIndex >= 0 AndAlso rowIndex < DGVSchedules.Rows.Count AndAlso colIndex >= 1 AndAlso colIndex < DGVSchedules.ColumnCount Then
                        DGVSchedules.Rows(rowIndex).Cells(colIndex).Style.BackColor = Color.Red
                    End If
                End If
                currentDate = currentDate.AddDays(1)
            End While
        End While

        con.Close()
    End Sub
End Class