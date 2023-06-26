using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// </summary>
namespace Interface_Example
{
    /// <summary>
    ///   <br />
    /// </summary>
    class Rectangle : IPolygon, IColor
    {

        /// <summary>Calculates the area.</summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        public void calculateArea(int a, int b)
        {

            int area = a * b;
            Console.WriteLine("Area of Rectangle: " + area);
        }

        /// <summary>Gets the color.</summary>
        public void getColor()
        {

            Console.WriteLine("Red Rectangle");

        }
    }
}
