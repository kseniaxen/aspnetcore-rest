using System.Collections.Generic;

namespace WebApp.Models
{
    public class DataProducts
    {
        public List<Product> dataProductsList;
        public DataProducts()
        {
            Supplier s1 = new Supplier
            { SupplierId = 1, Name = "Splash Dudes", City = "San Jose" };
            Supplier s2 = new Supplier
            { SupplierId = 2, Name = "Soccer Town", City = "Chicago" };
            Supplier s3 = new Supplier
            { SupplierId = 3, Name = "Chess Co", City = "New York" };
            Category c1 = new Category { CategoryId = 1, Name = "Watersports" };
            Category c2 = new Category { CategoryId = 2, Name = "Soccer" };
            Category c3 = new Category { CategoryId = 3, Name = "Chess" };
            dataProductsList = new List<Product>();

            dataProductsList.Add(
                new Product
                {
                    ProductId = 1,
                    Name = "Kayak",
                    Price = 275,
                    Category = c1,
                    Supplier = s1
                });
            dataProductsList.Add(
                new Product
                {
                    ProductId = 2,
                    Name = "Lifejacket",
                    Price = 48.95m,
                    Category = c1,
                    Supplier = s1
                });
            dataProductsList.Add(
                 new Product
                 {
                     ProductId = 3,
                     Name = "Lifejacket",
                     Price = 48.95m,
                     Category = c1,
                     Supplier = s1
                 });
            dataProductsList.Add(
                new Product
                {
                    ProductId = 4,
                    Name = "Product5",
                    Price = 23.95m,
                    Category = c2,
                    Supplier = s2
                });
        }
    }
}