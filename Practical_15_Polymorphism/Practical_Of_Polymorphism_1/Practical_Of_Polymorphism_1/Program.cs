using System;

/// <summary>
///   <br />
/// </summary>
namespace Practical_Of_Polymorphism_1
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
            Calculate c = new Calculate();
            c.AddNumbers(1, 2);
            c.AddNumbers(1, 2, 3);
            Console.ReadLine();
        }
    }
}
