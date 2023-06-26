using System;
using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
namespace Practical_19_List
{
    /// <summary>
    ///   <br />
    /// </summary>
    class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name:");
            string userName = Console.ReadLine();
            IList<string> strings = new List<string> { "Hello", "World", userName };
            string joined = string.Join(",", strings);
            Console.WriteLine(joined);
        }
    }
}