using System;

/*
 * Отметьте выражения, которые будут соответствовать строкам или
 * подстрокам.
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/[^qwerty]/ для строки \"123qwerty456\"");
            Console.WriteLine("/\\d/ для строки \"123qwerty456\"");
            Console.WriteLine("/qwerty/ для строки \"123qwerty456\"");
            Console.WriteLine("/qwerty/ для строки \"qwerty\"");
            Console.WriteLine("/\\w/ для строки \"qwerty\"");
        }
    }
}
