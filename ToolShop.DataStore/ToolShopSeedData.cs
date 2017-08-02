using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolShop.Model.Models;

namespace ToolShop.DataStore
{
    public class ToolShopSeedData : DropCreateDatabaseIfModelChanges<ToolsDbContext>
    {
        protected override void Seed(ToolsDbContext context)
        {
            PopulateCategories().ForEach(x => context.Categories.Add(x));
            PopulateProduct().ForEach(x => context.Products.Add(x));
        }

        private List<Category> PopulateCategories()
        {
            return new List<Category>()
            {
                new Category() { Name = "Aircraft" },
                new Category() { Name = "Mining" },
                new Category() { Name = "Vehicle Mechanic Toolkit" },
                new Category() { Name = "Mining" },
                new Category() { Name = "Jet Fighter" },
            };
        }

        private List<Product> PopulateProduct()
        {
            return new List<Product>()
            {
                new Product() { Name = "Aviation Software", CategoryId = 1, Price = 90000000.00M },
                new Product() { Name = "Aerodynamics Designer", CategoryId = 1, Price = 80000000.00M },
                new Product() { Name = "Landing Gear", CategoryId = 1, Price = 83000000.00M },
                new Product() { Name = "Propulsion Systems", CategoryId = 1, Price = 90000000.00M },
                new Product() { Name = "Navigation Panel", CategoryId = 1, Price = 90000000.00M },
            };
        }
    }
}
