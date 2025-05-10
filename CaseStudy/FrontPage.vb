Public Class FrontPage
    Private Sub RoundCornerButton(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.DarkBlue
        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand

        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()
        rad.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        rad.AddLine(10, 0, btn.Width - 20, 0)
        rad.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        rad.AddLine(Button1.Width, 20, btn.Width, btn.Height - 10)
        rad.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        rad.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        rad.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Button1.Region = New Region(rad)

        Dim rad2 As New Drawing2D.GraphicsPath
        rad2.StartFigure()
        rad2.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        rad2.AddLine(10, 0, btn.Width - 20, 0)
        rad2.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        rad2.AddLine(Button2.Width, 20, btn.Width, btn.Height - 10)
        rad2.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        rad2.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        rad2.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Button2.Region = New Region(rad2)

        Dim rad3 As New Drawing2D.GraphicsPath
        rad3.StartFigure()
        rad3.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        rad3.AddLine(10, 0, btn.Width - 20, 0)
        rad3.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        rad3.AddLine(Button3.Width, 20, btn.Width, btn.Height - 10)
        rad3.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        rad3.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        rad3.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Button3.Region = New Region(rad3)

        Dim rad4 As New Drawing2D.GraphicsPath
        rad4.StartFigure()
        rad4.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        rad4.AddLine(10, 0, btn.Width - 20, 0)
        rad4.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        rad4.AddLine(Button4.Width, 20, btn.Width, btn.Height - 10)
        rad4.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        rad4.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        rad4.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        Button4.Region = New Region(rad4)

    End Sub

    Private Sub FrontPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RoundCornerButton(Button1)
        RoundCornerButton(Button2)
        RoundCornerButton(Button3)
        RoundCornerButton(Button4)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Hide()
        Dashboard.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()
        BookingForm.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Hide()
        PaymentDetailSlip.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Me.Close()
        loginForm.Show()

    End Sub

End Class