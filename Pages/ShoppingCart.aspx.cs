using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ShoppingCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string username = Session["UserName"].ToString();
        Customer c = new Customer();
        int clID = c.returnClientID(username);
        int val;
        if (username.Equals("Guest"))
        {
            val = -1;
        }
        else
        {
            val = clID;
        }
        if (username != null)
        {
            getAllProductsInCart(val);
           // litStatus.Text = "  CleintID exist";
        }
        
    }
     
    private void getAllProductsInCart(int uname)
    {
        double subTotal = 0;
        OnlinePurchase o = new OnlinePurchase();

        List<cart> productsInCart = o.validateProduct(uname);
       
        CreateShopTable(productsInCart, out subTotal);

            AdminIndex admin = new AdminIndex();
            admin a = admin.getCost(1);


            double tax = ((a.localtax * subTotal) / 100);
            double tx = Math.Round((tax), 2);
            double shipping = a.shipping;
            double handling = a.handling;

            double totalAmount = subTotal + tax + shipping + handling;
            double finalamount = Math.Round((totalAmount), 2);
            double sbamount = Math.Round((subTotal), 2);

            Session["TotalAmount"] = finalamount.ToString().Trim();

            litShowTax.Text = a.localtax.ToString() + "  %";
            litTotal.Text = sbamount.ToString();
            litTax.Text = tx.ToString();
            litHandling.Text = handling.ToString();
            litShipping.Text = shipping.ToString();
            litTotalAmount.Text = finalamount.ToString();
            NoCart.Visible = false;
       
    }

    private void CreateShopTable(IEnumerable<cart> carts, out double subTotal)
    {
        subTotal = new double();

        ReceivingDeskScreen model = new ReceivingDeskScreen();
//        ProductModel model = new ProductModel();

        foreach (cart cart in carts)
        {
            int pid = Convert.ToInt32(cart.ProductId);
            //Create HTML elements and fill values with database data
            productdb product = model.GetProduct(pid);
            LegacyPartsDB l = new LegacyPartsDB();
            part pt = l.chooseParts(pid);

            ImageButton btnImage = new ImageButton
            {
                ImageUrl = string.Format("~/Images/Products/{0}",   product.image),
                PostBackUrl = string.Format("~/Pages/ChooseProduct.aspx?id={0}", product.id)
            };

            LinkButton lnkDelete = new LinkButton
            {
                PostBackUrl = string.Format("~/Pages/ShoppingCart.aspx?productId={0}", cart.id),
                Text = "Delete Item",
                ID = "del" + cart.id,
            };

            lnkDelete.Click += Delete_Item;

            //Fill amount list with numbers

            int q = Convert.ToInt32(product.qty);
            int[] amount = Enumerable.Range(1, q).ToArray();
            DropDownList ddlAmount = new DropDownList
            {
                DataSource = amount,
                AppendDataBoundItems = true,
                AutoPostBack = true,
                ID = cart.id.ToString()
            };
            ddlAmount.DataBind();
            ddlAmount.SelectedValue = cart.Amount.ToString();
            ddlAmount.SelectedIndexChanged += ddlAmount_SelectedIndexChanged;


            //Create table to hold shopping cart details
            Table table = new Table { CssClass = "CartTable" };
            TableRow row1 = new TableRow();
            TableRow row2 = new TableRow();

            TableCell cell1_1 = new TableCell { RowSpan = 2, Width = 50 };
            TableCell cell1_2 = new TableCell
            {
                Text = string.Format("<h4>{0}</h4><br />{1}<br/>In Stock",
                pt.description, "Item No:" + product.id),
                HorizontalAlign = HorizontalAlign.Left,
                Width = 350,
            };
            TableCell cell1_3 = new TableCell { Text = "Unit Price<hr/>" };
            TableCell cell1_4 = new TableCell { Text = "Quantity<hr/>" };
            TableCell cell1_5 = new TableCell { Text = "Item Total<hr/>" };
            TableCell cell1_6 = new TableCell();
            double pri = Convert.ToDouble(pt.price);
            TableCell cell2_1 = new TableCell();
            TableCell cell2_2 = new TableCell { Text = "$ " + pt.price };
            TableCell cell2_3 = new TableCell();
            TableCell cell2_4 = new TableCell { Text = "$ " + Math.Round((cart.Amount * pri), 2) };
            TableCell cell2_5 = new TableCell();
             

            //Set custom controls
            cell1_1.Controls.Add(btnImage);
            cell1_6.Controls.Add(lnkDelete);
            cell2_3.Controls.Add(ddlAmount);

            //Add rows & cells to table
            row1.Cells.Add(cell1_1);
            row1.Cells.Add(cell1_2);
            row1.Cells.Add(cell1_3);
            row1.Cells.Add(cell1_4);
            row1.Cells.Add(cell1_5);
            row1.Cells.Add(cell1_6);

            row2.Cells.Add(cell2_1);
            row2.Cells.Add(cell2_2);
            row2.Cells.Add(cell2_3);
            row2.Cells.Add(cell2_4);
            row2.Cells.Add(cell2_5);
            table.Rows.Add(row1);
            table.Rows.Add(row2);
            ShoppingCart.Controls.Add(table);


            //Add total of current purchased item to subtotal
            //Math.Round((subTotal += (cart.Amount * pri)), 2);
            subTotal += (cart.Amount * pri);
            

        }

        //Add selected objects to Session
        //Session[User.Identity.GetUserId()] = carts;
    }

    private void ddlAmount_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Get ID of product that has had its quantity dropdownlist changed.
        DropDownList selectedList = (DropDownList)sender;
        int cartId = Convert.ToInt32(selectedList.ID);
        int quantity = Convert.ToInt32(selectedList.SelectedValue);

        //Update purchase with new quantity and refresh page
        PurchaseCtrl purchase = new PurchaseCtrl();
        purchase.updateInventory(cartId,quantity);
        Response.Redirect("~/Pages/ShoppingCart.aspx");
    }

    private void Delete_Item(object sender, EventArgs e)
    {
        LinkButton selectedLink = (LinkButton)sender;
        string link = selectedLink.ID.Replace("del", "");
        int cartId = Convert.ToInt32(link);

        var cartModel = new CartModel();
        cartModel.deleteCart(cartId);

        Response.Redirect("~/Pages/ShoppingCart.aspx");
    }
}