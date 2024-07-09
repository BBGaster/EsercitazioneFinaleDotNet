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
    public class IscrittiService :GenericService<Iscritti,IscrittiModel>, IIscrittiService
    {
        public IscrittiService(IIscrittiRepository repository, IMapper mapper) : base(repository, mapper) { }

        public bool Delete(int studenteMatricola, int corsoId)
        {
            throw new NotImplementedException();
        }

        public List<IscrittiModel> GetByCorso(int corsoId)
        {
            throw new NotImplementedException();
        }

        public IscrittiModel GetById(int studenteMatricola, int corsoId)
        {
            throw new NotImplementedException();
        }
    }
}
