using Microsoft.AspNetCore.Mvc;
using Universita.BLL.Models;
using Universita.BLL.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Universita.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorsoController : ControllerBase
    {


        private readonly ICorsoServices _services;

        public CorsoController(ICorsoServices category)
        {

            _services = category;
        }

        // GET: api/<CorsoController>
        [HttpGet]
        public IEnumerable<CorsoModel> Get()
        {
            return _services.GetAll();
        }

        // GET api/<CorsoController>/5
        [HttpGet("{id}")]
        public CorsoModel Get(int id)
        {
            return _services.GetById(id);
        }

        // POST api/<CorsoController>
        [HttpPost]
        public void Post([FromBody] CorsoModel value)
        {
            _services.Create(value);
        }

        // PUT api/<CorsoController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] CorsoModel value)
        {
            _services.Update(value);
        }

        // DELETE api/<CorsoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _services.Delete(id);
        }
    }
}
