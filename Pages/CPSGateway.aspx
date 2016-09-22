<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CPSGateway.aspx.cs" Inherits="Pages_CPSGateway" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:Label ID="responseLb" runat="server"></asp:Label>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        Enter yor credit card details ..</p>
    <p>
        <strong>Credit Card Number :&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="creditcardnumTexbox" runat="server" Width="243px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; (format: xxxx xxxx xxxx xxxx)</strong>&nbsp;</p>
    <p>
        <strong>Expiration Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="expirationdateTexbox" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; ( format mm/yyyy )</strong>&nbsp;</p>
    <p>
        <strong>Amount:&nbsp;&nbsp; $&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Amount" runat="server"></asp:Label>
        </strong>&nbsp;</p>
    <p>
        <strong>First name of card holder :
        <asp:TextBox ID="firstnameTextbox" runat="server"></asp:TextBox>
        </strong>&nbsp;</p>
    <p>
        <strong>Last name of card holder:
        <asp:TextBox ID="lastnameTextbox" runat="server"></asp:TextBox>
        </strong>
    </p>
    <p>
        <asp:Button ID="creditCardSubmitButton" runat="server" Text="Payment" OnClick="creditCardSubmitButton_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    <p>
        <asp:Label ID="responseError" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>

