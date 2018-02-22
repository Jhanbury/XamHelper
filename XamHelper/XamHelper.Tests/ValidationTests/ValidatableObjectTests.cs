using NUnit.Framework;
using Xamarin.Forms;
using XamHelper.Converters;
using XamHelper.Validation;
using XamHelper.Validation.ValidationRules;

namespace XamHelper.Tests.ValidationTests
{
    [TestFixture]
    public class ValidatableObjectTests
    {
        private IValidatableObject<string> _validatableObject;
        
        

        [OneTimeSetUp]
        public void SetUp()
        {
            _validatableObject = new ValidatableObject<string>();
            
        }

        [Test]
        public void TestAddValidationRule()
        {
            //arrange
            var rule = new IsNotNullOrEmptyRule<string>("Value cannot be null");

            _validatableObject.Value = "Hello World";
            _validatableObject.AddValidationRule(rule);

            //act
            int actual = _validatableObject.Validations.Count;

            //assert
            Assert.AreEqual(1, actual);

        }
        [Test]
        public void TestValidate()
        {
            //arrange
            var rule = new IsNotNullOrEmptyRule<string>("Value cannot be null");

            _validatableObject.Value = "Hello World";
            _validatableObject.AddValidationRule(rule);

            //act
            var actual = _validatableObject.Validate();

            //assert
            Assert.AreEqual(true, actual);

        }


    }
}