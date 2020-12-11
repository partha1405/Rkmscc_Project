<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <center><div>
    
        <center><fieldset width="40%">
        <table>
        <tr>
            <td align="left">User type</td>
        <td align="left"> <asp:DropDownList ID="DropDownList1" runat="server" Width="250px">
            <asp:ListItem>Admin</asp:ListItem>
            <asp:ListItem>User</asp:ListItem>
            </asp:DropDownList> </td>
        </tr>
         <tr>
            <td align="left">User ID</td>
        <td align="left"> 
            <asp:TextBox ID="TextBox1" runat="server" Width="247px"></asp:TextBox> </td>
        </tr>
         <tr>
            <td align="left">Password</td>
        <td align="left"> 
            <asp:TextBox ID="TextBox2" runat="server" Width="247px"></asp:TextBox> </td>
        </tr>
        </table></fieldset></center><br />
    <asp:Button ID="Button1" runat="server" Text="Login" onclick="Button1_Click" />
    </div></center>
    </form>
</body>
</html>
