using System;

/*
 * В этом задании в нашу функцию передается угол в градусах.
 * Вам нужно вернуть из функции значение его синуса. Не забывайте,
 * что тригонометрические функции в JavaScript принимают аргументы
 * только в радианах!
 *
 * Sample Input:
 *
 * 348
 * Sample Output:
 *
 * -0.20791169081775987
 */

namespace step_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testMath(348));
        }

        private static double testMath(int a)
        {
            return Math.Sin((Math.PI / 180) * a);
        }
    }
}
