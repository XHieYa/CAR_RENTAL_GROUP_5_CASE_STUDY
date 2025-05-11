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
        lblgreet = New Label()
        Label12 = New Label()
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
        TabPage2 = New TabPage()
        BtnSchedCheck = New Button()
        btnCalculate = New Button()
        BtnDelete = New Button()
        Label3 = New Label()
        Label1 = New Label()
        BtnUpdate = New Button()
        ToDOB = New DateTimePicker()
        FromDOB = New DateTimePicker()
        DGLogs = New DataGridView()
        Button2 = New Button()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
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
        TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), Image)
        TabPage1.Controls.Add(lblgreet)
        TabPage1.Controls.Add(Label12)
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
        TabPage1.Controls.Add(lblDOB)
        TabPage1.Controls.Add(lblAddress)
        TabPage1.Controls.Add(lblSex)
        TabPage1.Controls.Add(lblAge)
        TabPage1.Controls.Add(lblFullName)
        TabPage1.Controls.Add(Label2)
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
        ' lblgreet
        ' 
        lblgreet.AutoSize = True
        lblgreet.Font = New Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblgreet.ForeColor = Color.Black
        lblgreet.Location = New Point(89, 27)
        lblgreet.Name = "lblgreet"
        lblgreet.Size = New Size(1119, 40)
        lblgreet.TabIndex = 0
        lblgreet.Text = "Welcome to Wheel-Away, [user]! Let's get you on the road."
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(3, 25)
        Label12.Name = "Label12"
        Label12.Size = New Size(97, 40)
        Label12.TabIndex = 18
        Label12.Text = "🛣🛤"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 13.8F)
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(516, 391)
        Label11.Name = "Label11"
        Label11.Size = New Size(124, 27)
        Label11.TabIndex = 17
        Label11.Text = "𓇻 Record:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 13.8F)
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(801, 304)
        Label10.Name = "Label10"
        Label10.Size = New Size(77, 27)
        Label10.TabIndex = 16
        Label10.Text = "✪ Sex:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 13.8F)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(801, 270)
        Label9.Name = "Label9"
        Label9.Size = New Size(183, 27)
        Label9.TabIndex = 15
        Label9.Text = "✪ Date Of Birth:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 13.8F)
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(801, 232)
        Label8.Name = "Label8"
        Label8.Size = New Size(87, 27)
        Label8.TabIndex = 14
        Label8.Text = "✪ Age:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 13.8F)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(233, 304)
        Label7.Name = "Label7"
        Label7.Size = New Size(129, 27)
        Label7.TabIndex = 13
        Label7.Text = "✪ Address:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 13.8F)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(233, 270)
        Label6.Name = "Label6"
        Label6.Size = New Size(102, 27)
        Label6.TabIndex = 12
        Label6.Text = "✪ Email:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 13.8F)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(233, 232)
        Label5.Name = "Label5"
        Label5.Size = New Size(144, 27)
        Label5.TabIndex = 11
        Label5.Text = "✪ Fullname:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(1198, 25)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 40)
        Label4.TabIndex = 10
        Label4.Text = "🛣🛤"
        ' 
        ' lblRecord
        ' 
        lblRecord.AutoSize = True
        lblRecord.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Underline)
        lblRecord.ForeColor = Color.Black
        lblRecord.Location = New Point(636, 391)
        lblRecord.Name = "lblRecord"
        lblRecord.Size = New Size(73, 27)
        lblRecord.TabIndex = 9
        lblRecord.Text = "[User]"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Underline)
        lblEmail.ForeColor = Color.Black
        lblEmail.Location = New Point(330, 270)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(73, 27)
        lblEmail.TabIndex = 8
        lblEmail.Text = "[User]"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.PaleGoldenrod
        Button1.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1186, 651)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(125, 35)
        Button1.TabIndex = 7
        Button1.Text = "Continue↪"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' lblDOB
        ' 
        lblDOB.AutoSize = True
        lblDOB.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Underline)
        lblDOB.ForeColor = Color.Black
        lblDOB.Location = New Point(980, 270)
        lblDOB.Name = "lblDOB"
        lblDOB.Size = New Size(73, 27)
        lblDOB.TabIndex = 6
        lblDOB.Text = "[User]"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Underline)
        lblAddress.ForeColor = Color.Black
        lblAddress.Location = New Point(359, 304)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(73, 27)
        lblAddress.TabIndex = 5
        lblAddress.Text = "[User]"
        ' 
        ' lblSex
        ' 
        lblSex.AutoSize = True
        lblSex.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Underline)
        lblSex.ForeColor = Color.Black
        lblSex.Location = New Point(874, 304)
        lblSex.Name = "lblSex"
        lblSex.Size = New Size(73, 27)
        lblSex.TabIndex = 4
        lblSex.Text = "[User]"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Underline)
        lblAge.ForeColor = Color.Black
        lblAge.Location = New Point(884, 232)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(73, 27)
        lblAge.TabIndex = 3
        lblAge.Text = "[User]"
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Underline)
        lblFullName.ForeColor = Color.Black
        lblFullName.Location = New Point(373, 232)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(73, 27)
        lblFullName.TabIndex = 2
        lblFullName.Text = "[User]"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Felix Titling", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(46, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(431, 33)
        Label2.TabIndex = 1
        Label2.Text = "˙⋆✮  Basic Information ✮⋆˙"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), Image)
        TabPage2.Controls.Add(Label16)
        TabPage2.Controls.Add(Label15)
        TabPage2.Controls.Add(Label14)
        TabPage2.Controls.Add(Label13)
        TabPage2.Controls.Add(BtnSchedCheck)
        TabPage2.Controls.Add(btnCalculate)
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
        ' BtnSchedCheck
        ' 
        BtnSchedCheck.BackColor = Color.PaleGoldenrod
        BtnSchedCheck.Font = New Font("Century", 12F, FontStyle.Bold)
        BtnSchedCheck.ForeColor = Color.Black
        BtnSchedCheck.Location = New Point(925, 525)
        BtnSchedCheck.Margin = New Padding(3, 4, 3, 4)
        BtnSchedCheck.Name = "BtnSchedCheck"
        BtnSchedCheck.Size = New Size(214, 31)
        BtnSchedCheck.TabIndex = 8
        BtnSchedCheck.Text = " Schedule Review"
        BtnSchedCheck.UseVisualStyleBackColor = False
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.PaleGoldenrod
        btnCalculate.Font = New Font("Century", 12F, FontStyle.Bold)
        btnCalculate.ForeColor = Color.Black
        btnCalculate.Location = New Point(925, 563)
        btnCalculate.Margin = New Padding(3, 4, 3, 4)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(214, 31)
        btnCalculate.TabIndex = 7
        btnCalculate.Text = "Review Total"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' BtnDelete
        ' 
        BtnDelete.BackColor = Color.PaleGoldenrod
        BtnDelete.Font = New Font("Century", 12F, FontStyle.Bold)
        BtnDelete.ForeColor = Color.Black
        BtnDelete.Location = New Point(1145, 563)
        BtnDelete.Margin = New Padding(3, 4, 3, 4)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(123, 31)
        BtnDelete.TabIndex = 6
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = False
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
        BtnUpdate.BackColor = Color.PaleGoldenrod
        BtnUpdate.Font = New Font("Century", 12F, FontStyle.Bold)
        BtnUpdate.ForeColor = Color.Black
        BtnUpdate.Location = New Point(1145, 525)
        BtnUpdate.Margin = New Padding(3, 4, 3, 4)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(123, 31)
        BtnUpdate.TabIndex = 3
        BtnUpdate.Text = "Update"
        BtnUpdate.UseVisualStyleBackColor = False
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
        DGLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGLogs.BackgroundColor = Color.LightGoldenrodYellow
        DGLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGLogs.Location = New Point(17, 15)
        DGLogs.Margin = New Padding(3, 4, 3, 4)
        DGLogs.MultiSelect = False
        DGLogs.Name = "DGLogs"
        DGLogs.ReadOnly = True
        DGLogs.RowHeadersWidth = 51
        DGLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGLogs.Size = New Size(1251, 501)
        DGLogs.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.PaleGoldenrod
        Button2.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(24, 651)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(125, 35)
        Button2.TabIndex = 19
        Button2.Text = "↩Back"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(170, 519)
        Label13.Name = "Label13"
        Label13.Size = New Size(91, 21)
        Label13.TabIndex = 9
        Label13.Text = "─── ⋆⋅☆⋅⋆ ──"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(488, 518)
        Label14.Name = "Label14"
        Label14.Size = New Size(91, 21)
        Label14.TabIndex = 10
        Label14.Text = "─── ⋆⋅☆⋅⋆ ──"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(488, 576)
        Label15.Name = "Label15"
        Label15.Size = New Size(91, 21)
        Label15.TabIndex = 11
        Label15.Text = "─── ⋆⋅☆⋅⋆ ──"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(170, 576)
        Label16.Name = "Label16"
        Label16.Size = New Size(91, 21)
        Label16.TabIndex = 12
        Label16.Text = "─── ⋆⋅☆⋅⋆ ──"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1326, 691)
        Controls.Add(Button2)
        Controls.Add(TabControl1)
        Controls.Add(Button1)
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
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnSchedCheck As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button2 As Button
End Class
