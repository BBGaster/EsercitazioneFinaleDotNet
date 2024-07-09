using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universita.DAL.Entityes;

namespace Universita.DAL.Repository.Interfaces
{
    internal interface IIscrittiRepository
    {
        bool Create(Iscritti iscritto);
        Iscritti Update(Iscritti iscritto);
        bool Delete(int studenteMatricola, int corsoId);
        IList<Iscritti> GetAll();
        Iscritti GetById(int studenteMatricola, int corsoId);
    }
}
