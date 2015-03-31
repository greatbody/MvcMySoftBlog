<%@ Page Title="" Language="VB" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="MvcMySoftBlog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <% Dim art = CType(ViewData("ArticleContent"), IEnumerable(Of Articles))%>
    <%= art(0).ArticleTitle%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <% Dim art = CType(ViewData("ArticleContent"), IEnumerable(Of Articles))%>
    <div style="position: fixed">
        <ul class="nav nav-tabsn nav-stackedn" id="myNav">
            <li><a href="javascript:void(0);" onclick="Article.Zan(<%= art(0).ID%>,this);">顶<span style="padding-left: 15px"><%= art(0).Likes%></span></a></li>
            <li><a href="javascript:void(0);" onclick="Article.Cai(<%= art(0).ID%>,this);">踩<span style="padding-left: 15px"><%= art(0).DisLikes%></span></a></li>
        </ul>
    </div>
    <div class="row panel panel-default centerview">
        <div class="text-center panel-heading" style="font-weight: bold; font-size: 16px;
            color: #a18f8f">
            <%= art(0).ArticleTitle%>
        </div>
        <div class="panel-group">
            <div style="border: 1px solid #ffffff; padding: 3px; text-align: right">
                <a href="/Article/Delete/<%= art(0).ID %>">[删除]</a><a href="/Article/Edit/<%= art(0).ID %>">[编辑]</a></div>
        </div>
        <div class="panel-body" style="min-height: 550px;">
            <%= art(0).ArticleContent%></div>
        <div class="panel-footer text-center">
            CopyLeft Sunsoft@2015-2020 All Rights Released</div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderReserve" runat="server">
    <script type="text/javascript" src="/Scripts/ArticleBusiness.js"></script>
    <style type="text/css">
        div .articlebody
        {
            width: 700px;
            margin: 0 auto;
        }
        div .centerview
        {
            margin: 0 auto;
            width: 900px;
        }
    </style>
    <style type="text/css">
        /* Custom Styles */
        ul.nav-tabsn
        {
            width: 90px;
            margin-top: 20px;
            border-radius: 4px;
            border: 1px solid #ddd;
            box-shadow: 0 1px 4px rgba(0, 0, 0, 0.067);
        }
        ul.nav-tabsn li
        {
            margin: 0;
            border-top: 1px solid #ddd;
        }
        ul.nav-tabsn li:first-child
        {
            border-top: none;
        }
        ul.nav-tabsn li a
        {
            margin: 0;
            padding: 8px 16px;
            border-radius: 0;
        }
        ul.nav-tabsn li.active a, ul.nav-tabs li.active a:hover
        {
            color: #fff;
            background: #0088cc;
            border: 1px solid #0088cc;
        }
        ul.nav-tabsn li:first-child a
        {
            border-radius: 4px 4px 0 0;
        }
        ul.nav-tabsn li:last-child a
        {
            border-radius: 0 0 4px 4px;
        }
        ul.nav-tabsn.affix
        {
            top: 180px; /* Set the top position of pinned element */
        }
    </style>
</asp:Content>
