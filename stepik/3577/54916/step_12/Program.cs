using System;

/*
 * Найдите разность двоичных чисел 10011111 - 1010100. В ответе
 * запишите двоичное число. Основание системы счисления писать не
 * нужно.
 */

namespace step_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "10011111";
            string b = "1010100";
            Console.WriteLine("{0} - {1} = {2}", a, b, Convert.ToString(Convert.ToInt32(a, 2) - Convert.ToInt32(b, 2), 2));
        }
    }
}
