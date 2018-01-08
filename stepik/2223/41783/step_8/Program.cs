using System;

/*
 * В этом задании вам нужно вычислить сумму всех четных чисел,
 * встречающихся в ряду от 1 до числа (включительно), передаваемого
 * в нашу функцию (переменная "а").
 */

namespace step_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testWhile(3));
        }

        private static double testWhile(double a)
        {
            double x = 0;
            while (a > 0)
            {
                if (a % 2 == 0)
                {
                    x += a;
                }
                a--;
            }
            return x;
        }
    }
}
