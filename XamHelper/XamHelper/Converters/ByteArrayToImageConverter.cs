using System;
using System.Globalization;
using System.IO;
using Xamarin.Forms;

namespace XamHelper.Converters
{
    public class ByteArrayToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var array = (byte[]) value;
            return ImageSource.FromStream((() => new MemoryStream(array)));

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}