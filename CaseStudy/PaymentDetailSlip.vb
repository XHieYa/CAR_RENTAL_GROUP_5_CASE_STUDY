Imports Microsoft.Data.SqlClient 'Importing SQL Database Access Commands
Public Class PaymentDetailSlip
    Dim totalpay As Double
    Dim rate As Integer = 150 'Val(BookingForm.txtRate.Text)
    Dim Discount As Integer
    Dim DriverFee As Integer
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
        Dim Con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CaseStudy;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")
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
                cmd.Parameters.AddWithValue("@Price", totalpay)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Successfully Booked", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub
    Public Sub CarPay()
        Dim TotalDays As Integer = (ToDate.Value.Date - FromDate.Value.Date).Days
        If CheckBox1.Checked Then
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
        Else
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
                Discount = 0 ' Invalid TotalDays
            End If
            totalpay = (rate * TotalDays) - Discount
        End If
        totalpay = (rate * TotalDays) - Discount + DriverFee
        MessageBox.Show("Total Days:" & TotalDays &
                        ControlChars.NewLine & "Discounted Price: " & Discount &
                        ControlChars.NewLine & "Driver Fee: " & DriverFee &
                        ControlChars.NewLine & "Total: " & totalpay, "Calculations")
    End Sub
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        CarPay()
    End Sub

    Private Sub BtnPayment_Click(sender As Object, e As EventArgs) Handles BtnPayment.Click
        Dim TotalDays As Integer = (ToDate.Value.Date - FromDate.Value.Date).Days
        Dim PaymentInput As String = InputBox("Total Days:" & TotalDays &
                        ControlChars.NewLine & "Discounted Price: " & Discount &
                        ControlChars.NewLine & "Driver Fee: " & DriverFee &
                        ControlChars.NewLine & "Total: " & totalpay, "Payment Input Box")
        If Val(PaymentInput) < totalpay Then
            MessageBox.Show("Insufficient Amount.", "Payment Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class