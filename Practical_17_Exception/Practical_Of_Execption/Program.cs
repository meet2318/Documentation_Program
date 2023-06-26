using System;

/// <summary>
/// 
/// </summary>
namespace Practical_Of_Execption
{
    /// <summary>
    ///   <br />
    /// </summary>
    class TestTemperature
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            try
            {
                temp.showTemp();
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }
            Console.ReadKey();
        }
    }
}
