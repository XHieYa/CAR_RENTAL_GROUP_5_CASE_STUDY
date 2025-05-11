<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaymentDetailSlip
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentDetailSlip))
        btnBackToBooking = New Button()
        BtnBackToDashBoard = New Button()
        BtnBackToSeater = New Button()
        GroupBox3 = New GroupBox()
        txtPlateNumber = New TextBox()
        Label16 = New Label()
        txtCarID = New TextBox()
        Label12 = New Label()
        Capacitytxt = New TextBox()
        Label11 = New Label()
        Typetxt = New TextBox()
        Ratetxt = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        txtCarName = New TextBox()
        txtBodyNumber = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        GroupBox4 = New GroupBox()
        Label17 = New Label()
        Label15 = New Label()
        BtnCalculate = New Button()
        CheckBox1 = New CheckBox()
        Label14 = New Label()
        Label13 = New Label()
        BtnPayment = New Button()
        ToDate = New DateTimePicker()
        FromDate = New DateTimePicker()
        GroupBox2 = New GroupBox()
        Label4 = New Label()
        Label5 = New Label()
        txtContact = New TextBox()
        txtEmail = New TextBox()
        GroupBox1 = New GroupBox()
        txtDOB = New TextBox()
        txtAge = New TextBox()
        Label6 = New Label()
        txtFullName = New TextBox()
        txtUsername = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox5 = New PictureBox()
        Label19 = New Label()
        Label20 = New Label()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBackToBooking
        ' 
        btnBackToBooking.BackColor = Color.PaleGoldenrod
        btnBackToBooking.Font = New Font("Century", 12F, FontStyle.Bold)
        btnBackToBooking.Location = New Point(666, 482)
        btnBackToBooking.Margin = New Padding(3, 2, 3, 2)
        btnBackToBooking.Name = "btnBackToBooking"
        btnBackToBooking.Size = New Size(123, 27)
        btnBackToBooking.TabIndex = 33
        btnBackToBooking.Text = "↩Booking"
        btnBackToBooking.UseVisualStyleBackColor = False
        ' 
        ' BtnBackToDashBoard
        ' 
        BtnBackToDashBoard.BackColor = Color.PaleGoldenrod
        BtnBackToDashBoard.Font = New Font("Century", 12F, FontStyle.Bold)
        BtnBackToDashBoard.Location = New Point(517, 482)
        BtnBackToDashBoard.Margin = New Padding(3, 2, 3, 2)
        BtnBackToDashBoard.Name = "BtnBackToDashBoard"
        BtnBackToDashBoard.Size = New Size(133, 27)
        BtnBackToDashBoard.TabIndex = 32
        BtnBackToDashBoard.Text = "↩DashBoard"
        BtnBackToDashBoard.UseVisualStyleBackColor = False
        ' 
        ' BtnBackToSeater
        ' 
        BtnBackToSeater.BackColor = Color.PaleGoldenrod
        BtnBackToSeater.Font = New Font("Century", 12F, FontStyle.Bold)
        BtnBackToSeater.Location = New Point(381, 482)
        BtnBackToSeater.Margin = New Padding(3, 2, 3, 2)
        BtnBackToSeater.Name = "BtnBackToSeater"
        BtnBackToSeater.Size = New Size(123, 27)
        BtnBackToSeater.TabIndex = 31
        BtnBackToSeater.Text = "↩Seaters"
        BtnBackToSeater.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txtPlateNumber)
        GroupBox3.Controls.Add(Label16)
        GroupBox3.Controls.Add(txtCarID)
        GroupBox3.Controls.Add(Label12)
        GroupBox3.Controls.Add(Capacitytxt)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(Typetxt)
        GroupBox3.Controls.Add(Ratetxt)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(txtCarName)
        GroupBox3.Controls.Add(txtBodyNumber)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Font = New Font("Stencil", 9F)
        GroupBox3.Location = New Point(392, 81)
        GroupBox3.Margin = New Padding(3, 2, 3, 2)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(3, 2, 3, 2)
        GroupBox3.Size = New Size(376, 337)
        GroupBox3.TabIndex = 4
        GroupBox3.TabStop = False
        GroupBox3.Text = "Car Details"
        ' 
        ' txtPlateNumber
        ' 
        txtPlateNumber.BackColor = Color.FloralWhite
        txtPlateNumber.Font = New Font("Century Gothic", 12F)
        txtPlateNumber.Location = New Point(114, 128)
        txtPlateNumber.Margin = New Padding(3, 2, 3, 2)
        txtPlateNumber.Multiline = True
        txtPlateNumber.Name = "txtPlateNumber"
        txtPlateNumber.ReadOnly = True
        txtPlateNumber.Size = New Size(256, 26)
        txtPlateNumber.TabIndex = 26
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Century Gothic", 12F)
        Label16.Location = New Point(5, 135)
        Label16.Name = "Label16"
        Label16.Size = New Size(80, 21)
        Label16.TabIndex = 25
        Label16.Text = "Plate No:"
        ' 
        ' txtCarID
        ' 
        txtCarID.BackColor = Color.FloralWhite
        txtCarID.Font = New Font("Century Gothic", 12F)
        txtCarID.Location = New Point(114, 66)
        txtCarID.Margin = New Padding(3, 2, 3, 2)
        txtCarID.Multiline = True
        txtCarID.Name = "txtCarID"
        txtCarID.Size = New Size(256, 26)
        txtCarID.TabIndex = 24
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 12F)
        Label12.Location = New Point(5, 105)
        Label12.Name = "Label12"
        Label12.Size = New Size(78, 21)
        Label12.TabIndex = 23
        Label12.Text = "Body No:"
        ' 
        ' Capacitytxt
        ' 
        Capacitytxt.BackColor = Color.FloralWhite
        Capacitytxt.Font = New Font("Century Gothic", 12F)
        Capacitytxt.Location = New Point(210, 256)
        Capacitytxt.Margin = New Padding(3, 2, 3, 2)
        Capacitytxt.Multiline = True
        Capacitytxt.Name = "Capacitytxt"
        Capacitytxt.ReadOnly = True
        Capacitytxt.Size = New Size(91, 26)
        Capacitytxt.TabIndex = 22
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 12F)
        Label11.Location = New Point(93, 264)
        Label11.Name = "Label11"
        Label11.Size = New Size(88, 21)
        Label11.TabIndex = 21
        Label11.Text = "Capacity:"
        ' 
        ' Typetxt
        ' 
        Typetxt.BackColor = Color.FloralWhite
        Typetxt.Font = New Font("Century Gothic", 12F)
        Typetxt.Location = New Point(210, 223)
        Typetxt.Margin = New Padding(3, 2, 3, 2)
        Typetxt.Multiline = True
        Typetxt.Name = "Typetxt"
        Typetxt.ReadOnly = True
        Typetxt.Size = New Size(91, 26)
        Typetxt.TabIndex = 20
        ' 
        ' Ratetxt
        ' 
        Ratetxt.BackColor = Color.FloralWhite
        Ratetxt.Font = New Font("Century Gothic", 12F)
        Ratetxt.Location = New Point(210, 190)
        Ratetxt.Margin = New Padding(3, 2, 3, 2)
        Ratetxt.Multiline = True
        Ratetxt.Name = "Ratetxt"
        Ratetxt.ReadOnly = True
        Ratetxt.Size = New Size(91, 26)
        Ratetxt.TabIndex = 19
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 12F)
        Label10.Location = New Point(93, 230)
        Label10.Name = "Label10"
        Label10.Size = New Size(51, 21)
        Label10.TabIndex = 18
        Label10.Text = "Type:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 12F)
        Label9.Location = New Point(93, 197)
        Label9.Name = "Label9"
        Label9.Size = New Size(52, 21)
        Label9.TabIndex = 17
        Label9.Text = "Rate:"
        ' 
        ' txtCarName
        ' 
        txtCarName.BackColor = Color.FloralWhite
        txtCarName.Font = New Font("Century Gothic", 12F)
        txtCarName.Location = New Point(114, 33)
        txtCarName.Margin = New Padding(3, 2, 3, 2)
        txtCarName.Multiline = True
        txtCarName.Name = "txtCarName"
        txtCarName.ReadOnly = True
        txtCarName.Size = New Size(256, 26)
        txtCarName.TabIndex = 16
        ' 
        ' txtBodyNumber
        ' 
        txtBodyNumber.BackColor = Color.FloralWhite
        txtBodyNumber.Font = New Font("Century Gothic", 12F)
        txtBodyNumber.Location = New Point(114, 98)
        txtBodyNumber.Margin = New Padding(3, 2, 3, 2)
        txtBodyNumber.Multiline = True
        txtBodyNumber.Name = "txtBodyNumber"
        txtBodyNumber.ReadOnly = True
        txtBodyNumber.Size = New Size(256, 26)
        txtBodyNumber.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 12F)
        Label8.Location = New Point(5, 74)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 21)
        Label8.TabIndex = 14
        Label8.Text = "Car ID:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 12F)
        Label7.Location = New Point(5, 40)
        Label7.Name = "Label7"
        Label7.Size = New Size(95, 21)
        Label7.TabIndex = 13
        Label7.Text = "Car Name:"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(Label17)
        GroupBox4.Controls.Add(Label15)
        GroupBox4.Controls.Add(BtnCalculate)
        GroupBox4.Controls.Add(CheckBox1)
        GroupBox4.Controls.Add(Label14)
        GroupBox4.Controls.Add(Label13)
        GroupBox4.Controls.Add(BtnPayment)
        GroupBox4.Controls.Add(ToDate)
        GroupBox4.Controls.Add(FromDate)
        GroupBox4.Font = New Font("Stencil", 9F)
        GroupBox4.Location = New Point(774, 81)
        GroupBox4.Margin = New Padding(3, 2, 3, 2)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(3, 2, 3, 2)
        GroupBox4.Size = New Size(376, 337)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        GroupBox4.Text = "Payment Method"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Century", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(26, 208)
        Label17.Name = "Label17"
        Label17.Size = New Size(225, 30)
        Label17.TabIndex = 30
        Label17.Text = "✦If your payment doesn't include a " & vbCrLf & "driver, leave this box unchecked.✦"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Felix Titling", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(5, 27)
        Label15.Name = "Label15"
        Label15.Size = New Size(201, 19)
        Label15.TabIndex = 29
        Label15.Text = "✮⋆˙Rental Period˙⋆✮"
        ' 
        ' BtnCalculate
        ' 
        BtnCalculate.BackColor = Color.PaleGoldenrod
        BtnCalculate.Font = New Font("Century", 12F, FontStyle.Bold)
        BtnCalculate.Location = New Point(238, 267)
        BtnCalculate.Margin = New Padding(3, 2, 3, 2)
        BtnCalculate.Name = "BtnCalculate"
        BtnCalculate.Size = New Size(133, 27)
        BtnCalculate.TabIndex = 28
        BtnCalculate.Text = "Calculate☆"
        BtnCalculate.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Century Gothic", 12F)
        CheckBox1.Location = New Point(15, 189)
        CheckBox1.Margin = New Padding(3, 2, 3, 2)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(113, 25)
        CheckBox1.TabIndex = 27
        CheckBox1.Text = "With Driver"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Century Gothic", 12F)
        Label14.Location = New Point(54, 116)
        Label14.Name = "Label14"
        Label14.Size = New Size(32, 21)
        Label14.TabIndex = 26
        Label14.Text = "To:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 12F)
        Label13.Location = New Point(54, 57)
        Label13.Name = "Label13"
        Label13.Size = New Size(52, 21)
        Label13.TabIndex = 25
        Label13.Text = "From:"
        ' 
        ' BtnPayment
        ' 
        BtnPayment.BackColor = Color.PaleGoldenrod
        BtnPayment.Font = New Font("Century", 12F, FontStyle.Bold)
        BtnPayment.Location = New Point(238, 300)
        BtnPayment.Margin = New Padding(3, 2, 3, 2)
        BtnPayment.Name = "BtnPayment"
        BtnPayment.Size = New Size(133, 27)
        BtnPayment.TabIndex = 15
        BtnPayment.Text = "Checkout☆"
        BtnPayment.UseVisualStyleBackColor = False
        ' 
        ' ToDate
        ' 
        ToDate.Font = New Font("Footlight MT Light", 13.8F)
        ToDate.Location = New Point(109, 134)
        ToDate.Margin = New Padding(3, 2, 3, 2)
        ToDate.Name = "ToDate"
        ToDate.Size = New Size(218, 27)
        ToDate.TabIndex = 14
        ' 
        ' FromDate
        ' 
        FromDate.Font = New Font("Footlight MT Light", 13.8F)
        FromDate.Location = New Point(109, 76)
        FromDate.Margin = New Padding(3, 2, 3, 2)
        FromDate.Name = "FromDate"
        FromDate.Size = New Size(218, 27)
        FromDate.TabIndex = 13
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(txtContact)
        GroupBox2.Controls.Add(txtEmail)
        GroupBox2.Font = New Font("Stencil", 9F)
        GroupBox2.Location = New Point(10, 271)
        GroupBox2.Margin = New Padding(3, 2, 3, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 2, 3, 2)
        GroupBox2.Size = New Size(376, 147)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Contact Details"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F)
        Label4.Location = New Point(54, 28)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 21)
        Label4.TabIndex = 7
        Label4.Text = "Email:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F)
        Label5.Location = New Point(54, 77)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 21)
        Label5.TabIndex = 8
        Label5.Text = "Contact No:"
        ' 
        ' txtContact
        ' 
        txtContact.BackColor = Color.FloralWhite
        txtContact.Font = New Font("Century Gothic", 12F)
        txtContact.Location = New Point(54, 97)
        txtContact.Margin = New Padding(3, 2, 3, 2)
        txtContact.Multiline = True
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(256, 26)
        txtContact.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FloralWhite
        txtEmail.Font = New Font("Century Gothic", 12F)
        txtEmail.Location = New Point(54, 48)
        txtEmail.Margin = New Padding(3, 2, 3, 2)
        txtEmail.Multiline = True
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(256, 26)
        txtEmail.TabIndex = 9
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtDOB)
        GroupBox1.Controls.Add(txtAge)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(txtFullName)
        GroupBox1.Controls.Add(txtUsername)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Stencil", 9F)
        GroupBox1.Location = New Point(10, 80)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.RightToLeft = RightToLeft.No
        GroupBox1.Size = New Size(376, 186)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Customer Information"
        ' 
        ' txtDOB
        ' 
        txtDOB.BackColor = Color.FloralWhite
        txtDOB.Font = New Font("Century Gothic", 12F)
        txtDOB.Location = New Point(110, 68)
        txtDOB.Margin = New Padding(3, 2, 3, 2)
        txtDOB.Multiline = True
        txtDOB.Name = "txtDOB"
        txtDOB.ReadOnly = True
        txtDOB.Size = New Size(256, 26)
        txtDOB.TabIndex = 14
        ' 
        ' txtAge
        ' 
        txtAge.BackColor = Color.FloralWhite
        txtAge.Font = New Font("Century Gothic", 12F)
        txtAge.Location = New Point(110, 99)
        txtAge.Margin = New Padding(3, 2, 3, 2)
        txtAge.Multiline = True
        txtAge.Name = "txtAge"
        txtAge.ReadOnly = True
        txtAge.Size = New Size(88, 26)
        txtAge.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F)
        Label6.Location = New Point(5, 136)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 21)
        Label6.TabIndex = 12
        Label6.Text = "DOB"
        ' 
        ' txtFullName
        ' 
        txtFullName.BackColor = Color.FloralWhite
        txtFullName.Font = New Font("Century Gothic", 12F)
        txtFullName.Location = New Point(110, 34)
        txtFullName.Margin = New Padding(3, 2, 3, 2)
        txtFullName.Multiline = True
        txtFullName.Name = "txtFullName"
        txtFullName.ReadOnly = True
        txtFullName.Size = New Size(256, 26)
        txtFullName.TabIndex = 11
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FloralWhite
        txtUsername.Font = New Font("Century Gothic", 12F)
        txtUsername.Location = New Point(110, 129)
        txtUsername.Margin = New Padding(3, 2, 3, 2)
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.ReadOnly = True
        txtUsername.Size = New Size(88, 26)
        txtUsername.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F)
        Label3.Location = New Point(5, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 21)
        Label3.TabIndex = 3
        Label3.Text = "Age:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F)
        Label2.Location = New Point(5, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 21)
        Label2.TabIndex = 2
        Label2.Text = "Username:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F)
        Label1.Location = New Point(5, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 21)
        Label1.TabIndex = 0
        Label1.Text = "Full Name:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1057, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(102, 83)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 34
        PictureBox1.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(1, 449)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(119, 68)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 37
        PictureBox5.TabStop = False
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.Transparent
        Label19.Font = New Font("Footlight MT Light", 7.8F)
        Label19.Location = New Point(1, 427)
        Label19.Name = "Label19"
        Label19.Size = New Size(83, 12)
        Label19.TabIndex = 36
        Label19.Text = "WheelAway, Inc."
        Label19.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.Transparent
        Label20.Font = New Font("Footlight MT Light", 7.8F)
        Label20.Location = New Point(1, 437)
        Label20.Name = "Label20"
        Label20.Size = New Size(113, 12)
        Label20.TabIndex = 35
        Label20.Text = "wheelaway@gmail.com"
        Label20.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PaymentDetailSlip
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1160, 518)
        Controls.Add(PictureBox5)
        Controls.Add(Label19)
        Controls.Add(Label20)
        Controls.Add(PictureBox1)
        Controls.Add(btnBackToBooking)
        Controls.Add(BtnBackToDashBoard)
        Controls.Add(BtnBackToSeater)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox3)
        Margin = New Padding(3, 2, 3, 2)
        Name = "PaymentDetailSlip"
        Text = "🚘Details ☆ Receipt── .✦"
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Typetxt As TextBox
    Friend WithEvents Ratetxt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCarName As TextBox
    Friend WithEvents txtBodyNumber As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCarID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Capacitytxt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ToDate As DateTimePicker
    Friend WithEvents FromDate As DateTimePicker
    Friend WithEvents BtnPayment As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtDOB As TextBox
    Friend WithEvents txtPlateNumber As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btnBackToBooking As Button
    Friend WithEvents BtnBackToDashBoard As Button
    Friend WithEvents BtnBackToSeater As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
End Class
