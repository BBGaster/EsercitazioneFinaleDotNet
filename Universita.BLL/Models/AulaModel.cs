﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universita.BLL.Models
{
    public class AulaModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Capienza { get; set; }
    }
}
