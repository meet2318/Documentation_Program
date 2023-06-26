using System;using System.IO;/// <summary>
///   <br />
/// </summary>
class Program{    /// <summary>
    ///   <para>
    /// Defines the entry point of the application.
    /// </para>
    /// </summary>
    /// <param name="args">The arguments.</param>
    static void Main(string[] args)    {        SaveImage();    }    /// <summary>Uploads the image.</summary>
    static void SaveImage()    {        try        {
            Console.Write("Enter Image Taken Path : ");            string sourcePath = Console.ReadLine();

            Console.Write("Enter Image Upload Path : ");            string destinationPath = Console.ReadLine();

            if (File.Exists(sourcePath))            {
                string file_Name = Path.GetFileName(sourcePath);

                string dest_File_Path = Path.Combine(destinationPath,file_Name);

                File.Copy(sourcePath, dest_File_Path);                Console.WriteLine("Image Put SuccessFully");            }            else            {                Console.WriteLine("File does not found. Check the file path.");            }        }        catch (Exception e)        {            Console.WriteLine("An error occurred :- " + e.Message);        }    }}