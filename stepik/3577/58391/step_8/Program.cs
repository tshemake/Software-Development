using System;

/*
 * Переведи число E8 из шестнадцатеричной системы счисления в десятичную. В ответе
 * запишите полученное шестнадцатеричное число. Основание системы счисления писать не нужно.
 */

namespace step_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:X} {0}", 0xE8);
        }
    }
}
