using System;

/*
 * In this task, you need to calculate the factorial for the number
 * passed to our function and return it doubled value. Just in case,
 * we recall that the factorial of a is the product of all integers
 * from 1 to a, for example, if a = 5, then the factorial a is equal to
 * 1 * 2 * 3 * 4 * 5
 * Sample Input 1:
 *
 *  8
 * Sample Output 1:
 *
 *  80640
 * Sample Input 2:
 *
 *  0
 * Sample Output 2:
 *
 *  2
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testFactorial(8));
            Console.WriteLine(testFactorial(0));
        }

        private static double testFactorial(int a)
        {
            double x = 1;
            for (int i = 1; i <= a; i++)
            {
                x *= i;
            }
            return 2 * x;
        }
    }
}
