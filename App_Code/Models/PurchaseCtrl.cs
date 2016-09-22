
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PurchaseCtrl
/// </summary>
public class PurchaseCtrl
{
    public productdb chooseProduct(int id)
    {
        try
        {
            using (autopartsEntities db = new autopartsEntities())
            {
                productdb product = db.productdbs.Find(id);
                return product;
            }
        }
        catch(Exception )
        {
            return null;
        }
    }

    public List<productdb> viewProducts()
    {
        try
        {
            using (autopartsEntities db = new autopartsEntities())
            {
                List<productdb> products = (from x in db.productdbs
                                            select x).ToList();
                return products;
            }
        }
        catch (Exception )
        {
            return null;
        }
    }

    public List<productdb> viewProductByType(int typeId)
    {
        try
        {
            using (autopartsEntities db = new autopartsEntities())
            {
                List<productdb> products = (from x in db.productdbs
                                            where x.typeId == typeId 
                                            select x).ToList();
                return products;
            }
        }
        catch (Exception )
        {
            return null;
        }
    }

    // will return all parts added to cart for particular user 
    public List<cart> validateProduct(int ClientID)
    {
        string client = ClientID.ToString();
        autopartsEntities db = new autopartsEntities();
        List<cart> orders = (from x in db.carts
                             where x.ClientId == client
                             && x.isInCart
                             orderby x.DatePurchased
                             select x).ToList();

        return orders;
    }

    // Will return total number of quantity
    public int getCost(int ClientID)
    {
        try
        {
            string client = ClientID.ToString();
            autopartsEntities db = new autopartsEntities();
            int total = (from x in db.carts
                                 where x.ClientId == client
                                 && x.isInCart
                                 select x.Amount).Sum();
            return total;
        }
        catch
        {
            return 0;
        }
    }

    public void updateInventory(int id,int quantity)
    {
        autopartsEntities db = new autopartsEntities();
        cart c = db.carts.Find(id);
        c.Amount = quantity;
        db.SaveChanges();

    }

    // Inventory Update
    public void inventoryUpdate(int id,int quantity)
    {
        autopartsEntities db = new autopartsEntities();
        productdb p = db.productdbs.Find(id);
        
        p.qty = p.qty-quantity;
        db.SaveChanges();

    }

//Will change the status of inInCart to false once part is purchased
public void markOrdersAsPaid(List<cart> carts,string auth)
    {
        autopartsEntities db = new autopartsEntities();
        
        if (carts != null)
        {
            foreach(cart cart in carts)
            {
                cart oldcart = db.carts.Find(cart.id);
                oldcart.DatePurchased = DateTime.Now;
                oldcart.isInCart = false;
                oldcart.authID = auth ;
            }
            db.SaveChanges();
        }
    }

}