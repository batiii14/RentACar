using Business.Dtos.Requests.Model;
using Business.Dtos.Responses.model;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IModelService
    {
         List<GetAllModelResponse> GetAll();
        GetModelByIdResponse GetModelById(int id);
        void Add(CreateModelRequest createModelRequest);
        void Update(UpdateModelRequest updateModelRequest);
        void Delete(DeleteModelRequest deleteModelRequest);
    }
}
