<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewSale
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.edtLoyaltyNo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.ProductsComboBox = New System.Windows.Forms.ComboBox()
        Me.dgvSales = New System.Windows.Forms.DataGridView()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.CancelSaleButton = New System.Windows.Forms.Button()
        Me.RemoveItemButton = New System.Windows.Forms.Button()
        Me.NewSaleButton = New System.Windows.Forms.Button()
        Me.pnlPrice = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LoyaltyDiscText = New System.Windows.Forms.MaskedTextBox()
        Me.EndSaleButton = New System.Windows.Forms.Button()
        Me.TotalText = New System.Windows.Forms.MaskedTextBox()
        Me.TotalinVATText = New System.Windows.Forms.MaskedTextBox()
        Me.VATText = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.pointTT = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControl.SuspendLayout()
        Me.pnlPrice.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(29, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Loyalty No"
        '
        'edtLoyaltyNo
        '
        Me.edtLoyaltyNo.Enabled = False
        Me.edtLoyaltyNo.Location = New System.Drawing.Point(117, 48)
        Me.edtLoyaltyNo.Name = "edtLoyaltyNo"
        Me.edtLoyaltyNo.Size = New System.Drawing.Size(100, 20)
        Me.edtLoyaltyNo.TabIndex = 1
        Me.edtLoyaltyNo.Text = "0"
        Me.edtLoyaltyNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AddButton)
        Me.Panel1.Controls.Add(Me.ProductsComboBox)
        Me.Panel1.Location = New System.Drawing.Point(324, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(342, 49)
        Me.Panel1.TabIndex = 2
        '
        'AddButton
        '
        Me.AddButton.Enabled = False
        Me.AddButton.Location = New System.Drawing.Point(241, 12)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(72, 26)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "&Add Item"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'ProductsComboBox
        '
        Me.ProductsComboBox.Enabled = False
        Me.ProductsComboBox.FormattingEnabled = True
        Me.ProductsComboBox.Location = New System.Drawing.Point(19, 14)
        Me.ProductsComboBox.Name = "ProductsComboBox"
        Me.ProductsComboBox.Size = New System.Drawing.Size(198, 21)
        Me.ProductsComboBox.TabIndex = 0
        '
        'dgvSales
        '
        Me.dgvSales.AllowUserToAddRows = False
        Me.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSales.Location = New System.Drawing.Point(27, 101)
        Me.dgvSales.Name = "dgvSales"
        Me.dgvSales.ReadOnly = True
        Me.dgvSales.Size = New System.Drawing.Size(639, 238)
        Me.dgvSales.TabIndex = 3
        '
        'pnlControl
        '
        Me.pnlControl.BackColor = System.Drawing.SystemColors.Control
        Me.pnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlControl.Controls.Add(Me.CancelSaleButton)
        Me.pnlControl.Controls.Add(Me.RemoveItemButton)
        Me.pnlControl.Controls.Add(Me.NewSaleButton)
        Me.pnlControl.Location = New System.Drawing.Point(33, 366)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(155, 142)
        Me.pnlControl.TabIndex = 4
        '
        'CancelSaleButton
        '
        Me.CancelSaleButton.Enabled = False
        Me.CancelSaleButton.Location = New System.Drawing.Point(37, 98)
        Me.CancelSaleButton.Name = "CancelSaleButton"
        Me.CancelSaleButton.Size = New System.Drawing.Size(75, 35)
        Me.CancelSaleButton.TabIndex = 2
        Me.CancelSaleButton.Text = "&Cancel Sale"
        Me.CancelSaleButton.UseVisualStyleBackColor = True
        '
        'RemoveItemButton
        '
        Me.RemoveItemButton.Enabled = False
        Me.RemoveItemButton.Location = New System.Drawing.Point(37, 48)
        Me.RemoveItemButton.Name = "RemoveItemButton"
        Me.RemoveItemButton.Size = New System.Drawing.Size(75, 44)
        Me.RemoveItemButton.TabIndex = 1
        Me.RemoveItemButton.Text = "&Remove Item"
        Me.RemoveItemButton.UseVisualStyleBackColor = True
        '
        'NewSaleButton
        '
        Me.NewSaleButton.Location = New System.Drawing.Point(37, 5)
        Me.NewSaleButton.Name = "NewSaleButton"
        Me.NewSaleButton.Size = New System.Drawing.Size(75, 35)
        Me.NewSaleButton.TabIndex = 0
        Me.NewSaleButton.Text = "&New Sale"
        Me.NewSaleButton.UseVisualStyleBackColor = True
        '
        'pnlPrice
        '
        Me.pnlPrice.Controls.Add(Me.Label4)
        Me.pnlPrice.Controls.Add(Me.LoyaltyDiscText)
        Me.pnlPrice.Controls.Add(Me.EndSaleButton)
        Me.pnlPrice.Controls.Add(Me.TotalText)
        Me.pnlPrice.Controls.Add(Me.TotalinVATText)
        Me.pnlPrice.Controls.Add(Me.VATText)
        Me.pnlPrice.Controls.Add(Me.Label3)
        Me.pnlPrice.Controls.Add(Me.Label2)
        Me.pnlPrice.Controls.Add(Me.lblTotal)
        Me.pnlPrice.Location = New System.Drawing.Point(486, 366)
        Me.pnlPrice.Name = "pnlPrice"
        Me.pnlPrice.Size = New System.Drawing.Size(180, 182)
        Me.pnlPrice.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 26)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Loyalty " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Discount"
        '
        'LoyaltyDiscText
        '
        Me.LoyaltyDiscText.Enabled = False
        Me.LoyaltyDiscText.Location = New System.Drawing.Point(70, 79)
        Me.LoyaltyDiscText.Mask = "R 000.00"
        Me.LoyaltyDiscText.Name = "LoyaltyDiscText"
        Me.LoyaltyDiscText.ReadOnly = True
        Me.LoyaltyDiscText.Size = New System.Drawing.Size(100, 20)
        Me.LoyaltyDiscText.TabIndex = 7
        '
        'EndSaleButton
        '
        Me.EndSaleButton.Enabled = False
        Me.EndSaleButton.Location = New System.Drawing.Point(93, 140)
        Me.EndSaleButton.Name = "EndSaleButton"
        Me.EndSaleButton.Size = New System.Drawing.Size(75, 34)
        Me.EndSaleButton.TabIndex = 6
        Me.EndSaleButton.Text = "&End Sale"
        Me.EndSaleButton.UseVisualStyleBackColor = True
        '
        'TotalText
        '
        Me.TotalText.Location = New System.Drawing.Point(70, 20)
        Me.TotalText.Mask = "R 000.00"
        Me.TotalText.Name = "TotalText"
        Me.TotalText.ReadOnly = True
        Me.TotalText.Size = New System.Drawing.Size(100, 20)
        Me.TotalText.TabIndex = 6
        '
        'TotalinVATText
        '
        Me.TotalinVATText.Location = New System.Drawing.Point(70, 111)
        Me.TotalinVATText.Mask = "R 000.00"
        Me.TotalinVATText.Name = "TotalinVATText"
        Me.TotalinVATText.ReadOnly = True
        Me.TotalinVATText.Size = New System.Drawing.Size(100, 20)
        Me.TotalinVATText.TabIndex = 5
        '
        'VATText
        '
        Me.VATText.Location = New System.Drawing.Point(70, 49)
        Me.VATText.Mask = "R 000.00"
        Me.VATText.Name = "VATText"
        Me.VATText.ReadOnly = True
        Me.VATText.Size = New System.Drawing.Size(100, 20)
        Me.VATText.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "VAT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total incl." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " VAT"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(16, 23)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "Total"
        '
        'NewSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ISTN_Project.My.Resources.Resources.background1
        Me.ClientSize = New System.Drawing.Size(725, 560)
        Me.Controls.Add(Me.pnlPrice)
        Me.Controls.Add(Me.pnlControl)
        Me.Controls.Add(Me.dgvSales)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.edtLoyaltyNo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NewSale"
        Me.Text = "NewSale"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControl.ResumeLayout(False)
        Me.pnlPrice.ResumeLayout(False)
        Me.pnlPrice.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents edtLoyaltyNo As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents ProductsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents dgvSales As System.Windows.Forms.DataGridView
    Friend WithEvents pnlControl As System.Windows.Forms.Panel
    Friend WithEvents CancelSaleButton As System.Windows.Forms.Button
    Friend WithEvents RemoveItemButton As System.Windows.Forms.Button
    Friend WithEvents NewSaleButton As System.Windows.Forms.Button
    Friend WithEvents pnlPrice As System.Windows.Forms.Panel
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EndSaleButton As System.Windows.Forms.Button
    Friend WithEvents TotalText As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TotalinVATText As System.Windows.Forms.MaskedTextBox
    Friend WithEvents VATText As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LoyaltyDiscText As System.Windows.Forms.MaskedTextBox
    Friend WithEvents pointTT As System.Windows.Forms.ToolTip
End Class
