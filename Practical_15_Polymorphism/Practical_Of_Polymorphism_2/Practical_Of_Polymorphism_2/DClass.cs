using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Of_Polymorphism_2
{
    // Derived Class
    /// <summary>
    ///   <br />
    /// </summary>
    public class DClass : BClass
    {
        /// <summary>Gets the information.</summary>
        public override void GetInfo()
        {
            Console.WriteLine("Welcome to Porbandar");
        }
    }

}
