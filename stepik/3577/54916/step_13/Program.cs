using System;

/*
 * Найдите разность двоичных чисел 10101010 - 1001110. В ответе
 * запишите двоичное число. Основание системы счисления писать не
 * нужно.
 */

namespace step_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "10101010";
            string b = "1001110";
            Console.WriteLine("{0} - {1} = {2}", a, b, Convert.ToString(Convert.ToInt32(a, 2) - Convert.ToInt32(b, 2), 2));
        }
    }
}
