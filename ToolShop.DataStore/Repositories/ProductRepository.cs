using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolShop.DataStore.Infrastructure;
using ToolShop.Model.Models;

namespace ToolShop.DataStore.Repositories
{
    /// <summary>
    /// Product Repository
    /// </summary>
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        /// <summary>
        /// Gets product by their names and Category name
        /// </summary>
        /// <returns></returns>
        public IList<Product> GetProductByNameAndCategoryName(string productName, string categoryName)
        {
            return DbSet.Where(x => x.Name.Equals(productName) && x.Category.Name.Equals(categoryName)).ToList();
        }

        /// <summary>
        /// Gets product by their names and Category Id
        /// </summary>
        /// <returns></returns>
        public IList<Product> GetProductByNameAndCategoryId(string productName, int categoryId)
        {
            return DbSet.Where(x => x.Name.Equals(productName) && x.Category.Id == categoryId).ToList();
        }
    }
}
