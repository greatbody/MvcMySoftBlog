Namespace MvcMySoftBlog
    Public Class ArticleController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /Article

        Function Index() As ActionResult
            Return View()
        End Function

        '
        ' GET: /Article/Details/5

        Function Article(ByVal id As Integer) As ActionResult

            Dim db As New BlogDbDataContext
            Dim articleses As IQueryable(Of Articles) = From wenzhang In db.Articles Where wenzhang.ID = id
            ViewData("Page") = "article"
            If articleses Is Nothing Then
                SetCurrent("NoArticleFound")
                Return View("NoArticleFound")
            Else
                SetCurrent("Article")
                ViewData("ArticleContent") = articleses
                Return View("Article")
            End If
        End Function

        '
        ' GET: /Article/Create

        Function Create() As ActionResult
            Return View()
        End Function

        '
        ' POST: /Article/Create
        <ValidateInput(False)> _
        <HttpPost()> _
        Function Create(ByVal title As String, ByVal content As String) As ActionResult
            Try
                ' TODO: Add insert logic here
                Using db As New BlogDbDataContext
                    Dim newArticle As New Articles
                    newArticle.ArticleTitle = title
                    newArticle.ArticleContent = content
                    newArticle.CreatedOn = Now
                    newArticle.IsCaoGao = False
                    newArticle.LastUpdate = Now
                    newArticle.UserID = GlobalBase.GetUserID()
                    db.Articles.InsertOnSubmit(newArticle)

                    db.SubmitChanges()
                End Using
                Return Json(New With {.Result = True})
            Catch ex As Exception
                Return Json(New With {.Result = False})
            End Try
        End Function

        '
        ' GET: /Article/Edit/5

        Function Edit(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        '
        ' POST: /Article/Edit/5

        <HttpPost()> _
        Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add update logic here

                Return RedirectToAction("Index")
            Catch
                Return View("Error")
            End Try
        End Function

        '
        ' GET: /Article/Delete/5

        Function Delete(ByVal id As Integer) As ActionResult
            Try
                Return RedirectToAction("Index")
            Catch ex As Exception
                Return View("Error")
            End Try

        End Function

        '
        ' POST: /Article/Delete/5

        <HttpPost()> _
        Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add delete logic here

                Return RedirectToAction("Index")
            Catch
                Return View("Error")
            End Try
        End Function

#Region "公共函数"
        Public Sub SetCurrent(ByVal PageName As String)
            ViewData(PageName) = "class=""active"""
        End Sub
#End Region
    End Class
End Namespace