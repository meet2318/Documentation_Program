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
    class Son : Father
    {

        // son constructor
        /// <summary>Initializes a new instance of the <see cref="Son" /> class.</summary>
        public Son()
        {
            Console.WriteLine("Son...");
        }

        /// <summary>Mobiles this instance.</summary>
        public void mobile()
        {
            Console.WriteLine("Son's mobile");
        }
    }

}
