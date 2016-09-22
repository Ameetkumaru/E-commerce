/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductModel
/// </summary>
public class ProductModel
{
    public string insertProduct(product product)
    {
        try
        {
            AutopartsEntities db = new AutopartsEntities();
            db.products.Add(product);
            db.SaveChanges();

            return product.name + "was successfully inserted";

        }catch(Exception e)
        {
            return "Error :" + e;
        }
    }

    public string updateProduct(int id,product product)
    {
        try
        {
            AutopartsEntities db = new AutopartsEntities();
            //Fetch
            product p = db.products.Find(id);
            p.name = product.name;
            p.price = product.price;
            p.typeId = product.typeId;
            p.description = product.description;
            p.image = product.image;

            db.SaveChanges();

            return product.name + "was successfully updated";

        }
        catch (Exception e)
        {
            return "Error :" + e;
        }
    }

    public string deleteProduct(int id)
    {
        try
        {
            AutopartsEntities db = new AutopartsEntities();
            product p = db.products.Find(id);

            db.products.Attach(p);
            db.products.Remove(p);
            db.SaveChanges();
            return p.name + "was successfully deleted";
        }
        catch (Exception e)
        {
            return "Error :" + e;
        }

    }
}




*/