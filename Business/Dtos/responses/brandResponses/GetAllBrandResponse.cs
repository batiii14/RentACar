using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.Brand
{
    public class GetAllBrandResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        
        public List<Model>? Models { get; set; }
    }
}
