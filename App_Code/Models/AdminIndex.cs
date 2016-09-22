using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AdminIndex
/// </summary>
public class AdminIndex
{
    public admin getCost(int id)
    {

        AdminCtrl a = new AdminCtrl();
        admin ad = a.getCost(id);
        return ad;
    }

    public string setCost(admin a)
    {
        AdminCtrl ad = new AdminCtrl();
        string message = ad.setCost(a);
        return message;
    }
}