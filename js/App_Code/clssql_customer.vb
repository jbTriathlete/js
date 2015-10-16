Imports db

Public Class clssql_customer
    Inherits cls_dba
    Public data As New clsdlo_customer

    Public Function getdata() As Boolean
        Dim ssql As String
        ssql = "Select * from base_customers"
        getDataset(ssql)
        Return True
    End Function

    Public Function getdata(ByVal customerid As Integer) As Boolean
        Dim ssql As String
        ssql = "Select * from base_customers where customer_id = " & customerid
        getDataset(ssql)
        Return True
    End Function

    Public Function getdata(ByVal customername As String) As Boolean
        Dim ssql As String
        ssql = "Select * from base_customers where customer_name = " & customername
        getDataset(ssql)
        Return True
    End Function
End Class
