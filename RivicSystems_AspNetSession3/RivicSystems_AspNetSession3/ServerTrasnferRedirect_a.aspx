<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServerTrasnferRedirect_a.aspx.cs" Inherits="RivicSystems_AspNetSession3.ServerTrasnferRedirect_a" %>

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
            <td colspan="2">
                <h1>This is redirected form</h1>
            </td>
        </tr>
        <tr>
            <td>
                <b>Name</b>
            </td>
            <td>
                :<asp:Label ID="lblName" runat="server">
                </asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <b>Email</b>
            </td>
            <td>
                :<asp:Label ID="lblEmail" runat="server">
                </asp:Label>
            </td>
        </tr>

    </table>
    </div>
    </form>
</body>
</html>
