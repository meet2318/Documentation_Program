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
        int month;

        Console.WriteLine("Enter Month Number Between 1 to 12");
        month = Convert.ToInt32(Console.ReadLine());

        switch (month)
        {
            case 1:
                Console.WriteLine("January\n");
                break;
            case 2:
                Console.WriteLine("February\n");
                break;
            case 3:
                Console.WriteLine("March\n");
                break;
            case 4:
                Console.WriteLine("April\n");
                break;
            case 5:
                Console.WriteLine("May\n");
                break;
            case 6:
                Console.WriteLine("June\n");
                break;
            case 7:
                Console.WriteLine("July\n");
                break;
            case 8:
                Console.WriteLine("August\n");
                break;
            case 9:
                Console.WriteLine("September\n");
                break;
            case 10:
                Console.WriteLine("October\n");
                break;
            case 11:
                Console.WriteLine("November\n");
                break;
            case 12:
                Console.WriteLine("December\n");
                break;
            default:
                Console.WriteLine("Invalid Month Number. \n Please Try Again....\n");
                break;
        }
    }
}