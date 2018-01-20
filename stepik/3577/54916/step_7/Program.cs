using System;

/*
 * Переведи число 109 из десятичной системы счисления в двоичную.
 * В ответе запишите полученное двоичное число. Основание системы
 * счисления писать не нужно.
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} - {1}", 109, Convert.ToString(109, 2));
        }
    }
}
