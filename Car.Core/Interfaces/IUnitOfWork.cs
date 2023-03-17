using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Core.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        ICarInventoryRepository Projects { get; }
        Task<int> CompletedAsync();
    }
}
