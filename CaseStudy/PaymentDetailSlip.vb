Imports Microsoft.Data.SqlClient 'Importing SQL Database Access Commands
Public Class PaymentDetailSlip
    Dim Discount As Double
    Dim totalpay As Double
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
        Dim Discount As Integer
        Dim TotalDays As Integer = (ToDate.Value.Date - FromDate.Value.Date).Days
        If 1 <= TotalDays >= 7 Then
            If CheckBox1.Checked Then
                Dim DriverDisc As Integer = 1000

                Discount = 0
                Dim Carrate As Double = Val(BookingForm.txtRate.Text)
                Dim rate As Integer = Val(BookingForm.txtRate.Text)

                totalpay = (rate * TotalDays) - Discount - DriverDisc
            End If
        ElseIf 8 <= TotalDays >= 14 Then
            If CheckBox1.Checked Then
                Dim DriverDisc As Integer = 1000

                Discount = 500
                Dim Carrate As Double = Val(BookingForm.txtRate.Text)
                Dim rate As Integer = Val(BookingForm.txtRate.Text)

                totalpay = (rate * TotalDays) - Discount - DriverDisc
            End If
        ElseIf 15 <= TotalDays >= 30 Then
            If CheckBox1.Checked Then
                Dim DriverDisc As Integer = 1000

                Discount = 1000
                Dim Carrate As Double = Val(BookingForm.txtRate.Text)
                Dim rate As Integer = Val(BookingForm.txtRate.Text)

                totalpay = (rate * TotalDays) - Discount - DriverDisc
            End If
        ElseIf 30 < TotalDays Then
            If CheckBox1.Checked Then
                Dim DriverDisc As Integer = 1000
                Discount = 1400
                Dim Carrate As Double = Val(BookingForm.txtRate.Text)
                Dim rate As Integer = Val(BookingForm.txtRate.Text)

                totalpay = (rate * TotalDays) - Discount - DriverDisc
            End If
        End If


    End Sub
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        Dim TotalDays As Integer = (ToDate.Value.Date - FromDate.Value.Date).Days
        MessageBox.Show(TotalDays, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim TotalPayment As Integer = (TotalDays * 150)
        GroupBox5.Text = "Receipt:" & ControlChars.NewLine & "Daily rate:" & 150 &
                                      ControlChars.NewLine & "Total Payment: " & TotalPayment
    End Sub

    Private Sub BtnPayment_Click(sender As Object, e As EventArgs) Handles BtnPayment.Click

        Dim PaymentInput As String = InputBox("Your Total Is " & totalpay & ControlChars.NewLine & "Enter Your Payment", "Payment Input Box")


        If Val(PaymentInput) < totalpay Then
            MessageBox.Show("Insufficient Amount.", "Payment Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class