using System.Collections.Generic;

namespace XamHelper.Validation
{
    public interface IValidatableObject<T>
    {
        bool Validate();
        void AddValidationRule(IValidationRule<T> rule);
        List<IValidationRule<T>> Validations { get; }
        List<string> Errors { get; }
        T Value { get; set; }
     }
}