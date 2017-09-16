using NUnit.Framework;
using XamHelper;
using XamHelper.Converters;

namespace XamHelper.Tests.ConverterTests
{
    [TestFixture]
    public class StringToNameConverterTests
    {
        private StringToNameConverter _stringToNameConverter;

        [OneTimeSetUp]
        public void SetUp()
        {
            _stringToNameConverter = new StringToNameConverter();
        }

        [Test]
        [TestCase("john hanbury", "John Hanbury")]
        public void TestConvert(string value, string expected)
        {
            var actual = _stringToNameConverter.Convert(value, null, null, null);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        [TestCase("John Hanbury", "John Hanbury")]
        public void TestConvertBack(string value, string expected)
        {
            var actual = _stringToNameConverter.ConvertBack(value, null, null, null);
            Assert.AreEqual(expected, actual);

        }
    }
}