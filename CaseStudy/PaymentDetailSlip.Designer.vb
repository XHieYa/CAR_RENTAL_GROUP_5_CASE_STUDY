<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentDetailSlip
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
        Panel1 = New Panel()
        GroupBox5 = New GroupBox()
        GroupBox3 = New GroupBox()
        txtCarID = New TextBox()
        Label12 = New Label()
        TextBox10 = New TextBox()
        Label11 = New Label()
        TextBox9 = New TextBox()
        TextBox8 = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        txtCarName = New TextBox()
        txtPlateNumber = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        GroupBox4 = New GroupBox()
        Label15 = New Label()
        BtnCalculate = New Button()
        CheckBox1 = New CheckBox()
        Label14 = New Label()
        Label13 = New Label()
        BtnPayment = New Button()
        ToDate = New DateTimePicker()
        FromDate = New DateTimePicker()
        CheckBox2 = New CheckBox()
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
        Panel1.Controls.Add(GroupBox5)
        Panel1.Controls.Add(GroupBox3)
        Panel1.Controls.Add(GroupBox4)
        Panel1.Controls.Add(CheckBox2)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Location = New Point(5, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(479, 728)
        Panel1.TabIndex = 2
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Location = New Point(321, 475)
        GroupBox5.Margin = New Padding(3, 4, 3, 4)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Padding = New Padding(3, 4, 3, 4)
        GroupBox5.Size = New Size(152, 253)
        GroupBox5.TabIndex = 5
        GroupBox5.TabStop = False
        GroupBox5.Text = "Receipt"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txtCarID)
        GroupBox3.Controls.Add(Label12)
        GroupBox3.Controls.Add(TextBox10)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(TextBox9)
        GroupBox3.Controls.Add(TextBox8)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(txtCarName)
        GroupBox3.Controls.Add(txtPlateNumber)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Location = New Point(9, 253)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(467, 213)
        GroupBox3.TabIndex = 4
        GroupBox3.TabStop = False
        GroupBox3.Text = "Car Details"
        ' 
        ' txtCarID
        ' 
        txtCarID.Location = New Point(115, 112)
        txtCarID.Multiline = True
        txtCarID.Name = "txtCarID"
        txtCarID.ReadOnly = True
        txtCarID.Size = New Size(346, 33)
        txtCarID.TabIndex = 24
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(9, 115)
        Label12.Name = "Label12"
        Label12.Size = New Size(101, 20)
        Label12.TabIndex = 23
        Label12.Text = "Body Number"
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(373, 163)
        TextBox10.Multiline = True
        TextBox10.Name = "TextBox10"
        TextBox10.ReadOnly = True
        TextBox10.Size = New Size(89, 33)
        TextBox10.TabIndex = 22
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(301, 165)
        Label11.Name = "Label11"
        Label11.Size = New Size(66, 20)
        Label11.TabIndex = 21
        Label11.Text = "Capacity"
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(192, 163)
        TextBox9.Multiline = True
        TextBox9.Name = "TextBox9"
        TextBox9.ReadOnly = True
        TextBox9.Size = New Size(108, 33)
        TextBox9.TabIndex = 20
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(55, 163)
        TextBox8.Multiline = True
        TextBox8.Name = "TextBox8"
        TextBox8.ReadOnly = True
        TextBox8.Size = New Size(90, 33)
        TextBox8.TabIndex = 19
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(146, 165)
        Label10.Name = "Label10"
        Label10.Size = New Size(40, 20)
        Label10.TabIndex = 18
        Label10.Text = "Type"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(9, 165)
        Label9.Name = "Label9"
        Label9.Size = New Size(45, 20)
        Label9.TabIndex = 17
        Label9.Text = "Color"
        ' 
        ' txtCarName
        ' 
        txtCarName.Location = New Point(115, 32)
        txtCarName.Multiline = True
        txtCarName.Name = "txtCarName"
        txtCarName.ReadOnly = True
        txtCarName.Size = New Size(346, 33)
        txtCarName.TabIndex = 16
        ' 
        ' txtPlateNumber
        ' 
        txtPlateNumber.Location = New Point(115, 72)
        txtPlateNumber.Multiline = True
        txtPlateNumber.Name = "txtPlateNumber"
        txtPlateNumber.ReadOnly = True
        txtPlateNumber.Size = New Size(346, 33)
        txtPlateNumber.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(9, 75)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 20)
        Label8.TabIndex = 14
        Label8.Text = "Plate Number"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(9, 35)
        Label7.Name = "Label7"
        Label7.Size = New Size(75, 20)
        Label7.TabIndex = 13
        Label7.Text = "Car Name"
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
        GroupBox4.Location = New Point(9, 475)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(309, 251)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        GroupBox4.Text = "Payment Method"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(93, 35)
        Label15.Name = "Label15"
        Label15.Size = New Size(87, 20)
        Label15.TabIndex = 29
        Label15.Text = "Rental Date"
        ' 
        ' BtnCalculate
        ' 
        BtnCalculate.Location = New Point(11, 209)
        BtnCalculate.Name = "BtnCalculate"
        BtnCalculate.Size = New Size(141, 36)
        BtnCalculate.TabIndex = 28
        BtnCalculate.Text = "Calculate"
        BtnCalculate.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(29, 165)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(106, 24)
        CheckBox1.TabIndex = 27
        CheckBox1.Text = "With Driver"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(9, 113)
        Label14.Name = "Label14"
        Label14.Size = New Size(29, 20)
        Label14.TabIndex = 26
        Label14.Text = "Till"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(9, 57)
        Label13.Name = "Label13"
        Label13.Size = New Size(43, 20)
        Label13.TabIndex = 25
        Label13.Text = "From"
        ' 
        ' BtnPayment
        ' 
        BtnPayment.Location = New Point(159, 209)
        BtnPayment.Name = "BtnPayment"
        BtnPayment.Size = New Size(141, 36)
        BtnPayment.TabIndex = 15
        BtnPayment.Text = "Proceed to pay"
        BtnPayment.UseVisualStyleBackColor = True
        ' 
        ' ToDate
        ' 
        ToDate.Enabled = False
        ToDate.Location = New Point(29, 133)
        ToDate.Name = "ToDate"
        ToDate.Size = New Size(241, 27)
        ToDate.TabIndex = 14
        ' 
        ' FromDate
        ' 
        FromDate.Enabled = False
        FromDate.Location = New Point(29, 80)
        FromDate.Name = "FromDate"
        FromDate.Size = New Size(241, 27)
        FromDate.TabIndex = 13
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(112, 653)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(106, 24)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "With Driver"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(TextBox4)
        GroupBox2.Controls.Add(txtEmail)
        GroupBox2.Location = New Point(3, 133)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(473, 115)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Contact Details"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 37)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 20)
        Label4.TabIndex = 7
        Label4.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 73)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 20)
        Label5.TabIndex = 8
        Label5.Text = "Contact No."
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(99, 69)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(331, 33)
        TextBox4.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(99, 29)
        txtEmail.Multiline = True
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(331, 33)
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
        GroupBox1.Location = New Point(3, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.RightToLeft = RightToLeft.No
        GroupBox1.Size = New Size(473, 124)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Customer Information"
        ' 
        ' txtDOB
        ' 
        txtDOB.Location = New Point(87, 77)
        txtDOB.Multiline = True
        txtDOB.Name = "txtDOB"
        txtDOB.ReadOnly = True
        txtDOB.Size = New Size(173, 31)
        txtDOB.TabIndex = 14
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(338, 75)
        txtAge.Multiline = True
        txtAge.Name = "txtAge"
        txtAge.ReadOnly = True
        txtAge.Size = New Size(74, 33)
        txtAge.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(9, 84)
        Label6.Name = "Label6"
        Label6.Size = New Size(40, 20)
        Label6.TabIndex = 12
        Label6.Text = "DOB"
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(87, 35)
        txtFullName.Multiline = True
        txtFullName.Name = "txtFullName"
        txtFullName.ReadOnly = True
        txtFullName.Size = New Size(173, 33)
        txtFullName.TabIndex = 11
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(338, 31)
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.ReadOnly = True
        txtUsername.Size = New Size(129, 33)
        txtUsername.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(267, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 20)
        Label3.TabIndex = 3
        Label3.Text = "Age:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(267, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 20)
        Label2.TabIndex = 2
        Label2.Text = "Username:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(9, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 20)
        Label1.TabIndex = 0
        Label1.Text = "FullName"
        ' 
        ' PaymentDetailSlip
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(489, 752)
        Controls.Add(Panel1)
        Name = "PaymentDetailSlip"
        Text = "DetailsReceipt"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCarName As TextBox
    Friend WithEvents txtPlateNumber As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCarID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CheckBox2 As CheckBox
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
End Class
