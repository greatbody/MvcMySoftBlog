<%@ Page Language="VB" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage(Of MvcMySoftBlog.LogOnModel)" %>

<asp:Content ID="loginTitle" ContentPlaceHolderID="TitleContent" runat="server"> 登录</asp:Content>

<asp:Content ID="loginContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>登录</h2>
    <p>
        请输入您的用户名和密码。如果您还没有帐户，请<%= Html.ActionLink("注册", "Register") %>。
    </p>

    <% Using Html.BeginForm() %>
        <%= Html.ValidationSummary(True, "登录未成功。请更正错误，然后重试。")%>
        <div>
            <fieldset>
                <legend>帐户信息</legend>
                
                <div class="editor-label">
                    <%= Html.LabelFor(Function(m) m.UserName) %>
                </div>
                <div class="editor-field">
                    <%= Html.TextBoxFor(Function(m) m.UserName) %>
                    <%= Html.ValidationMessageFor(Function(m) m.UserName) %>
                </div>
                
                <div class="editor-label">
                    <%= Html.LabelFor(Function(m) m.Password) %>
                </div>
                <div class="editor-field">
                    <%= Html.PasswordFor(Function(m) m.Password) %>
                    <%= Html.ValidationMessageFor(Function(m) m.Password) %>
                </div>
                
                <div class="editor-label">
                    <%= Html.CheckBoxFor(Function(m) m.RememberMe) %>
                    <%= Html.LabelFor(Function(m) m.RememberMe) %>
                </div>
                <p>
                    <input type="submit" value="登录" />
                </p>
            </fieldset>
        </div>
    <% End Using %>
</asp:Content>

