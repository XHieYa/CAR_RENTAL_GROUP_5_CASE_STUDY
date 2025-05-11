Public Class Camping_Cars
    Private Sub WD_Click(sender As Object, e As EventArgs) Handles WD.Click
        Dim message As String = "With Driver Rates" & vbCrLf & vbCrLf &
                            "1-7 days: ₱12,000/day" & vbCrLf &
                            "8-14 days: ₱10,625/day" & vbCrLf &
                            "15-30 days: ₱9,250/day" & vbCrLf &
                            "Over 30 days: ₱7,875/day" & vbCrLf & vbCrLf &
                            "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Motorhome 1 with Driver-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SD_Click(sender As Object, e As EventArgs) Handles SD.Click
        Dim message As String = "Self Driving Rates" & vbCrLf & vbCrLf &
                            "1-7 days: ₱11,000/day" & vbCrLf &
                            "8-14 days: ₱9,625/day" & vbCrLf &
                            "15-30 days: ₱8,250/day" & vbCrLf &
                            "Over 30 days: ₱6,875/day" & vbCrLf & vbCrLf &
                            "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Motorhome 1 Self Drive-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub B_Click(sender As Object, e As EventArgs) Handles B.Click
        Close()
    End Sub

    Private Sub WD1_Click(sender As Object, e As EventArgs) Handles WD1.Click, WD1.Click
        Dim message = "With Driver Rates" & vbCrLf & vbCrLf &
                          "1-7 days: ₱11,000/day" & vbCrLf &
                          "8-14 days: ₱9,750/day" & vbCrLf &
                          "15-30 days: ₱8,500/day" & vbCrLf &
                          "Over 30 days: ₱7,250/day" & vbCrLf & vbCrLf &
                          "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Motorhome 2 with Driver-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SD1_Click(sender As Object, e As EventArgs) Handles SD1.Click
        Dim message As String = "Self Driving Rates" & vbCrLf & vbCrLf &
                           "1-7 days: ₱10,000/day" & vbCrLf &
                           "8-14 days: ₱8,750/day" & vbCrLf &
                           "15-30 days: ₱7,500/day" & vbCrLf &
                           "Over 30 days: ₱6,250/day" & vbCrLf & vbCrLf &
                           "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Motorhome 2 Self Drive-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Close()
    End Sub

    Private Sub WD2_Click(sender As Object, e As EventArgs) Handles WD2.Click
        Dim message As String = "With Driver Rates" & vbCrLf & vbCrLf &
                            "1-7 days: ₱13,000/day" & vbCrLf &
                            "8-14 days: ₱11,500/day" & vbCrLf &
                            "15-30 days: ₱10,000/day" & vbCrLf &
                            "Over 30 days: ₱8,500/day" & vbCrLf & vbCrLf &
                            "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Motorhome 3 with Driver-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SD2_Click(sender As Object, e As EventArgs) Handles SD2.Click
        Dim message As String = "Self Driving Rates" & vbCrLf & vbCrLf &
                            "1-7 days: ₱12,000/day" & vbCrLf &
                            "8-14 days: ₱10,500/day" & vbCrLf &
                            "15-30 days: ₱9,000/day" & vbCrLf &
                            "Over 30 days: ₱7,500/day" & vbCrLf & vbCrLf &
                            "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Motorhome 3 Self Drive-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        Close()
    End Sub

    Private Sub WD3_Click(sender As Object, e As EventArgs) Handles WD3.Click
        Dim message As String = "With Driver Rates" & vbCrLf & vbCrLf &
                            "1-7 days: ₱12,000/day" & vbCrLf &
                            "8-14 days: ₱10,625/day" & vbCrLf &
                            "15-30 days: ₱9,250/day" & vbCrLf &
                            "Over 30 days: ₱7,875/day" & vbCrLf & vbCrLf &
                            "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Camper Van with Driver-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SD3_Click(sender As Object, e As EventArgs) Handles SD3.Click
        Dim message As String = "Self Driving Rates" & vbCrLf & vbCrLf &
                            "1-7 days: ₱11,000/day" & vbCrLf &
                            "8-14 days: ₱9,625/day" & vbCrLf &
                            "15-30 days: ₱8,250/day" & vbCrLf &
                            "Over 30 days: ₱6,875/day" & vbCrLf & vbCrLf &
                            "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Camper Van Self Drive-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        Close()
    End Sub

    Private Sub Motorhome_1_ConfirmButton(sender As Object, e As EventArgs) Handles C.Click
        Me.Hide()
        BookingForm.Show()
        Seaters.Hide()
        BookingForm.TxtCarID.Text = "3234"
        BookingForm.txtCar.Text = "Motorhome 1"
        BookingForm.txtCColor.Text = "White"
        BookingForm.txtType.Text = "Diesel"
        BookingForm.txtCapacity.Text = "9 Seaters"
        BookingForm.txtPlateNumber.Text = "PIC 9832"
        BookingForm.txtBodyNumber.Text = "1FTYR10D97PA44551"
        BookingForm.txtRate.Text = "11000"
    End Sub

    Private Sub Motorhome_2_ConfirmButton(sender As Object, e As EventArgs) Handles C1.Click
        Me.Hide()
        BookingForm.Show()
        Seaters.Hide()
        BookingForm.TxtCarID.Text = "1358"
        BookingForm.txtCar.Text = "Motorhome 2"
        BookingForm.txtCColor.Text = "Silver"
        BookingForm.txtType.Text = "Diesel"
        BookingForm.txtCapacity.Text = "5 Seaters"
        BookingForm.txtPlateNumber.Text = "VCZ 2415"
        BookingForm.txtBodyNumber.Text = "1C3LC56K07N537298"
        BookingForm.txtRate.Text = "10000"
    End Sub

    Private Sub Motorhome_3_ConfirmButton(sender As Object, e As EventArgs) Handles C2.Click
        Me.Hide()
        BookingForm.Show()
        Seaters.Hide()
        BookingForm.TxtCarID.Text = "1548"
        BookingForm.txtCar.Text = "Motorhome 3"
        BookingForm.txtCColor.Text = "White"
        BookingForm.txtType.Text = "Diesel"
        BookingForm.txtCapacity.Text = "10 Seaters"
        BookingForm.txtPlateNumber.Text = "UIC 6452"
        BookingForm.txtBodyNumber.Text = "3N1CE2CP0EL450229"
        BookingForm.txtRate.Text = "12000"
    End Sub

    Private Sub Camper_Van_ConfirmButton(sender As Object, e As EventArgs) Handles C3.Click
        Me.Hide()
        BookingForm.Show()
        Seaters.Hide()
        BookingForm.TxtCarID.Text = "8645"
        BookingForm.txtCar.Text = "Camper Van"
        BookingForm.txtCColor.Text = "Orange"
        BookingForm.txtType.Text = "Diesel"
        BookingForm.txtCapacity.Text = "9 Seaters"
        BookingForm.txtPlateNumber.Text = "ZAC 3245"
        BookingForm.txtBodyNumber.Text = "2G1WK15K779154878"
        BookingForm.txtRate.Text = "11000"
    End Sub
End Class