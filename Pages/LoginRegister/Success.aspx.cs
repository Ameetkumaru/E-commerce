using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_LoginRegister_Success : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        authCode.Text = Session["AuthCode"].ToString();

        string uname = Session["UserName"].ToString();
        Customer cm = new Customer();
        int cid;
        if (uname == "Guest")
        {
            cid = -1;
        }
        else
        {
            cid = cm.returnClientID(uname);
        }
        PurchaseCtrl p = new PurchaseCtrl(); 
        List<cart> carts = p.validateProduct(cid);
        foreach(cart cart in carts)
        {
            int q = Convert.ToInt32(cart.ProductId);
            p.inventoryUpdate(q,cart.Amount);
        }
        string auth = Session["AuthCode"].ToString();
        p.markOrdersAsPaid(carts,auth);
        Customer cust = new Customer();

        string wName, wAddress;
        if (cid ==(-1))
        {
            guest gue = cust.getGuestDetail(1);
            wName = gue.name;
            wAddress = gue.shippingAddress;
        }
        else
        {
            user use = cust.getUserDetail(cid);
            wName = use.name;
            wAddress = use.address;
        }

        warehouse wh = new warehouse
        {
            paymentID = auth ,
            Name = wName ,
            shippingAddress = wAddress ,
            packagingStatus = "ReadyToPacked",
            ShippingStatus = "NotShipped" ,
            DeliveryStatus = "NotDelivered"            
        };
        WarehouseScreen ws = new WarehouseScreen();
        string report = ws.printOrder(wh);

    }
}