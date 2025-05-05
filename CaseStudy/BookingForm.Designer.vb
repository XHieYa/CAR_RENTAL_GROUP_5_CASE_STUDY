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
        TxtCarID = New TextBox()
        BtnConfirm = New Button()
        DGVSchedules = New DataGridView()
        Cartxt = New TextBox()
        Label2 = New Label()
        Label4 = New Label()
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
        Label3.Location = New Point(6, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(25, 15)
        Label3.TabIndex = 9
        Label3.Text = "To: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 15)
        Label1.TabIndex = 8
        Label1.Text = "From:"
        ' 
        ' ToDOB
        ' 
        ToDOB.Location = New Point(54, 106)
        ToDOB.Name = "ToDOB"
        ToDOB.Size = New Size(200, 23)
        ToDOB.TabIndex = 7
        ' 
        ' FromDOB
        ' 
        FromDOB.Location = New Point(54, 77)
        FromDOB.Name = "FromDOB"
        FromDOB.Size = New Size(200, 23)
        FromDOB.TabIndex = 6
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Cartxt)
        GroupBox1.Controls.Add(TxtCarID)
        GroupBox1.Controls.Add(BtnConfirm)
        GroupBox1.Controls.Add(FromDOB)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(ToDOB)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(260, 162)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' TxtCarID
        ' 
        TxtCarID.Location = New Point(54, 48)
        TxtCarID.Name = "TxtCarID"
        TxtCarID.Size = New Size(200, 23)
        TxtCarID.TabIndex = 11
        ' 
        ' BtnConfirm
        ' 
        BtnConfirm.Location = New Point(15, 135)
        BtnConfirm.Name = "BtnConfirm"
        BtnConfirm.Size = New Size(75, 23)
        BtnConfirm.TabIndex = 10
        BtnConfirm.Text = "Confirm"
        BtnConfirm.UseVisualStyleBackColor = True
        ' 
        ' DGVSchedules
        ' 
        DGVSchedules.AllowUserToAddRows = False
        DGVSchedules.AllowUserToDeleteRows = False
        DGVSchedules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVSchedules.Location = New Point(12, 186)
        DGVSchedules.Name = "DGVSchedules"
        DGVSchedules.Size = New Size(1134, 351)
        DGVSchedules.TabIndex = 12
        ' 
        ' Cartxt
        ' 
        Cartxt.Location = New Point(54, 19)
        Cartxt.Name = "Cartxt"
        Cartxt.Size = New Size(200, 23)
        Cartxt.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 15)
        Label2.TabIndex = 13
        Label2.Text = "Car:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 56)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 15)
        Label4.TabIndex = 14
        Label4.Text = "ID No.:"
        ' 
        ' BookingForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1158, 549)
        Controls.Add(DGVSchedules)
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
    Friend WithEvents TxtCarID As TextBox
    Friend WithEvents DGVSchedules As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Cartxt As TextBox
End Class
