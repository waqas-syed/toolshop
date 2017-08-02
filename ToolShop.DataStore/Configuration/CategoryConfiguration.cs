using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolShop.Model.Models;

namespace ToolShop.DataStore.Configuration
{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            ToTable("category");
            HasKey(x => x.Id);
            Property(x => x.Name).IsRequired().HasMaxLength(100);
            //HasMany(x => x.Products).WithOptional().HasForeignKey(x => x.CategoryId);
        }
    }
}
