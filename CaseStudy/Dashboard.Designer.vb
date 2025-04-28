<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        lblAddress = New Label()
        lblSex = New Label()
        lblAge = New Label()
        lblFullName = New Label()
        Label2 = New Label()
        lblgreet = New Label()
        TabPage2 = New TabPage()
        TabPage3 = New TabPage()
        lblDOB = New Label()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(-1, -2)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(802, 455)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(lblDOB)
        TabPage1.Controls.Add(lblAddress)
        TabPage1.Controls.Add(lblSex)
        TabPage1.Controls.Add(lblAge)
        TabPage1.Controls.Add(lblFullName)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(lblgreet)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(794, 427)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Home"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Location = New Point(3, 78)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(86, 15)
        lblAddress.TabIndex = 5
        lblAddress.Text = "Address: [User]"
        ' 
        ' lblSex
        ' 
        lblSex.AutoSize = True
        lblSex.Location = New Point(3, 63)
        lblSex.Name = "lblSex"
        lblSex.Size = New Size(62, 15)
        lblSex.TabIndex = 4
        lblSex.Text = "Sex: [User]"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Location = New Point(3, 48)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(65, 15)
        lblAge.TabIndex = 3
        lblAge.Text = "Age: [User]"
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Location = New Point(3, 33)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(93, 15)
        lblFullName.TabIndex = 2
        lblFullName.Text = "Fullname: [User]"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 15)
        Label2.TabIndex = 1
        Label2.Text = "Basic Information:"
        ' 
        ' lblgreet
        ' 
        lblgreet.AutoSize = True
        lblgreet.Location = New Point(6, 3)
        lblgreet.Name = "lblgreet"
        lblgreet.Size = New Size(215, 15)
        lblgreet.TabIndex = 0
        lblgreet.Text = "Hello, [user] Welcome to Rent 4 Wheelz"
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(794, 427)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Logs"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(794, 427)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Settings"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' lblDOB
        ' 
        lblDOB.AutoSize = True
        lblDOB.Location = New Point(6, 93)
        lblDOB.Name = "lblDOB"
        lblDOB.Size = New Size(112, 15)
        lblDOB.TabIndex = 6
        lblDOB.Text = "Date Of Birth: [User]"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TabControl1)
        Name = "Dashboard"
        Text = "Dashboard"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents lblgreet As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblSex As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblDOB As Label
End Class
