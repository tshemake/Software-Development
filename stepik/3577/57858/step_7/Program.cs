using System;

/*
 * Переведи число 231 из восьмеричной системы счисления в десятичную.
 * В ответе запишите полученное десятичное число. Основание системы
 * счисления писать не нужно.
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} - {1}", "231", Convert.ToInt32("231", 8));
        }
    }
}
