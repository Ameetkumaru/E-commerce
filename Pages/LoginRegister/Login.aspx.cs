using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_LoginRegister_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {

    }

    protected void submit_Click(object sender, EventArgs e)
    {
        string uname = username.Text;
        string pass = password.Text;

        Login l = new Login();

        int value = l.login(uname,pass);
        if (value != 0)
        {
            Session["UserName"] = username.Text.Trim();
            string n = Session["UserName"].ToString();
            if(n=="admin")
            {
                Response.Redirect("~/Pages/Management/AdminIndex.aspx");
            }
            else if(n=="receiving")
            {
                Response.Redirect("~/Pages/Management/ReceivingDeskControl.aspx");
            }
            else if(n=="warehouse")
            {
                Response.Redirect("~/Pages/Management/Warehouse.aspx");
            }
            else
                Response.Redirect("~/Index.aspx");
        }
        else
            litStatus.Text = "Credential did not match !!! Please enter correct details.. ";
    }

    protected void Guest_Click(object sender, EventArgs e)
    {
        string uname = "Guest";     
               
         Session["UserName"] = uname.Trim();
        string gname = GuestName.Text;
        string gaddress = GuestAddress.Text;

        if ((gname == ""))
        {
            litStatus.Text = "Enter the Name and Shiping Address";
        }
        else if((gaddress == ""))
        {
            litStatus.Text = "Enter the Name and Shiping Address";
        }
        else
        {
            Customer c = new Customer();
            guest g = new guest();
            g.name = gname;
            g.shippingAddress = gaddress;

            string res = c.updateGuest(g);
            if (res == "success")
            {
                Response.Redirect("~/Index.aspx");
            }
            else
            {
                litStatus.Text = "Enter the Name and Shiping Address";
            }

        }
    }       
}