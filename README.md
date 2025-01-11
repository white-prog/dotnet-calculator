# Calculator Project

## Description

This project is a simple calculator application built using .NET. It performs basic arithmetic operations such as addition, subtraction, multiplication, and division.

## Project Details

- **Language**: C#
- **Framework**: .NET 9.0
- **IDE**: Visual Studio code 

## Features

- Addition of two numbers
- Subtraction of two numbers
- Multiplication of two numbers
- Division of two numbers

## Known Issues

### CS8600 Warning

The CS8600 warning indicates that a non-nullable reference type is being assigned a null value. This can occur when the compiler cannot guarantee that a value will not be null. To resolve this issue, ensure that all reference types are properly initialized and check for null values where necessary.

Example:
```csharp
string? nullableString = null;
string nonNullableString = nullableString!; // This will suppress the warning, but use with caution
```

To avoid this warning, you can also use the null-coalescing operator:
```csharp
string nonNullableString = nullableString ?? "default value";
```

### CS8604 Warning

The CS8604 warning indicates that a possibly null reference argument is being passed to a method that does not accept it. To resolve this issue, ensure that all arguments passed to methods are not null or handle the null case appropriately.

Example:
```csharp
void PrintLength(string? input)
{
	if (input == null)
	{
		Console.WriteLine("Input is null");
	}
	else
	{
		Console.WriteLine(input.Length);
	}
}
```


## How to Run

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Build the solution.
4. Run the application.

## License

This project is licensed under the MIT License.
