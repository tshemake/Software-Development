using System;

/*
 * В этом задании в нашу функцию testStr передаются две строки.
 * Вам нужно вернуть индекс позиции, с которой начинается вхождение
 * второй строки в первую.
 *
 * Sample Input:
 *
 *  This is a test string
 *  test
 * Sample Output:
 *
 *  10
 */

namespace step_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testStr("This is a test string", "test"));
        }

        private static int testStr(string a, string b)
        {
            return a.IndexOf(b);
        }
    }
}
