<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="Pages_ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style1">
        <strong>Contact US</strong></p>
    <p>
        <asp:Label ID="lblResult0" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
    </p>
    <p>
        Email id&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        &nbsp;
    </p>
    <p>
        Message&nbsp; :&nbsp;&nbsp;
        <asp:TextBox ID="TxtMsg" runat="server" Height="81px" Width="307px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnSubmit" runat="server" CssClass="button" OnClick="btnSubmit_Click" Text="Submit" />
    </p>
    <p>
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>

