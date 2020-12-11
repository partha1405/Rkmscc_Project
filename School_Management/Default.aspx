<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div>
   <center><fieldset style="width: 900px">
   <legend>Student Information</legend><table width="100%">
   <tr><td align="left">Student ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox 
           ID="TextBox1" runat="server" Width="264px" Height="18px" ReadOnly="True"></asp:TextBox>
        &nbsp; 
       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
           ControlToValidate="TextBox1" ForeColor="Red">Student ID cannot be blanked</asp:RequiredFieldValidator>
       </td></tr> 
<tr><td align="left">Student,s Name&nbsp;<asp:TextBox ID="TextBox2" runat="server" 
        Width="354px" style="margin-left: 7px"></asp:TextBox>&nbsp;
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="TextBox2" ForeColor="Red">Student&#39;s Name cannot be blanked</asp:RequiredFieldValidator>
       </td> </tr>
 <tr><td align="left">Roll No.&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox3" 
         runat="server" Width="205px" style="margin-left: 20px" ReadOnly="True"></asp:TextBox>&nbsp;&nbsp;&nbsp;
     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
         ControlToValidate="TextBox3" ForeColor="Red">Roll No. cannot be blanked</asp:RequiredFieldValidator>
       </td> </tr>
<tr><td align="left">Class&nbsp;<asp:TextBox ID="TextBox4" runat="server" style="margin-left: 47px" Width="275px"></asp:TextBox></td> </tr>
 <tr><td align="left">Section&nbsp;<asp:TextBox ID="TextBox5" runat="server" Width="206px" style="margin-left: 20px"></asp:TextBox></td> </tr>
<tr><td align="left">Library Card No.&nbsp;<asp:TextBox ID="TextBox6" 
        runat="server" Width="273px" ReadOnly="True"></asp:TextBox></td> </tr>
 <tr><td align="left">Bus No.&nbsp;<asp:TextBox ID="TextBox7" runat="server" style="margin-left: 21px" Width="200px"></asp:TextBox></td> </tr>
 <tr><td align="left"  colspan="2">Father's Name&nbsp;<asp:TextBox ID="TextBox8" runat="server" Width="411px" style="margin-left: 7px"></asp:TextBox></td> </tr>
 <tr><td align="left"  colspan="2">Address&nbsp;&nbsp;&nbsp;<asp:TextBox 
         ID="TextBox10" runat="server" Width="490px" style="margin-left: 33px"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
         ControlToValidate="TextBox10" ForeColor="Red">Address cannot be blanked</asp:RequiredFieldValidator>
       </td> </tr>
 <tr><td align="left">Phone No.&nbsp;<asp:TextBox ID="TextBox11" runat="server" Width="243px" style="margin-left: 32px"></asp:TextBox>&nbsp;&nbsp;
     <asp:CompareValidator ID="CompareValidator1" runat="server" 
         ControlToValidate="TextBox11" ForeColor="Red" Operator="DataTypeCheck" 
         Type="Double">Enter number only</asp:CompareValidator>
     </td></tr>
 <tr><td align="left">Father's Voter ID No.&nbsp;<asp:TextBox ID="TextBox12" runat="server" Width="275px" style="margin-left: 20px"></asp:TextBox></td> 
</tr>
</table> </fieldset></center>
   </div>
    
   <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="INSERT" onclick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 
<asp:Button ID="Button2" runat="server" Text="RESET" onclick="Button2_Click" />
</asp:Content>
