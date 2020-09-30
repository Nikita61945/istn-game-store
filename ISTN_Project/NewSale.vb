Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class NewSale
    Public SQL As New DataBaseControl
    Public dt As DataTable
    Public dr As DataRow
    Public ds As New DataSet
    Public TotalAmount As Decimal
    Public LoyaltyDisc As Decimal = 0
    Public LoyaltyNo As Integer
    Dim FinalAmount As Decimal = 0

    Private Sub NewSaleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewSaleButton.Click
        edtLoyaltyNo.Enabled = True
        ProductsComboBox.Enabled = True
        AddButton.Enabled = True
        CancelSaleButton.Enabled = True
        RemoveItemButton.Enabled = True
        NewSaleButton.Enabled = False
        If dt.Rows.Count > 0 Then
            dt.Rows.Clear()
        End If

    End Sub



    Private Sub edtLoyaltyNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtLoyaltyNo.Leave
        'check  to see loyalty customer exists
        'if it exists will display no of points sutomer has
        ' enables the loyalty customer discount field
        If SQL.HasConnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("Select * FROM LOYALTY WHERE LoyaltyNo = '" & Integer.Parse(edtLoyaltyNo.Text) & "'")
            If SQL.SQLDataSet.Tables(0).Rows.Count = 1 Then
                LoyaltyDiscText.Enabled = True
                SQL.SQLDataSet.Clear()
                SQL.RunQuery("Update Loyalty Set LoyaltyPoints = LoyaltyPoints + 10 WHERE LoyaltyNo = '" & Integer.Parse(edtLoyaltyNo.Text) & "'")
                LoyaltyNo = edtLoyaltyNo.Text
            Else
                MessageBox.Show("Loyalty Customer doesnt exist", "Invalid Custommer")
            End If
            UpdateFields()
        End If


    End Sub

    Private Sub EndSaleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndSaleButton.Click
        MessageBox.Show("Total due for sale : " + TotalinVATText.Text, "End of Sale", MessageBoxButtons.OK)
        If SQL.HasConnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("Select MAX(SaleID) AS HighestID FROM Sale")
            Dim ID As Integer = 0

            If IsDBNull(SQL.SQLDataSet.Tables(0).Rows(0).Item("HighestID")) Then
                ID = 1
            Else
                ID = SQL.SQLDataSet.Tables(0).Rows(0).Item("HighestID") + 1
            End If


            SQL.SQLDataSet.Clear()

            If (edtLoyaltyNo.Text).Equals("0") Then
                SQL.RunQuery("INSERT INTO Sale(SaleID, Date,EmployeeID,Amount)" & _
                           "VALUES ('" & ID & "','" & Date.Today & "','" & Login.EmployeeID & "' , '" & FinalAmount & "')")
            Else
                SQL.RunQuery("INSERT INTO Sale(SaleID, Date,EmployeeID,Amount,LoyaltyNo)" & _
                           "VALUES ('" & ID & "','" & Date.Today & "','" & Login.EmployeeID & "' , '" & FinalAmount & "','" & LoyaltyNo & "')")
            End If



            For i = 0 To ds.Tables(0).Rows.Count - 1 Step 1
                Dim ProductID As Integer = ds.Tables(0).Rows(i).Item(0)
                Dim ProductName As String = ds.Tables(0).Rows(i).Item(1)
                Dim ProductValue As Decimal = ds.Tables(0).Rows(i).Item(2)
                Dim SaleItemID As Integer = Integer.Parse((ID.ToString + i.ToString))


                SQL.SQLDataSet.Clear()
                SQL.RunQuery("Insert into SaleItem(SaleItemID,SaleID,ProductID,Amount,ProductName) " & _
                             "VALUES('" & SaleItemID & "','" & ID & "','" & ProductID & "','" & ProductValue & "','" & ProductName & "')")
                SQL.SQLDataSet.Clear()
                SQL.RunQuery("Update Product Set Quantity = Quantity -1 WHERE ProductID = '" & ProductID & "'")

            Next

            SQL.SQLDataSet.Clear()

        End If

        Me.Hide()
        NewSaleButton.Enabled = True
        MainMenu.Show()


    End Sub

    Public Sub UpdateFields()
        If SQL.HasConnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT ProductID , Name +' ' + Platform AS 'Description', Price FROM PRODUCT")
            SQL.SQLDataAap.SelectCommand = SQL.SQLComd
            SQL.SQLDataAap.Fill(SQL.SQLDataSet)
            ProductsComboBox.DataSource = SQL.SQLDataSet.Tables(0)
            ProductsComboBox.ValueMember = "ProductID"
            ProductsComboBox.DisplayMember = "Description"

            TotalText.Text = TotalAmount.ToString
            Dim VAT As Integer = TotalAmount * 0.14
            VATText.Text = VAT.ToString

            If (LoyaltyDiscText.Enabled) Then
                LoyaltyDiscText.Text = LoyaltyDisc.ToString
                LoyaltyDisc = TotalAmount * 0.2
            End If
            FinalAmount = (TotalAmount + VAT) - LoyaltyDisc
            TotalinVATText.Text = FinalAmount.ToString
        End If
    End Sub

    Private Sub NewSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateFields()
        GridSetUp()
        TotalAmount = 0
    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        Dim EmployeeID As String = ProductsComboBox.SelectedValue.ToString
        If SQL.HasConnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT ProductID , Name , Price FROM PRODUCT WHERE ProductID = '" & Int32.Parse(EmployeeID) & "'")
        End If

        dr = dt.NewRow
        dr("Product ID") = SQL.SQLDataSet.Tables(0).Rows(0).Item("ProductID")
        dr("Product Name") = SQL.SQLDataSet.Tables(0).Rows(0).Item("Name")
        dr("Product Amount") = SQL.SQLDataSet.Tables(0).Rows(0).Item("Price")
        dt.Rows.Add(dr)

        dt.AcceptChanges()
        dgvSales.Refresh()
        TotalAmount += Decimal.Parse(SQL.SQLDataSet.Tables(0).Rows(0).Item("Price").ToString)
        EndSaleButton.Enabled = True
        UpdateFields()
    End Sub

    Public Sub GridSetUp()

        Dim IDCol As DataColumn
        Dim PNameCol As DataColumn
        Dim PAmountCol As DataColumn
        Dim Bind As New BindingSource

        dt = New DataTable()
        IDCol = New DataColumn("Product ID", Type.GetType("System.Int32"))
        PNameCol = New DataColumn("Product Name", Type.GetType("System.String"))
        PAmountCol = New DataColumn("Product Amount", Type.GetType("System.Decimal"))

        dt.Columns.Add(IDCol)
        dt.Columns.Add(PNameCol)
        dt.Columns.Add(PAmountCol)
        ds.Tables.Add(dt)

        Bind.DataSource = dt
        dgvSales.DataSource = dt
    End Sub

    Private Sub RemoveItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveItemButton.Click
        Dim row As Integer = dgvSales.CurrentCell.RowIndex
        If MessageBox.Show("Are you want to remove  ?", "Removing an Item", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            TotalAmount -= ds.Tables(0).Rows(row).Item(2) + (ds.Tables(0).Rows(row).Item(2) * 0.14)
            ds.Tables(0).Rows.RemoveAt(row)
            ds.AcceptChanges()
            UpdateFields()
        End If
    End Sub

    Private Sub CancelSaleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelSaleButton.Click
        Me.Hide()
    End Sub

    Private Sub NewSale_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MainMenu.Show()
    End Sub

    Private Sub NewSale_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        If dt.Rows.Count > 0 Then
            dt.Rows.Clear()
        End If
        TotalAmount = 0
        edtLoyaltyNo.Enabled = False
        ProductsComboBox.Enabled = False
        AddButton.Enabled = False
        CancelSaleButton.Enabled = False
        RemoveItemButton.Enabled = False
        NewSaleButton.Enabled = True
        UpdateFields()

    End Sub
End Class