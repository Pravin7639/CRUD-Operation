
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs"
    Inherits="CRUD_Operation.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 123px;
        }
        .auto-style3 {
            width: 285px;
        }
        .auto-style4 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Id</td>
                    <td>
                        <asp:TextBox ID="txtId" runat="server" Width="219px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Name</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" Width="219px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Price</td>
                    <td>
                        <asp:TextBox ID="txtPrice" runat="server" Width="219px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>





        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                   
                    <asp:Button ID="btnInsert" runat="server" Height="29px"  Text="Insert"  CssClass="bg-blue" BackColor="#0099FF" BorderStyle="Solid" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="btnInsert_Click" Width="63px" />
                    
                    <asp:Button ID="btnRead" runat="server" Text="Read" Height="29px"  CssClass="bg-blue" BackColor="#0099FF" BorderStyle="Solid" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="btnRead_Click"/>

                    <asp:Button ID="btnUpdate" runat="server" Text="Update" Height="29px"  CssClass="bg-blue" BackColor="#0099FF" BorderStyle="Solid" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="btnUpdate_Click"/>

                    <asp:Button ID="btnClear" runat="server" Text="Clear" Height="29px"  CssClass="bg-blue" BackColor="#0099FF" BorderStyle="Solid" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="btnClear_Click"/>

                    <asp:Button ID="btnDelete" runat="server" Text="Delete" Height="29px"  CssClass="bg-blue" BackColor="#0099FF" BorderStyle="Solid" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="btnDelete_Click" Width="69px" />

                </td>
              
            </tr>
            

             <tr>
                <td class="auto-style3">
                    <asp:GridView ID="gvProduct" runat="server" Width="449px">
                    </asp:GridView>
                </td>
               
            </tr>

        </table>

        <asp:Label ID="lblMessage" runat="server" Text="Label" ForeColor="Red"></asp:Label>

    </form>
</body>
</html>
