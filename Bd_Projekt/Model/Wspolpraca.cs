using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bd_Projekt.Model
{
    public class Wspolpraca
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_wspolpracy { get; set; }
        [ForeignKey("Zespol")]
        public int id_zespolu { get; set; }


        [ForeignKey("Podwykonawca")]
        public int id_podwykonawcy { get; set; }



    }
}
