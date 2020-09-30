<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProduct
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
        Me.PriceText = New System.Windows.Forms.MaskedTextBox()
        Me.PlatformComboBox = New System.Windows.Forms.ComboBox()
        Me.Quatity = New System.Windows.Forms.NumericUpDown()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.Quatity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'edtName
        '
        Me.edtName.Location = New System.Drawing.Point(153, 72)
        Me.edtName.Name = "edtName"
        Me.edtName.Size = New System.Drawing.Size(200, 20)
        Me.edtName.TabIndex = 4
        '
        'PriceText
        '
        Me.PriceText.Location = New System.Drawing.Point(154, 133)
        Me.PriceText.Mask = " 000.00"
        Me.PriceText.Name = "PriceText"
        Me.PriceText.Size = New System.Drawing.Size(100, 20)
        Me.PriceText.TabIndex = 5
        '
        'PlatformComboBox
        '
        Me.PlatformComboBox.FormattingEnabled = True
        Me.PlatformComboBox.Items.AddRange(New Object() {"XBox", "PS4", "Nitendo"})
        Me.PlatformComboBox.Location = New System.Drawing.Point(153, 206)
        Me.PlatformComboBox.Name = "PlatformComboBox"
        Me.PlatformComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PlatformComboBox.TabIndex = 6
        '
        'Quatity
        '
        Me.Quatity.Location = New System.Drawing.Point(154, 272)
        Me.Quatity.Name = "Quatity"
        Me.Quatity.Size = New System.Drawing.Size(120, 20)
        Me.Quatity.TabIndex = 7
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.White
        Me.AddButton.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(263, 369)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(115, 47)
        Me.AddButton.TabIndex = 8
        Me.AddButton.Text = "&Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.White
        Me.CancelButton.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(401, 369)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(115, 47)
        Me.CancelButton.TabIndex = 9
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(37, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 28)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(37, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 28)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Price:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(37, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 28)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Platform:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(37, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 28)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Quantity:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ISTN_Project.My.Resources.Resources.LogoAngryNerds
        Me.PictureBox2.Location = New System.Drawing.Point(674, 315)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 126)
        Me.PictureBox2.TabIndex = 56
        Me.PictureBox2.TabStop = False
        '
        'AddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ISTN_Project.My.Resources.Resources.background1
        Me.ClientSize = New System.Drawing.Size(776, 443)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Quatity)
        Me.Controls.Add(Me.PlatformComboBox)
        Me.Controls.Add(Me.PriceText)
        Me.Controls.Add(Me.edtName)
        Me.Name = "AddProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AddProduct"
        CType(Me.Quatity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents edtName As System.Windows.Forms.TextBox
    Friend WithEvents PriceText As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PlatformComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Quatity As System.Windows.Forms.NumericUpDown
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
