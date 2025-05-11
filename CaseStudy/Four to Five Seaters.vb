Public Class Four_to_Five_Seaters

    Private Sub SD_Click(sender As Object, e As EventArgs) Handles SD.Click
        Dim message As String = "Self Driving Rates" & vbCrLf & vbCrLf &
                         "1-7 days: ₱3,000/day" & vbCrLf &
                         "8-14 days: ₱2,500/day" & vbCrLf &
                         "15-30 days: ₱2,000/day" & vbCrLf &
                         "Over 30 days: ₱1,800/day" & vbCrLf & vbCrLf &
                         "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Maruti Suzuki S-Presso Self Drive-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub WD_Click(sender As Object, e As EventArgs) Handles WD.Click
        Dim message As String = "With Driver Rates" & vbCrLf & vbCrLf &
                            "1-7 days: ₱4,000/day" & vbCrLf &
                            "8-14 days: ₱3,500/day" & vbCrLf &
                            "15-30 days: ₱3,000/day" & vbCrLf &
                            "Over 30 days: ₱2,800/day" & vbCrLf & vbCrLf &
                            "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Maruti Suzuki S-Presso with Driver-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub B_Click(sender As Object, e As EventArgs) Handles B.Click
        Close()
    End Sub

    Private Sub SD1_Click(sender As Object, e As EventArgs) Handles SD1.Click
        Dim message As String = "Self Driving Rates" & vbCrLf & vbCrLf &
                         "1-7 days: ₱4,200/day" & vbCrLf &
                         "8-14 days: ₱3,700/day" & vbCrLf &
                         "15-30 days: ₱3,200/day" & vbCrLf &
                         "Over 30 days: ₱2,800/day" & vbCrLf & vbCrLf &
                         "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Suzuki Jimny Self Drive-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub WD1_Click(sender As Object, e As EventArgs) Handles WD1.Click
        Dim message As String = "With Driver Rates" & vbCrLf & vbCrLf &
                           "1-7 days: ₱5,200/day" & vbCrLf &
                           "8-14 days: ₱4,700/day" & vbCrLf &
                           "15-30 days: ₱4,200/day" & vbCrLf &
                           "Over 30 days: ₱3,800/day" & vbCrLf & vbCrLf &
                           "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Suzuki Jimny with Driver-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Close()
    End Sub

    Private Sub SD2_Click(sender As Object, e As EventArgs) Handles SD2.Click
        Dim message As String = "Self Driving Rates" & vbCrLf & vbCrLf &
                          "1-7 days: ₱3,500/day" & vbCrLf &
                          "8-14 days: ₱3,000/day" & vbCrLf &
                          "15-30 days: ₱2,500/day" & vbCrLf &
                          "Over 30 days: ₱2,100/day" & vbCrLf & vbCrLf &
                          "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Ford Ranger Self Drive-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub WD2_Click(sender As Object, e As EventArgs) Handles WD2.Click
        Dim message As String = "With Driver Rates" & vbCrLf & vbCrLf &
                           "1-7 days: ₱4,500/day" & vbCrLf &
                           "8-14 days: ₱4,000/day" & vbCrLf &
                           "15-30 days: ₱4,500/day" & vbCrLf &
                           "Over 30 days: ₱3,100/day" & vbCrLf & vbCrLf &
                           "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Ford Ranger with Driver-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        Close()
    End Sub

    Private Sub SD3_Click(sender As Object, e As EventArgs) Handles SD3.Click
        Dim message As String = "Self Driving Rates" & vbCrLf & vbCrLf &
                         "1-7 days: ₱4,200/day" & vbCrLf &
                         "8-14 days: ₱3,700/day" & vbCrLf &
                         "15-30 days: ₱3,200/day" & vbCrLf &
                         "Over 30 days: ₱2,800/day" & vbCrLf & vbCrLf &
                         "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Mitsubishi Strada Self Drive-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub WD3_Click(sender As Object, e As EventArgs) Handles WD3.Click
        Dim message As String = "With Driver Rates" & vbCrLf & vbCrLf &
                           "1-7 days: ₱5,200/day" & vbCrLf &
                           "8-14 days: ₱4,700/day" & vbCrLf &
                           "15-30 days: ₱4,200/day" & vbCrLf &
                           "Over 30 days: ₱3,800/day" & vbCrLf & vbCrLf &
                           "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Mitsubishi Strada with Driver-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        Close()
    End Sub

    Private Sub Maruti_Suzuki_SPresso_ConfirmButton(sender As Object, e As EventArgs) Handles C.Click
        Me.Hide()
        BookingForm.Show()
        Seaters.Hide()
        BookingForm.txtCColor.Text = "Orange"
        BookingForm.txtCar.Text = "Maruti Suzuki S-Presso"
        BookingForm.txtPlateNumber.Text = "ABC 1234"
        BookingForm.txtType.Text = "Gasoline"
        BookingForm.txtCapacity.Text = "4-5 Seaters"
        BookingForm.txtBodyNumber.Text = "KNADH4A32A6694471"
        BookingForm.TxtCarID.Text = "5520"
        BookingForm.txtRate.Text = "3000"
    End Sub

    Private Sub Suzuki_Jimmy_ConfirmButton(sender As Object, e As EventArgs) Handles C1.Click
        Me.Hide()
        BookingForm.Show()
        Seaters.Hide()
        BookingForm.txtCColor.Text = "Lime Green"
        BookingForm.txtCar.Text = "Suzuki Jimmy"
        BookingForm.txtPlateNumber.Text = "HGI 6478"
        BookingForm.txtType.Text = "Gasoline"
        BookingForm.txtCapacity.Text = "4-5 Seaters"
        BookingForm.txtBodyNumber.Text = "1XKADR9X9PS506278"
        BookingForm.TxtCarID.Text = "4210"
        BookingForm.txtRate.Text = "4200"
    End Sub

    Private Sub Ford_Ranger_ConfirmButton(sender As Object, e As EventArgs) Handles C2.Click
        Me.Hide()
        BookingForm.Show()
        Seaters.Hide()
        BookingForm.TxtCarID.Text = "4591"
        BookingForm.txtCar.Text = "Ford Ranger"
        BookingForm.txtCColor.Text = "Blue"
        BookingForm.txtType.Text = "Diesel"
        BookingForm.txtCapacity.Text = "4-5 Seaters"
        BookingForm.txtPlateNumber.Text = "DEF 2365"
        BookingForm.txtBodyNumber.Text = "5UXFG43508LJ73109"
        BookingForm.txtRate.Text = "3500"
    End Sub

    Private Sub Mitsubishi_Strada_ConfirmButton(sender As Object, e As EventArgs) Handles C3.Click
        Me.Hide()
        BookingForm.Show()
        Seaters.Hide()
        BookingForm.TxtCarID.Text = "2347"
        BookingForm.txtCar.Text = "Mitsubishi Strada"
        BookingForm.txtCColor.Text = "Orange"
        BookingForm.txtType.Text = "Diesel"
        BookingForm.txtCapacity.Text = "4-5 Seaters"
        BookingForm.txtPlateNumber.Text = "HGO 9125"
        BookingForm.txtBodyNumber.Text = "WDDGF5EB0AR131131"
        BookingForm.txtRate.Text = "4200"
    End Sub
End Class