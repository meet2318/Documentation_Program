using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_10_This
{

    class program
    {

        /// <summary>Defines the entry point of the application.</summary>
        public static void Main()
        {
            meet obj = new meet();
            obj.SetName("Meet Pandya");
            Console.WriteLine(obj.GetName());
        }
    }
}