using DataAccess.Abstracts;
using DataAccess.Contexts;
using DataAccess.Repository;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess.Concretes
{
    public class BrandDal : EfEntityRepositoryBase<Brand, RentACarContext>, IBrandDal
    {
        public List<Brand> GetAllWithModel()
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Brands.Include(p=>p.Models).ToList();

            }
            
        }

        public Brand GetAllWithModel(int id)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Brands.Include(p => p.Models).Where(p => p.Id == id).Single();

            }

        }
    }
}
