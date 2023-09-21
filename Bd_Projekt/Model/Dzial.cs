using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bd_Projekt.Model
{
    public class Dzial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string nazwa_dzialu { get; set; }
        [ForeignKey("Biuro")]
        public int id_biura { get; set; }


    }
}
