using System;
/// <summary>
///   <br />
/// </summary>

namespace Practical_7_Constructors
{

    public class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            int a, b;

            Console.Write("Enter two numbers:\n");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Test t1 = new Test();

            Test t2 = new Test(a, b);
            t2.display();
        }
    }
}