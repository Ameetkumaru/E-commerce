using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ReceivingDeskScreen
/// </summary>
public class ReceivingDeskScreen
{

    public string insertParts(productdb product)
    {
        try
        {
            ReceivingDeskController r = new ReceivingDeskController();

            string message = r.insertParts(product);

            return message;

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
            ReceivingDeskController r = new ReceivingDeskController();

            string message = r.updateParts(id, product);

            return message;

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
            ReceivingDeskController r = new ReceivingDeskController();

            string message = r.deleteParts(id);

            return message;
        }
        catch (Exception e)
        {
            return "Error :" + e;
        }

    }


    public productdb GetProduct(int id)
    {
        ReceivingDeskController r = new ReceivingDeskController();
        productdb p = r.GetProduct(id);
        return p;
    }
}