<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookingForm))
        MnthC = New MonthCalendar()
        Label3 = New Label()
        Label1 = New Label()
        ToDOB = New DateTimePicker()
        FromDOB = New DateTimePicker()
        GroupBox1 = New GroupBox()
        Label5 = New Label()
        txtRate = New TextBox()
        Label12 = New Label()
        txtBodyNumber = New TextBox()
        txtCapacity = New TextBox()
        Label11 = New Label()
        txtType = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        txtCColor = New TextBox()
        txtCar = New TextBox()
        txtPlateNumber = New TextBox()
        TxtCarID = New TextBox()
        BtnBackToSeater = New Button()
        BtnConfirm = New Button()
        DGVSchedules = New DataGridView()
        Label6 = New Label()
        GroupBox1.SuspendLayout()
        CType(DGVSchedules, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MnthC
        ' 
        MnthC.BackColor = Color.LightGoldenrodYellow
        MnthC.Font = New Font("Footlight MT Light", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MnthC.Location = New Point(913, 19)
        MnthC.Name = "MnthC"
        MnthC.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century Gothic", 10.2F)
        Label3.Location = New Point(612, 85)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 19)
        Label3.TabIndex = 9
        Label3.Text = "To: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 10.2F)
        Label1.Location = New Point(612, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 19)
        Label1.TabIndex = 8
        Label1.Text = "From:"
        ' 
        ' ToDOB
        ' 
        ToDOB.Font = New Font("Footlight MT Light", 12F)
        ToDOB.Location = New Point(612, 107)
        ToDOB.Name = "ToDOB"
        ToDOB.Size = New Size(253, 24)
        ToDOB.TabIndex = 7
        ' 
        ' FromDOB
        ' 
        FromDOB.Font = New Font("Footlight MT Light", 12F)
        FromDOB.Location = New Point(612, 58)
        FromDOB.Name = "FromDOB"
        FromDOB.Size = New Size(253, 24)
        FromDOB.TabIndex = 6
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), Image)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtRate)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(txtBodyNumber)
        GroupBox1.Controls.Add(txtCapacity)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(txtType)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtCColor)
        GroupBox1.Controls.Add(txtCar)
        GroupBox1.Controls.Add(txtPlateNumber)
        GroupBox1.Controls.Add(TxtCarID)
        GroupBox1.Controls.Add(FromDOB)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(ToDOB)
        GroupBox1.Font = New Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(12, 18)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(889, 162)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Booking Detail"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Century Gothic", 10.2F)
        Label5.Location = New Point(346, 133)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 19)
        Label5.TabIndex = 32
        Label5.Text = "Pay Rate:"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtRate
        ' 
        txtRate.BackColor = Color.FloralWhite
        txtRate.Location = New Point(464, 128)
        txtRate.Margin = New Padding(3, 2, 3, 2)
        txtRate.Multiline = True
        txtRate.Name = "txtRate"
        txtRate.ReadOnly = True
        txtRate.Size = New Size(119, 24)
        txtRate.TabIndex = 31
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Century Gothic", 10.2F)
        Label12.Location = New Point(6, 77)
        Label12.Name = "Label12"
        Label12.Size = New Size(107, 19)
        Label12.TabIndex = 30
        Label12.Text = "Body Number:"
        ' 
        ' txtBodyNumber
        ' 
        txtBodyNumber.BackColor = Color.FloralWhite
        txtBodyNumber.Location = New Point(115, 74)
        txtBodyNumber.Margin = New Padding(3, 2, 3, 2)
        txtBodyNumber.Multiline = True
        txtBodyNumber.Name = "txtBodyNumber"
        txtBodyNumber.ReadOnly = True
        txtBodyNumber.Size = New Size(200, 24)
        txtBodyNumber.TabIndex = 29
        ' 
        ' txtCapacity
        ' 
        txtCapacity.BackColor = Color.FloralWhite
        txtCapacity.Location = New Point(115, 102)
        txtCapacity.Margin = New Padding(3, 2, 3, 2)
        txtCapacity.Multiline = True
        txtCapacity.Name = "txtCapacity"
        txtCapacity.ReadOnly = True
        txtCapacity.Size = New Size(200, 24)
        txtCapacity.TabIndex = 26
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Century Gothic", 10.2F)
        Label11.Location = New Point(-247, 144)
        Label11.Name = "Label11"
        Label11.Size = New Size(79, 19)
        Label11.TabIndex = 28
        Label11.Text = "Capacity:"
        ' 
        ' txtType
        ' 
        txtType.BackColor = Color.FloralWhite
        txtType.Location = New Point(464, 100)
        txtType.Margin = New Padding(3, 2, 3, 2)
        txtType.Multiline = True
        txtType.Name = "txtType"
        txtType.ReadOnly = True
        txtType.Size = New Size(119, 24)
        txtType.TabIndex = 25
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Century Gothic", 10.2F)
        Label10.Location = New Point(346, 105)
        Label10.Name = "Label10"
        Label10.Size = New Size(45, 19)
        Label10.TabIndex = 27
        Label10.Text = "Type:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Century Gothic", 10.2F)
        Label9.Location = New Point(346, 80)
        Label9.Name = "Label9"
        Label9.Size = New Size(49, 19)
        Label9.TabIndex = 26
        Label9.Text = "Color:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Century Gothic", 10.2F)
        Label8.Location = New Point(346, 27)
        Label8.Name = "Label8"
        Label8.Size = New Size(107, 19)
        Label8.TabIndex = 25
        Label8.Text = "Plate Number:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Century Gothic", 10.2F)
        Label4.Location = New Point(346, 51)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 19)
        Label4.TabIndex = 14
        Label4.Text = "Car ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 10.2F)
        Label2.Location = New Point(6, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 19)
        Label2.TabIndex = 13
        Label2.Text = "Car:"
        ' 
        ' txtCColor
        ' 
        txtCColor.BackColor = Color.FloralWhite
        txtCColor.Location = New Point(464, 74)
        txtCColor.Margin = New Padding(3, 2, 3, 2)
        txtCColor.Multiline = True
        txtCColor.Name = "txtCColor"
        txtCColor.ReadOnly = True
        txtCColor.Size = New Size(119, 24)
        txtCColor.TabIndex = 24
        ' 
        ' txtCar
        ' 
        txtCar.BackColor = Color.FloralWhite
        txtCar.Location = New Point(115, 46)
        txtCar.Multiline = True
        txtCar.Name = "txtCar"
        txtCar.ReadOnly = True
        txtCar.Size = New Size(200, 24)
        txtCar.TabIndex = 12
        ' 
        ' txtPlateNumber
        ' 
        txtPlateNumber.BackColor = Color.FloralWhite
        txtPlateNumber.Location = New Point(464, 19)
        txtPlateNumber.Margin = New Padding(3, 2, 3, 2)
        txtPlateNumber.Multiline = True
        txtPlateNumber.Name = "txtPlateNumber"
        txtPlateNumber.ReadOnly = True
        txtPlateNumber.Size = New Size(119, 24)
        txtPlateNumber.TabIndex = 23
        ' 
        ' TxtCarID
        ' 
        TxtCarID.BackColor = Color.FloralWhite
        TxtCarID.Location = New Point(464, 46)
        TxtCarID.Multiline = True
        TxtCarID.Name = "TxtCarID"
        TxtCarID.ReadOnly = True
        TxtCarID.Size = New Size(119, 24)
        TxtCarID.TabIndex = 11
        ' 
        ' BtnBackToSeater
        ' 
        BtnBackToSeater.BackColor = Color.PaleGoldenrod
        BtnBackToSeater.Font = New Font("Century", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnBackToSeater.Location = New Point(12, 493)
        BtnBackToSeater.Margin = New Padding(3, 2, 3, 2)
        BtnBackToSeater.Name = "BtnBackToSeater"
        BtnBackToSeater.Size = New Size(107, 23)
        BtnBackToSeater.TabIndex = 32
        BtnBackToSeater.Text = "↩Back" & vbCrLf
        BtnBackToSeater.UseVisualStyleBackColor = False
        ' 
        ' BtnConfirm
        ' 
        BtnConfirm.BackColor = Color.PaleGoldenrod
        BtnConfirm.Font = New Font("Century", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnConfirm.Location = New Point(1040, 493)
        BtnConfirm.Name = "BtnConfirm"
        BtnConfirm.Size = New Size(107, 23)
        BtnConfirm.TabIndex = 10
        BtnConfirm.Text = "Continue↪"
        BtnConfirm.UseVisualStyleBackColor = False
        ' 
        ' DGVSchedules
        ' 
        DGVSchedules.AllowUserToAddRows = False
        DGVSchedules.AllowUserToDeleteRows = False
        DGVSchedules.AllowUserToResizeColumns = False
        DGVSchedules.AllowUserToResizeRows = False
        DGVSchedules.BackgroundColor = Color.LightGoldenrodYellow
        DGVSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVSchedules.Enabled = False
        DGVSchedules.GridColor = Color.Black
        DGVSchedules.Location = New Point(12, 186)
        DGVSchedules.Name = "DGVSchedules"
        DGVSchedules.RowHeadersWidth = 51
        DGVSchedules.Size = New Size(1134, 301)
        DGVSchedules.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Century Gothic", 10.2F)
        Label6.Location = New Point(6, 105)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 19)
        Label6.TabIndex = 33
        Label6.Text = "Capacity:"
        ' 
        ' BookingForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1160, 518)
        Controls.Add(BtnBackToSeater)
        Controls.Add(DGVSchedules)
        Controls.Add(GroupBox1)
        Controls.Add(MnthC)
        Controls.Add(BtnConfirm)
        Name = "BookingForm"
        Text = "🚘Booking── .✦"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DGVSchedules, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents MnthC As MonthCalendar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToDOB As DateTimePicker
    Friend WithEvents FromDOB As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnConfirm As Button
    Friend WithEvents TxtCarID As TextBox
    Friend WithEvents DGVSchedules As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCar As TextBox
    Friend WithEvents txtCColor As TextBox
    Friend WithEvents txtPlateNumber As TextBox
    Friend WithEvents txtCapacity As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBodyNumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents BtnBackToSeater As Button
    Friend WithEvents Label6 As Label
End Class
