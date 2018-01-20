using System;

/*
 * Переведи число 11011111 из двоичной системы счисления в
 * десятичную. В ответе запишите полученное десятичное число.
 * Основание системы счисления писать не нужно.
 */

namespace step_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} - {1}", "11011111", Convert.ToInt32("11011111", 2));
        }
    }
}
