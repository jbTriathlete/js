Public Class clsdlo_xctrl
    Inherits db.cls_dba

    ' Public z_index As Integer

    Public Property workfolder() As String
        Get
            Return ds.Tables(0).Rows.Item(z_index).Item("xctrl_workfolder")
        End Get
        Set(value As String)
            ds.Tables(0).Rows.Item(z_index).Item("xctrl_workfolder") = value
        End Set
    End Property

    Public Property ordersfolder() As String
        Get
            Return ds.Tables(0).Rows.Item(z_index).Item("xctrl_ordersfolder")
        End Get
        Set(value As String)
            ds.Tables(0).Rows.Item(z_index).Item("xctrl_ordersfolder") = value
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
