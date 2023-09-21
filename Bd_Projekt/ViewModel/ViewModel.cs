using Bd_Projekt.Model;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;


namespace Bd_Projekt.ViewModel
{
    public class ViewModel : INotifyPropertyChanged
    {
        
        public event PropertyChangedEventHandler? PropertyChanged;

        private Type _tableType;

        public Type TableType
        {
            get { return _tableType; }
            set 
            { 
                _tableType = value;
                Kolekcja = GetData(value);
            }
        }

        private ObservableCollection<object> kolekcja;

        public ObservableCollection<object> Kolekcja
        {
            get { return kolekcja; }
            set 
            { 
                kolekcja = value;
;               OnPropertyChanged(nameof(Kolekcja));
            }
        }










        //--------------------- Objects from tables ----------------------------------------------

        public ObservableCollection<Pracownik> Pracownicy { get; set; }
        public ObservableCollection<Zespol> Zespoly { get; set; }
        public ObservableCollection<Dzial> Dzialy { get; set; }
        public ObservableCollection<Biuro> Biura { get; set; }
        public ObservableCollection<Projekt> Projekty { get; set; }
        public ObservableCollection<Klient> Klienci { get; set; }
        public ObservableCollection<Wspolpraca> Wspolprace { get; set; }
        public ObservableCollection<Podwykonawca> Podwykonawcy { get; set; }

        //-------------------------Objects--------------------------------------------
        public Pracownik Pracownik { get; set; } = 
            new Pracownik();
        public Dzial Dzial { get; set; } = new Dzial();
        public Zespol Zespol { get; set; } = new Zespol();
        public Biuro Biuro { get; set; } = new Biuro();
        public Projekt Projekt { get; set; } = new Projekt();
        public Klient Klient { get; set; } = new Klient();
        public Wspolpraca Wspolpraca { get; set; } = new Wspolpraca();
        public Podwykonawca Podwykonawca { get; set; } = new Podwykonawca();

        //----------------------Selected items-------------------------------
        public Pracownik sPracownik { get; set; } 
        public Dzial sDzial { get; set; } 
        public Zespol sZespol { get; set; } 
        public Biuro sBiuro { get; set; } 
        public Projekt sProjekt { get; set; } 
        public Klient sKlient { get; set; } 
        public Wspolpraca sWspolpraca { get; set; } 
        public Podwykonawca sPodwykonawca { get; set; } 

        //--------------- Commands-----------------------------------------------------
        /*
        //public AddPracownikCommand AddCommand { get; set; }
        public AddDzialCommand AddDzialCommand { get; set; }
        public AddBiuroCommand AddBiuroCommand { get; set; }
        public AddZespolCommand AddZespolCommand { get; set; }
        public AddProjektCommand AddProjektCommand { get; set; }
        public AddKlientCommand AddKlientCommand { get; set; }
        public AddPodwykonawcaCommand AddPodwykonawcaCommand { get; set; }
        public AddWspolpracaCommand AddWspolpracaCommand { get; set; }
        */

        // --------------------------- Ctor
        public ViewModel()
        {
            this.TableType = typeof(Dzial);
            /*
            Pracownicy = SQLHelper.GetEmplyees<Pracownik>();
            Zespoly = SQLHelper.GetZespoly();
            Dzialy = SQLHelper.GetDzialy();
            Biura = SQLHelper.GetBiura();
            Projekty = SQLHelper.GetProjekty();
            Klienci = SQLHelper.GetKlienci();
            Wspolprace = SQLHelper.GetWspolprace();
            Podwykonawcy = SQLHelper.GetPodwykonawcy();
            */

/*
            AddCommand = new AddPracownikCommand(Pracownik, this);
            AddDzialCommand = new AddDzialCommand(this, Dzial);
            AddBiuroCommand = new AddBiuroCommand(Biuro);
            AddZespolCommand = new AddZespolCommand(this, Zespol);
            AddProjektCommand = new AddProjektCommand(this, Projekt);
            AddKlientCommand = new AddKlientCommand(Klient);
            AddPodwykonawcaCommand = new AddPodwykonawcaCommand(Podwykonawca);
            AddWspolpracaCommand = new AddWspolpracaCommand(this);
*/

        }


        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<object> GetData(Type type)
        {
            if (type == null)
                return new ObservableCollection<object>();
            ObservableCollection<object> data = new ObservableCollection<object>();

            switch(type.Name)
            {
                case "Pracownik":
                    data = new ObservableCollection<object>(SQLHelper.GetEmplyees<Pracownik>());
                    break;
                case "Dzial":
                    data = new ObservableCollection<object>(SQLHelper.GetEmplyees<Dzial>());
                    break;
            }
            return data;    
        }


    }

    
}
