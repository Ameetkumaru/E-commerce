using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // string comp = Session["UserName"].ToString();
        if (!this.IsPostBack)
        {
            if (Session["UserName"] != null)
            {
                litStatus.Text = Session["UserName"].ToString() + " (Cart)";

                InkLogin.Visible = false;
                InkRegister.Visible = false;

                InkLogout.Visible = true;
               

                string sess = Session["UserName"].ToString();
                if (sess == "admin")
                {
                    litStatus.Visible = false;
                    HyperLink4.Visible = false;
                    HyperLink6.Visible = false;
                    //Response.Redirect("~/Pages/Management/AdminIndex.aspx");
                }
                else if (sess == "receiving")
                {
                    litStatus.Visible = false;
                    HyperLink3.Visible = false;
                    HyperLink6.Visible = false;
                }
                else if (sess == "warehouse")
                {
                    litStatus.Visible = false;
                    HyperLink3.Visible = false;
                    HyperLink4.Visible = false;
                }
                else
                {
                    litStatus.Visible = true;
                    HyperLink3.Visible = false;
                    HyperLink4.Visible = false;
                    HyperLink6.Visible = false;
                }
            }
            else
            {
                InkLogin.Visible = true;
                InkRegister.Visible = true;
                InkLogout.Visible = false;
                litStatus.Visible = false;
                HyperLink3.Visible = false;
                HyperLink4.Visible = false;
                HyperLink6.Visible = false;
            }
        }  
    }

    protected void InkLogout_Click(object sender, EventArgs e)
    {

    }
}
