Public Class Camping_Cars
    Private Sub WD_Click(sender As Object, e As EventArgs) Handles WD.Click
        Dim message As String = "With Driver Rates" & vbCrLf & vbCrLf &
                            "1-7 days: ₱9,000/day" & vbCrLf &
                            "8-14 days: ₱8,000/day" & vbCrLf &
                            "15-30 days: ₱7,000/day" & vbCrLf &
                            "Over 30 days: ₱6,000/day" & vbCrLf & vbCrLf &
                            "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Motorhome 1 with Driver-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SD_Click(sender As Object, e As EventArgs) Handles SD.Click
        Dim message As String = "Self Driving Rates" & vbCrLf & vbCrLf &
                            "1-7 days: ₱8,000/day" & vbCrLf &
                            "8-14 days: ₱7,000/day" & vbCrLf &
                            "15-30 days: ₱6,000/day" & vbCrLf &
                            "Over 30 days: ₱5,000/day" & vbCrLf & vbCrLf &
                            "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Motorhome 1 Self Drive-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub B_Click(sender As Object, e As EventArgs) Handles B.Click
        Close()
    End Sub

    Private Sub WD1_Click(sender As Object, e As EventArgs) Handles WD1.Click, WD1.Click
        Dim message = "With Driver Rates" & vbCrLf & vbCrLf &
                          "1-7 days: ₱6,500/day" & vbCrLf &
                          "8-14 days: ₱5,750/day" & vbCrLf &
                          "15-30 days: ₱5,000/day" & vbCrLf &
                          "Over 30 days: ₱4,250/day" & vbCrLf & vbCrLf &
                          "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Motorhome 2 with Driver-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SD1_Click(sender As Object, e As EventArgs) Handles SD1.Click
        Dim message As String = "Self Driving Rates" & vbCrLf & vbCrLf &
                           "1-7 days: ₱5,500/day" & vbCrLf &
                           "8-14 days: ₱4,750/day" & vbCrLf &
                           "15-30 days: ₱4,000/day" & vbCrLf &
                           "Over 30 days: ₱3,250/day" & vbCrLf & vbCrLf &
                           "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Motorhome 2 Self Drive-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Close()
    End Sub

    Private Sub WD2_Click(sender As Object, e As EventArgs) Handles WD2.Click
        Dim message As String = "With Driver Rates" & vbCrLf & vbCrLf &
                            "1-7 days: ₱12,000/day" & vbCrLf &
                            "8-14 days: ₱10,625/day" & vbCrLf &
                            "15-30 days: ₱9,250/day" & vbCrLf &
                            "Over 30 days: ₱7,900/day" & vbCrLf & vbCrLf &
                            "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Motorhome 3 with Driver-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SD2_Click(sender As Object, e As EventArgs) Handles SD2.Click
        Dim message As String = "Self Driving Rates" & vbCrLf & vbCrLf &
                            "1-7 days: ₱11,000/day" & vbCrLf &
                            "8-14 days: ₱9,625/day" & vbCrLf &
                            "15-30 days: ₱8,250/day" & vbCrLf &
                            "Over 30 days: ₱6,900/day" & vbCrLf & vbCrLf &
                            "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Motorhome 3 Self Drive-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        Close()
    End Sub

    Private Sub WD3_Click(sender As Object, e As EventArgs) Handles WD3.Click
        Dim message As String = "With Driver Rates" & vbCrLf & vbCrLf &
                            "1-7 days: ₱11,000/day" & vbCrLf &
                            "8-14 days: ₱9,750/day" & vbCrLf &
                            "15-30 days: ₱8,500/day" & vbCrLf &
                            "Over 30 days: ₱7,250/day" & vbCrLf & vbCrLf &
                            "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Camper Van with Driver-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SD3_Click(sender As Object, e As EventArgs) Handles SD3.Click
        Dim message As String = "Self Driving Rates" & vbCrLf & vbCrLf &
                            "1-7 days: ₱10,000/day" & vbCrLf &
                            "8-14 days: ₱8,750/day" & vbCrLf &
                            "15-30 days: ₱7,500/day" & vbCrLf &
                            "Over 30 days: ₱6,250/day" & vbCrLf & vbCrLf &
                            "Note: Prices are subject to change after finalizing car selection and driver preference (with or without)."

        MessageBox.Show(message, "★-Camper Van Self Drive-★", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        Close()
    End Sub
End Class