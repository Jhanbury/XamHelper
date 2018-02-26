using System;
using System.Windows.Input;
using Xamarin.Forms;
using XamHelper.Mvvm;
using XamHelper.Validation;
using XamHelper.Validation.ValidationRules;

namespace XamHelperSample
{
    public class MainPageViewModel : ExtendedBindableObject
    {
        private ValidatableObject<string> _name;
        public ValidatableObject<string> Name
        {
            get => _name;
            set
            {
                _name = value;
                RaisePropertyChanged(()=> Name);
            } 
        }

        public DateTime TodaysDate { get; set; }

        public MainPageViewModel()
        {
            TodaysDate = DateTime.Now;
            ValidateCommand = new Command(Validate);
            Name = new ValidatableObject<string>();
            Name.AddValidationRule(new IsNotNullOrEmptyRule<string>("Name cannot be null"));
            Name.AddValidationRule(new IsValidEmailValidationRule("Invalid Email"));
            Name.Value = "john hanbury";
            
        }

        public Command ValidateCommand { get; set; }

        private void Validate()
        {
            Name.Validate();
            RaisePropertyChanged((() => Name));
        }
    }
}