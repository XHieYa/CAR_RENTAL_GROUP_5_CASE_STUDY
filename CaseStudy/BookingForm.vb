Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.Data.SqlClient 'Importing SQL Database Access Commands
Public Class BookingForm
    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
        Dim StartDate = New DateTime(MnthC.SelectionStart.Year, MnthC.SelectionStart.Month, 1)
        Dim EndDate = StartDate.AddMonths(1)
        MessageBox.Show(StartDate)
        MessageBox.Show(EndDate)
    End Sub
    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        If FromDOB.Value.Date = ToDOB.Value.Date Then
            MessageBox.Show("Cannot Book Within The Same Day", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            PaymentDetailSlip.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub ColumnLoader()
        DGVSchedules.Columns.Add("CarName", "Car Name")
        Dim DaysInMonth As Integer = DateTime.DaysInMonth(MnthC.SelectionStart.Year, MnthC.SelectionStart.Month)
        For i = 1 To DaysInMonth
            DGVSchedules.Columns.Add(i, i)
        Next
    End Sub
    Private Sub RowLoader()
        Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")
        Dim query As String = "SELECT COUNT (CarID) FROM Booking"
        con.Open()
        Dim cmd As New SqlCommand(query, con)
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        Dim carRead As SqlDataReader = cmd.ExecuteReader
        For i = 1 To count
            DGVSchedules.Rows.Add(i.ToString)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ColumnLoader()
    End Sub

    Private Sub MnthC_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MnthC.DateChanged
        DGVSchedules.Columns.Clear()
        DGVSchedules.Rows.Clear()
        ColumnLoader()
        RowLoader()

    End Sub

    Private Sub BtnBookedDate_Click(sender As Object, e As EventArgs) Handles BtnBookedDate.Click
        Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")

        con.Open()
        Dim query As String = "SELECT * FROM Booking WHERE StartBookDate >= @ST AND EndBookDate <= @ET"
        Dim Start = New DateTime(MnthC.SelectionStart.Year, MnthC.SelectionStart.Month, 1)
        Dim EndD = Start.AddMonths(1)
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@ST", Start)
        cmd.Parameters.AddWithValue("@ET", EndD)
        Dim myReader As SqlDataReader = cmd.ExecuteReader()
        While myReader.Read
            Dim CarID As Integer = myReader.GetInt32(0)
            Dim StartDate As DateTime = myReader.GetDateTime(1)
            Dim EndDate As DateTime = myReader.GetDateTime(2)

            Dim StartDay As Integer = StartDate.Day
            Dim EndDay As Integer = EndDate.Day
            Dim TotalDays As Integer = EndDay - StartDay
            DGVSchedules(StartDay, CarID - 1).Style.BackColor = Color.Red

            For i = 1 To TotalDays
                DGVSchedules(StartDay + i, CarID - 1).Style.BackColor = Color.Red
                TotalDays -= 1
            Next





        End While




    End Sub
End Class