<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentEntry.aspx.cs" Inherits="RivicSystems_AspNetSession1.StudentEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Enter Student Name"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:HiddenField ID="HiddenField1" runat="server" />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
      </form>
</body>
</html>
