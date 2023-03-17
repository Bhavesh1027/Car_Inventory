using Car.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Core.Interfaces
{
    public interface ICarInventoryRepository: IGenericRepository<Entities.CarInventory>
    {
    }
}
