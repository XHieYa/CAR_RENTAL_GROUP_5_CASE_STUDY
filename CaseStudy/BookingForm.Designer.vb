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
        BtnConfirm = New Button()
        DGVSchedules = New DataGridView()
        GroupBox1.SuspendLayout()
        CType(DGVSchedules, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MnthC
        ' 
        MnthC.Location = New Point(913, 12)
        MnthC.Name = "MnthC"
        MnthC.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(25, 15)
        Label3.TabIndex = 9
        Label3.Text = "To: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 15)
        Label1.TabIndex = 8
        Label1.Text = "From:"
        ' 
        ' ToDOB
        ' 
        ToDOB.Location = New Point(54, 106)
        ToDOB.Name = "ToDOB"
        ToDOB.Size = New Size(200, 23)
        ToDOB.TabIndex = 7
        ' 
        ' FromDOB
        ' 
        FromDOB.Location = New Point(54, 77)
        FromDOB.Name = "FromDOB"
        FromDOB.Size = New Size(200, 23)
        FromDOB.TabIndex = 6
        ' 
        ' GroupBox1
        ' 
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
        GroupBox1.Controls.Add(BtnConfirm)
        GroupBox1.Controls.Add(FromDOB)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(ToDOB)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(649, 162)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Booking Detail"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(470, 22)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 15)
        Label5.TabIndex = 32
        Label5.Text = "Pay Rate:"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtRate
        ' 
        txtRate.Location = New Point(531, 19)
        txtRate.Margin = New Padding(3, 2, 3, 2)
        txtRate.Multiline = True
        txtRate.Name = "txtRate"
        txtRate.ReadOnly = True
        txtRate.Size = New Size(112, 23)
        txtRate.TabIndex = 31
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(260, 48)
        Label12.Name = "Label12"
        Label12.Size = New Size(84, 15)
        Label12.TabIndex = 30
        Label12.Text = "Body Number:"
        ' 
        ' txtBodyNumber
        ' 
        txtBodyNumber.Location = New Point(349, 45)
        txtBodyNumber.Margin = New Padding(3, 2, 3, 2)
        txtBodyNumber.Multiline = True
        txtBodyNumber.Name = "txtBodyNumber"
        txtBodyNumber.ReadOnly = True
        txtBodyNumber.Size = New Size(112, 26)
        txtBodyNumber.TabIndex = 29
        ' 
        ' txtCapacity
        ' 
        txtCapacity.Location = New Point(349, 131)
        txtCapacity.Margin = New Padding(3, 2, 3, 2)
        txtCapacity.Multiline = True
        txtCapacity.Name = "txtCapacity"
        txtCapacity.ReadOnly = True
        txtCapacity.Size = New Size(79, 26)
        txtCapacity.TabIndex = 26
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(287, 135)
        Label11.Name = "Label11"
        Label11.Size = New Size(56, 15)
        Label11.TabIndex = 28
        Label11.Text = "Capacity:"
        ' 
        ' txtType
        ' 
        txtType.Location = New Point(349, 102)
        txtType.Margin = New Padding(3, 2, 3, 2)
        txtType.Multiline = True
        txtType.Name = "txtType"
        txtType.ReadOnly = True
        txtType.Size = New Size(79, 26)
        txtType.TabIndex = 25
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(309, 106)
        Label10.Name = "Label10"
        Label10.Size = New Size(34, 15)
        Label10.TabIndex = 27
        Label10.Text = "Type:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(304, 77)
        Label9.Name = "Label9"
        Label9.Size = New Size(39, 15)
        Label9.TabIndex = 26
        Label9.Text = "Color:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(260, 22)
        Label8.Name = "Label8"
        Label8.Size = New Size(83, 15)
        Label8.TabIndex = 25
        Label8.Text = "Plate Number:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 56)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 15)
        Label4.TabIndex = 14
        Label4.Text = "Car ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 15)
        Label2.TabIndex = 13
        Label2.Text = "Car:"
        ' 
        ' txtCColor
        ' 
        txtCColor.Location = New Point(349, 74)
        txtCColor.Margin = New Padding(3, 2, 3, 2)
        txtCColor.Multiline = True
        txtCColor.Name = "txtCColor"
        txtCColor.ReadOnly = True
        txtCColor.Size = New Size(79, 26)
        txtCColor.TabIndex = 24
        ' 
        ' txtCar
        ' 
        txtCar.Location = New Point(54, 19)
        txtCar.Name = "txtCar"
        txtCar.ReadOnly = True
        txtCar.Size = New Size(200, 23)
        txtCar.TabIndex = 12
        ' 
        ' txtPlateNumber
        ' 
        txtPlateNumber.Location = New Point(349, 19)
        txtPlateNumber.Margin = New Padding(3, 2, 3, 2)
        txtPlateNumber.Multiline = True
        txtPlateNumber.Name = "txtPlateNumber"
        txtPlateNumber.ReadOnly = True
        txtPlateNumber.Size = New Size(112, 23)
        txtPlateNumber.TabIndex = 23
        ' 
        ' TxtCarID
        ' 
        TxtCarID.Location = New Point(54, 48)
        TxtCarID.Name = "TxtCarID"
        TxtCarID.ReadOnly = True
        TxtCarID.Size = New Size(200, 23)
        TxtCarID.TabIndex = 11
        ' 
        ' BtnConfirm
        ' 
        BtnConfirm.Location = New Point(15, 135)
        BtnConfirm.Name = "BtnConfirm"
        BtnConfirm.Size = New Size(75, 23)
        BtnConfirm.TabIndex = 10
        BtnConfirm.Text = "Confirm"
        BtnConfirm.UseVisualStyleBackColor = True
        ' 
        ' DGVSchedules
        ' 
        DGVSchedules.AllowUserToAddRows = False
        DGVSchedules.AllowUserToDeleteRows = False
        DGVSchedules.AllowUserToResizeColumns = False
        DGVSchedules.AllowUserToResizeRows = False
        DGVSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVSchedules.Enabled = False
        DGVSchedules.Location = New Point(12, 186)
        DGVSchedules.Name = "DGVSchedules"
        DGVSchedules.Size = New Size(1134, 351)
        DGVSchedules.TabIndex = 12
        ' 
        ' BookingForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1158, 549)
        Controls.Add(DGVSchedules)
        Controls.Add(GroupBox1)
        Controls.Add(MnthC)
        Name = "BookingForm"
        Text = "BookingForm"
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
End Class
