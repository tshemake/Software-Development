using System;

/*
 * So, let's try! In the place for the solution, you need to enter
 the code that will put the value from the variable "a" in the
 variable "x".
 *
 * It is necessary to pay attention to a frequent error: the
 * variable "a" is already described in the first line, and you do
 * not need to declare it again. Also, you do not need to put any
 * values into it - they are already there!
 *
 * Sample Input:
 *
 * 9
 * Sample Output:
 *
 * 9
 */

namespace step_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testA("9"));
        }

        private static string testA(string a)
        {
            string x = "";
            x = a;
            return x;
        }
    }
}
