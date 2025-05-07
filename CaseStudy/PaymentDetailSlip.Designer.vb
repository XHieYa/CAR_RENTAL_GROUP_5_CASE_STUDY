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
        Panel1 = New Panel()
        GroupBox3 = New GroupBox()
        txtPlateNumber = New TextBox()
        Label16 = New Label()
        txtCarID = New TextBox()
        Label12 = New Label()
        Capacitytxt = New TextBox()
        Label11 = New Label()
        Typetxt = New TextBox()
        Colortxt = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        txtCarName = New TextBox()
        txtBodyNumber = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        GroupBox5 = New GroupBox()
        GroupBox4 = New GroupBox()
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
        TextBox4 = New TextBox()
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
        Panel1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(GroupBox3)
        Panel1.Controls.Add(GroupBox5)
        Panel1.Controls.Add(GroupBox4)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Location = New Point(12, 11)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(444, 562)
        Panel1.TabIndex = 2
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
        GroupBox3.Controls.Add(Colortxt)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(txtCarName)
        GroupBox3.Controls.Add(txtBodyNumber)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Location = New Point(10, 206)
        GroupBox3.Margin = New Padding(3, 2, 3, 2)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(3, 2, 3, 2)
        GroupBox3.Size = New Size(425, 153)
        GroupBox3.TabIndex = 4
        GroupBox3.TabStop = False
        GroupBox3.Text = "Car Details"
        ' 
        ' txtPlateNumber
        ' 
        txtPlateNumber.Location = New Point(277, 54)
        txtPlateNumber.Margin = New Padding(3, 2, 3, 2)
        txtPlateNumber.Multiline = True
        txtPlateNumber.Name = "txtPlateNumber"
        txtPlateNumber.ReadOnly = True
        txtPlateNumber.Size = New Size(102, 20)
        txtPlateNumber.TabIndex = 26
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(192, 57)
        Label16.Name = "Label16"
        Label16.Size = New Size(80, 15)
        Label16.TabIndex = 25
        Label16.Text = "Plate Number"
        ' 
        ' txtCarID
        ' 
        txtCarID.Location = New Point(95, 54)
        txtCarID.Margin = New Padding(3, 2, 3, 2)
        txtCarID.Multiline = True
        txtCarID.Name = "txtCarID"
        txtCarID.ReadOnly = True
        txtCarID.Size = New Size(95, 20)
        txtCarID.TabIndex = 24
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(8, 86)
        Label12.Name = "Label12"
        Label12.Size = New Size(81, 15)
        Label12.TabIndex = 23
        Label12.Text = "Body Number"
        ' 
        ' Capacitytxt
        ' 
        Capacitytxt.Location = New Point(310, 121)
        Capacitytxt.Margin = New Padding(3, 2, 3, 2)
        Capacitytxt.Multiline = True
        Capacitytxt.Name = "Capacitytxt"
        Capacitytxt.ReadOnly = True
        Capacitytxt.Size = New Size(69, 20)
        Capacitytxt.TabIndex = 22
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(251, 124)
        Label11.Name = "Label11"
        Label11.Size = New Size(53, 15)
        Label11.TabIndex = 21
        Label11.Text = "Capacity"
        ' 
        ' Typetxt
        ' 
        Typetxt.Location = New Point(163, 123)
        Typetxt.Margin = New Padding(3, 2, 3, 2)
        Typetxt.Multiline = True
        Typetxt.Name = "Typetxt"
        Typetxt.ReadOnly = True
        Typetxt.Size = New Size(84, 20)
        Typetxt.TabIndex = 20
        ' 
        ' Colortxt
        ' 
        Colortxt.Location = New Point(50, 124)
        Colortxt.Margin = New Padding(3, 2, 3, 2)
        Colortxt.Multiline = True
        Colortxt.Name = "Colortxt"
        Colortxt.ReadOnly = True
        Colortxt.Size = New Size(70, 20)
        Colortxt.TabIndex = 19
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(126, 126)
        Label10.Name = "Label10"
        Label10.Size = New Size(31, 15)
        Label10.TabIndex = 18
        Label10.Text = "Type"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(8, 124)
        Label9.Name = "Label9"
        Label9.Size = New Size(36, 15)
        Label9.TabIndex = 17
        Label9.Text = "Color"
        ' 
        ' txtCarName
        ' 
        txtCarName.Location = New Point(94, 20)
        txtCarName.Margin = New Padding(3, 2, 3, 2)
        txtCarName.Multiline = True
        txtCarName.Name = "txtCarName"
        txtCarName.ReadOnly = True
        txtCarName.Size = New Size(303, 26)
        txtCarName.TabIndex = 16
        ' 
        ' txtBodyNumber
        ' 
        txtBodyNumber.Location = New Point(95, 83)
        txtBodyNumber.Margin = New Padding(3, 2, 3, 2)
        txtBodyNumber.Multiline = True
        txtBodyNumber.Name = "txtBodyNumber"
        txtBodyNumber.ReadOnly = True
        txtBodyNumber.Size = New Size(284, 20)
        txtBodyNumber.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(8, 56)
        Label8.Name = "Label8"
        Label8.Size = New Size(39, 15)
        Label8.TabIndex = 14
        Label8.Text = "Car ID"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(8, 26)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 15)
        Label7.TabIndex = 13
        Label7.Text = "Car Name"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Location = New Point(287, 362)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(148, 192)
        GroupBox5.TabIndex = 5
        GroupBox5.TabStop = False
        GroupBox5.Text = "Receipt"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(Label15)
        GroupBox4.Controls.Add(BtnCalculate)
        GroupBox4.Controls.Add(CheckBox1)
        GroupBox4.Controls.Add(Label14)
        GroupBox4.Controls.Add(Label13)
        GroupBox4.Controls.Add(BtnPayment)
        GroupBox4.Controls.Add(ToDate)
        GroupBox4.Controls.Add(FromDate)
        GroupBox4.Location = New Point(5, 368)
        GroupBox4.Margin = New Padding(3, 2, 3, 2)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(3, 2, 3, 2)
        GroupBox4.Size = New Size(270, 192)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        GroupBox4.Text = "Payment Method"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(81, 26)
        Label15.Name = "Label15"
        Label15.Size = New Size(67, 15)
        Label15.TabIndex = 29
        Label15.Text = "Rental Date"
        ' 
        ' BtnCalculate
        ' 
        BtnCalculate.Location = New Point(10, 157)
        BtnCalculate.Margin = New Padding(3, 2, 3, 2)
        BtnCalculate.Name = "BtnCalculate"
        BtnCalculate.Size = New Size(123, 27)
        BtnCalculate.TabIndex = 28
        BtnCalculate.Text = "Calculate"
        BtnCalculate.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(25, 124)
        CheckBox1.Margin = New Padding(3, 2, 3, 2)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(85, 19)
        CheckBox1.TabIndex = 27
        CheckBox1.Text = "With Driver"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(8, 85)
        Label14.Name = "Label14"
        Label14.Size = New Size(22, 15)
        Label14.TabIndex = 26
        Label14.Text = "Till"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(8, 43)
        Label13.Name = "Label13"
        Label13.Size = New Size(35, 15)
        Label13.TabIndex = 25
        Label13.Text = "From"
        ' 
        ' BtnPayment
        ' 
        BtnPayment.Location = New Point(139, 157)
        BtnPayment.Margin = New Padding(3, 2, 3, 2)
        BtnPayment.Name = "BtnPayment"
        BtnPayment.Size = New Size(123, 27)
        BtnPayment.TabIndex = 15
        BtnPayment.Text = "Proceed to pay"
        BtnPayment.UseVisualStyleBackColor = True
        ' 
        ' ToDate
        ' 
        ToDate.Enabled = False
        ToDate.Location = New Point(25, 100)
        ToDate.Margin = New Padding(3, 2, 3, 2)
        ToDate.Name = "ToDate"
        ToDate.Size = New Size(211, 23)
        ToDate.TabIndex = 14
        ' 
        ' FromDate
        ' 
        FromDate.Enabled = False
        FromDate.Location = New Point(25, 60)
        FromDate.Margin = New Padding(3, 2, 3, 2)
        FromDate.Name = "FromDate"
        FromDate.Size = New Size(211, 23)
        FromDate.TabIndex = 13
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(TextBox4)
        GroupBox2.Controls.Add(txtEmail)
        GroupBox2.Location = New Point(10, 117)
        GroupBox2.Margin = New Padding(3, 2, 3, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 2, 3, 2)
        GroupBox2.Size = New Size(425, 85)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Contact Details"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(8, 20)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 7
        Label4.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(10, 50)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 15)
        Label5.TabIndex = 8
        Label5.Text = "Contact No."
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(87, 47)
        TextBox4.Margin = New Padding(3, 2, 3, 2)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(303, 26)
        TextBox4.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(87, 17)
        txtEmail.Margin = New Padding(3, 2, 3, 2)
        txtEmail.Multiline = True
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(303, 26)
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
        GroupBox1.Location = New Point(10, 11)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.RightToLeft = RightToLeft.No
        GroupBox1.Size = New Size(425, 102)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Customer Information"
        ' 
        ' txtDOB
        ' 
        txtDOB.Location = New Point(76, 58)
        txtDOB.Margin = New Padding(3, 2, 3, 2)
        txtDOB.Multiline = True
        txtDOB.Name = "txtDOB"
        txtDOB.ReadOnly = True
        txtDOB.Size = New Size(152, 24)
        txtDOB.TabIndex = 14
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(296, 56)
        txtAge.Margin = New Padding(3, 2, 3, 2)
        txtAge.Multiline = True
        txtAge.Name = "txtAge"
        txtAge.ReadOnly = True
        txtAge.Size = New Size(65, 26)
        txtAge.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(8, 63)
        Label6.Name = "Label6"
        Label6.Size = New Size(31, 15)
        Label6.TabIndex = 12
        Label6.Text = "DOB"
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(76, 26)
        txtFullName.Margin = New Padding(3, 2, 3, 2)
        txtFullName.Multiline = True
        txtFullName.Name = "txtFullName"
        txtFullName.ReadOnly = True
        txtFullName.Size = New Size(152, 26)
        txtFullName.TabIndex = 11
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(296, 23)
        txtUsername.Margin = New Padding(3, 2, 3, 2)
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.ReadOnly = True
        txtUsername.Size = New Size(94, 26)
        txtUsername.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(234, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 3
        Label3.Text = "Age:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(234, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 2
        Label2.Text = "Username:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(8, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 15)
        Label1.TabIndex = 0
        Label1.Text = "FullName"
        ' 
        ' PaymentDetailSlip
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(462, 580)
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "PaymentDetailSlip"
        Text = "DetailsReceipt"
        Panel1.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Typetxt As TextBox
    Friend WithEvents Colortxt As TextBox
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
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtPlateNumber As TextBox
    Friend WithEvents Label16 As Label
End Class
