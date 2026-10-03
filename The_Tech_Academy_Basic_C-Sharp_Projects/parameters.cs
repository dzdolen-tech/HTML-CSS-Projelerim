using System;
using System.Collections.Generic;

namespace ParametersAssignment
{
    // Define a generic Employee class where 'T' represents the placeholder type
    public class Employee<T>
    {
        // Property 'Things' is a List holding items of the generic type 'T'
        public List<T> Things { get; set; }

        // Constructor initializing the 'Things' list to prevent null reference errors
        public Employee()
        {
            Things = new List<T>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object specifying 'string' as the generic type argument
            Employee<string> stringEmployee = new Employee<string>();

            // Assign a list of strings to the 'Things' property of stringEmployee
            stringEmployee.Things = new List<string> { "Laptop", "Desk Chair", "Monitor", "Notebook" };

            // Instantiate an Employee object specifying 'int' as the generic type argument
            Employee<int> intEmployee = new Employee<int>();

            // Assign a list of integers to the 'Things' property of intEmployee
            intEmployee.Things = new List<int> { 101, 202, 303, 404 };

            // Print header for the string employee's items
            Console.WriteLine("--- String Employee's Things ---");

            // Loop through each string item in the stringEmployee's Things list and print it
            foreach (string item in stringEmployee.Things)
            {
                Console.WriteLine(item);
            }

            // Print a section separator
            Console.WriteLine("\n--- Int Employee's Things ---");

            // Loop through each integer item in the intEmployee's Things list and print it
            foreach (int item in intEmployee.Things)
            {
                Console.WriteLine(item);
            }

            // Keep the console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}