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

        
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            return Json(_service.GetById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] TravelPackage data)
        {
            _service.Insert(data);
            _service.Save();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TravelPackage data)
        {
            data.Id = id;
            _service.Update(data);
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
