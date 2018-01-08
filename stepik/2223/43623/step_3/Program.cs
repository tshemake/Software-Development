using System;

/*
 * В этом задании в нашу функцию testStr передаются две строки.
 * Вам нужно вернуть из функции их суммарную длину.
 *
 * Sample Input:
 *
 * 5794675 181683
 * Sample Output:
 *
 * 13
 */

namespace step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testStr("5794675", "181683"));
        }

        private static double testStr(string a, string b)
        {
            return a.Length + b.Length;
        }
    }
}
