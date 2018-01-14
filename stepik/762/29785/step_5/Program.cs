using System;

/*
 * Найти все директории, соответствующие шаблону 'foo*':
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("find / -type d -name 'foo*'");
        }
    }
}
