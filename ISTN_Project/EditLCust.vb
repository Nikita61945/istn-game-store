Public Class EditLCust
    Public SQL As New DataBaseControl




    Private Sub CancelButton_Click(sender As System.Object, e As System.EventArgs) Handles CancelButton.Click
        Me.Hide()
        LoyaltyCustomers.Show()
    End Sub

    Private Sub EditLCust_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SaveButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveButton.Click
        If ((TellNoText.Text).StartsWith("0")) And (checkDigit(TellNoText.Text)) Then
            If checkEmail(edtEmail.Text) Then
                If SQL.HasConnection = True Then
                    If SQL.SQLDataSet IsNot Nothing Then
                        SQL.SQLDataSet.Clear()
                    End If

                    SQL.RunQuery("Update Loyalty SET Name = '" & edtName.Text & "', Surname = '" & edtSurname.Text & "', EmailAddress  = '" & edtEmail.Text & "', ContactNumber  = '" & TellNoText.Text & "', " & _
                                 " Address = '" & edtAddress1.Text & "', AddressCity = '" & edtAddress2.Text & "', AddressPostalCode = '" & edtAddress3.Text & "' WHERE LoyaltyNo = '" & Integer.Parse(LoyaltyCustomers.ID) & "'")
                End If
            Else
                MsgBox("Email is invalid", MsgBoxStyle.Information, "Invalid Data")
            End If
        Else
            MsgBox("Tell No is invalid", MsgBoxStyle.Information, "Invalid Data")
        End If
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
End Class