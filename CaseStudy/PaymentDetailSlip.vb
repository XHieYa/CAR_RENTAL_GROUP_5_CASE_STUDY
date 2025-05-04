Imports Microsoft.Data.SqlClient 'Importing SQL Database Access Commands
Public Class PaymentDetailSlip
    Private Sub PaymentDetailSlip(sender As Object, e As EventArgs) Handles MyBase.Load
        FromDate.Value = BookingForm.FromDOB.Value.Date
        ToDate.Value = BookingForm.ToDOB.Value.Date
        txtFullName.Text = Dashboard.lblFullName.Text
        txtAge.Text = Dashboard.lblAge.Text
        txtSex.Text = Dashboard.lblSex.Text
        txtDOB.Text = Dashboard.lblDOB.Text

    End Sub
    Private Sub BookingAdd()
        Dim Con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")
        Dim query As String = "Insert Into Booking (CarName, StartBookDate, EndBookDate) Values ('" & txtCarName.Text & "',@Fdate, @Tdate)"
        Try
            If FromDate.Value = ToDate.Value Then
                MessageBox.Show("Cannot Book Within The Same Day", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Con.Open()
                Dim cmd As New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@Fdate", FromDate.Value.Date)
                cmd.Parameters.AddWithValue("@Tdate", ToDate.Value.Date)
                cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            MessageBox.Show("Successfully Booked", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Con.Close()
        End Try
    End Sub

    Private Sub BtnPayment_Click(sender As Object, e As EventArgs) Handles BtnPayment.Click

    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        Dim TotalDays As Integer = ToDate.Value.Day - FromDate.Value.Day
    End Sub
End Class