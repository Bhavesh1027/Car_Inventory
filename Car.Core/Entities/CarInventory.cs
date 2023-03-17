using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Core.Entities
{
    public class CarInventory
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Decimal Price { get; set; }
        public Boolean New { get; set; }

    }
}
