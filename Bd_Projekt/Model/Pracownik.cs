using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bd_Projekt.Model
{
    public class Pracownik
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_pracownika { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public DateTime data_zatrudnienia { get; set; }
        public string? wyksztalcenie { get; set; }
        public decimal? pensja { get; set; }
        public string? stanowisko { get; set; }
        [ForeignKey("Zespol")]
        public int? id_zespolu { get; set; }


        [ForeignKey("Dzial")]
        public string? nazwa_dzialu { get; set; }



    }
}
