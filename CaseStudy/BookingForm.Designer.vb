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
        TxtCar = New TextBox()
        BtnConfirm = New Button()
        BtnShow = New Button()
        DGVSchedules = New DataGridView()
        Button1 = New Button()
        BtnBookedDate = New Button()
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
        Label3.Location = New Point(14, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(25, 15)
        Label3.TabIndex = 9
        Label3.Text = "To: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(1, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 15)
        Label1.TabIndex = 8
        Label1.Text = "From:"
        ' 
        ' ToDOB
        ' 
        ToDOB.Location = New Point(45, 84)
        ToDOB.Name = "ToDOB"
        ToDOB.Size = New Size(200, 23)
        ToDOB.TabIndex = 7
        ' 
        ' FromDOB
        ' 
        FromDOB.Location = New Point(45, 55)
        FromDOB.Name = "FromDOB"
        FromDOB.Size = New Size(200, 23)
        FromDOB.TabIndex = 6
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TxtCar)
        GroupBox1.Controls.Add(BtnConfirm)
        GroupBox1.Controls.Add(FromDOB)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(ToDOB)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(260, 144)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' TxtCar
        ' 
        TxtCar.Location = New Point(45, 26)
        TxtCar.Name = "TxtCar"
        TxtCar.Size = New Size(200, 23)
        TxtCar.TabIndex = 11
        ' 
        ' BtnConfirm
        ' 
        BtnConfirm.Location = New Point(6, 113)
        BtnConfirm.Name = "BtnConfirm"
        BtnConfirm.Size = New Size(75, 23)
        BtnConfirm.TabIndex = 10
        BtnConfirm.Text = "Confirm"
        BtnConfirm.UseVisualStyleBackColor = True
        ' 
        ' BtnShow
        ' 
        BtnShow.Location = New Point(797, 63)
        BtnShow.Name = "BtnShow"
        BtnShow.Size = New Size(104, 23)
        BtnShow.TabIndex = 11
        BtnShow.Text = "ShowSchedules"
        BtnShow.UseVisualStyleBackColor = True
        ' 
        ' DGVSchedules
        ' 
        DGVSchedules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVSchedules.Location = New Point(12, 186)
        DGVSchedules.Name = "DGVSchedules"
        DGVSchedules.Size = New Size(1134, 351)
        DGVSchedules.TabIndex = 12
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(797, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(104, 23)
        Button1.TabIndex = 13
        Button1.Text = "test"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' BtnBookedDate
        ' 
        BtnBookedDate.Location = New Point(763, 151)
        BtnBookedDate.Name = "BtnBookedDate"
        BtnBookedDate.Size = New Size(147, 23)
        BtnBookedDate.TabIndex = 14
        BtnBookedDate.Text = "Show Booked Date"
        BtnBookedDate.UseVisualStyleBackColor = True
        ' 
        ' BookingForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1158, 549)
        Controls.Add(BtnBookedDate)
        Controls.Add(Button1)
        Controls.Add(DGVSchedules)
        Controls.Add(BtnShow)
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
    Friend WithEvents BtnShow As Button
    Friend WithEvents TxtCar As TextBox
    Friend WithEvents DGVSchedules As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnBookedDate As Button
End Class
