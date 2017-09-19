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

        
        public void TestConvert()
        {
            var list = new List<int>
            {
                1,2,3,4
            };
            var actual = _collectionToIntConverter.Convert(list, null, null, null);
            Assert.AreEqual(4, actual);

        }

        
    }
}
