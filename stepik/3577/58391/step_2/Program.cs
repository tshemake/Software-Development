using System;

/*
 * Повторим двоичную систему счисления
 * Переведи число 216 из десятичной системы счисления в двоичную.
 * В ответе запишите полученное двоичное число. Основание системы
 * счисления писать не нужно.
 */

namespace step_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} - {1}", 216, Convert.ToString(216, 2));
        }
    }
}
