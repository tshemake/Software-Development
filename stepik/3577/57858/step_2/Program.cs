using System;

/*
 * Повторим двоичную систему счисления
 * Переведи число 152 из десятичной системы счисления в двоичную.
 * В ответе запишите полученное двоичное число. Основание системы
 * счисления писать не нужно.
 */

namespace step_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} - {1}", 152, Convert.ToString(152, 2));
        }
    }
}
