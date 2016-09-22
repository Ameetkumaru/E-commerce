using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

public partial class Pages_LoginRegister_Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    private user userCreate()
    {
        user u = new user();

        u.name = Name.Text;
        u.username = username.Text;
        u.password = Password.Text;
        u.number = PhoneNumber.Text;
        u.address = Address.Text;
        return u;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Password.Text !="" && username.Text !="" && Name.Text !="")
        {
            if (Password.Text == ConfirmPassword.Text)
            {
                try
                {
                    Login l = new Login();
                    user u = userCreate();
                    litStatus.Text = l.register(u);
                    Session["UserName"] = this.username.Text.Trim();
                    Response.Redirect("~/Index.aspx");
                }
                catch (Exception ex)
                {
                    litStatus.Text = ex.ToString();
                }
            }
            else
            {
                litStatus.Text = "Password does not match  ";
            }
        }
        else
        {
            litStatus.Text = "Please enter the * field  ";
        }

    }
}
