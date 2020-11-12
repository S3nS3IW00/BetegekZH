using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Betegek.Converters
{
    class TajConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string taj = value.ToString();
            Regex regex = new Regex("[0-9]+");
            return (taj.Length == 9 && regex.IsMatch(taj) ? "" : "nem ") + "érvényes (" + taj + ")";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
