using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolShop.DataStore.Infrastructure
{
    /// <summary>
    /// Creates and manages the instances for the DbContext
    /// </summary>
    public interface IDbFactory : IDisposable
    {
        /// <summary>
        /// Initialize the Db Context for Tools
        /// </summary>
        /// <returns></returns>
        ToolsDbContext GetDbContext();
    }
}
