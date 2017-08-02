using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolShop.Model.Models;

namespace ToolShop.DataStore.Configuration
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            ToTable("product");
            HasKey(x => x.Id);
            Property(x => x.Name).IsRequired().HasMaxLength(50);
            Property(x => x.Price).IsRequired().HasPrecision(10,2);
            HasRequired<Category>(s => s.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
        }
    }
}
