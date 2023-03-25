using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class ModelDal : IModelDal
    {
        public List<Model> GetAll()
        {
            List<Model> models = new List<Model>();
            Brand brand = new Brand();
            brand.Name = "Audi";
            brand.Id = 10;
            

            models.Add(new Model {DailyPrice=1000,Id=1,Name="ABC",brand};





            return models;
        }
    }
}
