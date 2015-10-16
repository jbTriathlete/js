Public Class clsdlo_xproduct
    Inherits db.cls_dba

    'Public z_index As Integer

    Public Property id() As String
        Get
            Return ds.Tables(0).Rows.Item(z_index).Item("xproduct_id")
        End Get
        Set(value As String)
            ds.Tables(0).Rows.Item(z_index).Item("xproduct_id") = value
        End Set
    End Property
    Public Property item() As String
        Get
            Return ds.Tables(0).Rows.Item(z_index).Item("xproduct_item")
        End Get
        Set(value As String)
            ds.Tables(0).Rows.Item(z_index).Item("xproduct_item") = value
        End Set
    End Property
    Public Property price() As Decimal
        Get
            Return ds.Tables(0).Rows.Item(z_index).Item("xproduct_price")
        End Get
        Set(value As Decimal)
            ds.Tables(0).Rows.Item(z_index).Item("xproduct_price") = value
        End Set
    End Property
    Public Property visible() As Boolean
        Get
            Return ds.Tables(0).Rows.Item(z_index).Item("xproduct_visible")
        End Get
        Set(value As Boolean)
            ds.Tables(0).Rows.Item(z_index).Item("xproduct_visible") = visible
        End Set
    End Property
    Public Property extend() As Boolean
        Get
            Return ds.Tables(0).Rows.Item(z_index).Item("xproduct_extend")
        End Get
        Set(value As Boolean)
            ds.Tables(0).Rows.Item(z_index).Item("xproduct_extend") = value
        End Set
    End Property
    Public Property division() As Boolean
        Get
            Return ds.Tables(0).Rows.Item(z_index).Item("xproduct_division")
        End Get
        Set(value As Boolean)
            ds.Tables(0).Rows.Item(z_index).Item("xproduct_division") = value
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
