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
        Public Sub New()
            '无参数构造函数
        End Sub

        Public Sub New(ByVal requestContext As RequestContext)
            Me.OnInit(requestContext)
        End Sub

        Public Overridable Sub OnInit()
            If Not Me.HttpContext.Session("UserLog") Is Nothing Then
                BlogUser = Me.HttpContext.Session("UserLog")
                Dim ControllerName As String = Me.RouteData.Values("controller").ToString() + "Controller"
                Dim ActionName As String = Me.RouteData.Values("action").ToString()
            Else
                '无权限的用户跳转到主页面
                Me.HttpContext.Response.Redirect("/")
            End If
        End Sub

        Public Overridable Sub OnInit(ByVal requestContext As System.Web.Routing.RequestContext)
            If Not requestContext.HttpContext.Session("UserLog") Is Nothing Then
                BlogUser = requestContext.HttpContext.Session("UserLog")
                Dim ControllerName As String = requestContext.RouteData.Values("controller").ToString() + "Controller"
                Dim ActionName As String = requestContext.RouteData.Values("action").ToString()
            End If
        End Sub

    End Class
End Namespace

