using System;

/*
 * In this task, two lines are passed to our testStr function.
 * You need to return a string from the function that will include
 * both of these lines, converting all the letters to lowercase in
 * the first line, and to capital letters in the second.
 * Sample Input:
 *
 *  Hello World!
 * Sample Output:
 *
 *  helloWORLD!
 */

namespace step_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testStr("Hello", "World!"));
        }

        private static string testStr(string a, string b)
        {
            return a.ToLower() + b.ToUpper();
        }
    }
}
