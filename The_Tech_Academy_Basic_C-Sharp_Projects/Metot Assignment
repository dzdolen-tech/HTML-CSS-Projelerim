using System;

namespace MethodAssignment
{
    // Define a class to hold our custom method
    public class MathOperations
    {
        // Define a void method that accepts two integers as parameters
        public void PerformMathAndDisplay(int number1, int number2)
        {
            // Perform a math operation on the first integer (e.g., multiply by 5)
            int result = number1 * 5;

            // Display the second integer to the console screen as requested
            Console.WriteLine($"The second integer passed into the method is: {number2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate (create an object instance of) the MathOperations class
            MathOperations mathObj = new MathOperations();

            // Call the method, passing in two numbers positional argument style (10 and 25)
            // 10 is multiplied by 5 internally, and 25 is printed to the screen
            mathObj.PerformMathAndDisplay(10, 25);

            // Call the method specifying the parameters by name (named arguments)
            // Here we explicitly map 'number1' to 7 and 'number2' to 42
            mathObj.PerformMathAndDisplay(number1: 7, number2: 42);

            // Keep the console window open until a key is pressed (prevents immediate auto-closing)
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}