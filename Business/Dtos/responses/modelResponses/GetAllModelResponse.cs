using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.model
{
    public class GetAllModelResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double DailyPrice { get; set; }
        public int BrandId { get; set; }
       
    }
}
