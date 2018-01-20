using System;
using System.Numerics;

/*
 * Вычислите значение выражения в интерактивном интерпретаторе языка
 * программирования Питон:
 * 12345678987654321 + 98765432123456789
 */

namespace step_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BigInteger.Parse("12345678987654321") + BigInteger.Parse("98765432123456789"));
        }
    }
}
