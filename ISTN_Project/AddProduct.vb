Public Class AddProduct
    Public SQL As New DataBaseControl

    Private Sub AddProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''   PlatformComboBox.Items.IndexOf = 0
    End Sub

    Private Sub AddButton_Click(sender As System.Object, e As System.EventArgs) Handles AddButton.Click
        If (Login.isFieldBlank(edtName.Text) = False) And (Login.isFieldBlank(PriceText.Text) = False) And (Quatity.Value.Equals(0) = False) Then
            If SQL.HasConnection = True Then
                If SQL.SQLDataSet IsNot Nothing Then
                    SQL.SQLDataSet.Clear()
                End If

                If (PlatformComboBox.SelectedIndex.ToString = "0") Then ''xbox
                    SQL.RunQuery("SELECT MAX(ProductID) As HighestID FROM Product WHERE Platform LIKE 'X%' ")
                ElseIf (PlatformComboBox.SelectedIndex.ToString = "1") Then 'ps4
                    SQL.RunQuery("SELECT MAX(ProductID) As HighestID FROM Product WHERE Platform LIKE 'P%' ")
                Else
                    SQL.RunQuery("SELECT MAX(ProductID) As HighestID FROM Product WHERE Platform LIKE 'N%' ")

                End If
                Dim ID As Integer = SQL.SQLDataSet.Tables(0).Rows(0).Item("HighestID") + 1

                Dim price As Decimal = (Decimal.Parse(PriceText.Text)) / 100
                price = FormatCurrency(price, 2)
                Dim platform As String = (PlatformComboBox.SelectedItem).ToString

                SQL.RunQuery("INSERT INTO Product(ProductID,Name,Price,Platform,Quantity) VALUES('" & ID & "','" & edtName.Text & "','" & price & "','" & platform & "','" & Quatity.Value.ToString & "')")
                MessageBox.Show("Data saved")
                Products.Show()
                Me.Hide()


            Else
                MessageBox.Show("Please fill in all fields", "Incomplete Details", MessageBoxButtons.OK)
            End If
        End If


    End Sub

    Private Sub CancelButton_Click(sender As System.Object, e As System.EventArgs) Handles CancelButton.Click
        Products.Show()
        Me.Hide()

    End Sub

End Class