using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universita.BLL.Models
{
    public class LezioneModel
    {
        public int Id { get; set; }
        public required string Name { get; set; } = string.Empty;
        public string Descrizione { get; set; } = string.Empty;
        public DateTime Data { get; set; }
        public DateTime OrarioInizio { get; set; }
        public int Durata { get; set; }
        [ForeignKey("AulaId")]
        public required int AulaId { get; set; }
        //public virtual AulaModel? Aula { get; set; }
        [ForeignKey("DocenteId")]
        public required int DocenteId { get; set; }
        //public virtual DocenteModel? Docente { get; set; }
        [ForeignKey("CorsoId")]
        public required int CorsoId { get; set; }
        //public virtual CorsoModel? Corso { get; set; }

    }
}
