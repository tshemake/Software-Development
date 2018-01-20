using System;

/*
 * Переведи число 11001100 из двоичной системы счисления в
 * десятичную. В ответе запишите полученное десятичное число.
 * Основание системы счисления писать не нужно.
 */

namespace step_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} - {1}", "11001100", Convert.ToInt32("11001100", 2));
        }
    }
}
