﻿using Core.DataAccess;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IModelDal:IEntityRepository<Model>
    {
        List<Model> GetAllWithBrand();
        Model GetAllWithBrand(int id);
    }
}
