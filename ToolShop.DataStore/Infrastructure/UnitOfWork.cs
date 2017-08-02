using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolShop.DataStore.Infrastructure
{
    /// <summary>
    /// Commit the changes to the database as a Unit of work
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private ToolsDbContext _toolsDbContext;

        /// <summary>
        /// Get the DbFactory to getthe Current DBContext
        /// </summary>
        /// <param name="dbFactory"></param>
        public UnitOfWork(IDbFactory dbFactory)
        {
            _toolsDbContext = dbFactory.GetDbContext();
        }

        /// <summary>
        /// Commit the current changes as a unit of work
        /// </summary>
        public void Commit()
        {
            _toolsDbContext.SaveChanges();
        }
    }
}
