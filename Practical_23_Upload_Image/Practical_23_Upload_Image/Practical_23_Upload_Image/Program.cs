﻿using System;
///   <br />
/// </summary>
class Program
    ///   <para>
    /// Defines the entry point of the application.
    /// </para>
    /// </summary>
    /// <param name="args">The arguments.</param>
    static void Main(string[] args)
    static void SaveImage()
            Console.Write("Enter Image Taken Path : ");

            Console.Write("Enter Image Upload Path : ");

            if (File.Exists(sourcePath))
                string file_Name = Path.GetFileName(sourcePath);

                string dest_File_Path = Path.Combine(destinationPath,file_Name);

                File.Copy(sourcePath, dest_File_Path);