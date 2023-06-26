using System;

/// <summary>
///   <br />
/// </summary>
class Program
{
    /// <summary>Defines the entry point of the application.</summary>
    /// <param name="args">The arguments.</param>
    public static void Main(string[] args)
    {
        int age = 0;

        Console.WriteLine("Enter Your Age");
        age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
        {
            Console.WriteLine("You Are Big");
        }
        else
        {
            Console.WriteLine("Enter Valid Age");
        }
    }
}