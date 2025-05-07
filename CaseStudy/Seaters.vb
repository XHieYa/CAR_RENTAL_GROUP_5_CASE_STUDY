Imports Windows.Win32.System
Imports Microsoft.Data.SqlClient
Imports Microsoft.IdentityModel.Protocols.Configuration 'Importing SQL Database Access Commands
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

    Private Sub Seaters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")
        con.Open()
        Dim query As String = "SELECT Username, Records FROM login WHERE Username = @Username" 'CONDITION PROMPT ON WHAT TO SELECT FROM THE DATA BASE
        Dim cmd As New SqlCommand(query, con) 'SEE BACK ON LOGIN FORM
        cmd.Parameters.AddWithValue("@Username", loginForm.txtuser.Text)
        Dim myReader As SqlDataReader = cmd.ExecuteReader() 'MAKES A SQL READER IN ORDER TO READ THE DATA THAT'S IN THE DATA BASE
        If myReader.HasRows Then 'CHECKS IF THE USERNAME/ROW HAS A DATA
            myReader.Read() 'EXECUTES READ COMMAND
            lblRecord.Text = myReader("Records").ToString() 'PLACES THE VARIABLES TO THE LABELS
        End If
        con.Close()
        If lblRecord.Text = "Good" Then
            CampingCars.Enabled = True
        End If
    End Sub
End Class