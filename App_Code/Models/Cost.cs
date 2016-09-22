using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Cost
/// </summary>
public class Cost
{
    public admin getCost(int id)
    {
        try
        {
            autopartsEntities db = new autopartsEntities();
            admin ad = db.admins.Find(id);
            admin a = new admin();

            a.shipping = ad.shipping ;
            a.handling = ad.handling;
            a.localtax = ad.localtax;

            return a;
        }
        catch (Exception )
        {
            return null;
        }
    }

    public string setCost(admin a)
    {
        try
        {
            autopartsEntities db = new autopartsEntities();
            //Fetch
            admin ad = db.admins.Find(a.id);

            ad.shipping = a.shipping;
            ad.handling = a.handling;
            ad.localtax = a.localtax;

            db.SaveChanges();

            return "All the rates were successfully updated";

        }
        catch (Exception e)
        {
            return "Error :" + e;
        }
    }

    
}