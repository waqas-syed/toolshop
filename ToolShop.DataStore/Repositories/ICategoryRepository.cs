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
    /// Interface for Category repository
    /// </summary>
    public interface ICategoryRepository : IRepository<Category>
    {
        IList<Category> GetCategoriesByName(string name);
    }
}
