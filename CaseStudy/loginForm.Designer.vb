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
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
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
        PictureBox2 = New PictureBox()
        PictureBox5 = New PictureBox()
        Label19 = New Label()
        Label20 = New Label()
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
        GroupBox1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), Image)
        GroupBox1.BackgroundImageLayout = ImageLayout.Zoom
        GroupBox1.Controls.Add(PictureBox3)
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
        GroupBox1.Location = New Point(12, 13)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(635, 639)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(1, 547)
        PictureBox3.Margin = New Padding(3, 4, 3, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(136, 91)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 24
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(513, 15)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(116, 111)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Footlight MT Light", 7.8F)
        Label15.Location = New Point(1, 517)
        Label15.Name = "Label15"
        Label15.Size = New Size(99, 14)
        Label15.TabIndex = 12
        Label15.Text = "WheelAway, Inc."
        Label15.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Footlight MT Light", 7.8F)
        Label14.Location = New Point(1, 531)
        Label14.Name = "Label14"
        Label14.Size = New Size(136, 14)
        Label14.TabIndex = 11
        Label14.Text = "wheelaway@gmail.com"
        Label14.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(27, 56)
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
        Label3.Location = New Point(34, 222)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 24)
        Label3.TabIndex = 9
        Label3.Text = "Password:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Footlight MT Light", 13.8F)
        Label13.Location = New Point(34, 173)
        Label13.Name = "Label13"
        Label13.Size = New Size(155, 24)
        Label13.TabIndex = 8
        Label13.Text = "Account Name:"
        ' 
        ' cbShowPassLI
        ' 
        cbShowPassLI.AutoSize = True
        cbShowPassLI.Font = New Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbShowPassLI.Location = New Point(446, 253)
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
        llblCreateAccount.Location = New Point(170, 476)
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
        BtnLogin.Location = New Point(235, 421)
        BtnLogin.Margin = New Padding(3, 4, 3, 4)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(132, 51)
        BtnLogin.TabIndex = 5
        BtnLogin.Text = "Log-in"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtpass
        ' 
        txtpass.BackColor = Color.LightGoldenrodYellow
        txtpass.Font = New Font("Footlight MT Light", 13.8F)
        txtpass.Location = New Point(235, 211)
        txtpass.Margin = New Padding(3, 4, 3, 4)
        txtpass.Multiline = True
        txtpass.Name = "txtpass"
        txtpass.PasswordChar = "●"c
        txtpass.Size = New Size(362, 35)
        txtpass.TabIndex = 4
        ' 
        ' txtuser
        ' 
        txtuser.BackColor = Color.LightGoldenrodYellow
        txtuser.Font = New Font("Footlight MT Light", 13.8F)
        txtuser.Location = New Point(235, 166)
        txtuser.Margin = New Padding(3, 4, 3, 4)
        txtuser.Multiline = True
        txtuser.Name = "txtuser"
        txtuser.Size = New Size(362, 35)
        txtuser.TabIndex = 3
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), Image)
        GroupBox2.Controls.Add(PictureBox2)
        GroupBox2.Controls.Add(PictureBox5)
        GroupBox2.Controls.Add(Label19)
        GroupBox2.Controls.Add(Label20)
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
        GroupBox2.Size = New Size(637, 639)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(515, 15)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(116, 111)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 25
        PictureBox2.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(1, 547)
        PictureBox5.Margin = New Padding(3, 4, 3, 4)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(136, 91)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 28
        PictureBox5.TabStop = False
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.Transparent
        Label19.Font = New Font("Footlight MT Light", 7.8F)
        Label19.Location = New Point(1, 517)
        Label19.Name = "Label19"
        Label19.Size = New Size(99, 14)
        Label19.TabIndex = 27
        Label19.Text = "WheelAway, Inc."
        Label19.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.Transparent
        Label20.Font = New Font("Footlight MT Light", 7.8F)
        Label20.Location = New Point(1, 531)
        Label20.Name = "Label20"
        Label20.Size = New Size(136, 14)
        Label20.TabIndex = 26
        Label20.Text = "wheelaway@gmail.com"
        Label20.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(38, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(443, 54)
        Label2.TabIndex = 13
        Label2.Text = "Welcome! Create an account to start " & vbCrLf & "your rental search."
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
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
        cbShowPasswordSI.BackColor = Color.Transparent
        cbShowPasswordSI.Font = New Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbShowPasswordSI.Location = New Point(452, 277)
        cbShowPasswordSI.Margin = New Padding(3, 4, 3, 4)
        cbShowPasswordSI.Name = "cbShowPasswordSI"
        cbShowPasswordSI.Size = New Size(157, 24)
        cbShowPasswordSI.TabIndex = 22
        cbShowPasswordSI.Text = "Show Password"
        cbShowPasswordSI.UseVisualStyleBackColor = False
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.LightGoldenrodYellow
        txtEmail.Font = New Font("Footlight MT Light", 12F)
        txtEmail.Location = New Point(212, 172)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(397, 29)
        txtEmail.TabIndex = 20
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Footlight MT Light", 13.8F)
        Label12.Location = New Point(20, 179)
        Label12.Name = "Label12"
        Label12.Size = New Size(158, 24)
        Label12.TabIndex = 21
        Label12.Text = "E-Mail Address:"
        ' 
        ' llblHaveAnAccount
        ' 
        llblHaveAnAccount.AutoSize = True
        llblHaveAnAccount.BackColor = Color.Transparent
        llblHaveAnAccount.Font = New Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        llblHaveAnAccount.Location = New Point(166, 474)
        llblHaveAnAccount.Name = "llblHaveAnAccount"
        llblHaveAnAccount.Size = New Size(285, 20)
        llblHaveAnAccount.TabIndex = 8
        llblHaveAnAccount.TabStop = True
        llblHaveAnAccount.Text = "Have an Account already? Log-in."
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Footlight MT Light", 13.8F)
        Label11.Location = New Point(20, 212)
        Label11.Name = "Label11"
        Label11.Size = New Size(103, 24)
        Label11.TabIndex = 18
        Label11.Text = "Fullname:"
        ' 
        ' txtFullName
        ' 
        txtFullName.BackColor = Color.LightGoldenrodYellow
        txtFullName.Font = New Font("Footlight MT Light", 12F)
        txtFullName.Location = New Point(212, 207)
        txtFullName.Margin = New Padding(3, 4, 3, 4)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(397, 29)
        txtFullName.TabIndex = 17
        ' 
        ' cmbSex
        ' 
        cmbSex.BackColor = Color.LemonChiffon
        cmbSex.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSex.Font = New Font("Footlight MT Light", 12F)
        cmbSex.FormattingEnabled = True
        cmbSex.Items.AddRange(New Object() {"Male", "Female", "Non-Binary", "LGBTQ+", "Not Prefered to Say"})
        cmbSex.Location = New Point(212, 307)
        cmbSex.Margin = New Padding(3, 4, 3, 4)
        cmbSex.Name = "cmbSex"
        cmbSex.Size = New Size(164, 28)
        cmbSex.TabIndex = 16
        ' 
        ' dtpDOB
        ' 
        dtpDOB.Font = New Font("Footlight MT Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpDOB.Location = New Point(212, 372)
        dtpDOB.Margin = New Padding(3, 4, 3, 4)
        dtpDOB.Name = "dtpDOB"
        dtpDOB.Size = New Size(274, 27)
        dtpDOB.TabIndex = 15
        dtpDOB.Value = New Date(2025, 3, 28, 13, 52, 21, 0)
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.LightGoldenrodYellow
        txtPassword.Font = New Font("Footlight MT Light", 12F)
        txtPassword.Location = New Point(212, 272)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "●"c
        txtPassword.Size = New Size(234, 29)
        txtPassword.TabIndex = 6
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Footlight MT Light", 13.8F)
        Label10.Location = New Point(20, 374)
        Label10.Name = "Label10"
        Label10.Size = New Size(149, 24)
        Label10.TabIndex = 6
        Label10.Text = "Date Of  Birth:"
        ' 
        ' BtnSignIn
        ' 
        BtnSignIn.Font = New Font("Felix Titling", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnSignIn.Location = New Point(244, 421)
        BtnSignIn.Margin = New Padding(3, 4, 3, 4)
        BtnSignIn.Name = "BtnSignIn"
        BtnSignIn.Size = New Size(132, 51)
        BtnSignIn.TabIndex = 6
        BtnSignIn.Text = "SIGN-UP"
        BtnSignIn.UseVisualStyleBackColor = True
        ' 
        ' txtAddress
        ' 
        txtAddress.BackColor = Color.LightGoldenrodYellow
        txtAddress.Font = New Font("Footlight MT Light", 12F)
        txtAddress.Location = New Point(212, 338)
        txtAddress.Margin = New Padding(3, 4, 3, 4)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(390, 29)
        txtAddress.TabIndex = 14
        ' 
        ' txtAge
        ' 
        txtAge.BackColor = Color.LightGoldenrodYellow
        txtAge.Font = New Font("Footlight MT Light", 12F)
        txtAge.Location = New Point(212, 240)
        txtAge.Margin = New Padding(3, 4, 3, 4)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(92, 29)
        txtAge.TabIndex = 11
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.LightGoldenrodYellow
        txtUsername.Font = New Font("Footlight MT Light", 12F)
        txtUsername.Location = New Point(212, 140)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(397, 29)
        txtUsername.TabIndex = 6
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Footlight MT Light", 13.8F)
        Label9.Location = New Point(20, 343)
        Label9.Name = "Label9"
        Label9.Size = New Size(89, 24)
        Label9.TabIndex = 10
        Label9.Text = "Address:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Footlight MT Light", 13.8F)
        Label8.Location = New Point(20, 311)
        Label8.Name = "Label8"
        Label8.Size = New Size(48, 24)
        Label8.TabIndex = 9
        Label8.Text = "Sex:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Footlight MT Light", 13.8F)
        Label7.Location = New Point(20, 278)
        Label7.Name = "Label7"
        Label7.Size = New Size(103, 24)
        Label7.TabIndex = 8
        Label7.Text = "Password:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Footlight MT Light", 13.8F)
        Label6.Location = New Point(20, 245)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 24)
        Label6.TabIndex = 7
        Label6.Text = "Age: "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Footlight MT Light", 13.8F)
        Label5.Location = New Point(20, 145)
        Label5.Name = "Label5"
        Label5.Size = New Size(161, 24)
        Label5.TabIndex = 6
        Label5.Text = "Account Name: "
        ' 
        ' loginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1326, 690)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "loginForm"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents PictureBox2 As PictureBox

End Class
