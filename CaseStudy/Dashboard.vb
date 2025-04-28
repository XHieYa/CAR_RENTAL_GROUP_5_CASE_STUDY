Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.Data.SqlClient 'Importing SQL Database Access Commands
Public Class Dashboard
    Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblgreet.Text = "Hello, " & loginForm.txtuser.Text & " Welcome to Rent 4 Wheelz"

        Try
            con.Open()
            Dim query As String = "SELECT Username, Fullname, Age, Sex, Address, [Date] FROM login WHERE Username = @Username"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Username", loginForm.txtuser.Text)

            Dim myReader As SqlDataReader = cmd.ExecuteReader()

            If myReader.HasRows Then
                myReader.Read()
                lblFullName.Text = "Full Name: " & myReader("Fullname").ToString()
                lblAge.Text = "Age: " & myReader("Age").ToString()
                lblSex.Text = "Sex: " & myReader("Sex").ToString()
                lblAddress.Text = "Address: " & myReader("Address").ToString()
                lblDOB.Text = "Date Of Birth: " & myReader("Date").ToString()
            Else
                MessageBox.Show("No data found for the provided username.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class