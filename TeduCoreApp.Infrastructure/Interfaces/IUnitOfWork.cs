using System;
using System.Collections.Generic;
using System.Text;

namespace TeduCoreApp.Infrastructure.Interfaces
{
    public interface IUnitOfWork :IDisposable
    {
        /// <summary>
        /// Gọi hàm SaveChange của Identity
        /// </summary>
        void Commit();
    }
}
