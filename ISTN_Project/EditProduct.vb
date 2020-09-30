Public Class EditProduct
    Public SQL As New DataBaseControl

    Private Sub SaveButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveButton.Click
        If SQL.HasConnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            If (Login.isFieldBlank(PriceText.Text) = False) Then
                Dim price As Decimal = (Decimal.Parse(PriceText.Text)) / 100
                price = FormatCurrency(price, 2)
                Dim statement As String = "Update Product Set Price= '" & price & "',Quantity='" & Integer.Parse(Quatity.Value) & "'WHERE ProductID = '" & Products.ID & "'"
                SQL.RunQuery(statement)

                MessageBox.Show("Data updated")
            Else
                MessageBox.Show("Please fill in all fields", "Incomplete Details", MessageBoxButtons.OK)
            End If
        End If

        Me.Hide()
        Products.Show()

    End Sub

    Private Sub CancelButton_Click(sender As System.Object, e As System.EventArgs) Handles CancelButton.Click
        Products.Show()
        Me.Hide()
    End Sub

    Private Sub EditProduct_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class