using MyInventory.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInventory.Models
{
    public static class ProductDB
    {        
        static ProductDB()
        {
            _products = new List<Product>();
            _products.Add(new Product
            {
                Code = "0001",
                Name = "MK Men Shave Foam",
                Family = 1,
                Category = 1,
                WholeSaleCost = 90,
                RetailCost = 180,
                ImageUrl = "/images/prod/mary-kay-mkmen-shave-foam.png"
            });

            _products.Add(new Product
            {
                Code = "0002",
                Name = "MK Men Facial Wash",
                Family = 1,
                Category = 1,
                WholeSaleCost = 80,
                RetailCost = 160,
                ImageUrl = "/images/prod/24108GB_003_MKMen_Facial.png"
            });

            _products.Add(new Product
            {
                Code = "0003",
                Name = "MK Men Cooling After-Shave Gel",
                Family = 1,
                Category = 1,
                WholeSaleCost = 85,
                RetailCost = 170,
                ImageUrl = "/images/prod/mary-kay-mkmen-cooling-after-shave-gel.png"
            });
        }

        public static List<Product> _products;

        //public ProductQueries MyProducts = new ProductQueries();
    }
}