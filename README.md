
# XamHelper
A nuget package which provides handy tools for your xamarin forms project

# Nuget:
[![NuGet](https://img.shields.io/nuget/vpre/XamHelper.svg?label=NuGet)](https://www.nuget.org/packages/XamHelper.Forms) 

# Features

## Converters
### **ByteArrayToImageConverter**
Converts a ByteArray in to an Image Source.
### **InverseBooleanConverter**
Inverts a Boolean Value.
### **StringToNameConverter**
Converts any string to Title case "tim cook" -> "Tim Cook".
### **CollectionToIntConverter**
Converts a Collection to an int which represents the number of records in the collection.
### **DateToFormattedStringConverter**
Converts a Datetime to a formatted date.
You can specify your own format using the paramter option.
There is a default format which is "dd/MM/yyyy".




## Validation
The validation namesspace has been added to assist developers in handling the common scenario of Validation.
This implementation follows the patterns described in the following [article](https://developer.xamarin.com/guides/xamarin-forms/enterprise-application-patterns/validation/)
### Usage:
In your ViewModel, foreach property you wish to validate create a ValidatableObject of that type:
```
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
```
You can then add rules to the Validatable object like so:
```
      Name = new ValidatableObject<string>();
      Name.AddValidationRule(new IsNotNullOrEmptyRule<string>("Name cannot be null"));
      Name.AddValidationRule(new IsValidEmailValidationRule("Invalid Email"));

```
### Validate
To validate the Value call the validate method:
```
  Name.Validate();
```

### XAML
We can Bind the value to XAML by using the Value property:
```
	<Label Text="{Binding Name.Value, Converter={StaticResource StringToNameConverter}}" />
```


### IValidationRule
Validation rules are defined by the IValdationRule interface:

```
      public interface IValidationRule<T>
      {
          string ValidationMessage { get; set; }

          bool Check(T value);
      }
```
You can create your own validation rules by implementing this interface:
```
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
 ```
 
      


----------


      

## Asynchronous Task Handlers
### **Task Handler**
Allows uses to easily Bind Tasks to UI Elements.
TaskHandler inherits from INotifyPropertyChanged to allow for Binding.
Task Handler takes in a Generic Parameter which represents the return type of the asynchronous Task.
It will also capture any exceptions and assign them to the Exception property so that error handling can be performed in the UI rather than alowing Exceptions to cause the app to crash.

