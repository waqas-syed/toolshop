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
    /// Repository to perform database operations for Product
    /// </summary>
    public interface IProductRepository : IRepository<Product>
    {
        IList<Product> GetProductByNameAndCategoryName(string productName, string categoryName);

        IList<Product> GetProductByNameAndCategoryId(string productName, int categoryId);
    }
}
