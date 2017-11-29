using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using XamHelper.Guards;

namespace XamHelper.Converters
{
    public class DateToFormattedStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Guard.ThrowIfNotDate(value, "Date");
            string format = parameter != null ? (string)parameter : "dd/MM/yyyy";
            var date = (DateTime)value;
            return date.ToString(format);                     
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
