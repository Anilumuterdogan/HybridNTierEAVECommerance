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
    public class AttributeDataSeedExtension
    {
        public static void SeedAttributes(ModelBuilder modelBuilder)
        {
            List<EntityAttribute> entityAttributes = new();
            
            EntityAttribute eA1 = new()
            {
                ID = 1,
                Title = "Color",
                Description = "Color that item has"
            };
            entityAttributes.Add(eA1);

            EntityAttribute eA2 = new()
            {
                ID = 2,
                Title = "Lenght",
                Description = "Lenght on Cm"
            };
            entityAttributes.Add(eA2);

            EntityAttribute eA3 = new()
            {
                ID = 3,
                Title = "Weight",
                Description = "weight on Kg"
            };
            entityAttributes.Add(eA3);

            EntityAttribute eA4 = new()
            {
                ID = 4,
                Title = "Ram",
                Description = "Ram"
            };
            entityAttributes.Add(eA4);

            EntityAttribute eA5 = new()
            {
                ID = 5,
                Title = "GraphicCart",
                Description = "Graphic cart"
            };
            entityAttributes.Add(eA5);

            EntityAttribute eA6 = new()
            {
                ID = 6,
                Title = "Fabric",
                Description = "Fabric"
            };
            entityAttributes.Add(eA6);

            modelBuilder.Entity<Category>().HasData(entityAttributes);
        }
    }
}
