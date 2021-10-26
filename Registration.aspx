<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="project_social_media.Registration" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <table>
                <tr>
                    <td>Pass Word:</td>
                    <td>
                        <asp:TextBox ID="txtpassword" TextMode="Password" runat="server"></asp:TextBox>
                        <ajaxToolkit:PasswordStrength ID="txtpassword_PasswordStrength" runat="server" BehaviorID="txtpassword_PasswordStrength" TargetControlID="txtpassword" />
                    </td>
                </tr>
                <tr>
                    <td>Confirm Pass Word:</td>
                    <td>
                        <asp:TextBox ID="txtcpassword" TextMode="Password" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="REGISTRATION" OnClick="Button1_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
