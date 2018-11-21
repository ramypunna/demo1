<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="01-UserControlDemo.aspx.cs" Inherits="RivicSystems_AspNetSession4._01_UserControlDemo" %>
<%@ Register src="~/LoginControl.ascx" TagName="LoginInformation" TagPrefix="uc1" %>
<%@ Register Assembly="DemoCustomControl" Namespace="DemoCustomControl" TagPrefix="cc1" %>

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
                <td>
                    <cc1:WebCustomControl1 ID="WebCustomControl1" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Button" />
                        <uc1:LoginInformation ID="LoginControl" runat="server" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
