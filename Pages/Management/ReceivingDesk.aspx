<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ReceivingDesk.aspx.cs" Inherits="Pages_Management_ReceivingDesk" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:Label ID="lblResult" runat="server"></asp:Label>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        Part Number :</p>
    <p>
        <asp:DropDownList ID="PartNum" runat="server" DataTextField="number" DataValueField="number" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="height: 22px" DataSourceID="SqlDataSource2">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:csci467ConnectionString %>" ProviderName="<%$ ConnectionStrings:csci467ConnectionString.ProviderName %>" SelectCommand="SELECT number, description, price FROM parts"></asp:SqlDataSource>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Quantity in hand :</p>
    <p>
        <asp:TextBox ID="TxtQty" runat="server"></asp:TextBox>
    </p>
    <p>
        Image :</p>
    <p>
        <asp:DropDownList ID="DImage" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click1" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>

