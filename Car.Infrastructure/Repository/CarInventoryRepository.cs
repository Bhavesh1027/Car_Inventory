using Car.Core.Entities;
using Car.Core.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Infrastructure.Repository
{
    public class CarInventoryRepository: GenericRepository<Core.Entities.CarInventory>,ICarInventoryRepository
    {
        public CarInventoryRepository(PMSDbContext context, ILogger logger) : base(context, logger)
        {
        }
    }
}
