using System;

/*
 * В этом задании вам нужно вписать в указанное место код,
 * который будет присваивать переменной "х" удвоенное значение
 * остатка от деления произведения переменных "a" и "b" на их сумму.
 */

namespace step_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testOperation(6, 4));
        }

        private static double testOperation(double a, double b)
        {
            double x;
            x = (a * b % (a + b)) * 2;
            return x;
        }
    }
}
