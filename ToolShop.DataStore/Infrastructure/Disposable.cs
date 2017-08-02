using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolShop.DataStore.Infrastructure
{
    /// <summary>
    /// Custom implementation of the IDisposable interface that will ensure we can dispose off objects ourselves
    /// </summary>
    public class Disposable : IDisposable
    {
        private bool _isDisposed;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_isDisposed && disposing)
            {
                DisposeCore();
            }

            _isDisposed = true;
        }

        protected virtual void DisposeCore()
        {
            
        }
    }
}
