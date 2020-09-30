Public Class MainMenu

    Private Sub MainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ID As String = Login.EmployeeID.ToString
        Label1.Text = "Welcome : " + ID
        If ((Login.JobLevel = "Manager") = False) Then
            btnEmployee.Enabled = False
            btnReports.Enabled = False
        End If
    End Sub

 
    Private Sub btnSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSale.Click
        NewSale.Show()
        Me.Hide()
    End Sub

    Private Sub btnLCust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLCust.Click
        LoyaltyCustomers.Show()
        Me.Hide()
    End Sub

    Private Sub btnProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProducts.Click
        Products.Show()
        Me.Hide()
    End Sub

    Private Sub btnEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployee.Click
        Employees.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click
        Me.Hide()
        Application.Exit()
    End Sub

    Private Sub btnPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPass.Click
        PassChange.Show()
    End Sub

    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        Reports.Show()
    End Sub
End Class