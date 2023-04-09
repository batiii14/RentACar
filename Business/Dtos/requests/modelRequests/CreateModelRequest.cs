using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.Model
{
    public class CreateModelRequest
    {
        public string Name { get; set; }
        public double DailyPrice { get; set; }
        public int BrandId { get; set; }
    }
}
