using Bd_Projekt.Model.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bd_Projekt.Model
{
    public class SQLHelper
    {
        public static ObservableCollection<T> GetEmplyees<T>() where T : class
        {
            using (var dbContext = new ProjectManagementDataContext())
            {
                var entities = dbContext.Set<T>().ToList();

                var obsCollection = new ObservableCollection<T>(entities);

                return obsCollection;
            }
        }

        
        public static ObservableCollection<Zespol> GetZespoly()
        {
            using (var dbContext = new ProjectManagementDataContext())
            {
                var zespoly = dbContext.Zespoly.ToList();

                var obsCollection = new ObservableCollection<Zespol>(zespoly);

                return obsCollection;
            }
        }

        public static ObservableCollection<Dzial> GetDzialy()
        {
            using (var dbContext = new ProjectManagementDataContext())
            {
                var dzialy = dbContext.Dzialy.ToList();

                var obsCollection = new ObservableCollection<Dzial>(dzialy);

                return obsCollection;
            }
        }

        public static ObservableCollection<Biuro> GetBiura()
        {
            using (var dbContext = new ProjectManagementDataContext())
            {
                var biura = dbContext.Biura.ToList();

                var obsCollection = new ObservableCollection<Biuro>(biura);

                return obsCollection;
            }
        }

        public static ObservableCollection<Projekt> GetProjekty()
        {
            using (var dbContext = new ProjectManagementDataContext())
            {
                var projekty = dbContext.Projekty.ToList();

                var obsCollection = new ObservableCollection<Projekt>(projekty);

                return obsCollection;
            }
        }

        public static ObservableCollection<Klient> GetKlienci()
        {
            using (var dbContext = new ProjectManagementDataContext())
            {
                var klienci = dbContext.Klienci.ToList();

                var obsCollection = new ObservableCollection<Klient>(klienci);

                return obsCollection;
            }
        }


        public static ObservableCollection<Wspolpraca> GetWspolprace()
        {
            using (var dbContext = new ProjectManagementDataContext())
            {
                var wspolprace = dbContext.Wspolprace.ToList();

                var obsCollection = new ObservableCollection<Wspolpraca>(wspolprace);

                return obsCollection;
            }
        }

        public static ObservableCollection<Podwykonawca> GetPodwykonawcy()
        {
            using (var dbContext = new ProjectManagementDataContext())
            {
                var podwykonawcy = dbContext.Podwykonawcy.ToList();

                var obsCollection = new ObservableCollection<Podwykonawca>(podwykonawcy);

                return obsCollection;
            }
        }
    }
}
