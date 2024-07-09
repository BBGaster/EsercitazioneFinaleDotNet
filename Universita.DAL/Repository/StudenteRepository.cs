using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universita.DAL.Entityes;
using Universita.DAL.Repository.Interfaces;

namespace Universita.DAL.Repository
{
    public class StudenteRepository : GenericRepository<Studente>, IStudenteRepository
    {
        public StudenteRepository(UniversityDbContext context) : base(context) { }
    }
}
