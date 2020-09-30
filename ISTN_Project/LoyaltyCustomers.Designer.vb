<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoyaltyCustomers
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.LoyaltyComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.dgvLCust = New System.Windows.Forms.DataGridView()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvLCust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.SearchButton)
        Me.Panel3.Controls.Add(Me.LoyaltyComboBox)
        Me.Panel3.Location = New System.Drawing.Point(52, 28)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(323, 41)
        Me.Panel3.TabIndex = 10
        '
        'SearchButton
        '
        Me.SearchButton.Enabled = False
        Me.SearchButton.Location = New System.Drawing.Point(241, 12)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(72, 26)
        Me.SearchButton.TabIndex = 1
        Me.SearchButton.Text = "&Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'LoyaltyComboBox
        '
        Me.LoyaltyComboBox.FormattingEnabled = True
        Me.LoyaltyComboBox.Location = New System.Drawing.Point(17, 12)
        Me.LoyaltyComboBox.Name = "LoyaltyComboBox"
        Me.LoyaltyComboBox.Size = New System.Drawing.Size(198, 21)
        Me.LoyaltyComboBox.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AddButton)
        Me.Panel2.Controls.Add(Me.EditButton)
        Me.Panel2.Location = New System.Drawing.Point(414, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(235, 43)
        Me.Panel2.TabIndex = 9
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(19, 9)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 30)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "&Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(128, 9)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 30)
        Me.EditButton.TabIndex = 2
        Me.EditButton.Text = "&Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'dgvLCust
        '
        Me.dgvLCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLCust.Location = New System.Drawing.Point(46, 85)
        Me.dgvLCust.Name = "dgvLCust"
        Me.dgvLCust.Size = New System.Drawing.Size(607, 332)
        Me.dgvLCust.TabIndex = 7
        '
        'LoyaltyCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ISTN_Project.My.Resources.Resources.background1
        Me.ClientSize = New System.Drawing.Size(705, 443)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvLCust)
        Me.Name = "LoyaltyCustomers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loyalty Customers"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvLCust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents LoyaltyComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents dgvLCust As System.Windows.Forms.DataGridView
End Class
