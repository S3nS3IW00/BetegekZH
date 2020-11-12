using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Betegek.Converters
{
    class AgeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime date;
            if (value is DateTime)
            {
                date = (DateTime)value;
            } else {
                try
                {
                    date = DateTime.Parse((string)value);
                } catch (Exception)
                {
                    date = System.DateTime.Now;
                }
            }

            return (System.DateTime.Now.Year - date.Year).ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
