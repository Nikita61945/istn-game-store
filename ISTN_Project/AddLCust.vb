
Public Class AddLCust
    Public SQL As New DataBaseControl

    Private Sub AddButton_Click(sender As System.Object, e As System.EventArgs) Handles AddButton.Click
        If ((TellNoText.Text).StartsWith("0")) And (checkDigit(TellNoText.Text)) Then
            If checkEmail(edtEmail.Text) Then
                If SQL.HasConnection Then
                    If SQL.SQLDataSet IsNot Nothing Then
                        SQL.SQLDataSet.Clear()
                    End If

                    SQL.RunQuery("Select MAX(LoyaltyNo) AS HighestID FROM Loyalty")
                    Dim ID As Integer = 0
                    If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
                        ID = SQL.SQLDataSet.Tables(0).Rows(0).Item("HighestID") + 1
                    Else
                        ID = 1
                    End If
                    SQL.SQLDataSet.Clear()
                    Dim Gender As String
                    If (cbxGender.SelectedText = "Female") Then
                        Gender = "F"
                    ElseIf (cbxGender.SelectedText = "Male") Then
                        Gender = "M"
                    Else
                        Gender = "O"
                    End If
                    Dim LPoints As Integer = 10
                    SQL.RunQuery("INSERT INTO Loyalty(LoyaltyNo,Name,Surname,EmailAddress,ContactNumber, " & _
                                 "Address,AddressCity,AddressPostalCode,DateOfBirth,Gender,LoyaltyPoints) " & _
                                 "Values('" & ID & "','" & edtName.Text & "','" & edtSurname.Text & "','" & edtEmail.Text & "','" & TellNoText.Text & "','" & edtAddress1.Text & "','" & edtAddress2.Text & "','" & edtAddress3.Text & "','" & Date.Parse(dtpLCust.Value) & "','" & Gender & "','" & LPoints & "')")
                End If
            Else
                MsgBox("Email is invalid", MsgBoxStyle.Information, "Invalid Data")
            End If
        Else
            MsgBox("Tell No is invalid", MsgBoxStyle.Information, "Invalid Data")
        End If

        MsgBox("Data Captured")
        Me.Hide()
        LoyaltyCustomers.Show()
    End Sub


    Function checkEmail(ByVal str As String) As Boolean
        Dim tf = True
        If Not str.Contains("@") And Not str.Contains(".") And str.Length > 30 Then
            tf = False
        End If
        Return tf
    End Function

    Function checkDigit(ByVal str As String) As Boolean
        Dim tf = True
        For i As Integer = 0 To (str.Length - 1)
            If Not Char.IsDigit(str.Chars(i)) Then
                tf = False
            End If
        Next
        Return tf
    End Function

    Private Sub CancelButton_Click(sender As System.Object, e As System.EventArgs) Handles CancelButton.Click
        LoyaltyCustomers.Show()
        Me.Hide()
    End Sub
End Class