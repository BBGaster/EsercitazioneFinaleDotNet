using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universita.DAL.Entityes
{
    public class Lezione
    {
        public int Id { get; set; }
        public required string Name { get; set; } = string.Empty;
        public string Descrizione { get; set; } = string.Empty;
        public DateTime Data { get; set; }
        public DateTime OrarioInizio { get; set; }
        public int Durata { get; set; }
        [ForeignKey("AulaId")]
        public required int AulaId { get; set; }
        public virtual Aula? Aula { get; set; }
        [ForeignKey("DocenteId")]
        public required int DocenteId { get; set; }
        public virtual Docente? Docente { get; set; }
        [ForeignKey("CorsoId")]
        public required int CorsoId { get; set; }
        public virtual Corso? Corso { get; set; }

    }
}
