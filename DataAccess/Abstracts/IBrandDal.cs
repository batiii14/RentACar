﻿using DataAccess.Repository;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IBrandDal:IEntityRepository<Brand>
    {
        List<Brand> GetAllWithModel();
        Brand GetAllWithModel(int id);
    }
}
