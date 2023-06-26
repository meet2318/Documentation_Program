using Practical_Of_Encapsulation;
using System;
namespace AccessSpecifiers
{
    /// <summary>
    ///   <br />
    /// </summary>
    class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Student student = new Student();
            // Setting values to the properties  
            student.ID = "101";
            student.Name = "Meet Pandya";
            student.Email = "meet@example.com";
            // getting values  
            Console.WriteLine("ID = " + student.ID);
            Console.WriteLine("Name = " + student.Name);
            Console.WriteLine("Email = " + student.Email);
        }
    }
}