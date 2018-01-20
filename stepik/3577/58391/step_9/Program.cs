using System;

/*
 * Сопоставьте числа в шестнадцатеричной и двоичной системах
 * счисления (первый столбик - запись числа в шестнадцатеричной
 * системе счисления, второй - запись числа в двоичной системе
 * счисления).
 */

namespace step_9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0x0; i <= 0x7; i++)
            {
                Console.WriteLine("{0:X} - {1}", i, Convert.ToString(i, 2));
            }
        }
    }
}
