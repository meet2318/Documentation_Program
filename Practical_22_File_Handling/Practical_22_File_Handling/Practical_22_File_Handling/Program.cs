using System;
using System.IO;
using System.Text;

/// <summary>
///   <br />
/// </summary>
class fileHandling
{
    /// <summary>Defines the entry point of the application.</summary>
    public static void Main()
    {
        string fileName = @"F:\Assignment_Programs\Practical_22_File_Handling\myTestFile.txt";

        try
        {
            // Delete the file if it exists.
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            Console.Write("\n\nCreate a file with text and read the file:\n");
            Console.Write("----------------------------------------------\n");
            // Create the file.
            using (StreamWriter fileStr = File.CreateText(fileName))
            {
                fileStr.WriteLine("\nName: Meet Pandya");
                fileStr.WriteLine("Education: MSC(IT & CA)");
                fileStr.WriteLine("Age:23");
                fileStr.WriteLine("Home Town: Porbandar");
            }
            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                Console.WriteLine("Here is the content of the file myTestFile.txt: ");
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("");
            }
        }
        catch (Exception MyExcep)
        {
            Console.WriteLine(MyExcep.ToString());
        }
    }
}