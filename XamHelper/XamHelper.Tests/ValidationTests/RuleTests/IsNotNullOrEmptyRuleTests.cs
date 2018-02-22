using NUnit.Framework;
using XamHelper.Validation;
using XamHelper.Validation.ValidationRules;

namespace XamHelper.Tests.ValidationTests
{
    [TestFixture]
    public class IsNotNullOrEmptyRuleTests
    {
        private IValidationRule<string> _validationRule;

        [OneTimeSetUp]
        public void SetUp()
        {
            _validationRule = new IsNotNullOrEmptyRule<string>("Value cannot be null");
        }

        [Test]
        public void TestAddValidationRule_True()
        {
            //act
            var actual = _validationRule.Check("johnhanbury4@gamail.com");

            //assert
            Assert.AreEqual(true, actual);
            Assert.AreEqual("Value cannot be null", _validationRule.ValidationMessage);

        }
        [Test]
        public void TestAddValidationRule_False()
        {
            //act
            var actual = _validationRule.Check(null);

            //assert
            Assert.AreEqual(false, actual);
            Assert.AreEqual("Value cannot be null", _validationRule.ValidationMessage);

        }
       
    }
}