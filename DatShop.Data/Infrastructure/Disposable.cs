using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatShop.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        private bool isDisposed=false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
            //throw new NotImplementedException();
        }

        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
                DisposeCore();
            isDisposed = true;         
        }

        private void DisposeCore()
        {

        }
    }
}
