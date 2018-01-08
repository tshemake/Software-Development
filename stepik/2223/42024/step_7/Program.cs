using System;

/*
 * В этом задании вам нужно вписать в указанное место код,
 * который будет присваивать переменной "х" значение суммы
 * переменных "a" и "b".
 *
 * Указанные ниже Sample Input (образец входных данных) и Sample
 * Output (образец выходных данных) - это пример. Они показывают,
 * что при значениях переменных "a" и "b" как в Sample Input,
 * например 2 и 8, ваш результат должен быть такой, как указано в
 * Sample Output. Например, если Sample Input - 2 и 8, то Sample
 * Output должен быть 10, т.е. сумма первой и второй переменных.
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testSum(2, 8));
        }

        private static double testSum(double a, double b)
        {
            double x;
            x = a + b;
            return x;
        }
    }
}
