using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Bd_Projekt.Model
{
    public class TableTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        
        {
            return Binding.DoNothing;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            
            if (value is bool isChecked && isChecked)
            {
                string param = parameter?.ToString();

                if (param == "Pracownik")
                {
                    return typeof(Pracownik);
                }

                if (param == "Dzial")
                {
                    return typeof(Dzial);
                }


            }
            return Binding.DoNothing;
        }
    }
}
