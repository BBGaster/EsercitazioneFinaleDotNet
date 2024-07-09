using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universita.DAL.Entityes
{
    public class Iscritti
    {
        
        public int StudenteMatricola { get; set; } 
        public Studente Studente { get; set; }

        public int CorsoId { get; set; }
        public Corso Corso { get; set; }
    }
}
