using System;

/*
 * Сопоставьте числа в восьмеричной и двоичной системах счисления
 * (первый столбик - запись числа в восьмеричной системе счисления,
 * второй - запись числа в двоичной системе счисления).
 */

namespace step_8
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= Convert.ToInt32("7", 8); i++)
            {
                Console.WriteLine("{0} - {1}", Convert.ToString(i, 8), Convert.ToString(i, 2));
            }
        }
    }
}
