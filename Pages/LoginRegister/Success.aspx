<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Success.aspx.cs" Inherits="Pages_LoginRegister_Success" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        Thank you for purchasing with Illinois Autoshop .Your Order is complete and ready for packing..</p>
    <p>
        &nbsp;</p>
    <p>
        Your payment confirmation code :&nbsp;&nbsp;
        <asp:Label ID="authCode" runat="server" Text="Label"></asp:Label>
    </p>
</asp:Content>

