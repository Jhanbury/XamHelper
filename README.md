# XamHelper
A nuget package which provides handy tools for your xamarin forms project

# Nuget:
[![NuGet](https://img.shields.io/nuget/v/XamHelper.svg?label=NuGet)](https://www.nuget.org/packages/XamHelper.Forms) 

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


## Asynchronous Task Handlers
### **Task Handler**
Allows uses to easily Bind Tasks to UI Elements.
TaskHandler inherits from INotifyPropertyChanged to allow for Binding.
Task Handler takes in a Generic Parameter which represents the return type of the asynchronous Task.
It will also capture any exceptions and assign them to the Exception property so that error handling can be performed in the UI rather than alowing Exceptions to cause the app to crash.

