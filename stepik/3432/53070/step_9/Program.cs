using System;

/*
 * In this task, you need to build the variable a to the power of
 * b and return from the function the remainder of the division
 * resulted value by 3.
 * Sample Input:
 *
 *  2 6
 * Sample Output:
 *
 *  1
 */

namespace step_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testMath(2, 6));
        }

        private static double testMath(double a, double b)
        {
            return Math.Pow(a, b) % 3;
        }
    }
}
