using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolShop.DataStore.Configuration;
using ToolShop.Model.Models;

namespace ToolShop.DataStore
{
    public class ToolsDbContext : DbContext
    {
        public ToolsDbContext() : base("ToolShopDB")
        {
            
        }

        // Create the DbSets for the entities in our project
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        /// <summary>
        /// Add the configuration of the Fluent API for the entities for this project
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
        }
    }
}
