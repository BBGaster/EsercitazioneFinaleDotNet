using Microsoft.AspNetCore.Mvc;
using Universita.BLL.Models;
using Universita.BLL.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Universita.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudenteController : ControllerBase
    {


        private readonly IStudenteService _services;

        public StudenteController(IStudenteService category)
        {

            _services = category;
        }

        // GET: api/<StudenteController>
        [HttpGet]
        public IEnumerable<StudenteModel> Get()
        {
            return _services.GetAll();
        }

        // GET api/<StudenteController>/5
        [HttpGet("{id}")]
        public StudenteModel Get(int id)
        {
            return _services.GetById(id);
        }

        // POST api/<StudenteController>
        [HttpPost]
        public void Post([FromBody] StudenteModel value)
        {
            _services.Create(value);
        }

        // PUT api/<StudenteController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] StudenteModel value)
        {
            _services.Update(value);
        }

        // DELETE api/<StudenteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _services.Delete(id);
        }
    }
}
