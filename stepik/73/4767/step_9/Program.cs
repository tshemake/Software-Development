using System;

/*
 * Предположим, что в файле  text.txt записаны строки, показанные
 * среди вариантов ответа. Отметьте только те из них, которые выведет
 * на экран команда  grep -E "[xklXKL]?[uU]buntu$" text.txt.
 */

namespace step_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lubuntu is better than Ubuntu");
            Console.WriteLine("Mac OS X, Windows, Ubuntu");
            Console.WriteLine("I prefer Kubuntu");
        }
    }
}
