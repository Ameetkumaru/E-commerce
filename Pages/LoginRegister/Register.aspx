<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Pages_LoginRegister_Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Literal ID="litStatus" runat="server"></asp:Literal>
<br />
<br />
Name :&nbsp; *<br />
&nbsp;<br />
<asp:TextBox ID="Name" runat="server" CssClass="inputs"></asp:TextBox>
<br />
<br />
Username : *<br />
<br />
<asp:TextBox ID="username" runat="server" CssClass="inputs"></asp:TextBox>
<br />
<br />
Password : *<br />
<br />
<asp:TextBox ID="Password" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
<br />
Confirm Password : *<br />
<br />
<asp:TextBox ID="ConfirmPassword" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
<br />
<br />
Phone Number :<br />
<br />
<asp:TextBox ID="PhoneNumber" runat="server" CssClass="inputs" TextMode="Phone"></asp:TextBox>
<br />
<br />
Mailing Address :<br />
<br />
<asp:TextBox ID="Address" runat="server" CssClass="inputs" Height="67px" Width="285px" MaxLength="500" TextMode="MultiLine"></asp:TextBox>
<br />
<br />
<br />
<asp:Button ID="submit" runat="server" CssClass="button" OnClick="Button1_Click" Text="Submit" />
<br />
<br />
</asp:Content>

