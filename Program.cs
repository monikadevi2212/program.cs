using System;

namespace ConsoleApp
{
    // Define an interface called IQuittable
    interface IQuittable
    {
        // Define the Quit method that any class implementing IQuittable must implement
        void Quit();
    }

    // Employee class that implements the IQuittable interface
    class Employee : IQuittable
    {
        // Implement the Quit method for Employee
        public void Quit()
        {
            // Print a message indicating the employee has quit
            Console.WriteLine("The employee has quit their job.");
        }
    }

    // Main program class
    class Program
    {
        // Main method - entry point of the program
        static void Main(string[] args)
        {
            // Create an object of type IQuittable, but instantiate it as an Employee
            IQuittable quitter = new Employee(); // Polymorphism: IQuittable can reference Employee

            // Call the Quit method on the IQuittable object
            quitter.Quit(); // This will call the Quit method from the Employee class

            // Optional: Wait for the user to press a key before closing the program
            Console.ReadKey(); // Pause the program so the user can see the output
        }
    }
}
interface IQuittable
{
    void Quit();
}
class Employee : IQuittable
{
    public void Quit()
    {
        Console.WriteLine("The employee has quit their job.");
    }
}
IQuittable quitter = new Employee();  // Polymorphism: IQuittable type referring to Employee object
quitter.Quit();  // Calls the Quit method from Employee class
