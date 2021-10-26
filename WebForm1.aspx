<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="project_social_media.WebForm1" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>        
        .s
        {
            color:gray;
        }
        #txtFirstName
        {
            border-top:none;
            border-left:none;
            border-right:none;
            border-bottom:1px solid black;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <table>
                <tr>
                    <td colspan="2"><h2>USER REGISTRATION</h2></td>
                </tr>
                <tr>
                    <td>First Name:</td>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                        <ajaxToolkit:TextBoxWatermarkExtender ID="txtFirstName_TextBoxWatermarkExtender" runat="server" BehaviorID="txtFirstName_TextBoxWatermarkExtender" TargetControlID="txtFirstName" WatermarkCssClass=".s" WatermarkText="First Name Please">
                        </ajaxToolkit:TextBoxWatermarkExtender>
                    </td>
                </tr>
                <tr>
                    <td>Last Name:</td>
                    <td>
                        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                        <ajaxToolkit:DropShadowExtender ID="txtLastName_DropShadowExtender" runat="server" BehaviorID="txtLastName_DropShadowExtender" TargetControlID="txtLastName" />
                    </td>
                </tr>
                <tr>
                    <td>Date of Birth:</td>
                    <td>
                        <%--<asp:DropDownList ID="ddlDates" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlDates_SelectedIndexChanged"></asp:DropDownList>
                        <asp:DropDownList ID="ddlMonths" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlMonths_SelectedIndexChanged"></asp:DropDownList>
                        <asp:DropDownList ID="ddlYears" runat="server"></asp:DropDownList>--%>
                        <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
                        <ajaxToolkit:CalendarExtender ID="txtDOB_CalendarExtender" runat="server" BehaviorID="txtDOB_CalendarExtender" TargetControlID="txtDOB" />
                </tr>
                <tr>
                    <td>Email or Phone:</td>
                    <td>
                        <asp:TextBox ID="txtEmailPhone" runat="server"></asp:TextBox></td>
                </tr>   
                <tr>
                    <td>Enter the Captcha Code:</td>
                    <td>
                        <asp:TextBox ID="txtCaptch" runat="server"></asp:TextBox><br />
                        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="cmdbutton" runat="server" Text="Register" OnClick="cmdbutton_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
