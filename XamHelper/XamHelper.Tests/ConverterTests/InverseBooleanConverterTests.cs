using NUnit.Framework;
using NUnit.Framework.Internal;
using XamHelper.Converters;

namespace XamHelper.Tests.ConverterTests
{
    [TestFixture]
    public class InverseBooleanConverterTests
    {
        private InverseBooleanConverter _inverseBooleanConverter;

        [OneTimeSetUp]
        public void SetUp()
        {
            _inverseBooleanConverter = new InverseBooleanConverter();
        }

        [Test]
        [TestCase(true,false)]
        public void TestConvert(bool value, bool expected)
        {
            var actual = _inverseBooleanConverter.Convert(value, null, null, null);
            Assert.AreEqual(expected,actual);

        }

        [Test]
        [TestCase(true, false)]
        public void TestConvertBack(bool value, bool expected)
        {
            var actual = _inverseBooleanConverter.ConvertBack(value, null, null, null);
            Assert.AreEqual(expected, actual);

        }
    }
}