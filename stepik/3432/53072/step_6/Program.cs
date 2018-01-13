using System;

/*
 * Mark the expressions that match the lines or substrings.
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/\\d/ for string \"123qwerty456\"");
            Console.WriteLine("/[^qwerty]/ for string \"123qwerty456\"");
            Console.WriteLine("/[4-6]/ for string \"123qwerty456\"");
            Console.WriteLine("/q/ for string \"qwerty\"");
            Console.WriteLine("/qwerty/ for string \"123qwerty456\"");
            Console.WriteLine("/qwerty/ for string \"qwerty\"");
        }
    }
}
