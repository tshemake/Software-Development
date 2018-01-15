using System;

/*
 * Напишите пожалуйста в двоичной системе счисления числа с 8 по 15
 */

namespace step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 8;
            int max = 15;
            for (int value = min; value <= max; value++)
            {
                Console.WriteLine(Convert.ToString(value, 2));
            }
        }
    }
}
