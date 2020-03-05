using AgenciaViajes.Presentation.API.Entities;
using AgenciaViajes.Presentation.API.Interfaces;
using AgenciaViajes.Presentation.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgenciaViajes.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelPackagesController : Controller
    {
        private readonly ICRUDMethods<TravelPackage> _service;

        public TravelPackagesController(ICRUDMethods<TravelPackage> service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Json(_service.GetAll());
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json(_service.GetById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] TravelPackageData data)
        {
            var model = new TravelPackage
            {
                Id = data.Id,
                Name = data.Name,
                Description = data.Description,
                Fecha = data.Fecha,
                Type = data.Type,
                TouristPlace = new TouristPlace(data.TouristPlace.Name, data.TouristPlace.Description)
            };

            _service.Insert(model);
            _service.Save();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TravelPackageData data)
        {
            data.Id = id;

            var model = new TravelPackage
            {
                Id = data.Id,
                Name = data.Name,
                Description = data.Description,
                Fecha = data.Fecha,
                Type = data.Type,
                TouristPlace = new TouristPlace(data.TouristPlace.Name, data.TouristPlace.Description)
            };

            _service.Update(model);
            _service.Save();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(new TravelPackage {Id = id});
            _service.Save();
            return Ok();
        }
    }
}