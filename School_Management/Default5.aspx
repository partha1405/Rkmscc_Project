<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default5.aspx.cs" Inherits="Default5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<div>
Enter Student Id  <asp:TextBox ID="TextBox1" runat="server" Width="211px"></asp:TextBox>
&nbsp;&nbsp; <asp:Button ID="Button1" runat="server" Text="SEARCH" onclick="Button1_Click" />
 &nbsp;
       <asp:DropDownList ID="DropDownList1" runat="server" Height="17px" Width="244px">
       </asp:DropDownList>
&nbsp; <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="SELECT" 
            Width="76px" />
        
        <br />
    <br />
    <center>
           <asp:GridView 
           ID="GridView1" runat="server" Width="828px">
       </asp:GridView>   </center>                   
</div>
</asp:Content>

