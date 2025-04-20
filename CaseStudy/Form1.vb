Public Class Form1

    Private Sub Four_Click(sender As Object, e As EventArgs) Handles FoFi.Click
        Dim form2 As New Form2()
        form2.ShowDialog()
    End Sub

    Private Sub SeEi_Click(sender As Object, e As EventArgs) Handles SeEi.Click
        Dim form3 As New Form3()
        form3.ShowDialog()
    End Sub
End Class
