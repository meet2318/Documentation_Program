using System;
/// <summary>
///   <br />
/// </summary>
public class StringExample
{
    /// <summary>Defines the entry point of the application.</summary>
    /// <param name="args">The arguments.</param>
    public static void Main(string[] args)
    {
        // Example Of Split
        string s1 = "Hello C Sharp";
        string[] s2 = s1.Split(' ');
        foreach (string s4 in s2)
        {
            Console.WriteLine(s4);
        }
        Console.WriteLine("--------------------------------------------------\n");
        // Example Of Upper 
        string s3 = s1.ToUpper();
        Console.WriteLine(s3);
        Console.WriteLine("--------------------------------------------------\n");
        // Example Of Concat
        string s11 = "Hello ";
        string s12 = "C#";
        Console.WriteLine(string.Concat(s11, s12));
        Console.WriteLine("--------------------------------------------------\n");
        // Example Of Equals
        Console.WriteLine(s1.Equals(s11));
        Console.WriteLine(s1.Equals(s12));
        Console.WriteLine("--------------------------------------------------\n");

    }
}