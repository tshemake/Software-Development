using System;

/*
 * А тут вам нужно вычислить и вернуть из функции площадь
 * треугольника. Передаваемые в функцию аргументы "a" и "b" -
 * это длины сторон, а "c" - это угол между ними в градусах.
 *
 * Sample Input:
 *
 *  2 10 16
 * Sample Output:
 *
 *  2.7563735581699915
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testMath(2, 10, 16));
        }

        private static double testMath(int a, int b, int c)
        {
            return 1 * a * b * Math.Sin((Math.PI / 180) * c) / 2;
        }
    }
}
