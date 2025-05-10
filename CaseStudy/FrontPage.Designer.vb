<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrontPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrontPage))
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(941, 36)
        Button1.Name = "Button1"
        Button1.Size = New Size(169, 61)
        Button1.TabIndex = 0
        Button1.Text = "Log-In or Sign Up"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(66, 128)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1044, 568)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' FrontPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1154, 746)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Name = "FrontPage"
        Text = "FrontPage"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
