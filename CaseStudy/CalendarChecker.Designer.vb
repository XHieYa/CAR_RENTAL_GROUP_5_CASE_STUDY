<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalendarChecker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalendarChecker))
        DGVSchedules = New DataGridView()
        MnthC = New MonthCalendar()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Button2 = New Button()
        CType(DGVSchedules, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DGVSchedules
        ' 
        DGVSchedules.AllowUserToAddRows = False
        DGVSchedules.AllowUserToDeleteRows = False
        DGVSchedules.AllowUserToResizeColumns = False
        DGVSchedules.AllowUserToResizeRows = False
        DGVSchedules.BackgroundColor = Color.LightGoldenrodYellow
        DGVSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVSchedules.Enabled = False
        DGVSchedules.Location = New Point(14, 231)
        DGVSchedules.Margin = New Padding(3, 4, 3, 4)
        DGVSchedules.Name = "DGVSchedules"
        DGVSchedules.RowHeadersWidth = 51
        DGVSchedules.Size = New Size(1300, 410)
        DGVSchedules.TabIndex = 14
        ' 
        ' MnthC
        ' 
        MnthC.Location = New Point(14, 21)
        MnthC.Margin = New Padding(10, 12, 10, 12)
        MnthC.Name = "MnthC"
        MnthC.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(313, 130)
        Label1.Name = "Label1"
        Label1.Size = New Size(985, 81)
        Label1.TabIndex = 15
        Label1.Text = resources.GetString("Label1.Text")
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1208, 1)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(117, 107)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 35
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(278, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 38)
        Label2.TabIndex = 36
        Label2.Text = "⊹ ࣪ ˖⏱ ୭˚.⊹"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.PaleGoldenrod
        Button2.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(12, 649)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(125, 35)
        Button2.TabIndex = 37
        Button2.Text = "↩Back"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' CalendarChecker
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1326, 691)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(DGVSchedules)
        Controls.Add(MnthC)
        Margin = New Padding(3, 4, 3, 4)
        Name = "CalendarChecker"
        Text = "🚘Calendar Checker── .✦"
        CType(DGVSchedules, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DGVSchedules As DataGridView
    Friend WithEvents MnthC As MonthCalendar
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
End Class
