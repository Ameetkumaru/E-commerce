using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ChooseProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Session["UserName"] != null)
        {
            string uname = Session["UserName"].ToString();
            if (uname == "admin")
            {
                btnAddCart.Visible = false;
                Quantity.Visible = false;
                fillPartDetails();
            }
            else if (uname == "receiving")
            {
                btnAddCart.Visible = false;
                Quantity.Visible = false;
                fillPartDetails();
            }
            else if (uname == "warehouse")
            {
                btnAddCart.Visible = false;
                Quantity.Visible = false;
                fillPartDetails();
            }
            else
                fillPartDetails();
        }
        else
        {
            btnAddCart.Visible = false;
            fillPartDetails();
        }
    }

    private void fillPartDetails()
    {
        if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            OnlinePurchase choosePart = new OnlinePurchase();
            productdb product = choosePart.chooseProduct(id);

            LegacyPartsDB l = new LegacyPartsDB();
            part pt = l.chooseParts(id);

            lblPrice.Text = "Price per Unit : $ " + pt.price;
            lblTitle.Text = pt.description;


            if (product == null)
            {
                imgProduct.ImageUrl = "~/Images/Products/NoImageFound.jpg";

                //int q = Convert.ToInt32(product.qty);
                //if (q == null)
                Quantity.Visible = false;
                //int[] qty = Enumerable.Range(0, 0).ToArray();
                //Quantity.DataSource = qty;
                //Quantity.AppendDataBoundItems = true;
                //Quantity.DataBind();
                Availability.Text = "Not available";
                btnAddCart.Visible = false;
            }
            else
            {
                imgProduct.ImageUrl = "~/Images/Products/" + product.image;

                int q = Convert.ToInt32(product.qty);

                if (q == 0)
                {
                    Quantity.Visible = false;
                    Availability.Text = "Not available";
                    btnAddCart.Visible = false;
                }
                else
                {
                    int[] qty = Enumerable.Range(1, q).ToArray();
                    Quantity.DataSource = qty;
                    Quantity.AppendDataBoundItems = true;
                    Quantity.DataBind();
                    Availability.Text = "Available";

                }
            }   
        }
    }
    


    protected void btnAddCart_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            string usname = Session["UserName"].ToString();
            Customer c = new Customer();
            int clID = c.returnClientID(usname);

            string clientId;

           if (usname.Equals("Guest"))
            {
                clientId = "-1";
            }
            else
            {
                 clientId = clID.ToString();
            }

            LegacyPartsDB legacy = new LegacyPartsDB();   
            int id = Convert.ToInt32(Request.QueryString["id"]);
            int qty = Convert.ToInt32(Quantity.SelectedValue);
            string ptname = legacy.partName(id);

            cart cart = new cart
            {
                ClientId = clientId,
                Amount = qty,
                ProductId = id,
                DatePurchased = DateTime.Now,
                isInCart = true,
                partName = ptname                              
            };

            CartModel ct = new CartModel();

            lblResult.Text = ct.insertCart(cart);
        }
        else
        {
            lblResult.Text = "No product added..";
        }
    }
}  