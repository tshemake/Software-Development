using System;

/*
 * Какие команды позволяют завершить работу с редактором vi с
 * сохранением данных (внесенных изменений)?
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("сначала :w, потом :q");
            Console.WriteLine("ZZ");
            Console.WriteLine(":wq");
        }
    }
}
