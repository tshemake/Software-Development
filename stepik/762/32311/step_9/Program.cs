using System;

/*
 * Сопоставьте тип файла и соответствующий ему символ в выводе ls -l
 */

namespace step_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("b - Блочное устройство");
            Console.WriteLine("l - Символьная ссылка");
            Console.WriteLine("p - Именованный канал");
            Console.WriteLine("c - Символьное устройство");
            Console.WriteLine("s - Сокет");
            Console.WriteLine("- - Обычный файл");
            Console.WriteLine("d - Директория");
        }
    }
}
