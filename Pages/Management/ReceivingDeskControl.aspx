<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ReceivingDeskControl.aspx.cs" Inherits="Pages_Management_ReceivingDeskControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
   
    <br />
     <asp:GridView ID="getProduct" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="ReceivingTeamProductDetails" Width="50%" CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="30">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
            <asp:BoundField DataField="qty" HeaderText="qty" SortExpression="qty" />
            <asp:BoundField DataField="image" HeaderText="image" SortExpression="image" />
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
    <asp:SqlDataSource ID="ReceivingTeamProductDetails" runat="server" ConnectionString="<%$ ConnectionStrings:autopartsConnectionString %>" DeleteCommand="DELETE FROM productdb WHERE (id = @id)" ProviderName="<%$ ConnectionStrings:autopartsConnectionString.ProviderName %>" SelectCommand="SELECT id, name, qty, image FROM productdb" UpdateCommand="UPDATE productdb SET name = @name, qty = @qty, image = @image WHERE (id = @id)"></asp:SqlDataSource>
    <br />
      <asp:LinkButton ID="LinkButton1" runat="server" CssClass="button" PostBackUrl="~/Pages/Management/ReceivingDesk.aspx">Add new part details</asp:LinkButton>
    
</asp:Content>

