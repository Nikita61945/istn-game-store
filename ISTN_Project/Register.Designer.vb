<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.dtpRegister = New System.Windows.Forms.DateTimePicker()
        Me.RecordButton = New System.Windows.Forms.Button()
        Me.dtpTimeIn = New System.Windows.Forms.DateTimePicker()
        Me.dtpTimeOut = New System.Windows.Forms.DateTimePicker()
        Me.CancelButton1 = New System.Windows.Forms.Button()
        Me.ENameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpRegister
        '
        Me.dtpRegister.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegister.Location = New System.Drawing.Point(208, 118)
        Me.dtpRegister.Name = "dtpRegister"
        Me.dtpRegister.Size = New System.Drawing.Size(200, 20)
        Me.dtpRegister.TabIndex = 2
        '
        'RecordButton
        '
        Me.RecordButton.BackColor = System.Drawing.Color.White
        Me.RecordButton.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecordButton.Location = New System.Drawing.Point(272, 369)
        Me.RecordButton.Name = "RecordButton"
        Me.RecordButton.Size = New System.Drawing.Size(115, 47)
        Me.RecordButton.TabIndex = 4
        Me.RecordButton.Text = "&Record"
        Me.RecordButton.UseVisualStyleBackColor = False
        '
        'dtpTimeIn
        '
        Me.dtpTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTimeIn.Location = New System.Drawing.Point(208, 179)
        Me.dtpTimeIn.Name = "dtpTimeIn"
        Me.dtpTimeIn.Size = New System.Drawing.Size(168, 20)
        Me.dtpTimeIn.TabIndex = 6
        '
        'dtpTimeOut
        '
        Me.dtpTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTimeOut.Location = New System.Drawing.Point(208, 243)
        Me.dtpTimeOut.Name = "dtpTimeOut"
        Me.dtpTimeOut.Size = New System.Drawing.Size(168, 20)
        Me.dtpTimeOut.TabIndex = 7
        '
        'CancelButton1
        '
        Me.CancelButton1.BackColor = System.Drawing.Color.White
        Me.CancelButton1.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton1.Location = New System.Drawing.Point(409, 369)
        Me.CancelButton1.Name = "CancelButton1"
        Me.CancelButton1.Size = New System.Drawing.Size(115, 47)
        Me.CancelButton1.TabIndex = 8
        Me.CancelButton1.Text = "&Cancel"
        Me.CancelButton1.UseVisualStyleBackColor = False
        '
        'ENameComboBox
        '
        Me.ENameComboBox.FormattingEnabled = True
        Me.ENameComboBox.Location = New System.Drawing.Point(208, 47)
        Me.ENameComboBox.Name = "ENameComboBox"
        Me.ENameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ENameComboBox.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(36, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 28)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Employee Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(36, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 28)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(36, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 28)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Time In:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(36, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 28)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Time Out:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ISTN_Project.My.Resources.Resources.LogoAngryNerds
        Me.PictureBox2.Location = New System.Drawing.Point(677, 317)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 126)
        Me.PictureBox2.TabIndex = 75
        Me.PictureBox2.TabStop = False
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ISTN_Project.My.Resources.Resources.background1
        Me.ClientSize = New System.Drawing.Size(776, 443)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ENameComboBox)
        Me.Controls.Add(Me.CancelButton1)
        Me.Controls.Add(Me.dtpTimeOut)
        Me.Controls.Add(Me.dtpTimeIn)
        Me.Controls.Add(Me.RecordButton)
        Me.Controls.Add(Me.dtpRegister)
        Me.Name = "Register"
        Me.Text = "Register"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpRegister As System.Windows.Forms.DateTimePicker
    Friend WithEvents RecordButton As System.Windows.Forms.Button
    Friend WithEvents dtpTimeIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTimeOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents CancelButton1 As System.Windows.Forms.Button
    Friend WithEvents ENameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
