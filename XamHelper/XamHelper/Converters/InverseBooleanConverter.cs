using System;
using System.Globalization;
using Xamarin.Forms;
using XamHelper.Guards;

namespace XamHelper.Converters
{
    public class InverseBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Guard.ThrowIfNull(value, "Bool");
            return !(bool) value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Guard.ThrowIfNull(value, "Bool");
            return !(bool) value;
        }
    }
}