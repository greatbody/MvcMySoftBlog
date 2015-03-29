<%@ Page Language="VB" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="MvcMySoftBlog" %>
<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    日志大厅</asp:Content>
<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-6">
            <div class="panel panel-default">
                <div class="panel-heading" style="padding: 5px 14px">
                    <div class="row">
                        <div class="col-md-10" style="line-height: 34px;">
                            推2荐榜</div>
                        <div class="col-md-2">
                            <button class="btn btn-default" id="btnPostNew">
                                我要发表</button>
                        </div>
                    </div>
                </div>
                <div class="panel-body">
                    <ul class="list-inline">
                        <%For Each article As Articles In ViewData("ArticleData")%>
                        <li style="width: 100%; padding: 5px 0;"><a href="/Article/Article/<%=article.ID %>"
                            target="_blank">
                            <%=article.ArticleTitle %></a> <span style="float: right">[<%= Format(article.LastUpdate, "yyyy-MM-dd HH:mm")%>]</span>
                        </li>
                        <%Next%>
                    </ul>
                </div>
            </div>
        </div>
        <div class="col-md-6">
            <div class="panel panel-default">
                <div class="panel-heading">
                    12
                </div>
                <div class="panel-body">
                    23
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content runat="server" ID="indexHeaderReserve" ContentPlaceHolderID="HeaderReserve">
    <script type="text/javascript" src="/Scripts/Page/Index.js"></script>
</asp:Content>
