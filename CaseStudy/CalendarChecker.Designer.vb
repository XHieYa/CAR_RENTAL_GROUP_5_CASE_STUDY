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
        CType(DGVSchedules, ComponentModel.ISupportInitialize).BeginInit()
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
        DGVSchedules.Location = New Point(14, 256)
        DGVSchedules.Margin = New Padding(3, 4, 3, 4)
        DGVSchedules.Name = "DGVSchedules"
        DGVSchedules.RowHeadersWidth = 51
        DGVSchedules.Size = New Size(1233, 308)
        DGVSchedules.TabIndex = 14
        ' 
        ' MnthC
        ' 
        MnthC.Location = New Point(14, 33)
        MnthC.Margin = New Padding(10, 12, 10, 12)
        MnthC.Name = "MnthC"
        MnthC.TabIndex = 13
        ' 
        ' CalendarChecker
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1261, 580)
        Controls.Add(DGVSchedules)
        Controls.Add(MnthC)
        Margin = New Padding(3, 4, 3, 4)
        Name = "CalendarChecker"
        Text = "🚘Calendar Checker── .✦"
        CType(DGVSchedules, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DGVSchedules As DataGridView
    Friend WithEvents MnthC As MonthCalendar
End Class
