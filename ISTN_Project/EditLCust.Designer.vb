<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditLCust
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
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.edtAddress3 = New System.Windows.Forms.TextBox()
        Me.edtAddress2 = New System.Windows.Forms.TextBox()
        Me.edtAddress1 = New System.Windows.Forms.TextBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.TellNoText = New System.Windows.Forms.MaskedTextBox()
        Me.edtEmail = New System.Windows.Forms.TextBox()
        Me.edtSurname = New System.Windows.Forms.TextBox()
        Me.edtName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GenderComboBox
        '
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.GenderComboBox.Location = New System.Drawing.Point(566, 268)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(121, 21)
        Me.GenderComboBox.TabIndex = 65
        '
        'edtAddress3
        '
        Me.edtAddress3.Location = New System.Drawing.Point(566, 125)
        Me.edtAddress3.Multiline = True
        Me.edtAddress3.Name = "edtAddress3"
        Me.edtAddress3.Size = New System.Drawing.Size(169, 20)
        Me.edtAddress3.TabIndex = 60
        '
        'edtAddress2
        '
        Me.edtAddress2.Location = New System.Drawing.Point(566, 88)
        Me.edtAddress2.Multiline = True
        Me.edtAddress2.Name = "edtAddress2"
        Me.edtAddress2.Size = New System.Drawing.Size(169, 20)
        Me.edtAddress2.TabIndex = 59
        '
        'edtAddress1
        '
        Me.edtAddress1.Location = New System.Drawing.Point(566, 49)
        Me.edtAddress1.Multiline = True
        Me.edtAddress1.Name = "edtAddress1"
        Me.edtAddress1.Size = New System.Drawing.Size(169, 20)
        Me.edtAddress1.TabIndex = 58
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.White
        Me.CancelButton.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(407, 374)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(115, 47)
        Me.CancelButton.TabIndex = 57
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.White
        Me.SaveButton.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(264, 374)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(115, 47)
        Me.SaveButton.TabIndex = 56
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'TellNoText
        '
        Me.TellNoText.Location = New System.Drawing.Point(210, 195)
        Me.TellNoText.Name = "TellNoText"
        Me.TellNoText.Size = New System.Drawing.Size(120, 20)
        Me.TellNoText.TabIndex = 51
        '
        'edtEmail
        '
        Me.edtEmail.Location = New System.Drawing.Point(210, 270)
        Me.edtEmail.Multiline = True
        Me.edtEmail.Name = "edtEmail"
        Me.edtEmail.Size = New System.Drawing.Size(169, 20)
        Me.edtEmail.TabIndex = 50
        '
        'edtSurname
        '
        Me.edtSurname.Location = New System.Drawing.Point(210, 125)
        Me.edtSurname.Name = "edtSurname"
        Me.edtSurname.Size = New System.Drawing.Size(169, 20)
        Me.edtSurname.TabIndex = 49
        '
        'edtName
        '
        Me.edtName.Location = New System.Drawing.Point(210, 50)
        Me.edtName.Name = "edtName"
        Me.edtName.Size = New System.Drawing.Size(169, 20)
        Me.edtName.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(41, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 28)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(41, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 28)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Contact Number:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(434, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 28)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Gender:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(434, 186)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 28)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "Date of Birth:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(434, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 28)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "Address:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(41, 268)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 28)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(41, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 28)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Surname:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ISTN_Project.My.Resources.Resources.LogoAngryNerds
        Me.PictureBox2.Location = New System.Drawing.Point(675, 317)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 126)
        Me.PictureBox2.TabIndex = 73
        Me.PictureBox2.TabStop = False
        '
        'dtpDOB
        '
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDOB.Location = New System.Drawing.Point(566, 192)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(200, 20)
        Me.dtpDOB.TabIndex = 74
        '
        'EditLCust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.ISTN_Project.My.Resources.Resources.background1
        Me.ClientSize = New System.Drawing.Size(776, 443)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Me.edtAddress3)
        Me.Controls.Add(Me.edtAddress2)
        Me.Controls.Add(Me.edtAddress1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.TellNoText)
        Me.Controls.Add(Me.edtEmail)
        Me.Controls.Add(Me.edtSurname)
        Me.Controls.Add(Me.edtName)
        Me.Name = "EditLCust"
        Me.Text = "Edit Loyalty Customer"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents edtAddress3 As System.Windows.Forms.TextBox
    Friend WithEvents edtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents edtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents TellNoText As System.Windows.Forms.MaskedTextBox
    Friend WithEvents edtEmail As System.Windows.Forms.TextBox
    Friend WithEvents edtSurname As System.Windows.Forms.TextBox
    Friend WithEvents edtName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
End Class
