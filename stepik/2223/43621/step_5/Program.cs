using System;

/*
 * В этом задании в нашу функцию testArray передаются два массива
 * случайной длины заполненные случайными числами. Вам нужно сосчитать
 * сумму всех элементов обоих массивов и возвратить ее из функции.
 *
 * Sample Input:
 *
 *  [8, 1, 1, 7, 4, 0]  [5, 8, 5, 4, 8]
 * Sample Output:
 *
 *  51
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testArray(new double[] { 8, 1, 1, 7, 4, 0 },
                                        new double[] { 5, 8, 5, 4, 8 }));
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
            return sum;
        }
    }
}
