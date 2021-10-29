<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="project_social_media.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <th colspan="2">LOGIN PAGE</th>
                </tr>
                <tr>
                    <td>User Name:</td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Pass Word:</td>
                    <td>
                        <asp:TextBox ID="txtPassWord" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="cmdSignIn" runat="server" Text="LOGIN" OnClick="cmdSignIn_Click" style="height: 26px" ></asp:Button></td>
                </tr>
            </table>
            /</div>
    </form>
</body>
</html>
