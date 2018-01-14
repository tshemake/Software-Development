using System;

/*
 * С помощью каких команд можно активировать режим noclobber?
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("set -C");
            Console.WriteLine("set -o noclobber");
        }
    }
}
