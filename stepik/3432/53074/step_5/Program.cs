using System;

/*
 * For starters - a small test!
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A closure stores a reference to variables that are in a function external to it");
            Console.WriteLine("If inside the normal function, nested in another function, make a call to the input parameter of the external function, then it will be called the closure");
            Console.WriteLine("If inside the normal function, nested in another function, make a call to a variable in the external function, then it will be called the closure");
        }
    }
}
