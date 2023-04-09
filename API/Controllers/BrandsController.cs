using Business.Abstracts;
using Business.Concretes;
using Business.Dtos.Requests.Brand;
using Business.Dtos.Responses.Brand;
using DataAccess.Concretes;
using Entities;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {

        IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute]int id)
        {
            var result = _brandService.GetById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);

        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            return Ok(_brandService.GetAll());
        }

        [HttpPost]
        public IActionResult Add(CreateBrandRequest brand)
        {
            _brandService.Add(brand);
            return Ok(brand);
            
        }

        [HttpDelete]
        public IActionResult Delete(DeleteBrandRequest id)
        {
            _brandService.Delete(id);
            return Ok();

        }

        [HttpPut]
        public IActionResult Update (UpdateBrandRequest id)
        {
            _brandService.update(id);
            return Ok();

        }

    }
}
