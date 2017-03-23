using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyInventory.Models
{
    public class MyInventoryDB : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}