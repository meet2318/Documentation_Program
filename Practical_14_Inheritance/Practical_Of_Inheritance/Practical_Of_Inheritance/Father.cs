using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// </summary>
namespace Practical_Of_Inheritance_5
{
    /// <summary>
    ///   <br />
    /// </summary>
    class Father : GrandFather
    {

        /// <summary>Homes this instance.</summary>
        public void home()
        {
            Console.WriteLine("Father's home");
        }

        /// <summary>Cars this instance.</summary>
        public void Car()
        {
            Console.WriteLine("Father's Car");
        }
    }

}
