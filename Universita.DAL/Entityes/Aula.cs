using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universita.DAL.Entityes
{
    public class Aula
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Capienza { get; set; }
    }
}
