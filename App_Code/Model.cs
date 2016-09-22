﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class admin
{
    public int id { get; set; }
    public int shipping { get; set; }
    public int handling { get; set; }
    public int localtax { get; set; }
}

public partial class cart
{
    public int id { get; set; }
    public string ClientId { get; set; }
    public Nullable<int> ProductId { get; set; }
    public int Amount { get; set; }
    public Nullable<System.DateTime> DatePurchased { get; set; }
    public bool isInCart { get; set; }
    public string authID { get; set; }
    public string partName { get; set; }

    public virtual productdb productdb { get; set; }
}

public partial class guest
{
    public int id { get; set; }
    public string name { get; set; }
    public string shippingAddress { get; set; }
}

public partial class productdb
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public productdb()
    {
        this.carts = new HashSet<cart>();
    }

    public int id { get; set; }
    public Nullable<int> typeId { get; set; }
    public string name { get; set; }
    public Nullable<int> qty { get; set; }
    public string image { get; set; }

    public virtual producttype producttype { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<cart> carts { get; set; }
}

public partial class producttype
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public producttype()
    {
        this.productdbs = new HashSet<productdb>();
    }

    public int id { get; set; }
    public string name { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<productdb> productdbs { get; set; }
}

public partial class user
{
    public int ClientId { get; set; }
    public string name { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public string number { get; set; }
    public string address { get; set; }
}

public partial class warehouse
{
    public int orderId { get; set; }
    public string paymentID { get; set; }
    public string Name { get; set; }
    public string shippingAddress { get; set; }
    public string packagingStatus { get; set; }
    public string ShippingStatus { get; set; }
    public string DeliveryStatus { get; set; }
}
