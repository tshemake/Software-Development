using System;
using System.Numerics;

/*
 * Вычислите в python значение выражения
 * 9**19 - int(float(9**19))
 *
 * Заметьте, что используется одно и то же число, но результат
 * получается не нулевой. Это показывает различие хранения
 * большого числа в целочисленном типе и типе с плавающей точкой.
 */

namespace step_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Pow(9, 19) - Math.Pow(9, 19));
            Console.WriteLine(BigInteger.Pow(9, 19) - BigInteger.Pow(9, 19));
            Console.WriteLine(89);
        }
    }
}
