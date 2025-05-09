<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        GroupBox1 = New GroupBox()
        BtnBad = New Button()
        btnGood = New Button()
        dgvRecord = New DataGridView()
        GroupBox2 = New GroupBox()
        Label5 = New Label()
        txtRate = New TextBox()
        Label12 = New Label()
        txtBodyNumber = New TextBox()
        txtCapacity = New TextBox()
        Label11 = New Label()
        txtType = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        txtCColor = New TextBox()
        txtCar = New TextBox()
        txtPlateNumber = New TextBox()
        TxtCarID = New TextBox()
        dgvCars = New DataGridView()
        btnAdd = New Button()
        GroupBox1.SuspendLayout()
        CType(dgvRecord, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(dgvCars, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(BtnBad)
        GroupBox1.Controls.Add(btnGood)
        GroupBox1.Controls.Add(dgvRecord)
        GroupBox1.Location = New Point(14, 8)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(327, 567)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Record"
        ' 
        ' BtnBad
        ' 
        BtnBad.Location = New Point(223, 528)
        BtnBad.Margin = New Padding(3, 4, 3, 4)
        BtnBad.Name = "BtnBad"
        BtnBad.Size = New Size(97, 31)
        BtnBad.TabIndex = 2
        BtnBad.Text = "Record: Bad"
        BtnBad.UseVisualStyleBackColor = True
        ' 
        ' btnGood
        ' 
        btnGood.Location = New Point(7, 528)
        btnGood.Margin = New Padding(3, 4, 3, 4)
        btnGood.Name = "btnGood"
        btnGood.Size = New Size(127, 31)
        btnGood.TabIndex = 1
        btnGood.Text = "Record: Good"
        btnGood.UseVisualStyleBackColor = True
        ' 
        ' dgvRecord
        ' 
        dgvRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecord.Location = New Point(7, 29)
        dgvRecord.Margin = New Padding(3, 4, 3, 4)
        dgvRecord.Name = "dgvRecord"
        dgvRecord.RowHeadersWidth = 51
        dgvRecord.Size = New Size(313, 447)
        dgvRecord.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnAdd)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(txtRate)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(txtBodyNumber)
        GroupBox2.Controls.Add(txtCapacity)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(txtType)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(txtCColor)
        GroupBox2.Controls.Add(txtCar)
        GroupBox2.Controls.Add(txtPlateNumber)
        GroupBox2.Controls.Add(TxtCarID)
        GroupBox2.Controls.Add(dgvCars)
        GroupBox2.Location = New Point(347, 8)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.Size = New Size(1036, 576)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Car List"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(624, 489)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 20)
        Label5.TabIndex = 48
        Label5.Text = "Pay Rate:"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtRate
        ' 
        txtRate.Location = New Point(701, 485)
        txtRate.Multiline = True
        txtRate.Name = "txtRate"
        txtRate.Size = New Size(127, 29)
        txtRate.TabIndex = 47
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(591, 447)
        Label12.Name = "Label12"
        Label12.Size = New Size(104, 20)
        Label12.TabIndex = 46
        Label12.Text = "Body Number:"
        ' 
        ' txtBodyNumber
        ' 
        txtBodyNumber.Location = New Point(701, 439)
        txtBodyNumber.Multiline = True
        txtBodyNumber.Name = "txtBodyNumber"
        txtBodyNumber.Size = New Size(127, 33)
        txtBodyNumber.TabIndex = 45
        ' 
        ' txtCapacity
        ' 
        txtCapacity.Location = New Point(701, 521)
        txtCapacity.Multiline = True
        txtCapacity.Name = "txtCapacity"
        txtCapacity.Size = New Size(90, 33)
        txtCapacity.TabIndex = 41
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(623, 526)
        Label11.Name = "Label11"
        Label11.Size = New Size(69, 20)
        Label11.TabIndex = 44
        Label11.Text = "Capacity:"
        ' 
        ' txtType
        ' 
        txtType.Location = New Point(285, 525)
        txtType.Multiline = True
        txtType.Name = "txtType"
        txtType.Size = New Size(90, 33)
        txtType.TabIndex = 39
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(230, 533)
        Label10.Name = "Label10"
        Label10.Size = New Size(43, 20)
        Label10.TabIndex = 43
        Label10.Text = "Type:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(230, 494)
        Label9.Name = "Label9"
        Label9.Size = New Size(48, 20)
        Label9.TabIndex = 42
        Label9.Text = "Color:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(592, 409)
        Label8.Name = "Label8"
        Label8.Size = New Size(103, 20)
        Label8.TabIndex = 40
        Label8.Text = "Plate Number:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(230, 451)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 20)
        Label4.TabIndex = 36
        Label4.Text = "Car ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(234, 412)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 20)
        Label2.TabIndex = 35
        Label2.Text = "Car:"
        ' 
        ' txtCColor
        ' 
        txtCColor.Location = New Point(285, 487)
        txtCColor.Multiline = True
        txtCColor.Name = "txtCColor"
        txtCColor.Size = New Size(90, 33)
        txtCColor.TabIndex = 38
        ' 
        ' txtCar
        ' 
        txtCar.Location = New Point(285, 409)
        txtCar.Margin = New Padding(3, 4, 3, 4)
        txtCar.Name = "txtCar"
        txtCar.Size = New Size(228, 27)
        txtCar.TabIndex = 34
        ' 
        ' txtPlateNumber
        ' 
        txtPlateNumber.Location = New Point(701, 405)
        txtPlateNumber.Multiline = True
        txtPlateNumber.Name = "txtPlateNumber"
        txtPlateNumber.Size = New Size(127, 29)
        txtPlateNumber.TabIndex = 37
        ' 
        ' TxtCarID
        ' 
        TxtCarID.Location = New Point(285, 447)
        TxtCarID.Margin = New Padding(3, 4, 3, 4)
        TxtCarID.Name = "TxtCarID"
        TxtCarID.Size = New Size(228, 27)
        TxtCarID.TabIndex = 33
        ' 
        ' dgvCars
        ' 
        dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCars.Location = New Point(7, 29)
        dgvCars.Margin = New Padding(3, 4, 3, 4)
        dgvCars.Name = "dgvCars"
        dgvCars.RowHeadersWidth = 51
        dgvCars.Size = New Size(1023, 369)
        dgvCars.TabIndex = 3
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(7, 412)
        btnAdd.Margin = New Padding(3, 4, 3, 4)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(208, 155)
        btnAdd.TabIndex = 3
        btnAdd.Text = "Add Car"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1395, 600)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "AdminForm"
        Text = "AdminForm"
        GroupBox1.ResumeLayout(False)
        CType(dgvRecord, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(dgvCars, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnBad As Button
    Friend WithEvents btnGood As Button
    Friend WithEvents dgvRecord As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvCars As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBodyNumber As TextBox
    Friend WithEvents txtCapacity As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtType As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCColor As TextBox
    Friend WithEvents txtCar As TextBox
    Friend WithEvents txtPlateNumber As TextBox
    Friend WithEvents TxtCarID As TextBox
    Friend WithEvents btnAdd As Button
End Class
