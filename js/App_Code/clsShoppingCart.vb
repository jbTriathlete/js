
Public Class clsShoppingCart
    Public cart As New Collection
    Public Function addItem(ByVal pic As String, ByVal productId As String, ByVal quantity As Integer) As Boolean
        Dim cartitem As New clsShoppingItem
        cartitem.pic = pic
        cartitem.productId = productId
        cartitem.quantity = quantity
        cart.Add(cartitem)
        Return True
    End Function

End Class
Public Class clsShoppingItem
    Public pic As String
    Public productId As String
    Public quantity As Integer
End Class
