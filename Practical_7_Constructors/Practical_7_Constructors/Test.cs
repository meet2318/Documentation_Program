using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7_Constructors
{
    public class Test
    {
        /// <summary>The s</summary>
        int s;

        /// <summary>Initializes a new instance of the <see cref="Test" /> class.</summary>
        public Test()
        {
            Console.Write("Sum is:");
        }
        /// <summary>Initializes a new instance of the <see cref="Test" /> class.</summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        public Test(int a, int b)
        {
            s = a + b;
        }

        /// <summary>Displays this instance.</summary>
        public void display()
        {
            Console.WriteLine(s);
        }


    }
}