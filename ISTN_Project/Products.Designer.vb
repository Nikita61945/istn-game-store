<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
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
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PriceDescRB = New System.Windows.Forms.RadioButton()
        Me.PriceAscRB = New System.Windows.Forms.RadioButton()
        Me.PlatformRB = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.ProductsComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProducts
        '
        Me.dgvProducts.Location = New System.Drawing.Point(44, 90)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.Size = New System.Drawing.Size(666, 257)
        Me.dgvProducts.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RefreshButton)
        Me.Panel1.Controls.Add(Me.UpdateButton)
        Me.Panel1.Controls.Add(Me.AddButton)
        Me.Panel1.Location = New System.Drawing.Point(51, 352)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(153, 123)
        Me.Panel1.TabIndex = 1
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(33, 81)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 23)
        Me.RefreshButton.TabIndex = 2
        Me.RefreshButton.Text = "&Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(32, 50)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateButton.TabIndex = 1
        Me.UpdateButton.Text = "&Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(31, 16)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 0
        Me.AddButton.Text = "&Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PriceDescRB)
        Me.GroupBox1.Controls.Add(Me.PriceAscRB)
        Me.GroupBox1.Controls.Add(Me.PlatformRB)
        Me.GroupBox1.Location = New System.Drawing.Point(485, 364)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order By"
        '
        'PriceDescRB
        '
        Me.PriceDescRB.AutoSize = True
        Me.PriceDescRB.Location = New System.Drawing.Point(20, 69)
        Me.PriceDescRB.Name = "PriceDescRB"
        Me.PriceDescRB.Size = New System.Drawing.Size(115, 17)
        Me.PriceDescRB.TabIndex = 2
        Me.PriceDescRB.TabStop = True
        Me.PriceDescRB.Text = "Price : Low to High"
        Me.PriceDescRB.UseVisualStyleBackColor = True
        '
        'PriceAscRB
        '
        Me.PriceAscRB.AutoSize = True
        Me.PriceAscRB.Location = New System.Drawing.Point(20, 47)
        Me.PriceAscRB.Name = "PriceAscRB"
        Me.PriceAscRB.Size = New System.Drawing.Size(115, 17)
        Me.PriceAscRB.TabIndex = 1
        Me.PriceAscRB.TabStop = True
        Me.PriceAscRB.Text = "Price : High to Low"
        Me.PriceAscRB.UseVisualStyleBackColor = True
        '
        'PlatformRB
        '
        Me.PlatformRB.AutoSize = True
        Me.PlatformRB.Location = New System.Drawing.Point(20, 26)
        Me.PlatformRB.Name = "PlatformRB"
        Me.PlatformRB.Size = New System.Drawing.Size(63, 17)
        Me.PlatformRB.TabIndex = 0
        Me.PlatformRB.TabStop = True
        Me.PlatformRB.Text = "Platfrom"
        Me.PlatformRB.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SearchButton)
        Me.Panel2.Controls.Add(Me.ProductsComboBox)
        Me.Panel2.Location = New System.Drawing.Point(362, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(323, 69)
        Me.Panel2.TabIndex = 3
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
        'ProductsComboBox
        '
        Me.ProductsComboBox.FormattingEnabled = True
        Me.ProductsComboBox.Location = New System.Drawing.Point(19, 14)
        Me.ProductsComboBox.Name = "ProductsComboBox"
        Me.ProductsComboBox.Size = New System.Drawing.Size(198, 21)
        Me.ProductsComboBox.TabIndex = 0
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ISTN_Project.My.Resources.Resources.background1
        Me.ClientSize = New System.Drawing.Size(758, 487)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvProducts)
        Me.Name = "Products"
        Me.Text = "Products"
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PriceDescRB As System.Windows.Forms.RadioButton
    Friend WithEvents PriceAscRB As System.Windows.Forms.RadioButton
    Friend WithEvents PlatformRB As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents ProductsComboBox As System.Windows.Forms.ComboBox
End Class
