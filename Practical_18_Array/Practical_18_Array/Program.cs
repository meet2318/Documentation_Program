using System;

/// <summary>
/// 
/// </summary>
namespace Practical_18_Array
{
    /// <summary>
    ///   <br />
    /// </summary>
    public class Example
    {
        /// <summary>Defines the entry point of the application.</summary>
        public static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int item = 1;

            int index = array.findIndex(item);
            if (index != -1)
            {
                Console.WriteLine(String.Format("Element {0} is found at index {1}", item, index));
            }
            else
            {
                Console.WriteLine("Element not found in the given array.");
            }
        }
    }
}
