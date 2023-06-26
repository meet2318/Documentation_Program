using System;

/// <summary>
///   <br />
/// </summary>

namespace Practical_Of_Polymorphism_2
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
            DClass d = new DClass();
            d.GetInfo();
            BClass b = new BClass();
            b.GetInfo();
            Console.ReadLine();
        }
    }
}