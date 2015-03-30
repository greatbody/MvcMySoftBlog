Public Class GlobalBase
    Public Shared Function GetUserID() As Integer
        Return 1
    End Function
    Public Shared Function GetShortTitle(ByVal Title As String, ByVal length As Integer) As String
        Return PublicFunc.GetShortTitle(Title, length)
    End Function
End Class
