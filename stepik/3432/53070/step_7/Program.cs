using System;
using System.Linq;

/*
 * In this task, 4 numbers are transferred to our procedure. You
 * need to calculate the result of dividing the larger of these
 * numbers by less, and rounding to the nearest largest integer
 * return from the function
 * Sample Input:
 *
 *  10 3 8 1
 * Sample Output:
 *
 *  10
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testMath(10, 3, 8, 1));
        }

        private static double testMath(double a, double b, double c, double d)
        {
            double[] array = { a, b, c, d };
            double max = array.Max();
            double min = array.Min();
            return Math.Ceiling(max / min);
        }
    }
}
