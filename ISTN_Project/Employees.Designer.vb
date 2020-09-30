<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employees
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
        Me.dgvEmployees = New System.Windows.Forms.DataGridView()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DisplayButton = New System.Windows.Forms.Button()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.JobTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.JobTypeRB = New System.Windows.Forms.RadioButton()
        Me.SurnameRadioButton = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.EmployeeesComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvEmployees
        '
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Location = New System.Drawing.Point(30, 69)
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.Size = New System.Drawing.Size(607, 332)
        Me.dgvEmployees.TabIndex = 0
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(19, 10)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 30)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "&Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(19, 48)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 30)
        Me.EditButton.TabIndex = 2
        Me.EditButton.Text = "&Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.DisplayButton)
        Me.Panel1.Controls.Add(Me.ShowButton)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(32, 408)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 119)
        Me.Panel1.TabIndex = 4
        '
        'DisplayButton
        '
        Me.DisplayButton.Location = New System.Drawing.Point(276, 25)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(75, 29)
        Me.DisplayButton.TabIndex = 3
        Me.DisplayButton.Text = "&Display"
        Me.DisplayButton.UseVisualStyleBackColor = True
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(276, 61)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 34)
        Me.ShowButton.TabIndex = 2
        Me.ShowButton.Text = "&Show All"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gray
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.JobTypeComboBox)
        Me.GroupBox1.Controls.Add(Me.JobTypeRB)
        Me.GroupBox1.Controls.Add(Me.SurnameRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter By/ Display Order :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(89, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 3
        '
        'JobTypeComboBox
        '
        Me.JobTypeComboBox.FormattingEnabled = True
        Me.JobTypeComboBox.Items.AddRange(New Object() {"Manager", "Sales Rep"})
        Me.JobTypeComboBox.Location = New System.Drawing.Point(88, 52)
        Me.JobTypeComboBox.Name = "JobTypeComboBox"
        Me.JobTypeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.JobTypeComboBox.TabIndex = 2
        '
        'JobTypeRB
        '
        Me.JobTypeRB.AutoSize = True
        Me.JobTypeRB.Location = New System.Drawing.Point(13, 52)
        Me.JobTypeRB.Name = "JobTypeRB"
        Me.JobTypeRB.Size = New System.Drawing.Size(69, 17)
        Me.JobTypeRB.TabIndex = 1
        Me.JobTypeRB.TabStop = True
        Me.JobTypeRB.Text = "Job Type"
        Me.JobTypeRB.UseVisualStyleBackColor = True
        '
        'SurnameRadioButton
        '
        Me.SurnameRadioButton.AutoSize = True
        Me.SurnameRadioButton.Location = New System.Drawing.Point(13, 29)
        Me.SurnameRadioButton.Name = "SurnameRadioButton"
        Me.SurnameRadioButton.Size = New System.Drawing.Size(67, 17)
        Me.SurnameRadioButton.TabIndex = 0
        Me.SurnameRadioButton.TabStop = True
        Me.SurnameRadioButton.Text = "Surname"
        Me.SurnameRadioButton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AddButton)
        Me.Panel2.Controls.Add(Me.EditButton)
        Me.Panel2.Location = New System.Drawing.Point(511, 412)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(126, 91)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.SearchButton)
        Me.Panel3.Controls.Add(Me.EmployeeesComboBox)
        Me.Panel3.Location = New System.Drawing.Point(30, 22)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(323, 41)
        Me.Panel3.TabIndex = 6
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
        'EmployeeesComboBox
        '
        Me.EmployeeesComboBox.FormattingEnabled = True
        Me.EmployeeesComboBox.Location = New System.Drawing.Point(17, 12)
        Me.EmployeeesComboBox.Name = "EmployeeesComboBox"
        Me.EmployeeesComboBox.Size = New System.Drawing.Size(198, 21)
        Me.EmployeeesComboBox.TabIndex = 0
        '
        'Employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ISTN_Project.My.Resources.Resources.background1
        Me.ClientSize = New System.Drawing.Size(700, 531)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvEmployees)
        Me.Name = "Employees"
        Me.Text = "Employees"
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvEmployees As System.Windows.Forms.DataGridView
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents JobTypeRB As System.Windows.Forms.RadioButton
    Friend WithEvents SurnameRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents JobTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents DisplayButton As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents EmployeeesComboBox As System.Windows.Forms.ComboBox
End Class
