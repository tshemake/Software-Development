using System;

/*
 * In this test, you need to map variable declarations and their type.
 */

namespace step_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("var x; The variable x is undefined type");
            Console.WriteLine("var x = 5; The variable x is number");
            Console.WriteLine("var y = '5'; The variable y is string");
            Console.WriteLine("var z = \"5\"; The variable z is string");
            Console.WriteLine("var x = true; The variable x is boolean");
            Console.WriteLine("var x = 'true'; The variable x is string");
            Console.WriteLine("var y = 0; The variable y is number");
            Console.WriteLine("var y = false; The variable y is boolean");
            Console.WriteLine("var z = 5; The variable z is number");
        }
    }
}
