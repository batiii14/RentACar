using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Model:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double DailyPrice { get; set; }

        public Brand Brand { get; set; }
    }
}
