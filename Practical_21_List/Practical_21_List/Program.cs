using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
///   <br />
/// </summary>
class Program
{
    /// <summary>Defines the entry point of the application.</summary>
    /// <param name="args">The arguments.</param>
    public static void Main(string[] args)
    {
        IList<string> meet = new List<string> { "A", "B", "C", "D", "A", "C", "E", "E", "E" };
        string joined = string.Join(",", meet);
        Console.WriteLine(joined);
        // Removing duplicate elements
        List<string> distinct = meet.Distinct().ToList();
        Console.WriteLine("List after removing duplicate elements ...");
        foreach (string res in distinct)
        {
            Console.WriteLine("{0}", res);
        }
    }
}