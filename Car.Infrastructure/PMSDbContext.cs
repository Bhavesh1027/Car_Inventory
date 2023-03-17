using Car.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Infrastructure
{
    public class PMSDbContext: DbContext
    {
        public PMSDbContext(DbContextOptions<PMSDbContext> options)
    : base(options)
        {
        }
        public virtual DbSet<Core.Entities.CarInventory> Projects { get; set; }
    }
}
