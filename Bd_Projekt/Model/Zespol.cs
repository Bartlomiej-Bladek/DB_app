using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bd_Projekt.Model
{
    public class Zespol
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_zespolu { get; set; }
        public DateTime data_powolania { get; set; }

        [ForeignKey("Projekt")]
        public int? id_projektu { get; set; }

        [ForeignKey("Biuro")]
        public int? id_biura { get; set; }







    }
}
