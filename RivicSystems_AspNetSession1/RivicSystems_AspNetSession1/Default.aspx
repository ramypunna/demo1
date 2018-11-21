<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RivicSystems_AspNetSession1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

    <asp:Button ID="Button1" runat="server" Text="Click Me" OnClick="Button1_Click" />

    <asp:HiddenField ID="HiddenField1" runat="server" Value ="0" />
</asp:Content>
