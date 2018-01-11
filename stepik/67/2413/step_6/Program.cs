using System;

/*
 * Расставьте скобки в выражении 
 *
 * a and b or not a and not b
 *
 * в соответствии с порядком вычисления выражения(приоритетом
 * операций). Всего потребуется 5 пар скобок (внешние скобки входят
 * в их число).
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("((a and b) or ((not a) and (not b)))");
        }
    }
}
