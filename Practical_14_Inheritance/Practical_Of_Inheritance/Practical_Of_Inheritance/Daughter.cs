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
    class Daughter : Father
    {

        // Daughter constructor
        /// <summary>Initializes a new instance of the <see cref="Daughter" /> class.</summary>
        public Daughter()
        {
            Console.WriteLine("Daughter...");
        }

        /// <summary>Purses this instance.</summary>
        public void purse()
        {
            Console.WriteLine("Daughter's purse");
        }
    }

}
