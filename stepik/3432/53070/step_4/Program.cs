using System;

/*
 * In this task, an angle in degrees is transmitted to our function.
 * You need to return from the function the value of its sine. Do not
 * forget that trigonometric functions in JavaScript accept arguments
 * only in radians!
 * Sample Input:
 *
 * 193
 * Sample Output:
 *
 * -0.22495105434386498
 */

namespace step_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testMath(193));
        }

        private static double testMath(int a)
        {
            return Math.Sin((Math.PI / 180) * a);
        }
    }
}
