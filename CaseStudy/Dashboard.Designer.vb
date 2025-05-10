<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
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
        btnCalculate = New Button()
        BtnDelete = New Button()
        Label3 = New Label()
        Label1 = New Label()
        BtnUpdate = New Button()
        ToDOB = New DateTimePicker()
        FromDOB = New DateTimePicker()
        DGLogs = New DataGridView()
        BtnSchedCheck = New Button()
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
        TabControl1.Location = New Point(18, 10)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1131, 476)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackgroundImageLayout = ImageLayout.Stretch
        TabPage1.Controls.Add(Label11)
        TabPage1.Controls.Add(Label10)
        TabPage1.Controls.Add(Label9)
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label5)
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
        TabPage1.Font = New Font("Stencil", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabPage1.Location = New Point(4, 26)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1123, 446)
        TabPage1.TabIndex = 0
        TabPage1.Text = "🚘Home── .✦"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 12.0F)
        Label11.Location = New Point(438, 267)
        Label11.Name = "Label11"
        Label11.Size = New Size(86, 21)
        Label11.TabIndex = 17
        Label11.Text = "𓇻 Record:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 12.0F)
        Label10.Location = New Point(688, 202)
        Label10.Name = "Label10"
        Label10.Size = New Size(57, 21)
        Label10.TabIndex = 16
        Label10.Text = "✪ Sex:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 12.0F)
        Label9.Location = New Point(688, 176)
        Label9.Name = "Label9"
        Label9.Size = New Size(132, 21)
        Label9.TabIndex = 15
        Label9.Text = "✪ Date Of Birth:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 12.0F)
        Label8.Location = New Point(688, 148)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 21)
        Label8.TabIndex = 14
        Label8.Text = "✪ Age:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 12.0F)
        Label7.Location = New Point(191, 202)
        Label7.Name = "Label7"
        Label7.Size = New Size(93, 21)
        Label7.TabIndex = 13
        Label7.Text = "✪ Address:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12.0F)
        Label6.Location = New Point(191, 176)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 21)
        Label6.TabIndex = 12
        Label6.Text = "✪ Email:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12.0F)
        Label5.Location = New Point(191, 148)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 21)
        Label5.TabIndex = 11
        Label5.Text = "✪ Fullname:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Stencil", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(960, 12)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 35)
        Label4.TabIndex = 10
        Label4.Text = "🛣🛤"
        ' 
        ' lblRecord
        ' 
        lblRecord.AutoSize = True
        lblRecord.Font = New Font("Century Gothic", 12.0F)
        lblRecord.Location = New Point(517, 267)
        lblRecord.Name = "lblRecord"
        lblRecord.Size = New Size(54, 21)
        lblRecord.TabIndex = 9
        lblRecord.Text = "[User]"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Century Gothic", 12.0F)
        lblEmail.Location = New Point(259, 176)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(54, 21)
        lblEmail.TabIndex = 8
        lblEmail.Text = "[User]"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Century", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1017, 419)
        Button1.Name = "Button1"
        Button1.Size = New Size(102, 26)
        Button1.TabIndex = 7
        Button1.Text = "Continue"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblDOB
        ' 
        lblDOB.AutoSize = True
        lblDOB.Font = New Font("Century Gothic", 12.0F)
        lblDOB.Location = New Point(815, 176)
        lblDOB.Name = "lblDOB"
        lblDOB.Size = New Size(54, 21)
        lblDOB.TabIndex = 6
        lblDOB.Text = "[User]"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Century Gothic", 12.0F)
        lblAddress.Location = New Point(279, 202)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(54, 21)
        lblAddress.TabIndex = 5
        lblAddress.Text = "[User]"
        ' 
        ' lblSex
        ' 
        lblSex.AutoSize = True
        lblSex.Font = New Font("Century Gothic", 12.0F)
        lblSex.Location = New Point(739, 202)
        lblSex.Name = "lblSex"
        lblSex.Size = New Size(54, 21)
        lblSex.TabIndex = 4
        lblSex.Text = "[User]"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Font = New Font("Century Gothic", 12.0F)
        lblAge.Location = New Point(749, 148)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(54, 21)
        lblAge.TabIndex = 3
        lblAge.Text = "[User]"
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Century Gothic", 12.0F)
        lblFullName.Location = New Point(288, 148)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(54, 21)
        lblFullName.TabIndex = 2
        lblFullName.Text = "[User]"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Felix Titling", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(32, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(301, 23)
        Label2.TabIndex = 1
        Label2.Text = "˙⋆✮  Basic Information ✮⋆˙"
        ' 
        ' lblgreet
        ' 
        lblgreet.AutoSize = True
        lblgreet.Font = New Font("Stencil", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblgreet.Location = New Point(94, 19)
        lblgreet.Name = "lblgreet"
        lblgreet.Size = New Size(800, 29)
        lblgreet.TabIndex = 0
        lblgreet.Text = "Welcome to Wheel-Away, [user]! Let's get you on the road."
        ' 
        ' TabPage2
        ' 
        TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), Image)
        TabPage2.Controls.Add(BtnSchedCheck)
        TabPage2.Controls.Add(btnCalculate)
        TabPage2.Controls.Add(BtnDelete)
        TabPage2.Controls.Add(Label3)
        TabPage2.Controls.Add(Label1)
        TabPage2.Controls.Add(BtnUpdate)
        TabPage2.Controls.Add(ToDOB)
        TabPage2.Controls.Add(FromDOB)
        TabPage2.Controls.Add(DGLogs)
        TabPage2.Location = New Point(4, 26)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1123, 446)
        TabPage2.TabIndex = 1
        TabPage2.Text = "🚘Records── .✦"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Font = New Font("Century", 12.0F, FontStyle.Bold)
        btnCalculate.Location = New Point(809, 422)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(187, 23)
        btnCalculate.TabIndex = 7
        btnCalculate.Text = "Calculate | Check"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Font = New Font("Century", 12.0F, FontStyle.Bold)
        BtnDelete.Location = New Point(1002, 422)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(108, 23)
        BtnDelete.TabIndex = 6
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12.0F)
        Label3.Location = New Point(316, 407)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 21)
        Label3.TabIndex = 5
        Label3.Text = "To: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12.0F)
        Label1.Location = New Point(17, 407)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 21)
        Label1.TabIndex = 4
        Label1.Text = "From:"
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Font = New Font("Century", 12.0F, FontStyle.Bold)
        BtnUpdate.Location = New Point(1002, 394)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(108, 23)
        BtnUpdate.TabIndex = 3
        BtnUpdate.Text = "Update"
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' ToDOB
        ' 
        ToDOB.Font = New Font("Century Gothic", 12.0F)
        ToDOB.Location = New Point(353, 407)
        ToDOB.Name = "ToDOB"
        ToDOB.Size = New Size(227, 27)
        ToDOB.TabIndex = 2
        ' 
        ' FromDOB
        ' 
        FromDOB.Font = New Font("Century Gothic", 12.0F)
        FromDOB.Location = New Point(73, 407)
        FromDOB.Name = "FromDOB"
        FromDOB.Size = New Size(227, 27)
        FromDOB.TabIndex = 1
        ' 
        ' DGLogs
        ' 
        DGLogs.AllowUserToAddRows = False
        DGLogs.AllowUserToDeleteRows = False
        DGLogs.AllowUserToResizeColumns = False
        DGLogs.AllowUserToResizeRows = False
        DGLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGLogs.BackgroundColor = Color.LightGoldenrodYellow
        DGLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGLogs.Location = New Point(15, 11)
        DGLogs.MultiSelect = False
        DGLogs.Name = "DGLogs"
        DGLogs.ReadOnly = True
        DGLogs.RowHeadersWidth = 51
        DGLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGLogs.Size = New Size(1095, 376)
        DGLogs.TabIndex = 0
        ' 
        ' BtnSchedCheck
        ' 
        BtnSchedCheck.Font = New Font("Century", 12.0F, FontStyle.Bold)
        BtnSchedCheck.Location = New Point(809, 394)
        BtnSchedCheck.Name = "BtnSchedCheck"
        BtnSchedCheck.Size = New Size(187, 23)
        BtnSchedCheck.TabIndex = 8
        BtnSchedCheck.Text = "Schedule Check"
        BtnSchedCheck.UseVisualStyleBackColor = True
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1160, 518)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnSchedCheck As Button
End Class
