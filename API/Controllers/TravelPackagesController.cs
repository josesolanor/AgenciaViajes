using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using API.Models;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
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

            var listTouristPlaces = new List<TouristPlace>();

            foreach (var place in data.TouristPlaces)
            {
                listTouristPlaces.Add(new TouristPlace(place.Name, place.Description));
            }

            var model = new TravelPackage()
            {
                Id = data.Id,
                Name = data.Name,
                Description = data.Description,
                Fecha = data.Fecha,
                Type = data.Type,
                TouristPlaces = listTouristPlaces
            };

            _service.Insert(model);
            _service.Save();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TravelPackageData data)
        {
            data.Id = id;
            var listTouristPlaces = new List<TouristPlace>();

            foreach (var place in data.TouristPlaces)
            {
                listTouristPlaces.Add(new TouristPlace(place.Name, place.Description));
            }

            var model = new TravelPackage()
            {
                Id = data.Id,
                Name = data.Name,
                Description = data.Description,
                Fecha = data.Fecha,
                Type = data.Type,
                TouristPlaces = listTouristPlaces
            };
            
            _service.Update(model);
            _service.Save();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            _service.Delete(new TravelPackage { Id = id });
            _service.Save();
            return Ok();
        }
    }
}
