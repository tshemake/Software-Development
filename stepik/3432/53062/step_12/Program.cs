using System;

/*
 * In this task, you need to write in the specified place the code
 * that will assign to the variable "x" the triple value of the
 * remainder of the division of the product of the variables "a" and
 * "b" by their sum.
 * Sample Input:
 *
 *  1 1
 * Sample Output:
 *
 *  3
 */

namespace step_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testOperation(1, 1));
        }

        private static double testOperation(double a, double b)
        {
            double x;
            x = (a * b % (a + b)) * 3;
            return x;
        }
    }
}
