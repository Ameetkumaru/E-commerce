﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class autopartsEntities : DbContext
{
    public autopartsEntities()
        : base("name=autopartsEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<productdb> productdbs { get; set; }
    public virtual DbSet<producttype> producttypes { get; set; }
    public virtual DbSet<admin> admins { get; set; }
    public virtual DbSet<user> users { get; set; }
    public virtual DbSet<guest> guests { get; set; }
    public virtual DbSet<cart> carts { get; set; }
    public virtual DbSet<warehouse> warehouses { get; set; }
}
