using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OnlinePurchase
/// </summary>
public class OnlinePurchase
{
    public productdb chooseProduct(int id)
    {
            PurchaseCtrl p = new PurchaseCtrl();
            productdb d = p.chooseProduct(id);
            return d;        
    }

    public List<productdb> viewProducts()
    {
        PurchaseCtrl p = new PurchaseCtrl();
        List<productdb> d = p.viewProducts();
        return d;
    }

    public List<productdb> viewProductByType(int typeId)
    {
        PurchaseCtrl p = new PurchaseCtrl();
        List<productdb> d = p.viewProductByType(typeId);
        return d;
    }

    public List<cart> validateProduct(int ClientID)
    {
        PurchaseCtrl p = new PurchaseCtrl();
        List<cart> c = p.validateProduct(ClientID);
        return c;
    }

    // Will return total number of quantity
    public int getCost(int ClientID)
    {
        PurchaseCtrl p = new PurchaseCtrl();
        int qty;
        return ( qty=p.getCost(ClientID));
    }

    public void updateInventory(int id, int quantity)
    {
        PurchaseCtrl p = new PurchaseCtrl();
        p.updateInventory(id,quantity);
    }

    //Will change the status of inInCart to false once part is purchased
    public void markOrdersAsPaid(List<cart> carts)
    {
        string s = "";
        PurchaseCtrl p = new PurchaseCtrl();
        p.markOrdersAsPaid(carts,s);        
    }



}