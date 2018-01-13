using System;

/*
 * In this task, two lines are passed to our testStr function.
 * You need to return the position index, from which the entry of
 * the second line in the first begins.
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
