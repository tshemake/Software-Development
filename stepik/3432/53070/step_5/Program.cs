using System;

/*
 * And then you need to calculate and return the area of the
 * triangle from the function. The arguments "a" and "b" passed
 * to the function are the lengths of the sides, and "c" is the
 * angle between them in degrees.
 * Sample Input:
 *
 *  10 8 29
 * Sample Output:
 *
 *  19.392384809853482
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testMath(10, 8, 29));
        }

        private static double testMath(int a, int b, int c)
        {
            return 1 * a * b * Math.Sin((Math.PI / 180) * c) / 2;
        }
    }
}
