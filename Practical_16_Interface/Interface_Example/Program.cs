using System;
/// <summary>
/// 
/// </summary>
namespace Interface_Example
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

            Rectangle r1 = new Rectangle();

            r1.calculateArea(1001, 2002);
            r1.getColor();
        }
    }
}