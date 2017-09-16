using System;
using System.Globalization;
using Xamarin.Forms;

namespace XamHelper.Converters
{
    public class StringToNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var input = value.ToString();
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString();
        }
    }
}