<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AdminIndex.aspx.cs" Inherits="Pages_Management_AdminIndex" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    Please find the Rates set by Admin.</p>
<p>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="AdminRates" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="shipping" HeaderText="shipping" SortExpression="shipping" />
            <asp:BoundField DataField="handling" HeaderText="handling" SortExpression="handling" />
            <asp:BoundField DataField="localtax" HeaderText="localtax" SortExpression="localtax" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <asp:SqlDataSource ID="AdminRates" runat="server" ConnectionString="server=localhost;user id=root;database=Autoparts;allowuservariables=True;password=Ameet1234$k" DeleteCommand="DELETE FROM admin WHERE (id = @id)" ProviderName="MySql.Data.MySqlClient" SelectCommand="SELECT id, shipping, handling, localtax FROM admin" UpdateCommand="UPDATE admin SET handling = @handling, shipping = @shipping, localtax = @localtax WHERE (id = @id)"></asp:SqlDataSource>
</p>
<p>
    &nbsp;</p>
</asp:Content>

