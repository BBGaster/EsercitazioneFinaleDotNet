﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universita.DAL.Entityes;

namespace Universita.DAL.Repository.Interfaces
{
    internal interface IIscrittiRepository : IGenericRepository<Iscritti>
    {
        
        bool Delete(int studenteMatricola, int corsoId);
        
        Iscritti GetById(int studenteMatricola, int corsoId);
    }
}
