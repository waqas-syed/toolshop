using System.Collections.Generic;
using System.Linq;
using ToolShop.DataStore.Infrastructure;
using ToolShop.Model.Models;

namespace ToolShop.DataStore.Repositories
{
    /// <summary>
    /// Performs database operations for Category
    /// </summary>
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
        
        public IList<Category> GetCategoriesByName(string name)
        {
            return DbSet.Where(x => x.Name.Equals(name)).ToList();
        }
    }
}
