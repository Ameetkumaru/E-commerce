<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="Pages_ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 441px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <asp:Panel ID="ShoppingCart" runat="server">
           <asp:Literal ID="NoCart" runat="server"></asp:Literal>
           <br />
       </asp:Panel>
           <table>
               <tr>
                   <td class="auto-style1">  <b>Total : </b></td>
                   <td> <asp:Literal ID="litTotal" runat="server" Text=""></asp:Literal> </td>  
               </tr>

               <tr>
                   <td class="auto-style1">  <b>Tax :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:Literal ID="litShowTax" runat="server"></asp:Literal>
                       </b></td>
                   <td> <asp:Literal ID="litTax" runat="server" Text=""></asp:Literal> </td>  
               </tr>

               <tr>
                   <td class="auto-style1">  <b>Shipping : </b></td>
                   <td> <asp:Literal ID="litShipping" runat="server" Text=""></asp:Literal> </td>  
               </tr>

               <tr>
                   <td class="auto-style1">  <b>Handling : </b></td>
                   <td> <asp:Literal ID="litHandling" runat="server" Text=""></asp:Literal> </td>  
               </tr>

               <tr>
                   <td class="auto-style1">  <b>Total Amount : </b></td>
                   <td> <asp:Literal ID="litTotalAmount" runat="server" Text=""></asp:Literal> </td>  
               </tr>

               <tr>
                   <td class="auto-style1">
                       <asp:LinkButton ID="InkContinue" runat="server" PostBackUrl="~/Index.aspx" Text="Continue Shopping"></asp:LinkButton>
                       OR
                       <asp:Button ID="checkOut" runat="server" Text="CheckOut" CssClass="button" Width="250px" PostBackUrl="~/Pages/CPSGateway.aspx" />
                   </td>
               </tr>

           </table>
      
</asp:Content>

