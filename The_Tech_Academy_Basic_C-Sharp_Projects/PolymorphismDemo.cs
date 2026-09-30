using System;

namespace PolymorphismDemo
{
    // Define the IQuittable interface
    public interface IQuittable
    {
        // Define a void method declaration called Quit that implementing classes must implement
        void Quit();
    }

    // Define the Employee class which implements the IQuittable interface
    public class Employee : IQuittable
    {
        // Public properties to store the employee's details
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Implementation of the Quit method required by the IQuittable interface
        public void Quit()
        {
            // Print a message to the console indicating that this specific employee has quit
            Console.WriteLine($"{FirstName} {LastName} (ID: {Id}) has submitted their resignation and quit the company.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Use polymorphism: instantiate an Employee object, but assign it to a variable of interface type IQuittable
            IQuittable quittableEmployee = new Employee()
            {
                Id = 101,
                FirstName = "Jane",
                LastName = "Doe"
            };

            // Call the Quit method on the IQuittable interface reference
            quittableEmployee.Quit();

            // Keep the console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}