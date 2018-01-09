using System;

/*
 * Практическое задание: работа с директориями
 * 1. Создайте директорию testdir в вашей домашней директории.
 * 2. Создайте с помощью одной команды директории ~/dir1/dir2/dir3
 * (директория dir3 является поддиректорией директории dir2, а
 * директория dir2 - поддиректорией директории dir1).
 * 3. Создайте в dir2 директорию dir4, а в dir4 директорию dir5.
 * Попробуйте это сделать одной командой.
 */

namespace step_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mkdir testdir");
            Console.WriteLine("mkdir -p dir1/dir2/dir3");
            Console.WriteLine("mkdir -p dir1/dir2/dir4/dir5");
        }
    }
}
