using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Of_Abstration
{
    // Derived class (inherit from Animal)
    /// <summary>
    ///   <br />
    /// </summary>
    class Pig : Animal
    {
        /// <summary>Animals the sound.</summary>
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
}
