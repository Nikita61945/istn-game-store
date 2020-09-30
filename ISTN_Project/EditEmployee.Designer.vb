<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditEmployee
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
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.edtEmerName = New System.Windows.Forms.TextBox()
        Me.EmerContactNoText = New System.Windows.Forms.MaskedTextBox()
        Me.TellNoText = New System.Windows.Forms.MaskedTextBox()
        Me.edtBankDetails = New System.Windows.Forms.TextBox()
        Me.RateText = New System.Windows.Forms.MaskedTextBox()
        Me.JobComboBox = New System.Windows.Forms.ComboBox()
        Me.edtSurname = New System.Windows.Forms.TextBox()
        Me.edtName = New System.Windows.Forms.TextBox()
        Me.ActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.White
        Me.CancelButton.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(400, 369)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(115, 47)
        Me.CancelButton.TabIndex = 39
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.White
        Me.SaveButton.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(263, 369)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(115, 47)
        Me.SaveButton.TabIndex = 38
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'edtEmerName
        '
        Me.edtEmerName.Location = New System.Drawing.Point(573, 125)
        Me.edtEmerName.Name = "edtEmerName"
        Me.edtEmerName.Size = New System.Drawing.Size(169, 20)
        Me.edtEmerName.TabIndex = 29
        '
        'EmerContactNoText
        '
        Me.EmerContactNoText.Location = New System.Drawing.Point(573, 185)
        Me.EmerContactNoText.Mask = "(999) 000-0000"
        Me.EmerContactNoText.Name = "EmerContactNoText"
        Me.EmerContactNoText.Size = New System.Drawing.Size(120, 20)
        Me.EmerContactNoText.TabIndex = 28
        '
        'TellNoText
        '
        Me.TellNoText.Location = New System.Drawing.Point(573, 56)
        Me.TellNoText.Mask = "(999) 000-0000"
        Me.TellNoText.Name = "TellNoText"
        Me.TellNoText.Size = New System.Drawing.Size(120, 20)
        Me.TellNoText.TabIndex = 27
        '
        'edtBankDetails
        '
        Me.edtBankDetails.Location = New System.Drawing.Point(151, 300)
        Me.edtBankDetails.Multiline = True
        Me.edtBankDetails.Name = "edtBankDetails"
        Me.edtBankDetails.Size = New System.Drawing.Size(169, 20)
        Me.edtBankDetails.TabIndex = 26
        '
        'RateText
        '
        Me.RateText.Location = New System.Drawing.Point(151, 239)
        Me.RateText.Mask = "00.00"
        Me.RateText.Name = "RateText"
        Me.RateText.ReadOnly = True
        Me.RateText.Size = New System.Drawing.Size(100, 20)
        Me.RateText.TabIndex = 25
        '
        'JobComboBox
        '
        Me.JobComboBox.FormattingEnabled = True
        Me.JobComboBox.Items.AddRange(New Object() {"Manager", "Sales Rep"})
        Me.JobComboBox.Location = New System.Drawing.Point(151, 174)
        Me.JobComboBox.Name = "JobComboBox"
        Me.JobComboBox.Size = New System.Drawing.Size(121, 21)
        Me.JobComboBox.TabIndex = 24
        '
        'edtSurname
        '
        Me.edtSurname.Location = New System.Drawing.Point(151, 105)
        Me.edtSurname.Name = "edtSurname"
        Me.edtSurname.Size = New System.Drawing.Size(169, 20)
        Me.edtSurname.TabIndex = 23
        '
        'edtName
        '
        Me.edtName.Location = New System.Drawing.Point(151, 48)
        Me.edtName.Name = "edtName"
        Me.edtName.ReadOnly = True
        Me.edtName.Size = New System.Drawing.Size(169, 20)
        Me.edtName.TabIndex = 22
        '
        'ActiveCheckBox
        '
        Me.ActiveCheckBox.AutoSize = True
        Me.ActiveCheckBox.Location = New System.Drawing.Point(573, 245)
        Me.ActiveCheckBox.Name = "ActiveCheckBox"
        Me.ActiveCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.ActiveCheckBox.TabIndex = 41
        Me.ActiveCheckBox.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(20, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 28)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Name:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(20, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 28)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Surname:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(20, 167)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 28)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Job Type:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(20, 230)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 28)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Hourly Rate:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(379, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 28)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "Contact Number:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(341, 117)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(207, 28)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Emergency Contact Name:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(324, 176)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(224, 28)
        Me.Label16.TabIndex = 56
        Me.Label16.Text = "Emergency Contact Number:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(414, 239)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 28)
        Me.Label17.TabIndex = 57
        Me.Label17.Text = "Active:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 292)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 28)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Bank Number:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ISTN_Project.My.Resources.Resources.LogoAngryNerds
        Me.PictureBox2.Location = New System.Drawing.Point(676, 316)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 126)
        Me.PictureBox2.TabIndex = 59
        Me.PictureBox2.TabStop = False
        '
        'EditEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ISTN_Project.My.Resources.Resources.background1
        Me.ClientSize = New System.Drawing.Size(776, 443)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ActiveCheckBox)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.edtEmerName)
        Me.Controls.Add(Me.EmerContactNoText)
        Me.Controls.Add(Me.TellNoText)
        Me.Controls.Add(Me.edtBankDetails)
        Me.Controls.Add(Me.RateText)
        Me.Controls.Add(Me.JobComboBox)
        Me.Controls.Add(Me.edtSurname)
        Me.Controls.Add(Me.edtName)
        Me.Name = "EditEmployee"
        Me.Text = "Edit Employee"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents edtEmerName As System.Windows.Forms.TextBox
    Friend WithEvents EmerContactNoText As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TellNoText As System.Windows.Forms.MaskedTextBox
    Friend WithEvents edtBankDetails As System.Windows.Forms.TextBox
    Friend WithEvents RateText As System.Windows.Forms.MaskedTextBox
    Friend WithEvents JobComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents edtSurname As System.Windows.Forms.TextBox
    Friend WithEvents edtName As System.Windows.Forms.TextBox
    Friend WithEvents ActiveCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
