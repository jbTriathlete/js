Public Class clsdlo_orders
    Inherits db.cls_dba

    'Public index As Integer

    Public Property id() As Integer
        Get
            Return ds.Tables(0).Rows.Item(z_index).Item("orders_id")
        End Get
        Set(value As Integer)
            ds.Tables(0).Rows.Item(z_index).Item("orders_id") = value
        End Set
    End Property

    Public Property customerid() As Integer
        Get
            Return ds.Tables(0).Rows.Item(z_index).Item("orders_customerid")
        End Get
        Set(value As Integer)
            ds.Tables(0).Rows.Item(z_index).Item("orders_customerid") = value
        End Set
    End Property
    Public Property pic() As String
        Get
            Return ds.Tables(0).Rows.Item(z_index).Item("orders_pic")
        End Get
        Set(value As String)
            ds.Tables(0).Rows.Item(z_index).Item("orders_pic") = value
        End Set
    End Property
    Public Property notes() As String
        Get
            Return ds.Tables(0).Rows.Item(z_index).Item("orders_notes")
        End Get
        Set(value As String)
            ds.Tables(0).Rows.Item(z_index).Item("orders_notes") = value
        End Set
    End Property
    Public Property quantity() As Integer
        Get
            Return ds.Tables(0).Rows.Item(z_index).Item("orders_quantity")
        End Get
        Set(value As Integer)
            ds.Tables(0).Rows.Item(z_index).Item("orders_quantity") = value
        End Set
    End Property
    Public Property itemtotal() As Integer
        Get
            Return ds.Tables(0).Rows.Item(z_index).Item("orders_itemtotal")
        End Get
        Set(value As Integer)
            ds.Tables(0).Rows.Item(z_index).Item("orders_itemtotal") = value
        End Set
    End Property
    Public Property xproductid() As Integer
        Get
            Return ds.Tables(0).Rows.Item(z_index).Item("orders_xproductid")
        End Get
        Set(value As Integer)
            ds.Tables(0).Rows.Item(z_index).Item("orders_xproductid") = value
        End Set
    End Property
    Public Property dt() As Date
        Get
            Return ds.Tables(0).Rows.Item(z_index).Item("orders_date")
        End Get
        Set(value As Date)
            ds.Tables(0).Rows.Item(z_index).Item("orders_date") = value
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
