using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Universita.BLL.Models
{
    public class IscrittiModel
    {
        
        public int StudenteMatricola { get; set; }
        
        public StudenteModel? Studente { get; set; }

        public int CorsoId { get; set; }
        
        public CorsoModel? Corso { get; set; }
    }
}
