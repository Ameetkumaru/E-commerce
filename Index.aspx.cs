using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        fillPage();
    }


    private void fillPage()
    {
        OnlinePurchase fillproduct = new OnlinePurchase();
        List<productdb> product = fillproduct.viewProducts();

       // productdb desc = fillproduct.chooseProduct();
        LegacyPartsDB l = new LegacyPartsDB();

        List<part> pt = l.viewAllParts();
        /*
        if(product != null)
        {
            foreach(productdb prod in product)
            {
                Panel productPanel = new Panel();
                ImageButton imageButton = new ImageButton();
                Label lblName = new Label();

                imageButton.ImageUrl = "~/Images/Products/" + prod.image;
                imageButton.CssClass = "productImage";
                imageButton.PostBackUrl = "~/Pages/ChooseProduct.aspx?id=" + prod.id;

                lblName.Text = prod.name;
                lblName.CssClass = "productName";

                productPanel.Controls.Add(imageButton);
                productPanel.Controls.Add(new Literal { Text ="<br/>"});
                productPanel.Controls.Add(lblName);

                PartsDisplay.Controls.Add(productPanel);

            }
        }*/
        if (pt != null)
        {
            foreach (part prod in pt)
            {
                Panel productPanel = new Panel();
                ImageButton imageButton = new ImageButton();
                Label lblName = new Label();
                productdb img = fillproduct.chooseProduct(prod.number);

                if (img == null)
                {
                    imageButton.ImageUrl = "~/Images/Products/NoImageFound.jpg";
                    imageButton.CssClass = "productImage";
                    imageButton.PostBackUrl = "~/Pages/ChooseProduct.aspx?id=" + prod.number;
                }
                else
                {
                    imageButton.ImageUrl = "~/Images/Products/" + img.image;
                    imageButton.CssClass = "productImage";
                    imageButton.PostBackUrl = "~/Pages/ChooseProduct.aspx?id=" + prod.number;
                }
                lblName.Text = prod.description;
                lblName.CssClass = "productName";

                productPanel.Controls.Add(imageButton);
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                productPanel.Controls.Add(lblName);

                PartsDisplay.Controls.Add(productPanel);

            }
        }
        else
        {
            PartsDisplay.Controls.Add(new Literal { Text = "No Product found ...!!!" });
        }
    }
}