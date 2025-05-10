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
        DGVSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVSchedules.Enabled = False
        DGVSchedules.Location = New Point(12, 220)
        DGVSchedules.Name = "DGVSchedules"
        DGVSchedules.Size = New Size(1079, 203)
        DGVSchedules.TabIndex = 14
        ' 
        ' MnthC
        ' 
        MnthC.Location = New Point(439, 18)
        MnthC.Name = "MnthC"
        MnthC.TabIndex = 13
        ' 
        ' CalendarChecker
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1103, 435)
        Controls.Add(DGVSchedules)
        Controls.Add(MnthC)
        Name = "CalendarChecker"
        Text = "CalendarChecker"
        CType(DGVSchedules, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DGVSchedules As DataGridView
    Friend WithEvents MnthC As MonthCalendar
End Class
