<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="01-DataBinding.aspx.cs" Inherits="RivicSystems_AspNetSession3._01_DataBinding" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
    </div>

    <asp:Repeater id="Repeater1" runat="server">

            <HeaderTemplate>

                <table border=1>
                  <tr>
                    <td><b>Student Id</b></td>
                    <td><b>Student Name</b></td>
                  </tr>

            </HeaderTemplate>

            <ItemTemplate>

                <tr>
                  <td> <%# DataBinder.Eval(Container.DataItem, "StudentId") %> </td>
                  <td> <%# DataBinder.Eval(Container.DataItem, "StudentName") %> </td>
                </tr>

            </ItemTemplate>

            <FooterTemplate>

                </table>

            </FooterTemplate>

        </asp:Repeater>

        <div>
            <div style="height: 100%; width: 100%;">  
                <div style="height: 650px; width: 650px; float: left;">  
                    <%--Data List Control--%>  
                    <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" BorderStyle="Double" BorderWidth="4px"  
                        CellPadding="3" CellSpacing="2" GridLines="Both" Height="617px">  
                        <HeaderTemplate>DataList Control</HeaderTemplate>  
                        <HeaderStyle BackColor="Gray" Font-Bold="true" HorizontalAlign="Center" Font-Size="X-Large" />  
                        <ItemTemplate>  
                            <div>  
                                <table style="width: 170px; text-align: center; border-color: red;">  
                                     <tr>  
                                        <td>  
                                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("StudentID") %>'></asp:Label>  
                                        </td>  
                                    </tr>  
                                    <tr>  
                                        <td>  
                                            <asp:Label ID="Label2" runat="server" Text='<%#Eval("StudentName") %>'></asp:Label>  
                                        </td>  
                                    </tr>  
                                    <tr>  
                                        <td>  
                                            <asp:Label ID="Label3" runat="server" Text='<%#Eval("StudentAddress") %>'></asp:Label>  
                                        </td>  
                                    </tr>  
                                  
                                </table>  
                            </div>  
                        </ItemTemplate>  
                    </asp:DataList>  
                </div>  
            </div>  

        </div>
    </form>
</body>
</html>
