using System;

/*
 * Числу, записанному в десятичной системе счисления, впишите
 * соответствующее число, записанное в двоичной системе счисления.
 */

namespace step_4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 11; i <= 20; i++)
            {
                Console.WriteLine("{0} - {1}", i, Convert.ToString(i, 2));
            }
        }
    }
}
