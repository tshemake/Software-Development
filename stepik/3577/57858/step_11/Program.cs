using System;

/*
 * Переведите число 307 из восьмеричной системы счисления в
 * двоичную. Запишите ответ в двоичной системе счисления. Основание
 * системы счисления писать не нужно.
 */

namespace step_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} - {1}", "307", Convert.ToString(Convert.ToInt32("307", 8), 2));
        }
    }
}
