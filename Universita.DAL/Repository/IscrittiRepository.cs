using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universita.DAL.Entityes;

namespace Universita.DAL.Repository
{
    internal class IscrittiRepository
    {
        private readonly UniversityDbContext _context;
        private readonly DbSet<Iscritti> _dbSet;

        public IscrittiRepository(UniversityDbContext context)
        {
            _context = context;
            _dbSet = context.Set<Iscritti>();
        }

        public bool Create(Iscritti iscritto)
        {
            _dbSet.Add(iscritto);
            return _context.SaveChanges() > 0;
        }

        public Iscritti Update(Iscritti iscritto)
        {
            _dbSet.Attach(iscritto);
            _context.Entry(iscritto).State = EntityState.Modified;
            _context.SaveChanges();
            return iscritto;
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

        public IList<Iscritti> GetAll()
        {
            return _dbSet.ToList();
        }

        public Iscritti GetById(int studenteMatricola, int corsoId)
        {
            return _dbSet.FirstOrDefault(i => i.StudenteMatricola == studenteMatricola && i.CorsoId == corsoId);
        }
    }
}
