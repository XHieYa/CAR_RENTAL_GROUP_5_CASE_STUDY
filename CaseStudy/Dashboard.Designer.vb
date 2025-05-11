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
        Label12 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox5 = New PictureBox()
        Label19 = New Label()
        Label20 = New Label()
        lblgreet = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        lblRecord = New Label()
        lblEmail = New Label()
        lblDOB = New Label()
        lblAddress = New Label()
        lblSex = New Label()
        lblAge = New Label()
        lblFullName = New Label()
        Label2 = New Label()
        TabPage2 = New TabPage()
        BtnSchedCheck = New Button()
        btnCalculate = New Button()
        btnDelete = New Button()
        dgLogs = New DataGridView()
        BtnUpdate = New Button()
        ToDOB = New DateTimePicker()
        FromDOB = New DateTimePicker()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(dgLogs, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Font = New Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(16, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1291, 643)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), Image)
        TabPage1.Controls.Add(Label12)
        TabPage1.Controls.Add(PictureBox1)
        TabPage1.Controls.Add(PictureBox5)
        TabPage1.Controls.Add(Label19)
        TabPage1.Controls.Add(Label20)
        TabPage1.Controls.Add(lblgreet)
        TabPage1.Controls.Add(Label11)
        TabPage1.Controls.Add(Label10)
        TabPage1.Controls.Add(Label9)
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(lblRecord)
        TabPage1.Controls.Add(lblEmail)
        TabPage1.Controls.Add(lblDOB)
        TabPage1.Controls.Add(lblAddress)
        TabPage1.Controls.Add(lblSex)
        TabPage1.Controls.Add(lblAge)
        TabPage1.Controls.Add(lblFullName)
        TabPage1.Controls.Add(Label2)
        TabPage1.Font = New Font("Stencil", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabPage1.Location = New Point(4, 26)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1283, 607)
        TabPage1.TabIndex = 0
        TabPage1.Text = "🚘Home── .✦"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(1013, 74)
        Label12.Name = "Label12"
        Label12.Size = New Size(110, 32)
        Label12.TabIndex = 18
        Label12.Text = "🛣🛤🛣"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1023, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(102, 83)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 35
        PictureBox1.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(2, 382)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(119, 68)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 31
        PictureBox5.TabStop = False
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.Transparent
        Label19.Font = New Font("Footlight MT Light", 7.8F)
        Label19.Location = New Point(2, 360)
        Label19.Name = "Label19"
        Label19.Size = New Size(83, 12)
        Label19.TabIndex = 30
        Label19.Text = "WheelAway, Inc."
        Label19.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.Transparent
        Label20.Font = New Font("Footlight MT Light", 7.8F)
        Label20.Location = New Point(2, 370)
        Label20.Name = "Label20"
        Label20.Size = New Size(113, 12)
        Label20.TabIndex = 29
        Label20.Text = "wheelaway@gmail.com"
        Label20.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblgreet
        ' 
        lblgreet.AutoSize = True
        lblgreet.Font = New Font("Stencil", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblgreet.ForeColor = Color.Black
        lblgreet.Location = New Point(82, 14)
        lblgreet.Name = "lblgreet"
        lblgreet.Size = New Size(800, 29)
        lblgreet.TabIndex = 0
        lblgreet.Text = "Welcome to Wheel-Away, [user]! Let's get you on the road."
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 12.0F)
        Label11.Location = New Point(436, 277)
        Label11.Name = "Label11"
        Label11.Size = New Size(86, 21)
        Label11.TabIndex = 17
        Label11.Text = "𓇻 Record:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 12.0F)
        Label10.Location = New Point(685, 212)
        Label10.Name = "Label10"
        Label10.Size = New Size(57, 21)
        Label10.TabIndex = 16
        Label10.Text = "✪ Sex:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 12.0F)
        Label9.Location = New Point(685, 186)
        Label9.Name = "Label9"
        Label9.Size = New Size(132, 21)
        Label9.TabIndex = 15
        Label9.Text = "✪ Date Of Birth:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 12.0F)
        Label8.Location = New Point(685, 158)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 21)
        Label8.TabIndex = 14
        Label8.Text = "✪ Age:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 12.0F)
        Label7.Location = New Point(188, 212)
        Label7.Name = "Label7"
        Label7.Size = New Size(93, 21)
        Label7.TabIndex = 13
        Label7.Text = "✪ Address:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12.0F)
        Label6.Location = New Point(188, 186)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 21)
        Label6.TabIndex = 12
        Label6.Text = "✪ Email:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12.0F)
        Label5.Location = New Point(188, 158)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 21)
        Label5.TabIndex = 11
        Label5.Text = "✪ Fullname:"
        ' 
        ' lblRecord
        ' 
        lblRecord.AutoSize = True
        lblRecord.Font = New Font("Century Gothic", 12.0F)
        lblRecord.Location = New Point(528, 277)
        lblRecord.Name = "lblRecord"
        lblRecord.Size = New Size(54, 21)
        lblRecord.TabIndex = 9
        lblRecord.Text = "[User]"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Century Gothic", 12.0F)
        lblEmail.Location = New Point(273, 186)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(54, 21)
        lblEmail.TabIndex = 8
        lblEmail.Text = "[User]"
        ' 
        ' lblDOB
        ' 
        lblDOB.AutoSize = True
        lblDOB.Font = New Font("Century Gothic", 12.0F)
        lblDOB.Location = New Point(823, 186)
        lblDOB.Name = "lblDOB"
        lblDOB.Size = New Size(54, 21)
        lblDOB.TabIndex = 6
        lblDOB.Text = "[User]"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Underline)
        lblAddress.ForeColor = Color.Black
        lblAddress.Location = New Point(298, 212)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(61, 23)
        lblAddress.TabIndex = 5
        lblAddress.Text = "[User]"
        ' 
        ' lblSex
        ' 
        lblSex.AutoSize = True
        lblSex.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Underline)
        lblSex.ForeColor = Color.Black
        lblSex.Location = New Point(749, 212)
        lblSex.Name = "lblSex"
        lblSex.Size = New Size(61, 23)
        lblSex.TabIndex = 4
        lblSex.Text = "[User]"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Underline)
        lblAge.ForeColor = Color.Black
        lblAge.Location = New Point(758, 158)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(61, 23)
        lblAge.TabIndex = 3
        lblAge.Text = "[User]"
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Underline)
        lblFullName.ForeColor = Color.Black
        lblFullName.Location = New Point(311, 158)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(61, 23)
        lblFullName.TabIndex = 2
        lblFullName.Text = "[User]"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Felix Titling", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(46, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(345, 25)
        Label2.TabIndex = 1
        Label2.Text = "˙⋆✮  Basic Information ✮⋆˙"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(BtnSchedCheck)
        TabPage2.Controls.Add(btnCalculate)
        TabPage2.Controls.Add(btnDelete)
        TabPage2.Controls.Add(dgLogs)
        TabPage2.Controls.Add(BtnUpdate)
        TabPage2.Controls.Add(ToDOB)
        TabPage2.Controls.Add(FromDOB)
        TabPage2.Location = New Point(4, 26)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1283, 613)
        TabPage2.TabIndex = 1
        TabPage2.Text = "🚘Records── .✦"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' BtnSchedCheck
        ' 
        BtnSchedCheck.BackColor = Color.PaleGoldenrod
        BtnSchedCheck.Font = New Font("Century", 12.0F, FontStyle.Bold)
        BtnSchedCheck.ForeColor = Color.Black
        BtnSchedCheck.Location = New Point(470, 576)
        BtnSchedCheck.Margin = New Padding(3, 4, 3, 4)
        BtnSchedCheck.Name = "BtnSchedCheck"
        BtnSchedCheck.Size = New Size(187, 23)
        BtnSchedCheck.TabIndex = 8
        BtnSchedCheck.Text = "Schedule Reviewer"
        BtnSchedCheck.UseVisualStyleBackColor = True
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Font = New Font("Century", 12.0F, FontStyle.Bold)
        btnCalculate.ForeColor = Color.Black
        btnCalculate.Location = New Point(250, 576)
        btnCalculate.Margin = New Padding(3, 4, 3, 4)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(214, 23)
        btnCalculate.TabIndex = 7
        btnCalculate.Text = "Review Total☆"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Century", 12.0F, FontStyle.Bold)
        btnDelete.ForeColor = Color.Black
        btnDelete.Location = New Point(777, 575)
        btnDelete.Margin = New Padding(3, 4, 3, 4)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(123, 24)
        btnDelete.TabIndex = 6
        btnDelete.Text = "Delete☆"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' dgLogs
        ' 
        dgLogs.AllowUserToAddRows = False
        dgLogs.AllowUserToDeleteRows = False
        dgLogs.AllowUserToResizeColumns = False
        dgLogs.AllowUserToResizeRows = False
        dgLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgLogs.BackgroundColor = Color.LightGoldenrodYellow
        dgLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgLogs.Location = New Point(18, 108)
        dgLogs.Margin = New Padding(3, 4, 3, 4)
        dgLogs.MultiSelect = False
        dgLogs.Name = "dgLogs"
        dgLogs.ReadOnly = True
        dgLogs.RowHeadersWidth = 51
        dgLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgLogs.Size = New Size(1251, 452)
        dgLogs.TabIndex = 0
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Font = New Font("Century", 12.0F, FontStyle.Bold)
        BtnUpdate.ForeColor = Color.Black
        BtnUpdate.Location = New Point(663, 576)
        BtnUpdate.Margin = New Padding(3, 2, 3, 2)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(108, 23)
        BtnUpdate.TabIndex = 3
        BtnUpdate.Text = "Update☆"
        BtnUpdate.UseVisualStyleBackColor = False
        ' 
        ' ToDOB
        ' 
        ToDOB.Font = New Font("Century Gothic", 12.0F)
        ToDOB.Location = New Point(537, 74)
        ToDOB.Margin = New Padding(3, 2, 3, 2)
        ToDOB.Name = "ToDOB"
        ToDOB.Size = New Size(290, 27)
        ToDOB.TabIndex = 2
        ' 
        ' FromDOB
        ' 
        FromDOB.Font = New Font("Century Gothic", 12.0F)
        FromDOB.Location = New Point(145, 74)
        FromDOB.Name = "FromDOB"
        FromDOB.Size = New Size(290, 27)
        FromDOB.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(176, 7)
        Label4.Name = "Label4"
        Label4.Size = New Size(901, 42)
        Label4.TabIndex = 37
        Label4.Text = "To ensure efficient operations, a detailed schedule was distributed, providing a " & vbCrLf & "complete overview of each user's rental, including their assigned vehicle."
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(1167, -8)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(116, 108)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 36
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12.0F)
        Label3.Location = New Point(316, 407)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 23)
        Label3.TabIndex = 5
        Label3.Text = "To: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12.0F)
        Label1.Location = New Point(17, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 23)
        Label1.TabIndex = 4
        Label1.Text = "From:"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.PaleGoldenrod
        Button1.Font = New Font("Century", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1142, 661)
        Button1.Name = "Button1"
        Button1.Size = New Size(109, 26)
        Button1.TabIndex = 7
        Button1.Text = "Continue↪"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1334, 699)
        Controls.Add(TabControl1)
        Controls.Add(Button1)
        Name = "Dashboard"
        Text = "🚘Dashboard── .✦"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        CType(dgLogs, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button1 As Button
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblRecord As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents dgLogs As DataGridView
    Friend WithEvents BtnSchedCheck As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnDelete As Button
End Class
