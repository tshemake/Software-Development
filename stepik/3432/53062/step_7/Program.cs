using System;

/*
 * In this task, you need to enter the code in the specified
 * location that will assign the value of the doubled sum of the
 * variables "a" and "b" to the variable "x."
 *
 * The Sample Input and Sample Output shown below is an example.
 * They show that for the values of the variables "a" and "b" as in
 * Sample Input, for example, 2 and 8, your result should be as
 * specified in Sample Output. For example, if Sample Input is 2 and 8,
 * then Sample Output should be 20, i.e. doubled sum of the first and
 * second variables.
 * Sample Input:
 *
 *  1 1
 * Sample Output:
 *
 *  4
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testSum(1, 1));
        }

        private static double testSum(double a, double b)
        {
            double x;
            x = 2 * (a + b);
            return x;
        }
    }
}
