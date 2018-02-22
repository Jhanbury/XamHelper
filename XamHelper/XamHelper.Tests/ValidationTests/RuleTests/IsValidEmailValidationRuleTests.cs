using NUnit.Framework;
using XamHelper.Validation;
using XamHelper.Validation.ValidationRules;

namespace XamHelper.Tests.ValidationTests
{
    [TestFixture]
    public class IsValidEmailValidationRuleTests
    {
        private IValidationRule<string> _validatableObject;

        [OneTimeSetUp]
        public void SetUp()
        {
            _validatableObject = new IsValidEmailValidationRule("Invalid Email address");
        }

        [Test]
        public void TestAddValidationRule_True()
        {
            //act
            var actual = _validatableObject.Check("johnhanbury4@gamail.com");
            
            //assert
            Assert.AreEqual(true, actual);
            Assert.AreEqual("Invalid Email address", _validatableObject.ValidationMessage);

        }
        [Test]
        public void TestAddValidationRule_False()
        {
            //act
            var actual = _validatableObject.Check("john");
            
            //assert
            Assert.AreEqual(false, actual);
            Assert.AreEqual("Invalid Email address", _validatableObject.ValidationMessage);

        }
        [Test]
        public void TestAddValidationRule_Null()
        {
            //act
            var actual = _validatableObject.Check(null);
            
            //assert
            Assert.AreEqual(false, actual);
            Assert.AreEqual("Invalid Email address", _validatableObject.ValidationMessage);

        }
    }
}