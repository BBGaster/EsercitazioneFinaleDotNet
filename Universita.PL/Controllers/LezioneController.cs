using Microsoft.AspNetCore.Mvc;
using Universita.BLL.Models;
using Universita.BLL.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Universita.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LezioneController : ControllerBase
    {


        private readonly ILezioneServices _services;

        public LezioneController(ILezioneServices category)
        {

            _services = category;
        }

        // GET: api/<LezioneController>
        [HttpGet]
        public IEnumerable<LezioneModel> Get()
        {
            return _services.GetAll();
        }

        // GET api/<LezioneController>/5
        [HttpGet("{id}")]
        public LezioneModel Get(int id)
        {
            return _services.GetById(id);
        }

        // POST api/<LezioneController>
        [HttpPost]
        public void Post([FromBody] LezioneModel value)
        {
            _services.Create(value);
        }

        // PUT api/<LezioneController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] LezioneModel value)
        {
            _services.Update(value);
        }

        // DELETE api/<LezioneController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _services.Delete(id);
        }
    }
}
