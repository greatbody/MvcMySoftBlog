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
        Function Create(ByVal formCollection As FormCollection) As ActionResult
            Try
                ' TODO: Add insert logic here
                Dim isCaoGao As Integer = formCollection("IsCaoGao")
                Dim id As Integer = formCollection("id")
                If isCaoGao = 1 Then
                    '如果是草稿，看看是不是新增
                    If id = -1 Then
                        '第一次保存草稿
                        Dim newArticle As New Articles
                        Using db As New BlogDbDataContext
                            newArticle.ArticleTitle = formCollection("title")
                            newArticle.ArticleContent = formCollection("content")
                            newArticle.CreatedOn = Now
                            newArticle.IsCaoGao = True
                            newArticle.LastUpdate = Now
                            newArticle.UserID = GlobalBase.GetUserID()
                            db.Articles.InsertOnSubmit(newArticle)
                            db.SubmitChanges()
                        End Using
                        Return Json(New With {.result = True})
                    Else
                        '不是新增
                        '则更新草稿
                        Using db As New BlogDbDataContext
                            Dim tmpArticle As Articles = db.Articles.First(Function(articles) articles.ID = id)
                            tmpArticle.ArticleTitle = formCollection("title")
                            tmpArticle.ArticleContent = formCollection("content")
                            db.SubmitChanges()
                        End Using
                        Return Json(New With {.result = True})
                    End If
                Else
                    '纯新增
                    Dim newArticle As New Articles
                    Using db As New BlogDbDataContext
                        newArticle.ArticleTitle = formCollection("title")
                        newArticle.ArticleContent = formCollection("content")
                        newArticle.CreatedOn = Now
                        newArticle.IsCaoGao = False
                        newArticle.LastUpdate = Now
                        newArticle.UserID = GlobalBase.GetUserID()
                        db.Articles.InsertOnSubmit(newArticle)
                        db.SubmitChanges()
                        '插入历史记录
                        Dim newArticleHis As New ArticleHistorys
                        With newArticleHis
                            .ArticleTile = newArticle.ArticleTitle
                            .ArticleContent = newArticle.ArticleContent
                            .UpdateDate = Now
                            .ArticleID = newArticle.ID
                            .UserID = newArticle.UserID
                        End With
                        db.ArticleHistorys.InsertOnSubmit(newArticleHis)
                        db.SubmitChanges()
                    End Using
                    Return Json(New With {.redirect = "/Article/Article/" & newArticle.ID.ToString()})
                End If

            Catch ex As Exception
                Return Json(New With {.redirect = "/Article/ErrorPage"})
            End Try
        End Function

        '
        ' GET: /Article/Edit/5

        Function Edit(ByVal id As Integer) As ActionResult
            Dim db As New BlogDbDataContext
            Dim articleses As IQueryable(Of Articles) = From wenzhang In db.Articles Where wenzhang.ID = id

            If articleses Is Nothing Then
                ViewData("Page") = "NoArticleFound"
                SetCurrent("NoArticleFound")
                Return View("NoArticleFound")
            Else
                SetCurrent("Edit")
                ViewData("Page") = "Edit"
                ViewData("ArticleContent") = articleses
                Return View("Edit")
            End If
            Return View()
        End Function

        '
        ' POST: /Article/Edit/5
        <ValidateInput(False)> _
        <HttpPost()> _
        Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add update logic here
                '提交的更新数据
                Dim db As New BlogDbDataContext
                Dim tmpArticle = From arts In db.Articles Where arts.ID = id
                For Each articles As Articles In tmpArticle
                    articles.ArticleTitle = collection("title")
                    articles.ArticleContent = collection("content")
                Next
                db.SubmitChanges()
                Return Json(New With {.result = True, .redirect = "/Article/Article/" & id.ToString()})
            Catch
                Return Json(New With {.result = False})
            End Try
        End Function

        '
        ' GET: /Article/Delete/5

        Function Delete(ByVal id As Integer) As ActionResult
            Try
                Dim db As New BlogDbDataContext
                Dim article As Articles = db.Articles.First(Function(dArticles) dArticles.ID = id)
                db.Articles.DeleteOnSubmit(article)
                db.SubmitChanges()
                Return RedirectToAction("Index", "Home")
            Catch ex As Exception
                Return View("ErrorPage")
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
                Return View("ErrorPage")
            End Try
        End Function

        Function ErrorPage() As ActionResult
            Return View()
        End Function

        'Ajax业务
        <HttpPost()> _
        Function VotePro(ByVal collection As FormCollection) As ActionResult
            Try
                If Not collection("id") Is Nothing Then
                    Dim id As Integer = collection("id")
                    Using db As New BlogDbDataContext
                        Dim article As Articles = db.Articles.First(Function(articles) articles.ID = id)
                        article.Likes += 1
                        db.SubmitChanges()
                    End Using
                    Return Json(New With {.result = True})
                End If
                Return Json(New With {.result = False})
            Catch ex As Exception
                Return Json(New With {.result = False})
            End Try
        End Function

        <HttpPost()> _
        Function VoteCon(ByVal collection As FormCollection) As ActionResult
            Try
                If Not collection("id") Is Nothing Then
                    Dim id As Integer = collection("id")
                    Using db As New BlogDbDataContext
                        Dim article As Articles = db.Articles.First(Function(articles) articles.ID = id)
                        article.DisLikes += 1
                        db.SubmitChanges()
                    End Using
                    Return Json(New With {.result = True})
                End If
                Return Json(New With {.result = False})
            Catch ex As Exception
                Return Json(New With {.result = False})
            End Try
        End Function

#Region "公共函数"
        Public Sub SetCurrent(ByVal PageName As String)
            ViewData(PageName) = "class=""active"""
        End Sub
#End Region
    End Class
End Namespace