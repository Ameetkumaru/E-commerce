using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductTypeModel
/// </summary>
public class ProductTypeModel
{
    public string insertProductType(producttype productType)
    {
        try
        {
            autopartsEntities db = new autopartsEntities();
            db.producttypes.Add(productType);
            db.SaveChanges();

            return productType.name + " was successfully inserted";

        }
        catch (Exception e)
        {
            return "Error :" + e;
        }
    }

    public string updateProductType(int id, producttype productType)
    {
        try
        {
            autopartsEntities db = new autopartsEntities();
            //Fetch
            producttype p = db.producttypes.Find(id);
            p.name = productType.name;
        

            db.SaveChanges();

            return productType.name + " was successfully updated";

        }
        catch (Exception e)
        {
            return "Error :" + e;
        }
    }

    public string deleteProductType(int id)
    {
        try
        {
            autopartsEntities db = new autopartsEntities();
            producttype p = db.producttypes.Find(id);

            db.producttypes.Attach(p);
            db.producttypes.Remove(p);
            db.SaveChanges();
            return p.name + " was successfully deleted";
        }
        catch (Exception e)
        {
            return "Error :" + e;
        }

    }
}