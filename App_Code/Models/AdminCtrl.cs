using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AdminCtrl
/// </summary>
public class AdminCtrl
{
    public admin getCost(int id)
    {
        Cost c = new Cost();
        admin ad = c.getCost(id);
        return ad;
    }

    public string setCost(admin a)
    {
        Cost c = new Cost();
        string message = c.setCost(a);
        return message;
    }

}