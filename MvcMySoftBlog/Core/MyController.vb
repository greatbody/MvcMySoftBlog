Namespace Core
    Public Class MyController
        Inherits Controller

        Private _user As UserBase
        Public Property BlogUser() As UserBase
            Get
                Return _user
            End Get
            Set(ByVal value As UserBase)
                _user = value
            End Set
        End Property

        Public Overridable Sub OnInit()
            If Me.HttpContext.Session("UserLog") Is Nothing Then
            Else
                BlogUser = Me.HttpContext.Session("UserLog")
            End If
        End Sub
    End Class
End Namespace

