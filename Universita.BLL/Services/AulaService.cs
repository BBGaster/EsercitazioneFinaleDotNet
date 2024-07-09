using AutoMapper;
using Universita.BLL.Models;
using Universita.BLL.Services.Interfaces;
using Universita.DAL.Entityes;
using Universita.DAL.Repository.Interfaces;

namespace Universita.BLL.Services
{
    public class AulaService :GenericService<Aula, AulaModel>, IAulaService
    {
        public AulaService(IAulaRepository repository, IMapper mapper) : base (repository, mapper) { }
    }
}
