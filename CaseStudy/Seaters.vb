Public Class Seaters
    Private Sub FourFive_Click(sender As Object, e As EventArgs) Handles FourFive.Click
        Dim form4to5 As New Four_to_Five_Seaters()
        form4to5.Show()
    End Sub

    Private Sub SevenEight_Click(sender As Object, e As EventArgs) Handles SevenEight.Click
        Dim form7to8 As New Seven_to_Eight_Seaters()
        form7to8.Show()
    End Sub

    Private Sub TenFifteen_Click(sender As Object, e As EventArgs) Handles TenFifteen.Click
        Dim form10to15 As New Ten_to_Fifteen_Seaters()
        form10to15.Show()
    End Sub

    Private Sub CampingCars_Click(sender As Object, e As EventArgs) Handles CampingCars.Click
        Dim formCC As New Camping_Cars()
        formCC.Show()
    End Sub
End Class