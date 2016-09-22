using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Customer
/// </summary>
public class Customer
{
    public string register(user us)
    {
        try
        {
            autopartsEntities db = new autopartsEntities();
            db.users.Add(us);
            db.SaveChanges();

            return us.username + " was successfully register.";

        }
        catch (Exception e)
        {
            return "Error :" + e;
        }
    }

    public int returnClientID(string username)
    {
        try
        {

            using (autopartsEntities db = new autopartsEntities())
            {
                List<user> us = (from x in db.users
                                 where x.username == username
                                 select x).ToList();
                foreach (user user in us)
                {
                    return user.ClientId;
                }
                return 0;
            }
        }
        catch (Exception )
        {
            return 0;
        }
    }


    public int login(string username, string password)
    {
        try
        {
            using (autopartsEntities db = new autopartsEntities())
            {
                List<user> us = (from x in db.users
                                 where x.username == username
                                 select x).ToList();
                foreach (user user in us)
                {
                    if (user.password == password)
                        return 1;
                }
                return 0;
            }
        }
        catch (Exception )
        {
            return 0;
        }
    }


    public string updateGuest(guest g)
    {
        try
        {
            autopartsEntities db = new autopartsEntities();
            //Fetch
            guest guest = db.guests.Find(1);
     
            guest.name = g.name;
            guest.shippingAddress = g.shippingAddress;
            db.SaveChanges();

            return "success";
        }
        catch (Exception e)
        {
            return "Error :" + e;
        }
    }

    public guest getGuestDetail(int id)
    {
        try
        {
            using (autopartsEntities db = new autopartsEntities())
            {
                guest gu = db.guests.Find(id);

                return gu;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }

    public user getUserDetail(int id)
    {
        try
        {
            using (autopartsEntities db = new autopartsEntities())
            {
                user us = db.users.Find(id);

                return us;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }
}