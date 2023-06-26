using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// </summary>
namespace Practical_Of_Execption
{
    /// <summary>
    ///   <br />
    /// </summary>
    public class Temperature
    {
        /// <summary>The temperature</summary>
        int temperature = 15;

        /// <summary>Shows the temporary.</summary>
        /// <exception cref="Practical_Of_Execption.TempIsZeroException">Do Not Devide By Zero</exception>
        public void showTemp()
        {

            if (temperature == 0)
            {
                throw (new TempIsZeroException("Do Not Devide By Zero"));
            }
            else
            {
                Console.WriteLine("Temperature: {0}", temperature);
            }
        }

    }
}
