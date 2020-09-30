Public Class Products
    Private SQL As New DataBaseControl
    Friend ID As String
    Friend rowClicked As Integer

    Public Sub populateCombo()
        If SQL.HasConnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("SELECT ProductID, convert(varchar(6),ProductID)+' '+ Name AS 'Identify' FROM Product")

            SQL.SQLDataAap.SelectCommand = SQL.SQLComd
            SQL.SQLDataAap.Fill(SQL.SQLDataSet)
            ProductsComboBox.DataSource = SQL.SQLDataSet.Tables(0)
            ProductsComboBox.ValueMember = "ProductID"
            ProductsComboBox.DisplayMember = "Identify"


        End If
    End Sub


    Private Sub GetProducts()
        Dim dbTable As New DataTable
        Dim bSource As New BindingSource
        SQL.SQLDataAap.SelectCommand = SQL.SQLComd
        SQL.SQLDataAap.Fill(dbTable)

        bSource.DataSource = dbTable
        SQL.SQLDataAap.Update(dbTable)
        dgvProducts.DataSource = dbTable



    End Sub

    Private Sub AddButton_Click(sender As System.Object, e As System.EventArgs) Handles AddButton.Click
        AddProduct.Show()
        Me.Hide()

    End Sub




    Private Sub SearchButton_Click(sender As System.Object, e As System.EventArgs) Handles SearchButton.Click
        Dim id As Integer = Integer.Parse(ProductsComboBox.SelectedValue.ToString)
        SQL.SQLDataSet.Clear()

        Dim query As String = "SELECT * FROM Product WHERE ProductID = '" & id & "'"
        SQL.RunQuery(query)
        GetProducts()
        populateCombo()

    End Sub

    Private Sub refreshButton_Click(sender As System.Object, e As System.EventArgs) Handles RefreshButton.Click
        If SQL.HasConnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()

            End If
            Dim revert As String = "SELECT * FROM Product"
            SQL.RunQuery(revert)
            GetProducts()
            populateCombo()

        End If
    End Sub


    Private Sub Products_Load_1(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dgvProducts.AutoResizeColumns()

        If SQL.HasConnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("SELECT * FROM Product")

        End If

        GetProducts()
        populateCombo()
    End Sub

    Private Sub UpdateButton_Click_1(sender As System.Object, e As System.EventArgs) Handles UpdateButton.Click
        EditProduct.Show()
        rowClicked = dgvProducts.CurrentRow.Index()
        ID = dgvProducts.Item(0, rowClicked).Value()

        EditProduct.edtName.Text = dgvProducts.Item(1, rowClicked).Value
        EditProduct.PriceText.Text = dgvProducts.Item(2, rowClicked).Value
        EditProduct.PlatformComboBox.SelectedItem = dgvProducts.Item(3, rowClicked).Value
        EditProduct.Quatity.Value = dgvProducts.Item(4, rowClicked).Value

    End Sub

    Private Sub PlatformRB_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles PlatformRB.CheckedChanged
        If SQL.HasConnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT * FROM Product ORDER BY Platform ASC")
        End If

        GetProducts()
    End Sub

    Private Sub PriceAscRB_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles PriceAscRB.CheckedChanged
        If SQL.HasConnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT * FROM Product ORDER BY Price DESC")
        End If
        GetProducts()
    End Sub

    Private Sub PriceDescRB_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles PriceDescRB.CheckedChanged
        If SQL.HasConnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT * FROM Product ORDER BY Price ASC")
        End If
        GetProducts()
    End Sub

    Private Sub ProductsComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ProductsComboBox.SelectedIndexChanged
        SearchButton.Enabled = True
    End Sub

    Private Sub Products_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        If SQL.HasConnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If

            SQL.RunQuery("SELECT * FROM Product")

        End If

        GetProducts()
        populateCombo()
    End Sub

    Private Sub Products_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MainMenu.Show()
    End Sub
End Class