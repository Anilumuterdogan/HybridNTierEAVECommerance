using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Project.CONF.Configurations;
using Project.DAL.Extensions;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.ContextClasses
{
    public class MyContext : IdentityDbContext<AppUser,IdentityRole<int>,int>
    {
        public MyContext(DbContextOptions<MyContext> opt) : base(opt)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AppUserConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new AppUserProfileConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new OrderDetailConfiguration());
            builder.ApplyConfiguration(new EntityAttributeConfiguration());
            builder.ApplyConfiguration(new ProductAttributeConfiguration());
            //Seeds
            UserRoleDataSeedExtension.SeedUser(builder);
            CategoryDataSeedExtension.SeedCategories(builder);
            AttributeDataSeedExtension.SeedAttributes(builder);
            ProductDataSeedExtension.SeedProducts(builder);

        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AppUserProfile> Profiles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<EntityAttribute> EntityAttributes { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }


    }
}
