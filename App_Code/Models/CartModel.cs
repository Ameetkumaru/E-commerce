
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CartModel
/// </summary>
public class CartModel
{
    public string insertCart(cart cart)
    {
        try
        {
            autopartsEntities db = new autopartsEntities();
            //            AutopartsEntities db = new AutopartsEntities();
            db.carts.Add(cart);
            db.SaveChanges();

            return "Part number : "+cart.ProductId + " was successfully added to cart";

        }
        catch (Exception e)
        {
            return "Error :" + e;
        }
    }

    public string updateCart(int id, cart cart)
    {
        try
        {
            autopartsEntities db = new autopartsEntities();
            //Fetch
            cart p = db.carts.Find(id);
            p.DatePurchased = cart.DatePurchased;
            p.ClientId = cart.ClientId;
            p.Amount = cart.Amount;
            p.isInCart = cart.isInCart;
            p.ProductId = cart.ProductId;

            db.SaveChanges();

            return "Part number : "+cart.ProductId + " was successfully updated";

        }
        catch (Exception e)
        {
            return "Error :" + e;
        }
    }

    public string deleteCart(int id)
    {
        try
        {
            autopartsEntities db = new autopartsEntities();
           cart p = db.carts.Find(id);

            db.carts.Attach(p);
            db.carts.Remove(p);
            db.SaveChanges();
            return "Part was successfully deleted";
        }
        catch (Exception e)
        {
            return "Error :" + e;
        }

    }

    public List<cart> cartList(string auth)
    {
        try
        {
            using (autopartsEntities db = new autopartsEntities())
            {
                List<cart> wh = (from x in db.carts
                                      where x.authID == auth
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