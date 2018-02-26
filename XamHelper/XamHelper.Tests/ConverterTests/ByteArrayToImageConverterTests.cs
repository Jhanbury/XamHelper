using System;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Xamarin.Forms;
using XamHelper.Converters;

namespace XamHelper.Tests.ConverterTests
{
    [TestFixture]
    public class ByteArrayToImageConverterTests
    {
        private ByteArrayToImageConverter _byteArrayToImageConverter;
        private byte[] image;
        
        [OneTimeSetUp]
        public void SetUp()
        {
            _byteArrayToImageConverter = new ByteArrayToImageConverter();
            image = new byte[200];
        }

        [Test]
        
        public void TestConvert()
        {
            var actual = _byteArrayToImageConverter.Convert(image, null, null, null);
            Assert.IsInstanceOf<ImageSource>(actual);

        }

        [Test]
        public void TestConvertBack()
        {
            Assert.Catch<NotImplementedException>(() => _byteArrayToImageConverter.ConvertBack(null, null, null, null));
        }

        


    }
}