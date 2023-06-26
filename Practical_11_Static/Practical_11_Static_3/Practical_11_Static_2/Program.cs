// concept of static method
using System;

namespace Practical_11_Static_2
{
    class Nparks
    {

        static public int t = 104;

        // Creating static method
        // Using static keyword
        /// <summary>Totals this instance.</summary>
        public static void total()
        {
            Console.WriteLine("Total number of national parks" +
                            " present in India is :{0}", t);
        }
    }
}