using System;

/*
 * Вычислите значение выражения в интерактивном интерпретаторе языка
 * программирования Питон:
 * 241.90263432641407 / 77
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:#.000000000000000}", Decimal.Parse("241.90263432641407") / 77);
        }
    }
}
