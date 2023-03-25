using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double DailyPrice { get; set; }

        public Brand Brand { get; set; }
    }
}
