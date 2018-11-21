<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServerTrasnsferRedirect.aspx.cs" Inherits="RivicSystems_AspNetSession3.ServerTrasnsferRedirect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
  
    <div style="font-family: Arial">
    <table>
        <tr>
            <td colspan="2">
                <h1>
                    This is First form</h1>
            </td>
        </tr>
        <tr>
            <td>
                <b>Name</b>
            </td>
            <td>
                :<asp:TextBox ID="txtName" runat="server">
                </asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <b>Email</b>
            </td>
            <td>
                :<asp:TextBox ID="txtEmail" runat="server">
                </asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnExecute" runat="server" 
                Text="Server.Execute" 
                Width="250px" onclick="btnExecute_Click"/>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblStatus" ForeColor="Green" 
                Font-Bold="true" runat="server"></asp:Label>
            </td>
        </tr>
    </table>

    </div>
    </form>
</body>
</html>
