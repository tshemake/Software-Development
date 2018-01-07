using System;

/*
 * Задание на понимание работы опций -path и -name команды find.
 * Отметьте все верные утверждения из перечисленных ниже.
 */

namespace step_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("В некоторых случаях find с -name найдет больше файлов, чем find с таким же запросом, но с -path");
            Console.WriteLine("В некоторых случаях find с -name найдет меньше файлов, чем find с таким же запросом, но с -path");
        }
    }
}
