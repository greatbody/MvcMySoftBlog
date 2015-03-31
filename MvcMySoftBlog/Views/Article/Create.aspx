<%@ Page Title="" Language="VB" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    创建日志
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-8 form-group">
            <input id="ArticleTitle" value="" placeholder="标题" class="form-control" />
        </div>
        <div class="col-md-4 form-group">
            <input id="ArticleDate" value="<%= Format(Now,"yyyy-MM-dd") %>" class="form-control" />
        </div>
    </div>
    <div class="row">
        <div class="col-md-12 form-group">
            <!-- 加载编辑器的容器 -->
            <script id="container" name="content" style="height: 600px;" type="text/plain"></script>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12 form-group">
            <button class="btn btn-default" style="float: right; padding: 5px 15px; margin-left: 8px"
                id="btnSubmit">
                发布</button>
            <button class="btn btn-default" style="float: right; padding: 5px 15px" id="btnPreview">
                预览</button>
        </div>
    </div>
    <!-- 配置文件 -->
    <script type="text/javascript" src="/Editor/ueditor.config.js"></script>
    <!-- 编辑器源码文件 -->
    <script type="text/javascript" src="/Editor/ueditor.all.js"></script>
    <!-- 日期控件 -->
    <link rel="Stylesheet" href="/Scripts/datepicker.css" />
    <script type="text/javascript" src="/Scripts/bootstrap-datepicker.js"></script>
    <script src="/Scripts/ArticleBusiness.js" type="text/javascript"></script>
    <script src="/Scripts/Page/Create.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderReserve" runat="server">
    <style type="text/css">
        .myform-control
        {
            display: block;
            width: 100%;
            height: 100%;
            padding: 6px 12px;
            background-color: #fff;
            background-image: none;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-shadow: inset 0 1px 1px rgba(0, 0, 0, .075);
        }
    </style>
</asp:Content>
