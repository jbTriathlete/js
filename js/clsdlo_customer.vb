Public Class clsdlo_customer
    Inherits db.cls_dba

    ' Public z_index As Integer

    Public Property id() As Integer
        Get
            Return ds.Tables(0).Rows.Item(z_index).Item("customer_id")
        End Get
        Set(value As Integer)
            ds.Tables(0).Rows.Item(z_index).Item("customer_id") = value
        End Set
    End Property

    Public Property name() As String
        Get
            Return ds.Tables(0).Rows.Item(z_index).Item("customer_name")
        End Get
        Set(value As String)
            ds.Tables(0).Rows.Item(z_index).Item("customer_name") = value
        End Set
    End Property
    Public Property maddress() As String
        Get
            Return ds.Tables(0).Rows.Item(z_index).Item("customer_maddress")
        End Get
        Set(value As String)
            ds.Tables(0).Rows.Item(z_index).Item("customer_maddress") = value
        End Set
    End Property
    Public Property mcity() As String
        Get
            Return ds.Tables(0).Rows.Item(z_index).Item("customer_mcity")
        End Get
        Set(value As String)
            ds.Tables(0).Rows.Item(z_index).Item("customer_mcity") = value
        End Set
    End Property
    Public Property mstate() As String
        Get
            Return ds.Tables(0).Rows.Item(z_index).Item("customer_mcity")
        End Get
        Set(value As String)
            ds.Tables(0).Rows.Item(z_index).Item("customer_mcity") = value
        End Set
    End Property
    Public Property mzip() As String
        Get
            Return ds.Tables(0).Rows.Item(z_index).Item("customer_mzip")
        End Get
        Set(value As String)
            ds.Tables(0).Rows.Item(z_index).Item("customer_mzip") = value
        End Set
    End Property
    Public Property phone() As String
        Get
            Return ds.Tables(0).Rows.Item(z_index).Item("customer_phone")
        End Get
        Set(value As String)
            ds.Tables(0).Rows.Item(z_index).Item("customer_phone") = value
        End Set
    End Property
    Public Property email() As String
        Get
            Return ds.Tables(0).Rows.Item(z_index).Item("customer_email")
        End Get
        Set(value As String)
            ds.Tables(0).Rows.Item(z_index).Item("customer_email") = value
        End Set
    End Property
    Public ReadOnly Property count() As Integer

        Get
            Return ds.Tables(0).Rows.Count
        End Get

    End Property
    Public Property index() As Integer

        Get
            Return z_index
        End Get
        Set(value As Integer)
            z_index = value
        End Set
    End Property
End Class
