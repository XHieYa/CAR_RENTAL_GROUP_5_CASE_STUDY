Imports Microsoft.Data.SqlClient 'Importing SQL Database Access Commands
Public Class PaymentDetailSlip
    'Set up Variables
    Dim totalpay As Double
    Dim rate As Integer = Val(BookingForm.txtRate.Text)
    Dim Discount As Integer
    Dim DriverFee As Integer
    Dim Driver As String
    Private Sub txtContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress 'make sure only numbers are held
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'when loaded takes the information from Booking Form and loginform for the username Ofc
    Private Sub PaymentDetailSlip(sender As Object, e As EventArgs) Handles MyBase.Load
        FromDate.Value = BookingForm.FromDOB.Value.Date
        ToDate.Value = BookingForm.ToDOB.Value.Date
        txtFullName.Text = Dashboard.lblFullName.Text
        txtUsername.Text = loginForm.txtuser.Text
        txtAge.Text = Dashboard.lblAge.Text
        txtDOB.Text = Dashboard.lblDOB.Text
        txtEmail.Text = Dashboard.lblEmail.Text
        txtCarName.Text = BookingForm.txtCar.Text
        txtCarID.Text = BookingForm.TxtCarID.Text
        txtBodyNumber.Text = BookingForm.txtBodyNumber.Text
        txtPlateNumber.Text = BookingForm.txtPlateNumber.Text
        Ratetxt.Text = BookingForm.txtRate.Text
        Typetxt.Text = BookingForm.txtType.Text
        Capacitytxt.Text = BookingForm.txtCapacity.Text

    End Sub
    'when payment is complete this shall execute
    Private Sub BookingAdd()
        'Sql connection
        Dim Con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CaseStudy;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")
        'Condition if checkbox for driver is yes or a no to be sent to the sql
        If CheckBox1.Checked Then
            Driver = "Yes"
        ElseIf CheckBox1.Checked = False Then
            Driver = "No"
        End If
        Try
            'checks if the date values are equal
            If FromDate.Value = ToDate.Value Then
                MessageBox.Show("Cannot book within the same day", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            'sql query
            Dim query As String = "INSERT INTO Booking (CarID, CarName, StartBookDate, EndBookDate, Price, WDriver, Rate, Contact, Username) VALUES (@CarID, @CarName, @Fdate, @Tdate, @Price, @WDriver, @Rate, @Contact, @Username)"
            Con.Open()
            'same as the other that adds items to sql
            Using cmd As New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@CarID", txtCarID.Text)
                cmd.Parameters.AddWithValue("@CarName", txtCarName.Text)
                cmd.Parameters.AddWithValue("@Fdate", FromDate.Value.Date)
                cmd.Parameters.AddWithValue("@Tdate", ToDate.Value.Date)
                cmd.Parameters.AddWithValue("Username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@Price", totalpay)
                cmd.Parameters.AddWithValue("@WDriver", Driver)
                cmd.Parameters.AddWithValue("@Rate", Ratetxt.Text)
                cmd.Parameters.AddWithValue("@Contact", txtContact.Text)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Successfully Booked", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub
    'Sub that calculates pay
    Public Sub CarPay()
        Dim TotalDays As Integer = (ToDate.Value.Date - FromDate.Value.Date).Days
        If CheckBox1.Checked = True Then
            Driver = "Yes"
        ElseIf CheckBox1.Checked = False Then
            Driver = "No"
        End If
        If Driver = "Yes" Then
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
        ElseIf Driver = "No" Then
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
                Discount = 0
            End If
            totalpay = (rate * TotalDays) - Discount
        End If
    End Sub
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        'gets total days
        Dim TotalDays As Integer = (ToDate.Value.Date - FromDate.Value.Date).Days
        'initiates carpay
        CarPay()
        'shows the total day and information
        MessageBox.Show("Total Days:" & TotalDays &
                        ControlChars.NewLine & "Discounted Price: " & Discount &
                        ControlChars.NewLine & "Driver Fee: " & DriverFee &
                        ControlChars.NewLine & "Total: " & totalpay, "Calculations")
    End Sub
    'same as calculate but with more if condition if they didnt put anything or decided to cancel out or insufficient funds
    Private Sub BtnPayment_Click(sender As Object, e As EventArgs) Handles BtnPayment.Click
        Dim TotalDays = (ToDate.Value.Date - FromDate.Value.Date).Days
        CarPay
        Dim PaymentInput = InputBox("Total Days:" & TotalDays &
                        ControlChars.NewLine & "Discounted Price: " & Discount &
                        ControlChars.NewLine & "Driver Fee: " & DriverFee &
                        ControlChars.NewLine & "Total: " & totalpay, "Payment Input Box")
        If PaymentInput = "" Then
            MessageBox.Show("Payment Canceled", "Info")
        Else
            If Val(PaymentInput) < totalpay Then
                MessageBox.Show("Insufficient Amount.", "Payment Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                BookingAdd()
                Dashboard.Close()
                Dashboard.Show()
                Me.Close()
            End If

        End If


    End Sub

    Private Sub btnBackToBooking_Click(sender As Object, e As EventArgs) Handles btnBackToBooking.Click
        BookingForm.Show()
        Me.Hide()
    End Sub

    Private Sub BtnBackToDashBoard_Click(sender As Object, e As EventArgs) Handles BtnBackToDashBoard.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub BtnBackToSeater_Click(sender As Object, e As EventArgs) Handles BtnBackToSeater.Click
        Seaters.Show()
        Me.Hide()
    End Sub
End Class