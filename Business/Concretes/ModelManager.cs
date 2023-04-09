using Business.Abstracts;
using Business.Dtos.Requests.Model;
using Business.Dtos.Responses.model;
using Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ModelManager : IModelService
    {
        private IModelDal _modelDal;
        ModelBusinessRules rules;

        public ModelManager(IModelDal modelDal)
        {
            _modelDal = modelDal;
            rules = new ModelBusinessRules(_modelDal);
        }

        

        public void Add(CreateModelRequest createModelRequest)
        {
            rules.ModelNameCanNotBeDuplicated(createModelRequest.Name);

            Model model = new Model
            {
                Name = createModelRequest.Name,
                DailyPrice = createModelRequest.DailyPrice,
                BrandId = createModelRequest.BrandId,
            };
            _modelDal.Add(model);
        }

        public void Update(UpdateModelRequest updateModelRequest)
        {
            Model model= _modelDal.Get(p=>p.Id == updateModelRequest.Id);
            model.Name=updateModelRequest.Name;
            model.DailyPrice=updateModelRequest.DailyPrice;

            _modelDal.Update(model);
        }

        public void Delete(DeleteModelRequest deleteModelRequest)
        {
            Model model = _modelDal.Get(p => p.Id == deleteModelRequest.Id);
            _modelDal.Delete(model);
        }

        public List<GetAllModelResponse> GetAll()
        {
            List<Model> models = _modelDal.GetList()?.ToList()?? new List<Model>();
            List<GetAllModelResponse> modelResponses = new List<GetAllModelResponse>();
            foreach(Model model in models)
            {
                GetAllModelResponse responseItem = new GetAllModelResponse();
                responseItem.Id = model.Id;
                responseItem.Name = model.Name;
                responseItem.DailyPrice= model.DailyPrice;
                responseItem.BrandId= model.BrandId;
                modelResponses.Add(responseItem);
            }
            return modelResponses;
        }

        public GetModelByIdResponse GetModelById(int id)
        {
            GetModelByIdResponse getModelByIdResponse=new GetModelByIdResponse();  
            Model model=_modelDal.Get(p=>p.Id == id);
            getModelByIdResponse.Id = id;
            getModelByIdResponse.ModelName= model.Name;

            return getModelByIdResponse;
        }
    }
}
