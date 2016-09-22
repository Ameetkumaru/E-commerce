using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for WarehouseScreen
/// </summary>
public class WarehouseScreen
{
    public WarehouseScreen()
    {
    }

    public string printOrder(warehouse wh)
    {
        WarehouseControl wc = new WarehouseControl();
        string status = wc.printOrder(wh);
        return status;
    }

}