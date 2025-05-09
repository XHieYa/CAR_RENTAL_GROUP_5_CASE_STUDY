<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        GroupBox1 = New GroupBox()
        Label15 = New Label()
        Label14 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label13 = New Label()
        cbShowPassLI = New CheckBox()
        llblCreateAccount = New LinkLabel()
        Label1 = New Label()
        BtnLogin = New Button()
        txtpass = New TextBox()
        txtuser = New TextBox()
        GroupBox2 = New GroupBox()
        Label2 = New Label()
        Label16 = New Label()
        cbShowPasswordSI = New CheckBox()
        txtEmail = New TextBox()
        Label12 = New Label()
        llblHaveAnAccount = New LinkLabel()
        Label11 = New Label()
        txtFullName = New TextBox()
        cmbSex = New ComboBox()
        dtpDOB = New DateTimePicker()
        txtPassword = New TextBox()
        Label10 = New Label()
        BtnSignIn = New Button()
        txtAddress = New TextBox()
        txtAge = New TextBox()
        txtUsername = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(Label15)
        GroupBox1.Controls.Add(Label14)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(cbShowPassLI)
        GroupBox1.Controls.Add(llblCreateAccount)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(BtnLogin)
        GroupBox1.Controls.Add(txtpass)
        GroupBox1.Controls.Add(txtuser)
        GroupBox1.Location = New Point(38, 13)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(609, 664)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Footlight MT Light", 10.2F)
        Label15.Location = New Point(477, 624)
        Label15.Name = "Label15"
        Label15.Size = New Size(126, 19)
        Label15.TabIndex = 12
        Label15.Text = "WheelAway, Inc."
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Footlight MT Light", 10.2F)
        Label14.Location = New Point(427, 643)
        Label14.Name = "Label14"
        Label14.Size = New Size(178, 19)
        Label14.TabIndex = 11
        Label14.Text = "wheelaway@gmail.com"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(10, 57)
        Label4.Name = "Label4"
        Label4.Size = New Size(460, 54)
        Label4.TabIndex = 10
        Label4.Text = "Welcome! Let's find your perfect rental. " & vbCrLf & "Log in here."
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Footlight MT Light", 13.8F)
        Label3.Location = New Point(46, 244)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 24)
        Label3.TabIndex = 9
        Label3.Text = "Password:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Footlight MT Light", 13.8F)
        Label13.Location = New Point(46, 191)
        Label13.Name = "Label13"
        Label13.Size = New Size(155, 24)
        Label13.TabIndex = 8
        Label13.Text = "Account Name:"
        ' 
        ' cbShowPassLI
        ' 
        cbShowPassLI.AutoSize = True
        cbShowPassLI.Font = New Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbShowPassLI.Location = New Point(410, 277)
        cbShowPassLI.Margin = New Padding(3, 4, 3, 4)
        cbShowPassLI.Name = "cbShowPassLI"
        cbShowPassLI.Size = New Size(157, 24)
        cbShowPassLI.TabIndex = 7
        cbShowPassLI.Text = "Show Password"
        cbShowPassLI.UseVisualStyleBackColor = True
        ' 
        ' llblCreateAccount
        ' 
        llblCreateAccount.AutoSize = True
        llblCreateAccount.Font = New Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        llblCreateAccount.Location = New Point(178, 487)
        llblCreateAccount.Name = "llblCreateAccount"
        llblCreateAccount.Size = New Size(258, 20)
        llblCreateAccount.TabIndex = 6
        llblCreateAccount.TabStop = True
        llblCreateAccount.Text = "No account yet? Register here."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(6, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 23)
        Label1.TabIndex = 0
        Label1.Text = "Log-In"
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Font = New Font("Felix Titling", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnLogin.Location = New Point(235, 418)
        BtnLogin.Margin = New Padding(3, 4, 3, 4)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(132, 51)
        BtnLogin.TabIndex = 5
        BtnLogin.Text = "Log-in"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtpass
        ' 
        txtpass.Font = New Font("Footlight MT Light", 13.8F)
        txtpass.Location = New Point(247, 234)
        txtpass.Margin = New Padding(3, 4, 3, 4)
        txtpass.Multiline = True
        txtpass.Name = "txtpass"
        txtpass.PasswordChar = "*"c
        txtpass.Size = New Size(320, 35)
        txtpass.TabIndex = 4
        ' 
        ' txtuser
        ' 
        txtuser.Font = New Font("Footlight MT Light", 13.8F)
        txtuser.Location = New Point(247, 184)
        txtuser.Margin = New Padding(3, 4, 3, 4)
        txtuser.Multiline = True
        txtuser.Name = "txtuser"
        txtuser.Size = New Size(320, 35)
        txtuser.TabIndex = 3
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(PictureBox2)
        GroupBox2.Controls.Add(Label17)
        GroupBox2.Controls.Add(Label18)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label16)
        GroupBox2.Controls.Add(cbShowPasswordSI)
        GroupBox2.Controls.Add(txtEmail)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(llblHaveAnAccount)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(txtFullName)
        GroupBox2.Controls.Add(cmbSex)
        GroupBox2.Controls.Add(dtpDOB)
        GroupBox2.Controls.Add(txtPassword)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(BtnSignIn)
        GroupBox2.Controls.Add(txtAddress)
        GroupBox2.Controls.Add(txtAge)
        GroupBox2.Controls.Add(txtUsername)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Location = New Point(677, 13)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.Size = New Size(609, 664)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(20, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(443, 54)
        Label2.TabIndex = 13
        Label2.Text = "Welcome! Create an account to start " & vbCrLf & "your rental search."
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(7, 15)
        Label16.Name = "Label16"
        Label16.Size = New Size(93, 23)
        Label16.TabIndex = 13
        Label16.Text = "Sign-Up"
        ' 
        ' cbShowPasswordSI
        ' 
        cbShowPasswordSI.AutoSize = True
        cbShowPasswordSI.Font = New Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbShowPasswordSI.Location = New Point(444, 320)
        cbShowPasswordSI.Margin = New Padding(3, 4, 3, 4)
        cbShowPasswordSI.Name = "cbShowPasswordSI"
        cbShowPasswordSI.Size = New Size(157, 24)
        cbShowPasswordSI.TabIndex = 22
        cbShowPasswordSI.Text = "Show Password"
        cbShowPasswordSI.UseVisualStyleBackColor = True
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Footlight MT Light", 12F)
        txtEmail.Location = New Point(213, 218)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(347, 29)
        txtEmail.TabIndex = 20
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Footlight MT Light", 13.8F)
        Label12.Location = New Point(21, 221)
        Label12.Name = "Label12"
        Label12.Size = New Size(158, 24)
        Label12.TabIndex = 21
        Label12.Text = "E-Mail Address:"
        ' 
        ' llblHaveAnAccount
        ' 
        llblHaveAnAccount.AutoSize = True
        llblHaveAnAccount.Font = New Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        llblHaveAnAccount.Location = New Point(159, 553)
        llblHaveAnAccount.Name = "llblHaveAnAccount"
        llblHaveAnAccount.Size = New Size(280, 20)
        llblHaveAnAccount.TabIndex = 8
        llblHaveAnAccount.TabStop = True
        llblHaveAnAccount.Text = "Have an Account already? Log-in"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Footlight MT Light", 13.8F)
        Label11.Location = New Point(21, 254)
        Label11.Name = "Label11"
        Label11.Size = New Size(103, 24)
        Label11.TabIndex = 18
        Label11.Text = "Fullname:"
        ' 
        ' txtFullName
        ' 
        txtFullName.Font = New Font("Footlight MT Light", 12F)
        txtFullName.Location = New Point(213, 251)
        txtFullName.Margin = New Padding(3, 4, 3, 4)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(347, 29)
        txtFullName.TabIndex = 17
        ' 
        ' cmbSex
        ' 
        cmbSex.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSex.Font = New Font("Footlight MT Light", 12F)
        cmbSex.FormattingEnabled = True
        cmbSex.Items.AddRange(New Object() {"Male", "Female", "Non-Binary", "LGBTQ+", "Not Prefered to Say"})
        cmbSex.Location = New Point(213, 350)
        cmbSex.Margin = New Padding(3, 4, 3, 4)
        cmbSex.Name = "cmbSex"
        cmbSex.Size = New Size(151, 28)
        cmbSex.TabIndex = 16
        ' 
        ' dtpDOB
        ' 
        dtpDOB.Font = New Font("Footlight MT Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpDOB.Location = New Point(213, 417)
        dtpDOB.Margin = New Padding(3, 4, 3, 4)
        dtpDOB.Name = "dtpDOB"
        dtpDOB.Size = New Size(272, 27)
        dtpDOB.TabIndex = 15
        dtpDOB.Value = New Date(2025, 3, 28, 13, 52, 21, 0)
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Footlight MT Light", 12F)
        txtPassword.Location = New Point(213, 317)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(226, 29)
        txtPassword.TabIndex = 6
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Footlight MT Light", 13.8F)
        Label10.Location = New Point(21, 417)
        Label10.Name = "Label10"
        Label10.Size = New Size(149, 24)
        Label10.TabIndex = 6
        Label10.Text = "Date Of  Birth:"
        ' 
        ' BtnSignIn
        ' 
        BtnSignIn.Font = New Font("Felix Titling", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnSignIn.Location = New Point(232, 487)
        BtnSignIn.Margin = New Padding(3, 4, 3, 4)
        BtnSignIn.Name = "BtnSignIn"
        BtnSignIn.Size = New Size(132, 51)
        BtnSignIn.TabIndex = 6
        BtnSignIn.Text = "SIGN-UP"
        BtnSignIn.UseVisualStyleBackColor = True
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Footlight MT Light", 12F)
        txtAddress.Location = New Point(213, 382)
        txtAddress.Margin = New Padding(3, 4, 3, 4)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(347, 29)
        txtAddress.TabIndex = 14
        ' 
        ' txtAge
        ' 
        txtAge.Font = New Font("Footlight MT Light", 12F)
        txtAge.Location = New Point(213, 287)
        txtAge.Margin = New Padding(3, 4, 3, 4)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(65, 29)
        txtAge.TabIndex = 11
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Footlight MT Light", 12F)
        txtUsername.Location = New Point(213, 188)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(347, 29)
        txtUsername.TabIndex = 6
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Footlight MT Light", 13.8F)
        Label9.Location = New Point(21, 385)
        Label9.Name = "Label9"
        Label9.Size = New Size(89, 24)
        Label9.TabIndex = 10
        Label9.Text = "Address:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Footlight MT Light", 13.8F)
        Label8.Location = New Point(21, 354)
        Label8.Name = "Label8"
        Label8.Size = New Size(48, 24)
        Label8.TabIndex = 9
        Label8.Text = "Sex:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Footlight MT Light", 13.8F)
        Label7.Location = New Point(21, 320)
        Label7.Name = "Label7"
        Label7.Size = New Size(103, 24)
        Label7.TabIndex = 8
        Label7.Text = "Password:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Footlight MT Light", 13.8F)
        Label6.Location = New Point(21, 287)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 24)
        Label6.TabIndex = 7
        Label6.Text = "Age: "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Footlight MT Light", 13.8F)
        Label5.Location = New Point(21, 187)
        Label5.Name = "Label5"
        Label5.Size = New Size(161, 24)
        Label5.TabIndex = 6
        Label5.Text = "Account Name: "
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Footlight MT Light", 10.2F)
        Label17.Location = New Point(477, 624)
        Label17.Name = "Label17"
        Label17.Size = New Size(126, 19)
        Label17.TabIndex = 14
        Label17.Text = "WheelAway, Inc."
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Footlight MT Light", 10.2F)
        Label18.Location = New Point(427, 643)
        Label18.Name = "Label18"
        Label18.Size = New Size(178, 19)
        Label18.TabIndex = 13
        Label18.Text = "wheelaway@gmail.com"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(480, 15)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(129, 127)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(476, 15)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(129, 127)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' loginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1326, 690)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "loginForm"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtuser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnSignIn As Button
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents llblCreateAccount As LinkLabel
    Friend WithEvents cmbSex As ComboBox
    Friend WithEvents cbShowPassLI As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents llblHaveAnAccount As LinkLabel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbShowPasswordSI As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox2 As PictureBox

End Class
