using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Universita.BLL.Models
{
    public class CorsoModel
    {
        public int Id { get; set; }
        
        public string Nome { get; set; } = string.Empty;
        [JsonIgnore]
        public ICollection<IscrittiModel> Iscrizioni { get; set; } = new List<IscrittiModel>();

    }
}
