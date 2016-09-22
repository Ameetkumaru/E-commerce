using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
public partial class Pages_Management_ReceivingDesk : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            GetImages();
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void GetImages()
    {
        try
        {
            string[] images = Directory.GetFiles(Server.MapPath("~/Images/Products/"));

            ArrayList imageList = new ArrayList();
            foreach(string image in images)
            {
                string imageName = image.Substring(image.LastIndexOf(@"\",StringComparison.Ordinal)+1);
                imageList.Add(imageName);
            }
                        
            DImage.DataSource = imageList;
            DImage.AppendDataBoundItems = true;
            DImage.DataBind();
        }
        catch(Exception e)
        {
            lblResult.Text = e.ToString();
        }
    }

    private productdb createPart()
    {
        productdb product = new productdb();

        product.id = Convert.ToInt32(PartNum.SelectedValue);
        product.typeId = 1 ;
        product.name = "";
        product.qty = Convert.ToInt32(TxtQty.Text); 
        product.image = DImage.SelectedValue;

        return product;
    }
    
    protected void BtnSubmit_Click1(object sender, EventArgs e)
    {
        ReceivingDeskScreen r = new ReceivingDeskScreen();
        productdb p = createPart();

        lblResult.Text = r.insertParts(p);
    }       
}