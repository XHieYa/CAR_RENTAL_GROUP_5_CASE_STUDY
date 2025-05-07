<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        lblEmail = New Label()
        Button1 = New Button()
        lblDOB = New Label()
        lblAddress = New Label()
        lblSex = New Label()
        lblAge = New Label()
        lblFullName = New Label()
        Label2 = New Label()
        lblgreet = New Label()
        TabPage2 = New TabPage()
        BtnDelete = New Button()
        Label3 = New Label()
        Label1 = New Label()
        BtnUpdate = New Button()
        ToDOB = New DateTimePicker()
        FromDOB = New DateTimePicker()
        DGLogs = New DataGridView()
        lblRecord = New Label()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(DGLogs, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(-1, -2)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(802, 455)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(lblRecord)
        TabPage1.Controls.Add(lblEmail)
        TabPage1.Controls.Add(Button1)
        TabPage1.Controls.Add(lblDOB)
        TabPage1.Controls.Add(lblAddress)
        TabPage1.Controls.Add(lblSex)
        TabPage1.Controls.Add(lblAge)
        TabPage1.Controls.Add(lblFullName)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(lblgreet)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(794, 427)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Home"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(9, 108)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(73, 15)
        lblEmail.TabIndex = 8
        lblEmail.Text = "Email: [User]"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(567, 328)
        Button1.Name = "Button1"
        Button1.Size = New Size(114, 30)
        Button1.TabIndex = 7
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblDOB
        ' 
        lblDOB.AutoSize = True
        lblDOB.Location = New Point(6, 93)
        lblDOB.Name = "lblDOB"
        lblDOB.Size = New Size(112, 15)
        lblDOB.TabIndex = 6
        lblDOB.Text = "Date Of Birth: [User]"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Location = New Point(3, 78)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(86, 15)
        lblAddress.TabIndex = 5
        lblAddress.Text = "Address: [User]"
        ' 
        ' lblSex
        ' 
        lblSex.AutoSize = True
        lblSex.Location = New Point(3, 63)
        lblSex.Name = "lblSex"
        lblSex.Size = New Size(62, 15)
        lblSex.TabIndex = 4
        lblSex.Text = "Sex: [User]"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Location = New Point(3, 48)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(65, 15)
        lblAge.TabIndex = 3
        lblAge.Text = "Age: [User]"
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Location = New Point(3, 33)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(93, 15)
        lblFullName.TabIndex = 2
        lblFullName.Text = "Fullname: [User]"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 15)
        Label2.TabIndex = 1
        Label2.Text = "Basic Information:"
        ' 
        ' lblgreet
        ' 
        lblgreet.AutoSize = True
        lblgreet.Location = New Point(6, 3)
        lblgreet.Name = "lblgreet"
        lblgreet.Size = New Size(215, 15)
        lblgreet.TabIndex = 0
        lblgreet.Text = "Hello, [user] Welcome to Rent 4 Wheelz"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(BtnDelete)
        TabPage2.Controls.Add(Label3)
        TabPage2.Controls.Add(Label1)
        TabPage2.Controls.Add(BtnUpdate)
        TabPage2.Controls.Add(ToDOB)
        TabPage2.Controls.Add(FromDOB)
        TabPage2.Controls.Add(DGLogs)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(794, 427)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Logs"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(697, 393)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(75, 23)
        BtnDelete.TabIndex = 6
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(315, 397)
        Label3.Name = "Label3"
        Label3.Size = New Size(25, 15)
        Label3.TabIndex = 5
        Label3.Text = "To: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(44, 397)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 15)
        Label1.TabIndex = 4
        Label1.Text = "From:"
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Location = New Point(599, 393)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(75, 23)
        BtnUpdate.TabIndex = 3
        BtnUpdate.Text = "Update"
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' ToDOB
        ' 
        ToDOB.Location = New Point(346, 393)
        ToDOB.Name = "ToDOB"
        ToDOB.Size = New Size(200, 23)
        ToDOB.TabIndex = 2
        ' 
        ' FromDOB
        ' 
        FromDOB.Location = New Point(88, 393)
        FromDOB.Name = "FromDOB"
        FromDOB.Size = New Size(200, 23)
        FromDOB.TabIndex = 1
        ' 
        ' DGLogs
        ' 
        DGLogs.AllowUserToAddRows = False
        DGLogs.AllowUserToDeleteRows = False
        DGLogs.AllowUserToResizeColumns = False
        DGLogs.AllowUserToResizeRows = False
        DGLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGLogs.Location = New Point(0, 0)
        DGLogs.Name = "DGLogs"
        DGLogs.ReadOnly = True
        DGLogs.Size = New Size(794, 376)
        DGLogs.TabIndex = 0
        ' 
        ' lblRecord
        ' 
        lblRecord.AutoSize = True
        lblRecord.Location = New Point(3, 123)
        lblRecord.Name = "lblRecord"
        lblRecord.Size = New Size(81, 15)
        lblRecord.TabIndex = 9
        lblRecord.Text = "Record: [User]"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TabControl1)
        Name = "Dashboard"
        Text = "Dashboard"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(DGLogs, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents lblgreet As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblSex As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents ToDOB As DateTimePicker
    Friend WithEvents FromDOB As DateTimePicker
    Friend WithEvents DGLogs As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents lblEmail As Label
    Friend WithEvents BtnDelete As Button
    Friend WithEvents lblRecord As Label
End Class
