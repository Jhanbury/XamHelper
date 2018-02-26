using System;
using System.Globalization;
using NUnit.Framework;
using XamHelper.Converters;
using XamHelper.Validation;
using XamHelper.Validation.ValidationRules;

namespace XamHelper.Tests.ConverterTests
{
    [TestFixture]
    public class FirstValidationRuleTests
    {
        private FirstValidationErrorConverter _converter;
        [OneTimeSetUp]
        public void Setup()
        {
            _converter = new FirstValidationErrorConverter();
        }
        [Test]
        public void TestFirstValidationRule()
        {
            //arrange
            var name = new ValidatableObject<string>();
            name.AddValidationRule(new IsNotNullOrEmptyRule<string>("Must have value"));
            name.AddValidationRule(new IsValidEmailValidationRule("Invalid Email"));
            //act
            name.Value = null;
            name.Validate();
            //assert
            
            var actual = _converter.Convert(name.Errors, null, null, CultureInfo.CurrentCulture);
            Assert.AreEqual("Must have value", actual);
        }

        [Test]
        public void TestFirstValidationRule_secondError()
        {
            //arrange
            var name = new ValidatableObject<string>();
            name.AddValidationRule(new IsNotNullOrEmptyRule<string>("Must have value"));
            name.AddValidationRule(new IsValidEmailValidationRule("Invalid Email"));
            //act
            name.Value = "John";
            name.Validate();
            //assert
            
            var actual = _converter.Convert(name.Errors, null, null, CultureInfo.CurrentCulture);
            Assert.AreEqual("Invalid Email", actual);
        }

        [Test]
        public void TestConvertBack()
        {
            
            Assert.Catch<NotImplementedException>(() => _converter.ConvertBack(null, null, null, null));


        }
    }
}