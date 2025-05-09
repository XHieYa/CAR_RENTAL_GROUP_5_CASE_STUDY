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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label4 = New Label()
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
        TabControl1.Font = New Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(21, 13)
        TabControl1.Margin = New Padding(3, 4, 3, 4)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1293, 635)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackgroundImageLayout = ImageLayout.Stretch
        TabPage1.Controls.Add(Label4)
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
        TabPage1.Font = New Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabPage1.Location = New Point(4, 30)
        TabPage1.Margin = New Padding(3, 4, 3, 4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3, 4, 3, 4)
        TabPage1.Size = New Size(1285, 601)
        TabPage1.TabIndex = 0
        TabPage1.Text = "🚘Home── .✦"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Stencil", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(1097, 16)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 44)
        Label4.TabIndex = 10
        Label4.Text = "🛣🛤"
        ' 
        ' lblRecord
        ' 
        lblRecord.AutoSize = True
        lblRecord.Font = New Font("Century Gothic", 12F)
        lblRecord.Location = New Point(501, 358)
        lblRecord.Name = "lblRecord"
        lblRecord.Size = New Size(167, 23)
        lblRecord.TabIndex = 9
        lblRecord.Text = "𓇻 Record: [User]"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Century Gothic", 12F)
        lblEmail.Location = New Point(218, 235)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(145, 23)
        lblEmail.TabIndex = 8
        lblEmail.Text = "✪ Email: [User]"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1162, 559)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 34)
        Button1.TabIndex = 7
        Button1.Text = "Continue"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblDOB
        ' 
        lblDOB.AutoSize = True
        lblDOB.Font = New Font("Century Gothic", 12F)
        lblDOB.Location = New Point(786, 235)
        lblDOB.Name = "lblDOB"
        lblDOB.Size = New Size(216, 23)
        lblDOB.TabIndex = 6
        lblDOB.Text = "✪ Date Of Birth: [User]"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Century Gothic", 12F)
        lblAddress.Location = New Point(218, 270)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(171, 23)
        lblAddress.TabIndex = 5
        lblAddress.Text = "✪ Address: [User]"
        ' 
        ' lblSex
        ' 
        lblSex.AutoSize = True
        lblSex.Font = New Font("Century Gothic", 12F)
        lblSex.Location = New Point(786, 270)
        lblSex.Name = "lblSex"
        lblSex.Size = New Size(126, 23)
        lblSex.TabIndex = 4
        lblSex.Text = "✪ Sex: [User]"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Font = New Font("Century Gothic", 12F)
        lblAge.Location = New Point(786, 198)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(134, 23)
        lblAge.TabIndex = 3
        lblAge.Text = "✪ Age: [User]"
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Century Gothic", 12F)
        lblFullName.Location = New Point(218, 198)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(183, 23)
        lblFullName.TabIndex = 2
        lblFullName.Text = "✪ Fullname: [User]"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Felix Titling", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(37, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(364, 27)
        Label2.TabIndex = 1
        Label2.Text = "˙⋆✮  Basic Information ✮⋆˙"
        ' 
        ' lblgreet
        ' 
        lblgreet.AutoSize = True
        lblgreet.Font = New Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblgreet.Location = New Point(107, 25)
        lblgreet.Name = "lblgreet"
        lblgreet.Size = New Size(1001, 35)
        lblgreet.TabIndex = 0
        lblgreet.Text = "Welcome to Wheel-Away, [user]! Let's get you on the road."
        ' 
        ' TabPage2
        ' 
        TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), Image)
        TabPage2.Controls.Add(BtnDelete)
        TabPage2.Controls.Add(Label3)
        TabPage2.Controls.Add(Label1)
        TabPage2.Controls.Add(BtnUpdate)
        TabPage2.Controls.Add(ToDOB)
        TabPage2.Controls.Add(FromDOB)
        TabPage2.Controls.Add(DGLogs)
        TabPage2.Location = New Point(4, 30)
        TabPage2.Margin = New Padding(3, 4, 3, 4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3, 4, 3, 4)
        TabPage2.Size = New Size(1285, 601)
        TabPage2.TabIndex = 1
        TabPage2.Text = "🚘Records── .✦"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Font = New Font("Century", 12F, FontStyle.Bold)
        BtnDelete.Location = New Point(1145, 562)
        BtnDelete.Margin = New Padding(3, 4, 3, 4)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(123, 31)
        BtnDelete.TabIndex = 6
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F)
        Label3.Location = New Point(361, 543)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 23)
        Label3.TabIndex = 5
        Label3.Text = "To: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F)
        Label1.Location = New Point(19, 543)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 23)
        Label1.TabIndex = 4
        Label1.Text = "From:"
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Font = New Font("Century", 12F, FontStyle.Bold)
        BtnUpdate.Location = New Point(1145, 525)
        BtnUpdate.Margin = New Padding(3, 4, 3, 4)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(123, 31)
        BtnUpdate.TabIndex = 3
        BtnUpdate.Text = "Update"
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' ToDOB
        ' 
        ToDOB.Font = New Font("Century Gothic", 12F)
        ToDOB.Location = New Point(403, 543)
        ToDOB.Margin = New Padding(3, 4, 3, 4)
        ToDOB.Name = "ToDOB"
        ToDOB.Size = New Size(259, 32)
        ToDOB.TabIndex = 2
        ' 
        ' FromDOB
        ' 
        FromDOB.Font = New Font("Century Gothic", 12F)
        FromDOB.Location = New Point(83, 543)
        FromDOB.Margin = New Padding(3, 4, 3, 4)
        FromDOB.Name = "FromDOB"
        FromDOB.Size = New Size(259, 32)
        FromDOB.TabIndex = 1
        ' 
        ' DGLogs
        ' 
        DGLogs.AllowUserToAddRows = False
        DGLogs.AllowUserToDeleteRows = False
        DGLogs.AllowUserToResizeColumns = False
        DGLogs.AllowUserToResizeRows = False
        DGLogs.BackgroundColor = Color.LightGoldenrodYellow
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
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
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
    Friend WithEvents Label4 As Label
End Class
