using Business.Abstracts;
using Business.Dtos.Requests.Brand;
using Business.Dtos.Responses.Brand;
using Business.Rules;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class BrandManager : IBrandService
    {
        private IBrandDal _brandDal;
        BrandBusinessRules rules;
        
        public BrandManager(IBrandDal brandDal)
        {
            
            _brandDal = brandDal;
            rules = new BrandBusinessRules(_brandDal);
        }

       

        public void Add(CreateBrandRequest createBrandRequest)
        {
            rules.BrandNameCanNotBeDuplicated(createBrandRequest.Name);
            Brand brand = new Brand
            {
                Name = createBrandRequest.Name,
            };
            _brandDal.Add(brand);
        }

        public void Delete(DeleteBrandRequest deleteBrandRequest)
        {
            Brand brand = _brandDal.Get(p => p.Id == deleteBrandRequest.BrandId);

            _brandDal.Delete(brand);
        }

        public void update(UpdateBrandRequest updateBrandRequest)
        {
            Brand brand = _brandDal.Get(p => p.Id == updateBrandRequest.Id);
            brand.Name = updateBrandRequest.Name;

            _brandDal.Update(brand);
        }

        public GetBrandByIdResponse GetById(int id)
        {
            GetBrandByIdResponse getBrandByIdResponse= new GetBrandByIdResponse();
            Brand brand = _brandDal.GetAllWithModel(id);
            getBrandByIdResponse.Name = brand.Name;
            getBrandByIdResponse.Id = brand.Id;
            getBrandByIdResponse.Models = brand.Models;
           
            return getBrandByIdResponse;

        }
        public List<GetAllBrandResponse> GetAll()
        {
            List<Brand> brands = _brandDal.GetAllWithModel().ToList();
            
            List<GetAllBrandResponse> brandResponses = new List<GetAllBrandResponse>();

            foreach (Brand brand in brands)
            {
                GetAllBrandResponse responseItem = new GetAllBrandResponse();
                responseItem.Models = brand.Models;
                responseItem.Id = brand.Id;
                responseItem.Name = brand.Name;
                brandResponses.Add(responseItem);
            }

            return brandResponses;
        }

    }
}
