﻿using System;

/*
 * Восьмеричная система счисления
 * Переведи число 123 из десятичной системы счисления в восьмеричную.
 * В ответе запишите полученное восьмеричное число. Основание системы
 * счисления писать не нужно.
 */
 
namespace step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} - {1}", 123, Convert.ToString(123, 8));
        }
    }
}
