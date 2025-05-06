Imports Microsoft.Data.SqlClient 'Importing SQL Database Access Commands
Public Class PaymentDetailSlip
    Private Sub PaymentDetailSlip(sender As Object, e As EventArgs) Handles MyBase.Load
        FromDate.Value = BookingForm.FromDOB.Value.Date
        ToDate.Value = BookingForm.ToDOB.Value.Date
        txtFullName.Text = Dashboard.lblFullName.Text
        txtUsername.Text = loginForm.txtuser.Text
        txtAge.Text = Dashboard.lblAge.Text
        txtDOB.Text = Dashboard.lblDOB.Text
        txtEmail.Text = Dashboard.lblEmail.Text

    End Sub
    Private Sub BookingAdd()
        Dim Con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")
        Try
            If FromDate.Value = ToDate.Value Then
                MessageBox.Show("Cannot book within the same day", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Dim query As String = "INSERT INTO Booking (CarID, CarName, StartBookDate, EndBookDate) VALUES (@CarID, @CarName, @Fdate, @Tdate)"
            Con.Open()
            Using cmd As New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@CarID", txtCarID.Text)
                cmd.Parameters.AddWithValue("@CarName", txtCarName.Text)
                cmd.Parameters.AddWithValue("@Fdate", FromDate.Value.Date)
                cmd.Parameters.AddWithValue("@Tdate", ToDate.Value.Date)
                cmd.Parameters.AddWithValue("Username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@Price", txtCarID)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Successfully Booked", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        Dim TotalDays As Integer = (ToDate.Value.Date - FromDate.Value.Date).Days
        MessageBox.Show(TotalDays, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim TotalPayment As Integer = (TotalDays * 150)
        GroupBox5.Text = "Receipt:" & ControlChars.NewLine & "Daily rate:" & 150 &
                                      ControlChars.NewLine & "Total Payment: " & TotalPayment
    End Sub

    Private Sub BtnPayment_Click(sender As Object, e As EventArgs) Handles BtnPayment.Click
        Dim TotalDays As Integer = (ToDate.Value.Date - FromDate.Value.Date).Days
        Dim TotalPayment As Integer = (TotalDays * 150)

        Dim PaymentInput As String = InputBox("Enter Payment Amount", "Payment Input Box")

        If Val(PaymentInput) < TotalPayment Then
            MessageBox.Show("Insufficient Amount.", "Payment Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class