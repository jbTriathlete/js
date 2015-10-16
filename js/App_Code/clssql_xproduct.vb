Imports photoViewWiz2.db

Public Class clssql_xproduct

    Public data As New clsdlo_xproduct
    Public Function getdata() As Boolean
        Dim ssql As String
        ssql = "Select * from x_product"
        data.getDataset(ssql)
        Return True
    End Function
End Class

