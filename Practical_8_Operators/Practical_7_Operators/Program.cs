using System;

/// <summary>
///   <br />
/// </summary>
public class Program
{

    /// <summary>Emis the calculator.</summary>
    /// <param name="p">The p.</param>
    /// <param name="r">The r.</param>
    /// <param name="t">The t.</param>
    /// <returns>
    ///   <br />
    /// </returns>
    static float emi_calculator(float p,
                        float r, float t)
    {
        float emi;

        r = r / (12 * 100); 
        t = t * 12; 
        emi = (p * r * (float)Math.Pow(1 + r, t))
            / (float)(Math.Pow(1 + r, t) - 1);

        return (emi);
    }

    /// <summary>Defines the entry point of the application.</summary>
    static public void Main()
    {
        float principal, rate, time, emi;
        principal = 10000;
        rate = 10;
        time = 2;

        emi = emi_calculator(principal, rate, time);

        Console.WriteLine("Monthly EMI is = " + emi);
    }
}

