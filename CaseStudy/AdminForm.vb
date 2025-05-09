Imports System.Text.RegularExpressions
Imports Windows.Win32.System
Imports Microsoft.Data.SqlClient
Imports Windows.Win32.UI.Controls
Public Class AdminForm
    Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CaseStudy;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")
    Private Sub ColumnLoadRecord()
        dgvRecord.Columns.Clear()
        dgvRecord.Columns.Add("Username", "User Name") 'The first part which is the car Name
        dgvRecord.Columns("Username").Width = 150
        dgvRecord.Columns.Add("Record", "Record")
        For Each column As DataGridViewColumn In dgvRecord.Columns 'loops to make the cells fill
            If column.Name <> "Username" Then 'condition that the first column CarName will not affected by fill
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End If
        Next
    End Sub
    Private Sub RowLoaderRecord() 'Loads the Rows AKA the car lists
        dgvRecord.Rows.Clear()
        Dim query As String = "SELECT Username, Records FROM login ORDER BY Username"
        con.Open()
        Dim cmd As New SqlCommand(query, con)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            Dim rowIndex As Integer = dgvRecord.Rows.Add()
            dgvRecord.Rows(rowIndex).Cells("Username").Value = reader("Username").ToString()
            dgvRecord.Rows(rowIndex).Cells("Record").Value = reader("Records").ToString()
        End While
        con.Close()
    End Sub
    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColumnLoadRecord()
        RowLoaderRecord()
        ColumnLoadCarList()
        RowLoaderCarList()
    End Sub
    Private Sub btnGood_Click(sender As Object, e As EventArgs) Handles btnGood.Click
        If dgvRecord.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a user to mark as 'Good'.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim UsernameID As String = dgvRecord.CurrentRow.Cells("Username").Value.ToString()
        Dim query As String = "UPDATE login SET Records = @Record Where Username = @Username"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@Username", UsernameID)
        cmd.Parameters.AddWithValue("@Record", "Good")
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        ColumnLoadRecord()
        RowLoaderRecord()
    End Sub
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

    Private Sub ColumnLoadCarList()
        dgvCars.Columns.Clear()
        dgvCars.Columns.Add("CarName", "Car Name") 'The first part which is the car Name
        dgvCars.Columns("CarName").Width = 250
        dgvCars.Columns.Add("Color", "Color")
        dgvCars.Columns.Add("GasType", "Gas Type")
        dgvCars.Columns.Add("Capacity", "Capacity")
        dgvCars.Columns.Add("PlateNo", "Plate Number")
        dgvCars.Columns.Add("VIN", "Body Number")
        dgvCars.Columns("VIN").Width = 180
        dgvCars.Columns.Add("Rate", "Base Rate")
        For Each column As DataGridViewColumn In dgvCars.Columns 'loops to make the cells fill
            If column.Name <> "CarName" And column.Name <> "VIN" Then 'condition that the first column CarName will not affected by fill
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End If
        Next
    End Sub
    Private Sub RowLoaderCarList() 'Loads the Rows AKA the car lists
        dgvCars.Rows.Clear()
        Dim query As String = "SELECT CarName, Color, GasType,Capacity, PlateNo, VIN, Rate FROM CarRent ORDER BY CarName"
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
End Class