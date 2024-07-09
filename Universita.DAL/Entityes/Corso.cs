﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universita.DAL.Entityes
{
    public class Corso
    {
        public int Id { get; set; }
        
        public string Nome { get; set; } = string.Empty;
        public ICollection<Iscritti> Iscrizioni { get; set; } = new List<Iscritti>();

    }
}
