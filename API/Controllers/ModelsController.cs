using Business.Abstracts;
using Business.Dtos.Requests.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        IModelService _modelService;

        public ModelsController(IModelService modelService)
        {
            _modelService = modelService;
        }

        [HttpGet("getAll")]
        public IActionResult Get()
        {
            return Ok(_modelService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_modelService.GetModelById(id));
        }

        [HttpPost]
        public IActionResult Add(CreateModelRequest model)
        {
            _modelService.Add(model);
            return Ok();

        }
        [HttpDelete]
        public IActionResult Delete(DeleteModelRequest id)
        {
            _modelService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(UpdateModelRequest model)
        {
            _modelService.Update(model);
            return Ok();
        }
    }
}
