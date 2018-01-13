using System;

/*
 * In this task two random-length arrays filled with random numbers
 * are transferred to our testArray function. You need to calculate
 * the sum of all the elements of both arrays and return it squared
 * from the function.
 * Sample Input:
 *
 *  [3, 6, 8, 6, 3, 1, 1, 8]  [8, 7, 4, 1, 6, 3]
 * Sample Output:
 *
 *  4225
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testArray(new double[] { 3, 6, 8, 6, 3, 1, 1, 8 },
                                        new double[] { 8, 7, 4, 1, 6, 3 }));
        }

        private static double testArray(double[] a, double[] b)
        {
            double sum = 0;
            foreach (double i in a)
            {
                sum += i;
            }
            foreach (double i in b)
            {
                sum += i;
            }
            return sum * sum;
        }
    }
}
