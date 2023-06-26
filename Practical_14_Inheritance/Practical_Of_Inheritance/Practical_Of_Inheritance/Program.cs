using System;



/*
 * Test hybrid inheritance
 */

namespace Practical_Of_Inheritance_5
{

    /// <summary>
    ///   <br />
    /// </summary>
    public class TestHybridInheritance
    {

        /// <summary>Mains the specified arguments.</summary>
        /// <param name="args">The arguments.</param>
        public static void Main(String[] args)
        {

            // Son object
            Son s = new Son();
            s.land();// Grand father method
            s.Car(); // Father method
            s.home();// Father method
            s.mobile();// son method

            // Daughter object
            Daughter d = new Daughter();
            d.land();// Grand father method
            d.Car(); // Father method
            d.home();// Father method
            d.purse();// daughter method

        }

    }

}