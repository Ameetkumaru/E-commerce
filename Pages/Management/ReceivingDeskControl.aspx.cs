using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Management_ReceivingDeskControl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PurchaseCtrl pc = new PurchaseCtrl();
        List<productdb> product = pc.viewProducts();

        LegacyPartsDB l = new LegacyPartsDB();

        ReceivingDeskController r = new ReceivingDeskController();

        foreach (productdb prod in product)
        {
            string name = l.partName(prod.id);
            r.updateName(prod.id, name);
        }
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {

    }
}