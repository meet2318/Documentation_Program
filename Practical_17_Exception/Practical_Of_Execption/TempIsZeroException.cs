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
    public class TempIsZeroException : Exception
    {
        /// <summary>Initializes a new instance of the <see cref="TempIsZeroException" /> class.</summary>
        /// <param name="message">The message that describes the error.</param>
        public TempIsZeroException(string message) : base(message)
        {

        }
    }

}
