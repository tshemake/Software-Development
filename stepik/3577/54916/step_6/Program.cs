using System;

/*
 * Переведи число 112 из десятичной системы счисления в двоичную.
 * В ответе запишите полученное двоичное число. Основание системы
 * счисления писать не нужно.
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} - {1}", 112, Convert.ToString(112, 2));
        }
    }
}
