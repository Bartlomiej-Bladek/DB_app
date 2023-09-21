using Bd_Projekt.Model.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bd_Projekt.Model.SQLUpdate
{
    public class SQLUpdate
    {
        public static void UpdatePracownik(int id)
        {
            using (var db = new ProjectManagementDataContext())
            {
                var entity = db.Pracownicy.FirstOrDefault(p => p.id_pracownika == id);

                if (entity != null)
                {

                }

            }
        }
    }
}
