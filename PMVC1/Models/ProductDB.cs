using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMVC1.Models
{
    public class ProductDB : IDatabaseLayer
    {
        public static ProductDB Instance = new ProductDB();

        private ProductDB()
        {

        }

        List<Product> _products = new List<Product>
         {
            new Product {Id = 1, Name = "A", Price = 123},
            new Product {Id = 2, Name = "B", Price = 432}
         };

        public List<Product> GetProducts()
        {
           //return new List<Product>
           // {
           //    new Product {Id = 1, Name = "A", Price = 123},
           //    new Product {Id = 2, Name = "B", Price = 432}
           // };

            return _products;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
    }
}