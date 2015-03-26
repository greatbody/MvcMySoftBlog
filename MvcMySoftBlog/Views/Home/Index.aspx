<%@ Page Language="VB" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    日志大厅</asp:Content>
<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-6">
            <div class="panel panel-default">
                <div class="panel-heading">
                    推荐榜</div>
                <div class="panel-body">
                    这里是推荐链接
                </div>
            </div>
        </div>
        <div class="col-md-6">
            <div class="panel panel-default">
                <div class="panel-heading" data-ng-app="" data-ng-init="d=3;m=4;">
                    <input data-ng-model="test" />
                    <div class="col-md-4">this is {{ d*m}}</div>
                    <div class="col-md-8"></div>
                    <input data-ng-model="test"/>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content runat="server" ID="indexHeaderReserve" ContentPlaceHolderID="HeaderReserve">
    <script type="text/javascript" src="/Scripts/Page/Index.js"></script>
</asp:Content>
