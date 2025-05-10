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
        btnAdd = New Button()
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
        GroupBox1.Location = New Point(12, 6)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(286, 482)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Record"
        ' 
        ' BtnBad
        ' 
        BtnBad.Location = New Point(88, 409)
        BtnBad.Name = "BtnBad"
        BtnBad.Size = New Size(111, 23)
        BtnBad.TabIndex = 2
        BtnBad.Text = "Record: Bad"
        BtnBad.UseVisualStyleBackColor = True
        ' 
        ' btnGood
        ' 
        btnGood.Location = New Point(88, 380)
        btnGood.Name = "btnGood"
        btnGood.Size = New Size(111, 23)
        btnGood.TabIndex = 1
        btnGood.Text = "Record: Good"
        btnGood.UseVisualStyleBackColor = True
        ' 
        ' dgvRecord
        ' 
        dgvRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecord.Location = New Point(6, 22)
        dgvRecord.MultiSelect = False
        dgvRecord.Name = "dgvRecord"
        dgvRecord.RowHeadersWidth = 51
        dgvRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRecord.Size = New Size(274, 308)
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
        GroupBox2.Location = New Point(304, 6)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(854, 482)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Car List"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(6, 351)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(182, 116)
        btnAdd.TabIndex = 3
        btnAdd.Text = "Add Car"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(571, 416)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 15)
        Label5.TabIndex = 48
        Label5.Text = "Pay Rate:"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtRate
        ' 
        txtRate.Location = New Point(639, 412)
        txtRate.Margin = New Padding(3, 2, 3, 2)
        txtRate.Multiline = True
        txtRate.Name = "txtRate"
        txtRate.Size = New Size(112, 23)
        txtRate.TabIndex = 47
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(542, 384)
        Label12.Name = "Label12"
        Label12.Size = New Size(84, 15)
        Label12.TabIndex = 46
        Label12.Text = "Body Number:"
        ' 
        ' txtBodyNumber
        ' 
        txtBodyNumber.Location = New Point(639, 378)
        txtBodyNumber.Margin = New Padding(3, 2, 3, 2)
        txtBodyNumber.Multiline = True
        txtBodyNumber.Name = "txtBodyNumber"
        txtBodyNumber.Size = New Size(112, 26)
        txtBodyNumber.TabIndex = 45
        ' 
        ' txtCapacity
        ' 
        txtCapacity.Location = New Point(639, 440)
        txtCapacity.Margin = New Padding(3, 2, 3, 2)
        txtCapacity.Multiline = True
        txtCapacity.Name = "txtCapacity"
        txtCapacity.Size = New Size(79, 26)
        txtCapacity.TabIndex = 41
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(570, 443)
        Label11.Name = "Label11"
        Label11.Size = New Size(56, 15)
        Label11.TabIndex = 44
        Label11.Text = "Capacity:"
        ' 
        ' txtType
        ' 
        txtType.Location = New Point(276, 441)
        txtType.Margin = New Padding(3, 2, 3, 2)
        txtType.Multiline = True
        txtType.Name = "txtType"
        txtType.Size = New Size(79, 26)
        txtType.TabIndex = 39
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(228, 447)
        Label10.Name = "Label10"
        Label10.Size = New Size(34, 15)
        Label10.TabIndex = 43
        Label10.Text = "Type:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(228, 418)
        Label9.Name = "Label9"
        Label9.Size = New Size(39, 15)
        Label9.TabIndex = 42
        Label9.Text = "Color:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(543, 356)
        Label8.Name = "Label8"
        Label8.Size = New Size(83, 15)
        Label8.TabIndex = 40
        Label8.Text = "Plate Number:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(228, 386)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 15)
        Label4.TabIndex = 36
        Label4.Text = "Car ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(231, 356)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 15)
        Label2.TabIndex = 35
        Label2.Text = "Car:"
        ' 
        ' txtCColor
        ' 
        txtCColor.Location = New Point(276, 412)
        txtCColor.Margin = New Padding(3, 2, 3, 2)
        txtCColor.Multiline = True
        txtCColor.Name = "txtCColor"
        txtCColor.Size = New Size(79, 26)
        txtCColor.TabIndex = 38
        ' 
        ' txtCar
        ' 
        txtCar.Location = New Point(276, 354)
        txtCar.Name = "txtCar"
        txtCar.Size = New Size(200, 23)
        txtCar.TabIndex = 34
        ' 
        ' txtPlateNumber
        ' 
        txtPlateNumber.Location = New Point(639, 352)
        txtPlateNumber.Margin = New Padding(3, 2, 3, 2)
        txtPlateNumber.Multiline = True
        txtPlateNumber.Name = "txtPlateNumber"
        txtPlateNumber.Size = New Size(112, 23)
        txtPlateNumber.TabIndex = 37
        ' 
        ' TxtCarID
        ' 
        TxtCarID.Location = New Point(276, 382)
        TxtCarID.Name = "TxtCarID"
        TxtCarID.Size = New Size(200, 23)
        TxtCarID.TabIndex = 33
        ' 
        ' dgvCars
        ' 
        dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCars.Location = New Point(6, 22)
        dgvCars.MultiSelect = False
        dgvCars.Name = "dgvCars"
        dgvCars.RowHeadersWidth = 51
        dgvCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCars.Size = New Size(840, 308)
        dgvCars.TabIndex = 3
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1160, 518)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
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
