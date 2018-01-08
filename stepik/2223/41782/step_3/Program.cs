using System;

/*
 * В этом задании вам нужно вписать в указанное место код,
 * который будет присваивать переменной "х" значение суммы
 * переменных "a" и "b" в случае если  a > b или их произведение
 * в остальных случаях.
 */

namespace step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testIf(3, 7));
        }

        private static double testIf(double a, double b)
        {
            double x;
            x = (a > b) ? a + b : a * b;
            return x;
        }
    }
}
