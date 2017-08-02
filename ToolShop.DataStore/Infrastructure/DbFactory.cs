using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolShop.DataStore.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ToolsDbContext _toolsDbContext;

        public DbFactory()
        {
            
        }

        protected override void DisposeCore()
        {
            if (_toolsDbContext != null)
            {
                _toolsDbContext.Dispose();
            }
        }

        public ToolsDbContext GetDbContext()
        {
            if (_toolsDbContext == null)
            {
                _toolsDbContext = new ToolsDbContext();
            }
            return _toolsDbContext;
        }
    }
}
