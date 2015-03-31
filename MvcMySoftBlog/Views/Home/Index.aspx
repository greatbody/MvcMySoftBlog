<%@ Page Language="VB" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="MvcMySoftBlog" %>
<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    日志大厅</asp:Content>
<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <%= ""%>
    <div class="row">
        <div class="col-md-6">
            <div class="panel panel-default">
                <div class="panel-heading panel-head-low">
                    <div class="row">
                        <div class="col-md-9" style="line-height: 34px;">
                            推荐榜</div>
                        <div class="col-md-3">
                            <a class="btn btn-default" id="btnPostNew" href="/Article/Create" target="_blank"
                                style="float: right">我要发表</a>
                        </div>
                    </div>
                </div>
                <div class="panel-body">
                    <ul class="list-inline">
                        <%For Each article As Articles In ViewData("ArticleData")%>
                        <li style="width: 100%; padding: 5px 0;"><a href="/Article/Article/<%=article.ID %>" title="<%= article.ArticleTitle %>">
                            <%= GlobalBase.GetShortTitle(article.ArticleTitle, 40)%></a> <span style="float: right">
                                [<%= Format(article.LastUpdate, "yyyy-MM-dd HH:mm")%>]</span> </li>
                        <%Next%>
                    </ul>
                </div>
            </div>
        </div>
        <div class="col-md-6">
            <div class="panel panel-default">
                <div class="panel-heading panel-head-low">
                    <div class="row">
                        <div class="col-md-9" style="line-height: 34px;">
                            最近发布</div>
                        <div class="col-md-3">
                            <a class="btn btn-default" id="A1" href="/Article/Create" target="_blank" style="float: right">
                                我要发表</a>
                        </div>
                    </div>
                </div>
                <div class="panel-body">
                    <ul class="list-inline">
                        <%For Each article As Articles In ViewData("ArticleData")%>
                        <li style="width: 100%; padding: 5px 0;"><a href="/Article/Article/<%=article.ID %>" title="<%= article.ArticleTitle %>">
                            <%= GlobalBase.GetShortTitle(article.ArticleTitle, 40)%></a> <span style="float: right">
                                [<%= Format(article.LastUpdate, "yyyy-MM-dd HH:mm")%>]</span> </li>
                        <%Next%>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content runat="server" ID="indexHeaderReserve" ContentPlaceHolderID="HeaderReserve">
    <script type="text/javascript" src="/Scripts/Page/Index.js"></script>
    <style type="text/css">
        .panel-head-low
        {
            padding: 5px 14px;
        }
    </style>
</asp:Content>
