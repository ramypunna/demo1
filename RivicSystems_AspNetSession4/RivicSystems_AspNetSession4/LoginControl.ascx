<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginControl.ascx.cs" Inherits="RivicSystems_AspNetSession4.LoginControl" %>
<table align="center">
    <tr>
        <td colspan="2">
            <asp:Label ID="lblusername" runat="server" ForeColor="Red"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            UserName:
        </td>
        <td>
            <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator
                ID="RequiredFieldValidator1" runat="server"
                ControlToValidate="txtusername">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
        </td>
        <td>
            <asp:Button ID="btnSaveName" runat="server" Text="Save"
                OnClick="btnSaveName_Click" style="height: 26px" />
        </td>
    </tr>
</table>