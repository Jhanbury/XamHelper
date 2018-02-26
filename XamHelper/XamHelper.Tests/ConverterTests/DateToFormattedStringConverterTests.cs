using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using XamHelper.Converters;

namespace XamHelper.Tests.ConverterTests
{
    [TestFixture]
    public class DateToFormattedStringConverterTests
    {
        private DateToFormattedStringConverter _dateConverter;

        [OneTimeSetUp]
        public void SetUp()
        {
            _dateConverter = new DateToFormattedStringConverter();
        }

        [Test]
        
        public void TestConvert()
        {
            var date = new DateTime(2012,06,12);
            var actual = _dateConverter.Convert(date, null, "dd/MMMM/yyyy", null);
            var Expected = "12/June/2012";
            Assert.AreEqual(Expected, actual);         

        }
        [Test]
        public void TestDefaultConvert()
        {
            var date = new DateTime(2012, 06, 12);
            var actual = _dateConverter.Convert(date, null, null, null);
            var Expected = "12/06/2012";
            Assert.AreEqual(Expected, actual);

        }
        [Test]
        public void TestConvertBack()
        {
            
            Assert.Catch<NotImplementedException>(() => _dateConverter.ConvertBack(null, null, null, null));


        }


    }
}
