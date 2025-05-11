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
        GroupBox1.SuspendLayout()
        CType(DGVSchedules, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MnthC
        ' 
        MnthC.BackColor = Color.LightGoldenrodYellow
        MnthC.Font = New Font("Footlight MT Light", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MnthC.Location = New Point(1043, 25)
        MnthC.Margin = New Padding(10, 12, 10, 12)
        MnthC.Name = "MnthC"
        MnthC.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century Gothic", 10.2F)
        Label3.Location = New Point(700, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 21)
        Label3.TabIndex = 9
        Label3.Text = "To: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 10.2F)
        Label1.Location = New Point(700, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 21)
        Label1.TabIndex = 8
        Label1.Text = "From:"
        ' 
        ' ToDOB
        ' 
        ToDOB.Font = New Font("Footlight MT Light", 12F)
        ToDOB.Location = New Point(760, 119)
        ToDOB.Margin = New Padding(3, 4, 3, 4)
        ToDOB.Name = "ToDOB"
        ToDOB.Size = New Size(228, 29)
        ToDOB.TabIndex = 7
        ' 
        ' FromDOB
        ' 
        FromDOB.Font = New Font("Footlight MT Light", 12F)
        FromDOB.Location = New Point(760, 78)
        FromDOB.Margin = New Padding(3, 4, 3, 4)
        FromDOB.Name = "FromDOB"
        FromDOB.Size = New Size(228, 29)
        FromDOB.TabIndex = 6
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), Image)
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
        GroupBox1.Location = New Point(14, 16)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(1016, 216)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Booking Detail"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Century Gothic", 10.2F)
        Label5.Location = New Point(40, 143)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 21)
        Label5.TabIndex = 32
        Label5.Text = "Pay Rate:"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtRate
        ' 
        txtRate.BackColor = Color.FloralWhite
        txtRate.Location = New Point(131, 134)
        txtRate.Multiline = True
        txtRate.Name = "txtRate"
        txtRate.ReadOnly = True
        txtRate.Size = New Size(228, 30)
        txtRate.TabIndex = 31
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Century Gothic", 10.2F)
        Label12.Location = New Point(395, 72)
        Label12.Name = "Label12"
        Label12.Size = New Size(127, 21)
        Label12.TabIndex = 30
        Label12.Text = "Body Number:"
        ' 
        ' txtBodyNumber
        ' 
        txtBodyNumber.BackColor = Color.FloralWhite
        txtBodyNumber.Location = New Point(530, 60)
        txtBodyNumber.Multiline = True
        txtBodyNumber.Name = "txtBodyNumber"
        txtBodyNumber.ReadOnly = True
        txtBodyNumber.Size = New Size(135, 30)
        txtBodyNumber.TabIndex = 29
        ' 
        ' txtCapacity
        ' 
        txtCapacity.BackColor = Color.FloralWhite
        txtCapacity.Location = New Point(530, 172)
        txtCapacity.Multiline = True
        txtCapacity.Name = "txtCapacity"
        txtCapacity.ReadOnly = True
        txtCapacity.Size = New Size(135, 30)
        txtCapacity.TabIndex = 26
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Century Gothic", 10.2F)
        Label11.Location = New Point(395, 175)
        Label11.Name = "Label11"
        Label11.Size = New Size(94, 21)
        Label11.TabIndex = 28
        Label11.Text = "Capacity:"
        ' 
        ' txtType
        ' 
        txtType.BackColor = Color.FloralWhite
        txtType.Location = New Point(530, 133)
        txtType.Multiline = True
        txtType.Name = "txtType"
        txtType.ReadOnly = True
        txtType.Size = New Size(135, 30)
        txtType.TabIndex = 25
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Century Gothic", 10.2F)
        Label10.Location = New Point(395, 140)
        Label10.Name = "Label10"
        Label10.Size = New Size(54, 21)
        Label10.TabIndex = 27
        Label10.Text = "Type:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Century Gothic", 10.2F)
        Label9.Location = New Point(395, 107)
        Label9.Name = "Label9"
        Label9.Size = New Size(59, 21)
        Label9.TabIndex = 26
        Label9.Text = "Color:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Century Gothic", 10.2F)
        Label8.Location = New Point(395, 36)
        Label8.Name = "Label8"
        Label8.Size = New Size(129, 21)
        Label8.TabIndex = 25
        Label8.Text = "Plate Number:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Century Gothic", 10.2F)
        Label4.Location = New Point(40, 108)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 21)
        Label4.TabIndex = 14
        Label4.Text = "Car ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 10.2F)
        Label2.Location = New Point(40, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 21)
        Label2.TabIndex = 13
        Label2.Text = "Car:"
        ' 
        ' txtCColor
        ' 
        txtCColor.BackColor = Color.FloralWhite
        txtCColor.Location = New Point(530, 96)
        txtCColor.Multiline = True
        txtCColor.Name = "txtCColor"
        txtCColor.ReadOnly = True
        txtCColor.Size = New Size(135, 30)
        txtCColor.TabIndex = 24
        ' 
        ' txtCar
        ' 
        txtCar.BackColor = Color.FloralWhite
        txtCar.Location = New Point(131, 61)
        txtCar.Margin = New Padding(3, 4, 3, 4)
        txtCar.Multiline = True
        txtCar.Name = "txtCar"
        txtCar.ReadOnly = True
        txtCar.Size = New Size(228, 30)
        txtCar.TabIndex = 12
        ' 
        ' txtPlateNumber
        ' 
        txtPlateNumber.BackColor = Color.FloralWhite
        txtPlateNumber.Location = New Point(530, 25)
        txtPlateNumber.Multiline = True
        txtPlateNumber.Name = "txtPlateNumber"
        txtPlateNumber.ReadOnly = True
        txtPlateNumber.Size = New Size(135, 30)
        txtPlateNumber.TabIndex = 23
        ' 
        ' TxtCarID
        ' 
        TxtCarID.BackColor = Color.FloralWhite
        TxtCarID.Location = New Point(131, 96)
        TxtCarID.Margin = New Padding(3, 4, 3, 4)
        TxtCarID.Multiline = True
        TxtCarID.Name = "TxtCarID"
        TxtCarID.ReadOnly = True
        TxtCarID.Size = New Size(228, 30)
        TxtCarID.TabIndex = 11
        ' 
        ' BtnBackToSeater
        ' 
        BtnBackToSeater.BackColor = Color.PaleGoldenrod
        BtnBackToSeater.Font = New Font("Century", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnBackToSeater.Location = New Point(14, 657)
        BtnBackToSeater.Name = "BtnBackToSeater"
        BtnBackToSeater.Size = New Size(122, 31)
        BtnBackToSeater.TabIndex = 32
        BtnBackToSeater.Text = "↩Back" & vbCrLf
        BtnBackToSeater.UseVisualStyleBackColor = False
        ' 
        ' BtnConfirm
        ' 
        BtnConfirm.BackColor = Color.PaleGoldenrod
        BtnConfirm.Font = New Font("Century", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnConfirm.Location = New Point(1188, 657)
        BtnConfirm.Margin = New Padding(3, 4, 3, 4)
        BtnConfirm.Name = "BtnConfirm"
        BtnConfirm.Size = New Size(122, 31)
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
        DGVSchedules.Location = New Point(14, 248)
        DGVSchedules.Margin = New Padding(3, 4, 3, 4)
        DGVSchedules.Name = "DGVSchedules"
        DGVSchedules.RowHeadersWidth = 51
        DGVSchedules.Size = New Size(1296, 401)
        DGVSchedules.TabIndex = 12
        ' 
        ' BookingForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1326, 691)
        Controls.Add(BtnBackToSeater)
        Controls.Add(DGVSchedules)
        Controls.Add(GroupBox1)
        Controls.Add(MnthC)
        Controls.Add(BtnConfirm)
        Margin = New Padding(3, 4, 3, 4)
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
End Class
