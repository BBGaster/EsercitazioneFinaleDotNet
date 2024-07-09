using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universita.DAL.Entityes;
using Universita.DAL.Repository.Interfaces;

namespace Universita.DAL.Repository
{
    internal class DocenteRepository : GenericRepository<Docente>, IDocenteRepository
    {
        public DocenteRepository(UniversityDbContext context) :base(context) { }
    }
}
