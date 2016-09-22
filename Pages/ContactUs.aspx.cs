using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ContactUs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string name =TxtName.Text;
       // lblResult.Text = " Thank you  for submitting your detail ..";
       lblResult.Text = " Thank you " + name + " for submitting your detail ..";
    }
}