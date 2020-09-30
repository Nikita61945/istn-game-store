<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Me.EmployeeTc = New System.Windows.Forms.TabControl()
        Me.EmployeesTB = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.EmployeeComboBox = New System.Windows.Forms.ComboBox()
        Me.HRforERB = New System.Windows.Forms.RadioButton()
        Me.SforERB = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.THRB = New System.Windows.Forms.RadioButton()
        Me.TSRB = New System.Windows.Forms.RadioButton()
        Me.dgvEmployee = New System.Windows.Forms.DataGridView()
        Me.SalesTP = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.grBDate = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EndDate = New System.Windows.Forms.DateTimePicker()
        Me.BeginDate = New System.Windows.Forms.DateTimePicker()
        Me.DateBetweenRadioButton = New System.Windows.Forms.RadioButton()
        Me.ThreeMonthRadioButton = New System.Windows.Forms.RadioButton()
        Me.OneMonthRadioButton = New System.Windows.Forms.RadioButton()
        Me.dgvSaleRep = New System.Windows.Forms.DataGridView()
        Me.ProductsTB = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ReStockRB = New System.Windows.Forms.RadioButton()
        Me.WorstSellerRB = New System.Windows.Forms.RadioButton()
        Me.BestSellerRB = New System.Windows.Forms.RadioButton()
        Me.QuatityLeftRB = New System.Windows.Forms.RadioButton()
        Me.QuatitySoldRB = New System.Windows.Forms.RadioButton()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ist2ggDataSet = New ISTN_Project.ist2ggDataSet()
        Me.SaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleTableAdapter = New ISTN_Project.ist2ggDataSetTableAdapters.SaleTableAdapter()
        Me.EmployeeTableAdapter = New ISTN_Project.ist2ggDataSetTableAdapters.EmployeeTableAdapter()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New ISTN_Project.ist2ggDataSetTableAdapters.ProductTableAdapter()
        Me.EmployeeTc.SuspendLayout()
        Me.EmployeesTB.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SalesTP.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grBDate.SuspendLayout()
        CType(Me.dgvSaleRep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductsTB.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ist2ggDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmployeeTc
        '
        Me.EmployeeTc.Controls.Add(Me.EmployeesTB)
        Me.EmployeeTc.Controls.Add(Me.SalesTP)
        Me.EmployeeTc.Controls.Add(Me.ProductsTB)
        Me.EmployeeTc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeTc.Location = New System.Drawing.Point(16, 12)
        Me.EmployeeTc.Name = "EmployeeTc"
        Me.EmployeeTc.SelectedIndex = 0
        Me.EmployeeTc.Size = New System.Drawing.Size(613, 460)
        Me.EmployeeTc.TabIndex = 0
        '
        'EmployeesTB
        '
        Me.EmployeesTB.Controls.Add(Me.GroupBox4)
        Me.EmployeesTB.Controls.Add(Me.GroupBox2)
        Me.EmployeesTB.Controls.Add(Me.dgvEmployee)
        Me.EmployeesTB.Location = New System.Drawing.Point(4, 34)
        Me.EmployeesTB.Name = "EmployeesTB"
        Me.EmployeesTB.Padding = New System.Windows.Forms.Padding(3)
        Me.EmployeesTB.Size = New System.Drawing.Size(605, 422)
        Me.EmployeesTB.TabIndex = 3
        Me.EmployeesTB.Text = "Employees"
        Me.EmployeesTB.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.EmployeeComboBox)
        Me.GroupBox4.Controls.Add(Me.HRforERB)
        Me.GroupBox4.Controls.Add(Me.SforERB)
        Me.GroupBox4.Location = New System.Drawing.Point(42, 186)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 132)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Individual"
        '
        'EmployeeComboBox
        '
        Me.EmployeeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeComboBox.FormattingEnabled = True
        Me.EmployeeComboBox.Location = New System.Drawing.Point(18, 30)
        Me.EmployeeComboBox.Name = "EmployeeComboBox"
        Me.EmployeeComboBox.Size = New System.Drawing.Size(156, 26)
        Me.EmployeeComboBox.TabIndex = 5
        '
        'HRforERB
        '
        Me.HRforERB.AutoSize = True
        Me.HRforERB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HRforERB.ForeColor = System.Drawing.Color.Black
        Me.HRforERB.Location = New System.Drawing.Point(29, 98)
        Me.HRforERB.Name = "HRforERB"
        Me.HRforERB.Size = New System.Drawing.Size(103, 19)
        Me.HRforERB.TabIndex = 4
        Me.HRforERB.TabStop = True
        Me.HRforERB.Text = "Hours Worked"
        Me.HRforERB.UseVisualStyleBackColor = True
        '
        'SforERB
        '
        Me.SforERB.AutoSize = True
        Me.SforERB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SforERB.ForeColor = System.Drawing.Color.Black
        Me.SforERB.Location = New System.Drawing.Point(29, 73)
        Me.SforERB.Name = "SforERB"
        Me.SforERB.Size = New System.Drawing.Size(56, 19)
        Me.SforERB.TabIndex = 3
        Me.SforERB.TabStop = True
        Me.SforERB.Text = "Sales"
        Me.SforERB.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.THRB)
        Me.GroupBox2.Controls.Add(Me.TSRB)
        Me.GroupBox2.Location = New System.Drawing.Point(42, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Overall"
        '
        'THRB
        '
        Me.THRB.AutoSize = True
        Me.THRB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.THRB.ForeColor = System.Drawing.Color.Black
        Me.THRB.Location = New System.Drawing.Point(29, 59)
        Me.THRB.Name = "THRB"
        Me.THRB.Size = New System.Drawing.Size(133, 19)
        Me.THRB.TabIndex = 3
        Me.THRB.TabStop = True
        Me.THRB.Text = "Total Hours Worked"
        Me.THRB.UseVisualStyleBackColor = True
        '
        'TSRB
        '
        Me.TSRB.AutoSize = True
        Me.TSRB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSRB.ForeColor = System.Drawing.Color.Black
        Me.TSRB.Location = New System.Drawing.Point(29, 34)
        Me.TSRB.Name = "TSRB"
        Me.TSRB.Size = New System.Drawing.Size(86, 19)
        Me.TSRB.TabIndex = 2
        Me.TSRB.TabStop = True
        Me.TSRB.Text = "Total Sales"
        Me.TSRB.UseVisualStyleBackColor = True
        '
        'dgvEmployee
        '
        Me.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployee.Location = New System.Drawing.Point(265, 19)
        Me.dgvEmployee.Name = "dgvEmployee"
        Me.dgvEmployee.Size = New System.Drawing.Size(318, 375)
        Me.dgvEmployee.TabIndex = 0
        '
        'SalesTP
        '
        Me.SalesTP.Controls.Add(Me.DataGridView1)
        Me.SalesTP.Controls.Add(Me.grBDate)
        Me.SalesTP.Controls.Add(Me.dgvSaleRep)
        Me.SalesTP.ForeColor = System.Drawing.Color.Red
        Me.SalesTP.Location = New System.Drawing.Point(4, 34)
        Me.SalesTP.Name = "SalesTP"
        Me.SalesTP.Padding = New System.Windows.Forms.Padding(3)
        Me.SalesTP.Size = New System.Drawing.Size(605, 422)
        Me.SalesTP.TabIndex = 0
        Me.SalesTP.Text = "Sales"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(288, 229)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(300, 72)
        Me.DataGridView1.TabIndex = 2
        '
        'grBDate
        '
        Me.grBDate.Controls.Add(Me.Label1)
        Me.grBDate.Controls.Add(Me.EndDate)
        Me.grBDate.Controls.Add(Me.BeginDate)
        Me.grBDate.Controls.Add(Me.DateBetweenRadioButton)
        Me.grBDate.Controls.Add(Me.ThreeMonthRadioButton)
        Me.grBDate.Controls.Add(Me.OneMonthRadioButton)
        Me.grBDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grBDate.Location = New System.Drawing.Point(36, 32)
        Me.grBDate.Name = "grBDate"
        Me.grBDate.Size = New System.Drawing.Size(200, 269)
        Me.grBDate.TabIndex = 1
        Me.grBDate.TabStop = False
        Me.grBDate.Text = "List of Sales for :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(68, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "AND"
        '
        'EndDate
        '
        Me.EndDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EndDate.Location = New System.Drawing.Point(16, 143)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(153, 21)
        Me.EndDate.TabIndex = 4
        '
        'BeginDate
        '
        Me.BeginDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeginDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeginDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BeginDate.Location = New System.Drawing.Point(16, 102)
        Me.BeginDate.Name = "BeginDate"
        Me.BeginDate.Size = New System.Drawing.Size(153, 21)
        Me.BeginDate.TabIndex = 3
        '
        'DateBetweenRadioButton
        '
        Me.DateBetweenRadioButton.AutoSize = True
        Me.DateBetweenRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateBetweenRadioButton.ForeColor = System.Drawing.Color.Black
        Me.DateBetweenRadioButton.Location = New System.Drawing.Point(35, 77)
        Me.DateBetweenRadioButton.Name = "DateBetweenRadioButton"
        Me.DateBetweenRadioButton.Size = New System.Drawing.Size(102, 19)
        Me.DateBetweenRadioButton.TabIndex = 2
        Me.DateBetweenRadioButton.TabStop = True
        Me.DateBetweenRadioButton.Text = "Date Between"
        Me.DateBetweenRadioButton.UseVisualStyleBackColor = True
        '
        'ThreeMonthRadioButton
        '
        Me.ThreeMonthRadioButton.AutoSize = True
        Me.ThreeMonthRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThreeMonthRadioButton.ForeColor = System.Drawing.Color.Black
        Me.ThreeMonthRadioButton.Location = New System.Drawing.Point(35, 52)
        Me.ThreeMonthRadioButton.Name = "ThreeMonthRadioButton"
        Me.ThreeMonthRadioButton.Size = New System.Drawing.Size(69, 19)
        Me.ThreeMonthRadioButton.TabIndex = 1
        Me.ThreeMonthRadioButton.TabStop = True
        Me.ThreeMonthRadioButton.Text = "90 Days"
        Me.ThreeMonthRadioButton.UseVisualStyleBackColor = True
        '
        'OneMonthRadioButton
        '
        Me.OneMonthRadioButton.AutoSize = True
        Me.OneMonthRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OneMonthRadioButton.ForeColor = System.Drawing.Color.Black
        Me.OneMonthRadioButton.Location = New System.Drawing.Point(35, 27)
        Me.OneMonthRadioButton.Name = "OneMonthRadioButton"
        Me.OneMonthRadioButton.Size = New System.Drawing.Size(69, 19)
        Me.OneMonthRadioButton.TabIndex = 0
        Me.OneMonthRadioButton.TabStop = True
        Me.OneMonthRadioButton.Text = "30 Days"
        Me.OneMonthRadioButton.UseVisualStyleBackColor = True
        '
        'dgvSaleRep
        '
        Me.dgvSaleRep.AllowUserToAddRows = False
        Me.dgvSaleRep.AllowUserToDeleteRows = False
        Me.dgvSaleRep.AllowUserToOrderColumns = True
        Me.dgvSaleRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSaleRep.Location = New System.Drawing.Point(288, 30)
        Me.dgvSaleRep.Name = "dgvSaleRep"
        Me.dgvSaleRep.ReadOnly = True
        Me.dgvSaleRep.Size = New System.Drawing.Size(300, 199)
        Me.dgvSaleRep.TabIndex = 0
        '
        'ProductsTB
        '
        Me.ProductsTB.Controls.Add(Me.GroupBox1)
        Me.ProductsTB.Controls.Add(Me.dgvProducts)
        Me.ProductsTB.Location = New System.Drawing.Point(4, 34)
        Me.ProductsTB.Name = "ProductsTB"
        Me.ProductsTB.Padding = New System.Windows.Forms.Padding(3)
        Me.ProductsTB.Size = New System.Drawing.Size(605, 422)
        Me.ProductsTB.TabIndex = 2
        Me.ProductsTB.Text = "Products"
        Me.ProductsTB.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ReStockRB)
        Me.GroupBox1.Controls.Add(Me.WorstSellerRB)
        Me.GroupBox1.Controls.Add(Me.BestSellerRB)
        Me.GroupBox1.Controls.Add(Me.QuatityLeftRB)
        Me.GroupBox1.Controls.Add(Me.QuatitySoldRB)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 185)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Display"
        '
        'ReStockRB
        '
        Me.ReStockRB.AutoSize = True
        Me.ReStockRB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReStockRB.ForeColor = System.Drawing.Color.Black
        Me.ReStockRB.Location = New System.Drawing.Point(32, 146)
        Me.ReStockRB.Name = "ReStockRB"
        Me.ReStockRB.Size = New System.Drawing.Size(115, 19)
        Me.ReStockRB.TabIndex = 5
        Me.ReStockRB.TabStop = True
        Me.ReStockRB.Text = "In need ReStock"
        Me.ReStockRB.UseVisualStyleBackColor = True
        '
        'WorstSellerRB
        '
        Me.WorstSellerRB.AutoSize = True
        Me.WorstSellerRB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorstSellerRB.ForeColor = System.Drawing.Color.Black
        Me.WorstSellerRB.Location = New System.Drawing.Point(32, 119)
        Me.WorstSellerRB.Name = "WorstSellerRB"
        Me.WorstSellerRB.Size = New System.Drawing.Size(91, 19)
        Me.WorstSellerRB.TabIndex = 4
        Me.WorstSellerRB.TabStop = True
        Me.WorstSellerRB.Text = "Worst Seller"
        Me.WorstSellerRB.UseVisualStyleBackColor = True
        '
        'BestSellerRB
        '
        Me.BestSellerRB.AutoSize = True
        Me.BestSellerRB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BestSellerRB.ForeColor = System.Drawing.Color.Black
        Me.BestSellerRB.Location = New System.Drawing.Point(32, 94)
        Me.BestSellerRB.Name = "BestSellerRB"
        Me.BestSellerRB.Size = New System.Drawing.Size(90, 19)
        Me.BestSellerRB.TabIndex = 3
        Me.BestSellerRB.TabStop = True
        Me.BestSellerRB.Text = "Best Sellers"
        Me.BestSellerRB.UseVisualStyleBackColor = True
        '
        'QuatityLeftRB
        '
        Me.QuatityLeftRB.AutoSize = True
        Me.QuatityLeftRB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuatityLeftRB.ForeColor = System.Drawing.Color.Black
        Me.QuatityLeftRB.Location = New System.Drawing.Point(32, 64)
        Me.QuatityLeftRB.Name = "QuatityLeftRB"
        Me.QuatityLeftRB.Size = New System.Drawing.Size(92, 19)
        Me.QuatityLeftRB.TabIndex = 2
        Me.QuatityLeftRB.TabStop = True
        Me.QuatityLeftRB.Text = "Quantity Left"
        Me.QuatityLeftRB.UseVisualStyleBackColor = True
        '
        'QuatitySoldRB
        '
        Me.QuatitySoldRB.AutoSize = True
        Me.QuatitySoldRB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuatitySoldRB.ForeColor = System.Drawing.Color.Black
        Me.QuatitySoldRB.Location = New System.Drawing.Point(32, 39)
        Me.QuatitySoldRB.Name = "QuatitySoldRB"
        Me.QuatitySoldRB.Size = New System.Drawing.Size(90, 19)
        Me.QuatitySoldRB.TabIndex = 1
        Me.QuatitySoldRB.TabStop = True
        Me.QuatitySoldRB.Text = "Quatity Sold"
        Me.QuatitySoldRB.UseVisualStyleBackColor = True
        '
        'dgvProducts
        '
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Location = New System.Drawing.Point(235, 18)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.Size = New System.Drawing.Size(364, 365)
        Me.dgvProducts.TabIndex = 0
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.Ist2ggDataSet
        '
        'Ist2ggDataSet
        '
        Me.Ist2ggDataSet.DataSetName = "ist2ggDataSet"
        Me.Ist2ggDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SaleBindingSource
        '
        Me.SaleBindingSource.DataMember = "Sale"
        Me.SaleBindingSource.DataSource = Me.Ist2ggDataSet
        '
        'SaleTableAdapter
        '
        Me.SaleTableAdapter.ClearBeforeFill = True
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.Ist2ggDataSet
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ISTN_Project.My.Resources.Resources.background1
        Me.ClientSize = New System.Drawing.Size(649, 530)
        Me.Controls.Add(Me.EmployeeTc)
        Me.Name = "Reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SalesReport"
        Me.EmployeeTc.ResumeLayout(False)
        Me.EmployeesTB.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SalesTP.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grBDate.ResumeLayout(False)
        Me.grBDate.PerformLayout()
        CType(Me.dgvSaleRep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductsTB.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ist2ggDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EmployeeTc As System.Windows.Forms.TabControl
    Friend WithEvents SalesTP As System.Windows.Forms.TabPage
    Friend WithEvents ProductsTB As System.Windows.Forms.TabPage
    Friend WithEvents grBDate As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSaleRep As System.Windows.Forms.DataGridView
    Friend WithEvents OneMonthRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents BeginDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateBetweenRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ThreeMonthRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents EmployeesTB As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents WorstSellerRB As System.Windows.Forms.RadioButton
    Friend WithEvents BestSellerRB As System.Windows.Forms.RadioButton
    Friend WithEvents QuatityLeftRB As System.Windows.Forms.RadioButton
    Friend WithEvents QuatitySoldRB As System.Windows.Forms.RadioButton
    Friend WithEvents ReStockRB As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents EmployeeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents HRforERB As System.Windows.Forms.RadioButton
    Friend WithEvents SforERB As System.Windows.Forms.RadioButton
    Friend WithEvents THRB As System.Windows.Forms.RadioButton
    Friend WithEvents TSRB As System.Windows.Forms.RadioButton
    Friend WithEvents Ist2ggDataSet As ISTN_Project.ist2ggDataSet
    Friend WithEvents SaleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SaleTableAdapter As ISTN_Project.ist2ggDataSetTableAdapters.SaleTableAdapter
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableAdapter As ISTN_Project.ist2ggDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents dgvEmployee As System.Windows.Forms.DataGridView
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductTableAdapter As ISTN_Project.ist2ggDataSetTableAdapters.ProductTableAdapter
End Class
