Public Class LoyaltyCustomers
    Public SQL As New DataBaseControl
    Friend ID As String
    Friend RowSelected As Integer

    Private Sub LoyaltyCustomers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load, MyBase.Activated
        If SQL.HasConnection = True Then

            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT * FROM LOYALTY")
        End If
        LoadGrid()
        PopulateCombo()


    End Sub

    Public Sub LoadGrid()
        Dim dbTable As New DataTable
        Dim bSource As New BindingSource
        SQL.SQLDataAap.SelectCommand = SQL.SQLComd
        SQL.SQLDataAap.Fill(dbTable)

        bSource.DataSource = dbTable
        SQL.SQLDataAap.Update(dbTable)
        dgvLCust.DataSource = dbTable
    End Sub

    Public Sub PopulateCombo()
        If SQL.HasConnection = True Then
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT LoyaltyNo, convert(varChar(6),LoyaltyNo) +' ' + Name + ' ' + Surname AS'Identify' FROM Loyalty")
            SQL.SQLDataAap.SelectCommand = SQL.SQLComd
            SQL.SQLDataAap.Fill(SQL.SQLDataSet)
            LoyaltyComboBox.DataSource = SQL.SQLDataSet.Tables(0)
            LoyaltyComboBox.ValueMember = "LoyaltyNo"
            LoyaltyComboBox.DisplayMember = "Identify"
        End If
    End Sub

    Private Sub SearchButton_Click(sender As System.Object, e As System.EventArgs) Handles SearchButton.Click
        If SQL.HasConnection Then
            Dim LCustID As Integer = Integer.Parse(LoyaltyComboBox.SelectedValue.ToString)
            If SQL.SQLDataSet IsNot Nothing Then
                SQL.SQLDataSet.Clear()
            End If
            SQL.RunQuery("SELECT * FROM Loyalty WHERE LoyaltyNo = '" & LCustID & "'")

            LoadGrid()
            PopulateCombo()
        End If
    End Sub

    Private Sub AddButton_Click(sender As System.Object, e As System.EventArgs) Handles AddButton.Click
        AddLCust.Show()
        Me.Hide()
    End Sub

    Private Sub EditButton_Click(sender As System.Object, e As System.EventArgs) Handles EditButton.Click
        EditLCust.Show()
        RowSelected = dgvLCust.CurrentRow.Index()
        ID = dgvLCust.Item(0, RowSelected).Value().ToString

        EditLCust.edtName.Text = dgvLCust.Item(1, RowSelected).Value()
        EditLCust.edtSurname.Text = dgvLCust.Item(2, RowSelected).Value()
        EditLCust.edtEmail.Text = dgvLCust.Item(3, RowSelected).Value()
        EditLCust.TellNoText.Text = dgvLCust.Item(4, RowSelected).Value()
        EditLCust.edtAddress1.Text = dgvLCust.Item(5, RowSelected).Value()
        EditLCust.edtAddress2.Text = dgvLCust.Item(6, RowSelected).Value()
        EditLCust.edtAddress3.Text = dgvLCust.Item(7, RowSelected).Value()
        EditLCust.dtpDOB.Value = dgvLCust.Item(8, RowSelected).Value()
        EditLCust.GenderComboBox.SelectedItem = dgvLCust.Item(9, RowSelected).Value()
        Me.Hide()
    End Sub

    Private Sub LoyaltyComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LoyaltyComboBox.SelectedIndexChanged
        SearchButton.Enabled = True
    End Sub

    Private Sub LoyaltyCustomers_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MainMenu.Show()
    End Sub
End Class