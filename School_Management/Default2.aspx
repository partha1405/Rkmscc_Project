<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>

    &nbsp;&nbsp;Enter Student ID&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" Width="176px" 
        ontextchanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" Text="SEARCH" onclick="Button1_Click" />
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="231px">
        </asp:DropDownList>
        &nbsp; &nbsp;&nbsp;&nbsp;<asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="SELECT" 
            Width="76px" />
        
        <br />
        &nbsp;
        Enter Library Card No.&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="272px" 
        ontextchanged="TextBox2_TextChanged"></asp:TextBox>
 &nbsp; &nbsp; &nbsp;
        <asp:Button ID="Button2" runat="server" Text="SEARCH" onclick="Button2_Click" 
            Width="73px" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="189px">
        </asp:DropDownList>
        &nbsp;
        <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="SELECT" 
            Width="76px" />
        <br />
        <br />
&nbsp; Student ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Width="196px" ReadOnly="True"></asp:TextBox>
        
 &nbsp;&nbsp;
        
        Student&#39;s Name&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Width="337px" ReadOnly="True"></asp:TextBox>
        
        <br />
        <br />
&nbsp; Library Card No.&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Width="196px" ReadOnly="True"></asp:TextBox>
        
        <br />
        
 <br />

    </div>
<div>

    &nbsp;&nbsp; Book Name&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="TextBox6" 
        runat="server" Width="434px"></asp:TextBox>

    <br />
&nbsp;&nbsp; Issue Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox7" runat="server" Width="216px"></asp:TextBox>

&nbsp;&nbsp;&nbsp; Submit Date&nbsp; <asp:TextBox ID="TextBox8" runat="server" 
        Width="216px"></asp:TextBox>

&nbsp;<br />
&nbsp;&nbsp; Total Fine&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox9" runat="server" Width="216px"></asp:TextBox>

    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button5" runat="server" Text="INSERT" onclick="Button5_Click" />

</div>
</asp:Content>

