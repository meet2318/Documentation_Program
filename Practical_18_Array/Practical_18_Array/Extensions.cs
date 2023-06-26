using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// </summary>
namespace Practical_18_Array
{
    /// <summary>
    ///   <br />
    /// </summary>
    public static class Extensions
    {
        /// <summary>Finds the index.</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array.</param>
        /// <param name="item">The item.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public static int findIndex<T>(this T[] array, T item)
        {
            return Array.IndexOf(array, item);
        }
    }

}
