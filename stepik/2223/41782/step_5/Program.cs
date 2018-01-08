using System;

/*
 * В этом задании вам нужно вписать в указанное место код,
 * который будет присваивать переменной "х" значение суммы
 * переменных "a" и "b" - в случае если  a < b, разность "a" и
 * "b" - в случае если  a > b, и их произведение  в остальных случаях.
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testIf(9, 9));
        }

        private static double testIf(double a, double b)
        {
            double x;
            if (a < b)
            {
                x = a + b;
            }
            else if (a > b)
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
