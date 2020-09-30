Public Class AddEmployee
    Public SQL As New DataBaseControl

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        'Checks all fields are filled
        'Inputs data into table
        If (Login.isFieldBlank(edtName.Text) = False) And (Login.isFieldBlank(edtSurname.Text) = False) And
           (Login.isFieldBlank(edtEmerName.Text) = False) And (Login.isFieldBlank(edtBankName.Text) = False) And
              (Login.isFieldBlank(RateText.Text) = False) And (Login.isFieldBlank(TellNoText.Text) = False) And
             (Login.isFieldBlank(EmerContactNoText.Text) = False) And (JobComboBox.SelectedItem.Equals("") = False) Then


            If SQL.HasConnection = True Then
                If SQL.SQLDataSet IsNot Nothing Then
                    SQL.SQLDataSet.Clear()
                End If
                SQL.RunQuery("Select MAX(EmployeeID) AS HighestID FROM Employee")
                Dim ID As Integer = SQL.SQLDataSet.Tables(0).Rows(0).Item("HighestID") + 1
                Dim Active As String = "A"
                Active.Trim()
                SQL.SQLDataSet.Clear()
                Dim banknum As Integer = Integer.Parse(edtBankAccountNo.Text)
                Dim job As String = (JobComboBox.SelectedItem).ToString
                Dim rate As Decimal = (Decimal.Parse(RateText.Text)) / 100
                rate = FormatCurrency(rate, 3)
                SQL.RunQuery("INSERT INTO Employee(EmployeeID,Name,Surname,BankNumber,BankName,JobLevel,HourlyRate,ContactNumber,EmergencyContactNo,EmergencyContactName,EmploymentStatus,Password) VALUES('" & ID & "','" & edtName.Text & "','" & edtSurname.Text & "','" & banknum & "','" & edtBankName.Text & "','" & job & "','" & rate & "','" & TellNoText.Text & "','" & EmerContactNoText.Text & "','" & edtEmerName.Text & "','A','" & edtName.Text & "')")
                MessageBox.Show("Data Inserted")
            Else
                MessageBox.Show("Please ensure ALL fields are entered", "Incomplete Details", MessageBoxButtons.OK)
            End If
        End If
        Employees.Show()
        Me.Hide()


    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        Employees.Show()
        Me.Hide()
    End Sub

    Private Sub AddEmployee_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RateText_MaskInputRejected(sender As System.Object, e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles RateText.MaskInputRejected

    End Sub
End Class