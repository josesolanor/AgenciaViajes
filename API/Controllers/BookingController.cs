using AgenciaViajes.Presentation.API.Entities;
using AgenciaViajes.Presentation.API.Interfaces;
using AgenciaViajes.Presentation.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgenciaViajes.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : Controller
    {
        private readonly ICRUDMethods<Booking> _service;

        public BookingController(ICRUDMethods<Booking> service)
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
        public IActionResult Post([FromBody] BookingData values)
        {
            var booking = new Booking
            {
                Id = values.Id,
                IdClient = values.IdClient,
                IdTravelPackage = values.IdTravelPackage,
                Cost = values.Cost,
                Client = values.Client,
                TravelPackage = values.TravelPackage
            };

            _service.Insert(booking);
            _service.Save();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] BookingData values)
        {
            var booking = new Booking
            {
                Id = id,
                IdClient = values.IdClient,
                IdTravelPackage = values.IdTravelPackage,
                Cost = values.Cost,
                Client = values.Client,
                TravelPackage = values.TravelPackage
            };

            _service.Update(booking);
            _service.Save();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var booking = new Booking
            {
                Id = id
            };
            _service.Delete(booking);
            _service.Save();
            return Ok();
        }
    }
}