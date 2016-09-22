using System;
using System.Collections.Generic;
using System.Linq;
using System.Web; 

/// <summary>
/// Summary description for ReceivingDeskController
/// </summary>
public class ReceivingDeskController
{
    public string insertParts(productdb product)
    {
        try
        {
            autopartsEntities db = new autopartsEntities();
            db.productdbs.Add(product);
            db.SaveChanges();

            return product.name + " was successfully inserted";

        }
        catch (Exception e)
        {
            return "Error :" + e;
        }
    }

    public string updateParts(int id, productdb product)
    {
        try
        {
            autopartsEntities db = new autopartsEntities();
            //Fetch
            productdb p = db.productdbs.Find(id);
            p.name = product.name;
            p.typeId = product.typeId;
            p.qty = product.qty;
            p.image = product.image;

            db.SaveChanges();

            return product.name + " was successfully updated";

        }
        catch (Exception e)
        {
            return "Error :" + e;
        }
    }

    public string deleteParts(int id)
    {
        try
        {
            autopartsEntities db = new autopartsEntities();
            productdb p = db.productdbs.Find(id);

            db.productdbs.Attach(p);
            db.productdbs.Remove(p);
            db.SaveChanges();
            return p.name + " was successfully deleted";
        }
        catch (Exception e)
        {
            return "Error :" + e;
        }

    }

    public productdb GetProduct(int id)
    {
        try
        {
            using (autopartsEntities db = new autopartsEntities())
            {
                productdb product = db.productdbs.Find(id);
                return product;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }

    public void updateName(int id,string partname )
    {
        try
        {
            autopartsEntities db = new autopartsEntities();
            //Fetch
            productdb p = db.productdbs.Find(id);
            p.name = partname;            
            db.SaveChanges();

        }
        catch (Exception)
        {
            
        }
    }
}