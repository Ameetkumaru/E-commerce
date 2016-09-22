using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Order
/// </summary>
public class Order
{
    public Order()
    {
    }

    public string printOrder(warehouse wh)
    {
        try
        {
            autopartsEntities db = new autopartsEntities();

            db.warehouses.Add(wh);
            db.SaveChanges();

            return "success";

        }
        catch (Exception e)
        {
            return "Error :" + e;
        }
    }

    public List<warehouse> orderList(string auth)
    {
        try
        {
            using (autopartsEntities db = new autopartsEntities())
            {
               List<warehouse> wh = (from x in db.warehouses
                                where x.paymentID == auth
                                select x).ToList();
                return wh;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }
}