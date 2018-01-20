using System;

/*
 * Переведи число 110 из десятичной системы счисления в восьмеричную.
 * В ответе запишите полученное восьмеричное число. Основание системы
 * счисления писать не нужно.
 */

namespace step_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} - {1}", 110, Convert.ToString(110, 8));
        }
    }
}
