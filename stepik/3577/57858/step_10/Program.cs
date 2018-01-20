using System;

/*
 * Переведите число 1000000 из двоичной системы счисления в
 * восьмеричную. Запишите ответ в восьмеричной системе счисления.
 * Основание системы счисления писать не нужно.
 */

namespace step_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} - {1}", "1000000", Convert.ToString(Convert.ToInt32("1000000", 2), 8));
        }
    }
}
