using System;

/*
 * Предположим, что в файле  text.txt записаны строки, показанные
 * среди вариантов ответа. Отметьте только те из них, которые
 * выведет на экран команда  grep "world" text.txt.
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The world is not enough");
            Console.WriteLine("The \"world\" is not enough");
            Console.WriteLine("world");
            Console.WriteLine("The beautifulworld is not enough");
            Console.WriteLine("The beautiful-world is not enough");
        }
    }
}