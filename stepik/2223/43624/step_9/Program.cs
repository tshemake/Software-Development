using System;

/*
 * В этом задании вам необходимо выполнить возведение переменной a в
 * степень b и возврат значения из функции.
 *
 * Sample Input:
 *
 * 5 1
 * Sample Output:
 *
 * 5
 */

namespace step_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testMath(5, 1));
        }

        private static double testMath(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
