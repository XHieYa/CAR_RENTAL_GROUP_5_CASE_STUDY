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
        lblRecord = New Label()
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
        TabControl1.Location = New Point(21, 13)
        TabControl1.Margin = New Padding(3, 4, 3, 4)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1293, 635)
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
        TabPage1.Location = New Point(4, 29)
        TabPage1.Margin = New Padding(3, 4, 3, 4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3, 4, 3, 4)
        TabPage1.Size = New Size(1285, 602)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Home"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' lblRecord
        ' 
        lblRecord.AutoSize = True
        lblRecord.Location = New Point(18, 177)
        lblRecord.Name = "lblRecord"
        lblRecord.Size = New Size(102, 20)
        lblRecord.TabIndex = 9
        lblRecord.Text = "Record: [User]"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(25, 157)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(92, 20)
        lblEmail.TabIndex = 8
        lblEmail.Text = "Email: [User]"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1140, 554)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(130, 40)
        Button1.TabIndex = 7
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblDOB
        ' 
        lblDOB.AutoSize = True
        lblDOB.Location = New Point(22, 137)
        lblDOB.Name = "lblDOB"
        lblDOB.Size = New Size(142, 20)
        lblDOB.TabIndex = 6
        lblDOB.Text = "Date Of Birth: [User]"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Location = New Point(18, 117)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(108, 20)
        lblAddress.TabIndex = 5
        lblAddress.Text = "Address: [User]"
        ' 
        ' lblSex
        ' 
        lblSex.AutoSize = True
        lblSex.Location = New Point(18, 97)
        lblSex.Name = "lblSex"
        lblSex.Size = New Size(78, 20)
        lblSex.TabIndex = 4
        lblSex.Text = "Sex: [User]"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Location = New Point(18, 77)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(82, 20)
        lblAge.TabIndex = 3
        lblAge.Text = "Age: [User]"
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Location = New Point(18, 57)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(115, 20)
        lblFullName.TabIndex = 2
        lblFullName.Text = "Fullname: [User]"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 20)
        Label2.TabIndex = 1
        Label2.Text = "Basic Information:"
        ' 
        ' lblgreet
        ' 
        lblgreet.AutoSize = True
        lblgreet.Location = New Point(22, 17)
        lblgreet.Name = "lblgreet"
        lblgreet.Size = New Size(272, 20)
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
        TabPage2.Location = New Point(4, 29)
        TabPage2.Margin = New Padding(3, 4, 3, 4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3, 4, 3, 4)
        TabPage2.Size = New Size(1285, 602)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Logs"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(1182, 563)
        BtnDelete.Margin = New Padding(3, 4, 3, 4)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(86, 31)
        BtnDelete.TabIndex = 6
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(713, 529)
        Label3.Name = "Label3"
        Label3.Size = New Size(32, 20)
        Label3.TabIndex = 5
        Label3.Text = "To: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(403, 529)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 20)
        Label1.TabIndex = 4
        Label1.Text = "From:"
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Location = New Point(1070, 563)
        BtnUpdate.Margin = New Padding(3, 4, 3, 4)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(86, 31)
        BtnUpdate.TabIndex = 3
        BtnUpdate.Text = "Update"
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' ToDOB
        ' 
        ToDOB.Location = New Point(748, 524)
        ToDOB.Margin = New Padding(3, 4, 3, 4)
        ToDOB.Name = "ToDOB"
        ToDOB.Size = New Size(228, 27)
        ToDOB.TabIndex = 2
        ' 
        ' FromDOB
        ' 
        FromDOB.Location = New Point(454, 524)
        FromDOB.Margin = New Padding(3, 4, 3, 4)
        FromDOB.Name = "FromDOB"
        FromDOB.Size = New Size(228, 27)
        FromDOB.TabIndex = 1
        ' 
        ' DGLogs
        ' 
        DGLogs.AllowUserToAddRows = False
        DGLogs.AllowUserToDeleteRows = False
        DGLogs.AllowUserToResizeColumns = False
        DGLogs.AllowUserToResizeRows = False
        DGLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGLogs.Location = New Point(17, 15)
        DGLogs.Margin = New Padding(3, 4, 3, 4)
        DGLogs.Name = "DGLogs"
        DGLogs.ReadOnly = True
        DGLogs.RowHeadersWidth = 51
        DGLogs.Size = New Size(1251, 501)
        DGLogs.TabIndex = 0
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1326, 690)
        Controls.Add(TabControl1)
        Margin = New Padding(3, 4, 3, 4)
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
