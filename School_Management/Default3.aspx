<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>

    &nbsp;&nbsp;Enter Student ID&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" Width="176px" ></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" Text="SEARCH" onclick="Button1_Click" />
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="231px">
        </asp:DropDownList>
        &nbsp; &nbsp;&nbsp;&nbsp;<asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="SELECT" 
            Width="76px" />
        
        <br />
        &nbsp;&nbsp;&nbsp;
 &nbsp; &nbsp; &nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;
        <br />
&nbsp; Student ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Width="196px" ReadOnly="True"></asp:TextBox>
        
 &nbsp;&nbsp;
        
        Student&#39;s Name&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Width="337px" ReadOnly="True"></asp:TextBox>
        
        <br />
        <br />
&nbsp; Bus No.&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Width="196px" ReadOnly="True"></asp:TextBox>
        
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
        
        <br />
        
 <br />

    </div>
<div>
&nbsp;&nbsp; Installment Month&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox7" runat="server" Width="216px"></asp:TextBox>

&nbsp;&nbsp;&nbsp; Paid Date&nbsp; <asp:TextBox ID="TextBox8" runat="server" 
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

