using System;
using System.Globalization;
using Xamarin.Forms;
using XamHelper.Guards;

namespace XamHelper.Converters
{
    public class StringToNameConverter : IValueConverter
    {
        /// <summary>
        /// Implement this method to convert a string to TitleCase john -> John />.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="targetType">The type to which to convert the value.</param>
        /// <param name="parameter">A parameter to use during the conversion.</param>
        /// <param name="culture">The culture to use during the conversion.</param>
        /// <returns>
        /// Returns the string in Title Case.
        /// </returns>
        /// <remarks>
        /// To be added.
        /// </remarks>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Guard.ThrowIfNull(value, "String");
            var input = value.ToString();
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString();
        }
    }
}