<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ChooseProduct.aspx.cs" Inherits="Pages_ChooseProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 510px;
        }
        .auto-style2 {
            font-size: 19px;
        }
        .auto-style4 {
            margin-bottom: 0px;
        }
        .auto-style5 {
            width: 510px;
            height: 124px;
        }
        .auto-style6 {
            width: 510px;
            height: 67px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td rowspan="4">
                <asp:Image ID="imgProduct" runat="server" CssClass="detailsImage" /></td>
             <td class="auto-style5"><h2>
                 <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label>
                &nbsp;
                 <hr class="auto-style4" />    
                 <h2>
                 <asp:Label ID="lblPrice" runat="server" CssClass="detailsPrice"></asp:Label></h2>
                 <strong><span class="auto-style2">Quantity</span></strong>&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="Quantity" runat="server" Height="16px" Width="160px"></asp:DropDownList>
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Button ID="btnAddCart" runat="server" CssClass="button" OnClick="btnAddCart_Click" Text="Add Product" Height="31px" Width="89px" />
                 <br/>
            </td>
        </tr>
         <tr>            
             <td class="auto-style6">
                 <asp:Label ID="Availability" runat="server" Text="Label"></asp:Label>
                 <br />
                 <br />
                 <asp:Label ID="lblResult" runat="server" CssClass="detailsMessage" Width="100%"></asp:Label>
                 <br />
             </td>
        </tr>
         <tr>
            <td class="auto-style1">&nbsp;</td>             
        </tr>
         <tr>
            <td class="auto-style1">&nbsp;</td>             
        </tr>
    </table>
</asp:Content>

