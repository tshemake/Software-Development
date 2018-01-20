using System;

/*
 * Переведите число BF из шестнадцатеричной системы счисления в
 * двоичную. Запишите ответ в двоичной системе счисления. Основание
 * системы счисления писать не нужно.
 */

namespace step_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:X} - {1}", 0xBF, Convert.ToString(0xBF, 2));
        }
    }
}
