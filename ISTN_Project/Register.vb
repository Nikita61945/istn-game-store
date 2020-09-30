Public Class Register
    Public SQL As New DataBaseControl


    Private Sub RecordButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecordButton.Click
        Dim HoursWorked As Integer
        Dim regNo As String
        Dim EmployeeID As Integer
        If SQL.HasConnection = True Then
            SQL.RunQuery("SELECT EmployeeID , Name  FROM EMPLOYEE WHERE EmployeeID = '" & (ENameComboBox.SelectedValue) & "'")
            If SQL.SQLDataSet.Tables(0).Rows.Count = 1 Then
                EmployeeID = SQL.SQLDataSet.Tables(0).Rows(0).Item("EmployeeID")
                regNo = (dtpRegister.Value.Date.Year).ToString + (dtpRegister.Value.Date.DayOfYear).ToString + (EmployeeID.ToString)
                HoursWorked = (dtpTimeOut.Value.Hour - dtpTimeIn.Value.Hour)
            End If
            SQL.SQLDataSet.Clear()

            SQL.RunQuery("Select * FROM REGISTER WHERE RegisterNo = '" & regNo & "'")
            If SQL.SQLDataSet.Tables(0).Rows.Count = 0 Then
                SQL.SQLDataSet.Clear()
                SQL.RunQuery("INSERT INTO REGISTER(RegisterNo,Date,HoursWorked,EmployeeID) " & _
                             "Values('" & regNo & "','" & Date.Parse(dtpRegister.Value) & "','" & HoursWorked & "','" & EmployeeID & "')")
            Else
                MsgBox("Hours Worked by Employee already caputured", MsgBoxStyle.Information, "Deatails already Captured")
            End If



        End If
        If SQL.SQLDataSet IsNot Nothing Then
            SQL.SQLDataSet.Clear()
        End If

        Me.Close()
        MainMenu.Show()

    End Sub

    Private Sub Register_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If SQL.HasConnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT EmployeeID, convert(varChar(6),EmployeeID) +' ' + Name + ' ' + Surname AS 'Identify' FROM EMPLOYEE")
            SQL.SQLDataAap.SelectCommand = SQL.SQLComd
            SQL.SQLDataAap.Fill(SQL.SQLDataSet)
            ENameComboBox.DataSource = SQL.SQLDataSet.Tables(0)
            ENameComboBox.ValueMember = "EmployeeID"
            ENameComboBox.DisplayMember = "Identify"

        End If


    End Sub

    Private Sub CancelButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton1.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub Register_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MainMenu.Show()
    End Sub
End Class