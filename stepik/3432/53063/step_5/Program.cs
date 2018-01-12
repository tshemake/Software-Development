using System;

/*
 * In this task, you need to write in the specified place the code
 * that will assign the value of the sum of the variables "a" and "b"
 * to the variable "x" in case a > b, the difference "a" and "b" if
 * a < b and their doubled product in other cases.
 * Sample Input:
 *
 *  0 5
 * Sample Output:
 *
 *  -5
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testIf(0, 5));
        }

        private static double testIf(double a, double b)
        {
            double x;
            if (a > b)
            {
                x = a + b;
            }
            else if (a < b)
            {
                x = a - b;
            }
            else
            {
                x = a * b;
            }
            return x;
        }
    }
}
