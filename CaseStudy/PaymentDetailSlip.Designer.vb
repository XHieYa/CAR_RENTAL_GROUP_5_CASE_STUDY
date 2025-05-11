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
        txtContact = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
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
        Label18 = New Label()
        Label21 = New Label()
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
        btnBackToBooking.Location = New Point(761, 643)
        btnBackToBooking.Name = "btnBackToBooking"
        btnBackToBooking.Size = New Size(141, 36)
        btnBackToBooking.TabIndex = 33
        btnBackToBooking.Text = "↩Booking"
        btnBackToBooking.UseVisualStyleBackColor = False
        ' 
        ' BtnBackToDashBoard
        ' 
        BtnBackToDashBoard.BackColor = Color.PaleGoldenrod
        BtnBackToDashBoard.Font = New Font("Century", 12F, FontStyle.Bold)
        BtnBackToDashBoard.Location = New Point(591, 643)
        BtnBackToDashBoard.Name = "BtnBackToDashBoard"
        BtnBackToDashBoard.Size = New Size(152, 36)
        BtnBackToDashBoard.TabIndex = 32
        BtnBackToDashBoard.Text = "↩DashBoard"
        BtnBackToDashBoard.UseVisualStyleBackColor = False
        ' 
        ' BtnBackToSeater
        ' 
        BtnBackToSeater.BackColor = Color.PaleGoldenrod
        BtnBackToSeater.Font = New Font("Century", 12F, FontStyle.Bold)
        BtnBackToSeater.Location = New Point(435, 643)
        BtnBackToSeater.Name = "BtnBackToSeater"
        BtnBackToSeater.Size = New Size(141, 36)
        BtnBackToSeater.TabIndex = 31
        BtnBackToSeater.Text = "↩Seaters"
        BtnBackToSeater.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), Image)
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
        GroupBox3.Location = New Point(448, 108)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(430, 449)
        GroupBox3.TabIndex = 4
        GroupBox3.TabStop = False
        GroupBox3.Text = "Car Details"
        ' 
        ' txtPlateNumber
        ' 
        txtPlateNumber.BackColor = Color.FloralWhite
        txtPlateNumber.Font = New Font("Century Gothic", 12F)
        txtPlateNumber.Location = New Point(130, 171)
        txtPlateNumber.Multiline = True
        txtPlateNumber.Name = "txtPlateNumber"
        txtPlateNumber.ReadOnly = True
        txtPlateNumber.Size = New Size(292, 33)
        txtPlateNumber.TabIndex = 26
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Font = New Font("Century Gothic", 12F)
        Label16.Location = New Point(6, 180)
        Label16.Name = "Label16"
        Label16.Size = New Size(100, 23)
        Label16.TabIndex = 25
        Label16.Text = "Plate No:"
        ' 
        ' txtCarID
        ' 
        txtCarID.BackColor = Color.FloralWhite
        txtCarID.Font = New Font("Century Gothic", 12F)
        txtCarID.Location = New Point(130, 88)
        txtCarID.Multiline = True
        txtCarID.Name = "txtCarID"
        txtCarID.ReadOnly = True
        txtCarID.Size = New Size(292, 33)
        txtCarID.TabIndex = 24
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Century Gothic", 12F)
        Label12.Location = New Point(6, 140)
        Label12.Name = "Label12"
        Label12.Size = New Size(98, 23)
        Label12.TabIndex = 23
        Label12.Text = "Body No:"
        ' 
        ' Capacitytxt
        ' 
        Capacitytxt.BackColor = Color.FloralWhite
        Capacitytxt.Font = New Font("Century Gothic", 12F)
        Capacitytxt.Location = New Point(240, 341)
        Capacitytxt.Multiline = True
        Capacitytxt.Name = "Capacitytxt"
        Capacitytxt.ReadOnly = True
        Capacitytxt.Size = New Size(103, 33)
        Capacitytxt.TabIndex = 22
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Century Gothic", 12F)
        Label11.Location = New Point(106, 352)
        Label11.Name = "Label11"
        Label11.Size = New Size(107, 23)
        Label11.TabIndex = 21
        Label11.Text = "Capacity:"
        ' 
        ' Typetxt
        ' 
        Typetxt.BackColor = Color.FloralWhite
        Typetxt.Font = New Font("Century Gothic", 12F)
        Typetxt.Location = New Point(240, 297)
        Typetxt.Multiline = True
        Typetxt.Name = "Typetxt"
        Typetxt.ReadOnly = True
        Typetxt.Size = New Size(103, 33)
        Typetxt.TabIndex = 20
        ' 
        ' Ratetxt
        ' 
        Ratetxt.BackColor = Color.FloralWhite
        Ratetxt.Font = New Font("Century Gothic", 12F)
        Ratetxt.Location = New Point(240, 253)
        Ratetxt.Multiline = True
        Ratetxt.Name = "Ratetxt"
        Ratetxt.ReadOnly = True
        Ratetxt.Size = New Size(103, 33)
        Ratetxt.TabIndex = 19
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Century Gothic", 12F)
        Label10.Location = New Point(106, 307)
        Label10.Name = "Label10"
        Label10.Size = New Size(61, 23)
        Label10.TabIndex = 18
        Label10.Text = "Type:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Century Gothic", 12F)
        Label9.Location = New Point(106, 263)
        Label9.Name = "Label9"
        Label9.Size = New Size(61, 23)
        Label9.TabIndex = 17
        Label9.Text = "Rate:"
        ' 
        ' txtCarName
        ' 
        txtCarName.BackColor = Color.FloralWhite
        txtCarName.Font = New Font("Century Gothic", 12F)
        txtCarName.Location = New Point(130, 44)
        txtCarName.Multiline = True
        txtCarName.Name = "txtCarName"
        txtCarName.ReadOnly = True
        txtCarName.Size = New Size(292, 33)
        txtCarName.TabIndex = 16
        ' 
        ' txtBodyNumber
        ' 
        txtBodyNumber.BackColor = Color.FloralWhite
        txtBodyNumber.Font = New Font("Century Gothic", 12F)
        txtBodyNumber.Location = New Point(130, 131)
        txtBodyNumber.Multiline = True
        txtBodyNumber.Name = "txtBodyNumber"
        txtBodyNumber.ReadOnly = True
        txtBodyNumber.Size = New Size(292, 33)
        txtBodyNumber.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Century Gothic", 12F)
        Label8.Location = New Point(6, 99)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 23)
        Label8.TabIndex = 14
        Label8.Text = "Car ID:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Century Gothic", 12F)
        Label7.Location = New Point(6, 53)
        Label7.Name = "Label7"
        Label7.Size = New Size(118, 23)
        Label7.TabIndex = 13
        Label7.Text = "Car Name:"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackgroundImage = CType(resources.GetObject("GroupBox4.BackgroundImage"), Image)
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
        GroupBox4.Location = New Point(885, 108)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(430, 449)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        GroupBox4.Text = "Payment Method"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Century", 7.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(30, 277)
        Label17.Name = "Label17"
        Label17.Size = New Size(252, 32)
        Label17.TabIndex = 30
        Label17.Text = "✦If your payment doesn't include a " & vbCrLf & "driver, leave this box unchecked.✦"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Felix Titling", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(6, 36)
        Label15.Name = "Label15"
        Label15.Size = New Size(245, 24)
        Label15.TabIndex = 29
        Label15.Text = "✮⋆˙Rental Period˙⋆✮"
        ' 
        ' BtnCalculate
        ' 
        BtnCalculate.BackColor = Color.PaleGoldenrod
        BtnCalculate.Font = New Font("Century", 12F, FontStyle.Bold)
        BtnCalculate.Location = New Point(272, 356)
        BtnCalculate.Name = "BtnCalculate"
        BtnCalculate.Size = New Size(152, 36)
        BtnCalculate.TabIndex = 28
        BtnCalculate.Text = "Calculate☆"
        BtnCalculate.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Font = New Font("Century Gothic", 12F)
        CheckBox1.Location = New Point(17, 252)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(133, 27)
        CheckBox1.TabIndex = 27
        CheckBox1.Text = "With Driver"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Century Gothic", 12F)
        Label14.Location = New Point(62, 155)
        Label14.Name = "Label14"
        Label14.Size = New Size(36, 23)
        Label14.TabIndex = 26
        Label14.Text = "To:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Century Gothic", 12F)
        Label13.Location = New Point(62, 76)
        Label13.Name = "Label13"
        Label13.Size = New Size(63, 23)
        Label13.TabIndex = 25
        Label13.Text = "From:"
        ' 
        ' BtnPayment
        ' 
        BtnPayment.BackColor = Color.PaleGoldenrod
        BtnPayment.Font = New Font("Century", 12F, FontStyle.Bold)
        BtnPayment.Location = New Point(272, 400)
        BtnPayment.Name = "BtnPayment"
        BtnPayment.Size = New Size(152, 36)
        BtnPayment.TabIndex = 15
        BtnPayment.Text = "Checkout☆"
        BtnPayment.UseVisualStyleBackColor = False
        ' 
        ' ToDate
        ' 
        ToDate.Enabled = False
        ToDate.Font = New Font("Footlight MT Light", 13.8F)
        ToDate.Location = New Point(62, 185)
        ToDate.Name = "ToDate"
        ToDate.Size = New Size(340, 32)
        ToDate.TabIndex = 14
        ' 
        ' FromDate
        ' 
        FromDate.Enabled = False
        FromDate.Font = New Font("Footlight MT Light", 13.8F)
        FromDate.Location = New Point(62, 107)
        FromDate.Name = "FromDate"
        FromDate.Size = New Size(340, 32)
        FromDate.TabIndex = 13
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), Image)
        GroupBox2.Controls.Add(txtContact)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(txtEmail)
        GroupBox2.Font = New Font("Stencil", 9F)
        GroupBox2.Location = New Point(11, 361)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(430, 196)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Contact Details"
        ' 
        ' txtContact
        ' 
        txtContact.BackColor = Color.FloralWhite
        txtContact.Font = New Font("Footlight MT Light", 12F)
        txtContact.Location = New Point(62, 135)
        txtContact.Margin = New Padding(3, 4, 3, 4)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(292, 29)
        txtContact.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Century Gothic", 12F)
        Label4.Location = New Point(62, 37)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 23)
        Label4.TabIndex = 7
        Label4.Text = "Email:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Century Gothic", 12F)
        Label5.Location = New Point(62, 103)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 23)
        Label5.TabIndex = 8
        Label5.Text = "Contact No:"
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FloralWhite
        txtEmail.Font = New Font("Century Gothic", 12F)
        txtEmail.Location = New Point(62, 64)
        txtEmail.Multiline = True
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(292, 33)
        txtEmail.TabIndex = 9
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), Image)
        GroupBox1.Controls.Add(txtDOB)
        GroupBox1.Controls.Add(txtAge)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(txtFullName)
        GroupBox1.Controls.Add(txtUsername)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Stencil", 9F)
        GroupBox1.Location = New Point(11, 107)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.RightToLeft = RightToLeft.No
        GroupBox1.Size = New Size(430, 248)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Customer Information"
        ' 
        ' txtDOB
        ' 
        txtDOB.BackColor = Color.FloralWhite
        txtDOB.Font = New Font("Century Gothic", 12F)
        txtDOB.Location = New Point(126, 91)
        txtDOB.Multiline = True
        txtDOB.Name = "txtDOB"
        txtDOB.ReadOnly = True
        txtDOB.Size = New Size(292, 33)
        txtDOB.TabIndex = 14
        ' 
        ' txtAge
        ' 
        txtAge.BackColor = Color.FloralWhite
        txtAge.Font = New Font("Century Gothic", 12F)
        txtAge.Location = New Point(126, 132)
        txtAge.Multiline = True
        txtAge.Name = "txtAge"
        txtAge.ReadOnly = True
        txtAge.Size = New Size(100, 33)
        txtAge.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Century Gothic", 12F)
        Label6.Location = New Point(6, 181)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 23)
        Label6.TabIndex = 12
        Label6.Text = "DOB"
        ' 
        ' txtFullName
        ' 
        txtFullName.BackColor = Color.FloralWhite
        txtFullName.Font = New Font("Century Gothic", 12F)
        txtFullName.Location = New Point(126, 45)
        txtFullName.Multiline = True
        txtFullName.Name = "txtFullName"
        txtFullName.ReadOnly = True
        txtFullName.Size = New Size(292, 33)
        txtFullName.TabIndex = 11
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FloralWhite
        txtUsername.Font = New Font("Century Gothic", 12F)
        txtUsername.Location = New Point(126, 172)
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.ReadOnly = True
        txtUsername.Size = New Size(100, 33)
        txtUsername.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century Gothic", 12F)
        Label3.Location = New Point(6, 141)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 23)
        Label3.TabIndex = 3
        Label3.Text = "Age:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 12F)
        Label2.Location = New Point(6, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 23)
        Label2.TabIndex = 2
        Label2.Text = "Username:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 12F)
        Label1.Location = New Point(6, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 23)
        Label1.TabIndex = 0
        Label1.Text = "Full Name:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1208, 3)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(117, 107)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 34
        PictureBox1.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(1, 599)
        PictureBox5.Margin = New Padding(3, 4, 3, 4)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(136, 91)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 37
        PictureBox5.TabStop = False
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.Transparent
        Label19.Font = New Font("Footlight MT Light", 7.8F)
        Label19.Location = New Point(1, 569)
        Label19.Name = "Label19"
        Label19.Size = New Size(99, 14)
        Label19.TabIndex = 36
        Label19.Text = "WheelAway, Inc."
        Label19.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.Transparent
        Label20.Font = New Font("Footlight MT Light", 7.8F)
        Label20.Location = New Point(1, 583)
        Label20.Name = "Label20"
        Label20.Size = New Size(136, 14)
        Label20.TabIndex = 35
        Label20.Text = "wheelaway@gmail.com"
        Label20.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(101, 20)
        Label18.Name = "Label18"
        Label18.Size = New Size(1024, 68)
        Label18.TabIndex = 38
        Label18.Text = "Complete your booking by entering your payment details and confirming " & vbCrLf & "your reservation."
        Label18.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.BackColor = Color.Transparent
        Label21.Font = New Font("Century", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(254, 569)
        Label21.Name = "Label21"
        Label21.Size = New Size(871, 36)
        Label21.TabIndex = 39
        Label21.Text = resources.GetString("Label21.Text")
        Label21.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PaymentDetailSlip
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1326, 691)
        Controls.Add(Label21)
        Controls.Add(Label18)
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
    Friend WithEvents Label18 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtContact As TextBox
End Class
