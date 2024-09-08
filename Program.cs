namespace cs_netcore_project_hello;

// using System;
// using System.Collections.Generic; >> automatically included in dotnet project by implicit usings
// using System.Threading.Tasks;


// Main program class
class Program
{
    // Main entry point of the program
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
       
        Console.WriteLine("Testing VS Code project and code navigation features..");

        // Using the another Person class
        Person person = new Person("John", "Doe");
        Console.WriteLine($"Created: {person.GetFullName()}");

        // Create some sample objects
        var calculator = new Calculator();
        var greeter = new Greeter();

        // Passing an object of one class to another
        string greeting = greeter.Greet(person);
        Console.WriteLine(greeting);

        // Test peeking definitions and jumping through code 
        int result = calculator.Add(5, 10);
        Console.WriteLine($"Calculator result: {result}");

        // Use the utility class method
        string reversed = StringUtilities.ReverseString("!nuf si edoC SV gnitseT");
        Console.WriteLine($"Reversed string: {reversed}");

        // Jump to method definitions or peek a definition
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        int sum = calculator.AddList(numbers);
        Console.WriteLine($"Sum of numbers: {sum}");

        // Using the MathHelper class over delegating to another class 
        int factorialResult = Calculator.Factorial(5);
        Console.WriteLine($"Factorial of 5: {factorialResult}");

        // Using the another MathHelper class
        bool isPrimeResult = MathHelper.IsPrime(7);
        Console.WriteLine($"Is 7 prime? {isPrimeResult}");

        // Call async/await 
        Task.Run(async () => await TestAsyncAwait(person)).Wait();

        // Test peeking definitions with classes
        string farewell = greeter.Farewell(person);
        Console.WriteLine(farewell);
    }
    
    // Test running async/await method
    static async Task TestAsyncAwait(Person person)
    {
        // Convert the person's fullname to uppercase using StringUtilities
        string upperCaseName = StringUtilities.ToUpperCase(person.GetFullName());

        Console.WriteLine("Starting async task...");
        Console.WriteLine($"{person.FirstName} needs help converting fullname to uppercase which is {upperCaseName}");
        await Task.Delay(1000); // Wait for 1 second
        Console.WriteLine("Async task completed.");
    }
}

// Calculator class to perform basic operations
public class Calculator
{
    // Method to add two numbers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Method to add a list of numbers
    public int AddList(List<int> numbers)
    {
        int sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    // Method to subtract two numbers
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    // New method prototype to calculate factorial, delegating to external class
    public static int Factorial(int number)
    {
        return MathHelper.Factorial(number);
    }

    public static bool IsPrime(int number)
    {
        return MathHelper.IsPrime(number);
    }
}

// Greeter class for creating greeting and farewell messages
public class Greeter
{
    // Method to create a greeting message
    public string Greet(Person person)
    {
        return $"Hello, {person.FirstName}! Welcome to VS Code.";
    }

    // Method to create a farewell message
    public string Farewell(Person person)
    {
        return $"Goodbye, Mr. {person.FirstName} {person.LastName}. See you next time!";
    }
}

// StringUtilities class for string operations
public static class StringUtilities
{
    // Method to reverse a string
    public static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // Method to convert a string to uppercase
    public static string ToUpperCase(string input)
    {
        return input.ToUpper();
    }
}
