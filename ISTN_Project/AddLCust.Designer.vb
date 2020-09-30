<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddLCust
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
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.edtEmail = New System.Windows.Forms.TextBox()
        Me.TellNoText = New System.Windows.Forms.MaskedTextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.edtAddress1 = New System.Windows.Forms.TextBox()
        Me.edtAddress2 = New System.Windows.Forms.TextBox()
        Me.edtAddress3 = New System.Windows.Forms.TextBox()
        Me.cbxGender = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dtpLCust = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'edtName
        '
        Me.edtName.Location = New System.Drawing.Point(185, 60)
        Me.edtName.Name = "edtName"
        Me.edtName.Size = New System.Drawing.Size(169, 20)
        Me.edtName.TabIndex = 22
        '
        'edtSurname
        '
        Me.edtSurname.Location = New System.Drawing.Point(185, 120)
        Me.edtSurname.Name = "edtSurname"
        Me.edtSurname.Size = New System.Drawing.Size(169, 20)
        Me.edtSurname.TabIndex = 23
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.White
        Me.CancelButton.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(396, 371)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(115, 47)
        Me.CancelButton.TabIndex = 39
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'edtEmail
        '
        Me.edtEmail.Location = New System.Drawing.Point(185, 243)
        Me.edtEmail.Multiline = True
        Me.edtEmail.Name = "edtEmail"
        Me.edtEmail.Size = New System.Drawing.Size(169, 20)
        Me.edtEmail.TabIndex = 26
        '
        'TellNoText
        '
        Me.TellNoText.Location = New System.Drawing.Point(185, 179)
        Me.TellNoText.Name = "TellNoText"
        Me.TellNoText.Size = New System.Drawing.Size(120, 20)
        Me.TellNoText.TabIndex = 27
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.White
        Me.AddButton.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(261, 371)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(115, 47)
        Me.AddButton.TabIndex = 38
        Me.AddButton.Text = "&Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'edtAddress1
        '
        Me.edtAddress1.Location = New System.Drawing.Point(548, 59)
        Me.edtAddress1.Multiline = True
        Me.edtAddress1.Name = "edtAddress1"
        Me.edtAddress1.Size = New System.Drawing.Size(169, 20)
        Me.edtAddress1.TabIndex = 40
        '
        'edtAddress2
        '
        Me.edtAddress2.Location = New System.Drawing.Point(548, 96)
        Me.edtAddress2.Multiline = True
        Me.edtAddress2.Name = "edtAddress2"
        Me.edtAddress2.Size = New System.Drawing.Size(169, 20)
        Me.edtAddress2.TabIndex = 41
        '
        'edtAddress3
        '
        Me.edtAddress3.Location = New System.Drawing.Point(548, 132)
        Me.edtAddress3.Multiline = True
        Me.edtAddress3.Name = "edtAddress3"
        Me.edtAddress3.Size = New System.Drawing.Size(169, 20)
        Me.edtAddress3.TabIndex = 42
        '
        'cbxGender
        '
        Me.cbxGender.FormattingEnabled = True
        Me.cbxGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.cbxGender.Location = New System.Drawing.Point(548, 250)
        Me.cbxGender.Name = "cbxGender"
        Me.cbxGender.Size = New System.Drawing.Size(121, 21)
        Me.cbxGender.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(41, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 28)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(41, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 28)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Surname:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(41, 171)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 28)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Contact Number:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(41, 234)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 28)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Email:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(413, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 28)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Address:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(413, 180)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 28)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Date of Birth:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(413, 243)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 28)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "Gender:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ISTN_Project.My.Resources.Resources.LogoAngryNerds
        Me.PictureBox2.Location = New System.Drawing.Point(676, 317)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 126)
        Me.PictureBox2.TabIndex = 55
        Me.PictureBox2.TabStop = False
        '
        'dtpLCust
        '
        Me.dtpLCust.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLCust.Location = New System.Drawing.Point(548, 188)
        Me.dtpLCust.Name = "dtpLCust"
        Me.dtpLCust.Size = New System.Drawing.Size(200, 20)
        Me.dtpLCust.TabIndex = 56
        Me.dtpLCust.Value = New Date(1998, 4, 25, 0, 0, 0, 0)
        '
        'AddLCust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ISTN_Project.My.Resources.Resources.background1
        Me.ClientSize = New System.Drawing.Size(776, 443)
        Me.Controls.Add(Me.dtpLCust)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbxGender)
        Me.Controls.Add(Me.edtAddress3)
        Me.Controls.Add(Me.edtAddress2)
        Me.Controls.Add(Me.edtAddress1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.TellNoText)
        Me.Controls.Add(Me.edtEmail)
        Me.Controls.Add(Me.edtSurname)
        Me.Controls.Add(Me.edtName)
        Me.Name = "AddLCust"
        Me.Text = "Add Loyalty Customer"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents edtName As System.Windows.Forms.TextBox
    Friend WithEvents edtSurname As System.Windows.Forms.TextBox
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents edtEmail As System.Windows.Forms.TextBox
    Friend WithEvents TellNoText As System.Windows.Forms.MaskedTextBox
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents edtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents edtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents edtAddress3 As System.Windows.Forms.TextBox
    Friend WithEvents cbxGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents dtpLCust As System.Windows.Forms.DateTimePicker
End Class
