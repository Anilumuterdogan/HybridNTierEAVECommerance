using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Extensions
{
    public class ProductDataSeedExtension
    {
        public static void SeedProducts(ModelBuilder modelBuilder)
        {

            List<Product> products = new();
            
                Product p1 = new()
                {
                    ID = 1,
                    ProductName = "Msi GF7666Laptop",
                    UnitPrice = 1200,
                    UnitsInStock = 100,
                    CategoryID = 2,
                    ImagePath = new Images().Nightlife()
                };
                products.Add(p1);
            
                Product p2 = new()
                {
                    ID = 2,
                    ProductName = "Iphone 14 Pro Max",
                    UnitPrice = 1400,
                    UnitsInStock = 100,
                    CategoryID = 2,
                    ImagePath = new Images().Nightlife()
                };
                products.Add(p2);

                Product p3 = new()
                {
                    ID = 3,
                    ProductName = "T-Shirt",
                    UnitPrice = 20,
                    UnitsInStock = 100,
                    CategoryID = 1,
                    ImagePath = new Images().Nightlife()
                };
                products.Add(p2);

            modelBuilder.Entity<Product>().HasData(products);
            
            
            //ProductAttributes

            //Product1
            modelBuilder.Entity<ProductAttribute>().HasData(new ProductAttribute
            {
                ProductID = 1,
                AttributeID = 1
            });
            modelBuilder.Entity<ProductAttribute>().HasData(new ProductAttribute
            {
                ProductID = 1,
                AttributeID = 2
            });
            modelBuilder.Entity<ProductAttribute>().HasData(new ProductAttribute
            {
                ProductID = 1,
                AttributeID = 3
            });
            modelBuilder.Entity<ProductAttribute>().HasData(new ProductAttribute
            {
                ProductID = 1,
                AttributeID = 4
            });
            modelBuilder.Entity<ProductAttribute>().HasData(new ProductAttribute
            {
                ProductID = 1,
                AttributeID = 5
            });

            //Product2
            modelBuilder.Entity<ProductAttribute>().HasData(new ProductAttribute
            {
                ProductID = 2,
                AttributeID = 1
            });
            modelBuilder.Entity<ProductAttribute>().HasData(new ProductAttribute
            {
                ProductID = 2,
                AttributeID = 2
            });
            modelBuilder.Entity<ProductAttribute>().HasData(new ProductAttribute
            {
                ProductID = 2,
                AttributeID = 3
            });
            modelBuilder.Entity<ProductAttribute>().HasData(new ProductAttribute
            {
                ProductID = 2,
                AttributeID = 4
            });

            //Product3
            modelBuilder.Entity<ProductAttribute>().HasData(new ProductAttribute
            {
                ProductID = 3,
                AttributeID = 1
            });
            modelBuilder.Entity<ProductAttribute>().HasData(new ProductAttribute
            {
                ProductID = 3,
                AttributeID = 2
            });
            modelBuilder.Entity<ProductAttribute>().HasData(new ProductAttribute
            {
                ProductID = 3,
                AttributeID = 6
            });
        }
    }
}
