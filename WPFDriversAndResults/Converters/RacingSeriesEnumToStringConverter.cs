using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using WPFDriversAndResults.Models;

namespace WPFDriversAndResults.Converters
{
    public class RacingSeriesEnumToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {            
            try
            {
                return Enums.GetEnumDescription((Enums.RacingSeries)value);
            }
            catch
            {
                return string.Empty;                 
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
