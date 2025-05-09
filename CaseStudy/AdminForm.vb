Imports System.Text.RegularExpressions
Imports Windows.Win32.System
Imports Microsoft.Data.SqlClient
Imports Windows.Win32.UI.Controls
Public Class AdminForm
    Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomerDB;Integrated Security=True")
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
End Class