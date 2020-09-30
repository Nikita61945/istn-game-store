Public Class PassChange
    Public SQL As New DataBaseControl

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        Dim EmployeeID As Integer = Login.EmployeeID
        If SQL.HasConnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT Password FROM Employee WHERE EmployeeID = '" & EmployeeID & "'")

            If (SQL.SQLDataSet.Tables(0).Rows(0).Item("Password").Equals(edtOldPass.Text)) Then
                If (edtNewPass.Text = edtNewPassConfirm.Text) Then
                    SQL.SQLDataSet.Clear()
                    SQL.RunQuery("Update Employee Set Password = '" & edtNewPass.Text & "'" & _
                                 "WHERE  EmployeeID = '" & EmployeeID & "'")
                Else
                    MsgBox("New Password do not match", MsgBoxStyle.OkOnly, "Passwords ")
                    edtNewPass.Clear()
                    edtNewPassConfirm.Clear()
                End If
            ElseIf (SQL.SQLDataSet.Tables(0).Rows(0).Item("Password").Equals(edtOldPass.Text)) = False Then
                MsgBox("Old Password Incorrect", MsgBoxStyle.OkOnly, "Passwords ")
                edtNewPass.Clear()
                edtNewPassConfirm.Clear()
                edtOldPass.Clear()
                End

            End If

        End If
        MainMenu.Show()
    End Sub
End Class