using System;

/*
 * Найти все файлы, соответствующие шаблону '*.bar':
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("find / -type f -name '*.bar'");
        }
    }
}
