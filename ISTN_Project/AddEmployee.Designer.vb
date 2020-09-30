<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEmployee
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
        Me.edtName = New System.Windows.Forms.TextBox()
        Me.edtSurname = New System.Windows.Forms.TextBox()
        Me.JobComboBox = New System.Windows.Forms.ComboBox()
        Me.RateText = New System.Windows.Forms.MaskedTextBox()
        Me.edtBankName = New System.Windows.Forms.TextBox()
        Me.TellNoText = New System.Windows.Forms.MaskedTextBox()
        Me.EmerContactNoText = New System.Windows.Forms.MaskedTextBox()
        Me.edtEmerName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.edtBankAccountNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'edtName
        '
        Me.edtName.Location = New System.Drawing.Point(199, 36)
        Me.edtName.Name = "edtName"
        Me.edtName.Size = New System.Drawing.Size(169, 20)
        Me.edtName.TabIndex = 0
        '
        'edtSurname
        '
        Me.edtSurname.Location = New System.Drawing.Point(199, 91)
        Me.edtSurname.Name = "edtSurname"
        Me.edtSurname.Size = New System.Drawing.Size(169, 20)
        Me.edtSurname.TabIndex = 1
        '
        'JobComboBox
        '
        Me.JobComboBox.FormattingEnabled = True
        Me.JobComboBox.Items.AddRange(New Object() {"Manager", "Sales Rep"})
        Me.JobComboBox.Location = New System.Drawing.Point(199, 155)
        Me.JobComboBox.Name = "JobComboBox"
        Me.JobComboBox.Size = New System.Drawing.Size(121, 21)
        Me.JobComboBox.TabIndex = 2
        '
        'RateText
        '
        Me.RateText.Location = New System.Drawing.Point(199, 211)
        Me.RateText.Mask = "00.00"
        Me.RateText.Name = "RateText"
        Me.RateText.Size = New System.Drawing.Size(100, 20)
        Me.RateText.TabIndex = 3
        '
        'edtBankName
        '
        Me.edtBankName.Location = New System.Drawing.Point(595, 27)
        Me.edtBankName.Multiline = True
        Me.edtBankName.Name = "edtBankName"
        Me.edtBankName.Size = New System.Drawing.Size(169, 20)
        Me.edtBankName.TabIndex = 5
        '
        'TellNoText
        '
        Me.TellNoText.Location = New System.Drawing.Point(595, 90)
        Me.TellNoText.Name = "TellNoText"
        Me.TellNoText.Size = New System.Drawing.Size(120, 20)
        Me.TellNoText.TabIndex = 6
        '
        'EmerContactNoText
        '
        Me.EmerContactNoText.Location = New System.Drawing.Point(595, 210)
        Me.EmerContactNoText.Name = "EmerContactNoText"
        Me.EmerContactNoText.Size = New System.Drawing.Size(120, 20)
        Me.EmerContactNoText.TabIndex = 8
        '
        'edtEmerName
        '
        Me.edtEmerName.Location = New System.Drawing.Point(595, 146)
        Me.edtEmerName.Name = "edtEmerName"
        Me.edtEmerName.Size = New System.Drawing.Size(169, 20)
        Me.edtEmerName.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(62, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 28)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(51, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 28)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Surname:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(53, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 28)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Job Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(43, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 28)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Hourly Rate:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(358, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(224, 28)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Emergency Contact Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(402, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 28)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Contact Number:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(417, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 28)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Bank Name:"
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.White
        Me.CancelButton.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(396, 364)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(115, 47)
        Me.CancelButton.TabIndex = 10
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.White
        Me.AddButton.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(263, 364)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(115, 47)
        Me.AddButton.TabIndex = 9
        Me.AddButton.Text = "&Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(181, 28)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Bank Account Number:"
        '
        'edtBankAccountNo
        '
        Me.edtBankAccountNo.Location = New System.Drawing.Point(199, 270)
        Me.edtBankAccountNo.Multiline = True
        Me.edtBankAccountNo.Name = "edtBankAccountNo"
        Me.edtBankAccountNo.Size = New System.Drawing.Size(169, 20)
        Me.edtBankAccountNo.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(358, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(207, 28)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Emergency Contact Name:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ISTN_Project.My.Resources.Resources.LogoAngryNerds
        Me.PictureBox2.Location = New System.Drawing.Point(673, 315)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 126)
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'AddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ISTN_Project.My.Resources.Resources.background1
        Me.ClientSize = New System.Drawing.Size(776, 443)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.edtBankAccountNo)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.edtEmerName)
        Me.Controls.Add(Me.EmerContactNoText)
        Me.Controls.Add(Me.TellNoText)
        Me.Controls.Add(Me.edtBankName)
        Me.Controls.Add(Me.RateText)
        Me.Controls.Add(Me.JobComboBox)
        Me.Controls.Add(Me.edtSurname)
        Me.Controls.Add(Me.edtName)
        Me.Name = "AddEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AddEmployee"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents edtName As System.Windows.Forms.TextBox
    Friend WithEvents edtSurname As System.Windows.Forms.TextBox
    Friend WithEvents JobComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RateText As System.Windows.Forms.MaskedTextBox
    Friend WithEvents edtBankName As System.Windows.Forms.TextBox
    Friend WithEvents TellNoText As System.Windows.Forms.MaskedTextBox
    Friend WithEvents EmerContactNoText As System.Windows.Forms.MaskedTextBox
    Friend WithEvents edtEmerName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents edtBankAccountNo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
