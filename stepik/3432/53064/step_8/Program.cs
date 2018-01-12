using System;

/*
 * In this task, you need to calculate the sum of all the odd
 * numbers occurring in a row from 1 to the number (inclusive) that
 * is passed to our function (variable "a").
 *
 * Sample Input:
 *
 *  7
 * Sample Output:
 *
 *  16
 */

namespace step_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testWhile(7));
        }

        private static double testWhile(double a)
        {
            double x = 0;
            while (a > 0)
            {
                if (a % 2 != 0)
                {
                    x += a;
                }
                a--;
            }
            return x;
        }
    }
}
