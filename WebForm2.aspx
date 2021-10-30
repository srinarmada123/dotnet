<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="project_social_media.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gvEmployeeDetails" runat="server">
    </asp:GridView>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Show" OnClick="Button1_Click"/>
</asp:Content>
