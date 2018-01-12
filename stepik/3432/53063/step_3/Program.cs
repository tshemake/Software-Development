using System;

/*
 * In this task, you need to write in the specified place the code
 * that will assign the value of the sum of the variables "a" and "b"
 * to the variable "x" if a< b or their product in other cases.
 * Sample Input:
 *
 *  9 4
 * Sample Output:
 *
 *  36
 */

namespace step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testIf(9, 4));
        }

        private static double testIf(double a, double b)
        {
            double x;
            x = (a < b) ? a + b : a * b;
            return x;
        }
    }
}
