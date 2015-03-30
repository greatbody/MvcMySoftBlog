<%@ Page Title="" Language="VB" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="MvcMySoftBlog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <% Dim art = CType(ViewData("ArticleContent"), IEnumerable(Of Articles))%>
    编辑日志 -
    <%= art(0).ArticleTitle%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <% Dim art = CType(ViewData("ArticleContent"), IEnumerable(Of Articles))%>
    <div class="row">
        <div class="col-lg-12 form-group">
            <input id="ArticleTitle" value="<%= art(0).ArticleTitle %>" placeholder="标题" class="form-control" />
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12 form-group">
            <!-- 加载编辑器的容器 -->
            <script id="container" name="content" style="height: 600px;" type="text/plain"><%= art(0).ArticleContent %></script>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12 form-group">
            <button class="btn btn-default" style="float: right; padding: 5px 15px; margin-left: 8px"
                id="btnSubmit">
                发布</button>
            <button class="btn btn-default" style="float: right; padding: 5px 15px" id="btnPreview">
                预览</button>
        </div>
    </div>
    <input type="hidden" id="articleID" value="<%= art(0).ID %>" />
    <!-- 配置文件 -->
    <script type="text/javascript" src="/Editor/ueditor.config.js"></script>
    <!-- 编辑器源码文件 -->
    <script type="text/javascript" src="/Editor/ueditor.all.js"></script>
    <script src="/Scripts/ArticleBusiness.js" type="text/javascript"></script>
    <script src="/Scripts/Page/Edit.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderReserve" runat="server">
</asp:Content>
