using System;

/*
 * Найдите сумму двоичных чисел 111101 + 1011100. В ответе запишите
 * двоичное число. Основание системы счисления писать не нужно.
 */

namespace step_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "111101";
            string b = "1011100";
            Console.WriteLine("{0} + {1} = {2}", a, b, Convert.ToString(Convert.ToInt32(a, 2) + Convert.ToInt32(b, 2), 2));
        }
    }
}
