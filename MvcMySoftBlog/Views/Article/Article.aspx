<%@ Page Title="" Language="VB" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="MvcMySoftBlog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <% Dim art = CType(ViewData("ArticleContent"), IEnumerable(Of Articles))%>
    <%= art(0).ArticleTitle%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <% Dim art = CType(ViewData("ArticleContent"), IEnumerable(Of Articles))%>
    <div class="row panel panel-default centerview">
        <div class="text-center panel-heading" style="font-weight: bold;font-size: 16px;color: #a18f8f">
            <%= art(0).ArticleTitle%>
        </div>
        <div class="panel-group">
            <div style="border:1px solid #ffffff;padding: 3px;text-align: right"><a href="/Article/Delete/<%= art(0).ID %>">[删除]</a><a href="/Article/Edit/<%= art(0).ID %>">[编辑]</a></div>
        </div>
        <div class="panel-body" style="min-height: 550px;"><%= art(0).ArticleContent%></div>
        <div class="panel-footer text-center">CopyLeft Sunsoft@2015-2020 All Rights Released</div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderReserve" runat="server">
    <style type="text/css">
        div .articlebody
        {
            width: 700px;
            margin: 0 auto;
        }
        div .centerview {
            margin: 0 auto;
            width: 900px
        }
    </style>
</asp:Content>
