﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Management_ManageProductTypes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ProductTypeModel model = new ProductTypeModel();
        producttype p = createProductType();

        lblResult.Text = model.insertProductType(p); 

    }

    private producttype createProductType()
    {
        producttype p = new producttype();

        p.name = txtName.Text;

        return p;
    }
}