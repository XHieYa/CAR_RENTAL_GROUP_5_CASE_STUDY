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
        Label14 = New Label()
        Label15 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Footlight MT Light", 9F)
        Label14.ForeColor = Color.White
        Label14.Location = New Point(2, 671)
        Label14.Name = "Label14"
        Label14.Size = New Size(155, 15)
        Label14.TabIndex = 14
        Label14.Text = "wheelaway@gmail.com"
        Label14.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Footlight MT Light", 9F)
        Label15.ForeColor = Color.White
        Label15.Location = New Point(2, 657)
        Label15.Name = "Label15"
        Label15.Size = New Size(114, 15)
        Label15.TabIndex = 13
        Label15.Text = "WheelAway, Inc."
        Label15.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(149, 593)
        Label1.Name = "Label1"
        Label1.Size = New Size(1044, 68)
        Label1.TabIndex = 26
        Label1.Text = "Unleash your wanderlust. We provide the wheels; you create the memories. " & vbCrLf & "Explore the world, one adventure after another."
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1192, 4)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(131, 108)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 27
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(315, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(717, 95)
        Label2.TabIndex = 28
        Label2.Text = "Wheel-Away, INC"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(599, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(182, 34)
        Label3.TabIndex = 29
        Label3.Text = "Welcome to"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(541, 124)
        Label4.Name = "Label4"
        Label4.Size = New Size(307, 34)
        Label4.TabIndex = 30
        Label4.Text = "Get ready to explore!"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.FlatStyle = FlatStyle.System
        Button1.Font = New Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1152, 543)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 47)
        Button1.TabIndex = 31
        Button1.Text = "➠Start"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' FrontPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1326, 690)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Name = "FrontPage"
        Text = "HomePage"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
