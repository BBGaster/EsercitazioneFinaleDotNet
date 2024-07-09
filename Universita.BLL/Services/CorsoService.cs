using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universita.BLL.Models;
using Universita.BLL.Services.Interfaces;
using Universita.DAL.Entityes;
using Universita.DAL.Repository.Interfaces;

namespace Universita.BLL.Services
{
    public class CorsoService : GenericService<Corso, CorsoModel> , ICorsoServices
    {
        public CorsoService(ICorsoRepository repository, IMapper mapper) : base(repository, mapper) { }
    }
}
