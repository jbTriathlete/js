Imports photoViewWiz2.db

Public Class clssql_orders
    Inherits cls_dba
    Public data As New clsdlo_orders
    Public Function getdata() As Boolean
        Dim ssql As String
        ssql = "Select * from base_orders"
        getDataset(ssql)
        Return True
    End Function


    Public Function getdata(ByVal orderid As Integer) As Boolean
        Dim ssql As String
        ssql = "Select * from base_orders where order_id = " & orderid
        getDataset(ssql)
        Return True
    End Function
End Class
