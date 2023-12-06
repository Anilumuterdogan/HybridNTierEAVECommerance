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
    public class CategoryDataSeedExtension
    {
        public static void SeedCategories(ModelBuilder modelBuilder)
        {
            List<Category> categories = new();

            
                Category c1 = new()
                {
                    ID = 1,
                    CategoryName = "Clothing",
                    Description = "clothing"
                };
                categories.Add(c1);

                 Category c2 = new()
            {
                    ID = 2,
                    CategoryName = "Technology",
                    Description = "From PC's to Phones"
                 };
                 categories.Add(c2);


            modelBuilder.Entity<Category>().HasData(categories);


        }
    }
}
