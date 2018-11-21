<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CachingDemo.aspx.cs" Inherits="RivicSystems_AspNetSession4.CachingDemo" %>
<%--<%@ OutputCache Duration="300" VaryByParam="None" %>--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<%--<script language="javascript">
    alert(new Date().toLocaleString());
</script>--%>

<body>
    <form id="form1" runat="server">
    <div>
     <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
      <div>
          <asp:DropDownList ID="DropDownList1" DataTextField="StudentName" DataValueField="StudentId" runat="server"></asp:DropDownList> 
        </div>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </div>
        <asp:button runat="server" text="Button" OnClick="Unnamed1_Click" />
    </div>
    </form>
</body>
</html>
