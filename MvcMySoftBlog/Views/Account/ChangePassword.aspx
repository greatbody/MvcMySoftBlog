<%@ Page Language="VB" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage(Of MvcMySoftBlog.ChangePasswordModel)" %>

<asp:Content ID="changePasswordTitle" ContentPlaceHolderID="TitleContent" runat="server"> 更改密码</asp:Content>

<asp:Content ID="changePasswordContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>更改密码</h2>
    <p>
        请使用下面的表单更改密码。
    </p>
    <p>
        新密码的长度至少应为 <%=Html.Encode(ViewData("PasswordLength"))%> 个字符。
    </p>

    <% Using Html.BeginForm() %>
        <%= Html.ValidationSummary(True, "密码更改未成功。请更正错误，然后重试。")%>
        <div>
            <fieldset>
                <legend>帐户信息</legend>
                
                <div class="editor-label">
                    <%= Html.LabelFor(Function(m) m.OldPassword) %>
                </div>
                <div class="editor-field">
                    <%= Html.PasswordFor(Function(m) m.OldPassword) %>
                    <%= Html.ValidationMessageFor(Function(m) m.OldPassword) %>
                </div>
                
                <div class="editor-label">
                    <%= Html.LabelFor(Function(m) m.NewPassword) %>
                </div>
                <div class="editor-field">
                    <%= Html.PasswordFor(Function(m) m.NewPassword) %>
                    <%= Html.ValidationMessageFor(Function(m) m.NewPassword) %>
                </div>
                
                <div class="editor-label">
                    <%= Html.LabelFor(Function(m) m.ConfirmPassword) %>
                </div>
                <div class="editor-field">
                    <%= Html.PasswordFor(Function(m) m.ConfirmPassword) %>
                    <%= Html.ValidationMessageFor(Function(m) m.ConfirmPassword) %>
                </div>
                
                <p>
                    <input type="submit" value="更改密码" />
                </p>
            </fieldset>
        </div>
    <% End Using %>
</asp:Content>

