using Car.Core.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork   
    {
        private readonly PMSDbContext _context;
        private readonly ILogger _logger;
        public ICarInventoryRepository Projects { get; private set; }
        public UnitOfWork(
            PMSDbContext context,
            ILoggerFactory logger
            )
        {
            _context = context;
            _logger = logger.CreateLogger("logs");
            Projects = new CarInventoryRepository(_context, _logger);
        }
        public async Task<int> CompletedAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
