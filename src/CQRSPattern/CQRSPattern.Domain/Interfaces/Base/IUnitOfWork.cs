using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSPattern.Domain.Interfaces.Base
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
