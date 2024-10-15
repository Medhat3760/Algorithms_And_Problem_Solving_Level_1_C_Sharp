# Problem 3: Odd or Even Checker

This C# program reads an integer from the user and determines whether the number is odd or even.


## Code Structure

```csharp
namespace Problem3
{
    internal class Problem3
    {
        enum enOddOrEven { Odd, Even }

        static int ReadNumber(string Message)
        {
            int Num;
            Console.WriteLine(Message);
            Num = int.Parse(Console.ReadLine());
            return Num;
        }

        static enOddOrEven CheckOddOrEven(int Num)
        {
            if (Num % 2 == 0)
            {
                return enOddOrEven.Even;
            }
            else
            {
                return enOddOrEven.Odd;
            }
        }

        static void PrintResult(enOddOrEven Result)
        {
            Console.WriteLine("Number is: " + Result);
        }

        static void Main(string[] args)
        {
            PrintResult(CheckOddOrEven(ReadNumber("Enter The Number ?")));
        }
    }
}
```
## Explanation of the Code
- **ReadNumber**: This method prompts the user to enter a number and reads the input.
- **CheckOddOrEven**: This method takes the input number and checks whether it is `odd or even`, returning an appropriate result (`Odd or Even`).
- **PrintResult**: This method prints the result `(odd or even)` to the console.
- **Main**: The entry point of the program that reads the number, checks if it's odd or even, and prints the result.


## How to Run the Program

1. Clone this repository to your local machine.

2. Open the solution in a C# development environment (e.g., Visual Studio).

3. uild the project.

4. Run the program.

## Example

When you run the program, it will display a prompt asking for a number:

```
Enter The Number ?
```
After you enter a number, the program will respond:
```
Number is: Even
```
Or
```
Number is: Odd
```
depending on the number you entered.
