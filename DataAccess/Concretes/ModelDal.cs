using Core.DataAccess;
using DataAccess.Abstracts;
using DataAccess.Contexts;

using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class ModelDal : EfEntityRepositoryBase<Model, RentACarContext>, IModelDal
    {
        public List<Model> GetAllWithBrand()
        {
            using (RentACarContext context= new RentACarContext())
            {
                return context.Models.Include(p=>p.Brand).ToList();

            }
        }

        public Model GetAllWithBrand(int id)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Models.Include(p => p.Brand).Where(p => p.Id == id).Single();

            }
        }
    }
}
