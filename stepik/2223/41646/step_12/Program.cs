using System;

/*
 * В место для решения нужно вписать код, который поместит
 * значение из переменной "a" в переменную "x". 
 */

namespace step_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testA("1"));
        }

        private static string testA(string a)
        {
            string x = "";
            x = a;
            return x;
        }
    }
}
