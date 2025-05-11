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
        Label4 = New Label()
        DGLogs = New DataGridView()
        PictureBox2 = New PictureBox()
        BtnSchedCheck = New Button()
        btnCalculate = New Button()
        BtnDelete = New Button()
        Label3 = New Label()
        Label1 = New Label()
        BtnUpdate = New Button()
        ToDOB = New DateTimePicker()
        FromDOB = New DateTimePicker()
        Button1 = New Button()
        Button2 = New Button()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(DGLogs, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
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
        TabPage1.Location = New Point(4, 30)
        TabPage1.Margin = New Padding(3, 4, 3, 4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3, 4, 3, 4)
        TabPage1.Size = New Size(1285, 601)
        TabPage1.TabIndex = 0
        TabPage1.Text = "🚘Home── .✦"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(1158, 99)
        Label12.Name = "Label12"
        Label12.Size = New Size(137, 40)
        Label12.TabIndex = 18
        Label12.Text = "🛣🛤🛣"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1169, -2)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(116, 111)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 35
        PictureBox1.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(2, 510)
        PictureBox5.Margin = New Padding(3, 4, 3, 4)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(136, 91)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 31
        PictureBox5.TabStop = False
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.Transparent
        Label19.Font = New Font("Footlight MT Light", 7.8F)
        Label19.Location = New Point(2, 480)
        Label19.Name = "Label19"
        Label19.Size = New Size(99, 14)
        Label19.TabIndex = 30
        Label19.Text = "WheelAway, Inc."
        Label19.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.Transparent
        Label20.Font = New Font("Footlight MT Light", 7.8F)
        Label20.Location = New Point(2, 494)
        Label20.Name = "Label20"
        Label20.Size = New Size(136, 14)
        Label20.TabIndex = 29
        Label20.Text = "wheelaway@gmail.com"
        Label20.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblgreet
        ' 
        lblgreet.AutoSize = True
        lblgreet.Font = New Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblgreet.ForeColor = Color.Black
        lblgreet.Location = New Point(29, 31)
        lblgreet.Name = "lblgreet"
        lblgreet.Size = New Size(1119, 40)
        lblgreet.TabIndex = 0
        lblgreet.Text = "Welcome to Wheel-Away, [user]! Let's get you on the road."
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 12.0F)
        Label11.Location = New Point(438, 267)
        Label11.Location = New Point(498, 369)
        Label11.Name = "Label11"
        Label11.Size = New Size(124, 27)
        Label11.TabIndex = 17
        Label11.Text = "𓇻 Record:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 12.0F)
        Label10.Location = New Point(688, 202)
        Label10.Location = New Point(783, 282)
        Label10.Name = "Label10"
        Label10.Size = New Size(77, 27)
        Label10.TabIndex = 16
        Label10.Text = "✪ Sex:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 12.0F)
        Label9.Location = New Point(688, 176)
        Label9.Location = New Point(783, 248)
        Label9.Name = "Label9"
        Label9.Size = New Size(183, 27)
        Label9.TabIndex = 15
        Label9.Text = "✪ Date Of Birth:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 12.0F)
        Label8.Location = New Point(688, 148)
        Label8.Location = New Point(783, 210)
        Label8.Name = "Label8"
        Label8.Size = New Size(87, 27)
        Label8.TabIndex = 14
        Label8.Text = "✪ Age:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 12.0F)
        Label7.Location = New Point(191, 202)
        Label7.Location = New Point(215, 282)
        Label7.Name = "Label7"
        Label7.Size = New Size(129, 27)
        Label7.TabIndex = 13
        Label7.Text = "✪ Address:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12.0F)
        Label6.Location = New Point(191, 176)
        Label6.Location = New Point(215, 248)
        Label6.Name = "Label6"
        Label6.Size = New Size(102, 27)
        Label6.TabIndex = 12
        Label6.Text = "✪ Email:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12.0F)
        Label5.Location = New Point(191, 148)
        Label5.Location = New Point(215, 210)
        Label5.Name = "Label5"
        Label5.Size = New Size(144, 27)
        Label5.TabIndex = 11
        Label5.Text = "✪ Fullname:"
        ' 
        ' lblRecord
        ' 
        lblRecord.AutoSize = True
        lblRecord.Font = New Font("Century Gothic", 12.0F)
        lblRecord.Location = New Point(517, 267)
        lblRecord.Location = New Point(618, 369)
        lblRecord.Name = "lblRecord"
        lblRecord.Size = New Size(73, 27)
        lblRecord.TabIndex = 9
        lblRecord.Text = "[User]"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Century Gothic", 12.0F)
        lblEmail.Location = New Point(259, 176)
        lblEmail.Location = New Point(312, 248)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(73, 27)
        lblEmail.TabIndex = 8
        lblEmail.Text = "[User]"
        ' 
        ' Button1
        ' 
        lblDOB.AutoSize = True
        lblDOB.Font = New Font("Century Gothic", 12.0F)
        lblDOB.Location = New Point(815, 176)
        lblDOB.Name = "lblDOB"
        lblDOB.Size = New Size(73, 27)
        lblDOB.TabIndex = 6
        lblDOB.Text = "[User]"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Century Gothic", 12.0F)
        lblAddress.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Underline)
        lblAddress.ForeColor = Color.Black
        lblAddress.Location = New Point(341, 282)
        lblAddress.Size = New Size(73, 27)
        lblAddress.TabIndex = 5
        lblAddress.Text = "[User]"
        ' 
        ' lblSex
        ' 
        lblSex.AutoSize = True
        lblSex.Font = New Font("Century Gothic", 12.0F)
        lblSex.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Underline)
        lblSex.ForeColor = Color.Black
        lblSex.Location = New Point(856, 282)
        lblSex.Size = New Size(73, 27)
        lblSex.TabIndex = 4
        lblSex.Text = "[User]"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Font = New Font("Century Gothic", 12.0F)
        lblAge.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Underline)
        lblAge.ForeColor = Color.Black
        lblAge.Location = New Point(866, 210)
        lblAge.Size = New Size(73, 27)
        lblAge.TabIndex = 3
        lblAge.Text = "[User]"
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Century Gothic", 12.0F)
        lblFullName.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Underline)
        lblFullName.ForeColor = Color.Black
        lblFullName.Location = New Point(355, 210)
        lblFullName.Size = New Size(73, 27)
        lblFullName.TabIndex = 2
        lblFullName.Text = "[User]"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Felix Titling", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Font = New Font("Felix Titling", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(53, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(431, 33)
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
        TabPage2.Controls.Add(BtnUpdate)
        TabPage2.Controls.Add(ToDOB)
        TabPage2.Controls.Add(FromDOB)
        TabPage2.Location = New Point(4, 30)
        TabPage2.Margin = New Padding(3, 4, 3, 4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3, 4, 3, 4)
        TabPage2.Size = New Size(1285, 601)
        TabPage2.TabIndex = 1
        TabPage2.Text = "🚘Records── .✦"
        TabPage2.UseVisualStyleBackColor = True
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
        ' DGLogs
        ' 
        DGLogs.AllowUserToAddRows = False
        DGLogs.AllowUserToDeleteRows = False
        DGLogs.AllowUserToResizeColumns = False
        DGLogs.AllowUserToResizeRows = False
        DGLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGLogs.BackgroundColor = Color.LightGoldenrodYellow
        DGLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGLogs.Location = New Point(17, 102)
        DGLogs.Margin = New Padding(3, 4, 3, 4)
        DGLogs.MultiSelect = False
        DGLogs.Name = "DGLogs"
        DGLogs.ReadOnly = True
        DGLogs.RowHeadersWidth = 51
        DGLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGLogs.Size = New Size(1251, 452)
        DGLogs.TabIndex = 0
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
        ' BtnSchedCheck
        ' 
        BtnSchedCheck.BackColor = Color.PaleGoldenrod
        BtnSchedCheck.Font = New Font("Century", 12.0F, FontStyle.Bold)
        BtnSchedCheck.ForeColor = Color.Black
        BtnSchedCheck.Location = New Point(428, 562)
        BtnSchedCheck.Margin = New Padding(3, 4, 3, 4)
        BtnSchedCheck.Name = "BtnSchedCheck"
        BtnSchedCheck.Size = New Size(214, 31)
        BtnSchedCheck.TabIndex = 8
        BtnSchedCheck.Text = "Schedule Review☆"
        BtnSchedCheck.UseVisualStyleBackColor = False
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Font = New Font("Century", 12.0F, FontStyle.Bold)
        btnCalculate.ForeColor = Color.Black
        btnCalculate.Location = New Point(648, 562)
        btnCalculate.Margin = New Padding(3, 4, 3, 4)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(214, 31)
        btnCalculate.TabIndex = 7
        btnCalculate.Text = "Review Total☆"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' BtnDelete
        ' BtnDelete
        ' 
        BtnDelete.Font = New Font("Century", 12.0F, FontStyle.Bold)
        BtnDelete.ForeColor = Color.Black
        BtnDelete.Location = New Point(868, 562)
        BtnDelete.Margin = New Padding(3, 4, 3, 4)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(123, 31)
        BtnDelete.TabIndex = 6
        BtnDelete.Text = "Delete☆"
        BtnDelete.UseVisualStyleBackColor = False
        ' 
        ' Label3
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
        ' BtnUpdate
        ' 
        BtnUpdate.Font = New Font("Century", 12.0F, FontStyle.Bold)
        BtnUpdate.ForeColor = Color.Black
        BtnUpdate.ForeColor = Color.Black
        BtnUpdate.Location = New Point(299, 562)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(123, 31)
        BtnUpdate.TabIndex = 3
        BtnUpdate.Text = "Update☆"
        BtnUpdate.UseVisualStyleBackColor = False
        ' 
        ' ToDOB
        ' ToDOB
        ' 
        ToDOB.Font = New Font("Century Gothic", 12.0F)
        ToDOB.Location = New Point(353, 407)
        ToDOB.Name = "ToDOB"
        ToDOB.Size = New Size(259, 32)
        ToDOB.TabIndex = 2
        ' 
        ' FromDOB
        ' 
        FromDOB.Font = New Font("Century Gothic", 12.0F)
        FromDOB.Location = New Point(73, 407)
        FromDOB.Name = "FromDOB"
        FromDOB.Margin = New Padding(3, 4, 3, 4)
        FromDOB.Name = "FromDOB"
        FromDOB.Size = New Size(259, 32)
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.PaleGoldenrod
        Button1.Font = New Font("Century", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1186, 651)
        Button1.Location = New Point(1186, 651)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(125, 35)
        Button1.TabIndex = 7
        Button1.Text = "Continue↪"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
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
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1326, 691)
        Controls.Add(Button2)
        Controls.Add(TabControl1)
        Controls.Add(Button1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Dashboard"
        Text = "🚘Dashboard── .✦"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(DGLogs, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DGLogs As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents lblEmail As Label
    Friend WithEvents BtnDelete As Button
    Friend WithEvents lblRecord As Label
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
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
