using System;
using System.IO;
/// <summary>
///   <br />
/// </summary>
public class Program
{

    /// <summary>For Loop Start</summary>
    /// <param name="args">The arguments.</param>
    public static void Main(string[] args)
    {
        for (int row = 1; row <= 5; ++row)
        {
            for (int col = 1; col <= row; ++col)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}