using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class BrandBusinessRules
    {
        IBrandDal _brandDal;

        public BrandBusinessRules(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void BrandNameCanNotBeDuplicated(string brandName)
        {
            Brand? brand = _brandDal.Get(p=>p.Name==brandName);
            if (brand != null)
            {
                throw new Exception("Brand name already exists");
            }
        }
    }
}
