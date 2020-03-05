using AgenciaViajes.API.Entities;
using AgenciaViajes.API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AgenciaViajes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : Controller
    {
        private readonly ICRUDMethods<Client> _service;

        public ClientsController(ICRUDMethods<Client> service)
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
            return Ok();
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}