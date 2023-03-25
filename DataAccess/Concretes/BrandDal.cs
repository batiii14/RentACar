using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess.Concretes
{
    public class BrandDal : IBrandDal
    {

        public List<Brand> GetAll()
        {
            List<Brand> brands = new List<Brand>();

            brands.Add(new Brand() { Id = 1, Name = "Audi" });
            brands.Add(new Brand() { Id = 2, Name = "Mercedes" });
            brands.Add(new Brand() { Id = 3, Name = "Peugeot" });
            brands.Add(new Brand() { Id = 4, Name = "Volvo" });




            return brands;
        }


    }
}
