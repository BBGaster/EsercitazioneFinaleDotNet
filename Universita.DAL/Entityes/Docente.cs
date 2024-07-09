﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universita.DAL.Entityes
{
    public class Docente
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cognome {  get; set; } = string.Empty;
        public string TitoloDiStudio { get; set; } = string.Empty;
    }
}
