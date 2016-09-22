using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Login
/// </summary>
public class Login
{
    public string register(user us)
    {
        try
        {
            LoginControl c = new LoginControl();
           
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
        LoginControl c = new LoginControl();
        return c.login(username, password);
    }

}