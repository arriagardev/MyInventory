using MyInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInventory.Queries
{
    public static class ProductQueries
    {

        public static List<Product> FindRandomProducts(int number)
        {
            List<Product> _list = new List<Product>();
            Random rnd = new Random();
            for (int i = 0; i < number; i++)
            {
                int r = rnd.Next(ProductDB._products.Count);
                _list.Add(ProductDB._products.ElementAt(r));
            }            
            return _list;
        }

        public static IEnumerable<Product> FindRandomProducts(this IQueryable<Product> products, int number)
        {
            List<Product> _list = new List<Product>();
            Random rnd = new Random();
            for (int i = 0; i < number; i++)
            {
                int r = rnd.Next(products.Count());
                _list.Add(products.ElementAt(r));
            }
            return _list;
        }

        public static Product FindByID(this IQueryable<Product> products, string code)
        {
            return products.Single(r => r.Code == code);
        }
        
        public static Product FindTheMostExpensive(this IQueryable<Product> products)
        {
            return products.OrderByDescending(r => r.RetailCost).First();
        }
    }
}