using System;

/*
 * В этом задании в нашу функцию testStr передаются две строки.
 * Вам нужно вернуть из функции строку, которая будет включать в
 * себя обе этих строки, преобразовав в первой строке все буквы в
 * заглавные, а во второй - в строчные.
 *
 * Sample Input:
 *
 *  Hello World!
 * Sample Output:
 *
 *  HELLOworld!
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
            return a.ToUpper() + b.ToLower();
        }
    }
}
