using System;

/*
 * Переведите число 111001 из двоичной системы счисления в
 * восьмеричную. Запишите ответ в восьмеричной системе счисления.
 * Основание системы счисления писать не нужно
 */

namespace step_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} - {1}", "111001", Convert.ToString(Convert.ToInt32("111001", 2), 8));
        }
    }
}
