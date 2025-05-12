Imports System.Text.RegularExpressions
Imports Windows.Win32.System
Imports Microsoft.Data.SqlClient
Imports Windows.Win32.UI.Controls
Public Class AdminForm
    'SQL Connection Just like from the other forms
    Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CaseStudy;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")
    'Sub to Load Column
    Private Sub ColumnLoadRecord()
        'Clears The Data Grid Column If ever the column loader gets Re-entered/Reused
        dgvRecord.Columns.Clear()
        'First Column That Enters the Username
        dgvRecord.Columns.Add("Username", "User Name")
        dgvRecord.Columns("Username").Width = 150
        dgvRecord.Columns.Add("Record", "Record")
        'Loops to Check and autosize the other cells
        For Each column As DataGridViewColumn In dgvRecord.Columns
            'Condition that the first column CarName will not affected by autosize
            If column.Name <> "Username" Then
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End If
        Next
    End Sub
    'Sub to load Row
    Private Sub RowLoaderRecord()
        dgvRecord.Rows.Clear()
        Dim query As String = "SELECT Username, Records FROM login ORDER BY Username"
        con.Open()
        Dim cmd As New SqlCommand(query, con)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        'Loop to get each of the row that has the Username and Record
        While reader.Read()
            Dim rowIndex As Integer = dgvRecord.Rows.Add()
            dgvRecord.Rows(rowIndex).Cells("Username").Value = reader("Username").ToString()
            dgvRecord.Rows(rowIndex).Cells("Record").Value = reader("Records").ToString()
        End While
        con.Close()
    End Sub
    'Sub that Handles the Form when it Loads
    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Subs that are called when the form is loaded
        ColumnLoadRecord()
        RowLoaderRecord()
        ColumnLoadCarList()
        RowLoaderCarList()
    End Sub
    'Button Sub when it gets clicked
    Private Sub btnGood_Click(sender As Object, e As EventArgs) Handles btnGood.Click
        'Iterate if the user has selected a row
        If dgvRecord.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a user to mark as 'Good'.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        'This is the code that insert the Username to UsernameID of the selected row
        Dim UsernameID As String = dgvRecord.CurrentRow.Cells("Username").Value.ToString()
        'This is the query on what should the SQL should do
        Dim query As String = "UPDATE login SET Records = @Record Where Username = @Username"
        Dim cmd As New SqlCommand(query, con)
        'This is where we insert the SQL variables that needs to be compared/added
        cmd.Parameters.AddWithValue("@Username", UsernameID)
        cmd.Parameters.AddWithValue("@Record", "Good")
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        ColumnLoadRecord()
        RowLoaderRecord()
    End Sub
    'Button Sub same as btnGood_Click difference is its just sets the record with Bad
    Private Sub BtnBad_Click(sender As Object, e As EventArgs) Handles BtnBad.Click
        If dgvRecord.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a user to mark as 'Bad'.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim UsernameID As String = dgvRecord.CurrentRow.Cells("Username").Value.ToString()
        Dim query As String = "UPDATE login SET Records = @Record WHERE Username = @Username"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@Username", UsernameID)
        cmd.Parameters.AddWithValue("@Record", "Bad")
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        ColumnLoadRecord()
        RowLoaderRecord()

    End Sub
    'Column Loader same as the one uptop with the column just with xtra function and size
    Private Sub ColumnLoadCarList()
        dgvCars.Columns.Clear()
        dgvCars.Columns.Add("CarName", "Car Name")
        dgvCars.Columns("CarName").Width = 220
        dgvCars.Columns.Add("Color", "Color")
        dgvCars.Columns.Add("GasType", "Gas Type")
        dgvCars.Columns.Add("Capacity", "Capacity")
        dgvCars.Columns.Add("PlateNo", "Plate Number")
        dgvCars.Columns.Add("VIN", "Body Number")
        dgvCars.Columns("VIN").Width = 180
        dgvCars.Columns.Add("Rate", "Base Rate")
        For Each column As DataGridViewColumn In dgvCars.Columns
            If column.Name <> "CarName" And column.Name <> "VIN" Then
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End If
        Next
    End Sub
    'Row Loader same as the one uptop with the row just with xtra function and size
    Private Sub RowLoaderCarList()
        dgvCars.Rows.Clear()
        Dim query As String = "SELECT CarName, Color, GasType,Capacity, PlateNo, VIN, Rate FROM CarList ORDER BY CarName"
        con.Open()
        Dim cmd As New SqlCommand(query, con)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            Dim rowIndex As Integer = dgvCars.Rows.Add()
            dgvCars.Rows(rowIndex).Cells("CarName").Value = reader("CarName").ToString()
            dgvCars.Rows(rowIndex).Cells("Color").Value = reader("Color").ToString()
            dgvCars.Rows(rowIndex).Cells("GasType").Value = reader("GasType").ToString()
            dgvCars.Rows(rowIndex).Cells("Capacity").Value = reader("Capacity").ToString()
            dgvCars.Rows(rowIndex).Cells("PlateNo").Value = reader("PlateNo").ToString()
            dgvCars.Rows(rowIndex).Cells("VIN").Value = reader("VIN").ToString()
            dgvCars.Rows(rowIndex).Cells("Rate").Value = reader("Rate").ToString()
        End While
        con.Close()
    End Sub
    'btnAdd is the same sub from login form
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        For Each item As Control In GroupBox2.Controls 'Checks if every Box Is accounted for
            If (TypeOf item Is TextBox) Then
                If (item.Text = "") Then
                    MessageBox.Show("All Fields Must be Filled up", "info", MessageBoxButtons.OK, MessageBoxIcon.Information) 'Error message if things are not field up
                    Return
                End If
            End If
        Next
        Try
            Dim query As String = "Insert Into CarList (CarName, CarID, Color, GasType, Capacity, PlateNo, VIN, Rate) VALUES (@CarName, @CarID, @Color, @GasType, @Capacity, @PlateNo, @VIN, @Rate)" 'Basically putting the value on their own cells for the database
            Dim command As New SqlCommand(query, con) 'Individually setting the values and using parameters to be input to their cells
            command.Parameters.AddWithValue("@CarName", txtCar.Text)
            command.Parameters.AddWithValue("@CarID", TxtCarID.Text)
            command.Parameters.AddWithValue("@Color", txtCColor.Text)
            command.Parameters.AddWithValue("@GasType", txtType.Text)
            command.Parameters.AddWithValue("@Capacity", txtCapacity.Text)
            command.Parameters.AddWithValue("@PlateNo", txtPlateNumber.Text)
            command.Parameters.AddWithValue("@VIN", txtBodyNumber.Text)
            command.Parameters.AddWithValue("@Rate", txtRate.Text)
            con.Open()
            command.ExecuteNonQuery() 'Used to create or change data within the database
            MessageBox.Show("Car Successfuly Added", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information) 'Message confirming your info has been saved
        Catch ex As Exception
            MessageBox.Show($"Error adding account: {ex.Message} ") 'Error message if smthng happen within the server
        Finally
            con.Close()
            ColumnLoadCarList()
            RowLoaderCarList()
            txtCar.Text = ""
            TxtCarID.Text = ""
            txtCColor.Text = ""
            txtType.Text = ""
            txtCapacity.Text = ""
            txtPlateNumber.Text = ""
            txtBodyNumber.Text = ""
            txtRate.Text = ""

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        loginForm.Show()
        loginForm.txtuser.Text = String.Empty
        loginForm.txtpass.Text = String.Empty
    End Sub
End Class