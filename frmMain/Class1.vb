
Imports System.Data.SqlClient
Module Class1
    Public User As DataRow

    Public ds As New DataSet()

    Public ConnectionString As String = "workstation id=havdps03532.mssql.somee.com;packet size=4096;user id=havdps03532_SQLLogin_1;pwd=nu41rkxi7z;data source=havdps03532.mssql.somee.com;persist security info=False;initial catalog=havdps03532"

    Public Sub ExecuteNonQuery(Sql As String)
        Dim Connection As New SqlConnection(ConnectionString)
        Dim Command As New SqlCommand(Sql, Connection)
        Connection.Open()
        Command.ExecuteNonQuery()
        Connection.Close()
    End Sub

    Public Sub Fill(Sql As String, TableName As String)
        Dim Connection As New SqlConnection(ConnectionString)
        Dim DataAdapter As New SqlDataAdapter(Sql, Connection)
        If ds.Tables.Contains(TableName) Then
            ds.Tables(TableName).Clear()
        End If
        DataAdapter.Fill(ds, TableName)
        Connection.Close()
    End Sub
End Module

