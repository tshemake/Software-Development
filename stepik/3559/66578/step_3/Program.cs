using System;
using System.Numerics;

/*
 * Вычислите значение выражения в интерактивном интерпретаторе языка
 * программирования Питон:
 * 999888777666555444333222111 - 111222333444555666777888999
 */

namespace step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BigInteger.Parse("999888777666555444333222111") - BigInteger.Parse("111222333444555666777888999"));
        }
    }
}
