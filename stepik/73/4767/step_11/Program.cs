using System;

/*
 * Что произойдет, если в команде
 * sed -n "/[a-z]*&sol;p" text.txt не указывать опцию -n?
 */

namespace step_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Что произойдет, если в команде sed -n \"/[a-z]*/p\" text.txt не указывать опцию -n?");
        }
    }
}