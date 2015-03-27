<%@ Page Title="" Language="VB" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-lg-12 form-group">
            <input id="ArticleTitle" value="" placeholder="标题" class="form-control" />
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12 form-group">
            <!-- 加载编辑器的容器 -->
            <script id="container" name="content" style="height: 600px;" type="text/plain"></script>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12 form-group">
            <button class="btn btn-default">发表</button>
        </div>
    </div>
    <!-- 配置文件 -->
    <script type="text/javascript" src="/Editor/ueditor.config.js"></script>
    <!-- 编辑器源码文件 -->
    <script type="text/javascript" src="/Editor/ueditor.all.js"></script>
    <!-- 实例化编辑器 -->
    <script src="/Scripts/Page/Create.js" type="text/javascript"></script>
    <script type="text/javascript">
        var oUE = new UE.ui.Editor({ innerHeight: "600px", innerWidth: "90%" });
        oUE.render("container");
        Timer.add(200, function () {
            var oIframe = $("#edui1_iframeholder");
            var oContainer = $("#edui1");
            if (oIframe.length > 0 && oContainer.length>0) {
                oIframe.css("height", "500px");
                oContainer.addClass("myform-control");
                Timer.CloseTimer("update");
            }
            console.log(oIframe.length);
        }, "update");
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderReserve" runat="server">
    <style type="text/css">
        .myform-control {
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
