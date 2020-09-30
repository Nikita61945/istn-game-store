Public Class Login
    Public JobLevel As String
    Public EmployeeID As Integer
    Public SQL As New DataBaseControl
    'Checks if Fields are blank before allowing them to be saved
    Public Function isFieldBlank(ByVal CheckField As String)
        If CheckField.Length = 0 Then
            Return True
        Else
            Return False
        End If

    End Function




    Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click
        'Checks if fields are blank
        'Checks to see user and password is valid
        'the obtains Job level from the employee table and sets job level
        'if job level is manager then go to Main menu 
        'if job level is sales then go straight to new sales from
        If isFieldBlank(EditEmployee.Text) = False And isFieldBlank(EditLCust.Text) = False Then
            If SQL.HasConnection = True Then
                If isValid() Then
                    MainMenu.Show()
                    Me.Hide()
                End If
            End If

            Else
                MessageBox.Show("Please enter details", "No Details Entered", MessageBoxButtons.OK)

            End If



    End Sub
    Private Function isValid() As Boolean
        If SQL.SQLDataSet IsNot Nothing Then
            SQL.SQLDataSet.Clear()
        End If

        SQL.RunQuery("SELECT EmployeeID, Password , JobLevel FROM Employee WHERE EmployeeID= '" & edtUsername.Text & "' ")

        If SQL.SQLDataSet.Tables(0).Rows.Count = 1 Then
            'SQL.SQLDataSet.Clear()
            ' SQL.RunQuery("SELECT Count(*) FROM Employee WHERE Name= '" & edtUsername.Text & "' " & _
            '    " AND Password = '" & edtPassword.Text & "'COLLATE SQL_Latin1_General_CP1_CS_AS")
            If SQL.SQLDataSet.Tables(0).Rows(0).Item("Password") = edtPassword.Text Then
                JobLevel = SQL.SQLDataSet.Tables(0).Rows(0).Item("JobLevel")
                EmployeeID = Int32.Parse(edtUsername.Text)
                Return True
            Else
                MsgBox("Password incorrect", MsgBoxStyle.OkOnly, "Login Failed")
                edtPassword.Clear()
                Return False
            End If
        Else
            MessageBox.Show("Invalid Usercode", "Login Failed")
            edtPassword.Clear()
            edtUsername.Clear()
            Return False
        End If
        Return False
    End Function

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Login_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class
