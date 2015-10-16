Imports photoViewWiz2.db

Namespace data
    Public Class clssql_xctrl
        ''  Inherits cls_dba
        Public data As New clsdlo_xctrl

        Public Function getdata() As Boolean
            Dim ssql As String
            ssql = "Select * from x_ctrl"
            data.getDataset(ssql)
            Return True
        End Function

    End Class
End Namespace
