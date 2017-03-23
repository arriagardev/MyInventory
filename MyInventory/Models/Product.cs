using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInventory.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Category { get; set; }
        public int Family { get; set; }
        public float WholeSaleCost { get; set; }
        public float RetailCost { get; set; }
        public string ImageUrl { get; set; }
    }
}