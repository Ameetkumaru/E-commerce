using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for WarehouseControl
/// </summary>
public class WarehouseControl
{
    public WarehouseControl()
    {}

    public string printOrder(warehouse wh)
    {
        Order od = new Order();
        string status = od.printOrder(wh);
        return status;
    }

}