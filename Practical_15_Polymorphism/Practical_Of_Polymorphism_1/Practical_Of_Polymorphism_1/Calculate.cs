using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Of_Polymorphism_1
{
    public class Calculate
    {
        /// <summary>Adds the numbers.</summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine("a + b = {0}", a + b);
        }
        /// <summary>Adds the numbers.</summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        public void AddNumbers(int a, int b, int c)
        {
            Console.WriteLine("a + b + c = {0}", a + b + c);
        }
    }

}
