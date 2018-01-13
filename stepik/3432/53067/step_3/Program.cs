using System;

/*
 * In this task, two lines are passed to our testStr function.
 * You need to return from the function their total length.
 * Sample Input:
 *
 *  498859 649838
 * Sample Output:
 *
 *  12
 */

namespace step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testStr("498859", "649838"));
        }

        private static double testStr(string a, string b)
        {
            return a.Length + b.Length;
        }
    }
}
