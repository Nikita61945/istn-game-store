Public Class Employees
    Private SQL As New DataBaseControl
    Friend ID As String
    Friend RowSelected As Integer


    Private Sub Employees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub PopComboBox()
        If SQL.HasConnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT EmployeeID, convert(varChar(6),EmployeeID)+' '+ Name AS 'Identify' FROM Employee")

            SQL.SQLDataAap.SelectCommand = SQL.SQLComd
            SQL.SQLDataAap.Fill(SQL.SQLDataSet)
            EmployeeesComboBox.DataSource = SQL.SQLDataSet.Tables(0)
            EmployeeesComboBox.ValueMember = "EmployeeID"
            EmployeeesComboBox.DisplayMember = "Identify"
        End If

    End Sub


    Private Sub GetEmployees()
        Dim dbTable As New DataTable
        Dim bSource As New BindingSource
        SQL.SQLDataAap.SelectCommand = SQL.SQLComd
        SQL.SQLDataAap.Fill(dbTable)

        bSource.DataSource = dbTable
        SQL.SQLDataAap.Update(dbTable)
        dgvEmployees.DataSource = dbTable
    End Sub



    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        AddEmployee.Show()
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        ' If  Then for errors mann
        EditEmployee.Show()
        RowSelected = dgvEmployees.CurrentRow.Index()
        ID = dgvEmployees.Item(0, RowSelected).Value().ToString
        'MsgBox(ID + "in sring")
        EditEmployee.edtBankDetails.Text = dgvEmployees.Item(6, RowSelected).Value()
        EditEmployee.edtName.Text = dgvEmployees.Item(1, RowSelected).Value()
        EditEmployee.edtSurname.Text = dgvEmployees.Item(2, RowSelected).Value()
        EditEmployee.JobComboBox.SelectedItem = dgvEmployees.Item(3, RowSelected).Value()
        EditEmployee.edtEmerName.Text = dgvEmployees.Item(8, RowSelected).Value()
        EditEmployee.EmerContactNoText.Text = dgvEmployees.Item(7, RowSelected).Value()
        EditEmployee.TellNoText.Text = dgvEmployees.Item(5, RowSelected).Value()
        EditEmployee.RateText.Text = dgvEmployees.Item(4, RowSelected).Value()

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim id As Integer = Integer.Parse(EmployeeesComboBox.SelectedValue.ToString)
        SQL.SQLDataSet.Clear()

        Dim query As String = "SELECT Name,Surname,JobLevel,ContactNumber,BankNumber,EmergencyContactNo,EmergencyContactName,EmploymentStatus FROM Employee WHERE EmployeeID='" & id & "'"

        SQL.RunQuery(query)
        GetEmployees()
        PopComboBox()

    End Sub


    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        If SQL.HasConnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            If SurnameRadioButton.Checked And TextBox1.Text <> "null" Then
                Dim surname As String = TextBox1.Text
                SQL.SQLDataSet.Clear()
                Dim surnameQuery As String = "SELECT * FROM Employee WHERE Surname = '" & surname & "'"
                '' Dim surnameQuery As String = "SELECT Name,Surname,JobLevel,ContactNumber,EmergencyContactNo,EmergencyContactName,EmploymentStatus FROM (SELECT * FROM Employee WHERE Surname = '" & surname & "') AS SURNAME ORDER BY Name ASC"
                SQL.RunQuery(surnameQuery)

            ElseIf JobTypeRB.Checked And JobTypeComboBox.SelectedItem <> "null" Then
                Dim job As String = (JobTypeComboBox.SelectedItem).ToString
                SQL.SQLDataSet.Clear()
                Dim jobQuery As String = "SELECT * FROM Employee WHERE JobLevel='" & job & "' ORDER BY Surname ASC"
                SQL.RunQuery(jobQuery)
            End If
            GetEmployees()
            PopComboBox()

        End If
    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        If SQL.HasConnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            Dim revertQuery As String = "SELECT Name,Surname,JobLevel,ContactNumber,BankNumber,EmergencyContactNo,EmergencyContactName,EmploymentStatus FROM Employee"
            SQL.RunQuery(revertQuery)
            GetEmployees()
            PopComboBox()

        End If
    End Sub

    Private Sub EmployeeesComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EmployeeesComboBox.SelectedIndexChanged
        SearchButton.Enabled = True
    End Sub

    Private Sub Employees_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        If SQL.HasConnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT EmployeeID,Name,Surname,JobLevel,HourlyRate,ContactNumber,BankNumber,EmergencyContactNo,EmergencyContactName,EmploymentStatus FROM EMPLOYEE")
            GetEmployees()
            PopComboBox()

        End If
    End Sub

    Private Sub Employees_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MainMenu.Show()
    End Sub
End Class