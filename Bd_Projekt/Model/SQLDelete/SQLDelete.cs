using Bd_Projekt.Model.DbContexts;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bd_Projekt.Model.SQLDelete
{
    public class SQLDelete
    {
        public static void DeletePracownik(int id)
        {
            Pracownik pracownik;
            using(var db = new ProjectManagementDataContext())
            {
                pracownik = db.Pracownicy.Where(p => p.id_pracownika == id).First();
                db.Pracownicy.Remove(pracownik);
                db.SaveChanges();
            }
        }

        public static void DeleteDzial(string nazwa)
        {
            Dzial entity;
            using (var db = new ProjectManagementDataContext())
            {
                entity = db.Dzialy.Where(p => p.nazwa_dzialu == nazwa).First();
                db.Dzialy.Remove(entity);
                db.SaveChanges();
            }
        }

        public static void DeleteBiuro(int id)
        {
            Biuro entity;
            using (var db = new ProjectManagementDataContext())
            {
                entity = db.Biura.Where(p => p.id_biura == id).First();
                db.Biura.Remove(entity);
                db.SaveChanges();
            }
        }

        public static void DeleteZespol(int id)
        {
            Zespol entity;
            using (var db = new ProjectManagementDataContext())
            {
                entity = db.Zespoly.Where(p => p.id_zespolu == id).First();
                db.Zespoly.Remove(entity);
                db.SaveChanges();
            }
        }


        public static void DeleteProjekt(int id)
        {
            Projekt entity;
            using (var db = new ProjectManagementDataContext())
            {
                entity = db.Projekty.Where(p => p.id_projektu == id).First();
                db.Projekty.Remove(entity);
                db.SaveChanges();
            }
        }


        public static void DeleteKlient(int id)
        {
            Klient entity;
            using (var db = new ProjectManagementDataContext())
            {
                entity = db.Klienci.Where(p => p.id_klienta == id).First();
                db.Klienci.Remove(entity);
                db.SaveChanges();
            }
        }


        public static void DeleteWspolpraca(int id)
        {
            Wspolpraca entity;
            using (var db = new ProjectManagementDataContext())
            {
                entity = db.Wspolprace.Where(p => p.id_wspolpracy == id).First();
                db.Wspolprace.Remove(entity);
                db.SaveChanges();
            }
        }


        public static void DeletePodwykonawca(int id)
        {
            Podwykonawca entity;
            using (var db = new ProjectManagementDataContext())
            {
                entity = db.Podwykonawcy.Where(p => p.id_podwykonawcy == id).First();
                db.Podwykonawcy.Remove(entity);
                db.SaveChanges();
            }
        }
    }
}
