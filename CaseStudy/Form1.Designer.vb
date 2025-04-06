<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        GroupBox1 = New GroupBox()
        CheckBox1 = New CheckBox()
        LinkLabel1 = New LinkLabel()
        BtnLogin = New Button()
        txtpass = New TextBox()
        txtuser = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        Label11 = New Label()
        sifullname = New TextBox()
        Cmbsex = New ComboBox()
        DateTimePickerDOB = New DateTimePicker()
        sipassword = New TextBox()
        Label10 = New Label()
        BtnSignIn = New Button()
        siaddress = New TextBox()
        siage = New TextBox()
        siusername = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label2 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Controls.Add(LinkLabel1)
        GroupBox1.Controls.Add(BtnLogin)
        GroupBox1.Controls.Add(txtpass)
        GroupBox1.Controls.Add(txtuser)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(6, -3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(393, 447)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(20, 109)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(108, 19)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(6, 131)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(89, 15)
        LinkLabel1.TabIndex = 6
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Create Account"
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Location = New Point(252, 119)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(75, 23)
        BtnLogin.TabIndex = 5
        BtnLogin.Text = "Log-in"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtpass
        ' 
        txtpass.Location = New Point(99, 80)
        txtpass.Name = "txtpass"
        txtpass.PasswordChar = "*"c
        txtpass.Size = New Size(123, 23)
        txtpass.TabIndex = 4
        ' 
        ' txtuser
        ' 
        txtuser.Location = New Point(99, 51)
        txtuser.Name = "txtuser"
        txtuser.Size = New Size(153, 23)
        txtuser.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 83)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 15)
        Label4.TabIndex = 2
        Label4.Text = "Password:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 59)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 15)
        Label3.TabIndex = 1
        Label3.Text = "Account Name: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(6, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 25)
        Label1.TabIndex = 0
        Label1.Text = "Log-In"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(sifullname)
        GroupBox2.Controls.Add(Cmbsex)
        GroupBox2.Controls.Add(DateTimePickerDOB)
        GroupBox2.Controls.Add(sipassword)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(BtnSignIn)
        GroupBox2.Controls.Add(siaddress)
        GroupBox2.Controls.Add(siage)
        GroupBox2.Controls.Add(siusername)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Location = New Point(405, -3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(393, 447)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(6, 93)
        Label11.Name = "Label11"
        Label11.Size = New Size(59, 15)
        Label11.TabIndex = 18
        Label11.Text = "Fullname:"
        ' 
        ' sifullname
        ' 
        sifullname.Location = New Point(105, 85)
        sifullname.Name = "sifullname"
        sifullname.Size = New Size(153, 23)
        sifullname.TabIndex = 17
        ' 
        ' Cmbsex
        ' 
        Cmbsex.DropDownStyle = ComboBoxStyle.DropDownList
        Cmbsex.FormattingEnabled = True
        Cmbsex.Items.AddRange(New Object() {"Male", "Female", "Non-Binary", "LGBTQ+", "Not Prefered to Say"})
        Cmbsex.Location = New Point(105, 170)
        Cmbsex.Name = "Cmbsex"
        Cmbsex.Size = New Size(153, 23)
        Cmbsex.TabIndex = 16
        ' 
        ' DateTimePickerDOB
        ' 
        DateTimePickerDOB.Location = New Point(105, 228)
        DateTimePickerDOB.Name = "DateTimePickerDOB"
        DateTimePickerDOB.Size = New Size(198, 23)
        DateTimePickerDOB.TabIndex = 15
        DateTimePickerDOB.Value = New Date(2025, 3, 28, 13, 52, 21, 0)
        ' 
        ' sipassword
        ' 
        sipassword.Location = New Point(105, 141)
        sipassword.Name = "sipassword"
        sipassword.Size = New Size(153, 23)
        sipassword.TabIndex = 6
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(6, 236)
        Label10.Name = "Label10"
        Label10.Size = New Size(81, 15)
        Label10.TabIndex = 6
        Label10.Text = "Date Of  Birth:"
        ' 
        ' BtnSignIn
        ' 
        BtnSignIn.Location = New Point(286, 263)
        BtnSignIn.Name = "BtnSignIn"
        BtnSignIn.Size = New Size(75, 23)
        BtnSignIn.TabIndex = 6
        BtnSignIn.Text = "Sign-Up"
        BtnSignIn.UseVisualStyleBackColor = True
        ' 
        ' siaddress
        ' 
        siaddress.Location = New Point(105, 199)
        siaddress.Name = "siaddress"
        siaddress.Size = New Size(153, 23)
        siaddress.TabIndex = 14
        ' 
        ' siage
        ' 
        siage.Location = New Point(105, 112)
        siage.Name = "siage"
        siage.Size = New Size(153, 23)
        siage.TabIndex = 11
        ' 
        ' siusername
        ' 
        siusername.Location = New Point(105, 56)
        siusername.Name = "siusername"
        siusername.Size = New Size(153, 23)
        siusername.TabIndex = 6
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(6, 207)
        Label9.Name = "Label9"
        Label9.Size = New Size(52, 15)
        Label9.TabIndex = 10
        Label9.Text = "Address:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(6, 178)
        Label8.Name = "Label8"
        Label8.Size = New Size(28, 15)
        Label8.TabIndex = 9
        Label8.Text = "Sex:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 149)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 15)
        Label7.TabIndex = 8
        Label7.Text = "Password:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 120)
        Label6.Name = "Label6"
        Label6.Size = New Size(34, 15)
        Label6.TabIndex = 7
        Label6.Text = "Age: "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 59)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 15)
        Label5.TabIndex = 6
        Label5.Text = "Account Name: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(6, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 25)
        Label2.TabIndex = 1
        Label2.Text = "Sign-In"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtuser As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSignIn As Button
    Friend WithEvents siaddress As TextBox
    Friend WithEvents siage As TextBox
    Friend WithEvents siusername As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents sipassword As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePickerDOB As DateTimePicker
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Cmbsex As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents sifullname As TextBox

End Class
