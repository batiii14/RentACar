using Business.Dtos.Requests.Brand;
using Business.Dtos.Responses.Brand;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IBrandService
    {

        List<GetAllBrandResponse> GetAll();
        GetBrandByIdResponse GetById(int id);
        void Add(CreateBrandRequest createBrandRequest);
        void update(UpdateBrandRequest updateBrandRequest);
        void Delete(DeleteBrandRequest deleteBrandRequest);
    }
}
