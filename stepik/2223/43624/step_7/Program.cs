using System;
using System.Linq;

/*
 * В этом задании в нашу функцию передаются 4 числа. Вам необходимо
 * вычислить результат деления большего из этих чисел на меньшее, и
 * округлив до ближайшего меньшего целого вернуть из функции.
 *
 * Sample Input:
 *
 *  1 4 8 8
 * Sample Output:
 *
 *  8
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testMath(1, 4, 8, 8));
        }

        private static double testMath(double a, double b, double c, double d)
        {
            double[] array = { a, b, c, d };
            double max = array.Max();
            double min = array.Min();
            return Math.Floor(max / min);
        }
    }
}
