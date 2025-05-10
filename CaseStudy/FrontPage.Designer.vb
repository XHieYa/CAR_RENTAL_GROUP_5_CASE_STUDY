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
        Panel1 = New Panel()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        PictureBox2 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.Window
        Button1.Location = New Point(0, 360)
        Button1.Name = "Button1"
        Button1.Size = New Size(350, 61)
        Button1.TabIndex = 0
        Button1.Text = "Dashboard"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(350, 737)
        Panel1.TabIndex = 2
        ' 
        ' Button4
        ' 
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = SystemColors.Window
        Button4.Location = New Point(0, 635)
        Button4.Name = "Button4"
        Button4.Size = New Size(350, 61)
        Button4.TabIndex = 5
        Button4.Text = "Log-Out"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.Window
        Button3.Location = New Point(0, 543)
        Button3.Name = "Button3"
        Button3.Size = New Size(350, 61)
        Button3.TabIndex = 4
        Button3.Text = "Payment"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.Window
        Button2.Location = New Point(0, 451)
        Button2.Name = "Button2"
        Button2.Size = New Size(350, 61)
        Button2.TabIndex = 4
        Button2.Text = "Booking"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(350, 357)
        Panel2.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(25, 27)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(296, 297)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(350, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(599, 65)
        Panel3.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Location = New Point(350, 65)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(599, 672)
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' FrontPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(949, 737)
        Controls.Add(PictureBox2)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Name = "FrontPage"
        Text = "FrontPage"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
