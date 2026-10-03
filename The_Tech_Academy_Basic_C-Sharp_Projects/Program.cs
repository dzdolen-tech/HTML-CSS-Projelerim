using System;

namespace EmployeeComparison
{
    // Define the Employee class to represent employee records
    public class Employee
    {
        // Unique identifier for the employee
        public int Id { get; set; }

        // Employee's first name
        public string FirstName { get; set; }

        // Employee's last name
        public string LastName { get; set; }

        // Overload the "==" operator to check equality between two Employee objects based on their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null, or both are the same instance, return true
            if (ReferenceEquals(emp1, emp2))
            {
                return true;
            }

            // If either object is null, they cannot be equal
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            {
                return false;
            }

            // Return true if the Ids match, otherwise false
            return emp1.Id == emp2.Id;
        }

        // Comparison operators must be overloaded in pairs; overload the "!=" operator
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Return the logical opposite of the "==" operator
            return !(emp1 == emp2);
        }

        // Good practice: Override Equals when overloading operator ==
        public override bool Equals(object obj)
        {
            // Ensure the passed object is an Employee before comparing Ids
            if (obj is Employee otherEmployee)
            {
                return this.Id == otherEmployee.Id;
            }
            return false;
        }

        // Good practice: Override GetHashCode when overriding Equals
        public override int GetHashCode()
        {
            // Use the Id property to generate the hash code
            return Id.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the first Employee object and assign values to its properties
            Employee employee1 = new Employee()
            {
                Id = 101,
                FirstName = "Alex",
                LastName = "Mercer"
            };

            // Instantiate the second Employee object with identical Id to test equality
            Employee employee2 = new Employee()
            {
                Id = 101,
                FirstName = "Jordan",
                LastName = "Lee"
            };

            // Instantiate a third Employee object with a different Id to test inequality
            Employee employee3 = new Employee()
            {
                Id = 102,
                FirstName = "Taylor",
                LastName = "Swift"
            };

            // Print initial header to console
            Console.WriteLine("=== Employee Comparison Results ===");

            // Compare employee1 and employee2 (Same Id: 101) using overloaded "==" operator
            Console.WriteLine($"employee1 (ID: {employee1.Id}) == employee2 (ID: {employee2.Id}): {employee1 == employee2}");

            // Compare employee1 and employee3 (Different Ids: 101 vs 102) using overloaded "!=" operator
            Console.WriteLine($"employee1 (ID: {employee1.Id}) != employee3 (ID: {employee3.Id}): {employee1 != employee3}");

            // Keep the console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}