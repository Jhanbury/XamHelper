using System;
using System.Text.RegularExpressions;

namespace XamHelper.Validation.ValidationRules
{
    public class IsValidEmailValidationRule : IValidationRule<string>
    {
        private string _validationMessage;

        public IsValidEmailValidationRule(string message)
        {
            ValidationMessage = message;
        }

        public string ValidationMessage
        {
            get => _validationMessage;
            set => _validationMessage = value;
        }

        public bool Check(string value)
        {
            if (value == null)
            {
                return false;
            }

            var str = value as string;

            return Regex.IsMatch(str,
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        }
    }
}