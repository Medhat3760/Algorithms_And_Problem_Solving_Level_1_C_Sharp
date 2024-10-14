# Problem2 -  Name Reader and Printer

## Overview

This simple C# program reads a user's name from the console input and then prints it back to the user. The program demonstrates the use of functions to read input and display output.

## Features

- Prompts the user to enter their name.
- Displays the entered name in the format: `Your Name is: <Name>`.
  
## Code Explanation

The program is contained within the `Problem2` namespace and uses the following methods:

1. **`ReadName(string Message)`**: 
   - Displays a message prompting the user to input their name.
   - Reads and returns the name from the console input.

2. **`PrintName(string Name)`**: 
   - Takes a name as an argument and prints it in the format: `Your Name is: <Name>`.

3. **`Main(string[] args)`**:
   - The entry point of the program.
   - Calls `ReadName` to get the user's name and then calls `PrintName` to display the name.

### Code Structure

```csharp
namespace Problem2
{
    internal class Problem2
    {
        static string ReadName(string Message)
        {
            string Name;
            Console.WriteLine(Message);
            Name = Console.ReadLine();
            return Name;
        }

        static void PrintName(string Name)
        {
            Console.WriteLine("Your Name is: " + Name);
        }

        static void Main(string[] args)
        {
            PrintName(ReadName("Enter Your Name ?"));
        }
    }
}
```
## How to Run the Program

1. **Open the Project**: Open the project in an IDE like Visual Studio or Visual Studio Code.

2. **Run the Program**: Compile and run the project. The console will ask you to input your name, and it will print your name back in the format `Your Name is: <Name>`.

## Example Output
```
Enter Your Name ?
Abdelrahman Medhat
Your Name is: Abdelrahman Medhat
```

## Requirements
- C# development environment (e.g., Visual Studio, .NET SDK)

