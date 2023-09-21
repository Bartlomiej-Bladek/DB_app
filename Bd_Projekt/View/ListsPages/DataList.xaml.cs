using Bd_Projekt.Model.SQLDelete;
using Bd_Projekt.View.InsertingPages;
using Bd_Projekt.View.UpdateWindows;
using Bd_Projekt.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bd_Projekt.View.ListsPages
{
    /// <summary>
    /// Logika interakcji dla klasy BiuroList.xaml
    /// </summary>
    public partial class DataList : Page
    {
        public DataList()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NavigateTo(new AddNewBiuroPage());
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            DeleteBiuroWindow deleteWindow = new DeleteBiuroWindow();
            deleteWindow.ShowDialog();
        }
    }
}
