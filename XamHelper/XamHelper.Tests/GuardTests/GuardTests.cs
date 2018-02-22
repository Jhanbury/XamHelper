using System;
using NUnit.Framework;
using XamHelper.Guards;
using XamHelper.Validation.ValidationRules;

namespace XamHelper.Tests.GuardTests
{
    [TestFixture]
    public class GuardTests
    {
        

        [OneTimeSetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void TestThrowIfNotString()
        {
            //act + assert
            Assert.Catch<ArgumentNullException>(() => Guard.ThrowIfNotString(null, "Test"));
        }
        [Test]
        public void TestThrowIfNotString_int()
        {
            //act + assert
            Assert.Catch<ArgumentNullException>(() => Guard.ThrowIfNotString(2, "Test"));
        }
        [Test]
        public void TestThrowIfNotNull()
        {
            //act + assert
            Assert.Catch<ArgumentNullException>(() => Guard.ThrowIfNotString(null, "Test"));
        }
        [Test]
        public void TestThrowIfNotDate()
        {
            //act + assert
            Assert.Catch<ArgumentNullException>(() => Guard.ThrowIfNotString(null, "Test"));
        }
    }
}