using System;
using System.Collections.Generic;
using System.Linq; // Required to use LINQ and Lambda expressions (such as Where)

namespace LambdaExpressionAssignment
{
    // Define the Employee class
    public class Employee
    {
        // Unique identification number for the employee
        public int Id { get; set; }

        // Employee's first name
        public string FirstName { get; set; }

        // Employee's last name
        public string LastName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of at least 10 employees (with at least two named "Joe")
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "Anna", LastName = "Johnson" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Davis" },
                new Employee { Id = 4, FirstName = "Sarah", LastName = "Williams" },
                new Employee { Id = 5, FirstName = "Michael", LastName = "Brown" },
                new Employee { Id = 6, FirstName = "Emily", LastName = "Jones" },
                new Employee { Id = 7, FirstName = "David", LastName = "Miller" },
                new Employee { Id = 8, FirstName = "Jessica", LastName = "Wilson" },
                new Employee { Id = 9, FirstName = "James", LastName = "Taylor" },
                new Employee { Id = 10, FirstName = "Amanda", LastName = "Anderson" }
            };

            // STEP 1: Use a foreach loop to create a new list of all employees named "Joe"
            List<Employee> joesWithForeach = new List<Employee>();

            // Iterate through each employee in the original list
            foreach (Employee emp in employees)
            {
                // Check if the FirstName property equals "Joe"
                if (emp.FirstName == "Joe")
                {
                    // Add the matching employee to the new list
                    joesWithForeach.Add(emp);
                }
            }

            // Display results obtained using the foreach loop
            Console.WriteLine("--- Employees Named 'Joe' (Foreach Loop) ---");
            foreach (Employee joe in joesWithForeach)
            {
                Console.WriteLine($"ID: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            // STEP 2: Perform the same action using a Lambda expression
            // 'emp => emp.FirstName == "Joe"' is the lambda function evaluating each employee object
            List<Employee> joesWithLambda = employees.Where(emp => emp.FirstName == "Joe").ToList();

            // Display results obtained using the Lambda expression
            Console.WriteLine("\n--- Employees Named 'Joe' (Lambda Expression) ---");
            foreach (Employee joe in joesWithLambda)
            {
                Console.WriteLine($"ID: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            // STEP 3: Use a Lambda expression to filter employees with an Id greater than 5
            List<Employee> idGreaterThanFive = employees.Where(emp => emp.Id > 5).ToList();

            // Display results for employees with Id > 5
            Console.WriteLine("\n--- Employees with ID Greater Than 5 (Lambda Expression) ---");
            foreach (Employee emp in idGreaterThanFive)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.FirstName} {emp.LastName}");
            }

            // Prevent console window from closing immediately
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}