Imports System.Data.Linq

<HandleError()> _
Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        SetCurrent("Index")
        ViewData("ArticleData") = GetList()
        Return View()
    End Function

    Function About() As ActionResult
        Return View()
    End Function

    <HttpPost()> _
    Function Rt() As ActionResult
        Return Json(View("JsonTest").ViewData)
    End Function


#Region "公共函数"
    Public Sub SetCurrent(ByVal PageName As String)
        ViewData(PageName) = "class=""active"""
    End Sub
#End Region
#Region "Business"
    Public Function GetList() As IQueryable(Of Articles)
        Dim articles As IQueryable(Of Articles)
        Dim db As New BlogDbDataContext
        articles = From articleCollection In db.Articles Select articleCollection Order By articleCollection.CreatedOn Descending
        Return articles.Take(5)
    End Function
#End Region
End Class
