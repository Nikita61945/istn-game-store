Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class DataBaseControl
    Public SQLCon As New SqlConnection With {.ConnectionString = "Data Source = 146.230.177.46\ist2; Initial Catalog=ist2gg;User ID=ist2gg; Password='f8j0di'"}

    Public SQLComd As SqlCommand
    Public SQLDataAap As SqlDataAdapter
    Public SQLDataSet As DataSet

    Public Function HasConnection() As Boolean

        Try
            SQLCon.Open()

            SQLCon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Sub RunQuery(Query As String)

   
        Try
            SQLCon.Open()

            SQLComd = New SqlCommand(Query, SQLCon)
            SQLDataAap = New SqlDataAdapter(SQLComd)
            SQLDataSet = New DataSet
            SQLDataAap.Fill(SQLDataSet)

            SQLCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQLCon.State = ConnectionState.Open Then
                SQLCon.Close()
            End If
        End Try
    End Sub

   


End Class
