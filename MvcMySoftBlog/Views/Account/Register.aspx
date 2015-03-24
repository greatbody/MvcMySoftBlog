<%@ Page Language="VB" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage(Of MvcMySoftBlog.RegisterModel)" %>

<asp:Content ID="registerTitle" ContentPlaceHolderID="TitleContent" runat="server"> 注册</asp:Content>

<asp:Content ID="registerContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>创建新帐户</h2>
    <p>
        请使用下面的表单创建新帐户。
    </p>
    <p>
        密码长度至少应为 <%=Html.Encode(ViewData("PasswordLength"))%> 个字符。
    </p>

    <% Using Html.BeginForm() %>
        <%= Html.ValidationSummary(True, "帐户创建未成功。请更正错误，然后重试。")%>
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
                    <%= Html.LabelFor(Function(m) m.Email) %>
                </div>
                <div class="editor-field">
                    <%= Html.TextBoxFor(Function(m) m.Email) %>
                    <%= Html.ValidationMessageFor(Function(m) m.Email) %>
                </div>
                
                <div class="editor-label">
                    <%= Html.LabelFor(Function(m) m.Password) %>
                </div>
                <div class="editor-field">
                    <%= Html.PasswordFor(Function(m) m.Password) %>
                    <%= Html.ValidationMessageFor(Function(m) m.Password) %>
                </div>
                
                <div class="editor-label">
                    <%= Html.LabelFor(Function(m) m.ConfirmPassword) %>
                </div>
                <div class="editor-field">
                    <%= Html.PasswordFor(Function(m) m.ConfirmPassword) %>
                    <%= Html.ValidationMessageFor(Function(m) m.ConfirmPassword) %>
                </div>
                
                <p>
                    <input type="submit" value="注册" />
                </p>
            </fieldset>
        </div>
    <% End Using %>
</asp:Content>

