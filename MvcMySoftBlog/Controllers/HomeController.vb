<HandleError()> _
Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        SetCurrent("Index")
        Return View()
    End Function

    Function About() As ActionResult
        Return View()
    End Function
    <HttpPost()> _
    Function Rt() As ActionResult

        Return View("JsonTest")
    End Function

#Region "公共函数"
    Public Sub SetCurrent(ByVal PageName As String)
        ViewData(PageName) = "class=""active"""
    End Sub
#End Region
End Class
