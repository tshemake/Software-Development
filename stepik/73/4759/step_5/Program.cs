using System;

/*
 * Какие (какая) из команд создадут файл file.txt и запишут
 * в него поток ошибок программы program? Считайте, что в момент
 * запуска программы файл file.txt не существует.
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program 2> file.txt");
            Console.WriteLine("program 2>> file.txt");
        }
    }
}