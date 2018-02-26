using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using XamHelper.Converters;

namespace XamHelper.Tests.ConverterTests
{
    [TestFixture]
    public class CollectionToIntConverterTests
    {
        private CollectionToIntConverter _collectionToIntConverter;

        [OneTimeSetUp]
        public void SetUp()
        {
            _collectionToIntConverter = new CollectionToIntConverter();
        }

        [Test]
        public void TestConvert()
        {
            var list = new List<int>
            {
                1,2,3,4
            };
            var actual = _collectionToIntConverter.Convert(list, null, null, null);
            Assert.AreEqual(4, actual);

        }

        [Test]
        public void TestConvert_null()
        {
            List list = null;
            Assert.Catch<ArgumentNullException>(() => _collectionToIntConverter.Convert(list, null, null, null));
            

        }
        [Test]
        public void TestConvertBack()
        {
            List list = null;
            Assert.Catch<NotImplementedException>(() => _collectionToIntConverter.ConvertBack(list, null, null, null));


        }
        [Test]
        public void TestConvert_nonlist()
        {
            var actual = _collectionToIntConverter.Convert("test", null, null, null);
            Assert.AreEqual(0,actual);


        }


    }
}
