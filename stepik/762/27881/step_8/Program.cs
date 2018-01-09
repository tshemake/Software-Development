using System;

/*
 * Напишите команду для создания структуры директорий
 * /home/box/foo/bar/baz, если вы находитесь в домашней
 * директории (/home/box).
 */

namespace step_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mkdir -p foo/bar/baz");
        }
    }
}
