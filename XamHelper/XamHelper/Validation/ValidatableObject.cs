using System.Collections.Generic;
using System.Linq;
using XamHelper.Mvvm;

namespace XamHelper.Validation
{
    public class ValidatableObject<T> : ExtendedBindableObject, IValidatableObject<T>, IValidity
    {
        private readonly List<IValidationRule<T>> _validations;
        private List<string> _errors;
        private T _value;
        private bool _isValid;

        public ValidatableObject()
        {
            _validations = new List<IValidationRule<T>>();
            _errors = new List<string>();
            _isValid = true;
        }

        public bool Validate()
        {
            Errors.Clear();
            IEnumerable<string> errors = _validations.Where(x => x.Check(Value) == false).Select(x => x.ValidationMessage);
            Errors = errors.ToList();
            IsValid = !Errors.Any();
            return this.IsValid;
        }

        public void AddValidationRule(IValidationRule<T> rule)
        {
            _validations.Add(rule);
            RaisePropertyChanged((() => Validations));
        }

        public List<IValidationRule<T>> Validations => _validations;

        public List<string> Errors
        {
            get => _errors;
            set => _errors = value;
        }

        public T Value
        {
            get => _value;
            set
            {
                _value = value;
                RaisePropertyChanged((() => Value));
            }
        }

        public bool IsValid
        {
            get => _isValid;
            set
            {
                _isValid = value;
                RaisePropertyChanged((() => IsValid));
            }
        }
    }
}