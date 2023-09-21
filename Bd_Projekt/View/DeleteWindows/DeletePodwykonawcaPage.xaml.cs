using Bd_Projekt.Model.SQLDelete;
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

namespace Bd_Projekt.View.DeleteWindows
{
    /// <summary>
    /// Logika interakcji dla klasy DeletePodwykonawcaPage.xaml
    /// </summary>
    public partial class DeletePodwykonawcaPage : Page
    {
        public DeletePodwykonawcaPage()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            SQLDelete.DeletePodwykonawca(Convert.ToInt32(deleteTextBox.Text));
        }
    }
}
