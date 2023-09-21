using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bd_Projekt.Model
{
    public class Projekt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_projektu { get; set; }
        public string nazwa { get; set; }
        public DateTime data_rozpoczecia { get; set; }
        [ForeignKey("Klient")]
        public int? id_klienta { get; set; }









    }
}
