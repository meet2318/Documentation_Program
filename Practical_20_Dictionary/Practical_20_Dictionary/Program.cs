using System;
using System.Collections.Generic;
public class Demo
{
    public static void Main()
    {
        Console.WriteLine("Enter Your Name:");
        string userName = Console.ReadLine();
        Dictionary<string, string> dict = new Dictionary<string, string>();
        Dictionary<string, string> dict1 = new Dictionary<string, string>();
        dict.Add("Name", userName);
        Console.WriteLine("\n");
        dict.Add("Education", "MSC(IT & CA)");
        dict.Add("Age", "23");
        dict.Add("HomeTown", "Porbandar");
        foreach (var item in dict)
        {
            Console.WriteLine("Key:- " + item.Key + " Value:- "+ item.Value);
        }
    }
}