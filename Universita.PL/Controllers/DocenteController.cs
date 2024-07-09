using Microsoft.AspNetCore.Mvc;
using Universita.BLL.Models;
using Universita.BLL.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Universita.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocenteController : ControllerBase
    {


        private readonly IDocenteService _services;

        public DocenteController(IDocenteService category)
        {

            _services = category;
        }

        // GET: api/<DocenteController>
        [HttpGet]
        public IEnumerable<DocenteModel> Get()
        {
            return _services.GetAll();
        }

        // GET api/<DocenteController>/5
        [HttpGet("{id}")]
        public DocenteModel Get(int id)
        {
            return _services.GetById(id);
        }

        // POST api/<DocenteController>
        [HttpPost]
        public void Post([FromBody] DocenteModel value)
        {
            _services.Create(value);
        }

        // PUT api/<DocenteController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] DocenteModel value)
        {
            _services.Update(value);
        }

        // DELETE api/<DocenteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _services.Delete(id);
        }
    }
}
