namespace XamHelper.Validation.ValidationRules
{
    public class IsNotNullOrEmptyRule<T> : IValidationRule<T>
    {
        private string _validationMessage;

        public IsNotNullOrEmptyRule(string message)
        {
            ValidationMessage = message;
        }

        public string ValidationMessage
        {
            get => _validationMessage;
            set => _validationMessage = value;
        }

        public bool Check(T value)
        {
            if (value == null)
            {
                return false;
            }

            var str = value as string;

            return !string.IsNullOrWhiteSpace(str);
        }
    }
}