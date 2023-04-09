using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class ModelBusinessRules
    {
        IModelDal _modelDal;

        public ModelBusinessRules(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }

        public void ModelNameCanNotBeDuplicated(string modelName)
        {
            Model? model=_modelDal.Get(p=>p.Name==modelName);
            if (model!=null)
            {
                throw new Exception("Model name already exists");
            }

        }
    }
}
