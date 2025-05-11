Public Class Ten_to_Fifteen_Seaters

    Private Sub SD_Click(sender As Object, e As EventArgs) Handles SD.Click
        Dim message As String = "Self Driving Rates" & vbCrLf & vbCrLf &
                           "1-7 days: ₱4,000/day" & vbCrLf &
                           "8-14 days: ₱3,500/day" & vbCrLf &
                           "15-30 days: ₱3,000/day" & vbCrLf &
                           "Over 30 days: ₱2,500/day" & vbCrLf & vbCrLf &
                           "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Nissan NV350 Urvan Self Drive-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub WD_Click(sender As Object, e As EventArgs) Handles WD.Click
        Dim message As String = "With Driver Rates" & vbCrLf & vbCrLf &
                           "1-7 days: ₱5,000/day" & vbCrLf &
                           "8-14 days: ₱4,500/day" & vbCrLf &
                           "15-30 days: ₱4,000/day" & vbCrLf &
                           "Over 30 days: ₱3,500/day" & vbCrLf & vbCrLf &
                           "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Nissan NV350 Urvan with Driver-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub B_Click(sender As Object, e As EventArgs) Handles B.Click
        Close()
    End Sub

    Private Sub SD1_Click(sender As Object, e As EventArgs) Handles SD1.Click
        Dim message As String = "Self Driving Rates" & vbCrLf & vbCrLf &
                           "1-7 days: ₱4,000/day" & vbCrLf &
                           "8-14 days: ₱3,500/day" & vbCrLf &
                           "15-30 days: ₱3,000/day" & vbCrLf &
                           "Over 30 days: ₱2,500/day" & vbCrLf & vbCrLf &
                           "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Toyota HIACE Commuter Van Self Drive-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub WD1_Click(sender As Object, e As EventArgs) Handles WD1.Click
        Dim message As String = "With Driver Rates" & vbCrLf & vbCrLf &
                           "1-7 days: ₱5,000/day" & vbCrLf &
                           "8-14 days: ₱4,500/day" & vbCrLf &
                           "15-30 days: ₱4,000/day" & vbCrLf &
                           "Over 30 days: ₱3,500/day" & vbCrLf & vbCrLf &
                           "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Toyota HIACE Commuter Van with Driver-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Close()
    End Sub

    Private Sub SD2_Click(sender As Object, e As EventArgs) Handles SD2.Click
        Dim message As String = "Self Driving Rates" & vbCrLf & vbCrLf &
                           "1-7 days: ₱4,000/day" & vbCrLf &
                           "8-14 days: ₱3,500/day" & vbCrLf &
                           "15-30 days: ₱3,000/day" & vbCrLf &
                           "Over 30 days: ₱2,500/day" & vbCrLf & vbCrLf &
                           "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Toyota HIACE Grandia Van Self Drive-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub WD2_Click(sender As Object, e As EventArgs) Handles WD2.Click
        Dim message As String = "With Driver Rates" & vbCrLf & vbCrLf &
                           "1-7 days: ₱5,000/day" & vbCrLf &
                           "8-14 days: ₱4,500/day" & vbCrLf &
                           "15-30 days: ₱4,000/day" & vbCrLf &
                           "Over 30 days: ₱3,500/day" & vbCrLf & vbCrLf &
                           "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Toyota HIACE Grandia Van with Driver-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        Close()
    End Sub

    Private Sub Nissan_NV350_Urvan_ConfirmButton(sender As Object, e As EventArgs) Handles C.Click
        Me.Hide()
        BookingForm.Show()
        Seaters.Hide()
        BookingForm.TxtCarID.Text = "1082"
        BookingForm.txtCar.Text = "Nissan NV350 Urvan"
        BookingForm.txtCColor.Text = "White"
        BookingForm.txtType.Text = "Diesel"
        BookingForm.txtCapacity.Text = "10-15 Seaters"
        BookingForm.txtPlateNumber.Text = "NQR 8795"
        BookingForm.txtBodyNumber.Text = "2GCEK19J271654076"
        BookingForm.txtRate.Text = "4000"
    End Sub

    Private Sub Toyota_HIACE_Commuter_Van_ConfirmButton(sender As Object, e As EventArgs) Handles C1.Click
        Me.Hide()
        BookingForm.Show()
        Seaters.Hide()
        BookingForm.TxtCarID.Text = "3462"
        BookingForm.txtCar.Text = "Toyota HIACE Commuter Van"
        BookingForm.txtCColor.Text = "White"
        BookingForm.txtType.Text = "Diesel"
        BookingForm.txtCapacity.Text = "10-15 Seaters"
        BookingForm.txtPlateNumber.Text = "YZX 2087"
        BookingForm.txtBodyNumber.Text = "WDDKJ5GB8AF061062"
        BookingForm.txtRate.Text = "4000"
    End Sub

    Private Sub Toyota_HIACE_Grandia_Van_ConfirmButton(sender As Object, e As EventArgs) Handles C2.Click
        Me.Hide()
        BookingForm.Show()
        Seaters.Hide()
        BookingForm.TxtCarID.Text = "8842"
        BookingForm.txtCar.Text = "Toyota HIACE Grandia Van"
        BookingForm.txtCColor.Text = "White"
        BookingForm.txtType.Text = "Diesel"
        BookingForm.txtCapacity.Text = "10-15 Seaters"
        BookingForm.txtPlateNumber.Text = "XYZ 5462"
        BookingForm.txtBodyNumber.Text = "1GNSKKE75ER172720"
        BookingForm.txtRate.Text = "4000"
    End Sub
End Class