using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// </summary>
namespace Practical_Of_Abstration
{
    /// <summary>
    ///   <br />
    /// </summary>
    abstract class Animal
    {
        // Abstract method (does not have a body)
        /// <summary>Animals the sound.</summary>
        public abstract void animalSound();
        // Regular method
        /// <summary>Sleeps this instance.</summary>
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

}
