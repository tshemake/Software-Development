using System;
using System.Numerics;

/*
 * Вычислите значение выражения в интерактивном интерпретаторе языка
 * программирования Питон:
 * 77777777777777777 * 77777777777777777
 */

namespace step_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BigInteger.Parse("77777777777777777") * BigInteger.Parse("77777777777777777"));
        }
    }
}
