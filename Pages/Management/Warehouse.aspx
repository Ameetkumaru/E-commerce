<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Warehouse.aspx.cs" Inherits="Pages_Management_Warehouse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="3" DataKeyNames="orderId" DataSourceID="WList" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:BoundField DataField="orderId" HeaderText="orderId" InsertVisible="False" ReadOnly="True" SortExpression="orderId" />
            <asp:BoundField DataField="paymentID" HeaderText="paymentID" SortExpression="paymentID" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="shippingAddress" HeaderText="shippingAddress" SortExpression="shippingAddress" />
            <asp:BoundField DataField="packagingStatus" HeaderText="packagingStatus" SortExpression="packagingStatus" />
            <asp:BoundField DataField="DeliveryStatus" HeaderText="DeliveryStatus" SortExpression="DeliveryStatus" />
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Print Invoice" ShowHeader="True" Text="PrintInvoice" />
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
    <asp:SqlDataSource ID="WList" runat="server" ConnectionString="<%$ ConnectionStrings:autopartsConnectionString %>" ProviderName="<%$ ConnectionStrings:autopartsConnectionString.ProviderName %>" SelectCommand="SELECT orderId, paymentID, Name, shippingAddress, packagingStatus, DeliveryStatus FROM warehouse WHERE (DeliveryStatus &lt;&gt; 'Delivered')" UpdateCommand="UPDATE warehouse SET packagingStatus = @packagingStatus, DeliveryStatus = @DeliveryStatus WHERE (orderId = @orderId)"></asp:SqlDataSource>
    <br />
    <br />
    Order which are delivered :
    <br />
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="orderId" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="orderId" HeaderText="orderId" InsertVisible="False" ReadOnly="True" SortExpression="orderId" />
            <asp:BoundField DataField="paymentID" HeaderText="paymentID" SortExpression="paymentID" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="shippingAddress" HeaderText="shippingAddress" SortExpression="shippingAddress" />
            <asp:BoundField DataField="DeliveryStatus" HeaderText="DeliveryStatus" SortExpression="DeliveryStatus" />
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Print Order" ShowHeader="True" Text="Print Order" />
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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:autopartsConnectionString %>" ProviderName="<%$ ConnectionStrings:autopartsConnectionString.ProviderName %>" SelectCommand="SELECT orderId, paymentID, Name, shippingAddress, DeliveryStatus FROM warehouse WHERE (DeliveryStatus = 'Delivered')"></asp:SqlDataSource>
    <br />
    <br />
    <asp:Literal ID="orderID" runat="server"></asp:Literal>
    <br />
</asp:Content>

