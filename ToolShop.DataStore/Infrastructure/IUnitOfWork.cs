using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolShop.DataStore.Infrastructure
{
    /// <summary>
    /// Interface for the UnitOfWork
    /// </summary>
    public interface IUnitOfWork
    {
        void Commit();
    }
}
