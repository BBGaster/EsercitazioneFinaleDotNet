using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universita.DAL.Entityes;
using Universita.DAL.Repository.Interfaces;

namespace Universita.DAL.Repository
{
    public class IscrittiRepository: GenericRepository<Iscritti>, IIscrittiRepository
    {
        private readonly UniversityDbContext _context;
        private readonly DbSet<Iscritti> _dbSet;

        public IscrittiRepository(UniversityDbContext context) :base(context) 
        {
            _context = context;
            _dbSet = context.Set<Iscritti>();
        }

        public bool Delete(int studenteMatricola, int corsoId)
        {
            var iscritto = _dbSet.FirstOrDefault(i => i.StudenteMatricola == studenteMatricola && i.CorsoId == corsoId);
            if (iscritto == null)
            {
                return false;
            }

            _dbSet.Remove(iscritto);
            return _context.SaveChanges() > 0;
        }

        public List<Iscritti> GetByCorso(int corsoId)
        {
            return _dbSet.Where(i => i.CorsoId == corsoId).ToList();
        }

        public Iscritti GetById(int studenteMatricola, int corsoId)
        {
            return _dbSet.FirstOrDefault(i => i.StudenteMatricola == studenteMatricola && i.CorsoId == corsoId);
        }
       
    }
}
