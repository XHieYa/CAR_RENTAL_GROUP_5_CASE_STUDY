Public Class Seven_to_Eight_Seaters
    Private Sub SD_Click(sender As Object, e As EventArgs) Handles SD.Click
        Dim message As String = "Self Driving Rates" & vbCrLf & vbCrLf &
                           "1-7 days: ₱3,500/day" & vbCrLf &
                           "8-14 days: ₱3,000/day" & vbCrLf &
                           "15-30 days: ₱2,500/day" & vbCrLf &
                           "Over 30 days: ₱2,100/day" & vbCrLf & vbCrLf &
                           "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Toyota Fortuner Self Drive-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub WD_Click(sender As Object, e As EventArgs) Handles WD.Click
        Dim message As String = "With Driver Rates" & vbCrLf & vbCrLf &
                            "1-7 days: ₱4,500/day" & vbCrLf &
                            "8-14 days: ₱4,000/day" & vbCrLf &
                            "15-30 days: ₱4,500/day" & vbCrLf &
                            "Over 30 days: ₱3,100/day" & vbCrLf & vbCrLf &
                            "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Toyota Fortuner with Driver-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub B_Click(sender As Object, e As EventArgs) Handles B.Click
        Close()
    End Sub

    Private Sub SD1_Click(sender As Object, e As EventArgs) Handles SD1.Click
        Dim message As String = "Self Driving Rates" & vbCrLf & vbCrLf &
                          "1-7 days: ₱3,000/day" & vbCrLf &
                          "8-14 days: ₱2,500/day" & vbCrLf &
                          "15-30 days: ₱2,000/day" & vbCrLf &
                          "Over 30 days: ₱1,800/day" & vbCrLf & vbCrLf &
                          "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Mitsubishi XPander Self Drive-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub WD1_Click(sender As Object, e As EventArgs) Handles WD1.Click
        Dim message As String = "With Driver Rates" & vbCrLf & vbCrLf &
                            "1-7 days: ₱4,000/day" & vbCrLf &
                            "8-14 days: ₱3,500/day" & vbCrLf &
                            "15-30 days: ₱3,000/day" & vbCrLf &
                            "Over 30 days: ₱2,800/day" & vbCrLf & vbCrLf &
                            "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Mitsubishi XPander with Driver-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Close()
    End Sub

    Private Sub SD2_Click(sender As Object, e As EventArgs) Handles SD2.Click
        Dim message As String = "Self Driving Rates" & vbCrLf & vbCrLf &
                         "1-7 days: ₱3,000/day" & vbCrLf &
                         "8-14 days: ₱2,500/day" & vbCrLf &
                         "15-30 days: ₱2,000/day" & vbCrLf &
                         "Over 30 days: ₱1,800/day" & vbCrLf & vbCrLf &
                         "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Toyota Avanza Self Drive-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub WD2_Click(sender As Object, e As EventArgs) Handles WD2.Click
        Dim message As String = "With Driver Rates" & vbCrLf & vbCrLf &
                            "1-7 days: ₱4,000/day" & vbCrLf &
                            "8-14 days: ₱3,500/day" & vbCrLf &
                            "15-30 days: ₱3,000/day" & vbCrLf &
                            "Over 30 days: ₱2,800/day" & vbCrLf & vbCrLf &
                            "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Toyota Avanza with Driver-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        Close()
    End Sub

    Private Sub SD3_Click(sender As Object, e As EventArgs) Handles SD3.Click
        Dim message As String = "Self Driving Rates" & vbCrLf & vbCrLf &
                          "1-7 days: ₱3,500/day" & vbCrLf &
                          "8-14 days: ₱3,000/day" & vbCrLf &
                          "15-30 days: ₱2,500/day" & vbCrLf &
                          "Over 30 days: ₱2,100/day" & vbCrLf & vbCrLf &
                          "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Toyota Innova Self Drive-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub WD3_Click(sender As Object, e As EventArgs) Handles WD3.Click
        Dim message As String = "With Driver Rates" & vbCrLf & vbCrLf &
                           "1-7 days: ₱4,500/day" & vbCrLf &
                           "8-14 days: ₱4,000/day" & vbCrLf &
                           "15-30 days: ₱4,500/day" & vbCrLf &
                           "Over 30 days: ₱3,100/day" & vbCrLf & vbCrLf &
                           "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Toyota Innova with Driver-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        Close()
    End Sub

    Private Sub Toyota_Fortuner_ConfirmButton(sender As Object, e As EventArgs) Handles C.Click
        Me.Hide()
        BookingForm.Show()
        Seaters.Hide()
        BookingForm.TxtCarID.Text = "3048"
        BookingForm.txtCar.Text = "Toyota Fortuner"
        BookingForm.txtCColor.Text = "Black"
        BookingForm.txtType.Text = "Gasoline/Diesel"
        BookingForm.txtCapacity.Text = "7-8 Seaters"
        BookingForm.txtPlateNumber.Text = "CVM 0914"
        BookingForm.txtBodyNumber.Text = "KNAGR4A65B5149652"
        BookingForm.txtRate.Text = "3500"
    End Sub

    Private Sub Mitsubishi_Strada_Xpander_ConfirmButton(sender As Object, e As EventArgs) Handles C1.Click
        Me.Hide()
        BookingForm.Show()
        Seaters.Hide()
        BookingForm.TxtCarID.Text = "8682"
        BookingForm.txtCar.Text = "Mitsubishi Strada Xpander"
        BookingForm.txtCColor.Text = "White"
        BookingForm.txtType.Text = "Gasoline"
        BookingForm.txtCapacity.Text = "7-8 Seaters"
        BookingForm.txtPlateNumber.Text = "OPC 8764"
        BookingForm.txtBodyNumber.Text = "1FDWE37S6WHB90879"
        BookingForm.txtRate.Text = "3000"
    End Sub

    Private Sub Toyota_Avanza_ConfirmButton(sender As Object, e As EventArgs) Handles C2.Click
        Me.Hide()
        BookingForm.Show()
        Seaters.Hide()
        BookingForm.TxtCarID.Text = "3011"
        BookingForm.txtCar.Text = "Toyota Avanza"
        BookingForm.txtCColor.Text = "Blue"
        BookingForm.txtType.Text = "Gasoline"
        BookingForm.txtCapacity.Text = "7-8 Seaters"
        BookingForm.txtPlateNumber.Text = "XZM 0862"
        BookingForm.txtBodyNumber.Text = "5N3AA08C76N800387"
        BookingForm.txtRate.Text = "3000"
    End Sub

    Private Sub Toyota_Innova_ConfirmButton(sender As Object, e As EventArgs) Handles C3.Click
        Me.Hide()
        BookingForm.Show()
        Seaters.Hide()
        BookingForm.TxtCarID.Text = "9818"
        BookingForm.txtCar.Text = "Toyota Innova"
        BookingForm.txtCColor.Text = "Black"
        BookingForm.txtType.Text = "Diesel"
        BookingForm.txtCapacity.Text = "7-8 Seaters"
        BookingForm.txtPlateNumber.Text = "SDG 5412"
        BookingForm.txtBodyNumber.Text = "1J8GN28K48W216968"
        BookingForm.txtRate.Text = "3500"
    End Sub
End Class