using Microsoft.AspNetCore.Mvc;
using Universita.BLL.Models;
using Universita.BLL.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Universita.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IscrittiController : ControllerBase
    {
        private readonly IIscrittiService _services;

        public IscrittiController(IIscrittiService services)
        {
            _services = services;
        }

        // GET: api/<IscrittiController>
        [HttpGet]
        public IEnumerable<IscrittiModel> Get()
        {
            return _services.GetAll();
        }

        // GET api/<IscrittiController>/5/10
        [HttpGet("{studenteMatricola}/{corsoId}")]
        public ActionResult<IscrittiModel> Get(int studenteMatricola, int corsoId)
        {
            var iscritto = _services.GetById(studenteMatricola, corsoId);
            if (iscritto == null)
            {
                return NotFound();
            }
            return Ok(iscritto);
        }

        // GET api/<IscrittiController>/ByCorso/10
        [HttpGet("ByCorso/{corsoId}")]
        public ActionResult<IEnumerable<IscrittiModel>> GetByCorso(int corsoId)
        {
            var iscritti = _services.GetByCorso(corsoId);
            return Ok(iscritti);
        }

        // POST api/<IscrittiController>
        [HttpPost]
        public ActionResult Post([FromBody] IscrittiModel value)
        {
            _services.Create(value);
            return CreatedAtAction(nameof(Get), new { studenteMatricola = value.StudenteMatricola, corsoId = value.CorsoId }, value);
        }

        // PUT api/<IscrittiController>/5
        [HttpPut("{studenteMatricola}/{corsoId}")]
        public ActionResult Put(int studenteMatricola, int corsoId, [FromBody] IscrittiModel value)
        {
            var iscritto = _services.GetById(studenteMatricola, corsoId);
            if (iscritto == null)
            {
                return NotFound();
            }

            _services.Update(value);
            return NoContent();
        }

        // DELETE api/<IscrittiController>/5/10
        [HttpDelete("{studenteMatricola}/{corsoId}")]
        public ActionResult Delete(int studenteMatricola, int corsoId)
        {
            var iscritto = _services.GetById(studenteMatricola, corsoId);
            if (iscritto == null)
            {
                return NotFound();
            }

            _services.Delete(studenteMatricola, corsoId);
            return NoContent();
        }
    }
}
