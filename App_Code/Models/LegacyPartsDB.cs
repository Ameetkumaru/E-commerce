using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LegacyPartsDB
/// </summary>
public class LegacyPartsDB
{
    public part chooseParts(int id)
    {
        try
        {
            using (csci467Entities db = new csci467Entities())
            {
                part p = db.parts.Find(id);
                
                return p;
            }
        }
        catch (Exception e )
        {
            throw e;
        }
    }

    public string partName(int id)
    {
        try
        {
            using (csci467Entities db = new csci467Entities())
            {
                part p = db.parts.Find(id);
                string name = p.description;
                return name;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }


    public List<part> viewAllParts()
    {

        try
        {
            using (csci467Entities db = new csci467Entities())
            {
                List<part> p = (from x in db.parts
                                select x).ToList();
                return p;
            }
        }
        catch (Exception)
        {
            return null;
        }

    }
}