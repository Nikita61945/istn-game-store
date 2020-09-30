Public Class EditEmployee
    Public SQL As New DataBaseControl

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActiveCheckBox.CheckedChanged

    End Sub

    Private Sub SaveButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveButton.Click
        Dim activeStatus As String = "A"
        If ActiveCheckBox.Checked Then
            activeStatus = "D"
        End If

        Dim query As String = "UPDATE Employee SET Name='" & edtName.Text & "',Surname='" & edtSurname.Text & "',BankNumber='" & Integer.Parse(edtBankDetails.Text) & "',ContactNumber='" & TellNoText.Text & "',EmergencyContactNo='" & EmerContactNoText.Text & "',EmergencyContactName='" & edtEmerName.Text & "',EmploymentStatus='" & activeStatus & "' WHERE EmployeeID='" & Integer.Parse(Employees.ID) & "'"
        SQL.RunQuery(query)
        MessageBox.Show("Employee data updated")
        Employees.Show()
        Me.Hide()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Employees.Show()
        Me.Hide()
    End Sub

 
    Private Sub EditEmployee_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
    End Sub
End Class