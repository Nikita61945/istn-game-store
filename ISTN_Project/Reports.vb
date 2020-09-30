Public Class Reports
    Public SQL As New DataBaseControl

    Private Sub EnableDatePicker(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateBetweenRadioButton.CheckedChanged
        If DateBetweenRadioButton.Checked Then
            EndDate.Enabled = True
            BeginDate.Enabled = True
            Label1.Enabled = True
        Else
            EndDate.Enabled = False
            BeginDate.Enabled = False
            Label1.Enabled = False
        End If
        If SQL.HasConnection Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            If DateBetweenRadioButton.Checked Then
                SQL.RunQuery("SELECT Date , Amount FROM SALE WHERE Date Between '" & Date.Parse(BeginDate.Value) & "' AND '" & Date.Parse(EndDate.Value) & "'")
            End If
            LoadSalesGrid()
        End If


    End Sub

    Private Sub TSRB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSRB.CheckedChanged
        If SQL.HasConnection Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            If TSRB.Checked Then
                SQL.RunQuery("SELECT EmployeeID, SUM(Amount) As 'TotalSales' FROM Sale Group BY EmployeeID")
            End If
            LoadEmployeeGrid()
        End If
    End Sub

    Public Sub LoadEmployeeGrid()
        Dim dbTable As New DataTable
        Dim bSource As New BindingSource
        SQL.SQLDataAap.SelectCommand = SQL.SQLComd
        SQL.SQLDataAap.Fill(dbTable)

        bSource.DataSource = dbTable
        SQL.SQLDataAap.Update(dbTable)
        dgvEmployee.DataSource = dbTable
        PopCombo()
    End Sub

    Public Sub LoadProductGrid()
        Dim dbTable As New DataTable
        Dim bSource As New BindingSource
        SQL.SQLDataAap.SelectCommand = SQL.SQLComd
        SQL.SQLDataAap.Fill(dbTable)

        bSource.DataSource = dbTable
        SQL.SQLDataAap.Update(dbTable)
        dgvProducts.DataSource = dbTable
    End Sub

    Public Sub LoadSalesGrid()
        Dim dbTable As New DataTable
        Dim bSource As New BindingSource
        SQL.SQLDataAap.SelectCommand = SQL.SQLComd
        SQL.SQLDataAap.Fill(dbTable)

        bSource.DataSource = dbTable
        SQL.SQLDataAap.Update(dbTable)
        dgvSaleRep.DataSource = dbTable
    End Sub
    Private Sub THRB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles THRB.CheckedChanged
        If SQL.HasConnection Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            If THRB.Checked Then
                SQL.RunQuery("SELECT EmployeeID, SUM(HoursWorked) As 'TotalHoursWorked' FROM Register Group BY EmployeeID")
            End If
            LoadEmployeeGrid()
        End If
    End Sub

    Private Sub SforERB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SforERB.CheckedChanged
        If SQL.HasConnection Then
            Dim EmployyeeID As Integer = Integer.Parse(EmployeeComboBox.SelectedValue.ToString)

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            If SforERB.Checked Then
                SQL.RunQuery("SELECT EmployeeID ,Date, SUM(Amount) As 'Day Sales' FROM Sale WHERE EmployeeID = '" & EmployyeeID & "' Group BY EmployeeID , Date ORDER BY Date")
            End If
            LoadEmployeeGrid()
        End If
    End Sub

    Private Sub Reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ist2ggDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.Ist2ggDataSet.Product)
        'TODO: This line of code loads data into the 'Ist2ggDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Ist2ggDataSet.Employee)
        'TODO: This line of code loads data into the 'Ist2ggDataSet.Sale' table. You can move, or remove it, as needed.
        PopCombo()
        SforERB.Enabled = False
        HRforERB.Enabled = False
    End Sub
    Public Sub PopCombo()
        If SQL.HasConnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT EmployeeID, convert(varChar(6),EmployeeID) +' ' + Name + ' ' + Surname AS'Identify' FROM EMPLOYEE")
            SQL.SQLDataAap.SelectCommand = SQL.SQLComd
            SQL.SQLDataAap.Fill(SQL.SQLDataSet)
            EmployeeComboBox.DataSource = SQL.SQLDataSet.Tables(0)
            EmployeeComboBox.ValueMember = "EmployeeID"
            EmployeeComboBox.DisplayMember = "Identify"

        End If
    End Sub
    Private Sub HRforERB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HRforERB.CheckedChanged
        If SQL.HasConnection Then
            Dim EmployyeeID As Integer = Integer.Parse(EmployeeComboBox.SelectedValue.ToString)
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            If HRforERB.Checked Then
                SQL.RunQuery("SELECT Date , HoursWorked FROM Register WHERE EmployeeID = '" & EmployyeeID & "' Order BY Date ASC")
            End If
            LoadEmployeeGrid()
            PopCombo()
        End If
    End Sub

    Private Sub OneMonthRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OneMonthRadioButton.CheckedChanged
        If SQL.HasConnection Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            Dim StartDate As String = Date.Parse(Date.Today).ToString("yyyy'/'MM'/'dd")
            Dim EndDate As String = Date.Parse(Date.Today.AddDays(-30)).ToString("yyyy'/'MM'/'dd")
            
            Dim s As String = "SELECT Date,Amount FROM SALE WHERE Date Between  '" & EndDate & "' and '" & StartDate & "'"

            If OneMonthRadioButton.Checked Then
                SQL.RunQuery(s)
            End If
            LoadSalesGrid()
        End If
    End Sub

    Private Sub QuatitySoldRB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuatitySoldRB.CheckedChanged
        If SQL.HasConnection Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            If QuatitySoldRB.Checked Then
                SQL.RunQuery("SELECT ProductID,ProductName ,COUNT(ProductName) AS 'Quantity Sold' FROM SaleItem GROUP BY ProductID,ProductName ORDER BY ProductName ASC")
            End If
            LoadProductGrid()
        End If
    End Sub

    Private Sub QuatityLeftRB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuatityLeftRB.CheckedChanged
        If SQL.HasConnection Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            If QuatityLeftRB.Checked Then
                SQL.RunQuery("SELECT ProductID, Name , Quantity FROM Product G")
            End If
            LoadProductGrid()
        End If
    End Sub

    Private Sub BestSellerRB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BestSellerRB.CheckedChanged
        If SQL.HasConnection Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            If BestSellerRB.Checked Then
                SQL.RunQuery("SELECT Product.ProductID,Product.Name,Product.Platform, " & _
                             "Count(SaleItem.ProductID) AS 'Quantity' FROM PRODUCT inner join SALEITEM " & _
                             " on product.productid=saleitem.productid Group BY product.ProductID " &
                             ",Product.name,product.platform,saleitem.productid order by 4 desc")
            End If
            LoadProductGrid()
        End If
    End Sub

    Private Sub ThreeMonthRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThreeMonthRadioButton.CheckedChanged
        If SQL.HasConnection Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            Dim StartDate As Date = Date.Today.AddDays(-1)
            Dim EndDate As Date = Date.Today.AddDays(-90)

            If ThreeMonthRadioButton.Checked Then
                SQL.RunQuery("SELECT Date , Amount FROM SALE WHERE Date Between '" & StartDate & "' AND '" & EndDate & "'")
            End If
            LoadSalesGrid()
        End If
    End Sub

    Private Sub EmployeeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeComboBox.SelectedIndexChanged
        SforERB.Enabled = True
        HRforERB.Enabled = True
    End Sub

    Private Sub ReStockRB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReStockRB.CheckedChanged
        If SQL.HasConnection Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            If ReStockRB.Checked Then
                SQL.RunQuery("SELECT Product.ProductID,Product.Name,Product.Platform, " & _
                             "Product.quantity FROM PRODUCT " &
                             "where Product.quantity < 2 order by 2")
            End If
            LoadProductGrid()
        End If


    End Sub

    Private Sub WorstSellerRB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorstSellerRB.CheckedChanged
        If SQL.HasConnection Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            If WorstSellerRB.Checked Then
                SQL.RunQuery("SELECT Product.ProductID,Product.Name,Product.Platform, " & _
                             "Count(SaleItem.ProductID) AS 'Quantity' FROM PRODUCT inner join SALEITEM " & _
                             " on product.productid=saleitem.productid Group BY product.ProductID " &
                             ",Product.name,product.platform,saleitem.productid order by 4")
            End If
            LoadProductGrid()
        End If

    End Sub

    Private Sub EmployeeTc_Selected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles EmployeeTc.Selected
        PopCombo()
    End Sub

    Private Sub Reports_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Hide()
        MainMenu.Show()
    End Sub
End Class