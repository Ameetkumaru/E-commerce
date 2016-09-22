using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LoginControl
/// </summary>
public class LoginControl
{
    public string register(user us)
    {
        try
        {
            Customer c = new Customer();

            string message = c.register(us);

            return message;

        }
        catch (Exception e)
        {
            return "Error :" + e;
        }
    }
    public int login(string username, string password)
    {       
            Customer c = new Customer();
            return c.login(username, password);       
    }
}