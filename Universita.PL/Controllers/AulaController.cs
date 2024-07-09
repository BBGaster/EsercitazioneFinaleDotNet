using Microsoft.AspNetCore.Mvc;
using Universita.BLL.Models;
using Universita.BLL.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Universita.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AulaController : ControllerBase
    {


        private readonly IAulaService _services;

        public AulaController(IAulaService category)
        {

            _services = category;
        }

        // GET: api/<AulaController>
        [HttpGet]
        public IEnumerable<AulaModel> Get()
        {
            return _services.GetAll();
        }

        // GET api/<AulaController>/5
        [HttpGet("{id}")]
        public AulaModel Get(int id)
        {
            return _services.GetById(id);
        }

        // POST api/<AulaController>
        [HttpPost]
        public void Post([FromBody] AulaModel value)
        {
            _services.Create(value);
        }

        // PUT api/<AulaController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] AulaModel value)
        {
            _services.Update(value);
        }

        // DELETE api/<AulaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _services.Delete(id);
        }
    }
}
