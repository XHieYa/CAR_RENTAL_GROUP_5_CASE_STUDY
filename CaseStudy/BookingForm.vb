Imports System.Runtime.InteropServices.JavaScript.JSType
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
        For i = 1 To 10
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

    End Sub
End Class