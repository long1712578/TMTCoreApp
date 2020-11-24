using System;
using System.Collections.Generic;
using System.Text;

namespace TMTCoreApp.Infrastructure.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        void Commit();
    }
}
