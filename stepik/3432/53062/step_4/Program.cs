using System;

/*
 * Compare the simplest operations indicated in the left column
 * with the results of their calculations, given in the right. The
 * initial values are x = 6 and y = 3;
 */

namespace step_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x=y; x = 3; y = 3;");
            Console.WriteLine("x = x + y; x = 9; y = 3;");
            Console.WriteLine("x = y - x; x = -3; y = 3;");
            Console.WriteLine("x = x * y; x = 18; y = 3;");
            Console.WriteLine("x = x % y; x = 0; y = 3;");
            Console.WriteLine("x = x / y; x = 2; y = 3;");
            Console.WriteLine("x = ++y; x = 4; y = 4;");
            Console.WriteLine("x = y++; x = 3; y = 4;");
            Console.WriteLine("x = --y; x = 2; y = 2;");
            Console.WriteLine("x = y--; x = 3; y = 2;");
        }
    }
}
