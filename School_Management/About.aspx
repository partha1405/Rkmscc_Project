<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div>

       &nbsp;&nbsp;Enter Student Id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:TextBox ID="TextBox1" runat="server" Width="211px"></asp:TextBox>
&nbsp;&nbsp;&nbsp; <asp:Button ID="Button1" runat="server" Text="SEARCH" onclick="Button1_Click" />
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:DropDownList ID="DropDownList1" runat="server" Height="17px" Width="244px">
       </asp:DropDownList>
&nbsp;&nbsp;&nbsp; <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="SELECT" 
            Width="76px" />
        
        <br />
        
        <br />
      
     
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<center>
           <asp:GridView 
           ID="GridView1" runat="server" Width="828px">
       </asp:GridView></center>

   </div>
</asp:Content>
