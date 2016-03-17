using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMVC1.Models
{
    public interface IDatabaseLayer
    {
        List<Product> GetProducts();
        void AddProduct(Product product);
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}