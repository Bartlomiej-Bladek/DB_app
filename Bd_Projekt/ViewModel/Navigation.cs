using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Bd_Projekt.ViewModel
{
    public class Navigation
    {
        public static void NavigateTo(Page page)
        {
            var frame = Application.Current.MainWindow.FindName("MainFrame") as Frame;
            frame.Navigate(page);
        }
    }
}
