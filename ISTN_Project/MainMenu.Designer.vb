<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSale = New System.Windows.Forms.Button()
        Me.btnLCust = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnPass = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(34, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome!"
        '
        'btnSale
        '
        Me.btnSale.Location = New System.Drawing.Point(42, 106)
        Me.btnSale.Name = "btnSale"
        Me.btnSale.Size = New System.Drawing.Size(452, 42)
        Me.btnSale.TabIndex = 1
        Me.btnSale.Text = "Sales"
        Me.btnSale.UseVisualStyleBackColor = True
        '
        'btnLCust
        '
        Me.btnLCust.Location = New System.Drawing.Point(42, 165)
        Me.btnLCust.Name = "btnLCust"
        Me.btnLCust.Size = New System.Drawing.Size(452, 42)
        Me.btnLCust.TabIndex = 2
        Me.btnLCust.Text = "Loyalty Customers"
        Me.btnLCust.UseVisualStyleBackColor = True
        '
        'btnProducts
        '
        Me.btnProducts.Location = New System.Drawing.Point(42, 224)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(452, 42)
        Me.btnProducts.TabIndex = 3
        Me.btnProducts.Text = "Products"
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'btnEmployee
        '
        Me.btnEmployee.Location = New System.Drawing.Point(42, 278)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(452, 42)
        Me.btnEmployee.TabIndex = 4
        Me.btnEmployee.Text = "Employees"
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(42, 442)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(452, 42)
        Me.btnLogOut.TabIndex = 5
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnPass
        '
        Me.btnPass.Location = New System.Drawing.Point(42, 391)
        Me.btnPass.Name = "btnPass"
        Me.btnPass.Size = New System.Drawing.Size(452, 42)
        Me.btnPass.TabIndex = 6
        Me.btnPass.Text = "Change My Password"
        Me.btnPass.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(42, 329)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(452, 42)
        Me.btnReports.TabIndex = 7
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ISTN_Project.My.Resources.Resources.background1
        Me.ClientSize = New System.Drawing.Size(530, 496)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnPass)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnEmployee)
        Me.Controls.Add(Me.btnProducts)
        Me.Controls.Add(Me.btnLCust)
        Me.Controls.Add(Me.btnSale)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSale As System.Windows.Forms.Button
    Friend WithEvents btnLCust As System.Windows.Forms.Button
    Friend WithEvents btnProducts As System.Windows.Forms.Button
    Friend WithEvents btnEmployee As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents btnPass As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
End Class
